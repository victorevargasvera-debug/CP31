using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000127 RID: 295
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_EdnPos
	{
		// Token: 0x06000804 RID: 2052 RVA: 0x0001B190 File Offset: 0x00019390
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos ct_EdnPos = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_EdnPos();
			if (node.Attributes["w:val"] != null)
			{
				ct_EdnPos.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdnPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdnPos), node.Attributes["w:val"].Value);
			}
			return ct_EdnPos;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0001B1EC File Offset: 0x000193EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0001B245 File Offset: 0x00019445
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0001B24D File Offset: 0x0001944D
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdnPos val
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

		// Token: 0x0400072F RID: 1839
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_EdnPos valField;
	}
}
