﻿#pragma checksum "E:\GSOFT\Projects\Asset Management\WIP\Program\mvvmSilverlight\AssetManagement\Views\Infranstructure\Room.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A076543C59BE0F0DF6030F1A6D408D6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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


namespace AssetManagement.Views.Infranstructure {
    
    
    public partial class Room : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid front;
        
        internal System.Windows.Controls.StackPanel splHeader;
        
        internal System.Windows.Controls.DataGrid dgdData;
        
        internal System.Windows.Controls.Grid back;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AssetManagement;component/Views/Infranstructure/Room.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.front = ((System.Windows.Controls.Grid)(this.FindName("front")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
            this.dgdData = ((System.Windows.Controls.DataGrid)(this.FindName("dgdData")));
            this.back = ((System.Windows.Controls.Grid)(this.FindName("back")));
        }
    }
}

