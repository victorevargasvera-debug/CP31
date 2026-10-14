using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200063A RID: 1594
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_UnSignedInteger
	{
		// Token: 0x06004500 RID: 17664 RVA: 0x000A3BF1 File Offset: 0x000A1DF1
		public static global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_UnSignedInteger
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["m:val"])
			};
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x000A3C18 File Offset: 0x000A1E18
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val, false);
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06004502 RID: 17666 RVA: 0x000A3C64 File Offset: 0x000A1E64
		// (set) Token: 0x06004503 RID: 17667 RVA: 0x000A3C6C File Offset: 0x000A1E6C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public uint val
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

		// Token: 0x04002B3C RID: 11068
		private uint valField;
	}
}
