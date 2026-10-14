using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.Model
{
	// Token: 0x02000052 RID: 82
	public class XMLParagraph
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x0000F2A1 File Offset: 0x0000D4A1
		public XMLParagraph(global::NPOI.OpenXmlFormats.Wordprocessing.CT_P paragraph)
		{
			this.paragraph = paragraph;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_P GetCTP()
		{
			return this.paragraph;
		}

		// Token: 0x0400023A RID: 570
		protected global::NPOI.OpenXmlFormats.Wordprocessing.CT_P paragraph;
	}
}
