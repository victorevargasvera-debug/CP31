using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000165 RID: 357
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RPr
	{
		// Token: 0x06000B18 RID: 2840 RVA: 0x000264FC File Offset: 0x000246FC
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr ct_RPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rStyle")
				{
					ct_RPr.rStyle = global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rFonts")
				{
					ct_RPr.rFonts = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_RPr.b = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bCs")
				{
					ct_RPr.bCs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "i")
				{
					ct_RPr.i = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "iCs")
				{
					ct_RPr.iCs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "caps")
				{
					ct_RPr.caps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "smallCaps")
				{
					ct_RPr.smallCaps = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "strike")
				{
					ct_RPr.strike = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "dstrike")
				{
					ct_RPr.dstrike = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "outline")
				{
					ct_RPr.outline = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_RPr.shadow = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "emboss")
				{
					ct_RPr.emboss = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "imprint")
				{
					ct_RPr.imprint = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "noProof")
				{
					ct_RPr.noProof = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "snapToGrid")
				{
					ct_RPr.snapToGrid = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vanish")
				{
					ct_RPr.vanish = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webHidden")
				{
					ct_RPr.webHidden = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_RPr.color = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "spacing")
				{
					ct_RPr.spacing = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "w")
				{
					ct_RPr.w = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "kern")
				{
					ct_RPr.kern = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "position")
				{
					ct_RPr.position = global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "sz")
				{
					ct_RPr.sz = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "szCs")
				{
					ct_RPr.szCs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "highlight")
				{
					ct_RPr.highlight = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "u")
				{
					ct_RPr.u = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "effect")
				{
					ct_RPr.effect = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "bdr")
				{
					ct_RPr.bdr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_RPr.shd = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "fitText")
				{
					ct_RPr.fitText = global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "vertAlign")
				{
					ct_RPr.vertAlign = global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rtl")
				{
					ct_RPr.rtl = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "cs")
				{
					ct_RPr.cs = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "em")
				{
					ct_RPr.em = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "lang")
				{
					ct_RPr.lang = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "eastAsianLayout")
				{
					ct_RPr.eastAsianLayout = global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "specVanish")
				{
					ct_RPr.specVanish = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_RPr.oMath = global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "rPrChange")
				{
					ct_RPr.rPrChange = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_RPr;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00026B00 File Offset: 0x00024D00
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.rStyle != null)
			{
				this.rStyle.Write(sw, "rStyle");
			}
			if (this.rFonts != null)
			{
				this.rFonts.Write(sw, "rFonts");
			}
			if (this.b != null)
			{
				this.b.Write(sw, "b");
			}
			if (this.bCs != null)
			{
				this.bCs.Write(sw, "bCs");
			}
			if (this.i != null)
			{
				this.i.Write(sw, "i");
			}
			if (this.iCs != null)
			{
				this.iCs.Write(sw, "iCs");
			}
			if (this.caps != null)
			{
				this.caps.Write(sw, "caps");
			}
			if (this.smallCaps != null)
			{
				this.smallCaps.Write(sw, "smallCaps");
			}
			if (this.strike != null)
			{
				this.strike.Write(sw, "strike");
			}
			if (this.dstrike != null)
			{
				this.dstrike.Write(sw, "dstrike");
			}
			if (this.outline != null)
			{
				this.outline.Write(sw, "outline");
			}
			if (this.shadow != null)
			{
				this.shadow.Write(sw, "shadow");
			}
			if (this.emboss != null)
			{
				this.emboss.Write(sw, "emboss");
			}
			if (this.imprint != null)
			{
				this.imprint.Write(sw, "imprint");
			}
			if (this.noProof != null)
			{
				this.noProof.Write(sw, "noProof");
			}
			if (this.snapToGrid != null)
			{
				this.snapToGrid.Write(sw, "snapToGrid");
			}
			if (this.vanish != null)
			{
				this.vanish.Write(sw, "vanish");
			}
			if (this.webHidden != null)
			{
				this.webHidden.Write(sw, "webHidden");
			}
			if (this.color != null)
			{
				this.color.Write(sw, "color");
			}
			if (this.spacing != null)
			{
				this.spacing.Write(sw, "spacing");
			}
			if (this.w != null)
			{
				this.w.Write(sw, "w");
			}
			if (this.kern != null)
			{
				this.kern.Write(sw, "kern");
			}
			if (this.position != null)
			{
				this.position.Write(sw, "position");
			}
			if (this.sz != null)
			{
				this.sz.Write(sw, "sz");
			}
			if (this.szCs != null)
			{
				this.szCs.Write(sw, "szCs");
			}
			if (this.highlight != null)
			{
				this.highlight.Write(sw, "highlight");
			}
			if (this.u != null)
			{
				this.u.Write(sw, "u");
			}
			if (this.effect != null)
			{
				this.effect.Write(sw, "effect");
			}
			if (this.bdr != null)
			{
				this.bdr.Write(sw, "bdr");
			}
			if (this.shd != null)
			{
				this.shd.Write(sw, "shd");
			}
			if (this.fitText != null)
			{
				this.fitText.Write(sw, "fitText");
			}
			if (this.vertAlign != null)
			{
				this.vertAlign.Write(sw, "vertAlign");
			}
			if (this.rtl != null)
			{
				this.rtl.Write(sw, "rtl");
			}
			if (this.cs != null)
			{
				this.cs.Write(sw, "cs");
			}
			if (this.em != null)
			{
				this.em.Write(sw, "em");
			}
			if (this.lang != null)
			{
				this.lang.Write(sw, "lang");
			}
			if (this.eastAsianLayout != null)
			{
				this.eastAsianLayout.Write(sw, "eastAsianLayout");
			}
			if (this.specVanish != null)
			{
				this.specVanish.Write(sw, "specVanish");
			}
			if (this.oMath != null)
			{
				this.oMath.Write(sw, "oMath");
			}
			if (this.rPrChange != null)
			{
				this.rPrChange.Write(sw, "rPrChange");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00026F22 File Offset: 0x00025122
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String AddNewRStyle()
		{
			this.rStyleField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_String();
			return this.rStyleField;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00026F35 File Offset: 0x00025135
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00026F3D File Offset: 0x0002513D
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String rStyle
		{
			get
			{
				return this.rStyleField;
			}
			set
			{
				this.rStyleField = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00026F46 File Offset: 0x00025146
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00026F4E File Offset: 0x0002514E
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts rFonts
		{
			get
			{
				return this.rFontsField;
			}
			set
			{
				this.rFontsField = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00026F57 File Offset: 0x00025157
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00026F5F File Offset: 0x0002515F
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff b
		{
			get
			{
				return this.bField;
			}
			set
			{
				this.bField = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00026F68 File Offset: 0x00025168
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00026F70 File Offset: 0x00025170
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bCs
		{
			get
			{
				return this.bCsField;
			}
			set
			{
				this.bCsField = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00026F79 File Offset: 0x00025179
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00026F81 File Offset: 0x00025181
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff i
		{
			get
			{
				return this.iField;
			}
			set
			{
				this.iField = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00026F8A File Offset: 0x0002518A
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00026F92 File Offset: 0x00025192
		[global::System.Xml.Serialization.XmlElement(Order = 5)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff iCs
		{
			get
			{
				return this.iCsField;
			}
			set
			{
				this.iCsField = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00026F9B File Offset: 0x0002519B
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00026FA3 File Offset: 0x000251A3
		[global::System.Xml.Serialization.XmlElement(Order = 6)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff caps
		{
			get
			{
				return this.capsField;
			}
			set
			{
				this.capsField = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00026FAC File Offset: 0x000251AC
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00026FB4 File Offset: 0x000251B4
		[global::System.Xml.Serialization.XmlElement(Order = 7)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff smallCaps
		{
			get
			{
				return this.smallCapsField;
			}
			set
			{
				this.smallCapsField = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00026FBD File Offset: 0x000251BD
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00026FC5 File Offset: 0x000251C5
		[global::System.Xml.Serialization.XmlElement(Order = 8)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff strike
		{
			get
			{
				return this.strikeField;
			}
			set
			{
				this.strikeField = value;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00026FCE File Offset: 0x000251CE
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00026FD6 File Offset: 0x000251D6
		[global::System.Xml.Serialization.XmlElement(Order = 9)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dstrike
		{
			get
			{
				return this.dstrikeField;
			}
			set
			{
				this.dstrikeField = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00026FDF File Offset: 0x000251DF
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00026FE7 File Offset: 0x000251E7
		[global::System.Xml.Serialization.XmlElement(Order = 10)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff outline
		{
			get
			{
				return this.outlineField;
			}
			set
			{
				this.outlineField = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00026FF0 File Offset: 0x000251F0
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00026FF8 File Offset: 0x000251F8
		[global::System.Xml.Serialization.XmlElement(Order = 11)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff shadow
		{
			get
			{
				return this.shadowField;
			}
			set
			{
				this.shadowField = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00027001 File Offset: 0x00025201
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00027009 File Offset: 0x00025209
		[global::System.Xml.Serialization.XmlElement(Order = 12)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff emboss
		{
			get
			{
				return this.embossField;
			}
			set
			{
				this.embossField = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00027012 File Offset: 0x00025212
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x0002701A File Offset: 0x0002521A
		[global::System.Xml.Serialization.XmlElement(Order = 13)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff imprint
		{
			get
			{
				return this.imprintField;
			}
			set
			{
				this.imprintField = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00027023 File Offset: 0x00025223
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0002702B File Offset: 0x0002522B
		[global::System.Xml.Serialization.XmlElement(Order = 14)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noProof
		{
			get
			{
				return this.noProofField;
			}
			set
			{
				this.noProofField = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x00027034 File Offset: 0x00025234
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0002703C File Offset: 0x0002523C
		[global::System.Xml.Serialization.XmlElement(Order = 15)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff snapToGrid
		{
			get
			{
				return this.snapToGridField;
			}
			set
			{
				this.snapToGridField = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00027045 File Offset: 0x00025245
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x0002704D File Offset: 0x0002524D
		[global::System.Xml.Serialization.XmlElement(Order = 16)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff vanish
		{
			get
			{
				return this.vanishField;
			}
			set
			{
				this.vanishField = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00027056 File Offset: 0x00025256
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0002705E File Offset: 0x0002525E
		[global::System.Xml.Serialization.XmlElement(Order = 17)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff webHidden
		{
			get
			{
				return this.webHiddenField;
			}
			set
			{
				this.webHiddenField = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00027067 File Offset: 0x00025267
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0002706F File Offset: 0x0002526F
		[global::System.Xml.Serialization.XmlElement(Order = 18)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00027078 File Offset: 0x00025278
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x00027080 File Offset: 0x00025280
		[global::System.Xml.Serialization.XmlElement(Order = 19)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure spacing
		{
			get
			{
				return this.spacingField;
			}
			set
			{
				this.spacingField = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00027089 File Offset: 0x00025289
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x00027091 File Offset: 0x00025291
		[global::System.Xml.Serialization.XmlElement(Order = 20)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale w
		{
			get
			{
				return this.wField;
			}
			set
			{
				this.wField = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0002709A File Offset: 0x0002529A
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x000270A2 File Offset: 0x000252A2
		[global::System.Xml.Serialization.XmlElement(Order = 21)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure kern
		{
			get
			{
				return this.kernField;
			}
			set
			{
				this.kernField = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x000270AB File Offset: 0x000252AB
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x000270B3 File Offset: 0x000252B3
		[global::System.Xml.Serialization.XmlElement(Order = 22)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure position
		{
			get
			{
				return this.positionField;
			}
			set
			{
				this.positionField = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x000270BC File Offset: 0x000252BC
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x000270C4 File Offset: 0x000252C4
		[global::System.Xml.Serialization.XmlElement(Order = 23)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure sz
		{
			get
			{
				return this.szField;
			}
			set
			{
				this.szField = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x000270CD File Offset: 0x000252CD
		// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000270D5 File Offset: 0x000252D5
		[global::System.Xml.Serialization.XmlElement(Order = 24)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure szCs
		{
			get
			{
				return this.szCsField;
			}
			set
			{
				this.szCsField = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x000270DE File Offset: 0x000252DE
		// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000270E6 File Offset: 0x000252E6
		[global::System.Xml.Serialization.XmlElement(Order = 25)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight highlight
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x000270EF File Offset: 0x000252EF
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x000270F7 File Offset: 0x000252F7
		[global::System.Xml.Serialization.XmlElement(Order = 26)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline u
		{
			get
			{
				return this.uField;
			}
			set
			{
				this.uField = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00027100 File Offset: 0x00025300
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00027108 File Offset: 0x00025308
		[global::System.Xml.Serialization.XmlElement(Order = 27)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect effect
		{
			get
			{
				return this.effectField;
			}
			set
			{
				this.effectField = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00027111 File Offset: 0x00025311
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00027119 File Offset: 0x00025319
		[global::System.Xml.Serialization.XmlElement(Order = 28)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bdr
		{
			get
			{
				return this.bdrField;
			}
			set
			{
				this.bdrField = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00027122 File Offset: 0x00025322
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0002712A File Offset: 0x0002532A
		[global::System.Xml.Serialization.XmlElement(Order = 29)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shd
		{
			get
			{
				return this.shdField;
			}
			set
			{
				this.shdField = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00027133 File Offset: 0x00025333
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0002713B File Offset: 0x0002533B
		[global::System.Xml.Serialization.XmlElement(Order = 30)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText fitText
		{
			get
			{
				return this.fitTextField;
			}
			set
			{
				this.fitTextField = value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00027144 File Offset: 0x00025344
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0002714C File Offset: 0x0002534C
		[global::System.Xml.Serialization.XmlElement(Order = 31)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun vertAlign
		{
			get
			{
				return this.vertAlignField;
			}
			set
			{
				this.vertAlignField = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00027155 File Offset: 0x00025355
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x0002715D File Offset: 0x0002535D
		[global::System.Xml.Serialization.XmlElement(Order = 32)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtl
		{
			get
			{
				return this.rtlField;
			}
			set
			{
				this.rtlField = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x00027166 File Offset: 0x00025366
		// (set) Token: 0x06000B5E RID: 2910 RVA: 0x0002716E File Offset: 0x0002536E
		[global::System.Xml.Serialization.XmlElement(Order = 33)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff cs
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

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00027177 File Offset: 0x00025377
		// (set) Token: 0x06000B60 RID: 2912 RVA: 0x0002717F File Offset: 0x0002537F
		[global::System.Xml.Serialization.XmlElement(Order = 34)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em em
		{
			get
			{
				return this.emField;
			}
			set
			{
				this.emField = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00027188 File Offset: 0x00025388
		// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00027190 File Offset: 0x00025390
		[global::System.Xml.Serialization.XmlElement(Order = 35)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language lang
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00027199 File Offset: 0x00025399
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x000271A1 File Offset: 0x000253A1
		[global::System.Xml.Serialization.XmlElement(Order = 36)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout eastAsianLayout
		{
			get
			{
				return this.eastAsianLayoutField;
			}
			set
			{
				this.eastAsianLayoutField = value;
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x000271AA File Offset: 0x000253AA
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x000271B2 File Offset: 0x000253B2
		[global::System.Xml.Serialization.XmlElement(Order = 37)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff specVanish
		{
			get
			{
				return this.specVanishField;
			}
			set
			{
				this.specVanishField = value;
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x000271BB File Offset: 0x000253BB
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x000271C3 File Offset: 0x000253C3
		[global::System.Xml.Serialization.XmlElement(Order = 38)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff oMath
		{
			get
			{
				return this.oMathField;
			}
			set
			{
				this.oMathField = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x000271CC File Offset: 0x000253CC
		// (set) Token: 0x06000B6A RID: 2922 RVA: 0x000271D4 File Offset: 0x000253D4
		[global::System.Xml.Serialization.XmlElement(Order = 39)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange rPrChange
		{
			get
			{
				return this.rPrChangeField;
			}
			set
			{
				this.rPrChangeField = value;
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x000271DD File Offset: 0x000253DD
		public bool IsSetLang()
		{
			return this.langField != null;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x000271E8 File Offset: 0x000253E8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language AddNewLang()
		{
			if (this.langField == null)
			{
				this.langField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language();
			}
			return this.langField;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00027203 File Offset: 0x00025403
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts AddNewRFonts()
		{
			if (this.rFontsField == null)
			{
				this.rFontsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts();
			}
			return this.rFontsField;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0002721E File Offset: 0x0002541E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewB()
		{
			if (this.bField == null)
			{
				this.bField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.bField;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00027239 File Offset: 0x00025439
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewBCs()
		{
			if (this.bCsField == null)
			{
				this.bCsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.bCsField;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00027254 File Offset: 0x00025454
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color AddNewColor()
		{
			if (this.colorField == null)
			{
				this.colorField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color();
			}
			return this.colorField;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002726F File Offset: 0x0002546F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure AddNewSz()
		{
			if (this.szField == null)
			{
				this.szField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure();
			}
			return this.szField;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0002728A File Offset: 0x0002548A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure AddNewSzCs()
		{
			if (this.szCsField == null)
			{
				this.szCsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure();
			}
			return this.szCsField;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000272A5 File Offset: 0x000254A5
		public bool IsSetPosition()
		{
			return this.positionField != null && !string.IsNullOrEmpty(this.positionField.val);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x000272C4 File Offset: 0x000254C4
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure AddNewPosition()
		{
			if (this.positionField == null)
			{
				this.positionField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure();
			}
			return this.positionField;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000272DF File Offset: 0x000254DF
		public bool IsSetB()
		{
			return this.bField != null;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x000272EA File Offset: 0x000254EA
		public bool IsSetI()
		{
			return this.iField != null;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000272F5 File Offset: 0x000254F5
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewI()
		{
			if (this.iField == null)
			{
				this.iField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.iField;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00027310 File Offset: 0x00025510
		public void AddNewNoProof()
		{
			if (this.noProofField == null)
			{
				this.noProofField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00027325 File Offset: 0x00025525
		public bool IsSetU()
		{
			return this.uField != null && this.uField.val != global::NPOI.OpenXmlFormats.Wordprocessing.ST_Underline.none;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00027343 File Offset: 0x00025543
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline AddNewU()
		{
			if (this.uField == null)
			{
				this.uField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline();
			}
			return this.uField;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0002735E File Offset: 0x0002555E
		public bool IsSetStrike()
		{
			return this.strike != null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00027369 File Offset: 0x00025569
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewStrike()
		{
			if (this.strikeField == null)
			{
				this.strikeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.strikeField;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00027384 File Offset: 0x00025584
		public bool IsSetVertAlign()
		{
			return this.vertAlignField != null;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002738F File Offset: 0x0002558F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun AddNewVertAlign()
		{
			if (this.vertAlignField == null)
			{
				this.vertAlignField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun();
			}
			return this.vertAlignField;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000273AA File Offset: 0x000255AA
		public bool IsSetRFonts()
		{
			return this.rFontsField != null;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000273B5 File Offset: 0x000255B5
		public bool IsSetSz()
		{
			return this.szField != null && this.szField.val > 0UL;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000273D0 File Offset: 0x000255D0
		public bool IsSetColor()
		{
			return this.colorField != null && !string.IsNullOrEmpty(this.colorField.val);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000273EF File Offset: 0x000255EF
		public bool IsSetDstrike()
		{
			return this.dstrikeField != null;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000273FA File Offset: 0x000255FA
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewDstrike()
		{
			if (this.dstrikeField == null)
			{
				this.dstrikeField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.dstrikeField;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00027415 File Offset: 0x00025615
		public bool IsSetEmboss()
		{
			return this.embossField != null;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00027420 File Offset: 0x00025620
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewEmboss()
		{
			if (this.embossField == null)
			{
				this.embossField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.embossField;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0002743B File Offset: 0x0002563B
		public bool IsSetImprint()
		{
			return this.imprintField != null;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00027446 File Offset: 0x00025646
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewImprint()
		{
			if (this.imprintField == null)
			{
				this.imprintField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.imprintField;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00027461 File Offset: 0x00025661
		public bool IsSetShadow()
		{
			return this.shadowField != null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0002746C File Offset: 0x0002566C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewShadow()
		{
			if (this.shadowField == null)
			{
				this.shadowField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.shadowField;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00027487 File Offset: 0x00025687
		public bool IsSetCaps()
		{
			return this.capsField != null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00027492 File Offset: 0x00025692
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewCaps()
		{
			if (this.capsField == null)
			{
				this.capsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.capsField;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000274AD File Offset: 0x000256AD
		public bool IsSetSmallCaps()
		{
			return this.smallCapsField != null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000274B8 File Offset: 0x000256B8
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewSmallCaps()
		{
			if (this.smallCapsField == null)
			{
				this.smallCapsField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff();
			}
			return this.smallCapsField;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000274D3 File Offset: 0x000256D3
		public bool IsSetKern()
		{
			return this.kernField != null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000274DE File Offset: 0x000256DE
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure AddNewKern()
		{
			if (this.kernField == null)
			{
				this.kernField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure();
			}
			return this.kernField;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000274F9 File Offset: 0x000256F9
		public bool IsSetSpacing()
		{
			return this.spacingField != null;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00027504 File Offset: 0x00025704
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure AddNewSpacing()
		{
			if (this.spacingField == null)
			{
				this.spacingField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure();
			}
			return this.spacingField;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0002751F File Offset: 0x0002571F
		public bool IsSetHighlight()
		{
			return this.highlightField != null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0002752A File Offset: 0x0002572A
		internal global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight AddNewHighlight()
		{
			this.highlightField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight();
			return this.highlightField;
		}

		// Token: 0x04000A32 RID: 2610
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_String rStyleField;

		// Token: 0x04000A33 RID: 2611
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts rFontsField;

		// Token: 0x04000A34 RID: 2612
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bField;

		// Token: 0x04000A35 RID: 2613
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff bCsField;

		// Token: 0x04000A36 RID: 2614
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff iField;

		// Token: 0x04000A37 RID: 2615
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff iCsField;

		// Token: 0x04000A38 RID: 2616
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff capsField;

		// Token: 0x04000A39 RID: 2617
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff smallCapsField;

		// Token: 0x04000A3A RID: 2618
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff strikeField;

		// Token: 0x04000A3B RID: 2619
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff dstrikeField;

		// Token: 0x04000A3C RID: 2620
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff outlineField;

		// Token: 0x04000A3D RID: 2621
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff shadowField;

		// Token: 0x04000A3E RID: 2622
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff embossField;

		// Token: 0x04000A3F RID: 2623
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff imprintField;

		// Token: 0x04000A40 RID: 2624
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff noProofField;

		// Token: 0x04000A41 RID: 2625
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff snapToGridField;

		// Token: 0x04000A42 RID: 2626
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff vanishField;

		// Token: 0x04000A43 RID: 2627
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff webHiddenField;

		// Token: 0x04000A44 RID: 2628
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color colorField;

		// Token: 0x04000A45 RID: 2629
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure spacingField;

		// Token: 0x04000A46 RID: 2630
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale wField;

		// Token: 0x04000A47 RID: 2631
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure kernField;

		// Token: 0x04000A48 RID: 2632
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure positionField;

		// Token: 0x04000A49 RID: 2633
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure szField;

		// Token: 0x04000A4A RID: 2634
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure szCsField;

		// Token: 0x04000A4B RID: 2635
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight highlightField;

		// Token: 0x04000A4C RID: 2636
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline uField;

		// Token: 0x04000A4D RID: 2637
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect effectField;

		// Token: 0x04000A4E RID: 2638
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border bdrField;

		// Token: 0x04000A4F RID: 2639
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd shdField;

		// Token: 0x04000A50 RID: 2640
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText fitTextField;

		// Token: 0x04000A51 RID: 2641
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun vertAlignField;

		// Token: 0x04000A52 RID: 2642
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff rtlField;

		// Token: 0x04000A53 RID: 2643
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff csField;

		// Token: 0x04000A54 RID: 2644
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em emField;

		// Token: 0x04000A55 RID: 2645
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language langField;

		// Token: 0x04000A56 RID: 2646
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout eastAsianLayoutField;

		// Token: 0x04000A57 RID: 2647
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff specVanishField;

		// Token: 0x04000A58 RID: 2648
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff oMathField;

		// Token: 0x04000A59 RID: 2649
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrChange rPrChangeField;
	}
}
