using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F0 RID: 1008
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_StockChart
	{
		// Token: 0x0600282E RID: 10286 RVA: 0x00065144 File Offset: 0x00063344
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart ct_StockChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_StockChart();
			ct_StockChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer>();
			ct_StockChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_StockChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dLbls")
				{
					ct_StockChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dropLines")
				{
					ct_StockChart.dropLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hiLowLines")
				{
					ct_StockChart.hiLowLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "upDownBars")
				{
					ct_StockChart.upDownBars = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_StockChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_StockChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_StockChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_StockChart;
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x000652D4 File Offset: 0x000634D4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.dropLines != null)
			{
				this.dropLines.Write(sw, "dropLines");
			}
			if (this.hiLowLines != null)
			{
				this.hiLowLines.Write(sw, "hiLowLines");
			}
			if (this.upDownBars != null)
			{
				this.upDownBars.Write(sw, "upDownBars");
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

		// Token: 0x06002830 RID: 10288 RVA: 0x00065460 File Offset: 0x00063660
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x00065477 File Offset: 0x00063677
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0006547F File Offset: 0x0006367F
		[global::System.Xml.Serialization.XmlElement("ser", Order = 0)]
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

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x00065488 File Offset: 0x00063688
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x00065490 File Offset: 0x00063690
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x00065499 File Offset: 0x00063699
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x000654A1 File Offset: 0x000636A1
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x000654AA File Offset: 0x000636AA
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x000654B2 File Offset: 0x000636B2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines hiLowLines
		{
			get
			{
				return this.hiLowLinesField;
			}
			set
			{
				this.hiLowLinesField = value;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x000654BB File Offset: 0x000636BB
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x000654C3 File Offset: 0x000636C3
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars upDownBars
		{
			get
			{
				return this.upDownBarsField;
			}
			set
			{
				this.upDownBarsField = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000654CC File Offset: 0x000636CC
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x000654D4 File Offset: 0x000636D4
		[global::System.Xml.Serialization.XmlElement("axId", Order = 5)]
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

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000654DD File Offset: 0x000636DD
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x000654E5 File Offset: 0x000636E5
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x04001D56 RID: 7510
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer> serField;

		// Token: 0x04001D57 RID: 7511
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D58 RID: 7512
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines dropLinesField;

		// Token: 0x04001D59 RID: 7513
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines hiLowLinesField;

		// Token: 0x04001D5A RID: 7514
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars upDownBarsField;

		// Token: 0x04001D5B RID: 7515
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001D5C RID: 7516
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
