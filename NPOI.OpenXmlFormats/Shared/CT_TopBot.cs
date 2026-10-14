using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000644 RID: 1604
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TopBot
	{
		// Token: 0x0600451E RID: 17694 RVA: 0x000A4010 File Offset: 0x000A2210
		public static global::NPOI.OpenXmlFormats.Shared.CT_TopBot Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_TopBot ct_TopBot = new global::NPOI.OpenXmlFormats.Shared.CT_TopBot();
			if (node.Attributes["m:val"] != null)
			{
				ct_TopBot.val = (global::NPOI.OpenXmlFormats.Shared.ST_TopBot)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_TopBot), node.Attributes["m:val"].Value);
			}
			return ct_TopBot;
		}

		// Token: 0x0600451F RID: 17695 RVA: 0x000A406C File Offset: 0x000A226C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x000A40C5 File Offset: 0x000A22C5
		// (set) Token: 0x06004521 RID: 17697 RVA: 0x000A40CD File Offset: 0x000A22CD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_TopBot val
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

		// Token: 0x04002B52 RID: 11090
		private global::NPOI.OpenXmlFormats.Shared.ST_TopBot valField;
	}
}
