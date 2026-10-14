namespace SpecialFeatures.PasswordResetFile
{
    using SpecialFeatures.FileOperations;
    using SpecialFeatures.ReadWritePassword;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    public class PageResetRadioPasswordProgress : PageFunction<DialogResult>, IDisposable, IComponentConnector
    {
        private readonly FileOperationData a;
        private readonly ReadWritePasswordApp b;
        private BackgroundWorker c;
        internal Grid Header;
        internal Rectangle Divider_Copy;
        internal Label ViewboxTitle;
        internal GroupBox GrpbxRadioParams;
        internal Label lblRadioModel;
        internal TextBox RadioModelTextBox;
        internal Label lblRadioSerialNo;
        internal TextBox RadioSerialNoTextBox;
        internal GroupBox GrpbxProgress;
        internal StackPanel stackMoreInfo;
        internal Label ConnectingToRadioLabel;
        internal BusyIndicator ConnectBusyIndicator;
        internal BusyIndicator VerifyBusyIndicator;
        internal BusyIndicator ResetFileValidationIndicator;
        internal BusyIndicator ResetIndicator;
        internal FlowDocumentScrollViewer ProgText;
        internal Paragraph myStsParagraph;
        internal ProgressBar progressBar2;
        internal Button CloseBtn;
        internal Button HelpBtn;
        private bool d;

        public PageResetRadioPasswordProgress(FileOperationData flashData, ReadWritePasswordApp readWritePasswordApp);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        internal Delegate _CreateDelegate(Type delegateType, string handler);
        private void a();
        private void a(UserState A_0);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        public void FlashportPage_Return(object sender, ReturnEventArgs<DialogResult> e);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void NavigationService_Navigating(object A_0, NavigatingCancelEventArgs A_1);
        private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1);
        private void OnBackgroundWorkerDoWork(object A_0, DoWorkEventArgs A_1);
        private void OnBackgroundWorkerProgressChanged(object A_0, ProgressChangedEventArgs A_1);
        private void OnBackgroundWorkerRunWorkerCompleted(object A_0, RunWorkerCompletedEventArgs A_1);
        private void Page_Loaded(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void UploadPasswordResetFile(string A_0, DoWorkEventArgs A_1);
    }
}

