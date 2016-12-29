using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPService.MyWebService;

namespace UWPService.Items
{
    public partial class ResultatPie : Resultat
    {
        public string MonthToString { get; set; }

        public ResultatPie()
        {
            
        }

        public void AffectMonthToString()
        {
            switch(Month)
            {
                case 1:
                    MonthToString = Mois.Janvier.ToString();
                    break;
                case 2:
                    MonthToString = Mois.Février.ToString();
                    break;
                case 3:
                    MonthToString = Mois.Mars.ToString();
                    break;
                case 4:
                    MonthToString = Mois.Avril.ToString();
                    break;
                case 5:
                    MonthToString = Mois.Mai.ToString();
                    break;
                case 6:
                    MonthToString = Mois.Juin.ToString();
                    break;
                case 7:
                    MonthToString = Mois.Juillet.ToString();
                    break;
                case 8:
                    MonthToString = Mois.Août.ToString();
                    break;
                case 9:
                    MonthToString = Mois.Septembre.ToString();
                    break;
                case 10:
                    MonthToString = Mois.Octobre.ToString();
                    break;
                case 11:
                    MonthToString = Mois.Novembre.ToString();
                    break;
                case 12:
                    MonthToString = Mois.Décembre.ToString();
                    break;
            }
        }
    }

    public enum Mois { Janvier, Février, Mars, Avril, Mai, Juin, Juillet, Août, Septembre, Octobre, Novembre, Décembre } 
}
