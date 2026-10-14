using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000651 RID: 1617
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Acc
	{
		// Token: 0x0600456F RID: 17775 RVA: 0x000A5700 File Offset: 0x000A3900
		public static global::NPOI.OpenXmlFormats.Shared.CT_Acc Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Acc ct_Acc = new global::NPOI.OpenXmlFormats.Shared.CT_Acc();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "accPr")
				{
					ct_Acc.accPr = global::NPOI.OpenXmlFormats.Shared.CT_AccPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Acc.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Acc;
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x000A57A0 File Offset: 0x000A39A0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.accPr != null)
			{
				this.accPr.Write(sw, "accPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06004571 RID: 17777 RVA: 0x000A580C File Offset: 0x000A3A0C
		// (set) Token: 0x06004572 RID: 17778 RVA: 0x000A5814 File Offset: 0x000A3A14
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_AccPr accPr
		{
			get
			{
				return this.accPrField;
			}
			set
			{
				this.accPrField = value;
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06004573 RID: 17779 RVA: 0x000A581D File Offset: 0x000A3A1D
		// (set) Token: 0x06004574 RID: 17780 RVA: 0x000A5825 File Offset: 0x000A3A25
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

		// Token: 0x04002B98 RID: 11160
		private global::NPOI.OpenXmlFormats.Shared.CT_AccPr accPrField;

		// Token: 0x04002B99 RID: 11161
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
