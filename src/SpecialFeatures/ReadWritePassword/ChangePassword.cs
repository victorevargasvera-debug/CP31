namespace SpecialFeatures.ReadWritePassword
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class ChangePassword : Window, IComponentConnector
    {
        private string a;
        private string b;
        [CompilerGenerated]
        private bool c;
        internal ChangePassword changePassword;
        internal Grid windowGrid;
        internal Label CurrentPasswordText;
        internal Label NewPasswordText;
        internal Label ConfirmPasswordText;
        internal PasswordBox CurrentPasswordBox;
        internal PasswordBox NewPasswordBox;
        internal PasswordBox ConfirmPasswordBox;
        internal Button OK;
        internal Button Cancel;
        internal Button changePasswdHelpbutton;
        private bool d;

        internal ChangePassword(string codeplugPassword);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnClickCancel(object A_0, RoutedEventArgs A_1);
        private void OnClickOK(object A_0, RoutedEventArgs A_1);
        private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        public bool IsCancelButtonClicked { get; set; }

        internal string UserEnteredPassword { get; set; }
    }
}

