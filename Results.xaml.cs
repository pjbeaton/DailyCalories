using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace DailyCalories
{
    public partial class Results : PhoneApplicationPage
    {
        public int weight { get; set; }
        public int age { get; set; }
        public int heightFeet { get; set; }
        public int heightInches { get; set; }
        public bool male { get; set; }
        public int activityLevel { get; set; }
        public int trendLevel { get; set; }
        public int goalLevel { get; set; }
        public int calories { get; set; }

        public Results()
        {
            InitializeComponent();

            weight = -1;
            age = -1;
            heightFeet = -1;
            heightInches = -1;
            male = true;
            activityLevel = -1;
            trendLevel = -1;
            goalLevel = -1;

            this.Loaded += new RoutedEventHandler(Results_Loaded);

        }

        void Results_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> goals = new List<string>
            {
                "Gain 2 pounds per week",
                "Gain 1 pound per week",
                "Maintain current body weight",
                "Lose 1 pound per week",
                "Lose 2 pounds per week"
            };

            radListGoal.ItemsSource = goals;
            radListGoal.SelectedIndex = 2;
            goalLevel = 2;

        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (e.NavigationMode == System.Windows.Navigation.NavigationMode.Back)
                NavigationService.GoBack();

            base.OnNavigatedTo(e);

            string weight = "";
            string age = "";
            string feet = "";
            string inches = ""; 
            string male = "";
            string activityLevel = "";
            string trendLevel = "";

            if (NavigationContext.QueryString.TryGetValue("weight", out weight))
                this.weight = int.Parse(weight);

            if (NavigationContext.QueryString.TryGetValue("age", out age))
                this.age = int.Parse(age); 

            if (NavigationContext.QueryString.TryGetValue("feet", out feet))
                this.heightFeet = int.Parse(feet); 

            if (NavigationContext.QueryString.TryGetValue("inches", out inches))
                this.heightInches = int.Parse(inches);

            if (NavigationContext.QueryString.TryGetValue("male", out male))
            {
                if (male == "True")
                    this.male = true;
                else
                    this.male = false;

            }

            if (NavigationContext.QueryString.TryGetValue("activity", out activityLevel))
            {
                this.activityLevel = int.Parse(activityLevel);
            }

            if (NavigationContext.QueryString.TryGetValue("trend", out trendLevel))
            {
                this.trendLevel = int.Parse(trendLevel);
            }

            SetCalorieConsumption();

            if (calories > 0)
            {
                txtCalorieConsumption.Text = string.Format("You are currently consuming an average of {0} calories per day.", calories.ToString());
            }
            else
            {
                MessageBox.Show("Oops, this is embarassing.  Please go back to the main screen and re-try your calculation.  If this continues, please email me at pjbeaton@hotmail.com.");
            } 
            
        }

        private bool isValid()
        {
            if (age > 0 && weight > 0 && heightInches > -1 && heightFeet > 0 && activityLevel > -1 && trendLevel > -1)
                return true;
            else
                return false;
        }

        private void SetCalorieConsumption()
        {
            int BMR = 0;
            if (isValid())
            {
                if (male == true)
                {
                    BMR = (int)(66 + (6.3 * weight) + (12.9 * (heightFeet*12 + heightInches)) - (6.8 * age));
                }
                else
                {
                    BMR = (int)(655 + (4.3 * weight) + (4.7 * (heightFeet*12 + heightInches)) - (4.7 * age));
                }

                calories = BMR + (BMR * (20 + (activityLevel * 10)) / 100);
                switch (trendLevel)
                {
                    case 0:
                        calories += 500;
                        break;
                    case 1:
                        calories += (3500 / 30);
                        break;
                    case 3:
                        calories -= (3500 / 30);
                        break;
                    case 4:
                        calories -= 500;
                        break;
                }

            }
            else
            {
                MessageBox.Show("Oops, this is embarassing.  Please go back to the main screen and re-try your calculation.  If this continues, please email me at pjbeaton@hotmail.com.");
            }
        }

        private void radListGoal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (radListGoal.SelectedIndex > -1)
            {
                goalLevel = radListGoal.SelectedIndex;

                int calorieGoal = GetCalorieGoal();

                if (calorieGoal > 0)
                {

                    txtCalorieGoals.Text = string.Format("To {0}, consume an average of {1} calories per day.", radListGoal.SelectedItem.ToString(), calorieGoal.ToString());
                }
                else
                {
                    MessageBox.Show("Oops, this is embarassing.  Please go back to the main screen and re-try your calculation.  If this continues, please email me at pjbeaton@hotmail.com.");
                }
            }
        }

        private int GetCalorieGoal()
        {
            int calorieGoal = 0;

            if (calories > 0)
            {
                calorieGoal = calories;

                switch (trendLevel)
                {
                    case 0:
                        calorieGoal -= 500;
                        break;
                    case 1:
                        calorieGoal -= (3500 / 30);
                        break;
                    case 3:
                        calorieGoal += (3500 / 30);
                        break;
                    case 4:
                        calorieGoal += 500;
                        break;
                }

                switch (goalLevel)
                {
                    case 0:
                        calorieGoal += 1000;
                        break;
                    case 1:
                        calorieGoal += 500;
                        break;
                    case 3:
                        calorieGoal -= 500;
                        break;
                    case 4:
                        calorieGoal -= 1000;
                        break;
                }
                return calorieGoal;
            }
            else
            {
                SetCalorieConsumption();
                return GetCalorieGoal();

                //MessageBox.Show("Oops, this is embarassing.  Please go back to the main screen and re-try your calculation.  If this continues, please email me at pjbeaton@hotmail.com.");
                //return -1;
            }
        }

    }
}