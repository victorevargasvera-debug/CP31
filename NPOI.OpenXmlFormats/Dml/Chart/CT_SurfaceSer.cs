using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003EB RID: 1003
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SurfaceSer
	{
		// Token: 0x060027D7 RID: 10199 RVA: 0x00064184 File Offset: 0x00062384
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer ct_SurfaceSer = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SurfaceSer();
			ct_SurfaceSer.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_SurfaceSer.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "order")
				{
					ct_SurfaceSer.order = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_SurfaceSer.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_SurfaceSer.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cat")
				{
					ct_SurfaceSer.cat = global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "val")
				{
					ct_SurfaceSer.val = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_SurfaceSer.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_SurfaceSer;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000642F4 File Offset: 0x000624F4
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
			if (this.cat != null)
			{
				this.cat.Write(sw, "cat");
			}
			if (this.val != null)
			{
				this.val.Write(sw, "val");
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

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x00064418 File Offset: 0x00062618
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x00064420 File Offset: 0x00062620
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

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x00064429 File Offset: 0x00062629
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x00064431 File Offset: 0x00062631
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

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0006443A File Offset: 0x0006263A
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x00064442 File Offset: 0x00062642
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

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x0006444B File Offset: 0x0006264B
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x00064453 File Offset: 0x00062653
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

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x0006445C File Offset: 0x0006265C
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00064464 File Offset: 0x00062664
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x0006446D File Offset: 0x0006266D
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x00064475 File Offset: 0x00062675
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x0006447E File Offset: 0x0006267E
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x00064486 File Offset: 0x00062686
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
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

		// Token: 0x04001D35 RID: 7477
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001D36 RID: 7478
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt orderField;

		// Token: 0x04001D37 RID: 7479
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_SerTx txField;

		// Token: 0x04001D38 RID: 7480
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001D39 RID: 7481
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxDataSource catField;

		// Token: 0x04001D3A RID: 7482
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumDataSource valField;

		// Token: 0x04001D3B RID: 7483
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
