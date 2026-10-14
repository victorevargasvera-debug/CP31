using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000463 RID: 1123
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PivotFmt
	{
		// Token: 0x06002CC4 RID: 11460 RVA: 0x000712E4 File Offset: 0x0006F4E4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt ct_PivotFmt = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PivotFmt();
			ct_PivotFmt.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_PivotFmt.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_PivotFmt.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_PivotFmt.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "marker")
				{
					ct_PivotFmt.marker = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dLbl")
				{
					ct_PivotFmt.dLbl = global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_PivotFmt.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_PivotFmt;
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00071424 File Offset: 0x0006F624
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.idx != null)
			{
				this.idx.Write(sw, "idx");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			if (this.txPr != null)
			{
				this.txPr.Write(sw, "txPr");
			}
			if (this.marker != null)
			{
				this.marker.Write(sw, "marker");
			}
			if (this.dLbl != null)
			{
				this.dLbl.Write(sw, "dLbl");
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

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x0007152C File Offset: 0x0006F72C
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x00071534 File Offset: 0x0006F734
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

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x0007153D File Offset: 0x0006F73D
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x00071545 File Offset: 0x0006F745
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x0007154E File Offset: 0x0006F74E
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x00071556 File Offset: 0x0006F756
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x0007155F File Offset: 0x0006F75F
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x00071567 File Offset: 0x0006F767
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00071570 File Offset: 0x0006F770
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x00071578 File Offset: 0x0006F778
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl dLbl
		{
			get
			{
				return this.dLblField;
			}
			set
			{
				this.dLblField = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x00071581 File Offset: 0x0006F781
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x00071589 File Offset: 0x0006F789
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

		// Token: 0x04001F5E RID: 8030
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001F5F RID: 8031
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001F60 RID: 8032
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001F61 RID: 8033
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker markerField;

		// Token: 0x04001F62 RID: 8034
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLbl dLblField;

		// Token: 0x04001F63 RID: 8035
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
