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
using Windows.UI.Popups;
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
    public sealed partial class Clients_Fournisseur_Detaille : Page
    {
        public object objectBinding = null;

        public Clients_Fournisseur_Detaille()
        {
            this.InitializeComponent();
            SystemNavigationManager.GetForCurrentView().BackRequested += Clients_Fournisseur_Detaille_BackRequested;
            panelClient.DataContext = objectBinding;
            panelFournisseur.DataContext = objectBinding;
        }

        private void Clients_Fournisseur_Detaille_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }

        private void affectCustomerToView(NavigationEventArgs e)
        {
            objectBinding = (Customer)e.Parameter;
            panelClient.DataContext = objectBinding;
            panelClient.Visibility = Visibility.Visible;

            if (string.IsNullOrEmpty(((Customer)objectBinding).FirstName) && string.IsNullOrEmpty(((Customer)objectBinding).LastName))
                WindowTitleClient.Text = Constante.GetTitreCreationClient;
            else
                WindowTitleClient.Text = string.Format("{0} {1} {2}", Constante.GetTitreModificationClient, ((Customer)objectBinding).FirstName, ((Customer)objectBinding).LastName);
        }

        private void affectSupplierToView(NavigationEventArgs e)
        {
            objectBinding = (Supplier)e.Parameter;
            panelFournisseur.DataContext = objectBinding;
            panelFournisseur.Visibility = Visibility.Visible;
            WindowTitleSupplier.Text = Constante.GetTitreCreationFournisseur;

            if (string.IsNullOrEmpty(((Supplier)objectBinding).CompanyName))
                WindowTitleSupplier.Text = Constante.GetTitreCreationFournisseur;
            else
                WindowTitleSupplier.Text = string.Format("{0} {1}", Constante.GetTitreModificationFournisseur, ((Supplier)objectBinding).CompanyName);            
                

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                if (e.Parameter.GetType() == typeof(Customer))
                    affectCustomerToView(e);

                if (e.Parameter.GetType() == typeof(Supplier))
                    affectSupplierToView(e);
            }

            if (Frame.CanGoBack)
                Windows.UI.Core.SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
        }

        private void DisplayMessage(string s)
        {
            var dialog = new MessageDialog(s);
            var r = dialog.ShowAsync();
        }

        private void btnSaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text))
            {
                if (Modele.IsCustomerPresent(Convert.ToInt32(tbID.Text)))
                {
                    // Mise à jour du client
                    Customer client = Modele.GetCustomerById(Convert.ToInt32(tbID.Text));
                    if (client != null)
                    {
                        Modele.UpdateCustomer(client, (Customer)objectBinding);
                        DisplayMessage("Modification réussi!");
                    }
                }
                else
                {
                    //Ajout d'un client
                    Modele.AddCustomer((Customer)objectBinding);
                    objectBinding = new Customer();
                    panelClient.DataContext = objectBinding;
                    DisplayMessage("Enregistrement réussi!");                    
                }
                Frame.Navigate(typeof(Client_Fournisseur), "Clients");
            }
            else
                DisplayMessage("Il est nécessaire de remplir au moins les champs Nom et Prénom pour enregistrer.");
        }

        private void btnSaveSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCompanyNameSupplier.Text))
            {
                if (Modele.IsSupplierPresent(Convert.ToInt32(tbIDSupplier.Text)))
                {
                    // Modification dd fournisseur sélectionné
                    Supplier fournisseur = Modele.GetSupplierById(Convert.ToInt32(tbIDSupplier.Text));
                    if (fournisseur != null)
                    {
                        Modele.UpdateSupplier(fournisseur, (Supplier)objectBinding);
                        DisplayMessage("Modification réussi!");
                    }
                }
                else
                {
                    //Ajout d'un fournisseur
                    Modele.AddSupplier((Supplier)objectBinding);
                    objectBinding = new Supplier();
                    panelClient.DataContext = objectBinding;
                    DisplayMessage("Enregistrement réussi!");
                }
                Frame.Navigate(typeof(Client_Fournisseur), "Fournisseurs");
            }
            else
                DisplayMessage("Il est nécessaire de remplir au moins le champ Nom de l'entreprise pour enregistrer.");
        }
    }
}
