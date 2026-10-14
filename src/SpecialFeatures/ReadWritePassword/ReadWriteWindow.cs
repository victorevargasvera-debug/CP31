namespace SpecialFeatures.ReadWritePassword
{
    using SpecialFeatures.ReadWriteTlsPsk;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class ReadWriteWindow : Window, IComponentConnector
    {
        private bool a;
        private bool b;
        private bool c;
        private string d;
        private ReadWriteUtil e;
        private readonly ReadWriteTlsPskHelper f;
        private readonly ReadWritePasswordApp g;
        internal ReadWriteWindow ReadWritePassword;
        internal CheckBox checkRead;
        internal CheckBox checkWrite;
        internal CheckBox checkSave;
        internal TextBlock PasswordNote;
        internal Button CancelButton;
        internal Button passwdWindowHelpbutton;
        internal Button ModifyButton;
        internal Button ChangePasswordButton;
        private bool h;

        public ReadWriteWindow();
        private void a();
        private void b();
        private void c();
        private void d();
        private void e();
        private void f();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        private void g();
        private void h();
        private void i();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OnClick_OK(object A_0, RoutedEventArgs A_1);
        private void OnClickCancel(object A_0, RoutedEventArgs A_1);
        private void OnClickChangePassword(object A_0, RoutedEventArgs A_1);
        private void OnClickModifyPermissions(object A_0, RoutedEventArgs A_1);
        private void OnHelpButton_Click(object A_0, RoutedEventArgs A_1);
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

