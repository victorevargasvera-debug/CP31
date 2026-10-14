using System;
using NPOI.SS.UserModel;
using NPOI.Util;
using NPOI.XSSF.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000C6 RID: 198
	public class SXSSFCreationHelper : global::NPOI.SS.UserModel.ICreationHelper
	{
		// Token: 0x06000C7E RID: 3198 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		public SXSSFCreationHelper(global::NPOI.XSSF.Streaming.SXSSFWorkbook workbook)
		{
			this.helper = new global::NPOI.XSSF.UserModel.XSSFCreationHelper(workbook.XssfWorkbook);
			this.wb = workbook;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0002DDE8 File Offset: 0x0002BFE8
		public global::NPOI.SS.UserModel.IClientAnchor CreateClientAnchor()
		{
			return this.helper.CreateClientAnchor();
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0002DDF5 File Offset: 0x0002BFF5
		public global::NPOI.SS.UserModel.IDataFormat CreateDataFormat()
		{
			return this.helper.CreateDataFormat();
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0002DE02 File Offset: 0x0002C002
		public global::NPOI.SS.UserModel.ExtendedColor CreateExtendedColor()
		{
			return this.helper.CreateExtendedColor();
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x0002DE0F File Offset: 0x0002C00F
		public global::NPOI.SS.UserModel.IFormulaEvaluator CreateFormulaEvaluator()
		{
			return new global::NPOI.XSSF.Streaming.SXSSFFormulaEvaluator(this.wb);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0002DE1C File Offset: 0x0002C01C
		public global::NPOI.SS.UserModel.IHyperlink CreateHyperlink(global::NPOI.SS.UserModel.HyperlinkType type)
		{
			return this.helper.CreateHyperlink(type);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x0002DE2A File Offset: 0x0002C02A
		public global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string text)
		{
			global::NPOI.XSSF.Streaming.SXSSFCreationHelper.logger.Log(3, "SXSSF doesn't support Rich Text Strings, any formatting information will be lost");
			return new global::NPOI.XSSF.UserModel.XSSFRichTextString(text);
		}

		// Token: 0x040003E2 RID: 994
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.Streaming.SXSSFCreationHelper));

		// Token: 0x040003E3 RID: 995
		private global::NPOI.XSSF.Streaming.SXSSFWorkbook wb;

		// Token: 0x040003E4 RID: 996
		private global::NPOI.XSSF.UserModel.XSSFCreationHelper helper;
	}
}
