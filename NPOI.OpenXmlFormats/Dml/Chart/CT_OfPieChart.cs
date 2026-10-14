using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E4 RID: 996
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OfPieChart
	{
		// Token: 0x0600276B RID: 10091 RVA: 0x00062C6C File Offset: 0x00060E6C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart ct_OfPieChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieChart();
			ct_OfPieChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer>();
			ct_OfPieChart.custSplit = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_OfPieChart.serLines = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines>();
			ct_OfPieChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ofPieType")
				{
					ct_OfPieChart.ofPieType = global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_OfPieChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_OfPieChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gapWidth")
				{
					ct_OfPieChart.gapWidth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "splitType")
				{
					ct_OfPieChart.splitType = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SplitType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "splitPos")
				{
					ct_OfPieChart.splitPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "secondPieSize")
				{
					ct_OfPieChart.secondPieSize = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SecondPieSize.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_OfPieChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "custSplit")
				{
					ct_OfPieChart.custSplit.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "serLines")
				{
					ct_OfPieChart.serLines.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_OfPieChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_OfPieChart;
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00062E9C File Offset: 0x0006109C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.ofPieType != null)
			{
				this.ofPieType.Write(sw, "ofPieType");
			}
			if (this.varyColors != null)
			{
				this.varyColors.Write(sw, "varyColors");
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.gapWidth != null)
			{
				this.gapWidth.Write(sw, "gapWidth");
			}
			if (this.splitType != null)
			{
				this.splitType.Write(sw, "splitType");
			}
			if (this.splitPos != null)
			{
				this.splitPos.Write(sw, "splitPos");
			}
			if (this.secondPieSize != null)
			{
				this.secondPieSize.Write(sw, "secondPieSize");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer ct_PieSer in this.ser)
				{
					ct_PieSer.Write(sw, "ser");
				}
			}
			if (this.custSplit != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ct_UnsignedInt in this.custSplit)
				{
					ct_UnsignedInt.Write(sw, "custSplit");
				}
			}
			if (this.serLines != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines ct_ChartLines in this.serLines)
				{
					ct_ChartLines.Write(sw, "serLines");
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

		// Token: 0x0600276D RID: 10093 RVA: 0x000630C0 File Offset: 0x000612C0
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000630D7 File Offset: 0x000612D7
		// (set) Token: 0x0600276F RID: 10095 RVA: 0x000630DF File Offset: 0x000612DF
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieType ofPieType
		{
			get
			{
				return this.ofPieTypeField;
			}
			set
			{
				this.ofPieTypeField = value;
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000630E8 File Offset: 0x000612E8
		// (set) Token: 0x06002771 RID: 10097 RVA: 0x000630F0 File Offset: 0x000612F0
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002772 RID: 10098 RVA: 0x000630F9 File Offset: 0x000612F9
		// (set) Token: 0x06002773 RID: 10099 RVA: 0x00063101 File Offset: 0x00061301
		[global::System.Xml.Serialization.XmlElement("ser", Order = 2)]
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

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002774 RID: 10100 RVA: 0x0006310A File Offset: 0x0006130A
		// (set) Token: 0x06002775 RID: 10101 RVA: 0x00063112 File Offset: 0x00061312
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002776 RID: 10102 RVA: 0x0006311B File Offset: 0x0006131B
		// (set) Token: 0x06002777 RID: 10103 RVA: 0x00063123 File Offset: 0x00061323
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x0006312C File Offset: 0x0006132C
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x00063134 File Offset: 0x00061334
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_SplitType splitType
		{
			get
			{
				return this.splitTypeField;
			}
			set
			{
				this.splitTypeField = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x0006313D File Offset: 0x0006133D
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x00063145 File Offset: 0x00061345
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double splitPos
		{
			get
			{
				return this.splitPosField;
			}
			set
			{
				this.splitPosField = value;
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x0006314E File Offset: 0x0006134E
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x00063156 File Offset: 0x00061356
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> custSplit
		{
			get
			{
				return this.custSplitField;
			}
			set
			{
				this.custSplitField = value;
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x0006315F File Offset: 0x0006135F
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x00063167 File Offset: 0x00061367
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_SecondPieSize secondPieSize
		{
			get
			{
				return this.secondPieSizeField;
			}
			set
			{
				this.secondPieSizeField = value;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x00063170 File Offset: 0x00061370
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x00063178 File Offset: 0x00061378
		[global::System.Xml.Serialization.XmlElement("serLines", Order = 9)]
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

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x00063181 File Offset: 0x00061381
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x00063189 File Offset: 0x00061389
		[global::System.Xml.Serialization.XmlArray(Order = 10)]
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

		// Token: 0x04001D06 RID: 7430
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieType ofPieTypeField;

		// Token: 0x04001D07 RID: 7431
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001D08 RID: 7432
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer> serField;

		// Token: 0x04001D09 RID: 7433
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D0A RID: 7434
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapWidthField;

		// Token: 0x04001D0B RID: 7435
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SplitType splitTypeField;

		// Token: 0x04001D0C RID: 7436
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double splitPosField;

		// Token: 0x04001D0D RID: 7437
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> custSplitField;

		// Token: 0x04001D0E RID: 7438
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SecondPieSize secondPieSizeField;

		// Token: 0x04001D0F RID: 7439
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines> serLinesField;

		// Token: 0x04001D10 RID: 7440
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
