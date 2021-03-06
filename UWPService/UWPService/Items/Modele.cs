﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPService.MyWebService;

namespace UWPService.Items
{
    public static class Modele
    {
        public async static Task LoadData()
        {
            YnovServiceClient ysc = new YnovServiceClient();
            VariableGlobale.IVente = await ysc.VentesAsync();
            VariableGlobale.IResultat = await ysc.ResultatsAsync();
            VariableGlobale.IClient = await ysc.ClientsAsync();
            VariableGlobale.Fournisseurs = await ysc.GetAllSuppliersAsync();
            VariableGlobale.Clients = await ysc.GetCustomersAsync();
            VariableGlobale.Produits = await ysc.GetAllProductsAsync();
            VariableGlobale.Factures = await ysc.GetAllOrderAsync();
            VariableGlobale.FacturesElement = await ysc.GetAllOrderItemAsync();
            await ysc.CloseAsync();
        }

        #region Méthodes CLIENT
        /// <summary>
        /// Vérifie si un client est présent dans l'observable collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool IsCustomerPresent(int id)
        {
            return VariableGlobale.Clients.Any(x => x.Id == id);
        }

        /// <summary>
        /// Obtention d'un client par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Customer GetCustomerById(int id)
        {
            return VariableGlobale.Clients.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Obtention du client par son nom et son prénom
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Customer GetCustomerFromLastNameAndFirstName(string value)
        {
            Customer client = VariableGlobale.Clients.FirstOrDefault(x => x.FirstName == value.Split(' ')[0] && x.LastName == value.Split(' ')[1]);

            if(client == null)
                client = VariableGlobale.Clients.FirstOrDefault(x => x.FirstName == value.Split(' ')[1] && x.LastName == value.Split(' ')[0]);

            return client;
        }

        /// <summary>
        /// Ajout d'un client
        /// </summary>
        /// <param name="client"></param>
        public static void AddCustomer(Customer client)
        {
            VariableGlobale.Clients.Add(client);
        }
        
        /// <summary>
        /// Suppression d'un client
        /// </summary>
        /// <param name="client"></param>
        public static void RemoveCustomer(Customer client)
        {
            VariableGlobale.Clients.Remove(client);
        }

        /// <summary>
        /// Mise à jour d'un client
        /// </summary>
        /// <param name="oldCustomer"></param>
        /// <param name="newCustomer"></param>
        public static void UpdateCustomer(Customer oldCustomer, Customer newCustomer)
        {
            RemoveCustomer(oldCustomer);
            AddCustomer(newCustomer);
        }
        #endregion

        #region Méthodes FOURNISSEUR
        /// <summary>
        /// Vérifié si un fournisseur est présent
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool IsSupplierPresent(int id)
        {
            return VariableGlobale.Fournisseurs.Any(x => x.Id == id);
        }

        /// <summary>
        /// Obtention d'un fournisseur en fonction de l'id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Supplier GetSupplierById(int id)
        {
            return VariableGlobale.Fournisseurs.FirstOrDefault(x => x.Id == id);
        }

        public static Supplier GetSupplierFromCompanyName(string value)
        {           
            return VariableGlobale.Fournisseurs.FirstOrDefault(x => x.CompanyName == value);
        }

        /// <summary>
        /// Ajout d'un fournisseur
        /// </summary>
        /// <param name="fournisseur"></param>
        public static void AddSupplier(Supplier fournisseur)
        {
            VariableGlobale.Fournisseurs.Add(fournisseur);
        }

        /// <summary>
        /// Suppression d'un fournisseur
        /// </summary>
        /// <param name="fournisseur"></param>
        public static void RemoveSupplier(Supplier fournisseur)
        {
            VariableGlobale.Fournisseurs.Remove(fournisseur);
        }

        /// <summary>
        /// Mise à jour d'un fournisseur
        /// </summary>
        /// <param name="oldSupplier"></param>
        /// <param name="newSupplier"></param>
        public static void UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            RemoveSupplier(oldSupplier);
            AddSupplier(newSupplier);
        }
        #endregion

        #region Méthode Résultat
        /// <summary>
        /// Ecrit les mois en string et non en int
        /// </summary>
        public static void Resultat()
        {
            VariableGlobale.Resultats = new ObservableCollection<ResultatPie>();
            foreach (Resultat item in VariableGlobale.IResultat)
            {
                ResultatPie item2 = new ResultatPie() { Year = item.Year, Amount = item.Amount, Month = item.Month };
                item2.AffectMonthToString();
                VariableGlobale.Resultats.Add(item2);
            }
        }
        #endregion

        #region Méthode PRODUIT
        public static Product GetProductById(int id)
        {
            return VariableGlobale.Produits.FirstOrDefault(x => x.Id == id);
        }

        public static Product GetProductFromName(string value)
        {
            return VariableGlobale.Produits.FirstOrDefault(x => x.ProductName == value);
        }
        #endregion

        #region Méthode FACTURE
        public static Order GetOrderFromNumber(string value)
        {
            return VariableGlobale.Factures.FirstOrDefault(x => x.OrderNumber == value);
        }
        #endregion
    }
}
