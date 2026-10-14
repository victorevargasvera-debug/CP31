using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000424 RID: 1060
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AxisUnit
	{
		// Token: 0x06002A4F RID: 10831 RVA: 0x0006A5CC File Offset: 0x000687CC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit ct_AxisUnit = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxisUnit();
			if (node.Attributes["val"] != null)
			{
				ct_AxisUnit.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["val"]);
			}
			return ct_AxisUnit;
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0006A612 File Offset: 0x00068812
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x0006A652 File Offset: 0x00068852
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0006A65A File Offset: 0x0006885A
		[global::System.Xml.Serialization.XmlAttribute]
		public double val
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

		// Token: 0x04001E37 RID: 7735
		private double valField;
	}
}
