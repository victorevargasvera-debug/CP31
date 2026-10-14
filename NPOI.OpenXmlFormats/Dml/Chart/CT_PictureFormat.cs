using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000436 RID: 1078
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_PictureFormat
	{
		// Token: 0x06002B2E RID: 11054 RVA: 0x0006C56C File Offset: 0x0006A76C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureFormat Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureFormat ct_PictureFormat = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_PictureFormat();
			if (node.Attributes["val"] != null)
			{
				ct_PictureFormat.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_PictureFormat)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_PictureFormat), node.Attributes["val"].Value);
			}
			return ct_PictureFormat;
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0006C5C8 File Offset: 0x0006A7C8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x0006C621 File Offset: 0x0006A821
		// (set) Token: 0x06002B31 RID: 11057 RVA: 0x0006C629 File Offset: 0x0006A829
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_PictureFormat val
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

		// Token: 0x04001EA1 RID: 7841
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_PictureFormat valField;
	}
}
