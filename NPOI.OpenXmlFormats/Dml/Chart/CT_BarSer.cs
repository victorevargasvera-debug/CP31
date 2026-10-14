using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D6 RID: 982
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BarSer
	{
		// Token: 0x060026B4 RID: 9908 RVA: 0x00060A64 File Offset: 0x0005EC64
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer ct_BarSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarSer();
			ct_BarSer.dPt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt>();
			ct_BarSer.trendline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline>();
			ct_BarSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_BarSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_BarSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_BarSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_BarSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "invertIfNegative")
				{
					ct_BarSer.invertIfNegative = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pictureOptions")
				{
					ct_BarSer.pictureOptions = global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_BarSer.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "errBars")
				{
					ct_BarSer.errBars = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cat")
				{
					ct_BarSer.cat = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "val")
				{
					ct_BarSer.val = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shape")
				{
					ct_BarSer.shape = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dPt")
				{
					ct_BarSer.dPt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "trendline")
				{
					ct_BarSer.trendline.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_BarSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_BarSer;
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00060CF0 File Offset: 0x0005EEF0
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
			if (this.pictureOptions != null)
			{
				this.pictureOptions.Write(sw, "pictureOptions");
			}
			if (this.dLbls != null)
			{
				this.dLbls.Write(sw, "dLbls");
			}
			if (this.errBars != null)
			{
				this.errBars.Write(sw, "errBars");
			}
			if (this.cat != null)
			{
				this.cat.Write(sw, "cat");
			}
			if (this.val != null)
			{
				this.val.Write(sw, "val");
			}
			if (this.shape != null)
			{
				this.shape.Write(sw, "shape");
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
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x00060F28 File Offset: 0x0005F128
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x00060F30 File Offset: 0x0005F130
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

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x060026B8 RID: 9912 RVA: 0x00060F39 File Offset: 0x0005F139
		// (set) Token: 0x060026B9 RID: 9913 RVA: 0x00060F41 File Offset: 0x0005F141
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

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x060026BA RID: 9914 RVA: 0x00060F4A File Offset: 0x0005F14A
		// (set) Token: 0x060026BB RID: 9915 RVA: 0x00060F52 File Offset: 0x0005F152
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

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x00060F5B File Offset: 0x0005F15B
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x00060F63 File Offset: 0x0005F163
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

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x00060F6C File Offset: 0x0005F16C
		// (set) Token: 0x060026BF RID: 9919 RVA: 0x00060F74 File Offset: 0x0005F174
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

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x00060F7D File Offset: 0x0005F17D
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x00060F85 File Offset: 0x0005F185
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x00060F8E File Offset: 0x0005F18E
		// (set) Token: 0x060026C3 RID: 9923 RVA: 0x00060F96 File Offset: 0x0005F196
		[global::System.Xml.Serialization.XmlElement("dPt", Order = 6)]
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

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x00060F9F File Offset: 0x0005F19F
		// (set) Token: 0x060026C5 RID: 9925 RVA: 0x00060FA7 File Offset: 0x0005F1A7
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x00060FB0 File Offset: 0x0005F1B0
		// (set) Token: 0x060026C7 RID: 9927 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		[global::System.Xml.Serialization.XmlElement("trendline", Order = 8)]
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

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060026C8 RID: 9928 RVA: 0x00060FC1 File Offset: 0x0005F1C1
		// (set) Token: 0x060026C9 RID: 9929 RVA: 0x00060FC9 File Offset: 0x0005F1C9
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars errBars
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

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x00060FD2 File Offset: 0x0005F1D2
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x00060FDA File Offset: 0x0005F1DA
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
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

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x00060FE3 File Offset: 0x0005F1E3
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x00060FEB File Offset: 0x0005F1EB
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
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

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x00060FF4 File Offset: 0x0005F1F4
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x00060FFC File Offset: 0x0005F1FC
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape shape
		{
			get
			{
				return this.shapeField;
			}
			set
			{
				this.shapeField = value;
			}
		}

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x00061005 File Offset: 0x0005F205
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0006100D File Offset: 0x0005F20D
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

		// Token: 0x060026D2 RID: 9938 RVA: 0x00061016 File Offset: 0x0005F216
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewIdx()
		{
			this.idxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.idxField;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00061029 File Offset: 0x0005F229
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewOrder()
		{
			this.orderField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.orderField;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0006103C File Offset: 0x0005F23C
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource AddNewCat()
		{
			this.catField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource();
			return this.catField;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0006104F File Offset: 0x0005F24F
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource AddNewVal()
		{
			this.valField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource();
			return this.valField;
		}

		// Token: 0x04001CBA RID: 7354
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001CBB RID: 7355
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001CBC RID: 7356
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001CBD RID: 7357
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001CBE RID: 7358
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean invertIfNegativeField;

		// Token: 0x04001CBF RID: 7359
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureOptions pictureOptionsField;

		// Token: 0x04001CC0 RID: 7360
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPtField;

		// Token: 0x04001CC1 RID: 7361
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CC2 RID: 7362
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline> trendlineField;

		// Token: 0x04001CC3 RID: 7363
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars errBarsField;

		// Token: 0x04001CC4 RID: 7364
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource catField;

		// Token: 0x04001CC5 RID: 7365
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource valField;

		// Token: 0x04001CC6 RID: 7366
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Shape shapeField;

		// Token: 0x04001CC7 RID: 7367
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
