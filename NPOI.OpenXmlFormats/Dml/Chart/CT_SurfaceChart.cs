using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000452 RID: 1106
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SurfaceChart
	{
		// Token: 0x06002C30 RID: 11312 RVA: 0x0006F0F8 File Offset: 0x0006D2F8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart ct_SurfaceChart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceChart();
			ct_SurfaceChart.ser = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer>();
			ct_SurfaceChart.bandFmts = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt>();
			ct_SurfaceChart.axId = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt>();
			ct_SurfaceChart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "wireframe")
				{
					ct_SurfaceChart.wireframe = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ser")
				{
					ct_SurfaceChart.ser.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bandFmts")
				{
					ct_SurfaceChart.bandFmts.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "axId")
				{
					ct_SurfaceChart.axId.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_SurfaceChart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SurfaceChart;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0006F244 File Offset: 0x0006D444
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x0006F3D0 File Offset: 0x0006D5D0
		// (set) Token: 0x06002C33 RID: 11315 RVA: 0x0006F3D8 File Offset: 0x0006D5D8
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

		// Token: 0x06002C34 RID: 11316 RVA: 0x0006F3E1 File Offset: 0x0006D5E1
		public int GetSeriesCount()
		{
			if (this.serField != null)
			{
				return this.serField.Count;
			}
			return 0;
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x0006F3F8 File Offset: 0x0006D5F8
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x0006F400 File Offset: 0x0006D600
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

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x0006F409 File Offset: 0x0006D609
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x0006F411 File Offset: 0x0006D611
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

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x0006F41A File Offset: 0x0006D61A
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x0006F422 File Offset: 0x0006D622
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

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x0006F42B File Offset: 0x0006D62B
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x0006F433 File Offset: 0x0006D633
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

		// Token: 0x04001F1E RID: 7966
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean wireframeField;

		// Token: 0x04001F1F RID: 7967
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer> serField;

		// Token: 0x04001F20 RID: 7968
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt> bandFmtsField;

		// Token: 0x04001F21 RID: 7969
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt> axIdField;

		// Token: 0x04001F22 RID: 7970
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
