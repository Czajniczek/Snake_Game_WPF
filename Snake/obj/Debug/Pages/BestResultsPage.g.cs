﻿#pragma checksum "..\..\..\Pages\BestResultsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AF29AC213EA557B0D8F84AEADD1CB1D97AD78D780EAEBEFF2FEAEB821A150A79"
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
using Snake.Converters;
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
    /// BestResultsPage
    /// </summary>
    public partial class BestResultsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Pages\BestResultsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back_Button;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\BestResultsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Music_Button;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\BestResultsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon Music_Icon;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Pages\BestResultsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit_Button;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\BestResultsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Results_DataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Snake;component/pages/bestresultspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\BestResultsPage.xaml"
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
            
            #line 13 "..\..\..\Pages\BestResultsPage.xaml"
            ((Snake.Pages.BestResultsPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.BestResultsPage_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Back_Button = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\Pages\BestResultsPage.xaml"
            this.Back_Button.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Music_Button = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Pages\BestResultsPage.xaml"
            this.Music_Button.Click += new System.Windows.RoutedEventHandler(this.MusicButton_Click);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\Pages\BestResultsPage.xaml"
            this.Music_Button.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Music_Button_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Music_Icon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 5:
            this.Exit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\Pages\BestResultsPage.xaml"
            this.Exit_Button.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Results_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

