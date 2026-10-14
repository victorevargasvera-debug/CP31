using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B7 RID: 1207
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_MeasureDimensionMaps
	{
		// Token: 0x0600315E RID: 12638 RVA: 0x0007BCA8 File Offset: 0x00079EA8
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps ct_MeasureDimensionMaps = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMaps();
			if (node.Attributes["count"] != null)
			{
				ct_MeasureDimensionMaps.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_MeasureDimensionMaps.map = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "map")
				{
					ct_MeasureDimensionMaps.map.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_MeasureDimensionMaps;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0007BD64 File Offset: 0x00079F64
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.map != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap ct_MeasureDimensionMap in this.map)
				{
					ct_MeasureDimensionMap.Write(sw, "map");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x0007BE04 File Offset: 0x0007A004
		public CT_MeasureDimensionMaps()
		{
			this.mapField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap>();
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x0007BE17 File Offset: 0x0007A017
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x0007BE1F File Offset: 0x0007A01F
		[global::System.Xml.Serialization.XmlElement("map", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap> map
		{
			get
			{
				return this.mapField;
			}
			set
			{
				this.mapField = value;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x0007BE28 File Offset: 0x0007A028
		// (set) Token: 0x06003164 RID: 12644 RVA: 0x0007BE30 File Offset: 0x0007A030
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

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x0007BE39 File Offset: 0x0007A039
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x0007BE41 File Offset: 0x0007A041
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

		// Token: 0x0400214B RID: 8523
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap> mapField;

		// Token: 0x0400214C RID: 8524
		private uint countField;

		// Token: 0x0400214D RID: 8525
		private bool countFieldSpecified;
	}
}
