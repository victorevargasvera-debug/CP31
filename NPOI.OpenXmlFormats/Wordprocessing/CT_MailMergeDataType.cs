using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000183 RID: 387
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MailMergeDataType
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x0002F17C File Offset: 0x0002D37C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDataType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDataType ct_MailMergeDataType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_MailMergeDataType();
			if (node.Attributes["w:val"] != null)
			{
				ct_MailMergeDataType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDataType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDataType), node.Attributes["w:val"].Value);
			}
			return ct_MailMergeDataType;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0002F231 File Offset: 0x0002D431
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x0002F239 File Offset: 0x0002D439
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDataType val
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

		// Token: 0x04000BCF RID: 3023
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_MailMergeDataType valField;
	}
}
