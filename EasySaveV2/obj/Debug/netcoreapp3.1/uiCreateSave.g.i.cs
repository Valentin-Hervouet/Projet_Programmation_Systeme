// Updated by XamlIntelliSenseFileGenerator 15/12/2022 13:12:27
#pragma checksum "..\..\..\uiCreateSave.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718E3761BDE77D848BBD853BC81F8E6E845E010F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using EasySaveV2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EasySaveV2
{


    /// <summary>
    /// uiCreateSave
    /// </summary>
    public partial class uiCreateSave : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 11 "..\..\..\uiCreateSave.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Create;

#line default
#line hidden


#line 12 "..\..\..\uiCreateSave.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name;

#line default
#line hidden


#line 15 "..\..\..\uiCreateSave.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Source;

#line default
#line hidden


#line 16 "..\..\..\uiCreateSave.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Dest;

#line default
#line hidden


#line 19 "..\..\..\uiCreateSave.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Type;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EasySaveV2;component/uicreatesave.xaml", System.UriKind.Relative);

#line 1 "..\..\..\uiCreateSave.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Create = ((System.Windows.Controls.Button)(target));
                    return;
                case 2:
                    this.Name = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.Source = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.Dest = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.Type = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.Close = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

