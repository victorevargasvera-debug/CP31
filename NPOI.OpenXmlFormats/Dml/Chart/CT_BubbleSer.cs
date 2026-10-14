using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003CF RID: 975
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BubbleSer
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x0005F900 File Offset: 0x0005DB00
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer ct_BubbleSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BubbleSer();
			ct_BubbleSer.dPt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt>();
			ct_BubbleSer.trendline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline>();
			ct_BubbleSer.errBars = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars>();
			ct_BubbleSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_BubbleSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_BubbleSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_BubbleSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_BubbleSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "invertIfNegative")
				{
					ct_BubbleSer.invertIfNegative = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_BubbleSer.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "xVal")
				{
					ct_BubbleSer.xVal = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "yVal")
				{
					ct_BubbleSer.yVal = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bubbleSize")
				{
					ct_BubbleSer.bubbleSize = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bubble3D")
				{
					ct_BubbleSer.bubble3D = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dPt")
				{
					ct_BubbleSer.dPt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "trendline")
				{
					ct_BubbleSer.trendline.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "errBars")
				{
					ct_BubbleSer.errBars.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_BubbleSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_BubbleSer;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0005FB9C File Offset: 0x0005DD9C
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
			if (this.invertIfNegative != null)
			{
				this.invertIfNegative.Write(sw, "invertIfNegative");
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
			if (this.bubbleSize != null)
			{
				this.bubbleSize.Write(sw, "bubbleSize");
			}
			if (this.bubble3D != null)
			{
				this.bubble3D.Write(sw, "bubble3D");
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

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x0005FE08 File Offset: 0x0005E008
		// (set) Token: 0x0600265B RID: 9819 RVA: 0x0005FE10 File Offset: 0x0005E010
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

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x0005FE19 File Offset: 0x0005E019
		// (set) Token: 0x0600265D RID: 9821 RVA: 0x0005FE21 File Offset: 0x0005E021
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

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x0005FE2A File Offset: 0x0005E02A
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x0005FE32 File Offset: 0x0005E032
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

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x0005FE3B File Offset: 0x0005E03B
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x0005FE43 File Offset: 0x0005E043
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

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x0005FE4C File Offset: 0x0005E04C
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x0005FE54 File Offset: 0x0005E054
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean invertIfNegative
		{
			get
			{
				return this.invertIfNegativeField;
			}
			set
			{
				this.invertIfNegativeField = value;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x0005FE5D File Offset: 0x0005E05D
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x0005FE65 File Offset: 0x0005E065
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

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x0005FE6E File Offset: 0x0005E06E
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x0005FE76 File Offset: 0x0005E076
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

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x0005FE7F File Offset: 0x0005E07F
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x0005FE87 File Offset: 0x0005E087
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

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x0005FE90 File Offset: 0x0005E090
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x0005FE98 File Offset: 0x0005E098
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

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x0005FEA1 File Offset: 0x0005E0A1
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x0005FEA9 File Offset: 0x0005E0A9
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

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0005FEB2 File Offset: 0x0005E0B2
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x0005FEBA File Offset: 0x0005E0BA
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

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x0005FEC3 File Offset: 0x0005E0C3
		// (set) Token: 0x06002671 RID: 9841 RVA: 0x0005FECB File Offset: 0x0005E0CB
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource bubbleSize
		{
			get
			{
				return this.bubbleSizeField;
			}
			set
			{
				this.bubbleSizeField = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x0005FED4 File Offset: 0x0005E0D4
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x0005FEDC File Offset: 0x0005E0DC
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean bubble3D
		{
			get
			{
				return this.bubble3DField;
			}
			set
			{
				this.bubble3DField = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0005FEE5 File Offset: 0x0005E0E5
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x0005FEED File Offset: 0x0005E0ED
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
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

		// Token: 0x04001C8F RID: 7311
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001C90 RID: 7312
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001C91 RID: 7313
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001C92 RID: 7314
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001C93 RID: 7315
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean invertIfNegativeField;

		// Token: 0x04001C94 RID: 7316
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPtField;

		// Token: 0x04001C95 RID: 7317
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001C96 RID: 7318
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline> trendlineField;

		// Token: 0x04001C97 RID: 7319
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars> errBarsField;

		// Token: 0x04001C98 RID: 7320
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource xValField;

		// Token: 0x04001C99 RID: 7321
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource yValField;

		// Token: 0x04001C9A RID: 7322
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource bubbleSizeField;

		// Token: 0x04001C9B RID: 7323
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean bubble3DField;

		// Token: 0x04001C9C RID: 7324
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
