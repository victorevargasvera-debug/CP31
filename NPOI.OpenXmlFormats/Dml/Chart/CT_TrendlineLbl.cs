using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000442 RID: 1090
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrendlineLbl
	{
		// Token: 0x06002BAA RID: 11178 RVA: 0x0006D980 File Offset: 0x0006BB80
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineLbl Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineLbl ct_TrendlineLbl = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineLbl();
			ct_TrendlineLbl.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "layout")
				{
					ct_TrendlineLbl.layout = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "tx")
				{
					ct_TrendlineLbl.tx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "numFmt")
				{
					ct_TrendlineLbl.numFmt = global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_TrendlineLbl.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "txPr")
				{
					ct_TrendlineLbl.txPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TrendlineLbl.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_TrendlineLbl;
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0006DAC0 File Offset: 0x0006BCC0
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
			if (this.numFmt != null)
			{
				this.numFmt.Write(sw, "numFmt");
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

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0006DBC8 File Offset: 0x0006BDC8
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x0006DBD0 File Offset: 0x0006BDD0
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

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x0006DBD9 File Offset: 0x0006BDD9
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x0006DBE1 File Offset: 0x0006BDE1
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

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0006DBEA File Offset: 0x0006BDEA
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x0006DBF2 File Offset: 0x0006BDF2
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmt
		{
			get
			{
				return this.numFmtField;
			}
			set
			{
				this.numFmtField = value;
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0006DBFB File Offset: 0x0006BDFB
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x0006DC03 File Offset: 0x0006BE03
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

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0006DC0C File Offset: 0x0006BE0C
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x0006DC14 File Offset: 0x0006BE14
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

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0006DC1D File Offset: 0x0006BE1D
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x0006DC25 File Offset: 0x0006BE25
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

		// Token: 0x04001EE6 RID: 7910
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Layout layoutField;

		// Token: 0x04001EE7 RID: 7911
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_Tx txField;

		// Token: 0x04001EE8 RID: 7912
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_NumFmt numFmtField;

		// Token: 0x04001EE9 RID: 7913
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001EEA RID: 7914
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_TextBody txPrField;

		// Token: 0x04001EEB RID: 7915
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
