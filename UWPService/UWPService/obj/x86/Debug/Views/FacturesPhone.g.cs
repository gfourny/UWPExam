﻿#pragma checksum "C:\Users\tbadi\Documents\GitHub\UWPExam\UWPService\UWPService\Views\FacturesPhone.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B668637467DDC6021D81D62B8CBD80D"
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
    partial class FacturesPhone : 
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
                    this.MyFlipView = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 3:
                {
                    this.tete = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 14 "..\..\..\Views\FacturesPhone.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tete).ItemClick += this.tete_ItemClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.tutu = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 26 "..\..\..\Views\FacturesPhone.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.tutu).ItemClick += this.tutu_ItemClick;
                    #line default
                }
                break;
            case 5:
                {
                    this.OrderForm = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 6:
                {
                    this.panelCustomer = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 7:
                {
                    this.panelOrder = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 8:
                {
                    this.lv = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 9:
                {
                    this.HeaderNumFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.NumFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.HeaderDatFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.DatFact = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13:
                {
                    this.HeaderPrixTTC = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14:
                {
                    this.PrixTTC = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.HeaderNomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.NomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.HeaderPrenomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.PrenomClient = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

