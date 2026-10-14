using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D8 RID: 984
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RadarSer
	{
		// Token: 0x060026EF RID: 9967 RVA: 0x00061578 File Offset: 0x0005F778
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer ct_RadarSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarSer();
			ct_RadarSer.dPt = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt>();
			ct_RadarSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_RadarSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_RadarSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_RadarSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_RadarSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "marker")
				{
					ct_RadarSer.marker = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbls")
				{
					ct_RadarSer.dLbls = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cat")
				{
					ct_RadarSer.cat = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "val")
				{
					ct_RadarSer.val = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dPt")
				{
					ct_RadarSer.dPt.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_RadarSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RadarSer;
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00061764 File Offset: 0x0005F964
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
			if (this.extLst != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension ct_Extension in this.extLst)
				{
					ct_Extension.Write(sw, "extLst");
				}
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00061904 File Offset: 0x0005FB04
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0006190C File Offset: 0x0005FB0C
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x00061915 File Offset: 0x0005FB15
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x0006191D File Offset: 0x0005FB1D
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

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x00061926 File Offset: 0x0005FB26
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x0006192E File Offset: 0x0005FB2E
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

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x00061937 File Offset: 0x0005FB37
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x0006193F File Offset: 0x0005FB3F
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

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x00061948 File Offset: 0x0005FB48
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00061950 File Offset: 0x0005FB50
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

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x00061959 File Offset: 0x0005FB59
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00061961 File Offset: 0x0005FB61
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

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x0006196A File Offset: 0x0005FB6A
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x00061972 File Offset: 0x0005FB72
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

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x0006197B File Offset: 0x0005FB7B
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x00061983 File Offset: 0x0005FB83
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
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

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x0006198C File Offset: 0x0005FB8C
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x00061994 File Offset: 0x0005FB94
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x0006199D File Offset: 0x0005FB9D
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x000619A5 File Offset: 0x0005FBA5
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
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

		// Token: 0x04001CD2 RID: 7378
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001CD3 RID: 7379
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001CD4 RID: 7380
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001CD5 RID: 7381
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001CD6 RID: 7382
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker markerField;

		// Token: 0x04001CD7 RID: 7383
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_DPt> dPtField;

		// Token: 0x04001CD8 RID: 7384
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbls dLblsField;

		// Token: 0x04001CD9 RID: 7385
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource catField;

		// Token: 0x04001CDA RID: 7386
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource valField;

		// Token: 0x04001CDB RID: 7387
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
