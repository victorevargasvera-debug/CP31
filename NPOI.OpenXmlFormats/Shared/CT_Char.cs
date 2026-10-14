using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200063B RID: 1595
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Char
	{
		// Token: 0x06004505 RID: 17669 RVA: 0x000A3C75 File Offset: 0x000A1E75
		public static global::NPOI.OpenXmlFormats.Shared.CT_Char Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Shared.CT_Char
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["m:val"])
			};
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x000A3C9C File Offset: 0x000A1E9C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x000A3CDC File Offset: 0x000A1EDC
		// (set) Token: 0x06004508 RID: 17672 RVA: 0x000A3CE4 File Offset: 0x000A1EE4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
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

		// Token: 0x04002B3D RID: 11069
		private string valField;
	}
}
