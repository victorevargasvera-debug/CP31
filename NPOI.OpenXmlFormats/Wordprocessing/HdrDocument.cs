using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000051 RID: 81
	public class HdrDocument
	{
		// Token: 0x0600028E RID: 654 RVA: 0x00004518 File Offset: 0x00002718
		public HdrDocument()
		{
			this.hdr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr();
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000452B File Offset: 0x0000272B
		public static global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.HdrDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr.Parse(doc.DocumentElement, namespaceMgr));
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00004540 File Offset: 0x00002740
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.hdr.Write(streamWriter);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000457C File Offset: 0x0000277C
		public HdrDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr hdr)
		{
			this.hdr = hdr;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000458B File Offset: 0x0000278B
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr Hdr
		{
			get
			{
				return this.hdr;
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00004593 File Offset: 0x00002793
		public void SetHdr(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr hdr)
		{
			this.hdr = hdr;
		}

		// Token: 0x040001B5 RID: 437
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Hdr hdr;
	}
}
