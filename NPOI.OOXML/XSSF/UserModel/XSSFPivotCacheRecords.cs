using System;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000096 RID: 150
	public class XSSFPivotCacheRecords : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x00019C61 File Offset: 0x00017E61
		public XSSFPivotCacheRecords()
		{
			this.ctPivotCacheRecords = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords();
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00019C74 File Offset: 0x00017E74
		protected XSSFPivotCacheRecords(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00019C89 File Offset: 0x00017E89
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFPivotCacheRecords(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00019C94 File Offset: 0x00017E94
		protected void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::System.Xml.XmlDocument xmlDocument = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this.ctPivotCacheRecords = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords.Parse(xmlDocument.DocumentElement, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00019CDC File Offset: 0x00017EDC
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords GetCtPivotCacheRecords()
		{
			return this.ctPivotCacheRecords;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00019CE4 File Offset: 0x00017EE4
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.ctPivotCacheRecords.Save(outputStream);
			outputStream.Close();
		}

		// Token: 0x040002FF RID: 767
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotCacheRecords ctPivotCacheRecords;
	}
}
