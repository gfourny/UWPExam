﻿#pragma checksum "C:\Users\ehounguevou\Documents\GitHub\UWPExam\UWPService\UWPService\Views\Produits.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1748FAD9E73A3538DF5EADBC91F0F723"
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
    partial class Produits : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ContentPresenter_Content(global::Windows.UI.Xaml.Controls.ContentPresenter obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
        };

        private class Produits_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IProduits_Bindings
        {
            private global::UWPService.Views.Produits dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ContentPresenter obj3;

            private Produits_obj1_BindingsTracking bindingsTracking;

            public Produits_obj1_Bindings()
            {
                this.bindingsTracking = new Produits_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ContentPresenter)target;
                        break;
                    default:
                        break;
                }
            }

            // IProduits_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // Produits_obj1_Bindings

            public void SetDataRoot(global::UWPService.Views.Produits newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::UWPService.Views.Produits obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MasterListView(obj.MasterListView, phase);
                    }
                }
            }
            private void Update_MasterListView(global::Windows.UI.Xaml.Controls.ListView obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MasterListView(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MasterListView_SelectedItem(obj.SelectedItem, phase);
                    }
                }
            }
            private void Update_MasterListView_SelectedItem(global::System.Object obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentPresenter_Content(this.obj3, obj, null);
                }
            }

            private class Produits_obj1_BindingsTracking
            {
                global::System.WeakReference<Produits_obj1_Bindings> WeakRefToBindingObj; 

                public Produits_obj1_BindingsTracking(Produits_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Produits_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_MasterListView(null);
                }

                public void DependencyPropertyChanged_MasterListView_SelectedItem(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    Produits_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.ListView obj = sender as global::Windows.UI.Xaml.Controls.ListView;
        if (obj != null)
        {
            bindings.Update_MasterListView_SelectedItem(obj.SelectedItem, DATA_CHANGED);
        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.ListView cache_MasterListView = null;
                private long tokenDPC_MasterListView_SelectedItem = 0;
                public void UpdateChildListeners_MasterListView(global::Windows.UI.Xaml.Controls.ListView obj)
                {
                    if (obj != cache_MasterListView)
                    {
                        if (cache_MasterListView != null)
                        {
                            cache_MasterListView.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ListView.SelectedItemProperty, tokenDPC_MasterListView_SelectedItem);
                            cache_MasterListView = null;
                        }
                        if (obj != null)
                        {
                            cache_MasterListView = obj;
                            tokenDPC_MasterListView_SelectedItem = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.ListView.SelectedItemProperty, DependencyPropertyChanged_MasterListView_SelectedItem);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.MasterListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 18 "..\..\..\Views\Produits.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.MasterListView).ItemClick += this.MasterListView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.DetailContentPresenter = (global::Windows.UI.Xaml.Controls.ContentPresenter)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Produits_obj1_Bindings bindings = new Produits_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

