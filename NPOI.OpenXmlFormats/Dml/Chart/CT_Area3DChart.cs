using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003C9 RID: 969
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Area3DChart
	{
		// Token: 0x0600260D RID: 9741 RVA: 0x0005EA70 File Offset: 0x0005CC70
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart ct_Area3DChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Area3DChart();
			ct_Area3DChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer>();
			ct_Area3DChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_Area3DChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "grouping")
				{
					ct_Area3DChart.grouping = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_Area3DChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_Area3DChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dropLines")
				{
					ct_Area3DChart.dropLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gapDepth")
				{
					ct_Area3DChart.gapDepth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_Area3DChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_Area3DChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Area3DChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Area3DChart;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x0005EC24 File Offset: 0x0005CE24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.grouping != null)
			{
				this.grouping.Write(sw, "grouping");
			}
			if (this.varyColors != null)
			{
				this.varyColors.Write(sw, "varyColors");
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.dropLines != null)
			{
				this.dropLines.Write(sw, "dropLines");
			}
			if (this.gapDepth != null)
			{
				this.gapDepth.Write(sw, "gapDepth");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer ct_AreaSer in this.ser)
				{
					ct_AreaSer.Write(sw, "ser");
				}
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

		// Token: 0x0600260F RID: 9743 RVA: 0x0005EDC8 File Offset: 0x0005CFC8
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x0005EDDF File Offset: 0x0005CFDF
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x0005EDE7 File Offset: 0x0005CFE7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping grouping
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

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0005EDF0 File Offset: 0x0005CFF0
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x0005EDF8 File Offset: 0x0005CFF8
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

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0005EE01 File Offset: 0x0005D001
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x0005EE09 File Offset: 0x0005D009
		[global::System.Xml.Serialization.XmlElement("ser", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer> ser
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

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x0005EE12 File Offset: 0x0005D012
		// (set) Token: 0x06002617 RID: 9751 RVA: 0x0005EE1A File Offset: 0x0005D01A
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

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x0005EE23 File Offset: 0x0005D023
		// (set) Token: 0x06002619 RID: 9753 RVA: 0x0005EE2B File Offset: 0x0005D02B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines dropLines
		{
			get
			{
				return this.dropLinesField;
			}
			set
			{
				this.dropLinesField = value;
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x0005EE34 File Offset: 0x0005D034
		// (set) Token: 0x0600261B RID: 9755 RVA: 0x0005EE3C File Offset: 0x0005D03C
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapDepth
		{
			get
			{
				return this.gapDepthField;
			}
			set
			{
				this.gapDepthField = value;
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x0005EE45 File Offset: 0x0005D045
		// (set) Token: 0x0600261D RID: 9757 RVA: 0x0005EE4D File Offset: 0x0005D04D
		[global::System.Xml.Serialization.XmlElement("axId", Order = 6)]
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

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x0005EE56 File Offset: 0x0005D056
		// (set) Token: 0x0600261F RID: 9759 RVA: 0x0005EE5E File Offset: 0x0005D05E
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x04001C6F RID: 7279
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping groupingField;

		// Token: 0x04001C70 RID: 7280
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001C71 RID: 7281
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer> serField;

		// Token: 0x04001C72 RID: 7282
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001C73 RID: 7283
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines dropLinesField;

		// Token: 0x04001C74 RID: 7284
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapDepthField;

		// Token: 0x04001C75 RID: 7285
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001C76 RID: 7286
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
