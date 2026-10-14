using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D9 RID: 985
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RadarStyle
	{
		// Token: 0x06002705 RID: 9989 RVA: 0x000619AE File Offset: 0x0005FBAE
		public CT_RadarStyle()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_RadarStyle.standard;
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000619C0 File Offset: 0x0005FBC0
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarStyle ct_RadarStyle = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_RadarStyle();
			if (node.Attributes["val"] != null)
			{
				ct_RadarStyle.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_RadarStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_RadarStyle), node.Attributes["val"].Value);
			}
			return ct_RadarStyle;
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x00061A1C File Offset: 0x0005FC1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x00061A75 File Offset: 0x0005FC75
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x00061A7D File Offset: 0x0005FC7D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_RadarStyle.standard)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_RadarStyle val
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

		// Token: 0x04001CDC RID: 7388
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_RadarStyle valField;
	}
}
