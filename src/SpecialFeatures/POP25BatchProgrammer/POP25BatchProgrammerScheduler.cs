namespace SpecialFeatures.POP25BatchProgrammer
{
    using DevComponents.WpfEditors;
    using SpecialFeatures;
    using SSLAdminTool;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Threading;
    using System.Xml.Serialization;

    public class POP25BatchProgrammerScheduler : Window, INotifyPropertyChanged, IComponentConnector
    {
        private TimeSpan a;
        private DispatcherTimer b;
        private string c;
        private SpecialFeaturesSettings d;
        private Collection<SystemKeyData> e;
        private string f;
        private string g;
        private byte[] h;
        private IDataStoreDecryptHandler i;
        private List<PNServer> j;
        private XmlSerializer k;
        private RadioList l;
        [CompilerGenerated]
        private bool m;
        [CompilerGenerated]
        private PropertyChangedEventHandler n;
        internal Label lbDateTime;
        internal DateTimeInput dtSchedulerDateTime;
        internal Label lbRadioListFilePath;
        internal TextBox txtboxRadioListFilePath;
        internal Button btnRadioListFilePathBrowse;
        internal GroupBox groupBoxARS;
        internal CheckBox chkboxStaticIpAddress;
        internal Label lbArsServerIpAddress;
        internal ComboBox autoRegServer;
        internal Label lbArsConnectionType;
        internal TextBox txtboxConnectionType;
        internal Label lbAvailableRadios;
        internal Label lbSelectedRadios;
        internal DataGrid dgAvailableRadio;
        internal DataGrid dgSelectedRadios;
        internal Button btnAdd;
        internal Button btnAddAll;
        internal Button btnRemove;
        internal Button btnRemoveAll;
        internal Label lbNumRetries;
        internal ComboBox txtbxNumRetries;
        internal CheckBox chkboxWriteProtect;
        internal Button btnStart;
        internal Button btnCancel;
        internal Button btnHelp;
        private bool o;

        public event PropertyChangedEventHandler PropertyChanged;

        public POP25BatchProgrammerScheduler();
        private void a();
        private string a(IPAddress A_0);
        private bool a(string A_0);
        private bool a(POP25RadioInfo A_0, POP25RadioInfo A_1);
        private bool a(PNServer A_0, ref string A_1);
        private void autoRegServer_SelectionChanged(object A_0, SelectionChangedEventArgs A_1);
        private bool b();
        private void b(string A_0);
        private void batchTimer_Tick(object A_0, EventArgs A_1);
        private void btnAdd_Click(object A_0, RoutedEventArgs A_1);
        private void btnAddAll_Click(object A_0, RoutedEventArgs A_1);
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btnRadioListFilePathBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btnRemove_Click(object A_0, RoutedEventArgs A_1);
        private void btnRemoveAll_Click(object A_0, RoutedEventArgs A_1);
        private void btnSchedulerHelp_Click(object A_0, RoutedEventArgs A_1);
        private void btnStart_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        private void d();
        private string e();
        private void EnableArsServer_Checked(object A_0, RoutedEventArgs A_1);
        private void EnableArsServer_UnChecked(object A_0, RoutedEventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        public void FireDataSourcePropertyChanged(string name);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void SchedulerWindow_Loaded(object A_0, RoutedEventArgs A_1);
        private void SchedulerWindowClosing(object A_0, CancelEventArgs A_1);
        [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void txtboxRadioListFilePath_SelectionChanged(object A_0, RoutedEventArgs A_1);
        private void txtbxNumRetries_TextChanged(object A_0, TextChangedEventArgs A_1);

        public List<PNServer> ARS_DataSource { get; }

        public ObservableCollection<POP25RadioInfo> DataSource { get; }

        public string ArsIpAddress { get; set; }

        internal string NumRetriePerFailedRadios { get; set; }

        internal bool WriteProtectRadios { get; set; }

        internal bool CancelBatchSchedule { get; set; }
    }
}

