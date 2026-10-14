using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E8 RID: 1000
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ScatterChart
	{
		// Token: 0x060027AB RID: 10155 RVA: 0x00063864 File Offset: 0x00061A64
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart ct_ScatterChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterChart();
			ct_ScatterChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer>();
			ct_ScatterChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_ScatterChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "scatterStyle")
				{
					ct_ScatterChart.scatterStyle = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "varyColors")
				{
					ct_ScatterChart.varyColors = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_ScatterChart.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_ScatterChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_ScatterChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ScatterChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ScatterChart;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000639C4 File Offset: 0x00061BC4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.scatterStyle != null)
			{
				this.scatterStyle.Write(sw, "scatterStyle");
			}
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
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer ct_ScatterSer in this.ser)
				{
					ct_ScatterSer.Write(sw, "ser");
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

		// Token: 0x060027AD RID: 10157 RVA: 0x00063B34 File Offset: 0x00061D34
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle AddNewScatterStyle()
		{
			this.scatterStyleField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle();
			return this.scatterStyleField;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00063B48 File Offset: 0x00061D48
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewAxId()
		{
			if (this.axIdField == null)
			{
				this.axIdField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt ct_UnsignedInt = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			this.axIdField.Add(ct_UnsignedInt);
			return ct_UnsignedInt;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00063B7C File Offset: 0x00061D7C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer AddNewSer()
		{
			if (this.serField == null)
			{
				this.serField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer>();
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer ct_ScatterSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer();
			this.serField.Add(ct_ScatterSer);
			return ct_ScatterSer;
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00063BAF File Offset: 0x00061DAF
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00063BC6 File Offset: 0x00061DC6
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x00063BCE File Offset: 0x00061DCE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle scatterStyle
		{
			get
			{
				return this.scatterStyleField;
			}
			set
			{
				this.scatterStyleField = value;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x00063BD7 File Offset: 0x00061DD7
		// (set) Token: 0x060027B4 RID: 10164 RVA: 0x00063BDF File Offset: 0x00061DDF
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

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x00063BE8 File Offset: 0x00061DE8
		// (set) Token: 0x060027B6 RID: 10166 RVA: 0x00063BF0 File Offset: 0x00061DF0
		[global::System.Xml.Serialization.XmlElement("ser", Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer> ser
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

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x00063BF9 File Offset: 0x00061DF9
		// (set) Token: 0x060027B8 RID: 10168 RVA: 0x00063C01 File Offset: 0x00061E01
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

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x00063C0A File Offset: 0x00061E0A
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x00063C12 File Offset: 0x00061E12
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

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x00063C1B File Offset: 0x00061E1B
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x00063C23 File Offset: 0x00061E23
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

		// Token: 0x04001D26 RID: 7462
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle scatterStyleField;

		// Token: 0x04001D27 RID: 7463
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean varyColorsField;

		// Token: 0x04001D28 RID: 7464
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer> serField;

		// Token: 0x04001D29 RID: 7465
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D2A RID: 7466
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001D2B RID: 7467
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
