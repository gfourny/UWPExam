using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPService.MyWebService;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPService.Views;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPService
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavigationCortana();

            YnovServiceClient Client = new YnovServiceClient();
            //MyGridView.ItemsSource = Client.GetCustomersAsync().Result;
            Client.CloseAsync();
        }

        /// <summary>
        /// Permet de réaliser la navigation avec Cortana
        /// Gestion des différents onglets
        /// </summary>
        private void NavigationCortana()
        {
            MyFrame.Navigate(typeof(Views.Dashboard));
            switch (Items.Constant.command)
            {
                case "Panier":
                    MyFrame.Navigate(typeof(Panier));
                    break;
                case "Client fournisseur":
                    MyFrame.Navigate(typeof(Client_Fournisseur));
                    break;
                case "Facture":
                    MyFrame.Navigate(typeof(Factures));
                    break;
                case "Produit":
                    MyFrame.Navigate(typeof(Produits));
                    break;
                default:
                    MyFrame.Navigate(typeof(Views.Dashboard));
                    break;
            }

            Items.Constant.command = string.Empty;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (((StackPanel)e.ClickedItem).Name == "Ham")
                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            else if (((StackPanel)e.ClickedItem).Name == "Client_Fournisseur")
                MyFrame.Navigate(typeof(Client_Fournisseur));
            else if (((StackPanel)e.ClickedItem).Name == "Factures")
                MyFrame.Navigate(typeof(Factures));
            else if (((StackPanel)e.ClickedItem).Name == "Panier")
                MyFrame.Navigate(typeof(Panier));
            else if (((StackPanel)e.ClickedItem).Name == "Produits")
                MyFrame.Navigate(typeof(Produits));
        }
    }
}
