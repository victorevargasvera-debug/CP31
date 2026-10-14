namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using SpecialFeatures.AcpXMLCoreEngineLib;
    using System;
    using System.Globalization;
    using System.Runtime.CompilerServices;

    public abstract class AcpBaseXMLCoreEngine
    {
        protected _XMLData XMLRptDataObj;
        protected _table rptTable;
        [CompilerGenerated]
        private AcpReports a;
        [CompilerGenerated]
        private string b;
        [CompilerGenerated]
        private CultureInfo c;
        [CompilerGenerated]
        private bool d;
        [CompilerGenerated]
        private string e;
        [CompilerGenerated]
        private _RecSet f;
        protected _UIFields rptFields;
        [CompilerGenerated]
        private _Value g;

        public AcpBaseXMLCoreEngine();
        public abstract void BuildDataTables(ref _XMLData XMLRptDataObj);
        public void BuildXMLfile(string XMLFileName, ref int inError);

        protected AcpReports acpr { get; set; }

        protected string cul { get; set; }

        protected CultureInfo ci { get; set; }

        protected bool isRTL { get; set; }

        protected string indexSeparator { get; set; }

        protected _RecSet rptRec { get; set; }

        protected _Value rptValue { get; set; }
    }
}

