using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000676 RID: 1654
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SPre
	{
		// Token: 0x060046B8 RID: 18104 RVA: 0x000A9E08 File Offset: 0x000A8008
		public static global::NPOI.OpenXmlFormats.Shared.CT_SPre Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_SPre ct_SPre = new global::NPOI.OpenXmlFormats.Shared.CT_SPre();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sPrePr")
				{
					ct_SPre.sPrePr = global::NPOI.OpenXmlFormats.Shared.CT_SPrePr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sub")
				{
					ct_SPre.sub = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sup")
				{
					ct_SPre.sup = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_SPre.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SPre;
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x000A9EF0 File Offset: 0x000A80F0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.sPrePr != null)
			{
				this.sPrePr.Write(sw, "sPrePr");
			}
			if (this.sub != null)
			{
				this.sub.Write(sw, "sub");
			}
			if (this.sup != null)
			{
				this.sup.Write(sw, "sup");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x000A9F8E File Offset: 0x000A818E
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x000A9F96 File Offset: 0x000A8196
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_SPrePr sPrePr
		{
			get
			{
				return this.sPrePrField;
			}
			set
			{
				this.sPrePrField = value;
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x000A9F9F File Offset: 0x000A819F
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x000A9FA7 File Offset: 0x000A81A7
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
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

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x000A9FB0 File Offset: 0x000A81B0
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x000A9FB8 File Offset: 0x000A81B8
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

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x000A9FC1 File Offset: 0x000A81C1
		// (set) Token: 0x060046C1 RID: 18113 RVA: 0x000A9FC9 File Offset: 0x000A81C9
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x04002C33 RID: 11315
		private global::NPOI.OpenXmlFormats.Shared.CT_SPrePr sPrePrField;

		// Token: 0x04002C34 RID: 11316
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg subField;

		// Token: 0x04002C35 RID: 11317
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg supField;

		// Token: 0x04002C36 RID: 11318
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
