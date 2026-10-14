using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000CC RID: 204
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SectType
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x000100DC File Offset: 0x0000E2DC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType ct_SectType = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SectType();
			if (node.Attributes["w:val"] != null)
			{
				ct_SectType.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_SectionMark)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_SectionMark), node.Attributes["w:val"].Value);
			}
			return ct_SectType;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00010138 File Offset: 0x0000E338
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00010191 File Offset: 0x0000E391
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00010199 File Offset: 0x0000E399
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_SectionMark val
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000101A2 File Offset: 0x0000E3A2
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x000101AA File Offset: 0x0000E3AA
		[global::System.Xml.Serialization.XmlIgnore]
		public bool valSpecified
		{
			get
			{
				return this.valFieldSpecified;
			}
			set
			{
				this.valFieldSpecified = value;
			}
		}

		// Token: 0x040004E9 RID: 1257
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_SectionMark valField;

		// Token: 0x040004EA RID: 1258
		private bool valFieldSpecified;
	}
}
