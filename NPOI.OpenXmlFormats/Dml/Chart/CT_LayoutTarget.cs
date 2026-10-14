using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000405 RID: 1029
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LayoutTarget
	{
		// Token: 0x06002942 RID: 10562 RVA: 0x00067CA4 File Offset: 0x00065EA4
		public CT_LayoutTarget()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.outer;
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00067CB4 File Offset: 0x00065EB4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget ct_LayoutTarget = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LayoutTarget();
			if (node.Attributes["val"] != null)
			{
				ct_LayoutTarget.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget), node.Attributes["val"].Value);
			}
			return ct_LayoutTarget;
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00067D10 File Offset: 0x00065F10
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			if (this.val != global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.outer)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			}
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x00067D72 File Offset: 0x00065F72
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x00067D7A File Offset: 0x00065F7A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget.outer)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget val
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

		// Token: 0x04001DC1 RID: 7617
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LayoutTarget valField;
	}
}
