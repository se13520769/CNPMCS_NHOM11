﻿#pragma checksum "C:\Users\WINUIT\Documents\GitHub\framework\gMVVM.Silverlight\Views\Common\ToolHeader.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D0B5AAC5CBC6240B0D7A3CEE4B1E1500"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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


namespace gMVVM.Views.Common {
    
    
    public partial class ToolHeader : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl RootItem;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Expander ToolLog;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gMVVM;component/Views/Common/ToolHeader.xaml", System.UriKind.Relative));
            this.RootItem = ((System.Windows.Controls.UserControl)(this.FindName("RootItem")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ToolLog = ((System.Windows.Controls.Expander)(this.FindName("ToolLog")));
        }
    }
}

