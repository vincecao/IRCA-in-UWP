﻿#pragma checksum "C:\Users\qq234\Documents\GitHub\IRCA-in-UWP\IRCA\parentPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6121580FEC6771362A6BD62FC946956"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRCA
{
    partial class parentPage : 
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
                    this.btnStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 2:
                {
                    this.deleteBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 135 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.deleteBtn).Click += this.deleteBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.saveBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 149 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.saveBtn).Click += this.saveBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.inkListPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 5:
                {
                    this.importBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6:
                {
                    this.addObjectBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7:
                {
                    this.nameFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 8:
                {
                    this.Record = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 102 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Record).Click += this.Record_ClickAsync;
                    #line default
                }
                break;
            case 9:
                {
                    this.suggestionBox_stackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 10:
                {
                    this.nameTextBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 114 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.nameTextBox).TextChanged += this.AutoSuggestBox_TextChanged;
                    #line 115 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.nameTextBox).QuerySubmitted += this.AutoSuggestBox_QuerySubmittedAsync;
                    #line default
                }
                break;
            case 11:
                {
                    this.importFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 12:
                {
                    this.cameraBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 67 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.cameraBtn).Click += this.cameraBtn_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.galleryBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\parentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.galleryBtn).Click += this.galleryBtn_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.coordinateLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.imageFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 16:
                {
                    this.inkCanvasGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 17:
                {
                    this.stepTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

