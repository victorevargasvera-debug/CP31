using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000138 RID: 312
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Jc
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0001DF84 File Offset: 0x0001C184
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc ct_Jc = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc();
			if (node.Attributes["w:val"] != null)
			{
				ct_Jc.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc), node.Attributes["w:val"].Value);
			}
			return ct_Jc;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0001E028 File Offset: 0x0001C228
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x0001E030 File Offset: 0x0001C230
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc val
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

		// Token: 0x0400079F RID: 1951
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_Jc valField;
	}
}
