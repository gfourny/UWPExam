﻿using System;
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
using UWPService.Items;

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
            RecupDonnees();
        }     

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {            
            var qualifiers = Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().QualifierValues;

            if (((StackPanel)e.ClickedItem).Name == "Ham")
                MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            else if (((StackPanel)e.ClickedItem).Name == "Fournisseurs")
                MyFrame.Navigate(typeof(Client_Fournisseur), "Fournisseurs");
            else if (((StackPanel)e.ClickedItem).Name == "Clients")
                MyFrame.Navigate(typeof(Client_Fournisseur), "Clients");
            else if (((StackPanel)e.ClickedItem).Name == "Factures")
            {
                if (qualifiers["DeviceFamily"] == "Mobile")
                {
                    MyFrame.Navigate(typeof(FacturesPhone));
                }
                else
                    MyFrame.Navigate(typeof(Factures));
            }

            else if (((StackPanel)e.ClickedItem).Name == "Produits")
            {
                if (qualifiers["DeviceFamily"] == "Mobile")
                    MyFrame.Navigate(typeof(ProduitsPhone));
                else
                    MyFrame.Navigate(typeof(Produits));
            }
        }

        private async void RecupDonnees()
        {
            await Modele.LoadData();
            Modele.Resultat();
            MyFrame.Navigate(typeof(Views.Dashboard));
            NavigationCortana.Navigation(MyFrame);
        } 
    }
}
