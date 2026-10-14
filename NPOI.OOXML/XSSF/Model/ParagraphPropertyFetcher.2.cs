using System;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E5 RID: 229
	public abstract class ParagraphPropertyFetcher<T> : global::NPOI.XSSF.Model.ParagraphPropertyFetcher
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x00030D16 File Offset: 0x0002EF16
		public T GetValue()
		{
			return this._value;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00030D1E File Offset: 0x0002EF1E
		public void SetValue(T val)
		{
			this._value = val;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00030D27 File Offset: 0x0002EF27
		public ParagraphPropertyFetcher(int level)
		{
			this._level = level;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00030D38 File Offset: 0x0002EF38
		public override bool Fetch(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape shape)
		{
			if (shape != null && shape.txBody != null && shape.txBody.lstStyle != null)
			{
				global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties ct_TextParagraphProperties;
				switch (this._level + 1)
				{
				case 1:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl1pPr;
					break;
				case 2:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl2pPr;
					break;
				case 3:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl3pPr;
					break;
				case 4:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl4pPr;
					break;
				case 5:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl5pPr;
					break;
				case 6:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl6pPr;
					break;
				case 7:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl7pPr;
					break;
				case 8:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl8pPr;
					break;
				case 9:
					ct_TextParagraphProperties = shape.txBody.lstStyle.lvl9pPr;
					break;
				default:
					ct_TextParagraphProperties = null;
					break;
				}
				if (ct_TextParagraphProperties != null)
				{
					return this.Fetch(ct_TextParagraphProperties);
				}
			}
			return false;
		}

		// Token: 0x0400041F RID: 1055
		private T _value;

		// Token: 0x04000420 RID: 1056
		private int _level;
	}
}
