using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003DD RID: 989
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PieChart
	{
		// Token: 0x06002727 RID: 10023 RVA: 0x00062048 File Offset: 0x00060248
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart ct_PieChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieChart();
			ct_PieChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer>();
			ct_PieChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "varyColors")
				{
					ct_PieChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_PieChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "firstSliceAng")
				{
					ct_PieChart.firstSliceAng = global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_PieChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PieChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PieChart;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00062174 File Offset: 0x00060374
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

		// Token: 0x06002729 RID: 10025 RVA: 0x00062298 File Offset: 0x00060498
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x000622AF File Offset: 0x000604AF
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x000622B7 File Offset: 0x000604B7
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

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x000622C0 File Offset: 0x000604C0
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x000622C8 File Offset: 0x000604C8
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

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000622D1 File Offset: 0x000604D1
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x000622D9 File Offset: 0x000604D9
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

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000622E2 File Offset: 0x000604E2
		// (set) Token: 0x06002731 RID: 10033 RVA: 0x000622EA File Offset: 0x000604EA
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

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x000622F3 File Offset: 0x000604F3
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x000622FB File Offset: 0x000604FB
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x04001CEB RID: 7403
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001CEC RID: 7404
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer> serField;

		// Token: 0x04001CED RID: 7405
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CEE RID: 7406
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_FirstSliceAng firstSliceAngField;

		// Token: 0x04001CEF RID: 7407
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
