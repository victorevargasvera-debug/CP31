namespace SpecialFeatures.Comms
{
    using SpecialFeatures.FileOperations;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;
    using System.Windows.Shapes;

    public class ProgressUpdate : Window, IDisposable, IComponentConnector
    {
        public bool bCommSuccess;
        internal Grid Header;
        internal Rectangle Divider_Copy;
        internal Label ViewboxTitle;
        internal GroupBox GrpbxProgress;
        internal StackPanel stackMoreInfo;
        internal Label ConnectingToRadioLabel;
        internal BusyIndicator ConnectingToRadioIndicator;
        internal TextBlock ConnectText;
        internal BusyIndicator ReadingRadioInformationIndicator;
        internal TextBlock RadioInfoText;
        internal BusyIndicator CodeplugIndicator;
        internal TextBlock CodeplugText;
        internal BusyIndicator VerificationIndicator;
        internal TextBlock VerificationText;
        internal TextBox ProgText;
        internal ProgressBar progressBar2;
        internal Button CloseBtn;
        private bool a;

        public ProgressUpdate();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        internal Delegate _CreateDelegate(Type delegateType, string handler);
        public void ClearStatus();
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1);
        protected override void OnClosing(CancelEventArgs e);
        private void Page_Loaded(object A_0, RoutedEventArgs A_1);
        public void ProgressUpdat(object sender, ProgressChangedEventArgs e);
        public void SetCloseBtnEnable(bool isEnable);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

