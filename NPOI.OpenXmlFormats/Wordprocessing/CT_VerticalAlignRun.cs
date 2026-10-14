using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000140 RID: 320
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_VerticalAlignRun
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x0001E274 File Offset: 0x0001C474
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun ct_VerticalAlignRun = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun();
			if (node.Attributes["w:val"] != null)
			{
				ct_VerticalAlignRun.val = (global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalAlignRun)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalAlignRun), node.Attributes["w:val"].Value);
			}
			return ct_VerticalAlignRun;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:val", this.val.ToString());
			sw.Write(">");
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0001E329 File Offset: 0x0001C529
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x0001E331 File Offset: 0x0001C531
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalAlignRun val
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

		// Token: 0x040007C1 RID: 1985
		private global::NPOI.OpenXmlFormats.Wordprocessing.ST_VerticalAlignRun valField;
	}
}
