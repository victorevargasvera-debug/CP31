namespace SpecialFeatures.Programming
{
    using SpecialFeatures;
    using SpecialFeatures.Programming.UI;
    using SSLAdminTool;
    using SSLMangrComp.Packets;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Windows.Threading;

    public class OTAPProgrammingWindow : Window, INotifyPropertyChanged, IComponentConnector
    {
        private ProgrammingOperation a;
        private DispatcherTimer b;
        private int c;
        [CompilerGenerated]
        private PropertyChangedEventHandler d;
        private bool e;
        private bool f;
        private OTAPPrescenceResult g;
        private ARSGetIPAddressWorker h;
        private SpecialFeaturesSettings i;
        private string j;
        private IDataStoreDecryptHandler k;
        private List<PNServer> l;
        private SubscriptionType m;
        internal StackPanel ProgrammingPanel;
        internal Label operationLabel;
        internal GroupBox GrpbxOTAPParameters;
        internal CheckBox useRadioIDCheckBox;
        internal ComboBox autoRegServer;
        internal Label lbArsConnectionType;
        internal TextBox txtboxConnectionType;
        internal Label lblTimeout;
        internal IPTextBox TimeOutTextbox;
        internal Label lblRadioID;
        internal IPTextBox RadioID;
        internal Label lblRadioIPOutput;
        internal SPF_UI_IPAddressV4_Control RadioIPAddressTextBox;
        internal Label lblInactivityTimer;
        internal IPTextBox InactivityTimerTextbox;
        internal Label lblTimeElapsed;
        internal TextBox txtTimeElapsed;
        internal Button btnGetIPOnly;
        internal Button btnOperation;
        internal Button btnCancel;
        internal Button btnHelp;
        private bool n;

        public event PropertyChangedEventHandler PropertyChanged;

        private OTAPProgrammingWindow();
        public OTAPProgrammingWindow(ProgrammingOperation operation);
        public OTAPProgrammingWindow(ProgrammingOperation operation, OTAPProgrammingParameters userParameters);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        internal Delegate _CreateDelegate(Type delegateType, string handler);
        private void a();
        private bool a(string A_0);
        private void a(OTAPPrescenceResult A_0, object A_1);
        private bool a(PNServer A_0, ref string A_1);
        private void ARSIPAddressTextBox_GotFocus(object A_0, RoutedEventArgs A_1);
        private void ARSIPAddressTextBox_LostFocus(object A_0, RoutedEventArgs A_1);
        private void autoRegServer_SelectionChanged(object A_0, SelectionChangedEventArgs A_1);
        private void b();
        private void b(string A_0);
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btnGetIPOnly_Click(object A_0, RoutedEventArgs A_1);
        private void btnHelp_Click(object A_0, RoutedEventArgs A_1);
        private void btnOperation_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        private bool d();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        protected override void OnClosing(CancelEventArgs e);
        protected override void OnInitialized(EventArgs e);
        private void onOTAPProgrammingWindowLoaded(object A_0, RoutedEventArgs A_1);
        private void OTAPProgrammingWindow_MouseLeftButtonDown(object A_0, MouseButtonEventArgs A_1);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0"), EditorBrowsable(1)]
        void IComponentConnector.Connect(int connectionId, object target);
        private void TimerClock_Tick(object A_0, EventArgs A_1);
        private void useRadioIDCheckBox_Checked(object A_0, RoutedEventArgs A_1);
        private void useRadioIDCheckBox_Unchecked(object A_0, RoutedEventArgs A_1);

        public List<PNServer> ARS_DataSource { get; }

        public OTAPProgrammingParameters OTAPProgrammingLastState { get; }

        public OTAPPrescenceResult PrescenceResult { get; }

        public int RunningTime { get; set; }

        public string ArsIpAddress { get; set; }

        public string RadioIpAddress { get; set; }
    }
}

