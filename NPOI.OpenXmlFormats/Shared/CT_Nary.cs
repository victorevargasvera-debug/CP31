using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000670 RID: 1648
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Nary
	{
		// Token: 0x06004682 RID: 18050 RVA: 0x000A9518 File Offset: 0x000A7718
		public static global::NPOI.OpenXmlFormats.Shared.CT_Nary Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Nary ct_Nary = new global::NPOI.OpenXmlFormats.Shared.CT_Nary();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "naryPr")
				{
					ct_Nary.naryPr = global::NPOI.OpenXmlFormats.Shared.CT_NaryPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sub")
				{
					ct_Nary.sub = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sup")
				{
					ct_Nary.sup = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Nary.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Nary;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x000A9600 File Offset: 0x000A7800
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.naryPr != null)
			{
				this.naryPr.Write(sw, "naryPr");
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

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06004684 RID: 18052 RVA: 0x000A969E File Offset: 0x000A789E
		// (set) Token: 0x06004685 RID: 18053 RVA: 0x000A96A6 File Offset: 0x000A78A6
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_NaryPr naryPr
		{
			get
			{
				return this.naryPrField;
			}
			set
			{
				this.naryPrField = value;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06004686 RID: 18054 RVA: 0x000A96AF File Offset: 0x000A78AF
		// (set) Token: 0x06004687 RID: 18055 RVA: 0x000A96B7 File Offset: 0x000A78B7
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

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06004688 RID: 18056 RVA: 0x000A96C0 File Offset: 0x000A78C0
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x000A96C8 File Offset: 0x000A78C8
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

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x0600468A RID: 18058 RVA: 0x000A96D1 File Offset: 0x000A78D1
		// (set) Token: 0x0600468B RID: 18059 RVA: 0x000A96D9 File Offset: 0x000A78D9
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

		// Token: 0x04002C21 RID: 11297
		private global::NPOI.OpenXmlFormats.Shared.CT_NaryPr naryPrField;

		// Token: 0x04002C22 RID: 11298
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg subField;

		// Token: 0x04002C23 RID: 11299
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg supField;

		// Token: 0x04002C24 RID: 11300
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
