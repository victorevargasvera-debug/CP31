using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000580 RID: 1408
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_PivotAreaReferences
	{
		// Token: 0x06003D97 RID: 15767 RVA: 0x000958E4 File Offset: 0x00093AE4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReferences Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReferences ct_PivotAreaReferences = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReferences();
			ct_PivotAreaReferences.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			ct_PivotAreaReferences.reference = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "reference")
				{
					ct_PivotAreaReferences.reference.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotAreaReferences;
		}

		// Token: 0x06003D98 RID: 15768 RVA: 0x0009598C File Offset: 0x00093B8C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.reference != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference ct_PivotAreaReference in this.reference)
				{
					ct_PivotAreaReference.Write(sw, "reference");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003D99 RID: 15769 RVA: 0x00095A2C File Offset: 0x00093C2C
		public CT_PivotAreaReferences()
		{
			this.referenceField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference>();
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06003D9A RID: 15770 RVA: 0x00095A3F File Offset: 0x00093C3F
		// (set) Token: 0x06003D9B RID: 15771 RVA: 0x00095A47 File Offset: 0x00093C47
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference> reference
		{
			get
			{
				return this.referenceField;
			}
			set
			{
				this.referenceField = value;
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06003D9C RID: 15772 RVA: 0x00095A50 File Offset: 0x00093C50
		// (set) Token: 0x06003D9D RID: 15773 RVA: 0x00095A58 File Offset: 0x00093C58
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

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06003D9E RID: 15774 RVA: 0x00095A61 File Offset: 0x00093C61
		// (set) Token: 0x06003D9F RID: 15775 RVA: 0x00095A69 File Offset: 0x00093C69
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

		// Token: 0x0400273D RID: 10045
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotAreaReference> referenceField;

		// Token: 0x0400273E RID: 10046
		private uint countField;

		// Token: 0x0400273F RID: 10047
		private bool countFieldSpecified;
	}
}
