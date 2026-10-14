using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000648 RID: 1608
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Style
	{
		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x000A418C File Offset: 0x000A238C
		// (set) Token: 0x06004529 RID: 17705 RVA: 0x000A4194 File Offset: 0x000A2394
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_Style val
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

		// Token: 0x0600452A RID: 17706 RVA: 0x000A41A0 File Offset: 0x000A23A0
		public static global::NPOI.OpenXmlFormats.Shared.CT_Style Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Style ct_Style = new global::NPOI.OpenXmlFormats.Shared.CT_Style();
			if (node.Attributes["m:val"] != null)
			{
				ct_Style.val = (global::NPOI.OpenXmlFormats.Shared.ST_Style)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_Style), node.Attributes["m:val"].Value);
			}
			return ct_Style;
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x000A41FC File Offset: 0x000A23FC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x04002B5E RID: 11102
		private global::NPOI.OpenXmlFormats.Shared.ST_Style valField;
	}
}
