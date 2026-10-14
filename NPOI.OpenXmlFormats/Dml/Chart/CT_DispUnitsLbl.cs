using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000428 RID: 1064
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DispUnitsLbl
	{
		// Token: 0x06002A98 RID: 10904 RVA: 0x0006AFFC File Offset: 0x000691FC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnitsLbl Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnitsLbl ct_DispUnitsLbl = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispUnitsLbl();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "layout")
				{
					ct_DispUnitsLbl.layout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_DispUnitsLbl.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_DispUnitsLbl.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_DispUnitsLbl.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_DispUnitsLbl;
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0006B0E4 File Offset: 0x000692E4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.layout != null)
			{
				this.layout.Write(sw, "layout");
			}
			if (this.tx != null)
			{
				this.tx.Write(sw, "tx");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.txPr != null)
			{
				this.txPr.Write(sw, "txPr");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06002A9A RID: 10906 RVA: 0x0006B182 File Offset: 0x00069382
		// (set) Token: 0x06002A9B RID: 10907 RVA: 0x0006B18A File Offset: 0x0006938A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06002A9C RID: 10908 RVA: 0x0006B193 File Offset: 0x00069393
		// (set) Token: 0x06002A9D RID: 10909 RVA: 0x0006B19B File Offset: 0x0006939B
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x0006B1A4 File Offset: 0x000693A4
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x0006B1AC File Offset: 0x000693AC
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06002AA0 RID: 10912 RVA: 0x0006B1B5 File Offset: 0x000693B5
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x0006B1BD File Offset: 0x000693BD
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x04001E54 RID: 7764
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layoutField;

		// Token: 0x04001E55 RID: 7765
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx txField;

		// Token: 0x04001E56 RID: 7766
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001E57 RID: 7767
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;
	}
}
