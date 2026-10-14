using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000663 RID: 1635
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_GroupChrPr
	{
		// Token: 0x06004617 RID: 17943 RVA: 0x000A8380 File Offset: 0x000A6580
		public static global::NPOI.OpenXmlFormats.Shared.CT_GroupChrPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_GroupChrPr ct_GroupChrPr = new global::NPOI.OpenXmlFormats.Shared.CT_GroupChrPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "chr")
				{
					ct_GroupChrPr.chr = global::NPOI.OpenXmlFormats.Shared.CT_Char.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pos")
				{
					ct_GroupChrPr.pos = global::NPOI.OpenXmlFormats.Shared.CT_TopBot.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vertJc")
				{
					ct_GroupChrPr.vertJc = global::NPOI.OpenXmlFormats.Shared.CT_TopBot.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_GroupChrPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_GroupChrPr;
		}

		// Token: 0x06004618 RID: 17944 RVA: 0x000A8468 File Offset: 0x000A6668
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.chr != null)
			{
				this.chr.Write(sw, "chr");
			}
			if (this.pos != null)
			{
				this.pos.Write(sw, "pos");
			}
			if (this.vertJc != null)
			{
				this.vertJc.Write(sw, "vertJc");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x000A8506 File Offset: 0x000A6706
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x000A850E File Offset: 0x000A670E
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

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x000A8517 File Offset: 0x000A6717
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x000A851F File Offset: 0x000A671F
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TopBot pos
		{
			get
			{
				return this.posField;
			}
			set
			{
				this.posField = value;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x000A8528 File Offset: 0x000A6728
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x000A8530 File Offset: 0x000A6730
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TopBot vertJc
		{
			get
			{
				return this.vertJcField;
			}
			set
			{
				this.vertJcField = value;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x000A8539 File Offset: 0x000A6739
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x000A8541 File Offset: 0x000A6741
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x04002BFD RID: 11261
		private global::NPOI.OpenXmlFormats.Shared.CT_Char chrField;

		// Token: 0x04002BFE RID: 11262
		private global::NPOI.OpenXmlFormats.Shared.CT_TopBot posField;

		// Token: 0x04002BFF RID: 11263
		private global::NPOI.OpenXmlFormats.Shared.CT_TopBot vertJcField;

		// Token: 0x04002C00 RID: 11264
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
