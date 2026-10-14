using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000672 RID: 1650
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Phant
	{
		// Token: 0x0600469C RID: 18076 RVA: 0x000A994C File Offset: 0x000A7B4C
		public static global::NPOI.OpenXmlFormats.Shared.CT_Phant Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_Phant ct_Phant = new global::NPOI.OpenXmlFormats.Shared.CT_Phant();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "phantPr")
				{
					ct_Phant.phantPr = global::NPOI.OpenXmlFormats.Shared.CT_PhantPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "e")
				{
					ct_Phant.e = global::NPOI.OpenXmlFormats.Shared.CT_OMathArg.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Phant;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x000A99EC File Offset: 0x000A7BEC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.phantPr != null)
			{
				this.phantPr.Write(sw, "phantPr");
			}
			if (this.e != null)
			{
				this.e.Write(sw, "e");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x0600469E RID: 18078 RVA: 0x000A9A58 File Offset: 0x000A7C58
		// (set) Token: 0x0600469F RID: 18079 RVA: 0x000A9A60 File Offset: 0x000A7C60
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_PhantPr phantPr
		{
			get
			{
				return this.phantPrField;
			}
			set
			{
				this.phantPrField = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x060046A0 RID: 18080 RVA: 0x000A9A69 File Offset: 0x000A7C69
		// (set) Token: 0x060046A1 RID: 18081 RVA: 0x000A9A71 File Offset: 0x000A7C71
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

		// Token: 0x04002C2B RID: 11307
		private global::NPOI.OpenXmlFormats.Shared.CT_PhantPr phantPrField;

		// Token: 0x04002C2C RID: 11308
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathArg eField;
	}
}
