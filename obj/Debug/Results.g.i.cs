﻿#pragma checksum "C:\Users\pjbeaton\Documents\Visual Studio 2010\Projects\DailyCalories\DailyCalories\Results.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "76A3767803C318924AACA41DF1AEC0A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Advertising.Mobile.UI;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace DailyCalories {
    
    
    public partial class Results : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Telerik.Windows.Controls.RadListPicker radListGoal;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl adControl1;
        
        internal System.Windows.Controls.TextBlock txtCalorieConsumption;
        
        internal System.Windows.Controls.TextBlock txtCalorieGoals;
        
        internal System.Windows.Controls.TextBlock txtDisclaimer;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/DailyCalories;component/Results.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.radListGoal = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("radListGoal")));
            this.adControl1 = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("adControl1")));
            this.txtCalorieConsumption = ((System.Windows.Controls.TextBlock)(this.FindName("txtCalorieConsumption")));
            this.txtCalorieGoals = ((System.Windows.Controls.TextBlock)(this.FindName("txtCalorieGoals")));
            this.txtDisclaimer = ((System.Windows.Controls.TextBlock)(this.FindName("txtDisclaimer")));
        }
    }
}

