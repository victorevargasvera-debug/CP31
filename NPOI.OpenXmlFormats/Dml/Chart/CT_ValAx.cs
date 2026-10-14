using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200042E RID: 1070
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ValAx
	{
		// Token: 0x06002AB6 RID: 10934 RVA: 0x0006B2F4 File Offset: 0x000694F4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx ct_ValAx = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ValAx();
			ct_ValAx.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "axId")
				{
					ct_ValAx.axId = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scaling")
				{
					ct_ValAx.scaling = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "delete")
				{
					ct_ValAx.delete = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "axPos")
				{
					ct_ValAx.axPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorGridlines")
				{
					ct_ValAx.majorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorGridlines")
				{
					ct_ValAx.minorGridlines = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "title")
				{
					ct_ValAx.title = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_ValAx.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorTickMark")
				{
					ct_ValAx.majorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorTickMark")
				{
					ct_ValAx.minorTickMark = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tickLblPos")
				{
					ct_ValAx.tickLblPos = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_ValAx.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_ValAx.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossAx")
				{
					ct_ValAx.crossAx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crosses")
				{
					ct_ValAx.crosses = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossesAt")
				{
					ct_ValAx.crossesAt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "crossBetween")
				{
					ct_ValAx.crossBetween = global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "majorUnit")
				{
					ct_ValAx.majorUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "minorUnit")
				{
					ct_ValAx.minorUnit = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dispUnits")
				{
					ct_ValAx.dispUnits = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnits.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_ValAx.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ValAx;
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0006B65C File Offset: 0x0006985C
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
			if (this.crosses != null)
			{
				this.crosses.Write(sw, "crosses");
			}
			if (this.crossesAt != null)
			{
				this.crossesAt.Write(sw, "crossesAt");
			}
			if (this.crossBetween != null)
			{
				this.crossBetween.Write(sw, "crossBetween");
			}
			if (this.majorUnit != null)
			{
				this.majorUnit.Write(sw, "majorUnit");
			}
			if (this.minorUnit != null)
			{
				this.minorUnit.Write(sw, "minorUnit");
			}
			if (this.dispUnits != null)
			{
				this.dispUnits.Write(sw, "dispUnits");
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

		// Token: 0x06002AB8 RID: 10936 RVA: 0x0006B8D0 File Offset: 0x00069AD0
		public bool IsSetNumFmt()
		{
			return this.numFmtField != null;
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x0006B8DB File Offset: 0x00069ADB
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt AddNewNumFmt()
		{
			this.numFmtField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt();
			return this.numFmtField;
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0006B8EE File Offset: 0x00069AEE
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses AddNewCrosses()
		{
			this.crossesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses();
			return this.crossesField;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0006B901 File Offset: 0x00069B01
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewAxId()
		{
			this.axIdField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.axIdField;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x0006B914 File Offset: 0x00069B14
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos AddNewAxPos()
		{
			this.axPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos();
			return this.axPosField;
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x0006B927 File Offset: 0x00069B27
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling AddNewScaling()
		{
			this.scalingField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling();
			return this.scalingField;
		}

		// Token: 0x06002ABE RID: 10942 RVA: 0x0006B93A File Offset: 0x00069B3A
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween AddNewCrossBetween()
		{
			this.crossBetweenField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween();
			return this.crossBetweenField;
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x0006B94D File Offset: 0x00069B4D
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewCrossAx()
		{
			this.crossAxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.crossAxField;
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x0006B960 File Offset: 0x00069B60
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos AddNewTickLblPos()
		{
			this.tickLblPosField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos();
			return this.tickLblPosField;
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x0006B973 File Offset: 0x00069B73
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0006B97B File Offset: 0x00069B7B
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

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x0006B984 File Offset: 0x00069B84
		// (set) Token: 0x06002AC4 RID: 10948 RVA: 0x0006B98C File Offset: 0x00069B8C
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

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x0006B995 File Offset: 0x00069B95
		// (set) Token: 0x06002AC6 RID: 10950 RVA: 0x0006B99D File Offset: 0x00069B9D
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

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x0006B9A6 File Offset: 0x00069BA6
		// (set) Token: 0x06002AC8 RID: 10952 RVA: 0x0006B9AE File Offset: 0x00069BAE
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

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0006B9B7 File Offset: 0x00069BB7
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x0006B9BF File Offset: 0x00069BBF
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

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x0006B9C8 File Offset: 0x00069BC8
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x0006B9D0 File Offset: 0x00069BD0
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

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x0006B9D9 File Offset: 0x00069BD9
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x0006B9E1 File Offset: 0x00069BE1
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

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x0006B9EA File Offset: 0x00069BEA
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x0006B9F2 File Offset: 0x00069BF2
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

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x0006B9FB File Offset: 0x00069BFB
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x0006BA03 File Offset: 0x00069C03
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

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x0006BA0C File Offset: 0x00069C0C
		// (set) Token: 0x06002AD4 RID: 10964 RVA: 0x0006BA14 File Offset: 0x00069C14
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

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x0006BA1D File Offset: 0x00069C1D
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x0006BA25 File Offset: 0x00069C25
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

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x0006BA2E File Offset: 0x00069C2E
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x0006BA36 File Offset: 0x00069C36
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

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x0006BA3F File Offset: 0x00069C3F
		// (set) Token: 0x06002ADA RID: 10970 RVA: 0x0006BA47 File Offset: 0x00069C47
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

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x0006BA50 File Offset: 0x00069C50
		// (set) Token: 0x06002ADC RID: 10972 RVA: 0x0006BA58 File Offset: 0x00069C58
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

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06002ADD RID: 10973 RVA: 0x0006BA61 File Offset: 0x00069C61
		// (set) Token: 0x06002ADE RID: 10974 RVA: 0x0006BA69 File Offset: 0x00069C69
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

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x0006BA72 File Offset: 0x00069C72
		// (set) Token: 0x06002AE0 RID: 10976 RVA: 0x0006BA7A File Offset: 0x00069C7A
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

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x0006BA83 File Offset: 0x00069C83
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x0006BA8B File Offset: 0x00069C8B
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween crossBetween
		{
			get
			{
				return this.crossBetweenField;
			}
			set
			{
				this.crossBetweenField = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x0006BA94 File Offset: 0x00069C94
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x0006BA9C File Offset: 0x00069C9C
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
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

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x0006BAA5 File Offset: 0x00069CA5
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x0006BAAD File Offset: 0x00069CAD
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
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

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x0006BAB6 File Offset: 0x00069CB6
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x0006BABE File Offset: 0x00069CBE
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnits dispUnits
		{
			get
			{
				return this.dispUnitsField;
			}
			set
			{
				this.dispUnitsField = value;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x0006BAC7 File Offset: 0x00069CC7
		// (set) Token: 0x06002AEA RID: 10986 RVA: 0x0006BACF File Offset: 0x00069CCF
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
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

		// Token: 0x06002AEB RID: 10987 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean AddNewDelete()
		{
			this.deleteField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean();
			return this.deleteField;
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x0006BAEB File Offset: 0x00069CEB
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark AddNewMajorTickMark()
		{
			this.majorTickMarkField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			return this.majorTickMarkField;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x0006BAFE File Offset: 0x00069CFE
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark AddNewMinorTickMark()
		{
			this.minorTickMarkField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			return this.minorTickMarkField;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x0006BB11 File Offset: 0x00069D11
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines AddNewMajorGridlines()
		{
			this.majorGridlinesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines();
			return this.majorGridlinesField;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x0006BB24 File Offset: 0x00069D24
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines AddNewMinorGridlines()
		{
			this.minorGridlinesField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines();
			return this.minorGridlinesField;
		}

		// Token: 0x04001E6B RID: 7787
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt axIdField;

		// Token: 0x04001E6C RID: 7788
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Scaling scalingField;

		// Token: 0x04001E6D RID: 7789
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean deleteField;

		// Token: 0x04001E6E RID: 7790
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos axPosField;

		// Token: 0x04001E6F RID: 7791
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines majorGridlinesField;

		// Token: 0x04001E70 RID: 7792
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines minorGridlinesField;

		// Token: 0x04001E71 RID: 7793
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title titleField;

		// Token: 0x04001E72 RID: 7794
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001E73 RID: 7795
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark majorTickMarkField;

		// Token: 0x04001E74 RID: 7796
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark minorTickMarkField;

		// Token: 0x04001E75 RID: 7797
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickLblPos tickLblPosField;

		// Token: 0x04001E76 RID: 7798
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001E77 RID: 7799
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001E78 RID: 7800
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt crossAxField;

		// Token: 0x04001E79 RID: 7801
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_CrossBetween crossBetweenField;

		// Token: 0x04001E7A RID: 7802
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit majorUnitField;

		// Token: 0x04001E7B RID: 7803
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit minorUnitField;

		// Token: 0x04001E7C RID: 7804
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnits dispUnitsField;

		// Token: 0x04001E7D RID: 7805
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;

		// Token: 0x04001E7E RID: 7806
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses crossesField;

		// Token: 0x04001E7F RID: 7807
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double crossesAtField;
	}
}
