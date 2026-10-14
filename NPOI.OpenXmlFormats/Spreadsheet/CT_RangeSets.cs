using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000483 RID: 1155
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_RangeSets
	{
		// Token: 0x06002E39 RID: 11833 RVA: 0x00074124 File Offset: 0x00072324
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets ct_RangeSets = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSets();
			if (node.Attributes["count"] != null)
			{
				ct_RangeSets.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_RangeSets.rangeSet = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rangeSet")
				{
					ct_RangeSets.rangeSet.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RangeSets;
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000741E0 File Offset: 0x000723E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.rangeSet != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet ct_RangeSet in this.rangeSet)
				{
					ct_RangeSet.Write(sw, "rangeSet");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00074280 File Offset: 0x00072480
		public CT_RangeSets()
		{
			this.rangeSetField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet>();
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x00074293 File Offset: 0x00072493
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x0007429B File Offset: 0x0007249B
		[global::System.Xml.Serialization.XmlElement("rangeSet", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet> rangeSet
		{
			get
			{
				return this.rangeSetField;
			}
			set
			{
				this.rangeSetField = value;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x000742A4 File Offset: 0x000724A4
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x000742AC File Offset: 0x000724AC
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

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x000742B5 File Offset: 0x000724B5
		// (set) Token: 0x06002E41 RID: 11841 RVA: 0x000742BD File Offset: 0x000724BD
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

		// Token: 0x04001FEE RID: 8174
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_RangeSet> rangeSetField;

		// Token: 0x04001FEF RID: 8175
		private uint countField;

		// Token: 0x04001FF0 RID: 8176
		private bool countFieldSpecified;
	}
}
