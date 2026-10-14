using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200045A RID: 1114
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Grouping
	{
		// Token: 0x06002C56 RID: 11350 RVA: 0x0006F7E6 File Offset: 0x0006D9E6
		public CT_Grouping()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping.standard;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0006F7F8 File Offset: 0x0006D9F8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping ct_Grouping = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Grouping();
			if (node.Attributes["val"] != null)
			{
				ct_Grouping.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping), node.Attributes["val"].Value);
			}
			return ct_Grouping;
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0006F854 File Offset: 0x0006DA54
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x0006F8AD File Offset: 0x0006DAAD
		// (set) Token: 0x06002C5A RID: 11354 RVA: 0x0006F8B5 File Offset: 0x0006DAB5
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping.standard)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping val
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

		// Token: 0x04001F35 RID: 7989
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_Grouping valField;
	}
}
