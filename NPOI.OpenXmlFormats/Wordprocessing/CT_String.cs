using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200004C RID: 76
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_String
	{
		// Token: 0x06000277 RID: 631 RVA: 0x00004333 File Offset: 0x00002533
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_String Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000435A File Offset: 0x0000255A
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write("/>");
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00004389 File Offset: 0x00002589
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00004391 File Offset: 0x00002591
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

		// Token: 0x040001B0 RID: 432
		private string valField;
	}
}
