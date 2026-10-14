namespace SpecialFeatures.CloneWizard
{
    using AcpCommonLib;
    using AcpFileHandlerLib;
    using AcpUI;
    using AcpUI.Common;
    using Infragistics.Windows.DataPresenter;
    using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
    using SpecialFeatures.Clone_Configuration.Common;
    using SpecialFeatures.Comms;
    using SpecialFeatures.Programming;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class PageCloneWizard : AcpPageFeature, INotifyPropertyChanged, IDisposable, IComponentConnector
    {
        private bool a;
        private RadioEjectTimer b;
        private bool c;
        private int d;
        private int e;
        private int f;
        private int g;
        private bool h;
        private bool i;
        private bool j;
        private int k;
        private int l;
        private int m;
        private int n;
        private ASKProgrammingHistoryInnerRecset o;
        private bool p;
        private Clone q;
        private IntPtr r;
        private Cursor s;
        private bool t;
        private string u;
        private bool v;
        private string w;
        [CompilerGenerated]
        private string x;
        private string y;
        [CompilerGenerated]
        private PropertyChangedEventHandler z;
        internal AcpThemeBase ThemeBaseObj;
        internal Hyperlink HLinkMultipleRadio;
        internal Hyperlink HLinkFileClone;
        internal Hyperlink HLinkTrkSysIDList;
        internal Hyperlink HLinkExpCnvSysIDList;
        internal Hyperlink HLinkExpIndAstroOtarRadioIDList;
        internal Hyperlink HLinkDataWide;
        internal Hyperlink HLinkDataProfileList;
        internal Hyperlink HLinkUserInfo;
        internal Hyperlink HLinkBluetooth;
        internal StackPanel MyStackPanel;
        internal AcpLabel ProgText;
        internal ProgressBar progressBar2;
        internal Button ReadRadioIDsbutton;
        internal Button CloneRadiobutton;
        internal Button btnBatchProgrammingHelp;
        internal AcpExpander ExpMultipleRadio;
        internal AcpLabel UnitID;
        internal AcpTextBox TrkSysUnitIDIncrement;
        internal AcpLabel ASTROID;
        internal AcpTextBox CnvSysAstroIDIncrement;
        internal AcpLabel MDCID;
        internal AcpTextBox CnvSysMdcIDIncrement;
        internal AcpLabel AstroOtarRadioID;
        internal AcpTextBox IndAstroOtarRadioIDIncrement;
        internal AcpButton OK;
        internal AcpExpander ExpFileClone;
        internal AcpLabel FileCloneEn;
        internal AcpCheckBox FileCloneEnBox;
        internal AcpLabel SerialNumber;
        internal AcpTextBox SerialNumberBox;
        internal AcpExpander ExpTrkSysIDList;
        internal AcpXamDataPresenter TrunkingIDDataPresenter;
        internal UnboundField TrkSysName_Col;
        internal UnboundField TrkSysID_Col;
        internal UnboundField UnitID_Col;
        internal AcpExpander ExpCnvSysIDList;
        internal AcpXamDataPresenter CnvSysIDDataPresenter;
        internal AcpExpander ExpIndAstroOtarRadioIDList;
        internal AcpLabel LblSecWideASTROOTARIndividualASTROOTARRadioID;
        internal AcpTextBoxSpinner SecWideASTROOTARIndividualASTROOTARRadioID;
        internal AcpXamDataPresenter IndAstroOtardRadioIDDataPresenter;
        internal UnboundField SecureKMFProfile_Col;
        internal UnboundField IndAstroOtarRadioID_Col;
        internal AcpExpander ExpDataWide;
        internal AcpGroupBox GrpBoxExpanderDataWideGeneralSerialLink1Addresses;
        internal AcpLabel SubscriberIPAddress1;
        internal AcpTextBox DataWideGeneralSubscriberIPAddress1;
        internal AcpLabel PeerIPAddress1;
        internal AcpTextBox DataWideGeneralPeerIPAddress1;
        internal AcpGroupBox GrpBoxExpanderDataWideGeneralBluetoothDUNAddresses;
        internal AcpLabel DataWideBTSubscriberIPAddress;
        internal AcpTextBox DataWideGeneralBTSubscriberIPAddress;
        internal AcpLabel DataWideBTPeerIPAddress;
        internal AcpTextBox DataWideGeneralBTPeerIPAddress;
        internal AcpExpander ExpDataProfileList;
        internal AcpXamDataPresenter DataProfilesDataPresenter;
        internal UnboundField DataProfileName_Col;
        internal AcpExpander ExpUserInfo;
        internal AcpLabel SoftIDUsername;
        internal AcpTextBox RadWideUserInformationandPasswordsSoftIDUsername;
        internal AcpLabel LblUserInfoPINPassword;
        internal AcpPasswordEyeBox RadWideUserInformationandPasswordsPINPassword;
        internal AcpLabel LblUserInfoUserLoginUnitID;
        internal AcpTextBox RadWideUserInformationandPasswordsUserLoginUnitID;
        internal AcpLabel LblRadioAlias;
        internal AcpTextBox RadWideUserInformationandPasswordsRadioAlias;
        internal AcpExpander ExpBluetooth;
        internal AcpLabel BluetoothFriendlyName;
        internal AcpTextBox RadWideBluetoothFriendlyName;
        private bool aa;

        public event PropertyChangedEventHandler PropertyChanged;

        public PageCloneWizard();
        [CompilerGenerated]
        private void a();
        private bool a(ref string A_0);
        private void a(object A_0);
        private string a(string A_0);
        private void a(IAcpField A_0, int A_1);
        private void a(RadioIdInfo A_0, bool A_1);
        private void a(double A_0, string A_1);
        private AcpFileHeader b();
        private bool b(out string A_0);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        private bool c();
        internal void CallMainFinish(bool status);
        internal void CallMainUiProcess(double n, string stat);
        internal void CloneFinished(bool status);
        internal void CloneRadio_updateStatus(double n, string stat);
        internal void CloneW_DisplayOTAP(ProgrammingOperation ProgOp, OTAPProgrammingParameters LastCommsOTAPUserState, SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject);
        internal void CloneW_DisplayRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn RadioRtn);
        public bool CommandLineCPSCloneProcedure();
        private bool d();
        internal void DisplayOTAP(ProgrammingOperation ProgOp, OTAPProgrammingParameters LastCommsOTAPUserState, SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject);
        internal void DisplayRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn RadioRtn);
        public void Dispose();
        protected virtual void Dispose(bool disposing);
        private void e();
        private void f();
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        public void FirePropertyChanged(string name);
        private void g();
        private void h();
        private void HLinkClick(object A_0, RoutedEventArgs A_1);
        private void i();
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        private void OK_Click(object A_0, RoutedEventArgs A_1);
        private void OnCloneWizardClone(object A_0, RoutedEventArgs A_1);
        private void OnCloneWizardReadIds(object A_0, RoutedEventArgs A_1);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnRadioEjectTimeOut(object A_0, EventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        private void PageCloneWizard_PreviewKeyDown(object A_0, KeyEventArgs A_1);
        private void PageCloneWizard_PreviewMouseDown(object A_0, MouseButtonEventArgs A_1);
        internal void PrePackHandler();
        public void SaveRadioIds();
        public void SaveRadioIdsInCruncher(RadioIdInfo TempRadioIds);
        public override void SetDataContext();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        public string StatusOfClone { get; private set; }

        public string SerNum { get; set; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass55_0
        {
            public PageCloneWizard <>4__this;
            public string radioSN;

            public <>c__DisplayClass55_0();
            internal void <OnCloneWizardCloneImp>b__0();
        }

        private delegate void MainFinish(bool status);

        private delegate void MainThreadUpdateRadioIds(RadioIdInfo TempRadioIds, bool TrkEnabled);

        public delegate void MainUIDisplayCBI(SpecialFeatures.Comms.Comms.CBIReturn CbiSN);

        public delegate void MainUIDisplayOTAP(ProgrammingOperation ProgOp, OTAPProgrammingParameters LastCommsOTAPUserState, SpecialFeatures.Comms.Comms.RadioOTAPObject radioObject);

        private delegate void UpdateProgress(double n, string stat);

        public delegate void WriteRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn info);
    }
}

