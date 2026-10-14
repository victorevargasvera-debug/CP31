using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000679 RID: 1657
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SSubSupPr
	{
		// Token: 0x060046D1 RID: 18129 RVA: 0x000AA230 File Offset: 0x000A8430
		public static global::NPOI.OpenXmlFormats.Shared.CT_SSubSupPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_SSubSupPr ct_SSubSupPr = new global::NPOI.OpenXmlFormats.Shared.CT_SSubSupPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "alnScr")
				{
					ct_SSubSupPr.alnScr = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_SSubSupPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SSubSupPr;
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.alnScr != null)
			{
				this.alnScr.Write(sw, "alnScr");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x000AA33C File Offset: 0x000A853C
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x000AA344 File Offset: 0x000A8544
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff alnScr
		{
			get
			{
				return this.alnScrField;
			}
			set
			{
				this.alnScrField = value;
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x000AA34D File Offset: 0x000A854D
		// (set) Token: 0x060046D6 RID: 18134 RVA: 0x000AA355 File Offset: 0x000A8555
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

		// Token: 0x04002C3B RID: 11323
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff alnScrField;

		// Token: 0x04002C3C RID: 11324
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
