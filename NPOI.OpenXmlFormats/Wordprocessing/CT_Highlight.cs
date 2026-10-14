using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000152 RID: 338
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Highlight
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x000210D4 File Offset: 0x0001F2D4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight ct_Highlight = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight();
			if (node.Attributes["w:val"] != null)
			{
				ct_Highlight.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_HighlightColor)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HighlightColor), node.Attributes["w:val"].Value);
			}
			return ct_Highlight;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00021130 File Offset: 0x0001F330
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00021189 File Offset: 0x0001F389
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00021191 File Offset: 0x0001F391
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_HighlightColor val
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

		// Token: 0x04000891 RID: 2193
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_HighlightColor valField;
	}
}
