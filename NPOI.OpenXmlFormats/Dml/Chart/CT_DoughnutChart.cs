using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E1 RID: 993
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DoughnutChart
	{
		// Token: 0x06002756 RID: 10070 RVA: 0x0006288C File Offset: 0x00060A8C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart ct_DoughnutChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DoughnutChart();
			ct_DoughnutChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer>();
			ct_DoughnutChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "varyColors")
				{
					ct_DoughnutChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_DoughnutChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "firstSliceAng")
				{
					ct_DoughnutChart.firstSliceAng = global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "holeSize")
				{
					ct_DoughnutChart.holeSize = global::NPOI.OpenXmlFormats.Dml.Chart.CT_HoleSize.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_DoughnutChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DoughnutChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DoughnutChart;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x000629DC File Offset: 0x00060BDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.varyColors != null)
			{
				this.varyColors.Write(sw, "varyColors");
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.firstSliceAng != null)
			{
				this.firstSliceAng.Write(sw, "firstSliceAng");
			}
			if (this.holeSize != null)
			{
				this.holeSize.Write(sw, "holeSize");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer ct_PieSer in this.ser)
				{
					ct_PieSer.Write(sw, "ser");
				}
			}
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00062B18 File Offset: 0x00060D18
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x00062B2F File Offset: 0x00060D2F
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x00062B37 File Offset: 0x00060D37
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColors
		{
			get
			{
				return this.varyColorsField;
			}
			set
			{
				this.varyColorsField = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00062B40 File Offset: 0x00060D40
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x00062B48 File Offset: 0x00060D48
		[global::System.Xml.Serialization.XmlElement("ser", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer> ser
		{
			get
			{
				return this.serField;
			}
			set
			{
				this.serField = value;
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x00062B51 File Offset: 0x00060D51
		// (set) Token: 0x0600275E RID: 10078 RVA: 0x00062B59 File Offset: 0x00060D59
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLbls
		{
			get
			{
				return this.dLblsField;
			}
			set
			{
				this.dLblsField = value;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x00062B62 File Offset: 0x00060D62
		// (set) Token: 0x06002760 RID: 10080 RVA: 0x00062B6A File Offset: 0x00060D6A
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng firstSliceAng
		{
			get
			{
				return this.firstSliceAngField;
			}
			set
			{
				this.firstSliceAngField = value;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x00062B73 File Offset: 0x00060D73
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x00062B7B File Offset: 0x00060D7B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_HoleSize holeSize
		{
			get
			{
				return this.holeSizeField;
			}
			set
			{
				this.holeSizeField = value;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00062B84 File Offset: 0x00060D84
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x00062B8C File Offset: 0x00060D8C
		[global::System.Xml.Serialization.XmlArray(Order = 5)]
		[global::System.Xml.Serialization.XmlArrayItem("ext", IsNullable = false)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x04001CFC RID: 7420
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001CFD RID: 7421
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer> serField;

		// Token: 0x04001CFE RID: 7422
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CFF RID: 7423
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng firstSliceAngField;

		// Token: 0x04001D00 RID: 7424
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_HoleSize holeSizeField;

		// Token: 0x04001D01 RID: 7425
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
