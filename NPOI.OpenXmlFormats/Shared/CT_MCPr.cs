using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000669 RID: 1641
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MCPr
	{
		// Token: 0x06004645 RID: 17989 RVA: 0x000A8B34 File Offset: 0x000A6D34
		public static global::NPOI.OpenXmlFormats.Shared.CT_MCPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_MCPr ct_MCPr = new global::NPOI.OpenXmlFormats.Shared.CT_MCPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "count")
				{
					ct_MCPr.count = global::NPOI.OpenXmlFormats.Shared.CT_Integer255.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "mcJc")
				{
					ct_MCPr.mcJc = global::NPOI.OpenXmlFormats.Shared.CT_XAlign.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_MCPr;
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x000A8BD4 File Offset: 0x000A6DD4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.count != null)
			{
				this.count.Write(sw, "count");
			}
			if (this.mcJc != null)
			{
				this.mcJc.Write(sw, "mcJc");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06004647 RID: 17991 RVA: 0x000A8C40 File Offset: 0x000A6E40
		// (set) Token: 0x06004648 RID: 17992 RVA: 0x000A8C48 File Offset: 0x000A6E48
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Integer255 count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06004649 RID: 17993 RVA: 0x000A8C51 File Offset: 0x000A6E51
		// (set) Token: 0x0600464A RID: 17994 RVA: 0x000A8C59 File Offset: 0x000A6E59
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_XAlign mcJc
		{
			get
			{
				return this.mcJcField;
			}
			set
			{
				this.mcJcField = value;
			}
		}

		// Token: 0x04002C0B RID: 11275
		private global::NPOI.OpenXmlFormats.Shared.CT_Integer255 countField;

		// Token: 0x04002C0C RID: 11276
		private global::NPOI.OpenXmlFormats.Shared.CT_XAlign mcJcField;
	}
}
