using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E6 RID: 998
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ScatterStyle
	{
		// Token: 0x060027A5 RID: 10149 RVA: 0x0006378C File Offset: 0x0006198C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle ct_ScatterStyle = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_ScatterStyle();
			if (node.Attributes["val"] != null)
			{
				ct_ScatterStyle.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle), node.Attributes["val"].Value);
			}
			return ct_ScatterStyle;
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000637E8 File Offset: 0x000619E8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00063841 File Offset: 0x00061A41
		public CT_ScatterStyle()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle.marker;
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x00063850 File Offset: 0x00061A50
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x00063858 File Offset: 0x00061A58
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle.marker)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle val
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

		// Token: 0x04001D1E RID: 7454
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_ScatterStyle valField;
	}
}
