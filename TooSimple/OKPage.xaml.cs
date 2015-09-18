using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace TooSimple
{
    public partial class OKPage : PhoneApplicationPage
    {
        private IsolatedStorageSettings appSetting = IsolatedStorageSettings.ApplicationSettings;

        public OKPage()
        {
            InitializeComponent();
            LayoutRoot_Loaded();
        }

        private void LayoutRoot_Loaded()
        // private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            if (appSetting.Contains("name"))
            {
                textbox.Text = appSetting["name"].ToString();
            }
        }

        void CopyClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textbox.Text.ToString());
            MessageBoxButton button = MessageBoxButton.OK;
            MessageBoxResult result = MessageBox.Show("", "复制成功", button);
        }
    }
}