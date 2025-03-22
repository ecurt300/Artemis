using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Artemis_App
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class MainWindow1 : Window
    {


        private string? _Day;
        private string? _Month;
        private string? _Year;
        public string Month
        {
            get
            {
                return _Day;
            }
            set
            {
                _Day = value;
                RaisePropertychangedEvent("Month");
            }

        }
        public string Day
        {
            get
            {
                return _Month;
            }
            set
            {
                _Month = value;
                RaisePropertychangedEvent("Month");
            }

        }

        public string Year
        {
            get
            {
                return _Year;
            }
            set
            {
                _Year = value;
                RaisePropertychangedEvent("Year");
            }

        }
        
        public MainWindow1()
        {
            this.InitializeComponent();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertychangedEvent(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _Day = "";
            _Month = "";
            _Year = "";
           
        }
       
        /*
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
        */
        }
}
