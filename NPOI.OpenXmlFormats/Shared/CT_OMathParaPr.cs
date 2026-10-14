using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200067D RID: 1661
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OMathParaPr
	{
		// Token: 0x060046F1 RID: 18161 RVA: 0x000AA788 File Offset: 0x000A8988
		public static global::NPOI.OpenXmlFormats.Shared.CT_OMathParaPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_OMathParaPr ct_OMathParaPr = new global::NPOI.OpenXmlFormats.Shared.CT_OMathParaPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "jc")
				{
					ct_OMathParaPr.jc = global::NPOI.OpenXmlFormats.Shared.CT_OMathJc.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_OMathParaPr;
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x000AA808 File Offset: 0x000A8A08
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.jc != null)
			{
				this.jc.Write(sw, "jc");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x000AA85B File Offset: 0x000A8A5B
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x000AA863 File Offset: 0x000A8A63
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathJc jc
		{
			get
			{
				return this.jcField;
			}
			set
			{
				this.jcField = value;
			}
		}

		// Token: 0x04002C45 RID: 11333
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathJc jcField;
	}
}
