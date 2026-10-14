using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001AF RID: 431
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Height
	{
		// Token: 0x0600105A RID: 4186 RVA: 0x00035344 File Offset: 0x00033544
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height ct_Height = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height();
			ct_Height.val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:val"]);
			if (node.Attributes["w:hRule"] != null)
			{
				ct_Height.hRule = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule), node.Attributes["w:hRule"].Value);
			}
			return ct_Height;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x000353BC File Offset: 0x000335BC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			if (this.hRule != global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule.auto)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:hRule", this.hRule.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600105C RID: 4188 RVA: 0x0003541F File Offset: 0x0003361F
		// (set) Token: 0x0600105D RID: 4189 RVA: 0x00035427 File Offset: 0x00033627
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong val
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

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600105E RID: 4190 RVA: 0x00035430 File Offset: 0x00033630
		// (set) Token: 0x0600105F RID: 4191 RVA: 0x00035438 File Offset: 0x00033638
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule hRule
		{
			get
			{
				return this.hRuleField;
			}
			set
			{
				this.hRuleField = value;
			}
		}

		// Token: 0x04000D09 RID: 3337
		private ulong valField;

		// Token: 0x04000D0A RID: 3338
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_HeightRule hRuleField;
	}
}
