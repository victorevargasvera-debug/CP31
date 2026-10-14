using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200017E RID: 382
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_DocType
	{
		// Token: 0x06000DDC RID: 3548 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocType ct_DocType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_DocType();
			if (node.Attributes["w:val"] != null)
			{
				ct_DocType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocType), node.Attributes["w:val"].Value);
			}
			return ct_DocType;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x0002EB21 File Offset: 0x0002CD21
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x0002EB29 File Offset: 0x0002CD29
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocType val
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

		// Token: 0x04000BB2 RID: 2994
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_DocType valField;
	}
}
