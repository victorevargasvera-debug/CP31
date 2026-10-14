using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000156 RID: 342
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextEffect
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x00021548 File Offset: 0x0001F748
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect ct_TextEffect = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect();
			if (node.Attributes["w:val"] != null)
			{
				ct_TextEffect.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextEffect)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextEffect), node.Attributes["w:val"].Value);
			}
			return ct_TextEffect;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000215A4 File Offset: 0x0001F7A4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000215EC File Offset: 0x0001F7EC
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000215F4 File Offset: 0x0001F7F4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextEffect val
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

		// Token: 0x040008B1 RID: 2225
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_TextEffect valField;
	}
}
