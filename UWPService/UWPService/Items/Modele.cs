using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPService.MyWebService;

namespace UWPService.Items
{
    public static class Modele
    {
        public async static void LoadData()
        {
            YnovServiceClient ysc = new YnovServiceClient();
            VariableGlobale.Fournisseurs = await ysc.GetAllSuppliersAsync();
            VariableGlobale.Clients = await ysc.GetCustomersAsync();
            await ysc.CloseAsync();
        }
    }
}
