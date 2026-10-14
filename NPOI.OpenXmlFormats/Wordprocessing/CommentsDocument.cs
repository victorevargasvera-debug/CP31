using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200004F RID: 79
	public class CommentsDocument
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00004423 File Offset: 0x00002623
		public CommentsDocument()
		{
			this.comments = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments();
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00004436 File Offset: 0x00002636
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CommentsDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CommentsDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments.Parse(doc.DocumentElement, NameSpaceManager));
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00004449 File Offset: 0x00002649
		public CommentsDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments comments)
		{
			this.comments = comments;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00004458 File Offset: 0x00002658
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments Comments
		{
			get
			{
				return this.comments;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00004460 File Offset: 0x00002660
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.comments.Write(streamWriter);
			}
		}

		// Token: 0x040001B3 RID: 435
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments comments;
	}
}
