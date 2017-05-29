using System;
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
using UWPProject.Pages;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            mainFrame.Navigate(typeof(HomePage));
        }

        private void listBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            ListBox lb = sender as ListBox;

            switch (lb.SelectedIndex)
            {
                case 0:
                    mainFrame.Navigate(typeof(HomePage));
                    break;
                case 1:
                    mainFrame.Navigate(typeof(ThemesPage));
                    break;
            }
        }
    }
}
