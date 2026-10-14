namespace SpecialFeatures.ACPXMLCoreEngineLib
{
    using SpecialFeatures.AcpReportManagerLib;
    using System;

    public class XMLCoreEngineFactory
    {
        public XMLCoreEngineFactory();
        public AcpBaseXMLCoreEngine MakeXMLCoreObj(reportType reporytype);
    }
}

