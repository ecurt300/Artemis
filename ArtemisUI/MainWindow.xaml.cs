using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Artemis;
using MoonData;
using MoonData.Domain;
using Utilities;
using Moon_Phase_App.Data;
using Microsoft.Extensions.DependencyInjection;
using Moon_Phase_App.Domain;
using Artemis.Logic;
using Application = Artemis.Application;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ArtemisUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
       private Application application {  get; set; }
       private MoonLogic moonLogic { get; set; }
        public MainWindow()
        {
            this.InitializeComponent();
            IServiceCollection services = new ServiceCollection();
            application = new Application(services);
            moonLogic = new MoonLogic();
        }

   

        private void InitiliazeDataBase_Click(object sender, RoutedEventArgs e)
        {
       
            moonLogic.InitializeDatabase(application);
            InitiliazeDataBase.Content = $"Progress {moonLogic.progress}";
        }

        private void ClearDataBase_Click(object sender, RoutedEventArgs e)
        {
          
            moonLogic.ClearDataBase(application);
           
        }

        private void FindNextFullMoon_Click(object sender, RoutedEventArgs e)
        {
        
         
            var day =   int.Parse(Day.Text);
            var month = int.Parse(Month.Text);
            var year =  int.Parse(Year.Text);
            
            FullMoonAnswer.Text = moonLogic.CalculateMoon(application, day, month, year);

        }
    }
}
