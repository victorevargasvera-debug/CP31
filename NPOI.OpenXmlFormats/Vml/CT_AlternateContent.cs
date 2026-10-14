using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001CE RID: 462
	public class CT_AlternateContent
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x0003B218 File Offset: 0x00039418
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x0003B220 File Offset: 0x00039420
		public string InnerXml { get; set; }

		// Token: 0x060011B3 RID: 4531 RVA: 0x0003B22C File Offset: 0x0003942C
		public static global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent ct_AlternateContent = new global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent();
			if (string.IsNullOrEmpty(node.InnerXml))
			{
				return ct_AlternateContent;
			}
			ct_AlternateContent.InnerXml = node.InnerXml;
			return ct_AlternateContent;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0003B260 File Offset: 0x00039460
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<mc:{0} xmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"", nodeName));
			if (this.InnerXml == null)
			{
				sw.Write(string.Format("/>", nodeName));
				return;
			}
			sw.Write(">");
			sw.Write(this.InnerXml);
			sw.Write(string.Format("</mc:{0}>", nodeName));
		}
	}
}
