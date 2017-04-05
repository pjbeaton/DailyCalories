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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            List<string> activity = new List<string>
            {
                "Little or no exercise, desk job",
                "Light exercise 1-3 days/week",
                "Moderate exercise 3-5 days/week",
                "Hard exercise 6-7 days/week",
                "Hard daily exercise and physical job"
            };

            radListLifestyle.ItemsSource = activity;
            radListLifestyle.SelectedIndex = 0;

            List<string> current = new List<string>
            {
                "Gaining about a pound a week",
                "Gaining about a pound a month",
                "Maintaining current body weight",
                "Losing about a pound a month",
                "Losing about a pound a week"
            };

            radListCurrent.ItemsSource = current;
            radListCurrent.SelectedIndex = 2;

            radMale.IsChecked = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (txtAge.Text == "" || txtAge.Text.Contains("."))
            {
                MessageBox.Show("Please enter your current age with no decimal point to calculate your daily calories consumed");
            }
            else
            {
                if (txtWeight.Text == "" || txtWeight.Text.Contains("."))
                {
                    MessageBox.Show("Please enter your current weight with no decimal point to calculate your daily calories consumed");
                }
                else
                {
                    if (txtFeet.Text == "" || txtFeet.Text.Contains(".") || txtInches.Text == "" || txtInches.Text.Contains("."))
                    {
                        MessageBox.Show("Please enter your height with no decimal point to calculate your daily calories consumed");
                    }
                    else
                    {
                        string uri = string.Format("/Results.xaml?age={0}&weight={1}&male={2}&female={3}&feet={4}&inches={5}&activity={6}&trend={7}",
                            txtAge.Text, txtWeight.Text, radMale.IsChecked, radFemale.IsChecked, txtFeet.Text, txtInches.Text, radListLifestyle.SelectedIndex.ToString(),
                            radListCurrent.SelectedIndex.ToString());

                        NavigationService.Navigate(new Uri(uri, UriKind.RelativeOrAbsolute));
                    }
                }
            }
        }
    }
}