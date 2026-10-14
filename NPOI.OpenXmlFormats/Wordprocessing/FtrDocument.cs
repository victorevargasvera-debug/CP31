using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000052 RID: 82
	public class FtrDocument
	{
		// Token: 0x06000294 RID: 660 RVA: 0x0000459C File Offset: 0x0000279C
		public FtrDocument()
		{
			this.ftr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000045AF File Offset: 0x000027AF
		public static global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.FtrDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr.Parse(doc.DocumentElement, namespaceMgr));
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000045C4 File Offset: 0x000027C4
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.ftr.Write(streamWriter);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00004600 File Offset: 0x00002800
		public FtrDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr ftr)
		{
			this.ftr = ftr;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000460F File Offset: 0x0000280F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr Ftr
		{
			get
			{
				return this.ftr;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00004617 File Offset: 0x00002817
		public void SetFtr(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr ftr)
		{
			this.ftr = ftr;
		}

		// Token: 0x040001B6 RID: 438
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ftr ftr;
	}
}
