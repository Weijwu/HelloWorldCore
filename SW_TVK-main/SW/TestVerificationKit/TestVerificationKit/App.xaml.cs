using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;
using Virtue.iGene_Pad.TVK.View;

namespace Virtue.iGene_Pad.TVK
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
          
            MainWindow window = new MainWindow();
            window.Show();
        }

    }
}
