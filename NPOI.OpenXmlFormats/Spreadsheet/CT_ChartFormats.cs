using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D5 RID: 1237
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ChartFormats
	{
		// Token: 0x06003395 RID: 13205 RVA: 0x00081724 File Offset: 0x0007F924
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormats Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormats ct_ChartFormats = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormats();
			if (node.Attributes["count"] != null)
			{
				ct_ChartFormats.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_ChartFormats.chartFormat = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "chartFormat")
				{
					ct_ChartFormats.chartFormat.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ChartFormats;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x000817E0 File Offset: 0x0007F9E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.chartFormat != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat ct_ChartFormat in this.chartFormat)
				{
					ct_ChartFormat.Write(sw, "chartFormat");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00081880 File Offset: 0x0007FA80
		public CT_ChartFormats()
		{
			this.chartFormatField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat>();
			this.countField = 0U;
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x0008189A File Offset: 0x0007FA9A
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x000818A2 File Offset: 0x0007FAA2
		[global::System.Xml.Serialization.XmlElement("chartFormat", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat> chartFormat
		{
			get
			{
				return this.chartFormatField;
			}
			set
			{
				this.chartFormatField = value;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x000818AB File Offset: 0x0007FAAB
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x000818B3 File Offset: 0x0007FAB3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
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

		// Token: 0x04002262 RID: 8802
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat> chartFormatField;

		// Token: 0x04002263 RID: 8803
		private uint countField;
	}
}
