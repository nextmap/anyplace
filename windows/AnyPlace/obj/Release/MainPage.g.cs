﻿#pragma checksum "C:\Users\panayiotis\Desktop\AnyPlace\AnyPlace\AnyPlace\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "63A23F4A4C270206A2DB2C4880DE5512"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Shell;
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


namespace AnyPlace {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Canvas canvas;
        
        internal System.Windows.Media.Animation.Storyboard moveAnimation;
        
        internal System.Windows.Controls.Canvas CanvasMenu;
        
        internal System.Windows.Controls.Grid gd_result;
        
        internal System.Windows.Controls.ProgressBar pb_result;
        
        internal System.Windows.Controls.TextBlock txt_term;
        
        internal System.Windows.Controls.TextBlock txt_result;
        
        internal Microsoft.Phone.Controls.LongListSelector ls_search;
        
        internal System.Windows.Controls.Grid directions_grid;
        
        internal System.Windows.Controls.ProgressBar calcProgrBar;
        
        internal System.Windows.Controls.TextBlock calcroutestext;
        
        internal System.Windows.Controls.TextBlock time;
        
        internal System.Windows.Controls.TextBlock distance;
        
        internal System.Windows.Controls.TextBlock dire;
        
        internal Microsoft.Phone.Controls.LongListSelector RouteLLS;
        
        internal System.Windows.Controls.Grid grdCommands;
        
        public Microsoft.Phone.Maps.Controls.Map Mymap;
        
        internal System.Windows.Controls.Grid floorpicker;
        
        internal Microsoft.Phone.Controls.AutoCompleteBox autoCompleteBuilding;
        
        internal System.Windows.Controls.TextBlock txt_selectedfloor;
        
        internal Microsoft.Phone.Controls.ListPicker Picker;
        
        internal System.Windows.Controls.Button btn_builddown;
        
        internal System.Windows.Controls.Button btn_floordown;
        
        internal System.Windows.Controls.Grid buildingsButton;
        
        internal System.Windows.Controls.Grid optionsbtn;
        
        internal System.Windows.Controls.Grid lpicker;
        
        internal Microsoft.Phone.Controls.ListPicker BPicker;
        
        internal System.Windows.Controls.Grid downloading;
        
        internal System.Windows.Controls.TextBlock txt_download;
        
        internal System.Windows.Controls.Grid trackmebtn;
        
        internal System.Windows.Controls.Grid floorButton;
        
        internal System.Windows.Controls.StackPanel stack;
        
        internal System.Windows.Controls.ProgressBar loading;
        
        internal System.Windows.Controls.Grid closeGrid;
        
        internal System.Windows.Controls.TextBlock txt_msg;
        
        internal System.Windows.Controls.Grid zoompanel;
        
        internal System.Windows.Controls.StackPanel floorPanel;
        
        internal System.Windows.Controls.TextBlock txt_cur;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Grid grid_search;
        
        internal System.Windows.Controls.TextBlock txt_msg1;
        
        internal System.Windows.Controls.Button all_builds;
        
        internal Microsoft.Phone.Controls.AutoCompleteBox autoCompleteBox;
        
        internal System.Windows.Controls.Grid MapOptions;
        
        internal Microsoft.Phone.Shell.ApplicationBar appBar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton sbutton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnyPlace;component/MainPage.xaml", System.UriKind.Relative));
            this.canvas = ((System.Windows.Controls.Canvas)(this.FindName("canvas")));
            this.moveAnimation = ((System.Windows.Media.Animation.Storyboard)(this.FindName("moveAnimation")));
            this.CanvasMenu = ((System.Windows.Controls.Canvas)(this.FindName("CanvasMenu")));
            this.gd_result = ((System.Windows.Controls.Grid)(this.FindName("gd_result")));
            this.pb_result = ((System.Windows.Controls.ProgressBar)(this.FindName("pb_result")));
            this.txt_term = ((System.Windows.Controls.TextBlock)(this.FindName("txt_term")));
            this.txt_result = ((System.Windows.Controls.TextBlock)(this.FindName("txt_result")));
            this.ls_search = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("ls_search")));
            this.directions_grid = ((System.Windows.Controls.Grid)(this.FindName("directions_grid")));
            this.calcProgrBar = ((System.Windows.Controls.ProgressBar)(this.FindName("calcProgrBar")));
            this.calcroutestext = ((System.Windows.Controls.TextBlock)(this.FindName("calcroutestext")));
            this.time = ((System.Windows.Controls.TextBlock)(this.FindName("time")));
            this.distance = ((System.Windows.Controls.TextBlock)(this.FindName("distance")));
            this.dire = ((System.Windows.Controls.TextBlock)(this.FindName("dire")));
            this.RouteLLS = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("RouteLLS")));
            this.grdCommands = ((System.Windows.Controls.Grid)(this.FindName("grdCommands")));
            this.Mymap = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("Mymap")));
            this.floorpicker = ((System.Windows.Controls.Grid)(this.FindName("floorpicker")));
            this.autoCompleteBuilding = ((Microsoft.Phone.Controls.AutoCompleteBox)(this.FindName("autoCompleteBuilding")));
            this.txt_selectedfloor = ((System.Windows.Controls.TextBlock)(this.FindName("txt_selectedfloor")));
            this.Picker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Picker")));
            this.btn_builddown = ((System.Windows.Controls.Button)(this.FindName("btn_builddown")));
            this.btn_floordown = ((System.Windows.Controls.Button)(this.FindName("btn_floordown")));
            this.buildingsButton = ((System.Windows.Controls.Grid)(this.FindName("buildingsButton")));
            this.optionsbtn = ((System.Windows.Controls.Grid)(this.FindName("optionsbtn")));
            this.lpicker = ((System.Windows.Controls.Grid)(this.FindName("lpicker")));
            this.BPicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("BPicker")));
            this.downloading = ((System.Windows.Controls.Grid)(this.FindName("downloading")));
            this.txt_download = ((System.Windows.Controls.TextBlock)(this.FindName("txt_download")));
            this.trackmebtn = ((System.Windows.Controls.Grid)(this.FindName("trackmebtn")));
            this.floorButton = ((System.Windows.Controls.Grid)(this.FindName("floorButton")));
            this.stack = ((System.Windows.Controls.StackPanel)(this.FindName("stack")));
            this.loading = ((System.Windows.Controls.ProgressBar)(this.FindName("loading")));
            this.closeGrid = ((System.Windows.Controls.Grid)(this.FindName("closeGrid")));
            this.txt_msg = ((System.Windows.Controls.TextBlock)(this.FindName("txt_msg")));
            this.zoompanel = ((System.Windows.Controls.Grid)(this.FindName("zoompanel")));
            this.floorPanel = ((System.Windows.Controls.StackPanel)(this.FindName("floorPanel")));
            this.txt_cur = ((System.Windows.Controls.TextBlock)(this.FindName("txt_cur")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.grid_search = ((System.Windows.Controls.Grid)(this.FindName("grid_search")));
            this.txt_msg1 = ((System.Windows.Controls.TextBlock)(this.FindName("txt_msg1")));
            this.all_builds = ((System.Windows.Controls.Button)(this.FindName("all_builds")));
            this.autoCompleteBox = ((Microsoft.Phone.Controls.AutoCompleteBox)(this.FindName("autoCompleteBox")));
            this.MapOptions = ((System.Windows.Controls.Grid)(this.FindName("MapOptions")));
            this.appBar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("appBar")));
            this.sbutton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("sbutton")));
        }
    }
}

