using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200064B RID: 1611
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RPR
	{
		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x000A42BC File Offset: 0x000A24BC
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x000A42C4 File Offset: 0x000A24C4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff lit
		{
			get
			{
				return this.litField;
			}
			set
			{
				this.litField = value;
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x000A42CD File Offset: 0x000A24CD
		// (set) Token: 0x06004536 RID: 17718 RVA: 0x000A42D5 File Offset: 0x000A24D5
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff nor
		{
			get
			{
				return this.norField;
			}
			set
			{
				this.norField = value;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x000A42DE File Offset: 0x000A24DE
		// (set) Token: 0x06004538 RID: 17720 RVA: 0x000A42E6 File Offset: 0x000A24E6
		public global::NPOI.OpenXmlFormats.Shared.CT_Script scr
		{
			get
			{
				return this.scrField;
			}
			set
			{
				this.scrField = value;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x000A42EF File Offset: 0x000A24EF
		// (set) Token: 0x0600453A RID: 17722 RVA: 0x000A42F7 File Offset: 0x000A24F7
		public global::NPOI.OpenXmlFormats.Shared.CT_Style sty
		{
			get
			{
				return this.styField;
			}
			set
			{
				this.styField = value;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x000A4300 File Offset: 0x000A2500
		// (set) Token: 0x0600453C RID: 17724 RVA: 0x000A4308 File Offset: 0x000A2508
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
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

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x000A4311 File Offset: 0x000A2511
		// (set) Token: 0x0600453E RID: 17726 RVA: 0x000A4319 File Offset: 0x000A2519
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
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

		// Token: 0x0600453F RID: 17727 RVA: 0x000A4324 File Offset: 0x000A2524
		internal static global::NPOI.OpenXmlFormats.Shared.CT_RPR Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_RPR ct_RPR = new global::NPOI.OpenXmlFormats.Shared.CT_RPR();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "lit")
				{
					ct_RPR.litField = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "nor")
				{
					ct_RPR.norField = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "aln")
				{
					ct_RPR.alnField = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "brk")
				{
					ct_RPR.brkField = global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "scr")
				{
					ct_RPR.scrField = global::NPOI.OpenXmlFormats.Shared.CT_Script.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sty")
				{
					ct_RPR.styField = global::NPOI.OpenXmlFormats.Shared.CT_Style.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RPR;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000A4454 File Offset: 0x000A2654
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}>", nodeName));
			if (this.litField != null)
			{
				this.litField.Write(sw, "lit");
			}
			if (this.norField != null)
			{
				this.norField.Write(sw, "nor");
			}
			if (this.scrField != null)
			{
				this.scrField.Write(sw, "scr");
			}
			if (this.styField != null)
			{
				this.styField.Write(sw, "sty");
			}
			if (this.brkField != null)
			{
				this.brkField.Write(sw, "brk");
			}
			if (this.alnField != null)
			{
				this.alnField.Write(sw, "aln");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000A4519 File Offset: 0x000A2719
		public bool IsSetI()
		{
			return this.litField != null;
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x000A4524 File Offset: 0x000A2724
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff AddNewI()
		{
			if (this.litField == null)
			{
				this.litField = new global::NPOI.OpenXmlFormats.Shared.CT_OnOff();
			}
			return this.litField;
		}

		// Token: 0x04002B65 RID: 11109
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff litField;

		// Token: 0x04002B66 RID: 11110
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff norField;

		// Token: 0x04002B67 RID: 11111
		private global::NPOI.OpenXmlFormats.Shared.CT_Script scrField;

		// Token: 0x04002B68 RID: 11112
		private global::NPOI.OpenXmlFormats.Shared.CT_Style styField;

		// Token: 0x04002B69 RID: 11113
		private global::NPOI.OpenXmlFormats.Shared.CT_ManualBreak brkField;

		// Token: 0x04002B6A RID: 11114
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff alnField;
	}
}
