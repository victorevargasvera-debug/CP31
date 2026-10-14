namespace SpecialFeatures.CloneExpress
{
    using AcpUI;
    using AcpUILib;
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
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class PageCloneExpress : AcpPageFeature, IAcpPageFeature, INotifyPropertyChanged, IComponentConnector
    {
        private bool a;
        private RadioEjectTimer b;
        private bool c;
        private bool d;
        private bool e;
        private int f;
        private int g;
        private int h;
        private int i;
        private ASKProgrammingHistoryInnerRecset j;
        private bool k;
        private IntPtr l;
        private bool m;
        public string LPKString;
        private string n;
        private string o;
        [CompilerGenerated]
        private PropertyChangedEventHandler p;
        internal AcpLabel ProgText;
        internal ProgressBar progressBar2;
        internal AcpExpander ExpCloneExp;
        internal Button CloneButton;
        internal Button HelpButton;
        internal AcpExpander ExpSerialNumber;
        internal AcpViewOnlyCtrl SerialNumberName;
        internal AcpViewOnlyCtrl RadInfoGeneralSerialNumber;
        internal AcpExpander ExpTrkSysIDList;
        internal AcpXamDataPresenter TrunkingIDDataPresenter;
        internal UnboundField TrkSysName_Col;
        internal UnboundField TrkSysID_Col;
        internal UnboundField UnitID_Col;
        internal AcpExpander ExpCnvSysIDList;
        internal AcpXamDataPresenter CnvSysIDDataPresenter;
        internal AcpExpander ExpIndAstroOtarRadioIDList;
        internal AcpViewOnlyCtrl LblSecWideASTROOTARIndividualASTROOTARRadioID;
        internal AcpViewOnlyCtrl SecWideASTROOTARIndividualASTROOTARRadioID;
        internal AcpXamDataPresenter IndAstroOtardRadioIDDataPresenter;
        internal UnboundField SecureKMFProfile_Col;
        internal UnboundField IndAstroOtarRadioID_Col;
        internal AcpExpander ExpDataWide;
        internal AcpViewOnlyCtrl SubscriberIPAddress1;
        internal AcpViewOnlyCtrl DataWideGeneralSubscriberIPAddress1;
        internal AcpViewOnlyCtrl PeerIPAddress1;
        internal AcpViewOnlyCtrl DataWideGeneralPeerIPAddress1;
        internal AcpViewOnlyCtrl BTSubscriberIPAddress;
        internal AcpViewOnlyCtrl DataWideGeneralBTSubscriberIPAddress;
        internal AcpViewOnlyCtrl BTPeerIPAddress;
        internal AcpViewOnlyCtrl DataWideGeneralBTPeerIPAddress;
        internal AcpExpander ExpDataProfileList;
        internal AcpXamDataPresenter DataProfilesDataPresenter;
        internal UnboundField DataProfileName_Col;
        internal AcpExpander ExpUserInfo;
        internal AcpViewOnlyCtrl SoftIDUsername;
        internal AcpViewOnlyCtrl RadWideUserInformationandPasswordsSoftIDUsername;
        internal AcpViewOnlyCtrl LblUserInfoPINPassword;
        internal AcpPasswordEyeBox RadWideUserInformationandPasswordsPINPassword;
        internal AcpViewOnlyCtrl LblUserInfoUserLoginUnitID;
        internal AcpViewOnlyCtrl RadWideUserInformationandPasswordsUserLoginUnitID;
        internal AcpViewOnlyCtrl LblRadioAlias;
        internal AcpViewOnlyCtrl RadWideUserInformationandPasswordsRadioAlias;
        internal AcpExpander ExpBluetooth;
        internal AcpViewOnlyCtrl BluetoothFriendlyName;
        internal AcpViewOnlyCtrl RadWideBluetoothFriendlyName;
        private bool q;

        public event PropertyChangedEventHandler PropertyChanged;

        public PageCloneExpress();
        private bool a(RadioIdInfo A_0);
        private void a(object A_0);
        private string a(string A_0);
        private void buttonHelp_Click(object A_0, RoutedEventArgs A_1);
        internal void CallMainFinish(bool status);
        internal void CallMainUiProcess(double n, string stat);
        internal void CloneFinished(bool status);
        internal void CloneRadio_updateStatus(double n, string stat);
        internal void CloneW_DisplayOTAP(ProgrammingOperation ProgOp, OTAPProgrammingParameters LastCommsOTAPUserState, SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject);
        internal void CloneW_DisplayRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn RadioRtn);
        internal void DisplayOTAP(ProgrammingOperation ProgOp, OTAPProgrammingParameters LastCommsOTAPUserState, SpecialFeatures.Comms.Comms.RadioOTAPObject RadioObject);
        internal void DisplayRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn RadioRtn);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        public void FirePropertyChanged(string name);
        [DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent();
        internal void OnCloneExpressClone(object sender, RoutedEventArgs e);
        public override void OnLoaded(object sender, RoutedEventArgs e);
        private void OnRadioEjectTimeOut(object A_0, EventArgs A_1);
        public override void OnUnloaded(object sender, RoutedEventArgs e);
        public override void SetDataContext();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);

        public string SerNum { get; set; }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass32_0
        {
            public PageCloneExpress <>4__this;
            public bool status;

            public <>c__DisplayClass32_0();
            internal void <OnCloneExpressClone>b__0();
        }

        private delegate void MainFinish(bool status);

        private delegate bool MainThreadUpdateRadioIds(RadioIdInfo TempRadioIds);

        public delegate void MainUIDisplayOTAP(ProgrammingOperation ProgOp, OTAPProgrammingParameters LastCommsOTAPUserState, SpecialFeatures.Comms.Comms.RadioOTAPObject radioObject);

        private delegate void UpdateProgress(double n, string stat);

        public delegate void WriteRadioQuery(SpecialFeatures.Comms.Comms.RadioRtn info);
    }
}

