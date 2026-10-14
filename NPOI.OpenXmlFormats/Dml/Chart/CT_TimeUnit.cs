using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000420 RID: 1056
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TimeUnit
	{
		// Token: 0x06002A07 RID: 10759 RVA: 0x00069B84 File Offset: 0x00067D84
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit ct_TimeUnit = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_TimeUnit();
			if (node.Attributes["val"] != null)
			{
				ct_TimeUnit.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_TimeUnit)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TimeUnit), node.Attributes["val"].Value);
			}
			return ct_TimeUnit;
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00069BE0 File Offset: 0x00067DE0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00069C39 File Offset: 0x00067E39
		public CT_TimeUnit()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_TimeUnit.days;
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x00069C48 File Offset: 0x00067E48
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00069C50 File Offset: 0x00067E50
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_TimeUnit.days)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_TimeUnit val
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

		// Token: 0x04001E19 RID: 7705
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_TimeUnit valField;
	}
}
