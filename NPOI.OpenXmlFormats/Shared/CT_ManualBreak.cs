using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200064A RID: 1610
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ManualBreak
	{
		// Token: 0x0600452D RID: 17709 RVA: 0x000A4244 File Offset: 0x000A2444
		public static global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak
			{
				alnAt = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["m:alnAt"])
			};
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x000A426B File Offset: 0x000A246B
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:alnAt", this.alnAt);
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x000A42AB File Offset: 0x000A24AB
		// (set) Token: 0x06004530 RID: 17712 RVA: 0x000A42B3 File Offset: 0x000A24B3
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "integer")]
		public string alnAt
		{
			get
			{
				return this.alnAtField;
			}
			set
			{
				this.alnAtField = value;
			}
		}

		// Token: 0x04002B64 RID: 11108
		private string alnAtField;
	}
}
