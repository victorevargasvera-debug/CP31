namespace SpecialFeatures.UCL.CallListUpdate
{
    using AcpBusinessLayer;
    using AcpCommonLib.UndoRedo;
    using AcpUI;
    using SpecialFeatures.Ucl.Contact;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Input;
    using System.Windows.Markup;

    public class UpdateUCL : Window, INotifyPropertyChanged, IComponentConnector
    {
        private ComboBoxItem a;
        private string b;
        private int c;
        private int d;
        private int e;
        private int f;
        private int g;
        private int h;
        private FeatureNode i;
        private int j;
        private int k;
        private int l;
        private string m;
        private List<ComboBoxItem> n;
        private List<ComboBoxItem> o;
        private ComboBoxItem p;
        private ComboBoxItem q;
        private int r;
        private int s;
        private int t;
        private int u;
        [CompilerGenerated]
        private PropertyChangedEventHandler v;
        internal AcpLabel lbAliasesListFilePath;
        internal AcpTextBox txtboxAliasesListFilePath;
        internal Button btnAliasesListFilePathBrowse;
        internal GroupBox groupBoxSysInfo;
        internal AcpLabel lbSysType;
        internal AcpComboBox comboSysType;
        internal AcpLabel lbSystemName;
        internal AcpComboBox comboSysName;
        internal AcpLabel LblTrkSysSystemID;
        internal AcpTextBox txSystemID;
        internal Grid txspCustomSystemId;
        internal AcpTextBox SystemidDec;
        internal AcpTextBox SystemidHex;
        internal RepeatButton UpClickSystemid;
        internal RepeatButton DownClickSystemid;
        internal AcpLabel LblTrkSysHomeWACNID;
        internal AcpTextBox txWACNID;
        internal Grid txspCustomWACNID;
        internal AcpTextBox CustomWACNIDDec;
        internal AcpTextBox CustomWACNIDHex;
        internal RepeatButton UpClickCustomWACNID;
        internal RepeatButton DownClickCustomWACNID;
        internal AcpCheckBox ckDeleteExtra;
        internal AcpLabel lbDeleteExtra;
        internal AcpLabel lbNoteToUser;
        internal Button btnImport;
        internal Button btnCancel;
        internal Button btnHelp;
        private bool w;

        public event PropertyChangedEventHandler PropertyChanged;

        public UpdateUCL();
        private string a();
        private void a(UpdateUCL.ValueChangeType A_0);
        private void a(string A_0);
        private string a(int A_0, int A_1);
        internal bool AddContactFromAliasList(UclContactRecset uclContactRecset, string key, string[] keyValues, ContainerTask importTask);
        internal void AddTrkAstroCallID(UclContact contact, string[] keyvalue, ContainerTask importTask);
        internal void AddTrkIICallID(UclContact contact, string[] keyvalue, ContainerTask importTask);
        private void b();
        private int b(string A_0);
        private void btnAliasesListFilePathBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btnImport_Click(object A_0, RoutedEventArgs A_1);
        private void btnUpdateUCLHelp_Click(object A_0, RoutedEventArgs A_1);
        private void c();
        private void d();
        internal bool DeleteEmptyContact(FeatureNode node, ContainerTask importTask);
        internal bool DeleteExtraCallIDs(NameValueCollection collection, ContainerTask importTask);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        private void OnClick(object A_0, RoutedEventArgs A_1);
        private void OnKeyPressUpDownEvent(object A_0, KeyEventArgs A_1);
        [DebuggerNonUserCode, EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
        void IComponentConnector.Connect(int connectionId, object target);
        private void systemName_SelectionChanged(object A_0, SelectionChangedEventArgs A_1);
        private void systemType_SelectionChanged(object A_0, SelectionChangedEventArgs A_1);
        private void TextChanged(object A_0, TextChangedEventArgs A_1);
        private void txtboxAliasesListFilePath_SelectionChanged(object A_0, RoutedEventArgs A_1);
        internal bool UpdateCallIDsAreNeeded(List<string> listCpg, List<string> listConsole);
        internal void UpdateCallList(NameValueCollection collection, ContainerTask importTask);
        internal bool UpdateContactID(UclContactRecset uclContactRecset, string key, string[] keyValues, ContainerTask importTask);
        internal void UpdateTrkAstroCallID(TrunkingCallListRecset trkAstroRecset, UclContact matchingContact, List<string> list, List<string> callIDsFromConsole, ContainerTask importTask);
        internal void UpdateTrkT2CallID(TrunkingT2CallListRecset trkIIRecset, UclContact matchingContact, List<string> list, List<string> callIDsFromConsole, ContainerTask importTask);
        private void UpdateUCL_Loaded(object A_0, RoutedEventArgs A_1);
        private void UpdateUCLWindowClosing(object A_0, CancelEventArgs A_1);

        public List<ComboBoxItem> SysTypeList { get; }

        public List<ComboBoxItem> lstSystemName { get; }

        public ComboBoxItem TypeSelection { get; set; }

        public ComboBoxItem NameSelection { get; set; }

        public int Wacnid { get; set; }

        public int WacnidDecValue { get; set; }

        public string WacnidHexValue { get; set; }

        public int Systemid { get; set; }

        public int SystemidDecValue { get; set; }

        public string SystemidHexValue { get; set; }

        private int CurrentSystemId { get; }

        private int CurrentWacnId { get; }

        private enum ValueChangeType
        {
            upwacnid,
            downwacnid,
            upsystemid,
            downsystemid
        }
    }
}

