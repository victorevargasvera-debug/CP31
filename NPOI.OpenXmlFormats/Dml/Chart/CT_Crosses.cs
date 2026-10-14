using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200041D RID: 1053
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Crosses
	{
		// Token: 0x060029FD RID: 10749 RVA: 0x00069A24 File Offset: 0x00067C24
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses ct_Crosses = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Crosses();
			if (node.Attributes["val"] != null)
			{
				ct_Crosses.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses), node.Attributes["val"].Value);
			}
			return ct_Crosses;
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00069A80 File Offset: 0x00067C80
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x00069AD9 File Offset: 0x00067CD9
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x00069AE1 File Offset: 0x00067CE1
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses val
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

		// Token: 0x04001E13 RID: 7699
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_Crosses valField;
	}
}
