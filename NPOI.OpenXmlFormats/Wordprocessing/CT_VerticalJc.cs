using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200014C RID: 332
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_VerticalJc
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x00020C3C File Offset: 0x0001EE3C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc ct_VerticalJc = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalJc();
			if (node.Attributes["w:val"] != null)
			{
				ct_VerticalJc.val = new global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc?((global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc), node.Attributes["w:val"].Value));
			}
			return ct_VerticalJc;
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00020C9C File Offset: 0x0001EE9C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			if (this.val != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.Value.ToString());
			}
			sw.Write("/>");
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00020CFC File Offset: 0x0001EEFC
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x00020D04 File Offset: 0x0001EF04
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc? val
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

		// Token: 0x04000852 RID: 2130
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalJc? valField;
	}
}
