using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x02000409 RID: 1033
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Double
	{
		// Token: 0x0600294C RID: 10572 RVA: 0x00067E62 File Offset: 0x00066062
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Double
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["val"])
			};
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00067E89 File Offset: 0x00066089
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val);
			sw.Write("/>");
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x00067EB8 File Offset: 0x000660B8
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x00067EC0 File Offset: 0x000660C0
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

		// Token: 0x04001DC9 RID: 7625
		private double valField;
	}
}
