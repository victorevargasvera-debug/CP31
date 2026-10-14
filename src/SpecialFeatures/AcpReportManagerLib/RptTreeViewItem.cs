namespace SpecialFeatures.AcpReportManagerLib
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Controls;

    public class RptTreeViewItem : TreeViewItem
    {
        private int a;
        private int b;
        private string c;
        private int d;
        private string e;
        private Dictionary<string, string> f;

        public RptTreeViewItem();

        internal string RptPath { get; set; }

        internal string RptRecordName { get; set; }

        internal int ItemType { get; set; }

        internal int ID { get; set; }

        internal int ParentID { get; set; }
    }
}

