using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E5 RID: 997
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ScatterSer
	{
		// Token: 0x06002785 RID: 10117 RVA: 0x00063194 File Offset: 0x00061394
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer ct_ScatterSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterSer();
			ct_ScatterSer.dPt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt>();
			ct_ScatterSer.trendline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline>();
			ct_ScatterSer.errBars = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars>();
			ct_ScatterSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_ScatterSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_ScatterSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_ScatterSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_ScatterSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "marker")
				{
					ct_ScatterSer.marker = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_ScatterSer.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "xVal")
				{
					ct_ScatterSer.xVal = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "yVal")
				{
					ct_ScatterSer.yVal = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smooth")
				{
					ct_ScatterSer.smooth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dPt")
				{
					ct_ScatterSer.dPt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "trendline")
				{
					ct_ScatterSer.trendline.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "errBars")
				{
					ct_ScatterSer.errBars.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ScatterSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ScatterSer;
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x0006340C File Offset: 0x0006160C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.idx != null)
			{
				this.idx.Write(sw, "idx");
			}
			if (this.order != null)
			{
				this.order.Write(sw, "order");
			}
			if (this.tx != null)
			{
				this.tx.Write(sw, "tx");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.marker != null)
			{
				this.marker.Write(sw, "marker");
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.xVal != null)
			{
				this.xVal.Write(sw, "xVal");
			}
			if (this.yVal != null)
			{
				this.yVal.Write(sw, "yVal");
			}
			if (this.smooth != null)
			{
				this.smooth.Write(sw, "smooth");
			}
			if (this.dPt != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt ct_DPt in this.dPt)
				{
					ct_DPt.Write(sw, "dPt");
				}
			}
			if (this.trendline != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline ct_Trendline in this.trendline)
				{
					ct_Trendline.Write(sw, "trendline");
				}
			}
			if (this.errBars != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars ct_ErrBars in this.errBars)
				{
					ct_ErrBars.Write(sw, "errBars");
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

		// Token: 0x06002787 RID: 10119 RVA: 0x00063660 File Offset: 0x00061860
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewIdx()
		{
			this.idxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.idxField;
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00063673 File Offset: 0x00061873
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewOrder()
		{
			this.orderField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.orderField;
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00063686 File Offset: 0x00061886
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource AddNewXVal()
		{
			this.xValField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource();
			return this.xValField;
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x00063699 File Offset: 0x00061899
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource AddNewYVal()
		{
			this.yValField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource();
			return this.yValField;
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000636AC File Offset: 0x000618AC
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x000636B4 File Offset: 0x000618B4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000636BD File Offset: 0x000618BD
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x000636C5 File Offset: 0x000618C5
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000636CE File Offset: 0x000618CE
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x000636D6 File Offset: 0x000618D6
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx tx
		{
			get
			{
				return this.txField;
			}
			set
			{
				this.txField = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000636DF File Offset: 0x000618DF
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x000636E7 File Offset: 0x000618E7
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPr
		{
			get
			{
				return this.spPrField;
			}
			set
			{
				this.spPrField = value;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x000636F0 File Offset: 0x000618F0
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x000636F8 File Offset: 0x000618F8
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker marker
		{
			get
			{
				return this.markerField;
			}
			set
			{
				this.markerField = value;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x00063701 File Offset: 0x00061901
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x00063709 File Offset: 0x00061909
		[global::System.Xml.Serialization.XmlElement("dPt", Order = 5)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPt
		{
			get
			{
				return this.dPtField;
			}
			set
			{
				this.dPtField = value;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x00063712 File Offset: 0x00061912
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x0006371A File Offset: 0x0006191A
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x00063723 File Offset: 0x00061923
		// (set) Token: 0x0600279A RID: 10138 RVA: 0x0006372B File Offset: 0x0006192B
		[global::System.Xml.Serialization.XmlElement("trendline", Order = 7)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline> trendline
		{
			get
			{
				return this.trendlineField;
			}
			set
			{
				this.trendlineField = value;
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00063734 File Offset: 0x00061934
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x0006373C File Offset: 0x0006193C
		[global::System.Xml.Serialization.XmlElement("errBars", Order = 8)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars> errBars
		{
			get
			{
				return this.errBarsField;
			}
			set
			{
				this.errBarsField = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x00063745 File Offset: 0x00061945
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x0006374D File Offset: 0x0006194D
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource xVal
		{
			get
			{
				return this.xValField;
			}
			set
			{
				this.xValField = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x00063756 File Offset: 0x00061956
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x0006375E File Offset: 0x0006195E
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource yVal
		{
			get
			{
				return this.yValField;
			}
			set
			{
				this.yValField = value;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x00063767 File Offset: 0x00061967
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x0006376F File Offset: 0x0006196F
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean smooth
		{
			get
			{
				return this.smoothField;
			}
			set
			{
				this.smoothField = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x00063778 File Offset: 0x00061978
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x00063780 File Offset: 0x00061980
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

		// Token: 0x04001D11 RID: 7441
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001D12 RID: 7442
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001D13 RID: 7443
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001D14 RID: 7444
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001D15 RID: 7445
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker markerField;

		// Token: 0x04001D16 RID: 7446
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPtField;

		// Token: 0x04001D17 RID: 7447
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D18 RID: 7448
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline> trendlineField;

		// Token: 0x04001D19 RID: 7449
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars> errBarsField;

		// Token: 0x04001D1A RID: 7450
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource xValField;

		// Token: 0x04001D1B RID: 7451
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource yValField;

		// Token: 0x04001D1C RID: 7452
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean smoothField;

		// Token: 0x04001D1D RID: 7453
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
