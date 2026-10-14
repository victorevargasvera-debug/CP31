namespace SpecialFeatures.POP25BatchProgrammer
{
    using System;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    [Serializable, XmlType("RadioList_Table")]
    public class RadioList : ObservableCollection<POP25RadioInfo>
    {
        public RadioList();
    }
}

