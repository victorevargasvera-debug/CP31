using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000410 RID: 1040
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AxPos
	{
		// Token: 0x060029AA RID: 10666 RVA: 0x00068CAC File Offset: 0x00066EAC
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos ct_AxPos = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_AxPos();
			if (node.Attributes["val"] != null)
			{
				ct_AxPos.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos), node.Attributes["val"].Value);
			}
			return ct_AxPos;
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x00068D08 File Offset: 0x00066F08
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x00068D61 File Offset: 0x00066F61
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x00068D69 File Offset: 0x00066F69
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos val
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

		// Token: 0x04001DEE RID: 7662
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_AxPos valField;
	}
}
