using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000637 RID: 1591
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Integer255
	{
		// Token: 0x060044F1 RID: 17649 RVA: 0x000A3A89 File Offset: 0x000A1C89
		public static global::NPOI.OpenXmlFormats.Shared.CT_Integer255 Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_Integer255
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["m:val"])
			};
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x000A3AB0 File Offset: 0x000A1CB0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x000A3AF0 File Offset: 0x000A1CF0
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x000A3AF8 File Offset: 0x000A1CF8
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

		// Token: 0x04002B39 RID: 11065
		private string valField;
	}
}
