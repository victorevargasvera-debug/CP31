namespace SpecialFeatures.Comms
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Forms;
    using System.Windows.Markup;
    using System.Windows.Shapes;

    public class LoadTxmCertificateMenu : Window, IDisposable, IComponentConnector
    {
        public bool bCommSuccess;
        private string a;
        private string b;
        private OpenFileDialog c;
        internal Grid Header;
        internal Rectangle Divider_Copy;
        internal Label ViewboxTitle;
        internal StackPanel stackMoreInfo;
        internal Label BrowseCertificateLabel;
        internal TextBox TxtBoxCertFile;
        internal TextBlock ButtonBlock;
        internal Button LoadButton;
        internal Button CloseBtn;
        private bool d;

        public LoadTxmCertificateMenu(string initDir);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        public void OnButtonClick_BrowseCert(object sender, EventArgs args);
        private void OnButtonClick_Close(object A_0, RoutedEventArgs A_1);
        public void OnButtonClick_LoadCert(object sender, EventArgs args);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
    }
}

