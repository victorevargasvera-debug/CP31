using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000673 RID: 1651
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RadPr
	{
		// Token: 0x060046A3 RID: 18083 RVA: 0x000A9A7C File Offset: 0x000A7C7C
		public static global::NPOI.OpenXmlFormats.Shared.CT_RadPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_RadPr ct_RadPr = new global::NPOI.OpenXmlFormats.Shared.CT_RadPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "degHide")
				{
					ct_RadPr.degHide = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_RadPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RadPr;
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x000A9B1C File Offset: 0x000A7D1C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.degHide != null)
			{
				this.degHide.Write(sw, "degHide");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x000A9B88 File Offset: 0x000A7D88
		// (set) Token: 0x060046A6 RID: 18086 RVA: 0x000A9B90 File Offset: 0x000A7D90
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff degHide
		{
			get
			{
				return this.degHideField;
			}
			set
			{
				this.degHideField = value;
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x000A9B99 File Offset: 0x000A7D99
		// (set) Token: 0x060046A8 RID: 18088 RVA: 0x000A9BA1 File Offset: 0x000A7DA1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x04002C2D RID: 11309
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff degHideField;

		// Token: 0x04002C2E RID: 11310
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
