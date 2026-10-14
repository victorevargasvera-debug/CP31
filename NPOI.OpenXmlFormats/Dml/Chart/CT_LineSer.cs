using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003EC RID: 1004
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineSer
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x00064490 File Offset: 0x00062690
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer ct_LineSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LineSer();
			ct_LineSer.dPt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt>();
			ct_LineSer.trendline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline>();
			ct_LineSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_LineSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_LineSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_LineSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_LineSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "marker")
				{
					ct_LineSer.marker = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_LineSer.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "errBars")
				{
					ct_LineSer.errBars = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cat")
				{
					ct_LineSer.cat = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "val")
				{
					ct_LineSer.val = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smooth")
				{
					ct_LineSer.smooth = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dPt")
				{
					ct_LineSer.dPt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "trendline")
				{
					ct_LineSer.trendline.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_LineSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_LineSer;
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000646F8 File Offset: 0x000628F8
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
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x00064918 File Offset: 0x00062B18
		// (set) Token: 0x060027EB RID: 10219 RVA: 0x00064920 File Offset: 0x00062B20
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

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x00064929 File Offset: 0x00062B29
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x00064931 File Offset: 0x00062B31
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

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x0006493A File Offset: 0x00062B3A
		// (set) Token: 0x060027EF RID: 10223 RVA: 0x00064942 File Offset: 0x00062B42
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

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x0006494B File Offset: 0x00062B4B
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x00064953 File Offset: 0x00062B53
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

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0006495C File Offset: 0x00062B5C
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x00064964 File Offset: 0x00062B64
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

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x0006496D File Offset: 0x00062B6D
		// (set) Token: 0x060027F5 RID: 10229 RVA: 0x00064975 File Offset: 0x00062B75
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

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0006497E File Offset: 0x00062B7E
		// (set) Token: 0x060027F7 RID: 10231 RVA: 0x00064986 File Offset: 0x00062B86
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

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x0006498F File Offset: 0x00062B8F
		// (set) Token: 0x060027F9 RID: 10233 RVA: 0x00064997 File Offset: 0x00062B97
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

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x000649A0 File Offset: 0x00062BA0
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x000649A8 File Offset: 0x00062BA8
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x000649B1 File Offset: 0x00062BB1
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x000649B9 File Offset: 0x00062BB9
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

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000649C2 File Offset: 0x00062BC2
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x000649CA File Offset: 0x00062BCA
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

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000649D3 File Offset: 0x00062BD3
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x000649DB File Offset: 0x00062BDB
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

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000649E4 File Offset: 0x00062BE4
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x000649EC File Offset: 0x00062BEC
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

		// Token: 0x06002804 RID: 10244 RVA: 0x000649F5 File Offset: 0x00062BF5
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewIdx()
		{
			this.idxField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.idxField;
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00064A08 File Offset: 0x00062C08
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt AddNewOrder()
		{
			this.orderField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt();
			return this.orderField;
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00064A1B File Offset: 0x00062C1B
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker AddNewMarker()
		{
			this.markerField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker();
			return this.markerField;
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00064A2E File Offset: 0x00062C2E
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource AddNewCat()
		{
			this.catField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource();
			return this.catField;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00064A41 File Offset: 0x00062C41
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource AddNewVal()
		{
			this.valField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource();
			return this.valField;
		}

		// Token: 0x04001D3C RID: 7484
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001D3D RID: 7485
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001D3E RID: 7486
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001D3F RID: 7487
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001D40 RID: 7488
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker markerField;

		// Token: 0x04001D41 RID: 7489
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPtField;

		// Token: 0x04001D42 RID: 7490
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001D43 RID: 7491
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Trendline> trendlineField;

		// Token: 0x04001D44 RID: 7492
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ErrBars errBarsField;

		// Token: 0x04001D45 RID: 7493
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource catField;

		// Token: 0x04001D46 RID: 7494
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource valField;

		// Token: 0x04001D47 RID: 7495
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean smoothField;

		// Token: 0x04001D48 RID: 7496
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
