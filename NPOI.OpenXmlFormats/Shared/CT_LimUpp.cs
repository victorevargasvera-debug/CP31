using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000668 RID: 1640
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LimUpp
	{
		// Token: 0x0600463C RID: 17980 RVA: 0x000A89BC File Offset: 0x000A6BBC
		public static global::NPOI.OpenXmlFormats.Shared.CT_LimUpp Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_LimUpp ct_LimUpp = new global::NPOI.OpenXmlFormats.Shared.CT_LimUpp();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "limUppPr")
				{
					ct_LimUpp.limUppPr = global::NPOI.OpenXmlFormats.Shared.CT_LimUppPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_LimUpp.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lim")
				{
					ct_LimUpp.lim = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_LimUpp;
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x000A8A7C File Offset: 0x000A6C7C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.limUppPr != null)
			{
				this.limUppPr.Write(sw, "limUppPr");
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

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x0600463E RID: 17982 RVA: 0x000A8B01 File Offset: 0x000A6D01
		// (set) Token: 0x0600463F RID: 17983 RVA: 0x000A8B09 File Offset: 0x000A6D09
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_LimUppPr limUppPr
		{
			get
			{
				return this.limUppPrField;
			}
			set
			{
				this.limUppPrField = value;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x000A8B12 File Offset: 0x000A6D12
		// (set) Token: 0x06004641 RID: 17985 RVA: 0x000A8B1A File Offset: 0x000A6D1A
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

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06004642 RID: 17986 RVA: 0x000A8B23 File Offset: 0x000A6D23
		// (set) Token: 0x06004643 RID: 17987 RVA: 0x000A8B2B File Offset: 0x000A6D2B
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

		// Token: 0x04002C08 RID: 11272
		private global::NPOI.OpenXmlFormats.Shared.CT_LimUppPr limUppPrField;

		// Token: 0x04002C09 RID: 11273
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;

		// Token: 0x04002C0A RID: 11274
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg limField;
	}
}
