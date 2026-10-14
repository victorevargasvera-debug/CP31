using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200018B RID: 395
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MailMergeOdsoFMDFieldType
	{
		// Token: 0x06000E3A RID: 3642 RVA: 0x0002F9D8 File Offset: 0x0002DBD8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeOdsoFMDFieldType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeOdsoFMDFieldType ct_MailMergeOdsoFMDFieldType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeOdsoFMDFieldType();
			if (node.Attributes["w:val"] != null)
			{
				ct_MailMergeOdsoFMDFieldType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeOdsoFMDFieldType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeOdsoFMDFieldType), node.Attributes["w:val"].Value);
			}
			return ct_MailMergeOdsoFMDFieldType;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0002FA34 File Offset: 0x0002DC34
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0002FA8D File Offset: 0x0002DC8D
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0002FA95 File Offset: 0x0002DC95
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeOdsoFMDFieldType val
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

		// Token: 0x04000BF6 RID: 3062
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeOdsoFMDFieldType valField;
	}
}
