using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004AF RID: 1199
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_CalculatedItems
	{
		// Token: 0x06003108 RID: 12552 RVA: 0x0007AF1C File Offset: 0x0007911C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems ct_CalculatedItems = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItems();
			if (node.Attributes["count"] != null)
			{
				ct_CalculatedItems.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_CalculatedItems.calculatedItem = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "calculatedItem")
				{
					ct_CalculatedItems.calculatedItem.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CalculatedItems;
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x0007AFD8 File Offset: 0x000791D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.calculatedItem != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem ct_CalculatedItem in this.calculatedItem)
				{
					ct_CalculatedItem.Write(sw, "calculatedItem");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0007B078 File Offset: 0x00079278
		public CT_CalculatedItems()
		{
			this.calculatedItemField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem>();
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x0007B08B File Offset: 0x0007928B
		// (set) Token: 0x0600310C RID: 12556 RVA: 0x0007B093 File Offset: 0x00079293
		[global::System.Xml.Serialization.XmlElement("calculatedItem", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem> calculatedItem
		{
			get
			{
				return this.calculatedItemField;
			}
			set
			{
				this.calculatedItemField = value;
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x0007B09C File Offset: 0x0007929C
		// (set) Token: 0x0600310E RID: 12558 RVA: 0x0007B0A4 File Offset: 0x000792A4
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

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x0600310F RID: 12559 RVA: 0x0007B0AD File Offset: 0x000792AD
		// (set) Token: 0x06003110 RID: 12560 RVA: 0x0007B0B5 File Offset: 0x000792B5
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

		// Token: 0x0400212C RID: 8492
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalculatedItem> calculatedItemField;

		// Token: 0x0400212D RID: 8493
		private uint countField;

		// Token: 0x0400212E RID: 8494
		private bool countFieldSpecified;
	}
}
