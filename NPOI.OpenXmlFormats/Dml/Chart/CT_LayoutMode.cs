using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000407 RID: 1031
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LayoutMode
	{
		// Token: 0x06002947 RID: 10567 RVA: 0x00067D83 File Offset: 0x00065F83
		public CT_LayoutMode()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.factor;
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x00067D92 File Offset: 0x00065F92
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x00067D9A File Offset: 0x00065F9A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.factor)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode val
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

		// Token: 0x0600294A RID: 10570 RVA: 0x00067DA4 File Offset: 0x00065FA4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode ct_LayoutMode = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutMode();
			if (node.Attributes["val"] != null)
			{
				ct_LayoutMode.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode), node.Attributes["val"].Value);
			}
			return ct_LayoutMode;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00067E00 File Offset: 0x00066000
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			if (this.val != global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode.factor)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			}
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001DC5 RID: 7621
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutMode valField;
	}
}
