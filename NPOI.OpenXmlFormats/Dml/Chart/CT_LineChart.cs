using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F1 RID: 1009
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineChart
	{
		// Token: 0x06002840 RID: 10304 RVA: 0x000654F0 File Offset: 0x000636F0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart ct_LineChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineChart();
			ct_LineChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer>();
			ct_LineChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_LineChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "grouping")
				{
					ct_LineChart.grouping = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_LineChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_LineChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dropLines")
				{
					ct_LineChart.dropLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hiLowLines")
				{
					ct_LineChart.hiLowLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "upDownBars")
				{
					ct_LineChart.upDownBars = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "marker")
				{
					ct_LineChart.marker = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smooth")
				{
					ct_LineChart.smooth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_LineChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_LineChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_LineChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_LineChart;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00065710 File Offset: 0x00063910
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
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer ct_LineSer in this.ser)
				{
					ct_LineSer.Write(sw, "ser");
				}
			}
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
			if (this.marker != null)
			{
				this.marker.Write(sw, "marker");
			}
			if (this.smooth != null)
			{
				this.smooth.Write(sw, "smooth");
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

		// Token: 0x06002842 RID: 10306 RVA: 0x00065900 File Offset: 0x00063B00
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x00065917 File Offset: 0x00063B17
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x0006591F File Offset: 0x00063B1F
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

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x00065928 File Offset: 0x00063B28
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x00065930 File Offset: 0x00063B30
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

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x00065939 File Offset: 0x00063B39
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x00065941 File Offset: 0x00063B41
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

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002849 RID: 10313 RVA: 0x0006594A File Offset: 0x00063B4A
		// (set) Token: 0x0600284A RID: 10314 RVA: 0x00065952 File Offset: 0x00063B52
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

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x0006595B File Offset: 0x00063B5B
		// (set) Token: 0x0600284C RID: 10316 RVA: 0x00065963 File Offset: 0x00063B63
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

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x0600284D RID: 10317 RVA: 0x0006596C File Offset: 0x00063B6C
		// (set) Token: 0x0600284E RID: 10318 RVA: 0x00065974 File Offset: 0x00063B74
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x0006597D File Offset: 0x00063B7D
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x00065985 File Offset: 0x00063B85
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x0006598E File Offset: 0x00063B8E
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x00065996 File Offset: 0x00063B96
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean marker
		{
			get
			{
				return this.markerField;
			}
			set
			{
				this.markerField = value;
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x0006599F File Offset: 0x00063B9F
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x000659A7 File Offset: 0x00063BA7
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean smooth
		{
			get
			{
				return this.smoothField;
			}
			set
			{
				this.smoothField = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x000659B0 File Offset: 0x00063BB0
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x000659B8 File Offset: 0x00063BB8
		[global::System.Xml.Serialization.XmlElement("axId", Order = 9)]
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

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000659C1 File Offset: 0x00063BC1
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x000659C9 File Offset: 0x00063BC9
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
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

		// Token: 0x06002859 RID: 10329 RVA: 0x000659D2 File Offset: 0x00063BD2
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping AddNewGrouping()
		{
			this.groupingField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping();
			return this.groupingField;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000659E8 File Offset: 0x00063BE8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer AddNewSer()
		{
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer ct_LineSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer();
			if (this.serField == null)
			{
				this.serField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer>();
			}
			this.serField.Add(ct_LineSer);
			return ct_LineSer;
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00065A1B File Offset: 0x00063C1B
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean AddNewVaryColors()
		{
			this.varyColorsField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			return this.varyColorsField;
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00065A30 File Offset: 0x00063C30
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

		// Token: 0x04001D5D RID: 7517
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping groupingField;

		// Token: 0x04001D5E RID: 7518
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001D5F RID: 7519
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer> serField;

		// Token: 0x04001D60 RID: 7520
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D61 RID: 7521
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines dropLinesField;

		// Token: 0x04001D62 RID: 7522
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines hiLowLinesField;

		// Token: 0x04001D63 RID: 7523
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBars upDownBarsField;

		// Token: 0x04001D64 RID: 7524
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean markerField;

		// Token: 0x04001D65 RID: 7525
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean smoothField;

		// Token: 0x04001D66 RID: 7526
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001D67 RID: 7527
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
