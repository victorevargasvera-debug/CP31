using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003ED RID: 1005
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Line3DChart
	{
		// Token: 0x0600280A RID: 10250 RVA: 0x00064A54 File Offset: 0x00062C54
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x0600280B RID: 10251 RVA: 0x00064A6B File Offset: 0x00062C6B
		// (set) Token: 0x0600280C RID: 10252 RVA: 0x00064A73 File Offset: 0x00062C73
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

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x0600280D RID: 10253 RVA: 0x00064A7C File Offset: 0x00062C7C
		// (set) Token: 0x0600280E RID: 10254 RVA: 0x00064A84 File Offset: 0x00062C84
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

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x00064A8D File Offset: 0x00062C8D
		// (set) Token: 0x06002810 RID: 10256 RVA: 0x00064A95 File Offset: 0x00062C95
		[global::System.Xml.Serialization.XmlElement("ser", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer> ser
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

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x00064A9E File Offset: 0x00062C9E
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x00064AA6 File Offset: 0x00062CA6
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

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x00064AAF File Offset: 0x00062CAF
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x00064AB7 File Offset: 0x00062CB7
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

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x00064AC0 File Offset: 0x00062CC0
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x00064AC8 File Offset: 0x00062CC8
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

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x00064AD1 File Offset: 0x00062CD1
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x00064AD9 File Offset: 0x00062CD9
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

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x00064AE2 File Offset: 0x00062CE2
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00064AEA File Offset: 0x00062CEA
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

		// Token: 0x0600281B RID: 10267 RVA: 0x00064AF4 File Offset: 0x00062CF4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart ct_Line3DChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Line3DChart();
			ct_Line3DChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer>();
			ct_Line3DChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_Line3DChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "grouping")
				{
					ct_Line3DChart.grouping = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_Line3DChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_Line3DChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dropLines")
				{
					ct_Line3DChart.dropLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gapDepth")
				{
					ct_Line3DChart.gapDepth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_Line3DChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_Line3DChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Line3DChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Line3DChart;
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00064CA8 File Offset: 0x00062EA8
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
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer ct_LineSer in this.ser)
				{
					ct_LineSer.Write(sw, "ser");
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

		// Token: 0x04001D49 RID: 7497
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping groupingField;

		// Token: 0x04001D4A RID: 7498
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001D4B RID: 7499
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer> serField;

		// Token: 0x04001D4C RID: 7500
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D4D RID: 7501
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines dropLinesField;

		// Token: 0x04001D4E RID: 7502
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapDepthField;

		// Token: 0x04001D4F RID: 7503
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001D50 RID: 7504
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
