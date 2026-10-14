using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000657 RID: 1623
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BoxPr
	{
		// Token: 0x0600459B RID: 17819 RVA: 0x000A6E80 File Offset: 0x000A5080
		public static global::NPOI.OpenXmlFormats.Shared.CT_BoxPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_BoxPr ct_BoxPr = new global::NPOI.OpenXmlFormats.Shared.CT_BoxPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "opEmu")
				{
					ct_BoxPr.opEmu = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noBreak")
				{
					ct_BoxPr.noBreak = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "diff")
				{
					ct_BoxPr.diff = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "brk")
				{
					ct_BoxPr.brk = global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "aln")
				{
					ct_BoxPr.aln = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_BoxPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BoxPr;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x000A6FB0 File Offset: 0x000A51B0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.opEmu != null)
			{
				this.opEmu.Write(sw, "opEmu");
			}
			if (this.noBreak != null)
			{
				this.noBreak.Write(sw, "noBreak");
			}
			if (this.diff != null)
			{
				this.diff.Write(sw, "diff");
			}
			if (this.brk != null)
			{
				this.brk.Write(sw, "brk");
			}
			if (this.aln != null)
			{
				this.aln.Write(sw, "aln");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x000A7080 File Offset: 0x000A5280
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x000A7088 File Offset: 0x000A5288
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff opEmu
		{
			get
			{
				return this.opEmuField;
			}
			set
			{
				this.opEmuField = value;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x000A7091 File Offset: 0x000A5291
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x000A7099 File Offset: 0x000A5299
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff noBreak
		{
			get
			{
				return this.noBreakField;
			}
			set
			{
				this.noBreakField = value;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x000A70A2 File Offset: 0x000A52A2
		// (set) Token: 0x060045A2 RID: 17826 RVA: 0x000A70AA File Offset: 0x000A52AA
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff diff
		{
			get
			{
				return this.diffField;
			}
			set
			{
				this.diffField = value;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x000A70B3 File Offset: 0x000A52B3
		// (set) Token: 0x060045A4 RID: 17828 RVA: 0x000A70BB File Offset: 0x000A52BB
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak brk
		{
			get
			{
				return this.brkField;
			}
			set
			{
				this.brkField = value;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x000A70C4 File Offset: 0x000A52C4
		// (set) Token: 0x060045A6 RID: 17830 RVA: 0x000A70CC File Offset: 0x000A52CC
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff aln
		{
			get
			{
				return this.alnField;
			}
			set
			{
				this.alnField = value;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x060045A7 RID: 17831 RVA: 0x000A70D5 File Offset: 0x000A52D5
		// (set) Token: 0x060045A8 RID: 17832 RVA: 0x000A70DD File Offset: 0x000A52DD
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
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

		// Token: 0x04002BD1 RID: 11217
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff opEmuField;

		// Token: 0x04002BD2 RID: 11218
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff noBreakField;

		// Token: 0x04002BD3 RID: 11219
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff diffField;

		// Token: 0x04002BD4 RID: 11220
		private global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak brkField;

		// Token: 0x04002BD5 RID: 11221
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff alnField;

		// Token: 0x04002BD6 RID: 11222
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
