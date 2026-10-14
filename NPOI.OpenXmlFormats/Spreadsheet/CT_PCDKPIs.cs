using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004A4 RID: 1188
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PCDKPIs
	{
		// Token: 0x06003094 RID: 12436 RVA: 0x00079BC8 File Offset: 0x00077DC8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs ct_PCDKPIs = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPIs();
			if (node.Attributes["count"] != null)
			{
				ct_PCDKPIs.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PCDKPIs.kpi = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "kpi")
				{
					ct_PCDKPIs.kpi.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PCDKPIs;
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00079C84 File Offset: 0x00077E84
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.kpi != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI ct_PCDKPI in this.kpi)
				{
					ct_PCDKPI.Write(sw, "kpi");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00079D24 File Offset: 0x00077F24
		public CT_PCDKPIs()
		{
			this.kpiField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI>();
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x00079D37 File Offset: 0x00077F37
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x00079D3F File Offset: 0x00077F3F
		[global::System.Xml.Serialization.XmlElement("kpi", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI> kpi
		{
			get
			{
				return this.kpiField;
			}
			set
			{
				this.kpiField = value;
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x00079D48 File Offset: 0x00077F48
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x00079D50 File Offset: 0x00077F50
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

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x00079D59 File Offset: 0x00077F59
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x00079D61 File Offset: 0x00077F61
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

		// Token: 0x040020F9 RID: 8441
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PCDKPI> kpiField;

		// Token: 0x040020FA RID: 8442
		private uint countField;

		// Token: 0x040020FB RID: 8443
		private bool countFieldSpecified;
	}
}
