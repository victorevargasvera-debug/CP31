using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000277 RID: 631
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextCharacterProperties
	{
		// Token: 0x060019B5 RID: 6581 RVA: 0x000461C0 File Offset: 0x000443C0
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties ct_TextCharacterProperties = new global::NPOI.OpenXmlFormats.Dml.CT_TextCharacterProperties();
			ct_TextCharacterProperties.kumimoji = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["kumimoji"]);
			ct_TextCharacterProperties.lang = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["lang"]);
			ct_TextCharacterProperties.altLang = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["altLang"]);
			ct_TextCharacterProperties.sz = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["sz"]);
			ct_TextCharacterProperties.bFieldSpecified = (node.Attributes["b"] != null);
			if (node.Attributes["b"] != null)
			{
				ct_TextCharacterProperties.bField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["b"]);
			}
			ct_TextCharacterProperties.iFieldSpecified = (node.Attributes["i"] != null);
			if (node.Attributes["i"] != null)
			{
				ct_TextCharacterProperties.iField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["i"]);
			}
			ct_TextCharacterProperties.uFieldSpecified = (node.Attributes["u"] != null);
			if (node.Attributes["u"] != null)
			{
				ct_TextCharacterProperties.uField = (global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType), node.Attributes["u"].Value);
			}
			ct_TextCharacterProperties.strikeFieldSpecified = (node.Attributes["strike"] != null);
			if (node.Attributes["strike"] != null)
			{
				ct_TextCharacterProperties.strikeField = (global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType), node.Attributes["strike"].Value);
			}
			ct_TextCharacterProperties.kern = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["kern"]);
			if (node.Attributes["cap"] != null)
			{
				ct_TextCharacterProperties.cap = (global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType), node.Attributes["cap"].Value);
			}
			ct_TextCharacterProperties.spc = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["spc"]);
			ct_TextCharacterProperties.normalizeH = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["normalizeH"]);
			ct_TextCharacterProperties.baselineFieldSpecified = (node.Attributes["baseline"] != null);
			ct_TextCharacterProperties.baselineField = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["baseline"]);
			ct_TextCharacterProperties.noProof = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["noProof"]);
			if (node.Attributes["dirty"] != null)
			{
				ct_TextCharacterProperties.dirty = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["dirty"]);
			}
			ct_TextCharacterProperties.err = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["err"]);
			if (node.Attributes["smtClean"] != null)
			{
				ct_TextCharacterProperties.smtClean = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["smtClean"]);
			}
			ct_TextCharacterProperties.smtId = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["smtId"]);
			ct_TextCharacterProperties.bmk = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["bmk"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ln")
				{
					ct_TextCharacterProperties.ln = global::NPOI.OpenXmlFormats.Dml.CT_LineProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noFill")
				{
					ct_TextCharacterProperties.noFill = new global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties();
				}
				else if (xmlNode.LocalName == "solidFill")
				{
					ct_TextCharacterProperties.solidFill = global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "gradFill")
				{
					ct_TextCharacterProperties.gradFill = global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "blipFill")
				{
					ct_TextCharacterProperties.blipFill = global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "pattFill")
				{
					ct_TextCharacterProperties.pattFill = global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "grpFill")
				{
					ct_TextCharacterProperties.grpFill = new global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties();
				}
				else if (xmlNode.LocalName == "effectLst")
				{
					ct_TextCharacterProperties.effectLst = global::NPOI.OpenXmlFormats.Dml.CT_EffectList.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effectDag")
				{
					ct_TextCharacterProperties.effectDag = global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "highlight")
				{
					ct_TextCharacterProperties.highlight = global::NPOI.OpenXmlFormats.Dml.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "uLnTx")
				{
					ct_TextCharacterProperties.uLnTx = new global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineLineFollowText();
				}
				else if (xmlNode.LocalName == "uLn")
				{
					ct_TextCharacterProperties.uLn = global::NPOI.OpenXmlFormats.Dml.CT_LineProperties.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "uFillTx")
				{
					ct_TextCharacterProperties.uFillTx = new global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillFollowText();
				}
				else if (xmlNode.LocalName == "uFill")
				{
					ct_TextCharacterProperties.uFill = global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillGroupWrapper.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "latin")
				{
					ct_TextCharacterProperties.latin = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "ea")
				{
					ct_TextCharacterProperties.ea = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cs")
				{
					ct_TextCharacterProperties.cs = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sym")
				{
					ct_TextCharacterProperties.sym = global::NPOI.OpenXmlFormats.Dml.CT_TextFont.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hlinkClick")
				{
					ct_TextCharacterProperties.hlinkClick = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "hlinkMouseOver")
				{
					ct_TextCharacterProperties.hlinkMouseOver = global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "extLst")
				{
					ct_TextCharacterProperties.extLst = global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_TextCharacterProperties;
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00046848 File Offset: 0x00044A48
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "kumimoji", this.kumimoji, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lang", this.lang);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "altLang", this.altLang);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "sz", this.sz);
			if (this.bFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "b", this.bField, true);
			}
			if (this.iFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "i", this.iField, true);
			}
			if (this.uFieldSpecified && this.uField != global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "u", this.uField.ToString());
			}
			if (this.strikeFieldSpecified && this.strikeField != global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType.noStrike)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "strike", this.strikeField.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "kern", this.kern);
			if (this.cap != global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType.none)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "cap", this.cap.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "spc", this.spc);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "normalizeH", this.normalizeH, false);
			if (this.baselineFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "baseline", this.baseline, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "noProof", this.noProof, false);
			if (!this.dirty)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dirty", this.dirty);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "err", this.err, false);
			if (!this.smtCleanField)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "smtClean", this.smtClean);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "smtId", this.smtId, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bmk", this.bmk);
			sw.Write(">");
			if (this.ln != null)
			{
				this.ln.Write(sw, "ln");
			}
			if (this.noFill != null)
			{
				sw.Write("<a:noFill/>");
			}
			if (this.solidFill != null)
			{
				this.solidFill.Write(sw, "solidFill");
			}
			if (this.gradFill != null)
			{
				this.gradFill.Write(sw, "gradFill");
			}
			if (this.blipFill != null)
			{
				this.blipFill.Write(sw, "a:blipFill");
			}
			if (this.pattFill != null)
			{
				this.pattFill.Write(sw, "pattFill");
			}
			if (this.grpFill != null)
			{
				sw.Write("<a:grpFill/>");
			}
			if (this.effectLst != null)
			{
				this.effectLst.Write(sw, "effectLst");
			}
			if (this.effectDag != null)
			{
				this.effectDag.Write(sw, "effectDag");
			}
			if (this.highlight != null)
			{
				this.highlight.Write(sw, "highlight");
			}
			if (this.uLnTx != null)
			{
				sw.Write("<a:uLnTx/>");
			}
			if (this.uLn != null)
			{
				this.uLn.Write(sw, "uLn");
			}
			if (this.uFillTx != null)
			{
				sw.Write("<a:uFillTx/>");
			}
			if (this.uFill != null)
			{
				this.uFill.Write(sw, "uFill");
			}
			if (this.latin != null)
			{
				this.latin.Write(sw, "latin");
			}
			if (this.ea != null)
			{
				this.ea.Write(sw, "ea");
			}
			if (this.cs != null)
			{
				this.cs.Write(sw, "cs");
			}
			if (this.sym != null)
			{
				this.sym.Write(sw, "sym");
			}
			if (this.hlinkClick != null)
			{
				this.hlinkClick.Write(sw, "hlinkClick");
			}
			if (this.hlinkMouseOver != null)
			{
				this.hlinkMouseOver.Write(sw, "hlinkMouseOver");
			}
			if (this.extLst != null)
			{
				this.extLst.Write(sw, "extLst");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00046C36 File Offset: 0x00044E36
		public CT_TextCharacterProperties()
		{
			this.strike = global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType.noStrike;
			this.dirtyField = true;
			this.errField = false;
			this.smtCleanField = true;
			this.smtIdField = 0U;
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00046C6F File Offset: 0x00044E6F
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x00046C77 File Offset: 0x00044E77
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties ln
		{
			get
			{
				return this.lnField;
			}
			set
			{
				this.lnField = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x060019BA RID: 6586 RVA: 0x00046C80 File Offset: 0x00044E80
		// (set) Token: 0x060019BB RID: 6587 RVA: 0x00046C88 File Offset: 0x00044E88
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFill
		{
			get
			{
				return this.noFillField;
			}
			set
			{
				this.noFillField = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x00046C91 File Offset: 0x00044E91
		// (set) Token: 0x060019BD RID: 6589 RVA: 0x00046C99 File Offset: 0x00044E99
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFill
		{
			get
			{
				return this.solidFillField;
			}
			set
			{
				this.solidFillField = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x060019BE RID: 6590 RVA: 0x00046CA2 File Offset: 0x00044EA2
		// (set) Token: 0x060019BF RID: 6591 RVA: 0x00046CAA File Offset: 0x00044EAA
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFill
		{
			get
			{
				return this.gradFillField;
			}
			set
			{
				this.gradFillField = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00046CB3 File Offset: 0x00044EB3
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x00046CBB File Offset: 0x00044EBB
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFill
		{
			get
			{
				return this.blipFillField;
			}
			set
			{
				this.blipFillField = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00046CC4 File Offset: 0x00044EC4
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x00046CCC File Offset: 0x00044ECC
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFill
		{
			get
			{
				return this.pattFillField;
			}
			set
			{
				this.pattFillField = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00046CD5 File Offset: 0x00044ED5
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00046CDD File Offset: 0x00044EDD
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFill
		{
			get
			{
				return this.grpFillField;
			}
			set
			{
				this.grpFillField = value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00046CE6 File Offset: 0x00044EE6
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x00046CEE File Offset: 0x00044EEE
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLst
		{
			get
			{
				return this.effectLstField;
			}
			set
			{
				this.effectLstField = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00046CF7 File Offset: 0x00044EF7
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x00046CFF File Offset: 0x00044EFF
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDag
		{
			get
			{
				return this.effectDagField;
			}
			set
			{
				this.effectDagField = value;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00046D08 File Offset: 0x00044F08
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x00046D10 File Offset: 0x00044F10
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Color highlight
		{
			get
			{
				return this.highlightField;
			}
			set
			{
				this.highlightField = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00046D19 File Offset: 0x00044F19
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x00046D21 File Offset: 0x00044F21
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineLineFollowText uLnTx
		{
			get
			{
				return this.uLnTxField;
			}
			set
			{
				this.uLnTxField = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00046D2A File Offset: 0x00044F2A
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x00046D32 File Offset: 0x00044F32
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Dml.CT_LineProperties uLn
		{
			get
			{
				return this.uLnField;
			}
			set
			{
				this.uLnField = value;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00046D3B File Offset: 0x00044F3B
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00046D43 File Offset: 0x00044F43
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillFollowText uFillTx
		{
			get
			{
				return this.uFillTxField;
			}
			set
			{
				this.uFillTxField = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x00046D4C File Offset: 0x00044F4C
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x00046D54 File Offset: 0x00044F54
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillGroupWrapper uFill
		{
			get
			{
				return this.uFillField;
			}
			set
			{
				this.uFillField = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00046D5D File Offset: 0x00044F5D
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x00046D65 File Offset: 0x00044F65
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont latin
		{
			get
			{
				return this.latinField;
			}
			set
			{
				this.latinField = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00046D6E File Offset: 0x00044F6E
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x00046D76 File Offset: 0x00044F76
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont ea
		{
			get
			{
				return this.eaField;
			}
			set
			{
				this.eaField = value;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00046D7F File Offset: 0x00044F7F
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x00046D87 File Offset: 0x00044F87
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont cs
		{
			get
			{
				return this.csField;
			}
			set
			{
				this.csField = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00046D90 File Offset: 0x00044F90
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x00046D98 File Offset: 0x00044F98
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont sym
		{
			get
			{
				return this.symField;
			}
			set
			{
				this.symField = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00046DA1 File Offset: 0x00044FA1
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x00046DA9 File Offset: 0x00044FA9
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClick
		{
			get
			{
				return this.hlinkClickField;
			}
			set
			{
				this.hlinkClickField = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00046DB2 File Offset: 0x00044FB2
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x00046DBA File Offset: 0x00044FBA
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkMouseOver
		{
			get
			{
				return this.hlinkMouseOverField;
			}
			set
			{
				this.hlinkMouseOverField = value;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00046DC3 File Offset: 0x00044FC3
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x00046DCB File Offset: 0x00044FCB
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00046DD4 File Offset: 0x00044FD4
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x00046DDC File Offset: 0x00044FDC
		[global::System.Xml.Serialization.XmlAttribute]
		public bool kumimoji
		{
			get
			{
				return this.kumimojiField;
			}
			set
			{
				this.kumimojiField = value;
				this.kumimojiFieldSpecified = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00046DEC File Offset: 0x00044FEC
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x00046DF4 File Offset: 0x00044FF4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool kumimojiSpecified
		{
			get
			{
				return this.kumimojiFieldSpecified;
			}
			set
			{
				this.kumimojiFieldSpecified = value;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00046DFD File Offset: 0x00044FFD
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x00046E05 File Offset: 0x00045005
		[global::System.Xml.Serialization.XmlAttribute]
		public string lang
		{
			get
			{
				return this.langField;
			}
			set
			{
				this.langField = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00046E0E File Offset: 0x0004500E
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x00046E16 File Offset: 0x00045016
		[global::System.Xml.Serialization.XmlAttribute]
		public string altLang
		{
			get
			{
				return this.altLangField;
			}
			set
			{
				this.altLangField = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00046E1F File Offset: 0x0004501F
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x00046E27 File Offset: 0x00045027
		[global::System.Xml.Serialization.XmlAttribute]
		public int sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
				this.szFieldSpecified = true;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00046E37 File Offset: 0x00045037
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x00046E3F File Offset: 0x0004503F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool szSpecified
		{
			get
			{
				return this.szFieldSpecified;
			}
			set
			{
				this.szFieldSpecified = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00046E48 File Offset: 0x00045048
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x00046E50 File Offset: 0x00045050
		[global::System.Xml.Serialization.XmlAttribute]
		public bool b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
				this.bFieldSpecified = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00046E60 File Offset: 0x00045060
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00046E68 File Offset: 0x00045068
		[global::System.Xml.Serialization.XmlIgnore]
		public bool bSpecified
		{
			get
			{
				return this.bFieldSpecified;
			}
			set
			{
				this.bFieldSpecified = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00046E71 File Offset: 0x00045071
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x00046E79 File Offset: 0x00045079
		[global::System.Xml.Serialization.XmlAttribute]
		public bool i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
				this.iFieldSpecified = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00046E89 File Offset: 0x00045089
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x00046E91 File Offset: 0x00045091
		[global::System.Xml.Serialization.XmlIgnore]
		public bool iSpecified
		{
			get
			{
				return this.iFieldSpecified;
			}
			set
			{
				this.iFieldSpecified = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00046E9A File Offset: 0x0004509A
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x00046EA2 File Offset: 0x000450A2
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
				this.uFieldSpecified = (value > global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType.none);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00046EB5 File Offset: 0x000450B5
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x00046EBD File Offset: 0x000450BD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool uSpecified
		{
			get
			{
				return this.uFieldSpecified;
			}
			set
			{
				this.uFieldSpecified = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00046EC6 File Offset: 0x000450C6
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x00046ECE File Offset: 0x000450CE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType strike
		{
			get
			{
				return this.strikeField;
			}
			set
			{
				this.strikeField = value;
				this.strikeFieldSpecified = (value > global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType.noStrike);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00046EE1 File Offset: 0x000450E1
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x00046EE9 File Offset: 0x000450E9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool strikeSpecified
		{
			get
			{
				return this.strikeFieldSpecified;
			}
			set
			{
				this.strikeFieldSpecified = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00046EF2 File Offset: 0x000450F2
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x00046EFA File Offset: 0x000450FA
		[global::System.Xml.Serialization.XmlAttribute]
		public int kern
		{
			get
			{
				return this.kernField;
			}
			set
			{
				this.kernField = value;
				this.kernFieldSpecified = true;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00046F0A File Offset: 0x0004510A
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00046F12 File Offset: 0x00045112
		[global::System.Xml.Serialization.XmlIgnore]
		public bool kernSpecified
		{
			get
			{
				return this.kernFieldSpecified;
			}
			set
			{
				this.kernFieldSpecified = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00046F1B File Offset: 0x0004511B
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x00046F23 File Offset: 0x00045123
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType cap
		{
			get
			{
				return this.capField;
			}
			set
			{
				this.capField = value;
				this.capFieldSpecified = (value > global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType.none);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00046F36 File Offset: 0x00045136
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x00046F3E File Offset: 0x0004513E
		[global::System.Xml.Serialization.XmlIgnore]
		public bool capSpecified
		{
			get
			{
				return this.capFieldSpecified;
			}
			set
			{
				this.capFieldSpecified = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00046F47 File Offset: 0x00045147
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x00046F4F File Offset: 0x0004514F
		[global::System.Xml.Serialization.XmlAttribute]
		public int spc
		{
			get
			{
				return this.spcField;
			}
			set
			{
				this.spcField = value;
				this.spcFieldSpecified = true;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00046F5F File Offset: 0x0004515F
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x00046F67 File Offset: 0x00045167
		[global::System.Xml.Serialization.XmlIgnore]
		public bool spcSpecified
		{
			get
			{
				return this.spcFieldSpecified;
			}
			set
			{
				this.spcFieldSpecified = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00046F70 File Offset: 0x00045170
		// (set) Token: 0x06001A0B RID: 6667 RVA: 0x00046F78 File Offset: 0x00045178
		[global::System.Xml.Serialization.XmlAttribute]
		public bool normalizeH
		{
			get
			{
				return this.normalizeHField;
			}
			set
			{
				this.normalizeHField = value;
				this.normalizeHFieldSpecified = true;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00046F88 File Offset: 0x00045188
		// (set) Token: 0x06001A0D RID: 6669 RVA: 0x00046F90 File Offset: 0x00045190
		[global::System.Xml.Serialization.XmlIgnore]
		public bool normalizeHSpecified
		{
			get
			{
				return this.normalizeHFieldSpecified;
			}
			set
			{
				this.normalizeHFieldSpecified = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00046F99 File Offset: 0x00045199
		// (set) Token: 0x06001A0F RID: 6671 RVA: 0x00046FA1 File Offset: 0x000451A1
		[global::System.Xml.Serialization.XmlAttribute]
		public int baseline
		{
			get
			{
				return this.baselineField;
			}
			set
			{
				this.baselineField = value;
				this.baselineFieldSpecified = true;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00046FB1 File Offset: 0x000451B1
		// (set) Token: 0x06001A11 RID: 6673 RVA: 0x00046FB9 File Offset: 0x000451B9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool baselineSpecified
		{
			get
			{
				return this.baselineFieldSpecified;
			}
			set
			{
				this.baselineFieldSpecified = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00046FC2 File Offset: 0x000451C2
		// (set) Token: 0x06001A13 RID: 6675 RVA: 0x00046FCA File Offset: 0x000451CA
		[global::System.Xml.Serialization.XmlAttribute]
		public bool noProof
		{
			get
			{
				return this.noProofField;
			}
			set
			{
				this.noProofField = value;
				this.noProofFieldSpecified = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00046FDA File Offset: 0x000451DA
		// (set) Token: 0x06001A15 RID: 6677 RVA: 0x00046FE2 File Offset: 0x000451E2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool noProofSpecified
		{
			get
			{
				return this.noProofFieldSpecified;
			}
			set
			{
				this.noProofFieldSpecified = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00046FEB File Offset: 0x000451EB
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x00046FF3 File Offset: 0x000451F3
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool dirty
		{
			get
			{
				return this.dirtyField;
			}
			set
			{
				this.dirtyField = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00046FFC File Offset: 0x000451FC
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x00047004 File Offset: 0x00045204
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool err
		{
			get
			{
				return this.errField;
			}
			set
			{
				this.errField = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0004700D File Offset: 0x0004520D
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00047015 File Offset: 0x00045215
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool smtClean
		{
			get
			{
				return this.smtCleanField;
			}
			set
			{
				this.smtCleanField = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x0004701E File Offset: 0x0004521E
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x00047026 File Offset: 0x00045226
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint smtId
		{
			get
			{
				return this.smtIdField;
			}
			set
			{
				this.smtIdField = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x0004702F File Offset: 0x0004522F
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00047037 File Offset: 0x00045237
		[global::System.Xml.Serialization.XmlAttribute]
		public string bmk
		{
			get
			{
				return this.bmkField;
			}
			set
			{
				this.bmkField = value;
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00047040 File Offset: 0x00045240
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont AddNewLatin()
		{
			this.latinField = new global::NPOI.OpenXmlFormats.Dml.CT_TextFont();
			return this.latinField;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00047053 File Offset: 0x00045253
		public bool IsSetSolidFill()
		{
			return this.solidFill != null;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0004705E File Offset: 0x0004525E
		public global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties AddNewSolidFill()
		{
			this.solidFillField = new global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties();
			return this.solidFillField;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00046EE1 File Offset: 0x000450E1
		public bool IsSetStrike()
		{
			return this.strikeFieldSpecified;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00047071 File Offset: 0x00045271
		public bool IsSetBaseline()
		{
			return this.baselineFieldSpecified && this.baselineField != 0;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00046E60 File Offset: 0x00045060
		public bool IsSetB()
		{
			return this.bFieldSpecified;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00046E89 File Offset: 0x00045089
		public bool IsSetI()
		{
			return this.iFieldSpecified;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00046EB5 File Offset: 0x000450B5
		public bool IsSetU()
		{
			return this.uFieldSpecified;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00046F36 File Offset: 0x00045136
		public bool IsSetCap()
		{
			return this.capFieldSpecified;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00046E37 File Offset: 0x00045037
		public bool IsSetSz()
		{
			return this.szFieldSpecified;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00047086 File Offset: 0x00045286
		public void UnsetSz()
		{
			this.szFieldSpecified = false;
			this.szField = 0;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00046F5F File Offset: 0x0004515F
		public bool IsSetSpc()
		{
			return this.spcFieldSpecified;
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00047096 File Offset: 0x00045296
		public void UnsetSpc()
		{
			this.spcFieldSpecified = false;
			this.spcField = 0;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000470A6 File Offset: 0x000452A6
		public bool IsSetLatin()
		{
			return this.latinField != null;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000470B1 File Offset: 0x000452B1
		public void UnsetLatin()
		{
			this.latinField = null;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000470BA File Offset: 0x000452BA
		public bool IsSetCs()
		{
			return this.csField != null;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000470C5 File Offset: 0x000452C5
		public void UnsetCs()
		{
			this.csField = null;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000470CE File Offset: 0x000452CE
		public bool IsSetSym()
		{
			return this.symField != null;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000470D9 File Offset: 0x000452D9
		public void UnsetSym()
		{
			this.symField = null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000470E2 File Offset: 0x000452E2
		public global::NPOI.OpenXmlFormats.Dml.CT_TextFont AddNewSym()
		{
			this.symField = new global::NPOI.OpenXmlFormats.Dml.CT_TextFont();
			return this.symField;
		}

		// Token: 0x04001359 RID: 4953
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties lnField;

		// Token: 0x0400135A RID: 4954
		private global::NPOI.OpenXmlFormats.Dml.CT_NoFillProperties noFillField;

		// Token: 0x0400135B RID: 4955
		private global::NPOI.OpenXmlFormats.Dml.CT_SolidColorFillProperties solidFillField;

		// Token: 0x0400135C RID: 4956
		private global::NPOI.OpenXmlFormats.Dml.CT_GradientFillProperties gradFillField;

		// Token: 0x0400135D RID: 4957
		private global::NPOI.OpenXmlFormats.Dml.CT_BlipFillProperties blipFillField;

		// Token: 0x0400135E RID: 4958
		private global::NPOI.OpenXmlFormats.Dml.CT_PatternFillProperties pattFillField;

		// Token: 0x0400135F RID: 4959
		private global::NPOI.OpenXmlFormats.Dml.CT_GroupFillProperties grpFillField;

		// Token: 0x04001360 RID: 4960
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectList effectLstField;

		// Token: 0x04001361 RID: 4961
		private global::NPOI.OpenXmlFormats.Dml.CT_EffectContainer effectDagField;

		// Token: 0x04001362 RID: 4962
		private global::NPOI.OpenXmlFormats.Dml.CT_Color highlightField;

		// Token: 0x04001363 RID: 4963
		private global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineLineFollowText uLnTxField;

		// Token: 0x04001364 RID: 4964
		private global::NPOI.OpenXmlFormats.Dml.CT_LineProperties uLnField;

		// Token: 0x04001365 RID: 4965
		private global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillFollowText uFillTxField;

		// Token: 0x04001366 RID: 4966
		private global::NPOI.OpenXmlFormats.Dml.CT_TextUnderlineFillGroupWrapper uFillField;

		// Token: 0x04001367 RID: 4967
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont latinField;

		// Token: 0x04001368 RID: 4968
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont eaField;

		// Token: 0x04001369 RID: 4969
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont csField;

		// Token: 0x0400136A RID: 4970
		private global::NPOI.OpenXmlFormats.Dml.CT_TextFont symField;

		// Token: 0x0400136B RID: 4971
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkClickField;

		// Token: 0x0400136C RID: 4972
		private global::NPOI.OpenXmlFormats.Dml.CT_Hyperlink hlinkMouseOverField;

		// Token: 0x0400136D RID: 4973
		private global::NPOI.OpenXmlFormats.Dml.CT_OfficeArtExtensionList extLstField;

		// Token: 0x0400136E RID: 4974
		private bool kumimojiField;

		// Token: 0x0400136F RID: 4975
		private bool kumimojiFieldSpecified;

		// Token: 0x04001370 RID: 4976
		private string langField;

		// Token: 0x04001371 RID: 4977
		private string altLangField;

		// Token: 0x04001372 RID: 4978
		private int szField;

		// Token: 0x04001373 RID: 4979
		private bool szFieldSpecified;

		// Token: 0x04001374 RID: 4980
		private bool bField;

		// Token: 0x04001375 RID: 4981
		private bool bFieldSpecified;

		// Token: 0x04001376 RID: 4982
		private bool iField;

		// Token: 0x04001377 RID: 4983
		private bool iFieldSpecified;

		// Token: 0x04001378 RID: 4984
		private global::NPOI.OpenXmlFormats.Dml.ST_TextUnderlineType uField;

		// Token: 0x04001379 RID: 4985
		private bool uFieldSpecified;

		// Token: 0x0400137A RID: 4986
		private global::NPOI.OpenXmlFormats.Dml.ST_TextStrikeType strikeField;

		// Token: 0x0400137B RID: 4987
		private bool strikeFieldSpecified;

		// Token: 0x0400137C RID: 4988
		private int kernField;

		// Token: 0x0400137D RID: 4989
		private bool kernFieldSpecified;

		// Token: 0x0400137E RID: 4990
		private global::NPOI.OpenXmlFormats.Dml.ST_TextCapsType capField;

		// Token: 0x0400137F RID: 4991
		private bool capFieldSpecified;

		// Token: 0x04001380 RID: 4992
		private int spcField;

		// Token: 0x04001381 RID: 4993
		private bool spcFieldSpecified;

		// Token: 0x04001382 RID: 4994
		private bool normalizeHField;

		// Token: 0x04001383 RID: 4995
		private bool normalizeHFieldSpecified;

		// Token: 0x04001384 RID: 4996
		private int baselineField;

		// Token: 0x04001385 RID: 4997
		private bool baselineFieldSpecified;

		// Token: 0x04001386 RID: 4998
		private bool noProofField;

		// Token: 0x04001387 RID: 4999
		private bool noProofFieldSpecified;

		// Token: 0x04001388 RID: 5000
		private bool dirtyField = true;

		// Token: 0x04001389 RID: 5001
		private bool errField;

		// Token: 0x0400138A RID: 5002
		private bool smtCleanField = true;

		// Token: 0x0400138B RID: 5003
		private uint smtIdField;

		// Token: 0x0400138C RID: 5004
		private string bmkField;
	}
}
