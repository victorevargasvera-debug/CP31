using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005B7 RID: 1463
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_WebPublishItems
	{
		// Token: 0x06004066 RID: 16486 RVA: 0x0009C324 File Offset: 0x0009A524
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems ct_WebPublishItems = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItems();
			if (node.Attributes["count"] != null)
			{
				ct_WebPublishItems.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_WebPublishItems.webPublishItem = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "webPublishItem")
				{
					ct_WebPublishItems.webPublishItem.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_WebPublishItems;
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x0009C3E0 File Offset: 0x0009A5E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, true);
			sw.Write(">");
			if (this.webPublishItem != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem ct_WebPublishItem in this.webPublishItem)
				{
					ct_WebPublishItem.Write(sw, "webPublishItem");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x0009C480 File Offset: 0x0009A680
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x0009C488 File Offset: 0x0009A688
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem> webPublishItem
		{
			get
			{
				return this.webPublishItemField;
			}
			set
			{
				this.webPublishItemField = value;
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x0009C491 File Offset: 0x0009A691
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x0009C499 File Offset: 0x0009A699
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

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x0009C4A2 File Offset: 0x0009A6A2
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x0009C4AA File Offset: 0x0009A6AA
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

		// Token: 0x040028D6 RID: 10454
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_WebPublishItem> webPublishItemField;

		// Token: 0x040028D7 RID: 10455
		private uint countField;

		// Token: 0x040028D8 RID: 10456
		private bool countFieldSpecified;
	}
}
