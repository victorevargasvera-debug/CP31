using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200016C RID: 364
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_RPrOriginal
	{
		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0002A1BF File Offset: 0x000283BF
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0002A1C7 File Offset: 0x000283C7
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure> spacing
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

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0002A1D0 File Offset: 0x000283D0
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0002A1D8 File Offset: 0x000283D8
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun> vertAlign
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

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0002A1E1 File Offset: 0x000283E1
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0002A1E9 File Offset: 0x000283E9
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale> w
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

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002A1F2 File Offset: 0x000283F2
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0002A1FA File Offset: 0x000283FA
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> noProof
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

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0002A203 File Offset: 0x00028403
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0002A20B File Offset: 0x0002840B
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> snapToGrid
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0002A214 File Offset: 0x00028414
		// (set) Token: 0x06000C5F RID: 3167 RVA: 0x0002A21C File Offset: 0x0002841C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language> lang
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

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0002A225 File Offset: 0x00028425
		// (set) Token: 0x06000C61 RID: 3169 RVA: 0x0002A22D File Offset: 0x0002842D
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> kern
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

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0002A236 File Offset: 0x00028436
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x0002A23E File Offset: 0x0002843E
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> outline
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

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0002A247 File Offset: 0x00028447
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x0002A24F File Offset: 0x0002844F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure> position
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

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0002A258 File Offset: 0x00028458
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0002A260 File Offset: 0x00028460
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts> rFonts
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

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0002A269 File Offset: 0x00028469
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x0002A271 File Offset: 0x00028471
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> rStyle
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

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x0002A27A File Offset: 0x0002847A
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x0002A282 File Offset: 0x00028482
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> rtl
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

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0002A28B File Offset: 0x0002848B
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0002A293 File Offset: 0x00028493
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> shadow
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

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x0002A29C File Offset: 0x0002849C
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x0002A2A4 File Offset: 0x000284A4
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> strike
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x0002A2AD File Offset: 0x000284AD
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x0002A2B5 File Offset: 0x000284B5
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd> shd
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

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0002A2BE File Offset: 0x000284BE
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x0002A2C6 File Offset: 0x000284C6
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> sz
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

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0002A2CF File Offset: 0x000284CF
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0002A2D7 File Offset: 0x000284D7
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> szCs
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

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0002A2E0 File Offset: 0x000284E0
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0002A2E8 File Offset: 0x000284E8
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> smallCaps
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

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0002A2F1 File Offset: 0x000284F1
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x0002A2F9 File Offset: 0x000284F9
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline> u
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

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0002A302 File Offset: 0x00028502
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x0002A30A File Offset: 0x0002850A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> vanish
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

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0002A313 File Offset: 0x00028513
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x0002A31B File Offset: 0x0002851B
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> oMath
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

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0002A324 File Offset: 0x00028524
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x0002A32C File Offset: 0x0002852C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> webHidden
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

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0002A335 File Offset: 0x00028535
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x0002A33D File Offset: 0x0002853D
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> specVanish
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

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0002A346 File Offset: 0x00028546
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x0002A34E File Offset: 0x0002854E
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> b
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

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x0002A357 File Offset: 0x00028557
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x0002A35F File Offset: 0x0002855F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> bCs
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

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0002A368 File Offset: 0x00028568
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x0002A370 File Offset: 0x00028570
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border> bdr
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

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x0002A379 File Offset: 0x00028579
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x0002A381 File Offset: 0x00028581
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> caps
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0002A38A File Offset: 0x0002858A
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0002A392 File Offset: 0x00028592
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color> color
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x0002A39B File Offset: 0x0002859B
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x0002A3A3 File Offset: 0x000285A3
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> cs
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

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0002A3AC File Offset: 0x000285AC
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0002A3B4 File Offset: 0x000285B4
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> dstrike
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

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0002A3BD File Offset: 0x000285BD
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x0002A3C5 File Offset: 0x000285C5
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout> eastAsianLayout
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

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0002A3CE File Offset: 0x000285CE
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x0002A3D6 File Offset: 0x000285D6
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect> effect
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

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0002A3DF File Offset: 0x000285DF
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x0002A3E7 File Offset: 0x000285E7
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em> em
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

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0002A3F0 File Offset: 0x000285F0
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x0002A3F8 File Offset: 0x000285F8
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> emboss
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

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x0002A401 File Offset: 0x00028601
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x0002A409 File Offset: 0x00028609
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText> fitText
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

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0002A412 File Offset: 0x00028612
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0002A41A File Offset: 0x0002861A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight> highlight
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

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0002A423 File Offset: 0x00028623
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0002A42B File Offset: 0x0002862B
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> i
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0002A434 File Offset: 0x00028634
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0002A43C File Offset: 0x0002863C
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> iCs
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

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0002A445 File Offset: 0x00028645
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x0002A44D File Offset: 0x0002864D
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> imprint
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

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0002A458 File Offset: 0x00028658
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrOriginal Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrOriginal ct_RPrOriginal = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPrOriginal();
			ct_RPrOriginal.spacing = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure>();
			ct_RPrOriginal.vertAlign = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun>();
			ct_RPrOriginal.w = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale>();
			ct_RPrOriginal.noProof = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.snapToGrid = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.lang = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language>();
			ct_RPrOriginal.kern = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure>();
			ct_RPrOriginal.outline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.position = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure>();
			ct_RPrOriginal.rFonts = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts>();
			ct_RPrOriginal.rStyle = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String>();
			ct_RPrOriginal.rtl = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.shadow = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.strike = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.shd = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd>();
			ct_RPrOriginal.sz = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure>();
			ct_RPrOriginal.szCs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure>();
			ct_RPrOriginal.smallCaps = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.u = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline>();
			ct_RPrOriginal.vanish = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.oMath = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.webHidden = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.specVanish = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.b = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.bCs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.bdr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border>();
			ct_RPrOriginal.caps = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.color = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color>();
			ct_RPrOriginal.cs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.dstrike = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.eastAsianLayout = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout>();
			ct_RPrOriginal.effect = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect>();
			ct_RPrOriginal.em = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em>();
			ct_RPrOriginal.emboss = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.fitText = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText>();
			ct_RPrOriginal.highlight = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight>();
			ct_RPrOriginal.i = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.iCs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_RPrOriginal.imprint = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "spacing")
				{
					ct_RPrOriginal.spacing.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "vertAlign")
				{
					ct_RPrOriginal.vertAlign.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "w")
				{
					ct_RPrOriginal.w.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "noProof")
				{
					ct_RPrOriginal.noProof.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "snapToGrid")
				{
					ct_RPrOriginal.snapToGrid.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "lang")
				{
					ct_RPrOriginal.lang.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "kern")
				{
					ct_RPrOriginal.kern.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "outline")
				{
					ct_RPrOriginal.outline.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "position")
				{
					ct_RPrOriginal.position.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rFonts")
				{
					ct_RPrOriginal.rFonts.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rStyle")
				{
					ct_RPrOriginal.rStyle.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rtl")
				{
					ct_RPrOriginal.rtl.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_RPrOriginal.shadow.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "strike")
				{
					ct_RPrOriginal.strike.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_RPrOriginal.shd.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "sz")
				{
					ct_RPrOriginal.sz.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "szCs")
				{
					ct_RPrOriginal.szCs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "smallCaps")
				{
					ct_RPrOriginal.smallCaps.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "u")
				{
					ct_RPrOriginal.u.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "vanish")
				{
					ct_RPrOriginal.vanish.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_RPrOriginal.oMath.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "webHidden")
				{
					ct_RPrOriginal.webHidden.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "specVanish")
				{
					ct_RPrOriginal.specVanish.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_RPrOriginal.b.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bCs")
				{
					ct_RPrOriginal.bCs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bdr")
				{
					ct_RPrOriginal.bdr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "caps")
				{
					ct_RPrOriginal.caps.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_RPrOriginal.color.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "cs")
				{
					ct_RPrOriginal.cs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "dstrike")
				{
					ct_RPrOriginal.dstrike.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "eastAsianLayout")
				{
					ct_RPrOriginal.eastAsianLayout.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "effect")
				{
					ct_RPrOriginal.effect.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "em")
				{
					ct_RPrOriginal.em.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "emboss")
				{
					ct_RPrOriginal.emboss.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "fitText")
				{
					ct_RPrOriginal.fitText.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "highlight")
				{
					ct_RPrOriginal.highlight.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "i")
				{
					ct_RPrOriginal.i.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "iCs")
				{
					ct_RPrOriginal.iCs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "imprint")
				{
					ct_RPrOriginal.imprint.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_RPrOriginal;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0002ACA8 File Offset: 0x00028EA8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			if (this.spacing != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure ct_SignedTwipsMeasure in this.spacing)
				{
					ct_SignedTwipsMeasure.Write(sw, "spacing");
				}
			}
			if (this.vertAlign != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun ct_VerticalAlignRun in this.vertAlign)
				{
					ct_VerticalAlignRun.Write(sw, "vertAlign");
				}
			}
			if (this.w != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale ct_TextScale in this.w)
				{
					ct_TextScale.Write(sw, "w");
				}
			}
			if (this.noProof != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff in this.noProof)
				{
					ct_OnOff.Write(sw, "noProof");
				}
			}
			if (this.snapToGrid != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff2 in this.snapToGrid)
				{
					ct_OnOff2.Write(sw, "snapToGrid");
				}
			}
			if (this.lang != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language ct_Language in this.lang)
				{
					ct_Language.Write(sw, "lang");
				}
			}
			if (this.kern != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure ct_HpsMeasure in this.kern)
				{
					ct_HpsMeasure.Write(sw, "kern");
				}
			}
			if (this.outline != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff3 in this.outline)
				{
					ct_OnOff3.Write(sw, "outline");
				}
			}
			if (this.position != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure ct_SignedHpsMeasure in this.position)
				{
					ct_SignedHpsMeasure.Write(sw, "position");
				}
			}
			if (this.rFonts != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts ct_Fonts in this.rFonts)
				{
					ct_Fonts.Write(sw, "rFonts");
				}
			}
			if (this.rStyle != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_String ct_String in this.rStyle)
				{
					ct_String.Write(sw, "rStyle");
				}
			}
			if (this.rtl != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff4 in this.rtl)
				{
					ct_OnOff4.Write(sw, "rtl");
				}
			}
			if (this.shadow != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff5 in this.shadow)
				{
					ct_OnOff5.Write(sw, "shadow");
				}
			}
			if (this.strike != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff6 in this.strike)
				{
					ct_OnOff6.Write(sw, "strike");
				}
			}
			if (this.shd != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd ct_Shd in this.shd)
				{
					ct_Shd.Write(sw, "shd");
				}
			}
			if (this.sz != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure ct_HpsMeasure2 in this.sz)
				{
					ct_HpsMeasure2.Write(sw, "sz");
				}
			}
			if (this.szCs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure ct_HpsMeasure3 in this.szCs)
				{
					ct_HpsMeasure3.Write(sw, "szCs");
				}
			}
			if (this.smallCaps != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff7 in this.smallCaps)
				{
					ct_OnOff7.Write(sw, "smallCaps");
				}
			}
			if (this.u != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline ct_Underline in this.u)
				{
					ct_Underline.Write(sw, "u");
				}
			}
			if (this.vanish != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff8 in this.vanish)
				{
					ct_OnOff8.Write(sw, "vanish");
				}
			}
			if (this.oMath != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff9 in this.oMath)
				{
					ct_OnOff9.Write(sw, "oMath");
				}
			}
			if (this.webHidden != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff10 in this.webHidden)
				{
					ct_OnOff10.Write(sw, "webHidden");
				}
			}
			if (this.specVanish != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff11 in this.specVanish)
				{
					ct_OnOff11.Write(sw, "specVanish");
				}
			}
			if (this.b != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff12 in this.b)
				{
					ct_OnOff12.Write(sw, "b");
				}
			}
			if (this.bCs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff13 in this.bCs)
				{
					ct_OnOff13.Write(sw, "bCs");
				}
			}
			if (this.bdr != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border ct_Border in this.bdr)
				{
					ct_Border.Write(sw, "bdr");
				}
			}
			if (this.caps != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff14 in this.caps)
				{
					ct_OnOff14.Write(sw, "caps");
				}
			}
			if (this.color != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color ct_Color in this.color)
				{
					ct_Color.Write(sw, "color");
				}
			}
			if (this.cs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff15 in this.cs)
				{
					ct_OnOff15.Write(sw, "cs");
				}
			}
			if (this.dstrike != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff16 in this.dstrike)
				{
					ct_OnOff16.Write(sw, "dstrike");
				}
			}
			if (this.eastAsianLayout != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout ct_EastAsianLayout in this.eastAsianLayout)
				{
					ct_EastAsianLayout.Write(sw, "eastAsianLayout");
				}
			}
			if (this.effect != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect ct_TextEffect in this.effect)
				{
					ct_TextEffect.Write(sw, "effect");
				}
			}
			if (this.em != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em ct_Em in this.em)
				{
					ct_Em.Write(sw, "em");
				}
			}
			if (this.emboss != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff17 in this.emboss)
				{
					ct_OnOff17.Write(sw, "emboss");
				}
			}
			if (this.fitText != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText ct_FitText in this.fitText)
				{
					ct_FitText.Write(sw, "fitText");
				}
			}
			if (this.highlight != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight ct_Highlight in this.highlight)
				{
					ct_Highlight.Write(sw, "highlight");
				}
			}
			if (this.i != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff18 in this.i)
				{
					ct_OnOff18.Write(sw, "i");
				}
			}
			if (this.iCs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff19 in this.iCs)
				{
					ct_OnOff19.Write(sw, "iCs");
				}
			}
			if (this.imprint != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff20 in this.imprint)
				{
					ct_OnOff20.Write(sw, "imprint");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x04000AD1 RID: 2769
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure> spacingField;

		// Token: 0x04000AD2 RID: 2770
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun> vertAlignField;

		// Token: 0x04000AD3 RID: 2771
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale> wField;

		// Token: 0x04000AD4 RID: 2772
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> noProofField;

		// Token: 0x04000AD5 RID: 2773
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> snapToGridField;

		// Token: 0x04000AD6 RID: 2774
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language> langField;

		// Token: 0x04000AD7 RID: 2775
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> kernField;

		// Token: 0x04000AD8 RID: 2776
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> outlineField;

		// Token: 0x04000AD9 RID: 2777
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure> positionField;

		// Token: 0x04000ADA RID: 2778
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts> rFontsField;

		// Token: 0x04000ADB RID: 2779
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> rStyleField;

		// Token: 0x04000ADC RID: 2780
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> rtlField;

		// Token: 0x04000ADD RID: 2781
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> shadowField;

		// Token: 0x04000ADE RID: 2782
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> strikeField;

		// Token: 0x04000ADF RID: 2783
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd> shdField;

		// Token: 0x04000AE0 RID: 2784
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> szField;

		// Token: 0x04000AE1 RID: 2785
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> szCsField;

		// Token: 0x04000AE2 RID: 2786
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> smallCapsField;

		// Token: 0x04000AE3 RID: 2787
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline> uField;

		// Token: 0x04000AE4 RID: 2788
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> vanishField;

		// Token: 0x04000AE5 RID: 2789
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> oMathField;

		// Token: 0x04000AE6 RID: 2790
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> webHiddenField;

		// Token: 0x04000AE7 RID: 2791
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> specVanishField;

		// Token: 0x04000AE8 RID: 2792
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> bField;

		// Token: 0x04000AE9 RID: 2793
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> bCsField;

		// Token: 0x04000AEA RID: 2794
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border> bdrField;

		// Token: 0x04000AEB RID: 2795
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> capsField;

		// Token: 0x04000AEC RID: 2796
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color> colorField;

		// Token: 0x04000AED RID: 2797
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> csField;

		// Token: 0x04000AEE RID: 2798
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> dstrikeField;

		// Token: 0x04000AEF RID: 2799
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout> eastAsianLayoutField;

		// Token: 0x04000AF0 RID: 2800
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect> effectField;

		// Token: 0x04000AF1 RID: 2801
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em> emField;

		// Token: 0x04000AF2 RID: 2802
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> embossField;

		// Token: 0x04000AF3 RID: 2803
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText> fitTextField;

		// Token: 0x04000AF4 RID: 2804
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight> highlightField;

		// Token: 0x04000AF5 RID: 2805
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> iField;

		// Token: 0x04000AF6 RID: 2806
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> iCsField;

		// Token: 0x04000AF7 RID: 2807
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> imprintField;
	}
}
