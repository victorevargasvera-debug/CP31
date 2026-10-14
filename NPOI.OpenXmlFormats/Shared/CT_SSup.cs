using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200067C RID: 1660
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SSup
	{
		// Token: 0x060046E8 RID: 18152 RVA: 0x000AA610 File Offset: 0x000A8810
		public static global::NPOI.OpenXmlFormats.Shared.CT_SSup Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_SSup ct_SSup = new global::NPOI.OpenXmlFormats.Shared.CT_SSup();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sSupPr")
				{
					ct_SSup.sSupPr = global::NPOI.OpenXmlFormats.Shared.CT_SSupPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_SSup.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sup")
				{
					ct_SSup.sup = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SSup;
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x000AA6D0 File Offset: 0x000A88D0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.sSupPr != null)
			{
				this.sSupPr.Write(sw, "sSupPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			if (this.sup != null)
			{
				this.sup.Write(sw, "sup");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x000AA755 File Offset: 0x000A8955
		// (set) Token: 0x060046EB RID: 18155 RVA: 0x000AA75D File Offset: 0x000A895D
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_SSupPr sSupPr
		{
			get
			{
				return this.sSupPrField;
			}
			set
			{
				this.sSupPrField = value;
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x000AA766 File Offset: 0x000A8966
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x000AA76E File Offset: 0x000A896E
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

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x000AA777 File Offset: 0x000A8977
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x000AA77F File Offset: 0x000A897F
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x04002C42 RID: 11330
		private global::NPOI.OpenXmlFormats.Shared.CT_SSupPr sSupPrField;

		// Token: 0x04002C43 RID: 11331
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;

		// Token: 0x04002C44 RID: 11332
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg supField;
	}
}
