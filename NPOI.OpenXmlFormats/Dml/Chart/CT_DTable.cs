using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200040A RID: 1034
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DTable
	{
		// Token: 0x06002952 RID: 10578 RVA: 0x00067ECC File Offset: 0x000660CC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DTable Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DTable ct_DTable = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DTable();
			ct_DTable.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "showHorzBorder")
				{
					ct_DTable.showHorzBorder = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showVertBorder")
				{
					ct_DTable.showVertBorder = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showOutline")
				{
					ct_DTable.showOutline = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "showKeys")
				{
					ct_DTable.showKeys = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_DTable.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_DTable.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_DTable.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_DTable;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x0006803C File Offset: 0x0006623C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.showHorzBorder != null)
			{
				this.showHorzBorder.Write(sw, "showHorzBorder");
			}
			if (this.showVertBorder != null)
			{
				this.showVertBorder.Write(sw, "showVertBorder");
			}
			if (this.showOutline != null)
			{
				this.showOutline.Write(sw, "showOutline");
			}
			if (this.showKeys != null)
			{
				this.showKeys.Write(sw, "showKeys");
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00068160 File Offset: 0x00066360
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x00068168 File Offset: 0x00066368
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showHorzBorder
		{
			get
			{
				return this.showHorzBorderField;
			}
			set
			{
				this.showHorzBorderField = value;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x00068171 File Offset: 0x00066371
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00068179 File Offset: 0x00066379
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showVertBorder
		{
			get
			{
				return this.showVertBorderField;
			}
			set
			{
				this.showVertBorderField = value;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x00068182 File Offset: 0x00066382
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x0006818A File Offset: 0x0006638A
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showOutline
		{
			get
			{
				return this.showOutlineField;
			}
			set
			{
				this.showOutlineField = value;
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x00068193 File Offset: 0x00066393
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0006819B File Offset: 0x0006639B
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showKeys
		{
			get
			{
				return this.showKeysField;
			}
			set
			{
				this.showKeysField = value;
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000681A4 File Offset: 0x000663A4
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x000681AC File Offset: 0x000663AC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000681B5 File Offset: 0x000663B5
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x000681BD File Offset: 0x000663BD
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000681C6 File Offset: 0x000663C6
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x000681CE File Offset: 0x000663CE
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

		// Token: 0x04001DCA RID: 7626
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showHorzBorderField;

		// Token: 0x04001DCB RID: 7627
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showVertBorderField;

		// Token: 0x04001DCC RID: 7628
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showOutlineField;

		// Token: 0x04001DCD RID: 7629
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean showKeysField;

		// Token: 0x04001DCE RID: 7630
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001DCF RID: 7631
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001DD0 RID: 7632
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
