using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003DB RID: 987
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RadarChart
	{
		// Token: 0x0600270B RID: 9995 RVA: 0x00061A88 File Offset: 0x0005FC88
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart ct_RadarChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarChart();
			ct_RadarChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer>();
			ct_RadarChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_RadarChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "radarStyle")
				{
					ct_RadarChart.radarStyle = global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_RadarChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_RadarChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_RadarChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_RadarChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_RadarChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RadarChart;
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00061BE8 File Offset: 0x0005FDE8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.radarStyle != null)
			{
				this.radarStyle.Write(sw, "radarStyle");
			}
			if (this.varyColors != null)
			{
				this.varyColors.Write(sw, "varyColors");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer ct_RadarSer in this.ser)
				{
					ct_RadarSer.Write(sw, "ser");
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

		// Token: 0x0600270D RID: 9997 RVA: 0x00061D58 File Offset: 0x0005FF58
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x00061D6F File Offset: 0x0005FF6F
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x00061D77 File Offset: 0x0005FF77
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarStyle radarStyle
		{
			get
			{
				return this.radarStyleField;
			}
			set
			{
				this.radarStyleField = value;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x00061D80 File Offset: 0x0005FF80
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x00061D88 File Offset: 0x0005FF88
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

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x00061D91 File Offset: 0x0005FF91
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x00061D99 File Offset: 0x0005FF99
		[global::System.Xml.Serialization.XmlElement("ser", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer> ser
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

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x00061DA2 File Offset: 0x0005FFA2
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x00061DAA File Offset: 0x0005FFAA
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x00061DB3 File Offset: 0x0005FFB3
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x00061DBB File Offset: 0x0005FFBB
		[global::System.Xml.Serialization.XmlElement("axId", Order = 4)]
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

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x00061DC4 File Offset: 0x0005FFC4
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x00061DCC File Offset: 0x0005FFCC
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x04001CE1 RID: 7393
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarStyle radarStyleField;

		// Token: 0x04001CE2 RID: 7394
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001CE3 RID: 7395
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer> serField;

		// Token: 0x04001CE4 RID: 7396
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CE5 RID: 7397
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001CE6 RID: 7398
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
