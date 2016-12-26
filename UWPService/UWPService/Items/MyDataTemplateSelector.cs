using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPService.MyWebService;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPService.Items
{
    public class MyDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SupplierTemplate { get; set; }
        public DataTemplate CustomerTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item,DependencyObject container)
        {
            if (item is Supplier)
                return SupplierTemplate;
            if (item is Customer)
                return CustomerTemplate;

            return base.SelectTemplateCore(item, container);
        }
    }
}
