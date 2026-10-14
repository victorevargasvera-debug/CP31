using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200052D RID: 1325
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WebPublishObjects
	{
		// Token: 0x06003A44 RID: 14916 RVA: 0x00090A0C File Offset: 0x0008EC0C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObjects Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObjects ct_WebPublishObjects = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObjects();
			ct_WebPublishObjects.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_WebPublishObjects.countSpecified = (node.Attributes["count"] != null);
			ct_WebPublishObjects.webPublishObject = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "webPublishObject")
				{
					ct_WebPublishObjects.webPublishObject.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_WebPublishObjects;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x00090AD0 File Offset: 0x0008ECD0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.webPublishObject != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject ct_WebPublishObject in this.webPublishObject)
				{
					ct_WebPublishObject.Write(sw, "webPublishObject");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x00090B70 File Offset: 0x0008ED70
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x00090B78 File Offset: 0x0008ED78
		[global::System.Xml.Serialization.XmlElement]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject> webPublishObject
		{
			get
			{
				return this.webPublishObjectField;
			}
			set
			{
				this.webPublishObjectField = value;
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x00090B81 File Offset: 0x0008ED81
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x00090B89 File Offset: 0x0008ED89
		[global::System.Xml.Serialization.XmlAttribute]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x00090B92 File Offset: 0x0008ED92
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x00090B9A File Offset: 0x0008ED9A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool countSpecified
		{
			get
			{
				return this.countFieldSpecified;
			}
			set
			{
				this.countFieldSpecified = value;
			}
		}

		// Token: 0x04002528 RID: 9512
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishObject> webPublishObjectField;

		// Token: 0x04002529 RID: 9513
		private uint countField;

		// Token: 0x0400252A RID: 9514
		private bool countFieldSpecified;
	}
}
