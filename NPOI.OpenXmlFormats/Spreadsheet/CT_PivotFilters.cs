using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004DE RID: 1246
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotFilters
	{
		// Token: 0x06003420 RID: 13344 RVA: 0x00082BD8 File Offset: 0x00080DD8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilters Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilters ct_PivotFilters = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilters();
			if (node.Attributes["count"] != null)
			{
				ct_PivotFilters.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PivotFilters.filter = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "filter")
				{
					ct_PivotFilters.filter.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotFilters;
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00082C94 File Offset: 0x00080E94
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.filter != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter ct_PivotFilter in this.filter)
				{
					ct_PivotFilter.Write(sw, "filter");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x00082D34 File Offset: 0x00080F34
		public CT_PivotFilters()
		{
			this.filterField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter>();
			this.countField = 0U;
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x00082D4E File Offset: 0x00080F4E
		// (set) Token: 0x06003424 RID: 13348 RVA: 0x00082D56 File Offset: 0x00080F56
		[global::System.Xml.Serialization.XmlElement("filter", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter> filter
		{
			get
			{
				return this.filterField;
			}
			set
			{
				this.filterField = value;
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x00082D5F File Offset: 0x00080F5F
		// (set) Token: 0x06003426 RID: 13350 RVA: 0x00082D67 File Offset: 0x00080F67
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

		// Token: 0x0400229A RID: 8858
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotFilter> filterField;

		// Token: 0x0400229B RID: 8859
		private uint countField;
	}
}
