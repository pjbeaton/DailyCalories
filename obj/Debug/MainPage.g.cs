﻿#pragma checksum "C:\Users\pjbeaton\Documents\Visual Studio 2010\Projects\DailyCalories\DailyCalories\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D0E66E93B7574F73513AA77DD8797E10"
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
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.ProgressBar progressBar1;
        
        internal System.Windows.Controls.ScrollViewer MainScroll;
        
        internal System.Windows.Controls.StackPanel MainStackPanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.RadioButton radMale;
        
        internal System.Windows.Controls.RadioButton radFemale;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBox txtAge;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBox txtWeight;
        
        internal System.Windows.Controls.TextBlock textBlock3;
        
        internal System.Windows.Controls.TextBox txtFeet;
        
        internal System.Windows.Controls.TextBlock textBlock3_Copy;
        
        internal System.Windows.Controls.TextBox txtInches;
        
        internal System.Windows.Controls.TextBlock textBlock3_Copy1;
        
        internal Telerik.Windows.Controls.RadListPicker radListLifestyle;
        
        internal Telerik.Windows.Controls.RadListPicker radListCurrent;
        
        internal System.Windows.Controls.Button button1;
        
        internal Microsoft.Advertising.Mobile.UI.AdControl adControl1;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/DailyCalories;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.progressBar1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar1")));
            this.MainScroll = ((System.Windows.Controls.ScrollViewer)(this.FindName("MainScroll")));
            this.MainStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("MainStackPanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.radMale = ((System.Windows.Controls.RadioButton)(this.FindName("radMale")));
            this.radFemale = ((System.Windows.Controls.RadioButton)(this.FindName("radFemale")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.txtAge = ((System.Windows.Controls.TextBox)(this.FindName("txtAge")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.txtWeight = ((System.Windows.Controls.TextBox)(this.FindName("txtWeight")));
            this.textBlock3 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3")));
            this.txtFeet = ((System.Windows.Controls.TextBox)(this.FindName("txtFeet")));
            this.textBlock3_Copy = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3_Copy")));
            this.txtInches = ((System.Windows.Controls.TextBox)(this.FindName("txtInches")));
            this.textBlock3_Copy1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock3_Copy1")));
            this.radListLifestyle = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("radListLifestyle")));
            this.radListCurrent = ((Telerik.Windows.Controls.RadListPicker)(this.FindName("radListCurrent")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.adControl1 = ((Microsoft.Advertising.Mobile.UI.AdControl)(this.FindName("adControl1")));
        }
    }
}

