using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPService.MyWebService;

namespace UWPService.Items
{
    public static class VariableGlobale
    {
        public static string command { get; set; }
        public static ObservableCollection<Supplier> Fournisseurs { get; set; }
        public static ObservableCollection<Customer> Clients { get; set; }
        public static ObservableCollection<Vente> IVente { get; set; }
        public static ObservableCollection<Resultat> IResultat { get; set;}
        public static ObservableCollection<Client> IClient { get; set; }
        public static ObservableCollection<Product> Produits { get; set; }
        public static ObservableCollection<OrderItem> FacturesElement { get; set; }
        public static ObservableCollection<Order> Factures { get; set; }
    }
}
