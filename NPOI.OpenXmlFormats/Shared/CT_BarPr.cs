using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000655 RID: 1621
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BarPr
	{
		// Token: 0x0600458D RID: 17805 RVA: 0x000A6C20 File Offset: 0x000A4E20
		public static global::NPOI.OpenXmlFormats.Shared.CT_BarPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_BarPr ct_BarPr = new global::NPOI.OpenXmlFormats.Shared.CT_BarPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "pos")
				{
					ct_BarPr.pos = global::NPOI.OpenXmlFormats.Shared.CT_TopBot.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_BarPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BarPr;
		}

		// Token: 0x0600458E RID: 17806 RVA: 0x000A6CC0 File Offset: 0x000A4EC0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.pos != null)
			{
				this.pos.Write(sw, "pos");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x0600458F RID: 17807 RVA: 0x000A6D2C File Offset: 0x000A4F2C
		// (set) Token: 0x06004590 RID: 17808 RVA: 0x000A6D34 File Offset: 0x000A4F34
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TopBot pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06004591 RID: 17809 RVA: 0x000A6D3D File Offset: 0x000A4F3D
		// (set) Token: 0x06004592 RID: 17810 RVA: 0x000A6D45 File Offset: 0x000A4F45
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

		// Token: 0x04002BCD RID: 11213
		private global::NPOI.OpenXmlFormats.Shared.CT_TopBot posField;

		// Token: 0x04002BCE RID: 11214
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
