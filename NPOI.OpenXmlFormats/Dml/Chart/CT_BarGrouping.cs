using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D4 RID: 980
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BarGrouping
	{
		// Token: 0x060026AE RID: 9902 RVA: 0x0006098A File Offset: 0x0005EB8A
		public CT_BarGrouping()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping.clustered;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0006099C File Offset: 0x0005EB9C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping ct_BarGrouping = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarGrouping();
			if (node.Attributes["val"] != null)
			{
				ct_BarGrouping.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping), node.Attributes["val"].Value);
			}
			return ct_BarGrouping;
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x000609F8 File Offset: 0x0005EBF8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x00060A51 File Offset: 0x0005EC51
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x00060A59 File Offset: 0x0005EC59
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping.clustered)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping val
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

		// Token: 0x04001CB4 RID: 7348
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarGrouping valField;
	}
}
