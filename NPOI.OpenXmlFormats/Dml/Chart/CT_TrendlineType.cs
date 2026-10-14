using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200043E RID: 1086
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrendlineType
	{
		// Token: 0x06002B9A RID: 11162 RVA: 0x0006D74C File Offset: 0x0006B94C
		public CT_TrendlineType()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TrendlineType.linear;
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x0006D75C File Offset: 0x0006B95C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineType ct_TrendlineType = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TrendlineType();
			if (node.Attributes["val"] != null)
			{
				ct_TrendlineType.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_TrendlineType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TrendlineType), node.Attributes["val"].Value);
			}
			return ct_TrendlineType;
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0006D7B8 File Offset: 0x0006B9B8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x0006D811 File Offset: 0x0006BA11
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x0006D819 File Offset: 0x0006BA19
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TrendlineType.linear)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_TrendlineType val
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

		// Token: 0x04001EDC RID: 7900
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_TrendlineType valField;
	}
}
