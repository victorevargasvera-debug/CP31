using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001CD RID: 461
	public class DocumentDocument
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x0000205F File Offset: 0x0000025F
		public DocumentDocument()
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0003B1B0 File Offset: 0x000393B0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.DocumentDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager namespaceMgr)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.DocumentDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document.Parse(doc.DocumentElement, namespaceMgr));
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0003B1C3 File Offset: 0x000393C3
		public DocumentDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document document)
		{
			this.document = document;
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0003B1D2 File Offset: 0x000393D2
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document Document
		{
			get
			{
				return this.document;
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0003B1DC File Offset: 0x000393DC
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.document.Write(streamWriter);
			}
		}

		// Token: 0x04000DBD RID: 3517
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Document document;
	}
}
