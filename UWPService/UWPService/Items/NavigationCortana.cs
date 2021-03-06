﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPService.MyWebService;
using UWPService.Views;
using Windows.UI.Xaml.Controls;

namespace UWPService.Items
{
    public static class NavigationCortana
    {
        public static void Navigation(Frame MyFrame)
        {
            Dictionary<string, string> valuesCommand = GetValuesFromCommand();
            if (valuesCommand.ContainsKey("FrameName"))
            {
                switch (valuesCommand["FrameName"])
                {
                    case "clients":
                        MyFrame.Navigate(typeof(Client_Fournisseur), "Clients");
                        break;
                    case "client":
                        if (valuesCommand["options"].Contains("id"))
                            MyFrame.Navigate(typeof(Clients_Fournisseur_Detaille), Modele.GetCustomerById(GetIdFromString(valuesCommand["options"])));
                        else
                            MyFrame.Navigate(typeof(Clients_Fournisseur_Detaille), Modele.GetCustomerFromLastNameAndFirstName(valuesCommand["options"]));
                        break;
                    case "fournisseur":
                        if (valuesCommand["options"].Contains("id"))
                            MyFrame.Navigate(typeof(Clients_Fournisseur_Detaille), Modele.GetSupplierById(GetIdFromString(valuesCommand["options"])));
                        else
                            MyFrame.Navigate(typeof(Clients_Fournisseur_Detaille), Modele.GetSupplierFromCompanyName(valuesCommand["options"]));
                        break;
                    case "fournisseurs":
                        MyFrame.Navigate(typeof(Client_Fournisseur), "Fournisseurs");
                        break;
                    case "factures":
                    case "facture":
                        if (!valuesCommand.ContainsKey("options"))
                            MyFrame.Navigate(typeof(Factures));
                        else if (valuesCommand["options"].Contains("client"))
                            MyFrame.Navigate(typeof(Factures), Modele.GetCustomerFromLastNameAndFirstName(GetNameFromString(valuesCommand["options"])));
                        else
                            MyFrame.Navigate(typeof(Factures), Modele.GetOrderFromNumber(GetOrderNumberFromString(valuesCommand["options"])));
                        break;
                    case "produits":
                    case "produit":

                        if (!valuesCommand.ContainsKey("options"))
                            MyFrame.Navigate(typeof(Produits));
                        else if (valuesCommand["options"].Contains("id"))
                            MyFrame.Navigate(typeof(Produits), Modele.GetProductById(GetIdFromString(valuesCommand["options"])));
                        else
                            MyFrame.Navigate(typeof(Produits), Modele.GetProductFromName(valuesCommand["options"]));

                        break;
                    case "création":
                        if (valuesCommand["options"].Contains("client"))
                            MyFrame.Navigate(typeof(Clients_Fournisseur_Detaille), new Customer() { Id = (VariableGlobale.Clients.Count + 1) });
                        else if (valuesCommand["options"].Contains("fournisseur"))
                            MyFrame.Navigate(typeof(Clients_Fournisseur_Detaille), new Supplier() { Id = (VariableGlobale.Fournisseurs.Count + 1) });
                        break;
                    default:
                        break;
                }

                Items.VariableGlobale.command = string.Empty;
            }
        }

        private static string GetNameFromString(string value)
        {
            string[] stringSeparators = new string[] { "du client " };
            string[] result = value.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            return result[0];
        }

        private static int GetIdFromString(string value)
        {
            string[] stringSeparators = new string[] { "dont l'id est égal à " };
            string[] result = value.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            return Convert.ToInt32(result[0]);
        }

        private static string GetOrderNumberFromString(string value)
        {
            string[] stringSeparators = new string[] { "numéro " };
            string[] result = value.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            return result[0];
        }

        private static Dictionary<string, string> GetValuesFromCommand()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            if (VariableGlobale.command != null)
            {
                string[] values = VariableGlobale.command.Split(' ');

                for (int i = 0; i < values.Count(); i++)
                {
                    if (result.ContainsKey("FrameName"))
                        if (!result.ContainsKey("options"))
                            result.Add("options", values[i]);
                        else
                            result["options"] = string.Format("{0} {1}", result["options"], values[i]);

                    if (IsWindowFrameName(values[i]) && !result.ContainsKey("FrameName"))
                        result.Add("FrameName", values[i]);
                }
            }
            return result;
        }

        private static bool IsWindowFrameName(string value)
        {
            return (value.ToLower().Contains("client") || value.ToLower().Contains("fournisseur") || value.ToLower().Contains("panier") || value.ToLower().Contains("produit") || value.ToLower().Contains("facture") || value.ToLower().Contains("création"));
        }
    }
}