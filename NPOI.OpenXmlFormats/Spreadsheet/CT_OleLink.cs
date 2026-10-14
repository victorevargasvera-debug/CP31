using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000607 RID: 1543
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OleLink
	{
		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x000A0C8D File Offset: 0x0009EE8D
		// (set) Token: 0x06004397 RID: 17303 RVA: 0x000A0C95 File Offset: 0x0009EE95
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem> oleItems
		{
			get
			{
				return this.oleItemsField;
			}
			set
			{
				this.oleItemsField = value;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x000A0C9E File Offset: 0x0009EE9E
		// (set) Token: 0x06004399 RID: 17305 RVA: 0x000A0CA6 File Offset: 0x0009EEA6
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x000A0CAF File Offset: 0x0009EEAF
		// (set) Token: 0x0600439B RID: 17307 RVA: 0x000A0CB7 File Offset: 0x0009EEB7
		[global::System.Xml.Serialization.XmlAttribute]
		public string progId
		{
			get
			{
				return this.progIdField;
			}
			set
			{
				this.progIdField = value;
			}
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x000A0CC0 File Offset: 0x0009EEC0
		internal static global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink ct_OleLink = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleLink();
			ct_OleLink.idField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["r:id"]);
			ct_OleLink.progIdField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["progId"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "oleItems")
				{
					ct_OleLink.oleItemsField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem>();
					foreach (object obj2 in xmlNode.ChildNodes)
					{
						global::System.Xml.XmlNode node2 = (global::System.Xml.XmlNode)obj2;
						ct_OleLink.oleItems.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem.Parse(node2));
					}
				}
			}
			return ct_OleLink;
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x000A0DC8 File Offset: 0x0009EFC8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "r:id", this.idField);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "progId", this.progIdField);
			sw.Write(">");
			if (this.oleItemsField.Count > 0)
			{
				sw.Write("<oleItems>");
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem ct_OleItem in this.oleItemsField)
				{
					ct_OleItem.Write(sw, "oleItem");
				}
				sw.Write("</oleItems>");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x04002A92 RID: 10898
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_OleItem> oleItemsField;

		// Token: 0x04002A93 RID: 10899
		private string idField;

		// Token: 0x04002A94 RID: 10900
		private string progIdField;
	}
}
