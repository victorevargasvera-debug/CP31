using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200067B RID: 1659
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SSupPr
	{
		// Token: 0x060046E3 RID: 18147 RVA: 0x000AA52C File Offset: 0x000A872C
		public static global::NPOI.OpenXmlFormats.Shared.CT_SSupPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_SSupPr ct_SSupPr = new global::NPOI.OpenXmlFormats.Shared.CT_SSupPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ctrlPr")
				{
					ct_SSupPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SSupPr;
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x000AA5AC File Offset: 0x000A87AC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x000AA5FF File Offset: 0x000A87FF
		// (set) Token: 0x060046E6 RID: 18150 RVA: 0x000AA607 File Offset: 0x000A8807
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPr
		{
			get
			{
				return this.ctrlPrField;
			}
			set
			{
				this.ctrlPrField = value;
			}
		}

		// Token: 0x04002C41 RID: 11329
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
