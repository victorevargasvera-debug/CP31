using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D1 RID: 977
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BarChart
	{
		// Token: 0x0600268D RID: 9869 RVA: 0x0006033C File Offset: 0x0005E53C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart ct_BarChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarChart();
			ct_BarChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer>();
			ct_BarChart.serLines = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines>();
			ct_BarChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_BarChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "barDir")
				{
					ct_BarChart.barDir = global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grouping")
				{
					ct_BarChart.grouping = global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_BarChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_BarChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gapWidth")
				{
					ct_BarChart.gapWidth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "overlap")
				{
					ct_BarChart.overlap = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Overlap.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_BarChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "serLines")
				{
					ct_BarChart.serLines.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_BarChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_BarChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_BarChart;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00060548 File Offset: 0x0005E748
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.barDir != null)
			{
				this.barDir.Write(sw, "barDir");
			}
			if (this.grouping != null)
			{
				this.grouping.Write(sw, "grouping");
			}
			if (this.varyColors != null)
			{
				this.varyColors.Write(sw, "varyColors");
			}
			if (this.gapWidth != null)
			{
				this.gapWidth.Write(sw, "gapWidth");
			}
			if (this.overlap != null)
			{
				this.overlap.Write(sw, "overlap");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer ct_BarSer in this.ser)
				{
					ct_BarSer.Write(sw, "ser");
				}
			}
			if (this.serLines != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines ct_ChartLines in this.serLines)
				{
					ct_ChartLines.Write(sw, "serLines");
				}
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.axId != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ct_UnsignedInt in this.axId)
				{
					ct_UnsignedInt.Write(sw, "axId");
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

		// Token: 0x0600268F RID: 9871 RVA: 0x00060750 File Offset: 0x0005E950
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x00060767 File Offset: 0x0005E967
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x0006076F File Offset: 0x0005E96F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir barDir
		{
			get
			{
				return this.barDirField;
			}
			set
			{
				this.barDirField = value;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x00060778 File Offset: 0x0005E978
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x00060780 File Offset: 0x0005E980
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping grouping
		{
			get
			{
				return this.groupingField;
			}
			set
			{
				this.groupingField = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x00060789 File Offset: 0x0005E989
		// (set) Token: 0x06002695 RID: 9877 RVA: 0x00060791 File Offset: 0x0005E991
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002696 RID: 9878 RVA: 0x0006079A File Offset: 0x0005E99A
		// (set) Token: 0x06002697 RID: 9879 RVA: 0x000607A2 File Offset: 0x0005E9A2
		[global::System.Xml.Serialization.XmlElement("ser", Order = 3)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer> ser
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

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x000607AB File Offset: 0x0005E9AB
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x000607B3 File Offset: 0x0005E9B3
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x000607BC File Offset: 0x0005E9BC
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x000607C4 File Offset: 0x0005E9C4
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapWidth
		{
			get
			{
				return this.gapWidthField;
			}
			set
			{
				this.gapWidthField = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x000607CD File Offset: 0x0005E9CD
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x000607D5 File Offset: 0x0005E9D5
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Overlap overlap
		{
			get
			{
				return this.overlapField;
			}
			set
			{
				this.overlapField = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x000607DE File Offset: 0x0005E9DE
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x000607E6 File Offset: 0x0005E9E6
		[global::System.Xml.Serialization.XmlElement("serLines", Order = 7)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines> serLines
		{
			get
			{
				return this.serLinesField;
			}
			set
			{
				this.serLinesField = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x000607EF File Offset: 0x0005E9EF
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x000607F7 File Offset: 0x0005E9F7
		[global::System.Xml.Serialization.XmlElement("axId", Order = 8)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axId
		{
			get
			{
				return this.axIdField;
			}
			set
			{
				this.axIdField = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x00060800 File Offset: 0x0005EA00
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x00060808 File Offset: 0x0005EA08
		[global::System.Xml.Serialization.XmlArray(Order = 9)]
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

		// Token: 0x060026A4 RID: 9892 RVA: 0x00060811 File Offset: 0x0005EA11
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping AddNewGrouping()
		{
			this.groupingField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping();
			return this.groupingField;
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00060824 File Offset: 0x0005EA24
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer AddNewSer()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer ct_BarSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer();
			if (this.serField == null)
			{
				this.serField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer>();
			}
			this.serField.Add(ct_BarSer);
			return ct_BarSer;
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00060857 File Offset: 0x0005EA57
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean AddNewVaryColors()
		{
			this.varyColorsField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			return this.varyColorsField;
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x0006086C File Offset: 0x0005EA6C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewAxId()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ct_UnsignedInt = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			if (this.axIdField == null)
			{
				this.axIdField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			}
			this.axIdField.Add(ct_UnsignedInt);
			return ct_UnsignedInt;
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0006089F File Offset: 0x0005EA9F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir AddNewBarDir()
		{
			this.barDirField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir();
			return this.barDirField;
		}

		// Token: 0x04001CA6 RID: 7334
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir barDirField;

		// Token: 0x04001CA7 RID: 7335
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping groupingField;

		// Token: 0x04001CA8 RID: 7336
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001CA9 RID: 7337
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer> serField;

		// Token: 0x04001CAA RID: 7338
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CAB RID: 7339
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapWidthField;

		// Token: 0x04001CAC RID: 7340
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Overlap overlapField;

		// Token: 0x04001CAD RID: 7341
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines> serLinesField;

		// Token: 0x04001CAE RID: 7342
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001CAF RID: 7343
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
