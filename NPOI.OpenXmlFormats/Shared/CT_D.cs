using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200065C RID: 1628
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_D
	{
		// Token: 0x060045DC RID: 17884 RVA: 0x000A7928 File Offset: 0x000A5B28
		public static global::NPOI.OpenXmlFormats.Shared.CT_D Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_D ct_D = new global::NPOI.OpenXmlFormats.Shared.CT_D();
			ct_D.e = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "dPr")
				{
					ct_D.dPr = global::NPOI.OpenXmlFormats.Shared.CT_DPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_D.e.Add(global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_D;
		}

		// Token: 0x060045DD RID: 17885 RVA: 0x000A79D8 File Offset: 0x000A5BD8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.dPr != null)
			{
				this.dPr.Write(sw, "dPr");
			}
			if (this.e != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Shared.CT_OMathArg ct_OMathArg in this.e)
				{
					ct_OMathArg.Write(sw, "e");
				}
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x060045DE RID: 17886 RVA: 0x000A7A7C File Offset: 0x000A5C7C
		// (set) Token: 0x060045DF RID: 17887 RVA: 0x000A7A84 File Offset: 0x000A5C84
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_DPr dPr
		{
			get
			{
				return this.dPrField;
			}
			set
			{
				this.dPrField = value;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x060045E0 RID: 17888 RVA: 0x000A7A8D File Offset: 0x000A5C8D
		// (set) Token: 0x060045E1 RID: 17889 RVA: 0x000A7A95 File Offset: 0x000A5C95
		[global::System.Xml.Serialization.XmlElement("e", Order = 1)]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> e
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

		// Token: 0x04002BEA RID: 11242
		private global::NPOI.OpenXmlFormats.Shared.CT_DPr dPrField;

		// Token: 0x04002BEB RID: 11243
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Shared.CT_OMathArg> eField;
	}
}
