namespace SpecialFeatures.SystemCertificates.List
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Markup;

    public class CustomSelectWindow : Window, IDisposable, IComponentConnector
    {
        private BackgroundWorker a;
        [CompilerGenerated]
        private List<string> b;
        [CompilerGenerated]
        private List<CertFileItem> c;
        [CompilerGenerated]
        private List<CertFileItem> d;
        private ObservableCollection<CertFileItem> e;
        private SelectionMode f;
        internal ListBox CertFileListBox;
        internal Button OKButton;
        internal Button CancelButton;
        private bool g;

        public CustomSelectWindow();
        private void a(List<CertFileItem> A_0);
        private void CancelButton_Click(object A_0, RoutedEventArgs A_1);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        private void downLoadWorker_DoWork(object A_0, DoWorkEventArgs A_1);
        private void downLoadWorker_ProgressChanged(object A_0, ProgressChangedEventArgs A_1);
        private void downLoadWorker_RunWorkerCompleted(object A_0, RunWorkerCompletedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OKButton_Click(object A_0, RoutedEventArgs A_1);
        private void OnLoaded(object A_0, RoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode, EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        private void Window_Closing(object A_0, CancelEventArgs A_1);

        public List<string> SelectedCertFiles { get; set; }

        public List<CertFileItem> PlanToDownloadFileList { get; set; }

        public List<CertFileItem> DownloadedFileList { get; set; }

        public ObservableCollection<CertFileItem> CertFileItems { get; set; }

        internal SelectionMode CertFileListBoxSelectionMethod { get; set; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass27_0
        {
            public string msg;

            public <>c__DisplayClass27_0();
            internal void <ShowErrorForCannotDownloadCertFiles>b__0();
        }
    }
}

