using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000181 RID: 385
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MailMergeDocType
	{
		// Token: 0x06000E04 RID: 3588 RVA: 0x0002F0B4 File Offset: 0x0002D2B4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDocType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDocType ct_MailMergeDocType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDocType();
			if (node.Attributes["w:val"] != null)
			{
				ct_MailMergeDocType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDocType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDocType), node.Attributes["w:val"].Value);
			}
			return ct_MailMergeDocType;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0002F110 File Offset: 0x0002D310
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0002F169 File Offset: 0x0002D369
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x0002F171 File Offset: 0x0002D371
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDocType val
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

		// Token: 0x04000BC7 RID: 3015
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDocType valField;
	}
}
