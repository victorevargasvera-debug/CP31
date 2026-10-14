using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003CA RID: 970
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AreaSer
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x0005EE68 File Offset: 0x0005D068
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer ct_AreaSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AreaSer();
			ct_AreaSer.dPt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt>();
			ct_AreaSer.trendline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline>();
			ct_AreaSer.errBars = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars>();
			ct_AreaSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_AreaSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_AreaSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_AreaSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_AreaSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pictureOptions")
				{
					ct_AreaSer.pictureOptions = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_AreaSer.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cat")
				{
					ct_AreaSer.cat = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "val")
				{
					ct_AreaSer.val = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dPt")
				{
					ct_AreaSer.dPt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "trendline")
				{
					ct_AreaSer.trendline.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "errBars")
				{
					ct_AreaSer.errBars.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_AreaSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_AreaSer;
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x0005F0BC File Offset: 0x0005D2BC
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
			if (this.pictureOptions != null)
			{
				this.pictureOptions.Write(sw, "pictureOptions");
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.cat != null)
			{
				this.cat.Write(sw, "cat");
			}
			if (this.val != null)
			{
				this.val.Write(sw, "val");
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

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x06002623 RID: 9763 RVA: 0x0005F2F8 File Offset: 0x0005D4F8
		// (set) Token: 0x06002624 RID: 9764 RVA: 0x0005F300 File Offset: 0x0005D500
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

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002625 RID: 9765 RVA: 0x0005F309 File Offset: 0x0005D509
		// (set) Token: 0x06002626 RID: 9766 RVA: 0x0005F311 File Offset: 0x0005D511
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

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002627 RID: 9767 RVA: 0x0005F31A File Offset: 0x0005D51A
		// (set) Token: 0x06002628 RID: 9768 RVA: 0x0005F322 File Offset: 0x0005D522
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

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06002629 RID: 9769 RVA: 0x0005F32B File Offset: 0x0005D52B
		// (set) Token: 0x0600262A RID: 9770 RVA: 0x0005F333 File Offset: 0x0005D533
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

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x0005F33C File Offset: 0x0005D53C
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x0005F344 File Offset: 0x0005D544
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptions
		{
			get
			{
				return this.pictureOptionsField;
			}
			set
			{
				this.pictureOptionsField = value;
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x0005F34D File Offset: 0x0005D54D
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x0005F355 File Offset: 0x0005D555
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

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x0005F35E File Offset: 0x0005D55E
		// (set) Token: 0x06002630 RID: 9776 RVA: 0x0005F366 File Offset: 0x0005D566
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

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x0005F36F File Offset: 0x0005D56F
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x0005F377 File Offset: 0x0005D577
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

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002633 RID: 9779 RVA: 0x0005F380 File Offset: 0x0005D580
		// (set) Token: 0x06002634 RID: 9780 RVA: 0x0005F388 File Offset: 0x0005D588
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

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x0005F391 File Offset: 0x0005D591
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x0005F399 File Offset: 0x0005D599
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource cat
		{
			get
			{
				return this.catField;
			}
			set
			{
				this.catField = value;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x0005F3A2 File Offset: 0x0005D5A2
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x0005F3AA File Offset: 0x0005D5AA
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x0005F3B3 File Offset: 0x0005D5B3
		// (set) Token: 0x0600263A RID: 9786 RVA: 0x0005F3BB File Offset: 0x0005D5BB
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
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

		// Token: 0x04001C77 RID: 7287
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001C78 RID: 7288
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001C79 RID: 7289
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001C7A RID: 7290
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001C7B RID: 7291
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptionsField;

		// Token: 0x04001C7C RID: 7292
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPtField;

		// Token: 0x04001C7D RID: 7293
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001C7E RID: 7294
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline> trendlineField;

		// Token: 0x04001C7F RID: 7295
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars> errBarsField;

		// Token: 0x04001C80 RID: 7296
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource catField;

		// Token: 0x04001C81 RID: 7297
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource valField;

		// Token: 0x04001C82 RID: 7298
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
