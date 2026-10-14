using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000190 RID: 400
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_CharacterSpacing
	{
		// Token: 0x06000E83 RID: 3715 RVA: 0x000302F8 File Offset: 0x0002E4F8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing ct_CharacterSpacing = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_CharacterSpacing();
			if (node.Attributes["w:val"] != null)
			{
				ct_CharacterSpacing.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_CharacterSpacing)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_CharacterSpacing), node.Attributes["w:val"].Value);
			}
			return ct_CharacterSpacing;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00030354 File Offset: 0x0002E554
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0003039C File Offset: 0x0002E59C
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x000303A4 File Offset: 0x0002E5A4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_CharacterSpacing val
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

		// Token: 0x04000C1F RID: 3103
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_CharacterSpacing valField;
	}
}
