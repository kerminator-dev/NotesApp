﻿#pragma checksum "..\..\..\..\View\EditorWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "235430EA523356670678B0D05616502B2A26E7BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HandyControl.Controls;
using HandyControl.Data;
using HandyControl.Expression.Media;
using HandyControl.Expression.Shapes;
using HandyControl.Interactivity;
using HandyControl.Media.Animation;
using HandyControl.Media.Effects;
using HandyControl.Properties.Langs;
using HandyControl.Themes;
using HandyControl.Tools;
using HandyControl.Tools.Converter;
using HandyControl.Tools.Extension;
using NotesApp.Properties;
using NotesApp.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace NotesApp.View {
    
    
    /// <summary>
    /// EditorWindow
    /// </summary>
    public partial class EditorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NotesApp.View.EditorWindow Window;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition Header;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition Main;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RowDefinition Footer;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel HeaderPanel;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 172 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SaveButton;
        
        #line default
        #line hidden
        
        
        #line 225 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 244 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 278 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ContentTextBox;
        
        #line default
        #line hidden
        
        
        #line 283 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border FooterPanel;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SymbolsCountTextBlock;
        
        #line default
        #line hidden
        
        
        #line 307 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FontSizeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 314 "..\..\..\..\View\EditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider FontSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NotesApp;component/view/editorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\EditorWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Window = ((NotesApp.View.EditorWindow)(target));
            
            #line 17 "..\..\..\..\View\EditorWindow.xaml"
            this.Window.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\View\EditorWindow.xaml"
            this.Window.Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Header = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.Main = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 4:
            this.Footer = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 5:
            
            #line 135 "..\..\..\..\View\EditorWindow.xaml"
            ((System.Windows.Controls.ContentControl)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Header_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HeaderPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 7:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 170 "..\..\..\..\View\EditorWindow.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SaveButton = ((System.Windows.Controls.TextBlock)(target));
            
            #line 191 "..\..\..\..\View\EditorWindow.xaml"
            this.SaveButton.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SaveButton_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.DateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.ContentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.FooterPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 13:
            this.SymbolsCountTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.FontSizeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.FontSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 326 "..\..\..\..\View\EditorWindow.xaml"
            this.FontSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.FontSlider_ValueChanged);
            
            #line default
            #line hidden
            
            #line 327 "..\..\..\..\View\EditorWindow.xaml"
            this.FontSlider.Loaded += new System.Windows.RoutedEventHandler(this.FontSlider_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
