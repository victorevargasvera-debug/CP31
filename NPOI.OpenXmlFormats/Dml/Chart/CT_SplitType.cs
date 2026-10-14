using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000454 RID: 1108
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SplitType
	{
		// Token: 0x06002C42 RID: 11330 RVA: 0x0006F4E3 File Offset: 0x0006D6E3
		public CT_SplitType()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_SplitType.auto;
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0006F4F4 File Offset: 0x0006D6F4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_SplitType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_SplitType ct_SplitType = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_SplitType();
			if (node.Attributes["val"] != null)
			{
				ct_SplitType.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_SplitType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_SplitType), node.Attributes["val"].Value);
			}
			return ct_SplitType;
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x0006F550 File Offset: 0x0006D750
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x0006F5A9 File Offset: 0x0006D7A9
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x0006F5B1 File Offset: 0x0006D7B1
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_SplitType.auto)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_SplitType val
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

		// Token: 0x04001F24 RID: 7972
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_SplitType valField;
	}
}
