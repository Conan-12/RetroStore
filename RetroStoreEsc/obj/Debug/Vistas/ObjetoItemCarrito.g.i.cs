﻿#pragma checksum "..\..\..\Vistas\ObjetoItemCarrito.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F288C6B3ED2FA70023020A3B09CF1C965BAC724F2C68A72ACDACF388B6C021DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using RetroStoreEsc.Vistas;
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


namespace RetroStoreEsc.Vistas {
    
    
    /// <summary>
    /// ObjetoItemCarrito
    /// </summary>
    public partial class ObjetoItemCarrito : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image picProducto;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtModelo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtPrecio;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtCantidad;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txtTotal;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnQuitar;
        
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
            System.Uri resourceLocater = new System.Uri("/RetroStoreEsc;component/vistas/objetoitemcarrito.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
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
            this.picProducto = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.txtModelo = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtPrecio = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtCantidad = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnQuitar = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Vistas\ObjetoItemCarrito.xaml"
            this.btnQuitar.Click += new System.Windows.RoutedEventHandler(this.btnQuitar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

