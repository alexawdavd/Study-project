// Updated by XamlIntelliSenseFileGenerator 08.02.2022 2:24:49
#pragma checksum "..\..\..\GlavnayaWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F9046398FEF24F9CE9E83330BE5BFC4F49F82AAB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PP02;
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


namespace PP02
{


    /// <summary>
    /// GlavnayaWindow
    /// </summary>
    public partial class GlavnayaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PP02;V1.0.0.0;component/glavnayawindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\GlavnayaWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 14 "..\..\..\GlavnayaWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ExitProgramMenuItem_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TabControl mainTabControl;
        internal System.Windows.Controls.Button addComponentButton;
        internal System.Windows.Controls.Button updateComponentButton;
        internal System.Windows.Controls.Button deleteComponentButton;
        internal System.Windows.Controls.Button addDeviceButton;
        internal System.Windows.Controls.Button updateDeviceButton;
        internal System.Windows.Controls.Button deleteDeviceButton;
        internal System.Windows.Controls.DataGrid componentDataGrid;
        internal System.Windows.Controls.DataGrid deviceDataGrid;
        internal System.Windows.Controls.TextBox componentNameTextBox;
        internal System.Windows.Controls.TextBox ammountTextBox;
        internal System.Windows.Controls.TextBox transactionDescriptionTextBox;
        internal System.Windows.Controls.TextBox transactionAmountTextBox;
        internal System.Windows.Controls.Button addTransactionButton;
        internal System.Windows.Controls.Button updateTransactionButton;
        internal System.Windows.Controls.Button deleteTransactionButton;
        internal System.Windows.Controls.DataGrid transactionDataGrid;
        internal System.Windows.Controls.TextBox loginTextBox;
        internal System.Windows.Controls.TextBox passwordTextBox;
        internal System.Windows.Controls.ComboBox positionComboBox;
        internal System.Windows.Controls.Button addUserButton;
        internal System.Windows.Controls.Button updateUserButton;
        internal System.Windows.Controls.Button deleteUserButton;
        internal System.Windows.Controls.DataGrid userDataGrid;
    }
}

