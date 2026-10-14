using System;
using System.IO;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005F7 RID: 1527
	public class SingleXmlCellsDocument
	{
		// Token: 0x0600431C RID: 17180 RVA: 0x0000205F File Offset: 0x0000025F
		public SingleXmlCellsDocument()
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x0009FDDE File Offset: 0x0009DFDE
		public SingleXmlCellsDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells cells)
		{
			this.cells = cells;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x0009FDED File Offset: 0x0009DFED
		public static global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument Parse(global::System.IO.Stream stream)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument((global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells)global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument.serializer.Deserialize(stream));
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x0009FE04 File Offset: 0x0009E004
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells GetSingleXmlCells()
		{
			return this.cells;
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x0009FE0C File Offset: 0x0009E00C
		public void SetSingleXmlCells(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells cells)
		{
			this.cells = cells;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x0009FE15 File Offset: 0x0009E015
		public void Save(global::System.IO.Stream stream)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument.serializer.Serialize(stream, this.cells);
		}

		// Token: 0x04002A5D RID: 10845
		private static global::System.Xml.Serialization.XmlSerializer serializer = new global::System.Xml.Serialization.XmlSerializer(typeof(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells));

		// Token: 0x04002A5E RID: 10846
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells cells;
	}
}
