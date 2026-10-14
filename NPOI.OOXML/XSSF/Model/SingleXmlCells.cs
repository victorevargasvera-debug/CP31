using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.XSSF.UserModel;
using NPOI.XSSF.UserModel.Helpers;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E7 RID: 231
	public class SingleXmlCells : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x000310CE File Offset: 0x0002F2CE
		public SingleXmlCells()
		{
			this.SingleXMLCells = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells();
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000310E1 File Offset: 0x0002F2E1
		public SingleXmlCells(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000310F6 File Offset: 0x0002F2F6
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public SingleXmlCells(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00031100 File Offset: 0x0002F300
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument singleXmlCellsDocument = global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument.Parse(is1);
				this.SingleXMLCells = singleXmlCellsDocument.GetSingleXmlCells();
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00023FD0 File Offset: 0x000221D0
		public global::NPOI.XSSF.UserModel.XSSFSheet GetXSSFSheet()
		{
			return (global::NPOI.XSSF.UserModel.XSSFSheet)base.GetParent();
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00031140 File Offset: 0x0002F340
		protected void WriteTo(global::System.IO.Stream out1)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument singleXmlCellsDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.SingleXmlCellsDocument();
			singleXmlCellsDocument.SetSingleXmlCells(this.SingleXMLCells);
			singleXmlCellsDocument.Save(out1);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003115C File Offset: 0x0002F35C
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00031182 File Offset: 0x0002F382
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells GetCTSingleXMLCells()
		{
			return this.SingleXMLCells;
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003118C File Offset: 0x0002F38C
		public global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell> GetAllSimpleXmlCell()
		{
			global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell> list = new global::System.Collections.Generic.List<global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell>();
			foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCell singleXmlCell in this.SingleXMLCells.singleXmlCell)
			{
				list.Add(new global::NPOI.XSSF.UserModel.Helpers.XSSFSingleXmlCell(singleXmlCell, this));
			}
			return list;
		}

		// Token: 0x04000426 RID: 1062
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_SingleXmlCells SingleXMLCells;
	}
}
