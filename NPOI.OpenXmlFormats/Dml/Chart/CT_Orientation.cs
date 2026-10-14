using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200040E RID: 1038
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Orientation
	{
		// Token: 0x060029A5 RID: 10661 RVA: 0x00068BE2 File Offset: 0x00066DE2
		public CT_Orientation()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation.minMax;
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00068BF4 File Offset: 0x00066DF4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation ct_Orientation = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Orientation();
			if (node.Attributes["val"] != null)
			{
				ct_Orientation.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation), node.Attributes["val"].Value);
			}
			return ct_Orientation;
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00068C50 File Offset: 0x00066E50
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x00068C98 File Offset: 0x00066E98
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00068CA0 File Offset: 0x00066EA0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation val
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

		// Token: 0x04001DEA RID: 7658
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_Orientation valField;
	}
}
