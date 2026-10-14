using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200065A RID: 1626
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BorderBox
	{
		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x000A7590 File Offset: 0x000A5790
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x000A7598 File Offset: 0x000A5798
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_BorderBoxPr borderBoxPr
		{
			get
			{
				return this.borderBoxPrField;
			}
			set
			{
				this.borderBoxPrField = value;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x060045C8 RID: 17864 RVA: 0x000A75A1 File Offset: 0x000A57A1
		// (set) Token: 0x060045C9 RID: 17865 RVA: 0x000A75A9 File Offset: 0x000A57A9
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg e
		{
			get
			{
				return this.eField;
			}
			set
			{
				this.eField = value;
			}
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x000A75B4 File Offset: 0x000A57B4
		public static global::NPOI.OpenXmlFormats.Shared.CT_BorderBox Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_BorderBox ct_BorderBox = new global::NPOI.OpenXmlFormats.Shared.CT_BorderBox();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "borderBoxPr")
				{
					ct_BorderBox.borderBoxPr = global::NPOI.OpenXmlFormats.Shared.CT_BorderBoxPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_BorderBox.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BorderBox;
		}

		// Token: 0x060045CB RID: 17867 RVA: 0x000A7654 File Offset: 0x000A5854
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.borderBoxPr != null)
			{
				this.borderBoxPr.Write(sw, "borderBoxPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x04002BE2 RID: 11234
		private global::NPOI.OpenXmlFormats.Shared.CT_BorderBoxPr borderBoxPrField;

		// Token: 0x04002BE3 RID: 11235
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
