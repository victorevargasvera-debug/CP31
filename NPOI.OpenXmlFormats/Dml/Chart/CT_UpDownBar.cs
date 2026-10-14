using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003EF RID: 1007
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_UpDownBar
	{
		// Token: 0x06002828 RID: 10280 RVA: 0x00065060 File Offset: 0x00063260
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar ct_UpDownBar = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_UpDownBar();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spPr")
				{
					ct_UpDownBar.spPr = global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_UpDownBar;
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000650E0 File Offset: 0x000632E0
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

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x00065133 File Offset: 0x00063333
		// (set) Token: 0x0600282B RID: 10283 RVA: 0x0006513B File Offset: 0x0006333B
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

		// Token: 0x04001D55 RID: 7509
		private global::NPOI.OpenXmlFormats.Dml.Chart.CT_ShapeProperties spPrField;
	}
}
