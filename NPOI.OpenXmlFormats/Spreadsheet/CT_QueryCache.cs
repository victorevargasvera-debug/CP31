using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004AB RID: 1195
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_QueryCache
	{
		// Token: 0x060030E8 RID: 12520 RVA: 0x0007A9D0 File Offset: 0x00078BD0
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache ct_QueryCache = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_QueryCache();
			if (node.Attributes["count"] != null)
			{
				ct_QueryCache.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_QueryCache.query = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "query")
				{
					ct_QueryCache.query.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_QueryCache;
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0007AA8C File Offset: 0x00078C8C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.query != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query ct_Query in this.query)
				{
					ct_Query.Write(sw, "query");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0007AB2C File Offset: 0x00078D2C
		public CT_QueryCache()
		{
			this.queryField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query>();
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x0007AB3F File Offset: 0x00078D3F
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x0007AB47 File Offset: 0x00078D47
		[global::System.Xml.Serialization.XmlElement("query", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query> query
		{
			get
			{
				return this.queryField;
			}
			set
			{
				this.queryField = value;
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x0007AB50 File Offset: 0x00078D50
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x0007AB58 File Offset: 0x00078D58
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

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x0007AB61 File Offset: 0x00078D61
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x0007AB69 File Offset: 0x00078D69
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

		// Token: 0x04002122 RID: 8482
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Query> queryField;

		// Token: 0x04002123 RID: 8483
		private uint countField;

		// Token: 0x04002124 RID: 8484
		private bool countFieldSpecified;
	}
}
