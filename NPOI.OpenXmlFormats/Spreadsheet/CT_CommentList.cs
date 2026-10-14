using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000549 RID: 1353
	[global::System.Serializable]
	public class CT_CommentList
	{
		// Token: 0x06003B07 RID: 15111 RVA: 0x00092020 File Offset: 0x00090220
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList ct_CommentList = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CommentList();
			ct_CommentList.comment = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "comment")
				{
					ct_CommentList.comment.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CommentList;
		}

		// Token: 0x06003B08 RID: 15112 RVA: 0x000920B0 File Offset: 0x000902B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}>", nodeName));
			if (this.comment != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment in this.comment)
				{
					ct_Comment.Write(sw, "comment");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00092130 File Offset: 0x00090330
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment GetCommentArray(int index)
		{
			return this.comment[index];
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x0009213E File Offset: 0x0009033E
		public void RemoveComment(int index)
		{
			this.comment.RemoveAt(index);
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x0009214C File Offset: 0x0009034C
		public int SizeOfCommentArray()
		{
			return this.comment.Count;
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x0009215C File Offset: 0x0009035C
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment InsertNewComment(int index)
		{
			if (this.commentField == null)
			{
				this.commentField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment();
			this.commentField.Insert(index, ct_Comment);
			return ct_Comment;
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00092190 File Offset: 0x00090390
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment AddNewComment()
		{
			if (this.commentField == null)
			{
				this.commentField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment>();
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment();
			this.commentField.Add(ct_Comment);
			return ct_Comment;
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x000921C3 File Offset: 0x000903C3
		// (set) Token: 0x06003B0F RID: 15119 RVA: 0x000921CB File Offset: 0x000903CB
		[global::System.Xml.Serialization.XmlElement("comment")]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment> comment
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

		// Token: 0x06003B10 RID: 15120 RVA: 0x000921D4 File Offset: 0x000903D4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment[] GetCommentArray()
		{
			if (this.commentField == null)
			{
				this.commentField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment>();
			}
			return this.commentField.ToArray();
		}

		// Token: 0x040025C6 RID: 9670
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment> commentField;
	}
}
