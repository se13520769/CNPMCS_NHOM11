﻿#pragma checksum "D:\Project Sacombank\gAMS_Sacombank.Silverlight\Views\Trade\PoManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6D05E58AA13FE8FFACB413324E30904D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace gAMS_Sacombank.Views.Trade {
    
    
    public partial class PoManager : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid front;
        
        internal System.Windows.Controls.StackPanel splHeader;
        
        internal System.Windows.Controls.DataGrid dgdData;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gAMS_Sacombank;component/Views/Trade/PoManager.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.front = ((System.Windows.Controls.Grid)(this.FindName("front")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
            this.dgdData = ((System.Windows.Controls.DataGrid)(this.FindName("dgdData")));
        }
    }
}

