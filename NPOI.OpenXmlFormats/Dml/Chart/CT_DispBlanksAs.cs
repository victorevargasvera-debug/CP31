using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003FB RID: 1019
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DispBlanksAs
	{
		// Token: 0x060028D6 RID: 10454 RVA: 0x00066D96 File Offset: 0x00064F96
		public CT_DispBlanksAs()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_DispBlanksAs.zero;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00066DA8 File Offset: 0x00064FA8
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs ct_DispBlanksAs = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_DispBlanksAs();
			if (node.Attributes["val"] != null)
			{
				ct_DispBlanksAs.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_DispBlanksAs)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_DispBlanksAs), node.Attributes["val"].Value);
			}
			return ct_DispBlanksAs;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00066E04 File Offset: 0x00065004
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x00066E4C File Offset: 0x0006504C
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x00066E54 File Offset: 0x00065054
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_DispBlanksAs.zero)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_DispBlanksAs val
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

		// Token: 0x04001D9A RID: 7578
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_DispBlanksAs valField;
	}
}
