using System;
using NPOI.HSSF.Record.Common;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000371 RID: 881
	public class HSSFCreationHelper : global::NPOI.SS.UserModel.ICreationHelper
	{
		// Token: 0x06001BA8 RID: 7080 RVA: 0x000549C5 File Offset: 0x00052BC5
		public HSSFCreationHelper(global::NPOI.HSSF.UserModel.HSSFWorkbook wb)
		{
			this.workbook = wb;
			this.dataFormat = new global::NPOI.HSSF.UserModel.HSSFDataFormat(this.workbook.Workbook);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000549EA File Offset: 0x00052BEA
		public global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string text)
		{
			return new global::NPOI.HSSF.UserModel.HSSFRichTextString(text);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x000549F2 File Offset: 0x00052BF2
		public global::NPOI.SS.UserModel.IDataFormat CreateDataFormat()
		{
			return this.dataFormat;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x000549FA File Offset: 0x00052BFA
		public global::NPOI.SS.UserModel.IHyperlink CreateHyperlink(global::NPOI.SS.UserModel.HyperlinkType type)
		{
			return new global::NPOI.HSSF.UserModel.HSSFHyperlink(type);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00054A02 File Offset: 0x00052C02
		public global::NPOI.SS.UserModel.IFormulaEvaluator CreateFormulaEvaluator()
		{
			return new global::NPOI.HSSF.UserModel.HSSFFormulaEvaluator(this.workbook);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00054A0F File Offset: 0x00052C0F
		public global::NPOI.SS.UserModel.IClientAnchor CreateClientAnchor()
		{
			return new global::NPOI.HSSF.UserModel.HSSFClientAnchor();
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00054A16 File Offset: 0x00052C16
		public global::NPOI.SS.UserModel.ExtendedColor CreateExtendedColor()
		{
			return new global::NPOI.HSSF.UserModel.HSSFExtendedColor(new global::NPOI.HSSF.Record.Common.ExtendedColor());
		}

		// Token: 0x04000B43 RID: 2883
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;

		// Token: 0x04000B44 RID: 2884
		private global::NPOI.HSSF.UserModel.HSSFDataFormat dataFormat;
	}
}
