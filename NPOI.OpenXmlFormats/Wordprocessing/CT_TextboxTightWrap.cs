using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200013E RID: 318
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextboxTightWrap
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x0001E1AC File Offset: 0x0001C3AC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap ct_TextboxTightWrap = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextboxTightWrap();
			if (node.Attributes["w:val"] != null)
			{
				ct_TextboxTightWrap.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextboxTightWrap)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextboxTightWrap), node.Attributes["w:val"].Value);
			}
			return ct_TextboxTightWrap;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0001E208 File Offset: 0x0001C408
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0001E261 File Offset: 0x0001C461
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x0001E269 File Offset: 0x0001C469
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextboxTightWrap val
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

		// Token: 0x040007BA RID: 1978
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextboxTightWrap valField;
	}
}
