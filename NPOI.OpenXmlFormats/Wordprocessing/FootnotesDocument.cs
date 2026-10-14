using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000050 RID: 80
	public class FootnotesDocument
	{
		// Token: 0x06000289 RID: 649 RVA: 0x0000449C File Offset: 0x0000269C
		public FootnotesDocument()
		{
			this.footnotes = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000044AF File Offset: 0x000026AF
		public static global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.FootnotesDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes.Parse(doc.DocumentElement, namespaceMgr));
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000044C2 File Offset: 0x000026C2
		public FootnotesDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes footnotes)
		{
			this.footnotes = footnotes;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000044D1 File Offset: 0x000026D1
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes Footnotes
		{
			get
			{
				return this.footnotes;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000044DC File Offset: 0x000026DC
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.footnotes.Write(streamWriter);
			}
		}

		// Token: 0x040001B4 RID: 436
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Footnotes footnotes;
	}
}
