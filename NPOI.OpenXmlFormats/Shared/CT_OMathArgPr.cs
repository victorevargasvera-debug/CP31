using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000653 RID: 1619
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OMathArgPr
	{
		// Token: 0x06004587 RID: 17799 RVA: 0x000A6B3C File Offset: 0x000A4D3C
		public static global::NPOI.OpenXmlFormats.Shared.CT_OMathArgPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OMathArgPr ct_OMathArgPr = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArgPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "argSz")
				{
					ct_OMathArgPr.argSz = global::NPOI.OpenXmlFormats.Shared.CT_Integer2.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_OMathArgPr;
		}

		// Token: 0x06004588 RID: 17800 RVA: 0x000A6BBC File Offset: 0x000A4DBC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.argSz != null)
			{
				this.argSz.Write(sw, "argSz");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x000A6C0F File Offset: 0x000A4E0F
		// (set) Token: 0x0600458B RID: 17803 RVA: 0x000A6C17 File Offset: 0x000A4E17
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Integer2 argSz
		{
			get
			{
				return this.argSzField;
			}
			set
			{
				this.argSzField = value;
			}
		}

		// Token: 0x04002B9E RID: 11166
		private global::NPOI.OpenXmlFormats.Shared.CT_Integer2 argSzField;
	}
}
