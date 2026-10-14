using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000658 RID: 1624
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Box
	{
		// Token: 0x060045A9 RID: 17833 RVA: 0x000A70E8 File Offset: 0x000A52E8
		public static global::NPOI.OpenXmlFormats.Shared.CT_Box Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Box ct_Box = new global::NPOI.OpenXmlFormats.Shared.CT_Box();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "boxPr")
				{
					ct_Box.boxPr = global::NPOI.OpenXmlFormats.Shared.CT_BoxPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Box.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Box;
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x000A7188 File Offset: 0x000A5388
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.boxPr != null)
			{
				this.boxPr.Write(sw, "boxPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x000A71F4 File Offset: 0x000A53F4
		public CT_Box()
		{
			this.eField = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			this.boxPrField = new global::NPOI.OpenXmlFormats.Shared.CT_BoxPr();
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x000A7212 File Offset: 0x000A5412
		// (set) Token: 0x060045AD RID: 17837 RVA: 0x000A721A File Offset: 0x000A541A
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_BoxPr boxPr
		{
			get
			{
				return this.boxPrField;
			}
			set
			{
				this.boxPrField = value;
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x060045AE RID: 17838 RVA: 0x000A7223 File Offset: 0x000A5423
		// (set) Token: 0x060045AF RID: 17839 RVA: 0x000A722B File Offset: 0x000A542B
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

		// Token: 0x04002BD7 RID: 11223
		private global::NPOI.OpenXmlFormats.Shared.CT_BoxPr boxPrField;

		// Token: 0x04002BD8 RID: 11224
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
