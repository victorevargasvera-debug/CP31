using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020004B3 RID: 1203
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	public class CT_Dimensions
	{
		// Token: 0x0600313A RID: 12602 RVA: 0x0007B724 File Offset: 0x00079924
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions ct_Dimensions = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Dimensions();
			if (node.Attributes["count"] != null)
			{
				ct_Dimensions.count = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["count"]);
			}
			ct_Dimensions.dimension = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dimension")
				{
					ct_Dimensions.dimension.Add(global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Dimensions;
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x0007B7E0 File Offset: 0x000799E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "count", this.count, false);
			sw.Write(">");
			if (this.dimension != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension ct_PivotDimension in this.dimension)
				{
					ct_PivotDimension.Write(sw, "dimension");
				}
			}
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0007B880 File Offset: 0x00079A80
		public CT_Dimensions()
		{
			this.dimensionField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension>();
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x0007B893 File Offset: 0x00079A93
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x0007B89B File Offset: 0x00079A9B
		[global::System.Xml.Serialization.XmlElement("dimension", Order = 0)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension> dimension
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

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x0007B8A4 File Offset: 0x00079AA4
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x0007B8AC File Offset: 0x00079AAC
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

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x0007B8B5 File Offset: 0x00079AB5
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x0007B8BD File Offset: 0x00079ABD
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

		// Token: 0x0400213F RID: 8511
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_PivotDimension> dimensionField;

		// Token: 0x04002140 RID: 8512
		private uint countField;

		// Token: 0x04002141 RID: 8513
		private bool countFieldSpecified;
	}
}
