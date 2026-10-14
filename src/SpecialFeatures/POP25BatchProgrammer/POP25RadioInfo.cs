namespace SpecialFeatures.POP25BatchProgrammer
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Xml.Serialization;

    [Serializable, XmlType("Radio")]
    public class POP25RadioInfo : INotifyPropertyChanged
    {
        public string radioIpAddr;
        public string radioID;
        private bool radioId_valid;
        private bool radioIp_valid;
        private string status;
        private bool radioIpARScheck;
        private bool radioIdcheck;
        private int indexInList;
        [CompilerGenerated]
        private PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        public POP25RadioInfo();
        public void OnPropertyChanged(PropertyChangedEventArgs e);

        public string Radio_ID { get; set; }

        public string Radio_IP { get; set; }

        [XmlIgnore]
        public bool Radio_ID_Valid { get; set; }

        [XmlIgnore]
        public bool Radio_IP_Valid { get; set; }

        [XmlIgnore]
        public string Status { get; set; }

        [XmlIgnore]
        public bool Radio_IP_ARS_Check { get; set; }

        [XmlIgnore]
        public bool Radio_ID_Check { get; set; }

        [XmlIgnore]
        internal int IndexInList { get; set; }
    }
}

