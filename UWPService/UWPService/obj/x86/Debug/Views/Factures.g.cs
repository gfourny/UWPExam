﻿#pragma checksum "C:\Users\tbadi\Documents\GitHub\UWPExam\UWPService\UWPService\Views\Factures.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B7E1F874799F6C0D5AC3E755D4EFBAD5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPService.Views
{
    partial class Factures : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.WindowsTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.tete = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 13 "..\..\..\Views\Factures.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tete).ItemClick += this.tete_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.tutu = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 25 "..\..\..\Views\Factures.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tutu).ItemClick += this.tutu_ItemClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.OrderForm = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 5:
                {
                    this.panelCustomer = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 6:
                {
                    this.panelOrder = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 7:
                {
                    this.lv = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 8:
                {
                    this.HeaderNumFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.NumFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.HeaderDatFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.DatFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.HeaderPrixTTC = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.PrixTTC = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.HeaderNomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.NomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.HeaderPrenomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.PrenomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.VisualState0min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 19:
                {
                    this.VisualState320min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 20:
                {
                    this.VisualState548min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 21:
                {
                    this.VisualState720min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 22:
                {
                    this.VisualState1024min = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

