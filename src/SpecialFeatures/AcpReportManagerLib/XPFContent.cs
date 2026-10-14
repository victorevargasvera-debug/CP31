namespace SpecialFeatures.AcpReportManagerLib
{
    using System;
    using System.Windows.Documents;

    internal class XPFContent
    {
        private string a;

        internal XPFContent(string contentPath);
        internal IDocumentPaginatorSource LoadViewableFixedContent(string documentName);
    }
}

