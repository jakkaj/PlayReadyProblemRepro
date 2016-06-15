﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PlayReadySample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnSmoothStreamButtonClicked(object sender, RoutedEventArgs e)
        {
            // You can get more streams (both protected and unprotected) here: http://playready.directtaps.net/smoothstreaming/
            this.Frame.Navigate(typeof(PlayerPage), new PlayerArguments { StreamUrl = "http://streamcovod.edgesuite.net/dash/test-vectors/clear/mbr_live_h264_16x9_1080_stereo/master.mpd"});
        }

        private void OnDashButtonClicked(object sender, RoutedEventArgs e)
        {
            // We don't need to specify rights manager url with this stream
            this.Frame.Navigate(typeof(PlayerPage), new PlayerArguments { StreamUrl = "http://streamcovod.edgesuite.net/dash/test-vectors/cenc/mbr_live_h264_16x9_1080_stereo/master.mpd" });
        }
    }
}
