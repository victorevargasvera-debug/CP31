using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000451 RID: 1105
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BandFmt
	{
		// Token: 0x06002C29 RID: 11305 RVA: 0x0006EFC8 File Offset: 0x0006D1C8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt ct_BandFmt = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BandFmt();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "idx")
				{
					ct_BandFmt.idx = global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spPr")
				{
					ct_BandFmt.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BandFmt;
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x0006F068 File Offset: 0x0006D268
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
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x0006F0D4 File Offset: 0x0006D2D4
		// (set) Token: 0x06002C2C RID: 11308 RVA: 0x0006F0DC File Offset: 0x0006D2DC
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

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x0006F0E5 File Offset: 0x0006D2E5
		// (set) Token: 0x06002C2E RID: 11310 RVA: 0x0006F0ED File Offset: 0x0006D2ED
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

		// Token: 0x04001F1C RID: 7964
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_UnsignedInt idxField;

		// Token: 0x04001F1D RID: 7965
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;
	}
}
