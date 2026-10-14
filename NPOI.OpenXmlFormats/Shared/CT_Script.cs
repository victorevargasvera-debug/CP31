using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000646 RID: 1606
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Script
	{
		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06004523 RID: 17699 RVA: 0x000A40D6 File Offset: 0x000A22D6
		// (set) Token: 0x06004524 RID: 17700 RVA: 0x000A40DE File Offset: 0x000A22DE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_Script val
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

		// Token: 0x06004525 RID: 17701 RVA: 0x000A40E8 File Offset: 0x000A22E8
		public static global::NPOI.OpenXmlFormats.Shared.CT_Script Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Script ct_Script = new global::NPOI.OpenXmlFormats.Shared.CT_Script();
			if (node.Attributes["m:val"] != null)
			{
				ct_Script.val = (global::NPOI.OpenXmlFormats.Shared.ST_Script)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_Script), node.Attributes["m:val"].Value);
			}
			return ct_Script;
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x000A4144 File Offset: 0x000A2344
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x04002B56 RID: 11094
		private global::NPOI.OpenXmlFormats.Shared.ST_Script valField;
	}
}
