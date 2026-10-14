using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200050D RID: 1293
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", ElementName = "comment")]
	[global::System.Serializable]
	public class CT_Comment
	{
		// Token: 0x060037AB RID: 14251 RVA: 0x0008ACF4 File Offset: 0x00088EF4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment ct_Comment = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Comment();
			ct_Comment.@ref = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["ref"]);
			if (node.Attributes["authorId"] != null)
			{
				ct_Comment.authorId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["authorId"]);
			}
			ct_Comment.guid = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["guid"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "text")
				{
					ct_Comment.text = global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Comment;
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x0008ADD4 File Offset: 0x00088FD4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "ref", this.@ref);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "authorId", this.authorId, true);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "guid", this.guid);
			sw.Write(">");
			if (this.text != null)
			{
				this.text.Write(sw, "text");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x0008AE5B File Offset: 0x0008905B
		// (set) Token: 0x060037AE RID: 14254 RVA: 0x0008AE63 File Offset: 0x00089063
		[global::System.Xml.Serialization.XmlElement("text")]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x0008AE6C File Offset: 0x0008906C
		// (set) Token: 0x060037B0 RID: 14256 RVA: 0x0008AE74 File Offset: 0x00089074
		[global::System.Xml.Serialization.XmlAttribute("ref")]
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x0008AE7D File Offset: 0x0008907D
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x0008AE85 File Offset: 0x00089085
		[global::System.Xml.Serialization.XmlAttribute("authorId")]
		public uint authorId
		{
			get
			{
				return this.authorIdField;
			}
			set
			{
				this.authorIdField = value;
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x0008AE8E File Offset: 0x0008908E
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x0008AE96 File Offset: 0x00089096
		[global::System.Xml.Serialization.XmlAttribute("guid")]
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x04002427 RID: 9255
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst textField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst();

		// Token: 0x04002428 RID: 9256
		private string refField = string.Empty;

		// Token: 0x04002429 RID: 9257
		private uint authorIdField;

		// Token: 0x0400242A RID: 9258
		private string guidField;
	}
}
