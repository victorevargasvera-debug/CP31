using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000666 RID: 1638
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LimLow
	{
		// Token: 0x0600462E RID: 17966 RVA: 0x000A8760 File Offset: 0x000A6960
		public static global::NPOI.OpenXmlFormats.Shared.CT_LimLow Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_LimLow ct_LimLow = new global::NPOI.OpenXmlFormats.Shared.CT_LimLow();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "limLowPr")
				{
					ct_LimLow.limLowPr = global::NPOI.OpenXmlFormats.Shared.CT_LimLowPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_LimLow.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lim")
				{
					ct_LimLow.lim = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_LimLow;
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x000A8820 File Offset: 0x000A6A20
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.limLowPr != null)
			{
				this.limLowPr.Write(sw, "limLowPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			if (this.lim != null)
			{
				this.lim.Write(sw, "lim");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06004630 RID: 17968 RVA: 0x000A88A5 File Offset: 0x000A6AA5
		// (set) Token: 0x06004631 RID: 17969 RVA: 0x000A88AD File Offset: 0x000A6AAD
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_LimLowPr limLowPr
		{
			get
			{
				return this.limLowPrField;
			}
			set
			{
				this.limLowPrField = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06004632 RID: 17970 RVA: 0x000A88B6 File Offset: 0x000A6AB6
		// (set) Token: 0x06004633 RID: 17971 RVA: 0x000A88BE File Offset: 0x000A6ABE
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

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x000A88C7 File Offset: 0x000A6AC7
		// (set) Token: 0x06004635 RID: 17973 RVA: 0x000A88CF File Offset: 0x000A6ACF
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg lim
		{
			get
			{
				return this.limField;
			}
			set
			{
				this.limField = value;
			}
		}

		// Token: 0x04002C04 RID: 11268
		private global::NPOI.OpenXmlFormats.Shared.CT_LimLowPr limLowPrField;

		// Token: 0x04002C05 RID: 11269
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;

		// Token: 0x04002C06 RID: 11270
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg limField;
	}
}
