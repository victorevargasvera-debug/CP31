using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B8 RID: 1208
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_MeasureDimensionMap
	{
		// Token: 0x06003167 RID: 12647 RVA: 0x0007BE4C File Offset: 0x0007A04C
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap ct_MeasureDimensionMap = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_MeasureDimensionMap();
			if (node.Attributes["measureGroup"] != null)
			{
				ct_MeasureDimensionMap.measureGroup = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["measureGroup"]);
			}
			if (node.Attributes["dimension"] != null)
			{
				ct_MeasureDimensionMap.dimension = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["dimension"]);
			}
			return ct_MeasureDimensionMap;
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x0007BEC0 File Offset: 0x0007A0C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "measureGroup", this.measureGroup, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dimension", this.dimension, false);
			sw.Write("/>");
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0007BF0D File Offset: 0x0007A10D
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x0007BF15 File Offset: 0x0007A115
		[global::System.Xml.Serialization.XmlAttribute]
		public uint measureGroup
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

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x0007BF1E File Offset: 0x0007A11E
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0007BF26 File Offset: 0x0007A126
		[global::System.Xml.Serialization.XmlIgnore]
		public bool measureGroupSpecified
		{
			get
			{
				return this.measureGroupFieldSpecified;
			}
			set
			{
				this.measureGroupFieldSpecified = value;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x0007BF2F File Offset: 0x0007A12F
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x0007BF37 File Offset: 0x0007A137
		[global::System.Xml.Serialization.XmlAttribute]
		public uint dimension
		{
			get
			{
				return this.dimensionField;
			}
			set
			{
				this.dimensionField = value;
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x0007BF40 File Offset: 0x0007A140
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x0007BF48 File Offset: 0x0007A148
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dimensionSpecified
		{
			get
			{
				return this.dimensionFieldSpecified;
			}
			set
			{
				this.dimensionFieldSpecified = value;
			}
		}

		// Token: 0x0400214E RID: 8526
		private uint measureGroupField;

		// Token: 0x0400214F RID: 8527
		private bool measureGroupFieldSpecified;

		// Token: 0x04002150 RID: 8528
		private uint dimensionField;

		// Token: 0x04002151 RID: 8529
		private bool dimensionFieldSpecified;
	}
}
