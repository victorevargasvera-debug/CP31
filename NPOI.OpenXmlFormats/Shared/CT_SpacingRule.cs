using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000639 RID: 1593
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SpacingRule
	{
		// Token: 0x060044FB RID: 17659 RVA: 0x000A3B79 File Offset: 0x000A1D79
		public static global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_SpacingRule
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["m:val"])
			};
		}

		// Token: 0x060044FC RID: 17660 RVA: 0x000A3BA0 File Offset: 0x000A1DA0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x060044FD RID: 17661 RVA: 0x000A3BE0 File Offset: 0x000A1DE0
		// (set) Token: 0x060044FE RID: 17662 RVA: 0x000A3BE8 File Offset: 0x000A1DE8
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

		// Token: 0x04002B3B RID: 11067
		private string valField;
	}
}
