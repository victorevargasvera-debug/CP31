using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B5 RID: 1205
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_MeasureGroups
	{
		// Token: 0x0600314E RID: 12622 RVA: 0x0007BA34 File Offset: 0x00079C34
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups ct_MeasureGroups = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroups();
			if (node.Attributes["count"] != null)
			{
				ct_MeasureGroups.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_MeasureGroups.measureGroup = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "measureGroup")
				{
					ct_MeasureGroups.measureGroup.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MeasureGroups;
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x0007BAF0 File Offset: 0x00079CF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.measureGroup != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup ct_MeasureGroup in this.measureGroup)
				{
					ct_MeasureGroup.Write(sw, "measureGroup");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x0007BB90 File Offset: 0x00079D90
		public CT_MeasureGroups()
		{
			this.measureGroupField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup>();
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x0007BBA3 File Offset: 0x00079DA3
		// (set) Token: 0x06003152 RID: 12626 RVA: 0x0007BBAB File Offset: 0x00079DAB
		[global::System.Xml.Serialization.XmlElement("measureGroup", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup> measureGroup
		{
			get
			{
				return this.measureGroupField;
			}
			set
			{
				this.measureGroupField = value;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x0007BBB4 File Offset: 0x00079DB4
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x0007BBBC File Offset: 0x00079DBC
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

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x0007BBC5 File Offset: 0x00079DC5
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x0007BBCD File Offset: 0x00079DCD
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

		// Token: 0x04002146 RID: 8518
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureGroup> measureGroupField;

		// Token: 0x04002147 RID: 8519
		private uint countField;

		// Token: 0x04002148 RID: 8520
		private bool countFieldSpecified;
	}
}
