using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000055 RID: 85
	public class StylesDocument
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00004717 File Offset: 0x00002917
		public StylesDocument()
		{
			this.styles = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000472A File Offset: 0x0000292A
		public static global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.StylesDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles.Parse(doc.DocumentElement, namespaceMgr));
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000473D File Offset: 0x0000293D
		public StylesDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles styles)
		{
			this.styles = styles;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000474C File Offset: 0x0000294C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles Styles
		{
			get
			{
				return this.styles;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00004754 File Offset: 0x00002954
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.styles.Write(streamWriter);
			}
		}

		// Token: 0x040001B9 RID: 441
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Styles styles;
	}
}
