using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000674 RID: 1652
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Rad
	{
		// Token: 0x060046AA RID: 18090 RVA: 0x000A9BAC File Offset: 0x000A7DAC
		public static global::NPOI.OpenXmlFormats.Shared.CT_Rad Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Rad ct_Rad = new global::NPOI.OpenXmlFormats.Shared.CT_Rad();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "radPr")
				{
					ct_Rad.radPr = global::NPOI.OpenXmlFormats.Shared.CT_RadPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "deg")
				{
					ct_Rad.deg = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Rad.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Rad;
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x000A9C6C File Offset: 0x000A7E6C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.radPr != null)
			{
				this.radPr.Write(sw, "radPr");
			}
			if (this.deg != null)
			{
				this.deg.Write(sw, "deg");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x000A9CF1 File Offset: 0x000A7EF1
		// (set) Token: 0x060046AD RID: 18093 RVA: 0x000A9CF9 File Offset: 0x000A7EF9
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_RadPr radPr
		{
			get
			{
				return this.radPrField;
			}
			set
			{
				this.radPrField = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x000A9D02 File Offset: 0x000A7F02
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x000A9D0A File Offset: 0x000A7F0A
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathArg deg
		{
			get
			{
				return this.degField;
			}
			set
			{
				this.degField = value;
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x000A9D13 File Offset: 0x000A7F13
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x000A9D1B File Offset: 0x000A7F1B
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x04002C2F RID: 11311
		private global::NPOI.OpenXmlFormats.Shared.CT_RadPr radPrField;

		// Token: 0x04002C30 RID: 11312
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg degField;

		// Token: 0x04002C31 RID: 11313
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
