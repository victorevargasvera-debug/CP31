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

    public class InitReadWritePassword : Window, IComponentConnector
    {
        private string a;
        internal PasswordBox ConfirmpasswordBox;
        internal PasswordBox EnterPasswordBox;
        internal Button Okbutton;
        internal Button CancelButton;
        internal Label ConfirmPasswordText;
        internal Label EnterPasswordText;
        internal Label label1;
        internal CheckBox RememberPasswordSession;
        internal Button initialPasswdHelpButton;
        private bool b;

        public InitReadWritePassword();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnClickCancel(object A_0, RoutedEventArgs A_1);
        private void OnClickOK(object A_0, RoutedEventArgs A_1);
        private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        internal string UserEnteredPassword { get; set; }
    }
}

