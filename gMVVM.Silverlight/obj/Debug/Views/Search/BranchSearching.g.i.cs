﻿#pragma checksum "C:\Users\WINUIT\Documents\GitHub\framework\gMVVM.Silverlight\Views\Search\BranchSearching.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "061F720D52AC6EE998AA2496A6616015"
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


namespace gMVVM.Views.Search {
    
    
    public partial class BranchSearching : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl RootItem;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid front;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gMVVM;component/Views/Search/BranchSearching.xaml", System.UriKind.Relative));
            this.RootItem = ((System.Windows.Controls.UserControl)(this.FindName("RootItem")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.front = ((System.Windows.Controls.Grid)(this.FindName("front")));
            this.dgdData = ((System.Windows.Controls.DataGrid)(this.FindName("dgdData")));
        }
    }
}

