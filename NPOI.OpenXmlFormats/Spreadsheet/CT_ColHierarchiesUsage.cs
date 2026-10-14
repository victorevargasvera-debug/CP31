using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004E3 RID: 1251
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_ColHierarchiesUsage
	{
		// Token: 0x06003458 RID: 13400 RVA: 0x00083478 File Offset: 0x00081678
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColHierarchiesUsage Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColHierarchiesUsage ct_ColHierarchiesUsage = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ColHierarchiesUsage();
			if (node.Attributes["count"] != null)
			{
				ct_ColHierarchiesUsage.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_ColHierarchiesUsage.colHierarchyUsage = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "colHierarchyUsage")
				{
					ct_ColHierarchiesUsage.colHierarchyUsage.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ColHierarchiesUsage;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00083534 File Offset: 0x00081734
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.colHierarchyUsage != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage ct_HierarchyUsage in this.colHierarchyUsage)
				{
					ct_HierarchyUsage.Write(sw, "colHierarchyUsage");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000835D4 File Offset: 0x000817D4
		public CT_ColHierarchiesUsage()
		{
			this.colHierarchyUsageField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage>();
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x000835E7 File Offset: 0x000817E7
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x000835EF File Offset: 0x000817EF
		[global::System.Xml.Serialization.XmlElement("colHierarchyUsage", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage> colHierarchyUsage
		{
			get
			{
				return this.colHierarchyUsageField;
			}
			set
			{
				this.colHierarchyUsageField = value;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x000835F8 File Offset: 0x000817F8
		// (set) Token: 0x0600345E RID: 13406 RVA: 0x00083600 File Offset: 0x00081800
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

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x0600345F RID: 13407 RVA: 0x00083609 File Offset: 0x00081809
		// (set) Token: 0x06003460 RID: 13408 RVA: 0x00083611 File Offset: 0x00081811
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

		// Token: 0x040022F3 RID: 8947
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_HierarchyUsage> colHierarchyUsageField;

		// Token: 0x040022F4 RID: 8948
		private uint countField;

		// Token: 0x040022F5 RID: 8949
		private bool countFieldSpecified;
	}
}
