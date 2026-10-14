using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003D2 RID: 978
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BarDir
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x000608B2 File Offset: 0x0005EAB2
		public CT_BarDir()
		{
			this.valField = global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir.col;
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000608C4 File Offset: 0x0005EAC4
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir ct_BarDir = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_BarDir();
			if (node.Attributes["val"] != null)
			{
				ct_BarDir.val = (global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir), node.Attributes["val"].Value);
			}
			return ct_BarDir;
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00060920 File Offset: 0x0005EB20
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</c:{0}>", nodeName));
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x00060979 File Offset: 0x0005EB79
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00060981 File Offset: 0x0005EB81
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir.col)]
		public global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir val
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

		// Token: 0x04001CB0 RID: 7344
		private global::NPOI.OpenXmlFormats.Dml.Chart.ST_BarDir valField;
	}
}
