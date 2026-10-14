using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000650 RID: 1616
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_AccPr
	{
		// Token: 0x06004568 RID: 17768 RVA: 0x000A55D0 File Offset: 0x000A37D0
		public static global::NPOI.OpenXmlFormats.Shared.CT_AccPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_AccPr ct_AccPr = new global::NPOI.OpenXmlFormats.Shared.CT_AccPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "chr")
				{
					ct_AccPr.chr = global::NPOI.OpenXmlFormats.Shared.CT_Char.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_AccPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_AccPr;
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x000A5670 File Offset: 0x000A3870
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.chr != null)
			{
				this.chr.Write(sw, "chr");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x000A56DC File Offset: 0x000A38DC
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x000A56E4 File Offset: 0x000A38E4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_Char chr
		{
			get
			{
				return this.chrField;
			}
			set
			{
				this.chrField = value;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x000A56ED File Offset: 0x000A38ED
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x000A56F5 File Offset: 0x000A38F5
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

		// Token: 0x04002B96 RID: 11158
		private global::NPOI.OpenXmlFormats.Shared.CT_Char chrField;

		// Token: 0x04002B97 RID: 11159
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
