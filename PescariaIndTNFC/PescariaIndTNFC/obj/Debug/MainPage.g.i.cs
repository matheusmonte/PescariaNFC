﻿#pragma checksum "C:\workspace\PescariaNFC\PescariaIndTNFC\PescariaIndTNFC\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "05BCE2796BC7520E862349F8F7DF54F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace PescariaIndTNFC {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Image foto;
        
        internal System.Windows.Controls.MediaElement AguaSom;
        
        internal System.Windows.Controls.MediaElement Aplauso;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PescariaIndTNFC;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.foto = ((System.Windows.Controls.Image)(this.FindName("foto")));
            this.AguaSom = ((System.Windows.Controls.MediaElement)(this.FindName("AguaSom")));
            this.Aplauso = ((System.Windows.Controls.MediaElement)(this.FindName("Aplauso")));
        }
    }
}

