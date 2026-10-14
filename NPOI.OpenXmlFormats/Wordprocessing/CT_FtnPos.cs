using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200011D RID: 285
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FtnPos
	{
		// Token: 0x060007C6 RID: 1990 RVA: 0x000199A4 File Offset: 0x00017BA4
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos ct_FtnPos = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnPos();
			if (node.Attributes["w:val"] != null)
			{
				ct_FtnPos.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnPos)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnPos), node.Attributes["w:val"].Value);
			}
			return ct_FtnPos;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00019A00 File Offset: 0x00017C00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00019A59 File Offset: 0x00017C59
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00019A61 File Offset: 0x00017C61
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnPos val
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

		// Token: 0x040006F8 RID: 1784
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_FtnPos valField;
	}
}
