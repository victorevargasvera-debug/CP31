using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x02000659 RID: 1625
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = true)]
	[global::System.Serializable]
	public class CT_BorderBoxPr
	{
		// Token: 0x060045B1 RID: 17841 RVA: 0x000A7234 File Offset: 0x000A5434
		public static global::NPOI.OpenXmlFormats.Shared.CT_BorderBoxPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_BorderBoxPr ct_BorderBoxPr = new global::NPOI.OpenXmlFormats.Shared.CT_BorderBoxPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "hideTop")
				{
					ct_BorderBoxPr.hideTop = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideBot")
				{
					ct_BorderBoxPr.hideBot = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideLeft")
				{
					ct_BorderBoxPr.hideLeft = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hideRight")
				{
					ct_BorderBoxPr.hideRight = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strikeH")
				{
					ct_BorderBoxPr.strikeH = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strikeV")
				{
					ct_BorderBoxPr.strikeV = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strikeBLTR")
				{
					ct_BorderBoxPr.strikeBLTR = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strikeTLBR")
				{
					ct_BorderBoxPr.strikeTLBR = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ctrlPr")
				{
					ct_BorderBoxPr.ctrlPr = global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_BorderBoxPr;
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x000A73DC File Offset: 0x000A55DC
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.hideTop != null)
			{
				this.hideTop.Write(sw, "hideTop");
			}
			if (this.hideBot != null)
			{
				this.hideBot.Write(sw, "hideBot");
			}
			if (this.hideLeft != null)
			{
				this.hideLeft.Write(sw, "hideLeft");
			}
			if (this.hideRight != null)
			{
				this.hideRight.Write(sw, "hideRight");
			}
			if (this.strikeH != null)
			{
				this.strikeH.Write(sw, "strikeH");
			}
			if (this.strikeV != null)
			{
				this.strikeV.Write(sw, "strikeV");
			}
			if (this.strikeBLTR != null)
			{
				this.strikeBLTR.Write(sw, "strikeBLTR");
			}
			if (this.strikeTLBR != null)
			{
				this.strikeTLBR.Write(sw, "strikeTLBR");
			}
			if (this.ctrlPr != null)
			{
				this.ctrlPr.Write(sw, "ctrlPr");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x000A74F7 File Offset: 0x000A56F7
		// (set) Token: 0x060045B4 RID: 17844 RVA: 0x000A74FF File Offset: 0x000A56FF
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideTop
		{
			get
			{
				return this.hideTopField;
			}
			set
			{
				this.hideTopField = value;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x060045B5 RID: 17845 RVA: 0x000A7508 File Offset: 0x000A5708
		// (set) Token: 0x060045B6 RID: 17846 RVA: 0x000A7510 File Offset: 0x000A5710
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideBot
		{
			get
			{
				return this.hideBotField;
			}
			set
			{
				this.hideBotField = value;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x000A7519 File Offset: 0x000A5719
		// (set) Token: 0x060045B8 RID: 17848 RVA: 0x000A7521 File Offset: 0x000A5721
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideLeft
		{
			get
			{
				return this.hideLeftField;
			}
			set
			{
				this.hideLeftField = value;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x000A752A File Offset: 0x000A572A
		// (set) Token: 0x060045BA RID: 17850 RVA: 0x000A7532 File Offset: 0x000A5732
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideRight
		{
			get
			{
				return this.hideRightField;
			}
			set
			{
				this.hideRightField = value;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x000A753B File Offset: 0x000A573B
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x000A7543 File Offset: 0x000A5743
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeH
		{
			get
			{
				return this.strikeHField;
			}
			set
			{
				this.strikeHField = value;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x000A754C File Offset: 0x000A574C
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x000A7554 File Offset: 0x000A5754
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeV
		{
			get
			{
				return this.strikeVField;
			}
			set
			{
				this.strikeVField = value;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x000A755D File Offset: 0x000A575D
		// (set) Token: 0x060045C0 RID: 17856 RVA: 0x000A7565 File Offset: 0x000A5765
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeBLTR
		{
			get
			{
				return this.strikeBLTRField;
			}
			set
			{
				this.strikeBLTRField = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x060045C1 RID: 17857 RVA: 0x000A756E File Offset: 0x000A576E
		// (set) Token: 0x060045C2 RID: 17858 RVA: 0x000A7576 File Offset: 0x000A5776
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeTLBR
		{
			get
			{
				return this.strikeTLBRField;
			}
			set
			{
				this.strikeTLBRField = value;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x000A757F File Offset: 0x000A577F
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x000A7587 File Offset: 0x000A5787
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
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

		// Token: 0x04002BD9 RID: 11225
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideTopField;

		// Token: 0x04002BDA RID: 11226
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideBotField;

		// Token: 0x04002BDB RID: 11227
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideLeftField;

		// Token: 0x04002BDC RID: 11228
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff hideRightField;

		// Token: 0x04002BDD RID: 11229
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeHField;

		// Token: 0x04002BDE RID: 11230
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeVField;

		// Token: 0x04002BDF RID: 11231
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeBLTRField;

		// Token: 0x04002BE0 RID: 11232
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff strikeTLBRField;

		// Token: 0x04002BE1 RID: 11233
		private global::NPOI.OpenXmlFormats.Shared.CT_CtrlPr ctrlPrField;
	}
}
