using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000177 RID: 375
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_View
	{
		// Token: 0x06000DB2 RID: 3506 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_View Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_View ct_View = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_View();
			if (node.Attributes["w:val"] != null)
			{
				ct_View.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_View)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_View), node.Attributes["w:val"].Value);
			}
			return ct_View;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0002E544 File Offset: 0x0002C744
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0002E59D File Offset: 0x0002C79D
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x0002E5A5 File Offset: 0x0002C7A5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_View val
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

		// Token: 0x04000B94 RID: 2964
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_View valField;
	}
}
