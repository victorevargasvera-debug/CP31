using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000054 RID: 84
	public class NumberingDocument
	{
		// Token: 0x0600029F RID: 671 RVA: 0x0000469B File Offset: 0x0000289B
		public NumberingDocument()
		{
			this.numbering = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000046AE File Offset: 0x000028AE
		public NumberingDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering numbering)
		{
			this.numbering = numbering;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x000046BD File Offset: 0x000028BD
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering Numbering
		{
			get
			{
				return this.numbering;
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000046C8 File Offset: 0x000028C8
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.numbering.Write(streamWriter);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00004704 File Offset: 0x00002904
		public static global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.NumberingDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering.Parse(doc.DocumentElement, NameSpaceManager));
		}

		// Token: 0x040001B8 RID: 440
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Numbering numbering;
	}
}
