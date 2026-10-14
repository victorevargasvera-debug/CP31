using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200050E RID: 1294
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "comments")]
	[global::System.Serializable]
	public class CT_Comments
	{
		// Token: 0x060037B6 RID: 14262 RVA: 0x0008AEC0 File Offset: 0x000890C0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments ct_Comments = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comments();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "authors")
				{
					ct_Comments.authors = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "commentList")
				{
					ct_Comments.commentList = global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Comments.extLst = global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Comments;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x0008AF80 File Offset: 0x00089180
		internal void Write(global::System.IO.StreamWriter sw)
		{
			sw.Write("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\" ?>");
			sw.Write("<comments xmlns=\"http://schemas.openxmlformats.org/spreadsheetml/2006/main\">");
			if (this.authors != null)
			{
				this.authors.Write(sw, "authors");
			}
			if (this.commentList != null)
			{
				this.commentList.Write(sw, "commentList");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write("</comments>");
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x0008AFF9 File Offset: 0x000891F9
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors AddNewAuthors()
		{
			this.authorsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors();
			return this.authorsField;
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x0008B00C File Offset: 0x0008920C
		public void AddNewCommentList()
		{
			this.commentListField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList();
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x060037BA RID: 14266 RVA: 0x0008B019 File Offset: 0x00089219
		// (set) Token: 0x060037BB RID: 14267 RVA: 0x0008B021 File Offset: 0x00089221
		[global::System.Xml.Serialization.XmlElement("authors", Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors authors
		{
			get
			{
				return this.authorsField;
			}
			set
			{
				this.authorsField = value;
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0008B02A File Offset: 0x0008922A
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x0008B032 File Offset: 0x00089232
		[global::System.Xml.Serialization.XmlElement("commentList", Order = 1)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList commentList
		{
			get
			{
				return this.commentListField;
			}
			set
			{
				this.commentListField = value;
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0008B03B File Offset: 0x0008923B
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x0008B043 File Offset: 0x00089243
		[global::System.Xml.Serialization.XmlElement("extLst", Order = 2)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x0400242B RID: 9259
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors authorsField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Authors();

		// Token: 0x0400242C RID: 9260
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList commentListField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList();

		// Token: 0x0400242D RID: 9261
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;
	}
}
