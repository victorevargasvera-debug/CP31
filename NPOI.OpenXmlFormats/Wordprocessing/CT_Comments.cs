using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200005A RID: 90
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot("comments", Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = false)]
	[global::System.Serializable]
	public class CT_Comments
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x00004B70 File Offset: 0x00002D70
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments ct_Comments = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comments();
			ct_Comments.comment = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "comment")
				{
					ct_Comments.comment.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Comments;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00004C00 File Offset: 0x00002E00
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>");
			sw.Write(string.Format("<w:comments ", new object[0]));
			sw.Write("xmlns:ve=\"http://schemas.openxmlformats.org/markup-compatibility/2006\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
			sw.Write("xmlns:r=\"http://schemas.openxmlformats.org/officeDocument/2006/relationships\" xmlns:m=\"http://schemas.openxmlformats.org/officeDocument/2006/math\" ");
			sw.Write("xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:wp=\"http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing\" ");
			sw.Write("xmlns:w10=\"urn:schemas-microsoft-com:office:word\" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\" ");
			sw.Write("xmlns:wne=\"http://schemas.microsoft.com/office/word/2006/wordml\">");
			sw.Write(">");
			if (this.comment != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment ct_Comment in this.comment)
				{
					ct_Comment.Write(sw, "comment");
				}
			}
			sw.Write("</w:comments>");
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00004CCC File Offset: 0x00002ECC
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00004CD4 File Offset: 0x00002ED4
		[global::System.Xml.Serialization.XmlElement("comment", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment> comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
			}
		}

		// Token: 0x040001C0 RID: 448
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Comment> commentField;
	}
}
