using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000413 RID: 1043
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Title
	{
		// Token: 0x060029B5 RID: 10677 RVA: 0x00068E58 File Offset: 0x00067058
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title ct_Title = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Title();
			ct_Title.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "tx")
				{
					ct_Title.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "layout")
				{
					ct_Title.layout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "overlay")
				{
					ct_Title.overlay = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Title.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_Title.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Title.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Title;
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00068F98 File Offset: 0x00067198
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.tx != null)
			{
				this.tx.Write(sw, "tx");
			}
			if (this.layout != null)
			{
				this.layout.Write(sw, "layout");
			}
			if (this.overlay != null)
			{
				this.overlay.Write(sw, "overlay");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.txPr != null)
			{
				this.txPr.Write(sw, "txPr");
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

		// Token: 0x060029B7 RID: 10679 RVA: 0x000690A0 File Offset: 0x000672A0
		public bool IsSetTx()
		{
			return this.txField != null;
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000690AB File Offset: 0x000672AB
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx AddNewTx()
		{
			this.txField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx();
			return this.txField;
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000690BE File Offset: 0x000672BE
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x000690C6 File Offset: 0x000672C6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx tx
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

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x000690CF File Offset: 0x000672CF
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x000690D7 File Offset: 0x000672D7
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layout
		{
			get
			{
				return this.layoutField;
			}
			set
			{
				this.layoutField = value;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x060029BD RID: 10685 RVA: 0x000690E0 File Offset: 0x000672E0
		// (set) Token: 0x060029BE RID: 10686 RVA: 0x000690E8 File Offset: 0x000672E8
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean overlay
		{
			get
			{
				return this.overlayField;
			}
			set
			{
				this.overlayField = value;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x000690F1 File Offset: 0x000672F1
		// (set) Token: 0x060029C0 RID: 10688 RVA: 0x000690F9 File Offset: 0x000672F9
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

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x00069102 File Offset: 0x00067302
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x0006910A File Offset: 0x0006730A
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x00069113 File Offset: 0x00067313
		// (set) Token: 0x060029C4 RID: 10692 RVA: 0x0006911B File Offset: 0x0006731B
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x04001DF5 RID: 7669
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx txField;

		// Token: 0x04001DF6 RID: 7670
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layoutField;

		// Token: 0x04001DF7 RID: 7671
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean overlayField;

		// Token: 0x04001DF8 RID: 7672
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001DF9 RID: 7673
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001DFA RID: 7674
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
