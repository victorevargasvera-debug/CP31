namespace SpecialFeatures.POP25BatchProgrammer
{
    using AcpUI;
    using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
    using SpecialFeatures;
    using SpecialFeatures.Comms;
    using SSLAdminTool;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Threading;

    public class POP25BatchProgrammerProgress : Window, IComponentConnector
    {
        private DispatcherTimer a;
        private bool b;
        private string c;
        private string d;
        private double e;
        private bool f;
        private bool g;
        public double totItems;
        private int h;
        public const int RADIO_ID_MAX = 0xfffffb;
        private SpecialFeaturesSettings i;
        private string j;
        private bool k;
        private bool l;
        private int m;
        private int n;
        private int o;
        private int p;
        private ASKProgrammingHistoryInnerRecset q;
        private bool r;
        private PNServer s;
        private byte[] t;
        private ObservableCollection<POP25RadioInfo> u;
        private ObservableCollection<POP25RadioInfo> v;
        private ObservableCollection<POP25RadioInfo> w;
        [CompilerGenerated]
        private string x;
        [CompilerGenerated]
        private bool y;
        [CompilerGenerated]
        private bool z;
        [CompilerGenerated]
        private bool aa;
        internal POP25BatchProgrammerProgress This;
        internal StackPanel spBatchProgrammingIPAndStart;
        internal TextBox txtboxArsServer;
        internal AcpTextBox dtProgressDateTime;
        internal StackPanel spBackGround;
        internal DataGrid dgBatchProgrammingProgress;
        internal TextBox ProgText;
        internal ProgressBar pbBatchProgrammingProgress;
        internal ProgressBar pbOverallBatchProgrammingProgress;
        internal TextBox txtbxRetryCount;
        internal Expander batProgressResultExpander;
        internal TextBox txtBoxProgressStatus;
        internal Button btnSaveToFile;
        internal StackPanel spBatchProgrammingRadioProgress;
        internal Button btnBatchProgrammingClose;
        internal Button btnBatchProgrammingCancel;
        internal Button btnBatchProgrammingHelp;
        private bool ab;

        public POP25BatchProgrammerProgress();
        private bool a(POP25RadioInfo A_0);
        private string a(string A_0);
        private void a(double A_0, string A_1);
        private bool b(string A_0);
        private void batchCloneTimer_Tick(object A_0, EventArgs A_1);
        private void batProgressResultExpander_Collapsed(object A_0, RoutedEventArgs A_1);
        private void batProgressResultExpander_Expanded(object A_0, RoutedEventArgs A_1);
        private void btnBack_Click(object A_0, RoutedEventArgs A_1);
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btnClose_Click(object A_0, RoutedEventArgs A_1);
        private void btnProgressWndHelp_Click(object A_0, RoutedEventArgs A_1);
        private void btnSaveAs_Click(object A_0, RoutedEventArgs A_1);
        internal void CallMainFinish(int status);
        internal void CloneFinished(int status);
        internal void CloneRadioUsingRadioIdOrRadioIp(POP25RadioInfo radio);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        internal void OnLoaded(object sender, RoutedEventArgs e);
        internal void OnUnLoaded(object sender, RoutedEventArgs e);
        internal void ProcessRadio(POP25RadioInfo radio, bool bContinueClone, string statusMsg, string networkError);
        private void ProgressWindowClosing(object A_0, CancelEventArgs A_1);
        internal void Radio_updateStatus(double n, string stat);
        internal int SaveRadioIds(RadioIdInfo tempRadioIds);
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
        internal void WriteToLog_Cont();
        internal void WriteToLog_Failure();
        internal void WriteToLog_Initial();
        internal void WriteToLog_Success();
        internal void WriteToLogCurrentPass();

        public ObservableCollection<POP25RadioInfo> DataSource { get; }

        internal double PbStatusval { get; set; }

        internal bool ARSServerEnabled { get; set; }

        internal string CurrentRadioIpAddress { get; set; }

        internal string CurrentRadioID { get; set; }

        public string ARSIpAddress { get; set; }

        internal bool WriteProtectWriteProtectedRad { get; set; }

        public int RetryCount { get; set; }

        internal int CurRetry { get; set; }

        internal bool CancelBatchProgramming { get; set; }

        internal bool BatchProgrammingInProgress { get; set; }

        internal bool BatchProgrammingComplete { get; set; }

        internal PNServer TargetARS { get; set; }

        internal byte[] DhBuff { get; set; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass91_0
        {
            public POP25BatchProgrammerProgress <>4__this;
            public POP25RadioInfo radio;

            public <>c__DisplayClass91_0();
            internal void <CloneRadioUsingRadioIdOrRadioIp>b__0();
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass92_0
        {
            public POP25BatchProgrammerProgress <>4__this;
            public int status_int;
            public int status;

            public <>c__DisplayClass92_0();
            internal void <ProcessRadio>b__0();
        }

        private delegate void MainFinish(int status);

        private delegate int MainThreadUpdateRadioIds(RadioIdInfo tempRadioIds);

        private delegate void RadioPresent(POP25RadioInfo currentRadio, bool bPresenceReturn, string statusMsg, string networkError);

        public delegate void UpdateProgress(double n, string stat);

        private delegate void UpdateRadioOverallProgressBarDelegate(DependencyProperty dp, object val);

        public delegate void WriteRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn info);
    }
}

