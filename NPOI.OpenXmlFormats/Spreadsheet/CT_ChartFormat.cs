using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D6 RID: 1238
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ChartFormat
	{
		// Token: 0x0600339C RID: 13212 RVA: 0x000818BC File Offset: 0x0007FABC
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat ct_ChartFormat = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ChartFormat();
			if (node.Attributes["chart"] != null)
			{
				ct_ChartFormat.chart = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["chart"]);
			}
			if (node.Attributes["format"] != null)
			{
				ct_ChartFormat.format = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["format"]);
			}
			if (node.Attributes["series"] != null)
			{
				ct_ChartFormat.series = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["series"]);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotArea")
				{
					ct_ChartFormat.pivotArea = global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ChartFormat;
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000819C0 File Offset: 0x0007FBC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "chart", this.chart, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "format", this.format, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "series", this.series);
			sw.Write(">");
			if (this.pivotArea != null)
			{
				this.pivotArea.Write(sw, "pivotArea");
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00081A48 File Offset: 0x0007FC48
		public CT_ChartFormat()
		{
			this.pivotAreaField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea();
			this.seriesField = false;
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x00081A62 File Offset: 0x0007FC62
		// (set) Token: 0x060033A0 RID: 13216 RVA: 0x00081A6A File Offset: 0x0007FC6A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotArea
		{
			get
			{
				return this.pivotAreaField;
			}
			set
			{
				this.pivotAreaField = value;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x00081A73 File Offset: 0x0007FC73
		// (set) Token: 0x060033A2 RID: 13218 RVA: 0x00081A7B File Offset: 0x0007FC7B
		[global::System.Xml.Serialization.XmlAttribute]
		public uint chart
		{
			get
			{
				return this.chartField;
			}
			set
			{
				this.chartField = value;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x00081A84 File Offset: 0x0007FC84
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x00081A8C File Offset: 0x0007FC8C
		[global::System.Xml.Serialization.XmlAttribute]
		public uint format
		{
			get
			{
				return this.formatField;
			}
			set
			{
				this.formatField = value;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x00081A95 File Offset: 0x0007FC95
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x00081A9D File Offset: 0x0007FC9D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool series
		{
			get
			{
				return this.seriesField;
			}
			set
			{
				this.seriesField = value;
			}
		}

		// Token: 0x04002264 RID: 8804
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotArea pivotAreaField;

		// Token: 0x04002265 RID: 8805
		private uint chartField;

		// Token: 0x04002266 RID: 8806
		private uint formatField;

		// Token: 0x04002267 RID: 8807
		private bool seriesField;
	}
}
