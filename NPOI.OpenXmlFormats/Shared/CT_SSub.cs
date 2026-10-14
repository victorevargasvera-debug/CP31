using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000678 RID: 1656
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SSub
	{
		// Token: 0x060046C8 RID: 18120 RVA: 0x000AA0B8 File Offset: 0x000A82B8
		public static global::NPOI.OpenXmlFormats.Shared.CT_SSub Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_SSub ct_SSub = new global::NPOI.OpenXmlFormats.Shared.CT_SSub();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "sSubPr")
				{
					ct_SSub.sSubPr = global::NPOI.OpenXmlFormats.Shared.CT_SSubPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_SSub.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sub")
				{
					ct_SSub.sub = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_SSub;
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x000AA178 File Offset: 0x000A8378
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.sSubPr != null)
			{
				this.sSubPr.Write(sw, "sSubPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			if (this.sub != null)
			{
				this.sub.Write(sw, "sub");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x000AA1FD File Offset: 0x000A83FD
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x000AA205 File Offset: 0x000A8405
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_SSubPr sSubPr
		{
			get
			{
				return this.sSubPrField;
			}
			set
			{
				this.sSubPrField = value;
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x000AA20E File Offset: 0x000A840E
		// (set) Token: 0x060046CD RID: 18125 RVA: 0x000AA216 File Offset: 0x000A8416
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

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x000AA21F File Offset: 0x000A841F
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x000AA227 File Offset: 0x000A8427
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

		// Token: 0x04002C38 RID: 11320
		private global::NPOI.OpenXmlFormats.Shared.CT_SSubPr sSubPrField;

		// Token: 0x04002C39 RID: 11321
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;

		// Token: 0x04002C3A RID: 11322
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg subField;
	}
}
