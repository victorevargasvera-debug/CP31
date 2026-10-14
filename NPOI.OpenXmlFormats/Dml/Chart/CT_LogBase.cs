using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x0200040D RID: 1037
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LogBase
	{
		// Token: 0x060029A0 RID: 10656 RVA: 0x00068B5C File Offset: 0x00066D5C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase ct_LogBase = new global::NPOI.OpenXmlFormats.Dml.Chart.CT_LogBase();
			if (node.Attributes["val"] != null)
			{
				ct_LogBase.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["val"]);
			}
			return ct_LogBase;
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00068BA2 File Offset: 0x00066DA2
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write("/>");
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x00068BD1 File Offset: 0x00066DD1
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x00068BD9 File Offset: 0x00066DD9
		[global::System.Xml.Serialization.XmlAttribute]
		public double val
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

		// Token: 0x04001DE9 RID: 7657
		private double valField;
	}
}
