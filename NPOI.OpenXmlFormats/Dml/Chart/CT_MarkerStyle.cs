using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000432 RID: 1074
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MarkerStyle
	{
		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x0006C207 File Offset: 0x0006A407
		// (set) Token: 0x06002B18 RID: 11032 RVA: 0x0006C20F File Offset: 0x0006A40F
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_MarkerStyle val
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

		// Token: 0x06002B19 RID: 11033 RVA: 0x0006C218 File Offset: 0x0006A418
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle ct_MarkerStyle = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_MarkerStyle();
			if (node.Attributes["val"] != null)
			{
				ct_MarkerStyle.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_MarkerStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_MarkerStyle), node.Attributes["val"].Value);
			}
			return ct_MarkerStyle;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x0006C274 File Offset: 0x0006A474
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001E8E RID: 7822
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_MarkerStyle valField;
	}
}
