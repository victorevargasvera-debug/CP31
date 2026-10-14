using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000114 RID: 276
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Placeholder
	{
		// Token: 0x06000790 RID: 1936 RVA: 0x0001860C File Offset: 0x0001680C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder ct_Placeholder = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "docPart")
				{
					ct_Placeholder.docPart = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Placeholder;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001868C File Offset: 0x0001688C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.docPart != null)
			{
				this.docPart.Write(sw, "docPart");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x000186DF File Offset: 0x000168DF
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x000186E7 File Offset: 0x000168E7
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String docPart
		{
			get
			{
				return this.docPartField;
			}
			set
			{
				this.docPartField = value;
			}
		}

		// Token: 0x040006CA RID: 1738
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String docPartField;
	}
}
