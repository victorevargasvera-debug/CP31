using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200065F RID: 1631
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FPr
	{
		// Token: 0x060045F9 RID: 17913 RVA: 0x000A7E7C File Offset: 0x000A607C
		public static global::NPOI.OpenXmlFormats.Shared.CT_FPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_FPr ct_FPr = new global::NPOI.OpenXmlFormats.Shared.CT_FPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "type")
				{
					ct_FPr.type = global::NPOI.OpenXmlFormats.Shared.CT_FType.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_FPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_FPr;
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x000A7F1C File Offset: 0x000A611C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.type != null)
			{
				this.type.Write(sw, "type");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x060045FB RID: 17915 RVA: 0x000A7F88 File Offset: 0x000A6188
		// (set) Token: 0x060045FC RID: 17916 RVA: 0x000A7F90 File Offset: 0x000A6190
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_FType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x060045FD RID: 17917 RVA: 0x000A7F99 File Offset: 0x000A6199
		// (set) Token: 0x060045FE RID: 17918 RVA: 0x000A7FA1 File Offset: 0x000A61A1
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPr
		{
			get
			{
				return this.ctrlPrField;
			}
			set
			{
				this.ctrlPrField = value;
			}
		}

		// Token: 0x04002BF4 RID: 11252
		private global::NPOI.OpenXmlFormats.Shared.CT_FType typeField;

		// Token: 0x04002BF5 RID: 11253
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
