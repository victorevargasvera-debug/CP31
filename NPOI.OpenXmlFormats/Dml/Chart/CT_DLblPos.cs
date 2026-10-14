using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200043B RID: 1083
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DLblPos
	{
		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x0006D1EF File Offset: 0x0006B3EF
		// (set) Token: 0x06002B7B RID: 11131 RVA: 0x0006D1F7 File Offset: 0x0006B3F7
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_DLblPos val
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

		// Token: 0x06002B7C RID: 11132 RVA: 0x0006D200 File Offset: 0x0006B400
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos ct_DLblPos = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DLblPos();
			if (node.Attributes["val"] != null)
			{
				ct_DLblPos.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_DLblPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_DLblPos), node.Attributes["val"].Value);
			}
			return ct_DLblPos;
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0006D25C File Offset: 0x0006B45C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001EC5 RID: 7877
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_DLblPos valField;
	}
}
