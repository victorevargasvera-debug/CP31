using System;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A8 RID: 168
	public class XSSFWorkbookType
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x00028973 File Offset: 0x00026B73
		private XSSFWorkbookType(string contentType, string extension)
		{
			this._contentType = contentType;
			this._extension = extension;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00028989 File Offset: 0x00026B89
		public string ContentType
		{
			get
			{
				return this._contentType;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00028991 File Offset: 0x00026B91
		public string Extension
		{
			get
			{
				return this._extension;
			}
		}

		// Token: 0x0400039E RID: 926
		public static global::NPOI.XSSF.UserModel.XSSFWorkbookType XLSX = new global::NPOI.XSSF.UserModel.XSSFWorkbookType(global::NPOI.XSSF.UserModel.XSSFRelation.WORKBOOK.ContentType, "xlsx");

		// Token: 0x0400039F RID: 927
		public static global::NPOI.XSSF.UserModel.XSSFWorkbookType XLSM = new global::NPOI.XSSF.UserModel.XSSFWorkbookType(global::NPOI.XSSF.UserModel.XSSFRelation.MACROS_WORKBOOK.ContentType, "xlsm");

		// Token: 0x040003A0 RID: 928
		private string _contentType;

		// Token: 0x040003A1 RID: 929
		private string _extension;
	}
}
