using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003E2 RID: 994
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OfPieType
	{
		// Token: 0x06002765 RID: 10085 RVA: 0x00062B95 File Offset: 0x00060D95
		public CT_OfPieType()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_OfPieType.pie;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00062BA4 File Offset: 0x00060DA4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieType ct_OfPieType = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_OfPieType();
			if (node.Attributes["val"] != null)
			{
				ct_OfPieType.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_OfPieType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_OfPieType), node.Attributes["val"].Value);
			}
			return ct_OfPieType;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00062C00 File Offset: 0x00060E00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x00062C59 File Offset: 0x00060E59
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00062C61 File Offset: 0x00060E61
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_OfPieType.pie)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_OfPieType val
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

		// Token: 0x04001D02 RID: 7426
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_OfPieType valField;
	}
}
