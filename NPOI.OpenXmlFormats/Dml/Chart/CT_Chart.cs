using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000464 RID: 1124
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", ElementName = "chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Chart
	{
		// Token: 0x06002CD3 RID: 11475 RVA: 0x00071594 File Offset: 0x0006F794
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart ct_Chart = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Chart();
			ct_Chart.pivotFmts = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt>();
			ct_Chart.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "title")
				{
					ct_Chart.title = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "autoTitleDeleted")
				{
					ct_Chart.autoTitleDeleted = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "view3D")
				{
					ct_Chart.view3D = global::NPOI.OpenXmlFormats.Dml.Chart.CT_View3D.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "floor")
				{
					ct_Chart.floor = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sideWall")
				{
					ct_Chart.sideWall = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "backWall")
				{
					ct_Chart.backWall = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "plotArea")
				{
					ct_Chart.plotArea = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "legend")
				{
					ct_Chart.legend = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "plotVisOnly")
				{
					ct_Chart.plotVisOnly = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dispBlanksAs")
				{
					ct_Chart.dispBlanksAs = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showDLblsOverMax")
				{
					ct_Chart.showDLblsOverMax = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pivotFmts")
				{
					ct_Chart.pivotFmts.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Chart.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Chart;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x000717EC File Offset: 0x0006F9EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.title != null)
			{
				this.title.Write(sw, "title");
			}
			if (this.autoTitleDeleted != null)
			{
				this.autoTitleDeleted.Write(sw, "autoTitleDeleted");
			}
			if (this.view3D != null)
			{
				this.view3D.Write(sw, "view3D");
			}
			if (this.floor != null)
			{
				this.floor.Write(sw, "floor");
			}
			if (this.sideWall != null)
			{
				this.sideWall.Write(sw, "sideWall");
			}
			if (this.backWall != null)
			{
				this.backWall.Write(sw, "backWall");
			}
			if (this.plotArea != null)
			{
				this.plotArea.Write(sw, "plotArea");
			}
			if (this.legend != null)
			{
				this.legend.Write(sw, "legend");
			}
			if (this.plotVisOnly != null)
			{
				this.plotVisOnly.Write(sw, "plotVisOnly");
			}
			if (this.dispBlanksAs != null)
			{
				this.dispBlanksAs.Write(sw, "dispBlanksAs");
			}
			if (this.showDLblsOverMax != null)
			{
				this.showDLblsOverMax.Write(sw, "showDLblsOverMax");
			}
			if (this.pivotFmts != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt ct_PivotFmt in this.pivotFmts)
				{
					ct_PivotFmt.Write(sw, "pivotFmts");
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

		// Token: 0x06002CD5 RID: 11477 RVA: 0x000719D8 File Offset: 0x0006FBD8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean AddNewPlotVisOnly()
		{
			this.plotVisOnlyField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			return this.plotVisOnlyField;
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x000719EB File Offset: 0x0006FBEB
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea AddNewPlotArea()
		{
			this.plotAreaField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea();
			return this.plotAreaField;
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000719FE File Offset: 0x0006FBFE
		public bool IsSetTitle()
		{
			return this.titleField != null;
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00071A09 File Offset: 0x0006FC09
		public bool IsSetLegend()
		{
			return this.legendField != null;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00071A14 File Offset: 0x0006FC14
		public void unsetLegend()
		{
			this.legendField = null;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00071A1D File Offset: 0x0006FC1D
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend AddNewLegend()
		{
			if (this.legendField == null)
			{
				this.legendField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend();
			}
			return this.legendField;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00071A38 File Offset: 0x0006FC38
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title AddNewTitle()
		{
			this.titleField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title();
			return this.titleField;
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x00071A4B File Offset: 0x0006FC4B
		// (set) Token: 0x06002CDD RID: 11485 RVA: 0x00071A53 File Offset: 0x0006FC53
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x06002CDE RID: 11486 RVA: 0x00071A5C File Offset: 0x0006FC5C
		// (set) Token: 0x06002CDF RID: 11487 RVA: 0x00071A64 File Offset: 0x0006FC64
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean autoTitleDeleted
		{
			get
			{
				return this.autoTitleDeletedField;
			}
			set
			{
				this.autoTitleDeletedField = value;
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x00071A6D File Offset: 0x0006FC6D
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x00071A75 File Offset: 0x0006FC75
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt> pivotFmts
		{
			get
			{
				return this.pivotFmtsField;
			}
			set
			{
				this.pivotFmtsField = value;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x00071A7E File Offset: 0x0006FC7E
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x00071A86 File Offset: 0x0006FC86
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_View3D view3D
		{
			get
			{
				return this.view3DField;
			}
			set
			{
				this.view3DField = value;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x00071A8F File Offset: 0x0006FC8F
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x00071A97 File Offset: 0x0006FC97
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface floor
		{
			get
			{
				return this.floorField;
			}
			set
			{
				this.floorField = value;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x00071AA0 File Offset: 0x0006FCA0
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x00071AA8 File Offset: 0x0006FCA8
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface sideWall
		{
			get
			{
				return this.sideWallField;
			}
			set
			{
				this.sideWallField = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00071AB1 File Offset: 0x0006FCB1
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x00071AB9 File Offset: 0x0006FCB9
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface backWall
		{
			get
			{
				return this.backWallField;
			}
			set
			{
				this.backWallField = value;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x00071AC2 File Offset: 0x0006FCC2
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x00071ACA File Offset: 0x0006FCCA
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotArea
		{
			get
			{
				return this.plotAreaField;
			}
			set
			{
				this.plotAreaField = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x00071AD3 File Offset: 0x0006FCD3
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x00071ADB File Offset: 0x0006FCDB
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend legend
		{
			get
			{
				return this.legendField;
			}
			set
			{
				this.legendField = value;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x00071AE4 File Offset: 0x0006FCE4
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x00071AEC File Offset: 0x0006FCEC
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean plotVisOnly
		{
			get
			{
				return this.plotVisOnlyField;
			}
			set
			{
				this.plotVisOnlyField = value;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x00071AF5 File Offset: 0x0006FCF5
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x00071AFD File Offset: 0x0006FCFD
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs dispBlanksAs
		{
			get
			{
				return this.dispBlanksAsField;
			}
			set
			{
				this.dispBlanksAsField = value;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x00071B06 File Offset: 0x0006FD06
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x00071B0E File Offset: 0x0006FD0E
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showDLblsOverMax
		{
			get
			{
				return this.showDLblsOverMaxField;
			}
			set
			{
				this.showDLblsOverMaxField = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x00071B17 File Offset: 0x0006FD17
		// (set) Token: 0x06002CF5 RID: 11509 RVA: 0x00071B1F File Offset: 0x0006FD1F
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
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

		// Token: 0x04001F64 RID: 8036
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title titleField;

		// Token: 0x04001F65 RID: 8037
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean autoTitleDeletedField;

		// Token: 0x04001F66 RID: 8038
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt> pivotFmtsField;

		// Token: 0x04001F67 RID: 8039
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_View3D view3DField;

		// Token: 0x04001F68 RID: 8040
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface floorField;

		// Token: 0x04001F69 RID: 8041
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface sideWallField;

		// Token: 0x04001F6A RID: 8042
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Surface backWallField;

		// Token: 0x04001F6B RID: 8043
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PlotArea plotAreaField;

		// Token: 0x04001F6C RID: 8044
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Legend legendField;

		// Token: 0x04001F6D RID: 8045
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean plotVisOnlyField;

		// Token: 0x04001F6E RID: 8046
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs dispBlanksAsField;

		// Token: 0x04001F6F RID: 8047
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showDLblsOverMaxField;

		// Token: 0x04001F70 RID: 8048
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
