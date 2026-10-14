using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200013A RID: 314
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextDirection
	{
		// Token: 0x060008A6 RID: 2214 RVA: 0x0001E03C File Offset: 0x0001C23C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection ct_TextDirection = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextDirection();
			if (node.Attributes["w:val"] != null)
			{
				ct_TextDirection.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextDirection)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextDirection), node.Attributes["w:val"].Value);
			}
			return ct_TextDirection;
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0001E098 File Offset: 0x0001C298
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0001E0E0 File Offset: 0x0001C2E0
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextDirection val
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

		// Token: 0x040007AB RID: 1963
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextDirection valField;
	}
}
