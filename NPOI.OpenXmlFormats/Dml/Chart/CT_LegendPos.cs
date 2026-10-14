using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000400 RID: 1024
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LegendPos
	{
		// Token: 0x060028F0 RID: 10480 RVA: 0x00067137 File Offset: 0x00065337
		public CT_LegendPos()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.r;
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x00067146 File Offset: 0x00065346
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x0006714E File Offset: 0x0006534E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.r)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos val
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

		// Token: 0x060028F3 RID: 10483 RVA: 0x00067158 File Offset: 0x00065358
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos ct_LegendPos = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LegendPos();
			if (node.Attributes["val"] != null)
			{
				ct_LegendPos.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos), node.Attributes["val"].Value);
			}
			return ct_LegendPos;
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000671B4 File Offset: 0x000653B4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			if (this.val != global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos.r)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			}
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x04001DA5 RID: 7589
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_LegendPos valField;
	}
}
