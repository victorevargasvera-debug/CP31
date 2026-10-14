using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000427 RID: 1063
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CatAx
	{
		// Token: 0x06002A5A RID: 10842 RVA: 0x0006A72C File Offset: 0x0006892C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx ct_CatAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_CatAx();
			ct_CatAx.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "axId")
				{
					ct_CatAx.axId = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scaling")
				{
					ct_CatAx.scaling = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "delete")
				{
					ct_CatAx.delete = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "axPos")
				{
					ct_CatAx.axPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorGridlines")
				{
					ct_CatAx.majorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorGridlines")
				{
					ct_CatAx.minorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "title")
				{
					ct_CatAx.title = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_CatAx.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorTickMark")
				{
					ct_CatAx.majorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorTickMark")
				{
					ct_CatAx.minorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickLblPos")
				{
					ct_CatAx.tickLblPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_CatAx.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_CatAx.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossAx")
				{
					ct_CatAx.crossAx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crosses")
				{
					ct_CatAx.crosses = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossesAt")
				{
					ct_CatAx.crossesAt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "auto")
				{
					ct_CatAx.auto = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lblAlgn")
				{
					ct_CatAx.lblAlgn = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblAlgn.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lblOffset")
				{
					ct_CatAx.lblOffset = global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickLblSkip")
				{
					ct_CatAx.tickLblSkip = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickMarkSkip")
				{
					ct_CatAx.tickMarkSkip = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noMultiLvlLbl")
				{
					ct_CatAx.noMultiLvlLbl = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_CatAx.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_CatAx;
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x0006AADC File Offset: 0x00068CDC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}>", nodeName));
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
			if (this.crossesAt != null)
			{
				this.crossesAt.Write(sw, "crossesAt");
			}
			if (this.crosses != null)
			{
				this.crosses.Write(sw, "crosses");
			}
			if (this.auto != null)
			{
				this.auto.Write(sw, "auto");
			}
			if (this.lblAlgn != null)
			{
				this.lblAlgn.Write(sw, "lblAlgn");
			}
			if (this.lblOffset != null)
			{
				this.lblOffset.Write(sw, "lblOffset");
			}
			if (this.tickLblSkip != null)
			{
				this.tickLblSkip.Write(sw, "tickLblSkip");
			}
			if (this.tickMarkSkip != null)
			{
				this.tickMarkSkip.Write(sw, "tickMarkSkip");
			}
			if (this.noMultiLvlLbl != null)
			{
				this.noMultiLvlLbl.Write(sw, "noMultiLvlLbl");
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

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x0006AD84 File Offset: 0x00068F84
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0006AD8C File Offset: 0x00068F8C
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

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x0006AD95 File Offset: 0x00068F95
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x0006AD9D File Offset: 0x00068F9D
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

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x0006ADA6 File Offset: 0x00068FA6
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x0006ADAE File Offset: 0x00068FAE
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

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x0006ADB7 File Offset: 0x00068FB7
		// (set) Token: 0x06002A63 RID: 10851 RVA: 0x0006ADBF File Offset: 0x00068FBF
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

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x0006ADC8 File Offset: 0x00068FC8
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x0006ADD0 File Offset: 0x00068FD0
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

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x0006ADD9 File Offset: 0x00068FD9
		// (set) Token: 0x06002A67 RID: 10855 RVA: 0x0006ADE1 File Offset: 0x00068FE1
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

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x0006ADEA File Offset: 0x00068FEA
		// (set) Token: 0x06002A69 RID: 10857 RVA: 0x0006ADF2 File Offset: 0x00068FF2
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

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x0006ADFB File Offset: 0x00068FFB
		// (set) Token: 0x06002A6B RID: 10859 RVA: 0x0006AE03 File Offset: 0x00069003
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

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06002A6C RID: 10860 RVA: 0x0006AE0C File Offset: 0x0006900C
		// (set) Token: 0x06002A6D RID: 10861 RVA: 0x0006AE14 File Offset: 0x00069014
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0006AE1D File Offset: 0x0006901D
		// (set) Token: 0x06002A6F RID: 10863 RVA: 0x0006AE25 File Offset: 0x00069025
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

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06002A70 RID: 10864 RVA: 0x0006AE2E File Offset: 0x0006902E
		// (set) Token: 0x06002A71 RID: 10865 RVA: 0x0006AE36 File Offset: 0x00069036
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

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06002A72 RID: 10866 RVA: 0x0006AE3F File Offset: 0x0006903F
		// (set) Token: 0x06002A73 RID: 10867 RVA: 0x0006AE47 File Offset: 0x00069047
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

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x0006AE50 File Offset: 0x00069050
		// (set) Token: 0x06002A75 RID: 10869 RVA: 0x0006AE58 File Offset: 0x00069058
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

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x0006AE61 File Offset: 0x00069061
		// (set) Token: 0x06002A77 RID: 10871 RVA: 0x0006AE69 File Offset: 0x00069069
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

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06002A78 RID: 10872 RVA: 0x0006AE72 File Offset: 0x00069072
		// (set) Token: 0x06002A79 RID: 10873 RVA: 0x0006AE7A File Offset: 0x0006907A
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

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06002A7A RID: 10874 RVA: 0x0006AE83 File Offset: 0x00069083
		// (set) Token: 0x06002A7B RID: 10875 RVA: 0x0006AE8B File Offset: 0x0006908B
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

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0006AE94 File Offset: 0x00069094
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x0006AE9C File Offset: 0x0006909C
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

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06002A7E RID: 10878 RVA: 0x0006AEA5 File Offset: 0x000690A5
		// (set) Token: 0x06002A7F RID: 10879 RVA: 0x0006AEAD File Offset: 0x000690AD
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblAlgn lblAlgn
		{
			get
			{
				return this.lblAlgnField;
			}
			set
			{
				this.lblAlgnField = value;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06002A80 RID: 10880 RVA: 0x0006AEB6 File Offset: 0x000690B6
		// (set) Token: 0x06002A81 RID: 10881 RVA: 0x0006AEBE File Offset: 0x000690BE
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
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

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x0006AEC7 File Offset: 0x000690C7
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x0006AECF File Offset: 0x000690CF
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
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

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x0006AED8 File Offset: 0x000690D8
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x0006AEE0 File Offset: 0x000690E0
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
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

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06002A86 RID: 10886 RVA: 0x0006AEE9 File Offset: 0x000690E9
		// (set) Token: 0x06002A87 RID: 10887 RVA: 0x0006AEF1 File Offset: 0x000690F1
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean noMultiLvlLbl
		{
			get
			{
				return this.noMultiLvlLblField;
			}
			set
			{
				this.noMultiLvlLblField = value;
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x0006AEFA File Offset: 0x000690FA
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x0006AF02 File Offset: 0x00069102
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
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

		// Token: 0x06002A8A RID: 10890 RVA: 0x0006AF0B File Offset: 0x0006910B
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt AddNewNumFmt()
		{
			this.numFmtField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt();
			return this.numFmtField;
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x0006AF1E File Offset: 0x0006911E
		public bool IsSetNumFmt()
		{
			return this.numFmtField != null;
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x0006AF29 File Offset: 0x00069129
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewAxId()
		{
			this.axIdField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.axIdField;
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0006AF3C File Offset: 0x0006913C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos AddNewAxPos()
		{
			this.axPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos();
			return this.axPosField;
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x0006AF4F File Offset: 0x0006914F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling AddNewScaling()
		{
			this.scalingField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling();
			return this.scalingField;
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x0006AF62 File Offset: 0x00069162
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses AddNewCrosses()
		{
			this.crossesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses();
			return this.crossesField;
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x0006AF75 File Offset: 0x00069175
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewCrossAx()
		{
			this.crossAxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.crossAxField;
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x0006AF88 File Offset: 0x00069188
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos AddNewTickLblPos()
		{
			this.tickLblPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos();
			return this.tickLblPosField;
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x0006AF9B File Offset: 0x0006919B
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean AddNewDelete()
		{
			this.deleteField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			return this.deleteField;
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x0006AFAE File Offset: 0x000691AE
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark AddNewMajorTickMark()
		{
			this.majorTickMarkField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			return this.majorTickMarkField;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x0006AFC1 File Offset: 0x000691C1
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines AddNewMajorGridlines()
		{
			this.majorGridlinesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines();
			return this.majorGridlinesField;
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x0006AFD4 File Offset: 0x000691D4
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines AddNewMinorGridlines()
		{
			this.minorGridlinesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines();
			return this.minorGridlinesField;
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x0006AFE7 File Offset: 0x000691E7
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark AddNewMinorTickMark()
		{
			this.minorTickMarkField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			return this.minorTickMarkField;
		}

		// Token: 0x04001E3D RID: 7741
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt axIdField;

		// Token: 0x04001E3E RID: 7742
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling scalingField;

		// Token: 0x04001E3F RID: 7743
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean deleteField;

		// Token: 0x04001E40 RID: 7744
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos axPosField;

		// Token: 0x04001E41 RID: 7745
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines majorGridlinesField;

		// Token: 0x04001E42 RID: 7746
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines minorGridlinesField;

		// Token: 0x04001E43 RID: 7747
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title titleField;

		// Token: 0x04001E44 RID: 7748
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001E45 RID: 7749
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark majorTickMarkField;

		// Token: 0x04001E46 RID: 7750
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark minorTickMarkField;

		// Token: 0x04001E47 RID: 7751
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos tickLblPosField;

		// Token: 0x04001E48 RID: 7752
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001E49 RID: 7753
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001E4A RID: 7754
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt crossAxField;

		// Token: 0x04001E4B RID: 7755
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean autoField;

		// Token: 0x04001E4C RID: 7756
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblAlgn lblAlgnField;

		// Token: 0x04001E4D RID: 7757
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblOffset lblOffsetField;

		// Token: 0x04001E4E RID: 7758
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip tickLblSkipField;

		// Token: 0x04001E4F RID: 7759
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Skip tickMarkSkipField;

		// Token: 0x04001E50 RID: 7760
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean noMultiLvlLblField;

		// Token: 0x04001E51 RID: 7761
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001E52 RID: 7762
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double crossesAtField;

		// Token: 0x04001E53 RID: 7763
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses crossesField;
	}
}
