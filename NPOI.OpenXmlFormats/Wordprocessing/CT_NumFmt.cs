using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000AF RID: 175
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_NumFmt
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x0000DD64 File Offset: 0x0000BF64
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt ct_NumFmt = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_NumFmt();
			if (node.Attributes["w:val"] != null)
			{
				ct_NumFmt.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat), node.Attributes["w:val"].Value);
			}
			return ct_NumFmt;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0000DE08 File Offset: 0x0000C008
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x0000DE10 File Offset: 0x0000C010
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat val
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

		// Token: 0x04000429 RID: 1065
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_NumberFormat valField;
	}
}
