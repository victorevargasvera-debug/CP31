using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000422 RID: 1058
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DateAx
	{
		// Token: 0x06002A0D RID: 10765 RVA: 0x00069C5C File Offset: 0x00067E5C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx ct_DateAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DateAx();
			ct_DateAx.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "axId")
				{
					ct_DateAx.axId = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scaling")
				{
					ct_DateAx.scaling = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "delete")
				{
					ct_DateAx.delete = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "axPos")
				{
					ct_DateAx.axPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorGridlines")
				{
					ct_DateAx.majorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorGridlines")
				{
					ct_DateAx.minorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "title")
				{
					ct_DateAx.title = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_DateAx.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorTickMark")
				{
					ct_DateAx.majorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorTickMark")
				{
					ct_DateAx.minorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickLblPos")
				{
					ct_DateAx.tickLblPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_DateAx.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_DateAx.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossAx")
				{
					ct_DateAx.crossAx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crosses")
				{
					ct_DateAx.crosses = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "auto")
				{
					ct_DateAx.auto = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lblOffset")
				{
					ct_DateAx.lblOffset = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "baseTimeUnit")
				{
					ct_DateAx.baseTimeUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorUnit")
				{
					ct_DateAx.majorUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorTimeUnit")
				{
					ct_DateAx.majorTimeUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorUnit")
				{
					ct_DateAx.minorUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorTimeUnit")
				{
					ct_DateAx.minorTimeUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DateAx.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DateAx;
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0006A00C File Offset: 0x0006820C
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
			if (this.auto != null)
			{
				this.auto.Write(sw, "auto");
			}
			if (this.lblOffset != null)
			{
				this.lblOffset.Write(sw, "lblOffset");
			}
			if (this.baseTimeUnit != null)
			{
				this.baseTimeUnit.Write(sw, "baseTimeUnit");
			}
			if (this.majorUnit != null)
			{
				this.majorUnit.Write(sw, "majorUnit");
			}
			if (this.majorTimeUnit != null)
			{
				this.majorTimeUnit.Write(sw, "majorTimeUnit");
			}
			if (this.minorUnit != null)
			{
				this.minorUnit.Write(sw, "minorUnit");
			}
			if (this.minorTimeUnit != null)
			{
				this.minorTimeUnit.Write(sw, "minorTimeUnit");
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

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x0006A2C0 File Offset: 0x000684C0
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0006A2C8 File Offset: 0x000684C8
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

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0006A2D1 File Offset: 0x000684D1
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0006A2D9 File Offset: 0x000684D9
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

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x0006A2E2 File Offset: 0x000684E2
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0006A2EA File Offset: 0x000684EA
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

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0006A2F3 File Offset: 0x000684F3
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0006A2FB File Offset: 0x000684FB
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

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0006A304 File Offset: 0x00068504
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0006A30C File Offset: 0x0006850C
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

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x0006A315 File Offset: 0x00068515
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x0006A31D File Offset: 0x0006851D
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

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0006A326 File Offset: 0x00068526
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x0006A32E File Offset: 0x0006852E
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

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0006A337 File Offset: 0x00068537
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x0006A33F File Offset: 0x0006853F
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

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x0006A348 File Offset: 0x00068548
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x0006A350 File Offset: 0x00068550
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

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x0006A359 File Offset: 0x00068559
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0006A361 File Offset: 0x00068561
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

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0006A36A File Offset: 0x0006856A
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0006A372 File Offset: 0x00068572
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

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x0006A37B File Offset: 0x0006857B
		// (set) Token: 0x06002A26 RID: 10790 RVA: 0x0006A383 File Offset: 0x00068583
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

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06002A27 RID: 10791 RVA: 0x0006A38C File Offset: 0x0006858C
		// (set) Token: 0x06002A28 RID: 10792 RVA: 0x0006A394 File Offset: 0x00068594
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

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06002A29 RID: 10793 RVA: 0x0006A39D File Offset: 0x0006859D
		// (set) Token: 0x06002A2A RID: 10794 RVA: 0x0006A3A5 File Offset: 0x000685A5
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

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06002A2B RID: 10795 RVA: 0x0006A3AE File Offset: 0x000685AE
		// (set) Token: 0x06002A2C RID: 10796 RVA: 0x0006A3B6 File Offset: 0x000685B6
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
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

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x0006A3BF File Offset: 0x000685BF
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x0006A3C7 File Offset: 0x000685C7
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

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x0006A3D0 File Offset: 0x000685D0
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x0006A3D8 File Offset: 0x000685D8
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean auto
		{
			get
			{
				return this.autoField;
			}
			set
			{
				this.autoField = value;
			}
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0006A3E1 File Offset: 0x000685E1
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x0006A3E9 File Offset: 0x000685E9
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset lblOffset
		{
			get
			{
				return this.lblOffsetField;
			}
			set
			{
				this.lblOffsetField = value;
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06002A33 RID: 10803 RVA: 0x0006A3F2 File Offset: 0x000685F2
		// (set) Token: 0x06002A34 RID: 10804 RVA: 0x0006A3FA File Offset: 0x000685FA
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit baseTimeUnit
		{
			get
			{
				return this.baseTimeUnitField;
			}
			set
			{
				this.baseTimeUnitField = value;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x0006A403 File Offset: 0x00068603
		// (set) Token: 0x06002A36 RID: 10806 RVA: 0x0006A40B File Offset: 0x0006860B
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit majorUnit
		{
			get
			{
				return this.majorUnitField;
			}
			set
			{
				this.majorUnitField = value;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0006A414 File Offset: 0x00068614
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x0006A41C File Offset: 0x0006861C
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit majorTimeUnit
		{
			get
			{
				return this.majorTimeUnitField;
			}
			set
			{
				this.majorTimeUnitField = value;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x0006A425 File Offset: 0x00068625
		// (set) Token: 0x06002A3A RID: 10810 RVA: 0x0006A42D File Offset: 0x0006862D
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit minorUnit
		{
			get
			{
				return this.minorUnitField;
			}
			set
			{
				this.minorUnitField = value;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x0006A436 File Offset: 0x00068636
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x0006A43E File Offset: 0x0006863E
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit minorTimeUnit
		{
			get
			{
				return this.minorTimeUnitField;
			}
			set
			{
				this.minorTimeUnitField = value;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x0006A447 File Offset: 0x00068647
		// (set) Token: 0x06002A3E RID: 10814 RVA: 0x0006A44F File Offset: 0x0006864F
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
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

		// Token: 0x06002A3F RID: 10815 RVA: 0x0006A458 File Offset: 0x00068658
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt AddNewNumFmt()
		{
			this.numFmtField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt();
			return this.numFmtField;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x0006A46B File Offset: 0x0006866B
		public bool IsSetNumFmt()
		{
			return this.numFmtField != null;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x0006A476 File Offset: 0x00068676
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewAxId()
		{
			this.axIdField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.axIdField;
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x0006A489 File Offset: 0x00068689
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos AddNewAxPos()
		{
			this.axPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos();
			return this.axPosField;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x0006A49C File Offset: 0x0006869C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling AddNewScaling()
		{
			this.scalingField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling();
			return this.scalingField;
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x0006A4AF File Offset: 0x000686AF
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses AddNewCrosses()
		{
			this.crossesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses();
			return this.crossesField;
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x0006A4C2 File Offset: 0x000686C2
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewCrossAx()
		{
			this.crossAxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.crossAxField;
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x0006A4D5 File Offset: 0x000686D5
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos AddNewTickLblPos()
		{
			this.tickLblPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos();
			return this.tickLblPosField;
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x0006A4E8 File Offset: 0x000686E8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean AddNewDelete()
		{
			this.deleteField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			return this.deleteField;
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x0006A4FB File Offset: 0x000686FB
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark AddNewMajorTickMark()
		{
			this.majorTickMarkField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			return this.majorTickMarkField;
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x0006A50E File Offset: 0x0006870E
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark AddNewMinorTickMark()
		{
			this.minorTickMarkField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			return this.minorTickMarkField;
		}

		// Token: 0x04001E1E RID: 7710
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt axIdField;

		// Token: 0x04001E1F RID: 7711
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling scalingField;

		// Token: 0x04001E20 RID: 7712
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean deleteField;

		// Token: 0x04001E21 RID: 7713
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos axPosField;

		// Token: 0x04001E22 RID: 7714
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines majorGridlinesField;

		// Token: 0x04001E23 RID: 7715
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines minorGridlinesField;

		// Token: 0x04001E24 RID: 7716
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title titleField;

		// Token: 0x04001E25 RID: 7717
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001E26 RID: 7718
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark majorTickMarkField;

		// Token: 0x04001E27 RID: 7719
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark minorTickMarkField;

		// Token: 0x04001E28 RID: 7720
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos tickLblPosField;

		// Token: 0x04001E29 RID: 7721
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001E2A RID: 7722
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001E2B RID: 7723
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt crossAxField;

		// Token: 0x04001E2C RID: 7724
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean autoField;

		// Token: 0x04001E2D RID: 7725
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset lblOffsetField;

		// Token: 0x04001E2E RID: 7726
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit baseTimeUnitField;

		// Token: 0x04001E2F RID: 7727
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit majorUnitField;

		// Token: 0x04001E30 RID: 7728
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit majorTimeUnitField;

		// Token: 0x04001E31 RID: 7729
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit minorUnitField;

		// Token: 0x04001E32 RID: 7730
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit minorTimeUnitField;

		// Token: 0x04001E33 RID: 7731
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001E34 RID: 7732
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double crossesAtField;

		// Token: 0x04001E35 RID: 7733
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses crossesField;
	}
}
