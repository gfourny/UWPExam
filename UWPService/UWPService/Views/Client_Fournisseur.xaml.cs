using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPService.Items;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPService.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Client_Fournisseur : Page
    {
        public Client_Fournisseur()
        {
            this.InitializeComponent();
        }
        
        private void BindCustomers()
        {
            GridViewCustomer.ItemsSource = VariableGlobale.Clients;
            GridViewSupplier.Visibility = Visibility.Collapsed;
        }

        private void BindSupplier()
        {
            GridViewSupplier.ItemsSource = VariableGlobale.Fournisseurs;
            GridViewCustomer.Visibility = Visibility.Visible;
        }

        private void MainPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                WindowsTitle.Text = e.Parameter.ToString();
                switch (e.Parameter.ToString())
                {
                    case "Fournisseurs":
                        BindSupplier();
                        break;
                    case "Clients":
                        BindCustomers();
                        break;
                }
            }

            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }
    }
}
