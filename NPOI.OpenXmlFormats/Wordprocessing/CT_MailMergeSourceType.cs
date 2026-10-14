using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000188 RID: 392
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MailMergeSourceType
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x0002F6A8 File Offset: 0x0002D8A8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeSourceType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeSourceType ct_MailMergeSourceType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeSourceType();
			if (node.Attributes["w:val"] != null)
			{
				ct_MailMergeSourceType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeSourceType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeSourceType), node.Attributes["w:val"].Value);
			}
			return ct_MailMergeSourceType;
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0002F704 File Offset: 0x0002D904
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0002F75D File Offset: 0x0002D95D
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x0002F765 File Offset: 0x0002D965
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeSourceType val
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

		// Token: 0x04000BE5 RID: 3045
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeSourceType valField;
	}
}
