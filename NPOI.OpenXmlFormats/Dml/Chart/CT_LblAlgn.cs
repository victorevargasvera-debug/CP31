using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000425 RID: 1061
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LblAlgn
	{
		// Token: 0x06002A54 RID: 10836 RVA: 0x0006A664 File Offset: 0x00068864
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblAlgn Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblAlgn ct_LblAlgn = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LblAlgn();
			if (node.Attributes["val"] != null)
			{
				ct_LblAlgn.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_LblAlgn)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LblAlgn), node.Attributes["val"].Value);
			}
			return ct_LblAlgn;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x0006A6C0 File Offset: 0x000688C0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x0006A719 File Offset: 0x00068919
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x0006A721 File Offset: 0x00068921
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_LblAlgn val
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

		// Token: 0x04001E38 RID: 7736
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LblAlgn valField;
	}
}
