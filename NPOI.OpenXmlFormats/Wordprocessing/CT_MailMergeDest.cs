using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000185 RID: 389
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MailMergeDest
	{
		// Token: 0x06000E0E RID: 3598 RVA: 0x0002F244 File Offset: 0x0002D444
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDest Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDest ct_MailMergeDest = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDest();
			if (node.Attributes["w:val"] != null)
			{
				ct_MailMergeDest.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDest)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDest), node.Attributes["w:val"].Value);
			}
			return ct_MailMergeDest;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0002F2F9 File Offset: 0x0002D4F9
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0002F301 File Offset: 0x0002D501
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDest val
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

		// Token: 0x04000BD7 RID: 3031
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDest valField;
	}
}
