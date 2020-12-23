﻿#pragma checksum "..\..\..\Pages\SettingsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4E04F031781FB0B1D50E9C5DCDBF210837BD7F4E1EDE54993D162AFB88A0F5F4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Snake.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Snake.Pages {
    
    
    /// <summary>
    /// SettingsPage
    /// </summary>
    public partial class SettingsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_Button;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Music_Button;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon Music_Icon;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Button;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Left_Image;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DifficultyLevel_Button;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OwnSettings_Button;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MusicSettings_Button;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\Pages\SettingsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Right_Image;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Snake;component/pages/settingspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SettingsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\..\Pages\SettingsPage.xaml"
            ((Snake.Pages.SettingsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.SettingsPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Back_Button = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\SettingsPage.xaml"
            this.Back_Button.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Music_Button = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Pages\SettingsPage.xaml"
            this.Music_Button.Click += new System.Windows.RoutedEventHandler(this.MusicButton_Click);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\Pages\SettingsPage.xaml"
            this.Music_Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Music_Button_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Music_Icon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 5:
            this.Exit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Pages\SettingsPage.xaml"
            this.Exit_Button.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Left_Image = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.DifficultyLevel_Button = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\..\Pages\SettingsPage.xaml"
            this.DifficultyLevel_Button.Click += new System.Windows.RoutedEventHandler(this.DifficultyLevelButton_Click);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\Pages\SettingsPage.xaml"
            this.DifficultyLevel_Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.DifficultyLevel_Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 117 "..\..\..\Pages\SettingsPage.xaml"
            this.DifficultyLevel_Button.MouseLeave += new System.Windows.Input.MouseEventHandler(this.DifficultyLevel_Button_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OwnSettings_Button = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\Pages\SettingsPage.xaml"
            this.OwnSettings_Button.Click += new System.Windows.RoutedEventHandler(this.OwnSettingsButton_Click);
            
            #line default
            #line hidden
            
            #line 129 "..\..\..\Pages\SettingsPage.xaml"
            this.OwnSettings_Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.OwnSettings_Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 130 "..\..\..\Pages\SettingsPage.xaml"
            this.OwnSettings_Button.MouseLeave += new System.Windows.Input.MouseEventHandler(this.OwnSettings_Button_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MusicSettings_Button = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\Pages\SettingsPage.xaml"
            this.MusicSettings_Button.Click += new System.Windows.RoutedEventHandler(this.MusicSettingsButton_Click);
            
            #line default
            #line hidden
            
            #line 142 "..\..\..\Pages\SettingsPage.xaml"
            this.MusicSettings_Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.MusicSettings_Button_MouseEnter);
            
            #line default
            #line hidden
            
            #line 143 "..\..\..\Pages\SettingsPage.xaml"
            this.MusicSettings_Button.MouseLeave += new System.Windows.Input.MouseEventHandler(this.MusicSettings_Button_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Right_Image = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

