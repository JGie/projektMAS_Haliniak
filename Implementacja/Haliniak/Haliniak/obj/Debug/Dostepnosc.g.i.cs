﻿#pragma checksum "..\..\Dostepnosc.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "33175405BB0A545CEA6906BFBFC50D92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace Haliniak {
    
    
    /// <summary>
    /// Dostepnosc
    /// </summary>
    public partial class Dostepnosc : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\Dostepnosc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNiedostepne;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\Dostepnosc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDostepne;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Dostepnosc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label daneKlienta;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Dostepnosc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrzyjmij;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Dostepnosc.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOdrzuc;
        
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
            System.Uri resourceLocater = new System.Uri("/Haliniak;component/dostepnosc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dostepnosc.xaml"
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
            this.lblNiedostepne = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblDostepne = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.daneKlienta = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnPrzyjmij = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Dostepnosc.xaml"
            this.btnPrzyjmij.Click += new System.Windows.RoutedEventHandler(this.btnPrzyjmij_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnOdrzuc = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Dostepnosc.xaml"
            this.btnOdrzuc.Click += new System.Windows.RoutedEventHandler(this.btnOdrzuc_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

