﻿#pragma checksum "E:\GSOFT\Projects\gAMS_Sacombank_V2\WIP\Program\gAMS_Sacombank.Silverlight\Views\AssCommon\AssetTypeList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "833E55AF24E6374642CE4EC9480E5AF3"
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


namespace gAMS_Sacombank.Views.AssCommon {
    
    
    public partial class AssetTypeList : System.Windows.Controls.UserControl {
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gAMS_Sacombank;component/Views/AssCommon/AssetTypeList.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.front = ((System.Windows.Controls.Grid)(this.FindName("front")));
            this.splHeader = ((System.Windows.Controls.StackPanel)(this.FindName("splHeader")));
            this.dgdData = ((System.Windows.Controls.DataGrid)(this.FindName("dgdData")));
            this.back = ((System.Windows.Controls.Grid)(this.FindName("back")));
        }
    }
}

