namespace UWPService.Views
{
    partial class Dashboard : 
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
                    this.MyRelativePanel = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.BubbleChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 3:
                {
                    this.SuivantB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 34 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.SuivantB).PointerPressed += this.SuivantB_PointerPressed;
                    #line 34 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.SuivantB).PointerEntered += this.SuivantB_PointerEntered;
                    #line 34 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.SuivantB).PointerExited += this.SuivantB_PointerExited;
                    #line default
                }
                break;
            case 4:
                {
                    this.PrecedentB = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 35 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.PrecedentB).PointerPressed += this.PrecedentB_PointerPressed;
                    #line 35 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.PrecedentB).PointerEntered += this.PrecedentB_PointerEntered;
                    #line 35 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.PrecedentB).PointerExited += this.PrecedentB_PointerExited;
                    #line default
                }
                break;
            case 5:
                {
                    this.Titre3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.PieChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 7:
                {
                    this.Titre2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.AreaChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
                }
                break;
            case 9:
                {
                    this.Suivant = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 20 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Suivant).PointerPressed += this.Suivant_PointerPressed;
                    #line 20 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Suivant).PointerEntered += this.Suivant_PointerEntered;
                    #line 20 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Suivant).PointerExited += this.Suivant_PointerExited;
                    #line default
                }
                break;
            case 10:
                {
                    this.Precedent = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 21 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Precedent).PointerPressed += this.Precedent_PointerPressed;
                    #line 21 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Precedent).PointerEntered += this.Precedent_PointerEntered;
                    #line 21 "..\..\..\Views\Dashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Precedent).PointerExited += this.Precedent_PointerExited;
                    #line default
                }
                break;
            case 11:
                {
                    this.Titre1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

