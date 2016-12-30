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
using UWPService.Items;
using UWPService.MyWebService;
using System.Collections.ObjectModel;
using Windows.UI.Core;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPService.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class FacturesPhone : Page
    {
        private ObservableCollection<OrderProduct> OrderProducts;
        public FacturesPhone()
        {
            this.InitializeComponent();

            bindListView();
            OrderProducts = new ObservableCollection<OrderProduct>();

            foreach (OrderItem item in VariableGlobale.FacturesElement)
            {
                Product prod = VariableGlobale.Produits.FirstOrDefault(x => x.Id == item.ProductId);
                OrderProduct p = new OrderProduct
                {
                    Id = item.Id,
                    OrderId = item.OrderId,
                    Package = prod.Package,
                    ProductId = item.ProductId,
                    ProductName = prod.ProductName,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };

                OrderProducts.Add(p);
            }
        }

        private void bindListView()
        {
            tete.ItemsSource = VariableGlobale.Clients;
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
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        private void tete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int clientid = ((Customer)e.ClickedItem).Id;
            tutu.ItemsSource = VariableGlobale.Factures.Where(x => x.CustomerId == clientid);
            MyFlipView.SelectedIndex = 1;
        }

        private void tutu_ItemClick(object sender, ItemClickEventArgs e)
        {
            int orderid = ((Order)e.ClickedItem).Id;
            panelCustomer.DataContext = (Customer)tete.SelectedItem;
            panelOrder.DataContext = (Order)e.ClickedItem;
            lv.ItemsSource = OrderProducts.Where(x => x.OrderId == orderid).ToList();
            OrderForm.Visibility = Visibility.Visible;
            MyFlipView.SelectedIndex = 2;
        }
    }
}
