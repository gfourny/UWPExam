using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        int Plus = 5;
        public Dashboard()
        {
            this.InitializeComponent();
            this.Loaded += Dashboard_Loaded;
            YnovServiceClient Vente = new YnovServiceClient();
            Vente.CloseAsync();

        }

        void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            LoadChartContents();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!Frame.CanGoBack)
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private async void LoadChartContents()
        {
            YnovServiceClient nbVente = new YnovServiceClient();

            ObservableCollection<MyWebService.Vente> IVente = await nbVente.VentesAsync();
            (AreaChart.Series[0] as AreaSeries).ItemsSource = IVente.Skip(0).Take(7);

            //Random rand = new Random();
            //List<Dashboard> financialStuffList = new List<Dashboard>();
            //financialStuffList.Add(new Dashboard() { Name = "MSFT", Amount = rand.Next(0, 200) });
            //financialStuffList.Add(new Dashboard() { Name = "AAPL", Amount = rand.Next(0, 200) });
            //financialStuffList.Add(new Dashboard() { Name = "GOOG", Amount = rand.Next(0, 200) });
            //financialStuffList.Add(new Dashboard() { Name = "BBRY", Amount = rand.Next(0, 200) });

            //(AreaChart.Series[0] as AreaSeries).ItemsSource = financialStuffList;
        }
        private async void Suivant_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Plus += 7;
            YnovServiceClient nbVente = new YnovServiceClient();
            ObservableCollection<MyWebService.Vente> IVente = await nbVente.VentesAsync();
            (AreaChart.Series[0] as AreaSeries).ItemsSource = IVente.Skip(Plus).Take(7);
            Suivant.FontSize = 15;
        }

        private async void Precedent_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            Plus -= 7;
            YnovServiceClient nbVente = new YnovServiceClient();
            ObservableCollection<MyWebService.Vente> IVente = await nbVente.VentesAsync();
            (AreaChart.Series[0] as AreaSeries).ItemsSource = IVente.Skip(Plus).Take(7);
            Precedent.FontSize = 15;
        }

        private void Suivant_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Suivant.FontSize = 30;
        }

        private void Suivant_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Suivant.FontSize = 22;
        }

        private void Precedent_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Precedent.FontSize = 30;
        }

        private void Precedent_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Precedent.FontSize = 22;
        }
    }
}
