using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000192 RID: 402
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Kinsoku
	{
		// Token: 0x06000E88 RID: 3720 RVA: 0x000303B0 File Offset: 0x0002E5B0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Kinsoku
			{
				lang = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:lang"]),
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"])
			};
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00030400 File Offset: 0x0002E600
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:lang", this.lang);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0003045C File Offset: 0x0002E65C
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00030464 File Offset: 0x0002E664
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0003046D File Offset: 0x0002E66D
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00030475 File Offset: 0x0002E675
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

		// Token: 0x04000C24 RID: 3108
		private string langField;

		// Token: 0x04000C25 RID: 3109
		private string valField;
	}
}
