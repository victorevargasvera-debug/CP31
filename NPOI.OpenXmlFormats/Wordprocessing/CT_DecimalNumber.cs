using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000045 RID: 69
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DecimalNumber
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0000408F File Offset: 0x0000228F
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000040B6 File Offset: 0x000022B6
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000040E6 File Offset: 0x000022E6
		// (set) Token: 0x06000259 RID: 601 RVA: 0x000040EE File Offset: 0x000022EE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string val
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

		// Token: 0x040001A9 RID: 425
		private string valField;
	}
}
