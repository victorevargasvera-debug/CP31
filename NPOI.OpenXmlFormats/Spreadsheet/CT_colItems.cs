using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004C7 RID: 1223
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_colItems
	{
		// Token: 0x0600331D RID: 13085 RVA: 0x00080214 File Offset: 0x0007E414
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_colItems Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_colItems ct_colItems = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_colItems();
			if (node.Attributes["count"] != null)
			{
				ct_colItems.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_colItems.i = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "i")
				{
					ct_colItems.i.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_I.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_colItems;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000802D0 File Offset: 0x0007E4D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.i != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_I ct_I in this.i)
				{
					ct_I.Write(sw, "i");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00080370 File Offset: 0x0007E570
		public CT_colItems()
		{
			this.iField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I>();
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003320 RID: 13088 RVA: 0x00080383 File Offset: 0x0007E583
		// (set) Token: 0x06003321 RID: 13089 RVA: 0x0008038B File Offset: 0x0007E58B
		[global::System.Xml.Serialization.XmlElement("i", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I> i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06003322 RID: 13090 RVA: 0x00080394 File Offset: 0x0007E594
		// (set) Token: 0x06003323 RID: 13091 RVA: 0x0008039C File Offset: 0x0007E59C
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

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06003324 RID: 13092 RVA: 0x000803A5 File Offset: 0x0007E5A5
		// (set) Token: 0x06003325 RID: 13093 RVA: 0x000803AD File Offset: 0x0007E5AD
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

		// Token: 0x0400221F RID: 8735
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_I> iField;

		// Token: 0x04002220 RID: 8736
		private uint countField;

		// Token: 0x04002221 RID: 8737
		private bool countFieldSpecified;
	}
}
