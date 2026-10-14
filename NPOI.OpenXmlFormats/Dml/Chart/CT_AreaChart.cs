using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003CB RID: 971
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AreaChart
	{
		// Token: 0x0600263C RID: 9788 RVA: 0x0005F3C4 File Offset: 0x0005D5C4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart ct_AreaChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaChart();
			ct_AreaChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer>();
			ct_AreaChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_AreaChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "grouping")
				{
					ct_AreaChart.grouping = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_AreaChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_AreaChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dropLines")
				{
					ct_AreaChart.dropLines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_AreaChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_AreaChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_AreaChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_AreaChart;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x0005F554 File Offset: 0x0005D754
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
			if (this.dropLines != null)
			{
				this.dropLines.Write(sw, "dropLines");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer ct_AreaSer in this.ser)
				{
					ct_AreaSer.Write(sw, "ser");
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

		// Token: 0x0600263E RID: 9790 RVA: 0x0005F6E0 File Offset: 0x0005D8E0
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x0005F6F7 File Offset: 0x0005D8F7
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x0005F6FF File Offset: 0x0005D8FF
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

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002641 RID: 9793 RVA: 0x0005F708 File Offset: 0x0005D908
		// (set) Token: 0x06002642 RID: 9794 RVA: 0x0005F710 File Offset: 0x0005D910
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

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002643 RID: 9795 RVA: 0x0005F719 File Offset: 0x0005D919
		// (set) Token: 0x06002644 RID: 9796 RVA: 0x0005F721 File Offset: 0x0005D921
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

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002645 RID: 9797 RVA: 0x0005F72A File Offset: 0x0005D92A
		// (set) Token: 0x06002646 RID: 9798 RVA: 0x0005F732 File Offset: 0x0005D932
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

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002647 RID: 9799 RVA: 0x0005F73B File Offset: 0x0005D93B
		// (set) Token: 0x06002648 RID: 9800 RVA: 0x0005F743 File Offset: 0x0005D943
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

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x0005F74C File Offset: 0x0005D94C
		// (set) Token: 0x0600264A RID: 9802 RVA: 0x0005F754 File Offset: 0x0005D954
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

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x0600264B RID: 9803 RVA: 0x0005F75D File Offset: 0x0005D95D
		// (set) Token: 0x0600264C RID: 9804 RVA: 0x0005F765 File Offset: 0x0005D965
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

		// Token: 0x04001C83 RID: 7299
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping groupingField;

		// Token: 0x04001C84 RID: 7300
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001C85 RID: 7301
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer> serField;

		// Token: 0x04001C86 RID: 7302
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001C87 RID: 7303
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines dropLinesField;

		// Token: 0x04001C88 RID: 7304
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001C89 RID: 7305
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
