﻿#pragma checksum "..\..\..\Presentacion\PrincipalWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3DD455B6DE6EBE97EB2BE31A3525A68DC129A97045853576E95CBD93E7EF432C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace FONET_CIA_LTDA.Presentacion {
    
    
    /// <summary>
    /// PrincipalWindow
    /// </summary>
    public partial class PrincipalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTipoUsuario;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblUsuario;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cerrarSesion;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost salir;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNoCerrar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Presentacion\PrincipalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost cargando;
        
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
            System.Uri resourceLocater = new System.Uri("/FONET_CIA_LTDA;component/presentacion/principalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Presentacion\PrincipalWindow.xaml"
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
            
            #line 23 "..\..\..\Presentacion\PrincipalWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblTipoUsuario = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblUsuario = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.cerrarSesion = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Presentacion\PrincipalWindow.xaml"
            this.cerrarSesion.Click += new System.Windows.RoutedEventHandler(this.CerrarSesion_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frame1 = ((System.Windows.Controls.Frame)(target));
            
            #line 43 "..\..\..\Presentacion\PrincipalWindow.xaml"
            this.frame1.AddHandler(System.Windows.FrameworkContentElement.LoadedEvent, new System.Windows.RoutedEventHandler(this.Frame1_Loaded));
            
            #line default
            #line hidden
            return;
            case 7:
            this.salir = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            case 8:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Presentacion\PrincipalWindow.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnNoCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Presentacion\PrincipalWindow.xaml"
            this.btnNoCerrar.Click += new System.Windows.RoutedEventHandler(this.BtnNoCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cargando = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

