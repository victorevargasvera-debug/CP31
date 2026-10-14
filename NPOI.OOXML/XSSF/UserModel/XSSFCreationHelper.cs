using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000076 RID: 118
	public class XSSFCreationHelper : global::NPOI.SS.UserModel.ICreationHelper
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x00015DFC File Offset: 0x00013FFC
		public XSSFCreationHelper(global::NPOI.XSSF.UserModel.XSSFWorkbook wb)
		{
			this.workbook = wb;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00015E0B File Offset: 0x0001400B
		public global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string text)
		{
			global::NPOI.XSSF.UserModel.XSSFRichTextString xssfrichTextString = new global::NPOI.XSSF.UserModel.XSSFRichTextString(text);
			xssfrichTextString.SetStylesTableReference(this.workbook.GetStylesSource());
			return xssfrichTextString;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00015E24 File Offset: 0x00014024
		public global::NPOI.SS.UserModel.IDataFormat CreateDataFormat()
		{
			return this.workbook.CreateDataFormat();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00015E31 File Offset: 0x00014031
		public global::NPOI.SS.UserModel.IHyperlink CreateHyperlink(global::NPOI.SS.UserModel.HyperlinkType type)
		{
			return new global::NPOI.XSSF.UserModel.XSSFHyperlink(type);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00015E39 File Offset: 0x00014039
		public global::NPOI.SS.UserModel.IFormulaEvaluator CreateFormulaEvaluator()
		{
			return new global::NPOI.XSSF.UserModel.XSSFFormulaEvaluator(this.workbook);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00015E46 File Offset: 0x00014046
		public global::NPOI.SS.UserModel.IClientAnchor CreateClientAnchor()
		{
			return new global::NPOI.XSSF.UserModel.XSSFClientAnchor();
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00015E4D File Offset: 0x0001404D
		public global::NPOI.SS.UserModel.ExtendedColor CreateExtendedColor()
		{
			return new global::NPOI.XSSF.UserModel.XSSFColor();
		}

		// Token: 0x040002BC RID: 700
		private global::NPOI.XSSF.UserModel.XSSFWorkbook workbook;
	}
}
