using System;
using NPOI.OpenXmlFormats.Dml;
using NPOI.OpenXmlFormats.Dml.Spreadsheet;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E4 RID: 228
	public abstract class ParagraphPropertyFetcher
	{
		// Token: 0x06000E2B RID: 3627
		public abstract bool Fetch(global::NPOI.OpenXmlFormats.Dml.CT_TextParagraphProperties props);

		// Token: 0x06000E2C RID: 3628
		public abstract bool Fetch(global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_Shape props);
	}
}
