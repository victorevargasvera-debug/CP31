using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000664 RID: 1636
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GroupChr
	{
		// Token: 0x06004622 RID: 17954 RVA: 0x000A854C File Offset: 0x000A674C
		public static global::NPOI.OpenXmlFormats.Shared.CT_GroupChr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_GroupChr ct_GroupChr = new global::NPOI.OpenXmlFormats.Shared.CT_GroupChr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "groupChrPr")
				{
					ct_GroupChr.groupChrPr = global::NPOI.OpenXmlFormats.Shared.CT_GroupChrPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_GroupChr.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupChr;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x000A85EC File Offset: 0x000A67EC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.groupChrPr != null)
			{
				this.groupChrPr.Write(sw, "groupChrPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06004624 RID: 17956 RVA: 0x000A8658 File Offset: 0x000A6858
		// (set) Token: 0x06004625 RID: 17957 RVA: 0x000A8660 File Offset: 0x000A6860
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_GroupChrPr groupChrPr
		{
			get
			{
				return this.groupChrPrField;
			}
			set
			{
				this.groupChrPrField = value;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06004626 RID: 17958 RVA: 0x000A8669 File Offset: 0x000A6869
		// (set) Token: 0x06004627 RID: 17959 RVA: 0x000A8671 File Offset: 0x000A6871
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

		// Token: 0x04002C01 RID: 11265
		private global::NPOI.OpenXmlFormats.Shared.CT_GroupChrPr groupChrPrField;

		// Token: 0x04002C02 RID: 11266
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
