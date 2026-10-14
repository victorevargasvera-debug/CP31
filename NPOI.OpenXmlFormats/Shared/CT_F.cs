using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000660 RID: 1632
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_F
	{
		// Token: 0x06004600 RID: 17920 RVA: 0x000A7FAC File Offset: 0x000A61AC
		public static global::NPOI.OpenXmlFormats.Shared.CT_F Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_F ct_F = new global::NPOI.OpenXmlFormats.Shared.CT_F();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "fPr")
				{
					ct_F.fPr = global::NPOI.OpenXmlFormats.Shared.CT_FPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "num")
				{
					ct_F.num = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "den")
				{
					ct_F.den = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_F;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x000A806C File Offset: 0x000A626C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.fPr != null)
			{
				this.fPr.Write(sw, "fPr");
			}
			if (this.num != null)
			{
				this.num.Write(sw, "num");
			}
			if (this.den != null)
			{
				this.den.Write(sw, "den");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06004602 RID: 17922 RVA: 0x000A80F1 File Offset: 0x000A62F1
		// (set) Token: 0x06004603 RID: 17923 RVA: 0x000A80F9 File Offset: 0x000A62F9
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_FPr fPr
		{
			get
			{
				return this.fPrField;
			}
			set
			{
				this.fPrField = value;
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x000A8102 File Offset: 0x000A6302
		// (set) Token: 0x06004605 RID: 17925 RVA: 0x000A810A File Offset: 0x000A630A
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg num
		{
			get
			{
				return this.numField;
			}
			set
			{
				this.numField = value;
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06004606 RID: 17926 RVA: 0x000A8113 File Offset: 0x000A6313
		// (set) Token: 0x06004607 RID: 17927 RVA: 0x000A811B File Offset: 0x000A631B
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg den
		{
			get
			{
				return this.denField;
			}
			set
			{
				this.denField = value;
			}
		}

		// Token: 0x04002BF6 RID: 11254
		private global::NPOI.OpenXmlFormats.Shared.CT_FPr fPrField;

		// Token: 0x04002BF7 RID: 11255
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg numField;

		// Token: 0x04002BF8 RID: 11256
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg denField;
	}
}
