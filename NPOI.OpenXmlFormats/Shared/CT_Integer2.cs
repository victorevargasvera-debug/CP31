using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000638 RID: 1592
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Integer2
	{
		// Token: 0x060044F6 RID: 17654 RVA: 0x000A3B01 File Offset: 0x000A1D01
		public static global::NPOI.OpenXmlFormats.Shared.CT_Integer2 Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_Integer2
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["m:val"])
			};
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x000A3B28 File Offset: 0x000A1D28
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x000A3B68 File Offset: 0x000A1D68
		// (set) Token: 0x060044F9 RID: 17657 RVA: 0x000A3B70 File Offset: 0x000A1D70
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

		// Token: 0x04002B3A RID: 11066
		private string valField;
	}
}
