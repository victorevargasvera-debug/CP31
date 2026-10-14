using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000132 RID: 306
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RubyAlign
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x0001CFF0 File Offset: 0x0001B1F0
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyAlign Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyAlign ct_RubyAlign = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RubyAlign();
			if (node.Attributes["w:val"] != null)
			{
				ct_RubyAlign.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_RubyAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_RubyAlign), node.Attributes["w:val"].Value);
			}
			return ct_RubyAlign;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0001D04C File Offset: 0x0001B24C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0001D0A5 File Offset: 0x0001B2A5
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0001D0AD File Offset: 0x0001B2AD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_RubyAlign val
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

		// Token: 0x04000771 RID: 1905
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_RubyAlign valField;
	}
}
