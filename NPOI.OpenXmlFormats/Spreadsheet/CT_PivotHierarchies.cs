using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004D7 RID: 1239
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_PivotHierarchies
	{
		// Token: 0x060033A7 RID: 13223 RVA: 0x00081AA8 File Offset: 0x0007FCA8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchies Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchies ct_PivotHierarchies = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchies();
			if (node.Attributes["count"] != null)
			{
				ct_PivotHierarchies.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_PivotHierarchies.pivotHierarchy = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pivotHierarchy")
				{
					ct_PivotHierarchies.pivotHierarchy.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotHierarchies;
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00081B64 File Offset: 0x0007FD64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.pivotHierarchy != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy ct_PivotHierarchy in this.pivotHierarchy)
				{
					ct_PivotHierarchy.Write(sw, "pivotHierarchy");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00081C04 File Offset: 0x0007FE04
		public CT_PivotHierarchies()
		{
			this.pivotHierarchyField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy>();
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x00081C17 File Offset: 0x0007FE17
		// (set) Token: 0x060033AB RID: 13227 RVA: 0x00081C1F File Offset: 0x0007FE1F
		[global::System.Xml.Serialization.XmlElement("pivotHierarchy", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy> pivotHierarchy
		{
			get
			{
				return this.pivotHierarchyField;
			}
			set
			{
				this.pivotHierarchyField = value;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x00081C28 File Offset: 0x0007FE28
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x00081C30 File Offset: 0x0007FE30
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

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x00081C39 File Offset: 0x0007FE39
		// (set) Token: 0x060033AF RID: 13231 RVA: 0x00081C41 File Offset: 0x0007FE41
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

		// Token: 0x04002268 RID: 8808
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotHierarchy> pivotHierarchyField;

		// Token: 0x04002269 RID: 8809
		private uint countField;

		// Token: 0x0400226A RID: 8810
		private bool countFieldSpecified;
	}
}
