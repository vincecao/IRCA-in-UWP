﻿#pragma checksum "C:\Users\qq234\Documents\Visual Studio 2017\Projects\IRCA\IRCA\fullScreenImage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7DCB6C3D3B912ED83FFF65B9DD4B2422"
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
    partial class fullScreenImage : 
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
                    this.coordinateLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.FullScreenImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.CanvasGird = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 51 "..\..\..\fullScreenImage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.CanvasGird).PointerPressed += this.CanvasGird_PointerPressed;
                    #line default
                }
                break;
            case 4:
                {
                    this.addObjectBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\fullScreenImage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.addObjectBtn).Tapped += this.stepTextBlock_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.nameTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

