using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000FE RID: 254
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Language
	{
		// Token: 0x060006F1 RID: 1777 RVA: 0x00015DE8 File Offset: 0x00013FE8
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:val"]),
				eastAsia = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:eastAsia"]),
				bidi = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["w:bidi"])
			};
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00015E50 File Offset: 0x00014050
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:eastAsia", this.eastAsia);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:bidi", this.bidi);
			sw.Write("/>");
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00015EAC File Offset: 0x000140AC
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00015EB4 File Offset: 0x000140B4
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string val
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

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00015EBD File Offset: 0x000140BD
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00015EC5 File Offset: 0x000140C5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string eastAsia
		{
			get
			{
				return this.eastAsiaField;
			}
			set
			{
				this.eastAsiaField = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00015ECE File Offset: 0x000140CE
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00015ED6 File Offset: 0x000140D6
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public string bidi
		{
			get
			{
				return this.bidiField;
			}
			set
			{
				this.bidiField = value;
			}
		}

		// Token: 0x04000633 RID: 1587
		private string valField;

		// Token: 0x04000634 RID: 1588
		private string eastAsiaField;

		// Token: 0x04000635 RID: 1589
		private string bidiField;
	}
}
