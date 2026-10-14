using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200013C RID: 316
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextAlignment
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x0001E0F4 File Offset: 0x0001C2F4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment ct_TextAlignment = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextAlignment();
			if (node.Attributes["w:val"] != null)
			{
				ct_TextAlignment.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextAlignment)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextAlignment), node.Attributes["w:val"].Value);
			}
			return ct_TextAlignment;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0001E150 File Offset: 0x0001C350
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x0001E198 File Offset: 0x0001C398
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x0001E1A0 File Offset: 0x0001C3A0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextAlignment val
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

		// Token: 0x040007B3 RID: 1971
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextAlignment valField;
	}
}
