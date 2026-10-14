using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000431 RID: 1073
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Marker
	{
		// Token: 0x06002B0C RID: 11020 RVA: 0x0006BFE0 File Offset: 0x0006A1E0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker ct_Marker = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Marker();
			ct_Marker.extLst = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "symbol")
				{
					ct_Marker.symbol = global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "size")
				{
					ct_Marker.size = global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerSize.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_Marker.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_Marker.extLst.Add(global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_Marker;
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0006C0D8 File Offset: 0x0006A2D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.symbol != null)
			{
				this.symbol.Write(sw, "symbol");
			}
			if (this.size != null)
			{
				this.size.Write(sw, "size");
			}
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
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

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06002B0E RID: 11022 RVA: 0x0006C1B0 File Offset: 0x0006A3B0
		// (set) Token: 0x06002B0F RID: 11023 RVA: 0x0006C1B8 File Offset: 0x0006A3B8
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle symbol
		{
			get
			{
				return this.symbolField;
			}
			set
			{
				this.symbolField = value;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x0006C1C1 File Offset: 0x0006A3C1
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0006C1C9 File Offset: 0x0006A3C9
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerSize size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0006C1D2 File Offset: 0x0006A3D2
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0006C1DA File Offset: 0x0006A3DA
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

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0006C1E3 File Offset: 0x0006A3E3
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x0006C1EB File Offset: 0x0006A3EB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x06002B16 RID: 11030 RVA: 0x0006C1F4 File Offset: 0x0006A3F4
		public global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle AddNewSymbol()
		{
			this.symbolField = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle();
			return this.symbolField;
		}

		// Token: 0x04001E8A RID: 7818
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle symbolField;

		// Token: 0x04001E8B RID: 7819
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerSize sizeField;

		// Token: 0x04001E8C RID: 7820
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;

		// Token: 0x04001E8D RID: 7821
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Dml.Chart.CT_Extension> extLstField;
	}
}
