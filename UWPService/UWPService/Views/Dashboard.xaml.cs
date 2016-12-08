using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPService.MyWebService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPService.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Dashboard : Page
    {
        public Dashboard()
        {
            this.InitializeComponent();
            YnovServiceClient Client = new YnovServiceClient();
            MyGridView.ItemsSource = Client.GetCustomersAsync().Result;
            Client.CloseAsync();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!Frame.CanGoBack)
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void LoadChartContent()
        {
            YnovServiceClient Client = new YnovServiceClient();

            Random rand = new Random();
            List<Customer> CustomersList = Client.GetCustomersAsync().Result.ToList();
            CustomersList.Add(new Customer() { FirstName = Client.GetCustomersAsync().Result.ToString() });
            (AreaChart.Series[0] as AreaSeries).ItemsSource = CustomersList;
        }
    }
}
