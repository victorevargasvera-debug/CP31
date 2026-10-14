using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000B9 RID: 185
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LevelSuffix
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelSuffix Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelSuffix ct_LevelSuffix = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_LevelSuffix();
			if (node.Attributes["w:val"] != null)
			{
				ct_LevelSuffix.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_LevelSuffix)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_LevelSuffix), node.Attributes["w:val"].Value);
			}
			return ct_LevelSuffix;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000ED50 File Offset: 0x0000CF50
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write("/>");
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0000ED98 File Offset: 0x0000CF98
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_LevelSuffix val
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

		// Token: 0x0400048F RID: 1167
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_LevelSuffix valField;
	}
}
