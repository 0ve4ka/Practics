// Updated by XamlIntelliSenseFileGenerator 17.04.2023 8:20:48
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3AB3F4D4E6501D2DFB1D3144566B53AC0FCE39F568EB277A226C4AAF3705581A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstPractic;
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


namespace FirstPractic
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGoExOne;

#line default
#line hidden


#line 17 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGoExTwo;

#line default
#line hidden


#line 18 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGoExthree;

#line default
#line hidden


#line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGoExFour;

#line default
#line hidden


#line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGoExFive;

#line default
#line hidden


#line 22 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Pages;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FirstPractic;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BtnGoBack = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\MainWindow.xaml"
                    this.BtnGoBack.Click += new System.Windows.RoutedEventHandler(this.BtnGoBack_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.BtnGoExOne = ((System.Windows.Controls.Button)(target));

#line 16 "..\..\MainWindow.xaml"
                    this.BtnGoExOne.Click += new System.Windows.RoutedEventHandler(this.BtnGoExOne_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.BtnGoExTwo = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\MainWindow.xaml"
                    this.BtnGoExTwo.Click += new System.Windows.RoutedEventHandler(this.BtnGoExTwo_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.BtnGoExthree = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\MainWindow.xaml"
                    this.BtnGoExthree.Click += new System.Windows.RoutedEventHandler(this.BtnGoExthree_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.BtnGoExFour = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\MainWindow.xaml"
                    this.BtnGoExFour.Click += new System.Windows.RoutedEventHandler(this.BtnGoExFour_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.BtnGoExFive = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\MainWindow.xaml"
                    this.BtnGoExFive.Click += new System.Windows.RoutedEventHandler(this.BtnGoExFive_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.Pages = ((System.Windows.Controls.Frame)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

