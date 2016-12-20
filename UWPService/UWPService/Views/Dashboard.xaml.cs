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
        int Plus = 0;
        int PlusB = 0;
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
            YnovServiceClient MyService = new YnovServiceClient();

            ObservableCollection<MyWebService.Vente> IVente = await MyService.VentesAsync();
            (AreaChart.Series[0] as AreaSeries).ItemsSource = IVente.Skip(0).Take(7);

            ObservableCollection<MyWebService.Resultat> IResultat = await MyService.ResultatsAsync();
            (PieChart.Series[0] as PieSeries).ItemsSource = IResultat.Skip(0).Take(3);

            ObservableCollection<MyWebService.Client> IClient = await MyService.ClientsAsync();
            (BubbleChart.Series[0] as BubbleSeries).ItemsSource = IClient.Skip(0).Take(5);
        }

        private async void Suivant_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            YnovServiceClient MyService = new YnovServiceClient();
            ObservableCollection<MyWebService.Vente> IVente = await MyService.VentesAsync();

            if (Plus > IVente.Count-14)
            {
                Plus = 0;
            }
            else
            {
                Plus += 7;
            }
            (AreaChart.Series[0] as AreaSeries).ItemsSource = IVente.Skip(Plus).Take(7);
        }

        private async void Precedent_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (Plus < 0)
                Plus = 0;
            Plus -= 7;
            YnovServiceClient MyService = new YnovServiceClient();
            ObservableCollection<MyWebService.Vente> IVente = await MyService.VentesAsync();
            (AreaChart.Series[0] as AreaSeries).ItemsSource = IVente.Skip(Plus).Take(7);
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

        private async void SuivantB_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            YnovServiceClient MyService = new YnovServiceClient();
            ObservableCollection<MyWebService.Client> IClient = await MyService.ClientsAsync();

            if (PlusB > IClient.Count - 14)
            {
                PlusB = 0;
            }
            else
            {
                PlusB += 5;
            }
            (BubbleChart.Series[0] as BubbleSeries).ItemsSource = IClient.Skip(PlusB).Take(5);
        }

        private async void PrecedentB_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            if (PlusB < 0)
                PlusB = 0;
            PlusB -= 5;
            YnovServiceClient MyService = new YnovServiceClient();
            ObservableCollection<MyWebService.Client> IClient = await MyService.ClientsAsync();
            (BubbleChart.Series[0] as BubbleSeries).ItemsSource = IClient.Skip(PlusB).Take(5);
        }

        private void SuivantB_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            SuivantB.FontSize = 30;
        }

        private void SuivantB_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            SuivantB.FontSize = 22;
        }

        private void PrecedentB_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            PrecedentB.FontSize = 30;
        }

        private void PrecedentB_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            PrecedentB.FontSize = 22;
        }
    }
}
