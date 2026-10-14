using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200054A RID: 1354
	public class CommentsDocument
	{
		// Token: 0x06003B12 RID: 15122 RVA: 0x0000205F File Offset: 0x0000025F
		public CommentsDocument()
		{
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000921F4 File Offset: 0x000903F4
		public CommentsDocument(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments comments)
		{
			this.comments = comments;
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00092203 File Offset: 0x00090403
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CommentsDocument Parse(global::System.Xml.XmlDocument xmlDoc, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CommentsDocument
			{
				comments = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments.Parse(xmlDoc.DocumentElement, namespaceManager)
			};
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x0009221C File Offset: 0x0009041C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments GetComments()
		{
			return this.comments;
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00092224 File Offset: 0x00090424
		public void SetComments(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments comments)
		{
			this.comments = comments;
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00092230 File Offset: 0x00090430
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.comments.Write(streamWriter);
			}
		}

		// Token: 0x040025C7 RID: 9671
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments comments;
	}
}
