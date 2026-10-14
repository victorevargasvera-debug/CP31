using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200066A RID: 1642
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_MC
	{
		// Token: 0x0600464C RID: 17996 RVA: 0x000A8C64 File Offset: 0x000A6E64
		public static global::NPOI.OpenXmlFormats.Shared.CT_MC Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_MC ct_MC = new global::NPOI.OpenXmlFormats.Shared.CT_MC();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mcPr")
				{
					ct_MC.mcPr = global::NPOI.OpenXmlFormats.Shared.CT_MCPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_MC;
		}

		// Token: 0x0600464D RID: 17997 RVA: 0x000A8CE4 File Offset: 0x000A6EE4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.mcPr != null)
			{
				this.mcPr.Write(sw, "mcPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x0600464E RID: 17998 RVA: 0x000A8D37 File Offset: 0x000A6F37
		// (set) Token: 0x0600464F RID: 17999 RVA: 0x000A8D3F File Offset: 0x000A6F3F
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_MCPr mcPr
		{
			get
			{
				return this.mcPrField;
			}
			set
			{
				this.mcPrField = value;
			}
		}

		// Token: 0x04002C0D RID: 11277
		private global::NPOI.OpenXmlFormats.Shared.CT_MCPr mcPrField;
	}
}
