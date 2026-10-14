using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000412 RID: 1042
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ChartLines
	{
		// Token: 0x060029AF RID: 10671 RVA: 0x00068D74 File Offset: 0x00066F74
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines ct_ChartLines = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ChartLines();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spPr")
				{
					ct_ChartLines.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_ChartLines;
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00068DF4 File Offset: 0x00066FF4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			sw.Write(">");
			if (this.spPr != null)
			{
				this.spPr.Write(sw, "spPr");
			}
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x00068E47 File Offset: 0x00067047
		// (set) Token: 0x060029B2 RID: 10674 RVA: 0x00068E4F File Offset: 0x0006704F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
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

		// Token: 0x04001DF4 RID: 7668
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;
	}
}
