namespace SpecialFeatures.POP25BatchProgrammer
{
    using SpecialFeatures;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Markup;
    using System.Xml.Serialization;

    public class POP25BatchProgrammerRadioList : Window, INotifyPropertyChanged, IComponentConnector
    {
        private string a;
        private SpecialFeaturesSettings b;
        private XmlSerializer c;
        private POP25BatchProgrammerRadioList.RadioList d;
        private bool e;
        private bool f;
        [CompilerGenerated]
        private PropertyChangedEventHandler g;
        internal POP25BatchProgrammerRadioList This;
        internal Label lbSchedulerList;
        internal TextBox txtboxRadioListFilePath;
        internal Button btnRadioListFilePathBrowse;
        internal Label lbRadioList;
        internal Label label1;
        internal DataGrid dgRadioList;
        internal Button btnDelete;
        internal Button btnDeleteAll;
        internal Button btnSave;
        internal Button btnSaveAs;
        internal Button btnDone;
        internal Button btnCancel;
        internal Button btnHelp;
        private bool h;

        public event PropertyChangedEventHandler PropertyChanged;

        public POP25BatchProgrammerRadioList();
        private string a();
        private void a(string A_0);
        private void btnCancel_Click(object A_0, RoutedEventArgs A_1);
        private void btndelete_Click(object A_0, RoutedEventArgs A_1);
        private void btnDeleteAll_Click(object A_0, RoutedEventArgs A_1);
        private void btnDone_Click(object A_0, RoutedEventArgs A_1);
        private void btnRadioListFilePathBrowse_Click(object A_0, RoutedEventArgs A_1);
        private void btnRadioListHelp_click(object A_0, RoutedEventArgs A_1);
        private void btnSave_Click(object A_0, RoutedEventArgs A_1);
        private void btnSaveAs_Click(object A_0, RoutedEventArgs A_1);
        private void DataSource_CollectionChanged(object A_0, NotifyCollectionChangedEventArgs A_1);
        private void dgRadioList_CurrentCellChanged(object A_0, EventArgs A_1);
        private void F1HelpCommandCanExcute(object A_0, CanExecuteRoutedEventArgs A_1);
        public void FirePropertyChanged(string name);
        [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        public void InitializeComponent();
        [EditorBrowsable(1), GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
        void IComponentConnector.Connect(int connectionId, object target);
        private void This_Closing(object A_0, CancelEventArgs A_1);

        public ObservableCollection<POP25BatchProgrammerRadioList.RadioInfo> DataSource { get; }

        [Serializable, XmlType("Radio")]
        public class RadioInfo
        {
            private string radio_id;
            private string radio_ip;
            private bool radio_id_valid;
            private bool radio_ip_valid;

            public RadioInfo();

            public string Radio_ID { get; set; }

            public string Radio_IP { get; set; }

            [XmlIgnore]
            public bool Radio_ID_Valid { get; set; }

            [XmlIgnore]
            public bool Radio_IP_Valid { get; set; }
        }

        [Serializable, XmlType("RadioList_Table")]
        public class RadioList : ObservableCollection<POP25BatchProgrammerRadioList.RadioInfo>
        {
            public RadioList();
        }
    }
}

