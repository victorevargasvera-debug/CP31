using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D0 RID: 976
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BubbleChart
	{
		// Token: 0x06002677 RID: 9847 RVA: 0x0005FEF8 File Offset: 0x0005E0F8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart ct_BubbleChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleChart();
			ct_BubbleChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer>();
			ct_BubbleChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_BubbleChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "varyColors")
				{
					ct_BubbleChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_BubbleChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bubble3D")
				{
					ct_BubbleChart.bubble3D = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bubbleScale")
				{
					ct_BubbleChart.bubbleScale = global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleScale.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showNegBubbles")
				{
					ct_BubbleChart.showNegBubbles = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sizeRepresents")
				{
					ct_BubbleChart.sizeRepresents = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SizeRepresents.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_BubbleChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_BubbleChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_BubbleChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_BubbleChart;
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x000600D0 File Offset: 0x0005E2D0
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
			if (this.bubble3D != null)
			{
				this.bubble3D.Write(sw, "bubble3D");
			}
			if (this.bubbleScale != null)
			{
				this.bubbleScale.Write(sw, "bubbleScale");
			}
			if (this.showNegBubbles != null)
			{
				this.showNegBubbles.Write(sw, "showNegBubbles");
			}
			if (this.sizeRepresents != null)
			{
				this.sizeRepresents.Write(sw, "sizeRepresents");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer ct_BubbleSer in this.ser)
				{
					ct_BubbleSer.Write(sw, "ser");
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

		// Token: 0x06002679 RID: 9849 RVA: 0x0006028C File Offset: 0x0005E48C
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x000602A3 File Offset: 0x0005E4A3
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x000602AB File Offset: 0x0005E4AB
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

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x000602B4 File Offset: 0x0005E4B4
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x000602BC File Offset: 0x0005E4BC
		[global::System.Xml.Serialization.XmlElement("ser", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer> ser
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

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x000602C5 File Offset: 0x0005E4C5
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x000602CD File Offset: 0x0005E4CD
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

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x000602D6 File Offset: 0x0005E4D6
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x000602DE File Offset: 0x0005E4DE
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean bubble3D
		{
			get
			{
				return this.bubble3DField;
			}
			set
			{
				this.bubble3DField = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000602E7 File Offset: 0x0005E4E7
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x000602EF File Offset: 0x0005E4EF
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleScale bubbleScale
		{
			get
			{
				return this.bubbleScaleField;
			}
			set
			{
				this.bubbleScaleField = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x000602F8 File Offset: 0x0005E4F8
		// (set) Token: 0x06002685 RID: 9861 RVA: 0x00060300 File Offset: 0x0005E500
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showNegBubbles
		{
			get
			{
				return this.showNegBubblesField;
			}
			set
			{
				this.showNegBubblesField = value;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x00060309 File Offset: 0x0005E509
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x00060311 File Offset: 0x0005E511
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_SizeRepresents sizeRepresents
		{
			get
			{
				return this.sizeRepresentsField;
			}
			set
			{
				this.sizeRepresentsField = value;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0006031A File Offset: 0x0005E51A
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x00060322 File Offset: 0x0005E522
		[global::System.Xml.Serialization.XmlElement("axId", Order = 7)]
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

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0006032B File Offset: 0x0005E52B
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x00060333 File Offset: 0x0005E533
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x04001C9D RID: 7325
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001C9E RID: 7326
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer> serField;

		// Token: 0x04001C9F RID: 7327
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CA0 RID: 7328
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean bubble3DField;

		// Token: 0x04001CA1 RID: 7329
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleScale bubbleScaleField;

		// Token: 0x04001CA2 RID: 7330
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showNegBubblesField;

		// Token: 0x04001CA3 RID: 7331
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SizeRepresents sizeRepresentsField;

		// Token: 0x04001CA4 RID: 7332
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001CA5 RID: 7333
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
