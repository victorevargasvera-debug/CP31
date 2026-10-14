using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Shared
{
	// Token: 0x0200062A RID: 1578
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math")]
	[global::System.Xml.Serialization.XmlRoot("mathPr", Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/math", IsNullable = false)]
	[global::System.Serializable]
	public class CT_MathPr
	{
		// Token: 0x060044A5 RID: 17573 RVA: 0x000A2EC0 File Offset: 0x000A10C0
		public CT_MathPr()
		{
			this.naryLimField = new global::NPOI.OpenXmlFormats.Shared.CT_LimLoc();
			this.intLimField = new global::NPOI.OpenXmlFormats.Shared.CT_LimLoc();
			this.defJcField = new global::NPOI.OpenXmlFormats.Shared.CT_OMathJc();
			this.rMarginField = new global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure();
			this.lMarginField = new global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure();
			this.smallFracField = new global::NPOI.OpenXmlFormats.Shared.CT_OnOff();
			this.brkBinSubField = new global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub();
			this.brkBinField = new global::NPOI.OpenXmlFormats.Shared.CT_BreakBin();
			this.mathFontField = new global::NPOI.OpenXmlFormats.Shared.CT_String();
			this.mathFont.val = "Cambria Math";
			this.brkBin.val = global::NPOI.OpenXmlFormats.Shared.ST_BreakBin.before;
			this.brkBinSub.val = global::NPOI.OpenXmlFormats.Shared.ST_BreakBinSub.Item;
			this.smallFrac.val = global::NPOI.OpenXmlFormats.Shared.ST_OnOff.off;
			this.lMargin.val = 0U;
			this.rMargin.val = 0U;
			this.defJc.val = global::NPOI.OpenXmlFormats.Shared.ST_Jc.centerGroup;
			this.itemField = new global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure();
			(this.Item as global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure).val = 1440U;
			this.itemElementName = "wrapIndent";
			this.intLim.val = global::NPOI.OpenXmlFormats.Shared.ST_LimLoc.subSup;
			this.naryLim.val = global::NPOI.OpenXmlFormats.Shared.ST_LimLoc.undOvr;
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x000A2FD4 File Offset: 0x000A11D4
		public static global::NPOI.OpenXmlFormats.Shared.CT_MathPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Shared.CT_MathPr ct_MathPr = new global::NPOI.OpenXmlFormats.Shared.CT_MathPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "mathFont")
				{
					ct_MathPr.mathFont = global::NPOI.OpenXmlFormats.Shared.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "brkBin")
				{
					ct_MathPr.brkBin = global::NPOI.OpenXmlFormats.Shared.CT_BreakBin.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "brkBinSub")
				{
					ct_MathPr.brkBinSub = global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smallFrac")
				{
					ct_MathPr.smallFrac = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dispDef")
				{
					ct_MathPr.dispDef = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lMargin")
				{
					ct_MathPr.lMargin = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rMargin")
				{
					ct_MathPr.rMargin = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "defJc")
				{
					ct_MathPr.defJc = global::NPOI.OpenXmlFormats.Shared.CT_OMathJc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "preSp")
				{
					ct_MathPr.preSp = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "postSp")
				{
					ct_MathPr.postSp = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "interSp")
				{
					ct_MathPr.interSp = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "intraSp")
				{
					ct_MathPr.intraSp = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "wrapIndent")
				{
					ct_MathPr.Item = global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure.Parse(xmlNode, namespaceManager);
					ct_MathPr.itemElementName = "wrapIndent";
				}
				else if (xmlNode.LocalName == "wrapRight")
				{
					ct_MathPr.Item = global::NPOI.OpenXmlFormats.Shared.CT_OnOff.Parse(xmlNode, namespaceManager);
					ct_MathPr.itemElementName = "wrapRight";
				}
				else if (xmlNode.LocalName == "intLim")
				{
					ct_MathPr.intLim = global::NPOI.OpenXmlFormats.Shared.CT_LimLoc.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "naryLim")
				{
					ct_MathPr.naryLim = global::NPOI.OpenXmlFormats.Shared.CT_LimLoc.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_MathPr;
		}

		// Token: 0x060044A7 RID: 17575 RVA: 0x000A328C File Offset: 0x000A148C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<m:{0}", nodeName));
			sw.Write(">");
			if (this.mathFont != null)
			{
				this.mathFont.Write(sw, "mathFont");
			}
			if (this.brkBin != null)
			{
				this.brkBin.Write(sw, "brkBin");
			}
			if (this.brkBinSub != null)
			{
				this.brkBinSub.Write(sw, "brkBinSub");
			}
			if (this.smallFrac != null)
			{
				this.smallFrac.Write(sw, "smallFrac");
			}
			if (this.dispDef != null)
			{
				this.dispDef.Write(sw, "dispDef");
			}
			if (this.lMargin != null)
			{
				this.lMargin.Write(sw, "lMargin");
			}
			if (this.rMargin != null)
			{
				this.rMargin.Write(sw, "rMargin");
			}
			if (this.defJc != null)
			{
				this.defJc.Write(sw, "defJc");
			}
			if (this.preSp != null)
			{
				this.preSp.Write(sw, "preSp");
			}
			if (this.postSp != null)
			{
				this.postSp.Write(sw, "postSp");
			}
			if (this.interSp != null)
			{
				this.interSp.Write(sw, "interSp");
			}
			if (this.intraSp != null)
			{
				this.intraSp.Write(sw, "intraSp");
			}
			if (this.Item != null)
			{
				if (this.itemElementName == "wrapIndent")
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure)this.itemField).Write(sw, this.itemElementName);
				}
				else
				{
					((global::NPOI.OpenXmlFormats.Shared.CT_OnOff)this.itemField).Write(sw, this.itemElementName);
				}
			}
			if (this.intLim != null)
			{
				this.intLim.Write(sw, "intLim");
			}
			if (this.naryLim != null)
			{
				this.naryLim.Write(sw, "naryLim");
			}
			sw.Write(string.Format("</m:{0}>", nodeName));
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x000A346E File Offset: 0x000A166E
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x000A3476 File Offset: 0x000A1676
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Shared.CT_String mathFont
		{
			get
			{
				return this.mathFontField;
			}
			set
			{
				this.mathFontField = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x060044AA RID: 17578 RVA: 0x000A347F File Offset: 0x000A167F
		// (set) Token: 0x060044AB RID: 17579 RVA: 0x000A3487 File Offset: 0x000A1687
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Shared.CT_BreakBin brkBin
		{
			get
			{
				return this.brkBinField;
			}
			set
			{
				this.brkBinField = value;
			}
		}

		// Token: 0x170019E1 RID: 6625
		// (get) Token: 0x060044AC RID: 17580 RVA: 0x000A3490 File Offset: 0x000A1690
		// (set) Token: 0x060044AD RID: 17581 RVA: 0x000A3498 File Offset: 0x000A1698
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub brkBinSub
		{
			get
			{
				return this.brkBinSubField;
			}
			set
			{
				this.brkBinSubField = value;
			}
		}

		// Token: 0x170019E2 RID: 6626
		// (get) Token: 0x060044AE RID: 17582 RVA: 0x000A34A1 File Offset: 0x000A16A1
		// (set) Token: 0x060044AF RID: 17583 RVA: 0x000A34A9 File Offset: 0x000A16A9
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff smallFrac
		{
			get
			{
				return this.smallFracField;
			}
			set
			{
				this.smallFracField = value;
			}
		}

		// Token: 0x170019E3 RID: 6627
		// (get) Token: 0x060044B0 RID: 17584 RVA: 0x000A34B2 File Offset: 0x000A16B2
		// (set) Token: 0x060044B1 RID: 17585 RVA: 0x000A34BA File Offset: 0x000A16BA
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OnOff dispDef
		{
			get
			{
				return this.dispDefField;
			}
			set
			{
				this.dispDefField = value;
			}
		}

		// Token: 0x170019E4 RID: 6628
		// (get) Token: 0x060044B2 RID: 17586 RVA: 0x000A34C3 File Offset: 0x000A16C3
		// (set) Token: 0x060044B3 RID: 17587 RVA: 0x000A34CB File Offset: 0x000A16CB
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure lMargin
		{
			get
			{
				return this.lMarginField;
			}
			set
			{
				this.lMarginField = value;
			}
		}

		// Token: 0x170019E5 RID: 6629
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x000A34D4 File Offset: 0x000A16D4
		// (set) Token: 0x060044B5 RID: 17589 RVA: 0x000A34DC File Offset: 0x000A16DC
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure rMargin
		{
			get
			{
				return this.rMarginField;
			}
			set
			{
				this.rMarginField = value;
			}
		}

		// Token: 0x170019E6 RID: 6630
		// (get) Token: 0x060044B6 RID: 17590 RVA: 0x000A34E5 File Offset: 0x000A16E5
		// (set) Token: 0x060044B7 RID: 17591 RVA: 0x000A34ED File Offset: 0x000A16ED
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Shared.CT_OMathJc defJc
		{
			get
			{
				return this.defJcField;
			}
			set
			{
				this.defJcField = value;
			}
		}

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x060044B8 RID: 17592 RVA: 0x000A34F6 File Offset: 0x000A16F6
		// (set) Token: 0x060044B9 RID: 17593 RVA: 0x000A34FE File Offset: 0x000A16FE
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure preSp
		{
			get
			{
				return this.preSpField;
			}
			set
			{
				this.preSpField = value;
			}
		}

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x060044BA RID: 17594 RVA: 0x000A3507 File Offset: 0x000A1707
		// (set) Token: 0x060044BB RID: 17595 RVA: 0x000A350F File Offset: 0x000A170F
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure postSp
		{
			get
			{
				return this.postSpField;
			}
			set
			{
				this.postSpField = value;
			}
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x060044BC RID: 17596 RVA: 0x000A3518 File Offset: 0x000A1718
		// (set) Token: 0x060044BD RID: 17597 RVA: 0x000A3520 File Offset: 0x000A1720
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure interSp
		{
			get
			{
				return this.interSpField;
			}
			set
			{
				this.interSpField = value;
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x060044BE RID: 17598 RVA: 0x000A3529 File Offset: 0x000A1729
		// (set) Token: 0x060044BF RID: 17599 RVA: 0x000A3531 File Offset: 0x000A1731
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure intraSp
		{
			get
			{
				return this.intraSpField;
			}
			set
			{
				this.intraSpField = value;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060044C0 RID: 17600 RVA: 0x000A353A File Offset: 0x000A173A
		// (set) Token: 0x060044C1 RID: 17601 RVA: 0x000A3542 File Offset: 0x000A1742
		[global::System.Xml.Serialization.XmlElement("wrapIndent", typeof(global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure), Order = 12)]
		[global::System.Xml.Serialization.XmlElement("wrapRight", typeof(global::NPOI.OpenXmlFormats.Shared.CT_OnOff), Order = 12)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x060044C2 RID: 17602 RVA: 0x000A354B File Offset: 0x000A174B
		// (set) Token: 0x060044C3 RID: 17603 RVA: 0x000A3553 File Offset: 0x000A1753
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Shared.CT_LimLoc intLim
		{
			get
			{
				return this.intLimField;
			}
			set
			{
				this.intLimField = value;
			}
		}

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x060044C4 RID: 17604 RVA: 0x000A355C File Offset: 0x000A175C
		// (set) Token: 0x060044C5 RID: 17605 RVA: 0x000A3564 File Offset: 0x000A1764
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Shared.CT_LimLoc naryLim
		{
			get
			{
				return this.naryLimField;
			}
			set
			{
				this.naryLimField = value;
			}
		}

		// Token: 0x04002B08 RID: 11016
		private global::NPOI.OpenXmlFormats.Shared.CT_String mathFontField;

		// Token: 0x04002B09 RID: 11017
		private global::NPOI.OpenXmlFormats.Shared.CT_BreakBin brkBinField;

		// Token: 0x04002B0A RID: 11018
		private global::NPOI.OpenXmlFormats.Shared.CT_BreakBinSub brkBinSubField;

		// Token: 0x04002B0B RID: 11019
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff smallFracField;

		// Token: 0x04002B0C RID: 11020
		private global::NPOI.OpenXmlFormats.Shared.CT_OnOff dispDefField;

		// Token: 0x04002B0D RID: 11021
		private global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure lMarginField;

		// Token: 0x04002B0E RID: 11022
		private global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure rMarginField;

		// Token: 0x04002B0F RID: 11023
		private global::NPOI.OpenXmlFormats.Shared.CT_OMathJc defJcField;

		// Token: 0x04002B10 RID: 11024
		private global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure preSpField;

		// Token: 0x04002B11 RID: 11025
		private global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure postSpField;

		// Token: 0x04002B12 RID: 11026
		private global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure interSpField;

		// Token: 0x04002B13 RID: 11027
		private global::NPOI.OpenXmlFormats.Shared.CT_TwipsMeasure intraSpField;

		// Token: 0x04002B14 RID: 11028
		private object itemField;

		// Token: 0x04002B15 RID: 11029
		private string itemElementName;

		// Token: 0x04002B16 RID: 11030
		private global::NPOI.OpenXmlFormats.Shared.CT_LimLoc intLimField;

		// Token: 0x04002B17 RID: 11031
		private global::NPOI.OpenXmlFormats.Shared.CT_LimLoc naryLimField;
	}
}
