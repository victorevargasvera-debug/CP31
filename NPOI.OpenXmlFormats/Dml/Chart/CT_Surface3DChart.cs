using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003EA RID: 1002
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Surface3DChart
	{
		// Token: 0x060027C9 RID: 10185 RVA: 0x00063E40 File Offset: 0x00062040
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart ct_Surface3DChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface3DChart();
			ct_Surface3DChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer>();
			ct_Surface3DChart.bandFmts = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt>();
			ct_Surface3DChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_Surface3DChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "wireframe")
				{
					ct_Surface3DChart.wireframe = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_Surface3DChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bandFmts")
				{
					ct_Surface3DChart.bandFmts.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_Surface3DChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Surface3DChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Surface3DChart;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00063F8C File Offset: 0x0006218C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.wireframe != null)
			{
				this.wireframe.Write(sw, "wireframe");
			}
			if (this.ser != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer ct_SurfaceSer in this.ser)
				{
					ct_SurfaceSer.Write(sw, "ser");
				}
			}
			if (this.bandFmts != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt ct_BandFmt in this.bandFmts)
				{
					ct_BandFmt.Write(sw, "bandFmts");
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

		// Token: 0x060027CB RID: 10187 RVA: 0x00064118 File Offset: 0x00062318
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0006412F File Offset: 0x0006232F
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x00064137 File Offset: 0x00062337
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean wireframe
		{
			get
			{
				return this.wireframeField;
			}
			set
			{
				this.wireframeField = value;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x00064140 File Offset: 0x00062340
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x00064148 File Offset: 0x00062348
		[global::System.Xml.Serialization.XmlElement("ser", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer> ser
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

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x00064151 File Offset: 0x00062351
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00064159 File Offset: 0x00062359
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt> bandFmts
		{
			get
			{
				return this.bandFmtsField;
			}
			set
			{
				this.bandFmtsField = value;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x00064162 File Offset: 0x00062362
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x0006416A File Offset: 0x0006236A
		[global::System.Xml.Serialization.XmlElement("axId", Order = 3)]
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

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00064173 File Offset: 0x00062373
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x0006417B File Offset: 0x0006237B
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

		// Token: 0x04001D30 RID: 7472
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean wireframeField;

		// Token: 0x04001D31 RID: 7473
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer> serField;

		// Token: 0x04001D32 RID: 7474
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt> bandFmtsField;

		// Token: 0x04001D33 RID: 7475
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001D34 RID: 7476
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
