namespace SpecialFeatures.ReadWritePassword
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class PromptReadWritePassword : Window, IComponentConnector
    {
        private string a;
        private bool b;
        internal PasswordBox CodeplugPasswordBox;
        internal Label CodeplugPasswordText;
        internal Label SerialNumberText;
        internal Label SerialNumberValue;
        internal Button OKButton;
        internal Button CancelButton;
        internal Label label1;
        internal CheckBox RememberPasswordSession;
        internal Button promptPasswdHelpButton;
        private bool c;

        public PromptReadWritePassword();
        public PromptReadWritePassword(string serialNumber);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnClickCancel(object A_0, RoutedEventArgs A_1);
        private void OnClickOK(object A_0, RoutedEventArgs A_1);
        private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);

        internal bool IsCanceled { get; }

        internal string UserEnteredPassword { get; set; }
    }
}

