﻿#pragma checksum "..\..\..\..\Views\CardControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CF1F6C8ED7BDA7FEE3BDD0CD6DAFC2BE13C5E215"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace NotesApp.Views {
    
    
    /// <summary>
    /// CardControl
    /// </summary>
    public partial class CardControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NotesApp.Views.CardControl Card_UserControl;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.DoubleAnimation OpacityAnimation;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ControlBorder;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Effects.DropShadowEffect DropShadowEffect;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteButton;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ContentTextBlock;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\..\Views\CardControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CreatedTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/NotesApp;component/views/cardcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CardControl.xaml"
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
            this.Card_UserControl = ((NotesApp.Views.CardControl)(target));
            return;
            case 2:
            this.OpacityAnimation = ((System.Windows.Media.Animation.DoubleAnimation)(target));
            return;
            case 3:
            this.ControlBorder = ((System.Windows.Controls.Border)(target));
            
            #line 88 "..\..\..\..\Views\CardControl.xaml"
            this.ControlBorder.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Control_MouseEnter);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\..\Views\CardControl.xaml"
            this.ControlBorder.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Control_MouseLeave);
            
            #line default
            #line hidden
            
            #line 93 "..\..\..\..\Views\CardControl.xaml"
            this.ControlBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Control_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DropShadowEffect = ((System.Windows.Media.Effects.DropShadowEffect)(target));
            return;
            case 5:
            this.TitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DeleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\..\..\Views\CardControl.xaml"
            this.DeleteButton.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ContentTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.CreatedTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

