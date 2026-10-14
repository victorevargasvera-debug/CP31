using System;
using System.Text;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000B0 RID: 176
	public class XSSFXmlColumnPr
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x0002A52D File Offset: 0x0002872D
		public XSSFXmlColumnPr(global::NPOI.XSSF.UserModel.XSSFTable table, global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ctTableColum, global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr CT_XmlColumnPr)
		{
			this.table = table;
			this.ctTableColumn = ctTableColum;
			this.ctXmlColumnPr = CT_XmlColumnPr;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0002A54A File Offset: 0x0002874A
		public long GetMapId()
		{
			return (long)((ulong)this.ctXmlColumnPr.mapId);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0002A558 File Offset: 0x00028758
		public string GetXPath()
		{
			return this.ctXmlColumnPr.xpath;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0002A565 File Offset: 0x00028765
		public long GetId()
		{
			return (long)((ulong)this.ctTableColumn.id);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0002A574 File Offset: 0x00028774
		public string GetLocalXPath()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = this.table.GetCommonXpath().Split(new char[]
			{
				'/'
			}).Length - 1;
			string[] array = this.ctXmlColumnPr.xpath.Split(new char[]
			{
				'/'
			});
			for (int i = num; i < array.Length; i++)
			{
				stringBuilder.Append("/" + array[i]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0002A5EB File Offset: 0x000287EB
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_XmlDataType GetXmlDataType()
		{
			return this.ctXmlColumnPr.xmlDataType;
		}

		// Token: 0x040003AD RID: 941
		private global::NPOI.XSSF.UserModel.XSSFTable table;

		// Token: 0x040003AE RID: 942
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_TableColumn ctTableColumn;

		// Token: 0x040003AF RID: 943
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_XmlColumnPr ctXmlColumnPr;
	}
}
