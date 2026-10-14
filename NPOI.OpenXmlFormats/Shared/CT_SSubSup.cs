using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200067A RID: 1658
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SSubSup
	{
		// Token: 0x060046D8 RID: 18136 RVA: 0x000AA360 File Offset: 0x000A8560
		public static global::NPOI.OpenXmlFormats.Shared.CT_SSubSup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_SSubSup ct_SSubSup = new global::NPOI.OpenXmlFormats.Shared.CT_SSubSup();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sSubSupPr")
				{
					ct_SSubSup.sSubSupPr = global::NPOI.OpenXmlFormats.Shared.CT_SSubSupPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_SSubSup.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sub")
				{
					ct_SSubSup.sub = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sup")
				{
					ct_SSubSup.sup = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SSubSup;
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x000AA448 File Offset: 0x000A8648
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.sSubSupPr != null)
			{
				this.sSubSupPr.Write(sw, "sSubSupPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			if (this.sub != null)
			{
				this.sub.Write(sw, "sub");
			}
			if (this.sup != null)
			{
				this.sup.Write(sw, "sup");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x000AA4E6 File Offset: 0x000A86E6
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x000AA4EE File Offset: 0x000A86EE
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_SSubSupPr sSubSupPr
		{
			get
			{
				return this.sSubSupPrField;
			}
			set
			{
				this.sSubSupPrField = value;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x000AA4F7 File Offset: 0x000A86F7
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x000AA4FF File Offset: 0x000A86FF
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

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x000AA508 File Offset: 0x000A8708
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x000AA510 File Offset: 0x000A8710
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg sub
		{
			get
			{
				return this.subField;
			}
			set
			{
				this.subField = value;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x000AA519 File Offset: 0x000A8719
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x000AA521 File Offset: 0x000A8721
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg sup
		{
			get
			{
				return this.supField;
			}
			set
			{
				this.supField = value;
			}
		}

		// Token: 0x04002C3D RID: 11325
		private global::NPOI.OpenXmlFormats.Shared.CT_SSubSupPr sSubSupPrField;

		// Token: 0x04002C3E RID: 11326
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;

		// Token: 0x04002C3F RID: 11327
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg subField;

		// Token: 0x04002C40 RID: 11328
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg supField;
	}
}
