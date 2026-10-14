using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200063C RID: 1596
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_XAlign
	{
		// Token: 0x0600450A RID: 17674 RVA: 0x000A3CF0 File Offset: 0x000A1EF0
		public static global::NPOI.OpenXmlFormats.Shared.CT_XAlign Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_XAlign ct_XAlign = new global::NPOI.OpenXmlFormats.Shared.CT_XAlign();
			if (node.Attributes["m:val"] != null)
			{
				ct_XAlign.val = (global::NPOI.OpenXmlFormats.Shared.ST_XAlign)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Shared.ST_XAlign), node.Attributes["m:val"].Value);
			}
			return ct_XAlign;
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x000A3D4C File Offset: 0x000A1F4C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "m:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x000A3DA5 File Offset: 0x000A1FA5
		// (set) Token: 0x0600450D RID: 17677 RVA: 0x000A3DAD File Offset: 0x000A1FAD
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Shared.ST_XAlign val
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

		// Token: 0x04002B3E RID: 11070
		private global::NPOI.OpenXmlFormats.Shared.ST_XAlign valField;
	}
}
