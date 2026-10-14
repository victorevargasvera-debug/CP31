using System;
using NPOI.OpenXmlFormats.Dml;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200008B RID: 139
	public class XSSFLineBreak : global::NPOI.XSSF.UserModel.XSSFTextRun
	{
		// Token: 0x0600072E RID: 1838 RVA: 0x00018623 File Offset: 0x00016823
		public XSSFLineBreak(global::NPOI.OpenXmlFormats.Dml.CT_RegularTextRun r, global::NPOI.XSSF.UserModel.XSSFTextParagraph p, global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties brProps) : base(r, p)
		{
			this._brProps = brProps;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00018634 File Offset: 0x00016834
		protected new global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties GetRPr()
		{
			return this._brProps;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0001863C File Offset: 0x0001683C
		public void SetText(string text)
		{
			throw new global::System.InvalidOperationException("You cannot change text of a line break, it is always '\\n'");
		}

		// Token: 0x040002E7 RID: 743
		private global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties _brProps;
	}
}
