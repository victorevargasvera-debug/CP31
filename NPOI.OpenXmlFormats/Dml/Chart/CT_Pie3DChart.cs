using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003DC RID: 988
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Pie3DChart
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x00061DD8 File Offset: 0x0005FFD8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart ct_Pie3DChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Pie3DChart();
			ct_Pie3DChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer>();
			ct_Pie3DChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "varyColors")
				{
					ct_Pie3DChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_Pie3DChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_Pie3DChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Pie3DChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Pie3DChart;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00061EE0 File Offset: 0x000600E0
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

		// Token: 0x0600271D RID: 10013 RVA: 0x00061FEC File Offset: 0x000601EC
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x00062003 File Offset: 0x00060203
		// (set) Token: 0x0600271F RID: 10015 RVA: 0x0006200B File Offset: 0x0006020B
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x00062014 File Offset: 0x00060214
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x0006201C File Offset: 0x0006021C
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

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x00062025 File Offset: 0x00060225
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0006202D File Offset: 0x0006022D
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

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x00062036 File Offset: 0x00060236
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x0006203E File Offset: 0x0006023E
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x04001CE7 RID: 7399
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001CE8 RID: 7400
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PieSer> serField;

		// Token: 0x04001CE9 RID: 7401
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CEA RID: 7402
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
