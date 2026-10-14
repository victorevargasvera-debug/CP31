using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000056 RID: 86
	public class EndnotesDocument
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0000205F File Offset: 0x0000025F
		public EndnotesDocument()
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00004790 File Offset: 0x00002990
		public static global::NPOI.OpenXmlFormats.Wordprocessing.EndnotesDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.EndnotesDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes.Parse(doc.DocumentElement, namespaceMgr));
		}

		// Token: 0x060002AB RID: 683 RVA: 0x000047A3 File Offset: 0x000029A3
		public EndnotesDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes endnotes)
		{
			this.endnotes = endnotes;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002AC RID: 684 RVA: 0x000047B2 File Offset: 0x000029B2
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes Endnotes
		{
			get
			{
				return this.endnotes;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000047BC File Offset: 0x000029BC
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.endnotes.Write(streamWriter);
			}
		}

		// Token: 0x040001BA RID: 442
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Endnotes endnotes;
	}
}
