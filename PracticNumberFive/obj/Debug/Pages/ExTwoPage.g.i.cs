﻿#pragma checksum "..\..\..\Pages\ExTwoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C95A0F263C29386CEC722234963737557BC2A3078B5025F26FDD56FD8922F9AE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PracticNumberFive.Pages;
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


namespace PracticNumberFive.Pages {
    
    
    /// <summary>
    /// ExTwoPage
    /// </summary>
    public partial class ExTwoPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\Pages\ExTwoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNumbersExTwo;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\ExTwoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BntExTwo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Pages\ExTwoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddExTwo;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\ExTwoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Answer;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\ExTwoPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxExTwo;
        
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
            System.Uri resourceLocater = new System.Uri("/PracticNumberFive;component/pages/extwopage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ExTwoPage.xaml"
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
            this.TbNumbersExTwo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.BntExTwo = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Pages\ExTwoPage.xaml"
            this.BntExTwo.Click += new System.Windows.RoutedEventHandler(this.BntExTwo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnAddExTwo = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Pages\ExTwoPage.xaml"
            this.BtnAddExTwo.Click += new System.Windows.RoutedEventHandler(this.BtnAddExTwo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Answer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ListBoxExTwo = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
