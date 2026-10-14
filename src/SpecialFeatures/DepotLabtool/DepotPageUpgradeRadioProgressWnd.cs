namespace SpecialFeatures.DepotLabtool
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class DepotPageUpgradeRadioProgressWnd : Window, IDisposable, IComponentConnector
    {
        private string a;
        private string b;
        private UpgradeRadioData c;
        private BackgroundWorker d;
        internal GroupBox GrpbxProgress;
        internal StackPanel stackMoreInfo;
        internal Label ConnectingToRadioLabel;
        internal ProgressBar progressBar2;
        internal TextBox ProgText;
        internal Button CloseBtn;
        private bool e;

        public DepotPageUpgradeRadioProgressWnd(UpgradeRadioData upgradeRadioData);
        private void a();
        private void backgroundWorker1_DoWork(object A_0, DoWorkEventArgs A_1);
        private void backgroundWorker1_ProgressChanged(object A_0, ProgressChangedEventArgs A_1);
        private void backgroundWorker1_RunWorkerCompleted(object A_0, RunWorkerCompletedEventArgs A_1);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        private long FlashRadio(UpgradeRadioData A_0, BackgroundWorker A_1, DoWorkEventArgs A_2);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void ObButtonClick_Close(object A_0, RoutedEventArgs A_1);
        private void Page_Loaded(object A_0, RoutedEventArgs A_1);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

