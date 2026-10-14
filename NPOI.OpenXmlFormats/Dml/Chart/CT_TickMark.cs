using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000419 RID: 1049
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TickMark
	{
		// Token: 0x060029F3 RID: 10739 RVA: 0x00069896 File Offset: 0x00067A96
		public CT_TickMark()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.cross;
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000698A8 File Offset: 0x00067AA8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark ct_TickMark = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TickMark();
			if (node.Attributes["val"] != null)
			{
				ct_TickMark.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark), node.Attributes["val"].Value);
			}
			return ct_TickMark;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00069904 File Offset: 0x00067B04
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x0006994C File Offset: 0x00067B4C
		// (set) Token: 0x060029F7 RID: 10743 RVA: 0x00069954 File Offset: 0x00067B54
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark.cross)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark val
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

		// Token: 0x04001E07 RID: 7687
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_TickMark valField;
	}
}
