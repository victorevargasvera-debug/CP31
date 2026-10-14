using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200040B RID: 1035
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SerAx
	{
		// Token: 0x06002963 RID: 10595 RVA: 0x000681D8 File Offset: 0x000663D8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx ct_SerAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerAx();
			ct_SerAx.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "axId")
				{
					ct_SerAx.axId = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scaling")
				{
					ct_SerAx.scaling = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "delete")
				{
					ct_SerAx.delete = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "axPos")
				{
					ct_SerAx.axPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorGridlines")
				{
					ct_SerAx.majorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorGridlines")
				{
					ct_SerAx.minorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "title")
				{
					ct_SerAx.title = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_SerAx.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorTickMark")
				{
					ct_SerAx.majorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorTickMark")
				{
					ct_SerAx.minorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickLblPos")
				{
					ct_SerAx.tickLblPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_SerAx.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_SerAx.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossAx")
				{
					ct_SerAx.crossAx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crosses")
				{
					ct_SerAx.crosses = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossesAt")
				{
					ct_SerAx.crossesAt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickLblSkip")
				{
					ct_SerAx.tickLblSkip = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickMarkSkip")
				{
					ct_SerAx.tickMarkSkip = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_SerAx.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SerAx;
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x000684F8 File Offset: 0x000666F8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.axId != null)
			{
				this.axId.Write(sw, "axId");
			}
			if (this.scaling != null)
			{
				this.scaling.Write(sw, "scaling");
			}
			if (this.delete != null)
			{
				this.delete.Write(sw, "delete");
			}
			if (this.axPos != null)
			{
				this.axPos.Write(sw, "axPos");
			}
			if (this.majorGridlines != null)
			{
				this.majorGridlines.Write(sw, "majorGridlines");
			}
			if (this.minorGridlines != null)
			{
				this.minorGridlines.Write(sw, "minorGridlines");
			}
			if (this.title != null)
			{
				this.title.Write(sw, "title");
			}
			if (this.numFmt != null)
			{
				this.numFmt.Write(sw, "numFmt");
			}
			if (this.majorTickMark != null)
			{
				this.majorTickMark.Write(sw, "majorTickMark");
			}
			if (this.minorTickMark != null)
			{
				this.minorTickMark.Write(sw, "minorTickMark");
			}
			if (this.tickLblPos != null)
			{
				this.tickLblPos.Write(sw, "tickLblPos");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.txPr != null)
			{
				this.txPr.Write(sw, "txPr");
			}
			if (this.crossAx != null)
			{
				this.crossAx.Write(sw, "crossAx");
			}
			if (this.crosses != null)
			{
				this.crosses.Write(sw, "crosses");
			}
			if (this.crossesAt != null)
			{
				this.crossesAt.Write(sw, "crossesAt");
			}
			if (this.tickLblSkip != null)
			{
				this.tickLblSkip.Write(sw, "tickLblSkip");
			}
			if (this.tickMarkSkip != null)
			{
				this.tickMarkSkip.Write(sw, "tickMarkSkip");
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

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06002965 RID: 10597 RVA: 0x00068748 File Offset: 0x00066948
		// (set) Token: 0x06002966 RID: 10598 RVA: 0x00068750 File Offset: 0x00066950
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt axId
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

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06002967 RID: 10599 RVA: 0x00068759 File Offset: 0x00066959
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x00068761 File Offset: 0x00066961
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling scaling
		{
			get
			{
				return this.scalingField;
			}
			set
			{
				this.scalingField = value;
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06002969 RID: 10601 RVA: 0x0006876A File Offset: 0x0006696A
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x00068772 File Offset: 0x00066972
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x0600296B RID: 10603 RVA: 0x0006877B File Offset: 0x0006697B
		// (set) Token: 0x0600296C RID: 10604 RVA: 0x00068783 File Offset: 0x00066983
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos axPos
		{
			get
			{
				return this.axPosField;
			}
			set
			{
				this.axPosField = value;
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600296D RID: 10605 RVA: 0x0006878C File Offset: 0x0006698C
		// (set) Token: 0x0600296E RID: 10606 RVA: 0x00068794 File Offset: 0x00066994
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines majorGridlines
		{
			get
			{
				return this.majorGridlinesField;
			}
			set
			{
				this.majorGridlinesField = value;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x0600296F RID: 10607 RVA: 0x0006879D File Offset: 0x0006699D
		// (set) Token: 0x06002970 RID: 10608 RVA: 0x000687A5 File Offset: 0x000669A5
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines minorGridlines
		{
			get
			{
				return this.minorGridlinesField;
			}
			set
			{
				this.minorGridlinesField = value;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000687AE File Offset: 0x000669AE
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x000687B6 File Offset: 0x000669B6
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06002973 RID: 10611 RVA: 0x000687BF File Offset: 0x000669BF
		// (set) Token: 0x06002974 RID: 10612 RVA: 0x000687C7 File Offset: 0x000669C7
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x000687D0 File Offset: 0x000669D0
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x000687D8 File Offset: 0x000669D8
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark majorTickMark
		{
			get
			{
				return this.majorTickMarkField;
			}
			set
			{
				this.majorTickMarkField = value;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06002977 RID: 10615 RVA: 0x000687E1 File Offset: 0x000669E1
		// (set) Token: 0x06002978 RID: 10616 RVA: 0x000687E9 File Offset: 0x000669E9
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark minorTickMark
		{
			get
			{
				return this.minorTickMarkField;
			}
			set
			{
				this.minorTickMarkField = value;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06002979 RID: 10617 RVA: 0x000687F2 File Offset: 0x000669F2
		// (set) Token: 0x0600297A RID: 10618 RVA: 0x000687FA File Offset: 0x000669FA
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos tickLblPos
		{
			get
			{
				return this.tickLblPosField;
			}
			set
			{
				this.tickLblPosField = value;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x00068803 File Offset: 0x00066A03
		// (set) Token: 0x0600297C RID: 10620 RVA: 0x0006880B File Offset: 0x00066A0B
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
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

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x0600297D RID: 10621 RVA: 0x00068814 File Offset: 0x00066A14
		// (set) Token: 0x0600297E RID: 10622 RVA: 0x0006881C File Offset: 0x00066A1C
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPr
		{
			get
			{
				return this.txPrField;
			}
			set
			{
				this.txPrField = value;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x0600297F RID: 10623 RVA: 0x00068825 File Offset: 0x00066A25
		// (set) Token: 0x06002980 RID: 10624 RVA: 0x0006882D File Offset: 0x00066A2D
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt crossAx
		{
			get
			{
				return this.crossAxField;
			}
			set
			{
				this.crossAxField = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06002981 RID: 10625 RVA: 0x00068836 File Offset: 0x00066A36
		// (set) Token: 0x06002982 RID: 10626 RVA: 0x0006883E File Offset: 0x00066A3E
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses crosses
		{
			get
			{
				return this.crossesField;
			}
			set
			{
				this.crossesField = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06002983 RID: 10627 RVA: 0x00068847 File Offset: 0x00066A47
		// (set) Token: 0x06002984 RID: 10628 RVA: 0x0006884F File Offset: 0x00066A4F
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double crossesAt
		{
			get
			{
				return this.crossesAtField;
			}
			set
			{
				this.crossesAtField = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x00068858 File Offset: 0x00066A58
		// (set) Token: 0x06002986 RID: 10630 RVA: 0x00068860 File Offset: 0x00066A60
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip tickLblSkip
		{
			get
			{
				return this.tickLblSkipField;
			}
			set
			{
				this.tickLblSkipField = value;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06002987 RID: 10631 RVA: 0x00068869 File Offset: 0x00066A69
		// (set) Token: 0x06002988 RID: 10632 RVA: 0x00068871 File Offset: 0x00066A71
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip tickMarkSkip
		{
			get
			{
				return this.tickMarkSkipField;
			}
			set
			{
				this.tickMarkSkipField = value;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x0006887A File Offset: 0x00066A7A
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x00068882 File Offset: 0x00066A82
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
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

		// Token: 0x04001DD1 RID: 7633
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt axIdField;

		// Token: 0x04001DD2 RID: 7634
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling scalingField;

		// Token: 0x04001DD3 RID: 7635
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean deleteField;

		// Token: 0x04001DD4 RID: 7636
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos axPosField;

		// Token: 0x04001DD5 RID: 7637
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines majorGridlinesField;

		// Token: 0x04001DD6 RID: 7638
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines minorGridlinesField;

		// Token: 0x04001DD7 RID: 7639
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title titleField;

		// Token: 0x04001DD8 RID: 7640
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001DD9 RID: 7641
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark majorTickMarkField;

		// Token: 0x04001DDA RID: 7642
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark minorTickMarkField;

		// Token: 0x04001DDB RID: 7643
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos tickLblPosField;

		// Token: 0x04001DDC RID: 7644
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001DDD RID: 7645
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001DDE RID: 7646
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt crossAxField;

		// Token: 0x04001DDF RID: 7647
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip tickLblSkipField;

		// Token: 0x04001DE0 RID: 7648
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip tickMarkSkipField;

		// Token: 0x04001DE1 RID: 7649
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001DE2 RID: 7650
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses crossesField;

		// Token: 0x04001DE3 RID: 7651
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double crossesAtField;
	}
}
