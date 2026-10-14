using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200062C RID: 1580
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LimLoc
	{
		// Token: 0x060044CB RID: 17611 RVA: 0x000A35E8 File Offset: 0x000A17E8
		public static global::NPOI.OpenXmlFormats.Shared.CT_LimLoc Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_LimLoc ct_LimLoc = new global::NPOI.OpenXmlFormats.Shared.CT_LimLoc();
			if (node.Attributes["m:val"] != null)
			{
				ct_LimLoc.val = (global::NPOI.OpenXmlFormats.Shared.ST_LimLoc)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_LimLoc), node.Attributes["m:val"].Value);
			}
			return ct_LimLoc;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000A3644 File Offset: 0x000A1844
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x000A369D File Offset: 0x000A189D
		// (set) Token: 0x060044CE RID: 17614 RVA: 0x000A36A5 File Offset: 0x000A18A5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_LimLoc val
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

		// Token: 0x04002B19 RID: 11033
		private global::NPOI.OpenXmlFormats.Shared.ST_LimLoc valField;
	}
}
