using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000094 RID: 148
	public class XSSFPivotCache : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x000198E9 File Offset: 0x00017AE9
		public XSSFPivotCache()
		{
			this.ctPivotCache = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache();
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000198FC File Offset: 0x00017AFC
		public XSSFPivotCache(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache ctPivotCache)
		{
			this.ctPivotCache = ctPivotCache;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0001990B File Offset: 0x00017B0B
		protected XSSFPivotCache(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00019920 File Offset: 0x00017B20
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFPivotCache(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0001992C File Offset: 0x00017B2C
		protected void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::System.Xml.XmlDocument xmlDocument = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this.ctPivotCache = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache.Parse(xmlDocument.DocumentElement, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00019974 File Offset: 0x00017B74
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache GetCTPivotCache()
		{
			return this.ctPivotCache;
		}

		// Token: 0x040002FD RID: 765
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCache ctPivotCache;
	}
}
