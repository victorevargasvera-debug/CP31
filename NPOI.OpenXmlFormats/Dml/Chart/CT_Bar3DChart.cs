using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D7 RID: 983
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Bar3DChart
	{
		// Token: 0x060026D6 RID: 9942 RVA: 0x00061064 File Offset: 0x0005F264
		public CT_Bar3DChart()
		{
			this.extLstField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			this.axIdField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			this.shapeField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape();
			this.gapDepthField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount();
			this.gapWidthField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount();
			this.dLblsField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls();
			this.serField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer>();
			this.varyColorsField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			this.groupingField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping();
			this.barDirField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir();
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x000610E5 File Offset: 0x0005F2E5
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000610FC File Offset: 0x0005F2FC
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00061104 File Offset: 0x0005F304
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir barDir
		{
			get
			{
				return this.barDirField;
			}
			set
			{
				this.barDirField = value;
			}
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x0006110D File Offset: 0x0005F30D
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x00061115 File Offset: 0x0005F315
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping grouping
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

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x0006111E File Offset: 0x0005F31E
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x00061126 File Offset: 0x0005F326
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17000EC4 RID: 3780
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x0006112F File Offset: 0x0005F32F
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x00061137 File Offset: 0x0005F337
		[global::System.Xml.Serialization.XmlElement("ser", Order = 3)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer> ser
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

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x00061140 File Offset: 0x0005F340
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x00061148 File Offset: 0x0005F348
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x00061151 File Offset: 0x0005F351
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x00061159 File Offset: 0x0005F359
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x060026E4 RID: 9956 RVA: 0x00061162 File Offset: 0x0005F362
		// (set) Token: 0x060026E5 RID: 9957 RVA: 0x0006116A File Offset: 0x0005F36A
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x060026E6 RID: 9958 RVA: 0x00061173 File Offset: 0x0005F373
		// (set) Token: 0x060026E7 RID: 9959 RVA: 0x0006117B File Offset: 0x0005F37B
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape shape
		{
			get
			{
				return this.shapeField;
			}
			set
			{
				this.shapeField = value;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x060026E8 RID: 9960 RVA: 0x00061184 File Offset: 0x0005F384
		// (set) Token: 0x060026E9 RID: 9961 RVA: 0x0006118C File Offset: 0x0005F38C
		[global::System.Xml.Serialization.XmlElement("axId", Order = 8)]
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

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x060026EA RID: 9962 RVA: 0x00061195 File Offset: 0x0005F395
		// (set) Token: 0x060026EB RID: 9963 RVA: 0x0006119D File Offset: 0x0005F39D
		[global::System.Xml.Serialization.XmlArray(Order = 9)]
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

		// Token: 0x060026EC RID: 9964 RVA: 0x000611A8 File Offset: 0x0005F3A8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart ct_Bar3DChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Bar3DChart();
			ct_Bar3DChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer>();
			ct_Bar3DChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_Bar3DChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "barDir")
				{
					ct_Bar3DChart.barDir = global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grouping")
				{
					ct_Bar3DChart.grouping = global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_Bar3DChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_Bar3DChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gapWidth")
				{
					ct_Bar3DChart.gapWidth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gapDepth")
				{
					ct_Bar3DChart.gapDepth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shape")
				{
					ct_Bar3DChart.shape = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_Bar3DChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_Bar3DChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Bar3DChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Bar3DChart;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000613A4 File Offset: 0x0005F5A4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.barDir != null)
			{
				this.barDir.Write(sw, "barDir");
			}
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
			if (this.gapWidth != null)
			{
				this.gapWidth.Write(sw, "gapWidth");
			}
			if (this.gapDepth != null)
			{
				this.gapDepth.Write(sw, "gapDepth");
			}
			if (this.shape != null)
			{
				this.shape.Write(sw, "shape");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer ct_BarSer in this.ser)
				{
					ct_BarSer.Write(sw, "ser");
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

		// Token: 0x04001CC8 RID: 7368
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir barDirField;

		// Token: 0x04001CC9 RID: 7369
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping groupingField;

		// Token: 0x04001CCA RID: 7370
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001CCB RID: 7371
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer> serField;

		// Token: 0x04001CCC RID: 7372
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CCD RID: 7373
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapWidthField;

		// Token: 0x04001CCE RID: 7374
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_GapAmount gapDepthField;

		// Token: 0x04001CCF RID: 7375
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape shapeField;

		// Token: 0x04001CD0 RID: 7376
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001CD1 RID: 7377
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
