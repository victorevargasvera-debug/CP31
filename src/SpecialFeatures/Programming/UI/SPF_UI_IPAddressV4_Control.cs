namespace SpecialFeatures.Programming.UI
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Net;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class SPF_UI_IPAddressV4_Control : UserControl, IComponentConnector
    {
        private bool a;
        private TextBox b;
        private TextBox c;
        private bool d;
        internal StackPanel ipAddressStackPanel;
        internal IPTextBox ip1TextBox;
        internal IPTextBox ip2TextBox;
        internal IPTextBox ip3TextBox;
        internal IPTextBox ip4TextBox;
        internal IPTextBox portTextBox;
        private bool e;

        public SPF_UI_IPAddressV4_Control();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        internal Delegate _CreateDelegate(Type delegateType, string handler);
        private int a(Key A_0);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void ipAddressStackPanel_PreviewGotKeyboardFocus(object A_0, KeyboardFocusChangedEventArgs A_1);
        private void ipAddressStackPanel_PreviewKeyDown(object A_0, KeyEventArgs A_1);
        private void ipAddressStackPanel_PreviewLostKeyboardFocus(object A_0, KeyboardFocusChangedEventArgs A_1);
        private void ipAddressStackPanel_PreviewTextInput(object A_0, TextCompositionEventArgs A_1);
        private void ipAddressStackPanel_TextChanged(object A_0, TextChangedEventArgs A_1);
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e);
        private void SPF_UI_IPAddressV4_Control_Loaded(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        protected void TestPropertyChanged(object sender, EventArgs e);

        public bool ReadOnly { get; set; }

        internal string sIP_Address { get; set; }

        public IPAddress IP_Address { get; }

        public int Port { get; }
    }
}

