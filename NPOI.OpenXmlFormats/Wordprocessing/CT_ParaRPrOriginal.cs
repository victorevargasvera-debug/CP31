using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000167 RID: 359
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ParaRPrOriginal
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x000276A7 File Offset: 0x000258A7
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x000276AF File Offset: 0x000258AF
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange ins
		{
			get
			{
				return this.insField;
			}
			set
			{
				this.insField = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x000276B8 File Offset: 0x000258B8
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x000276C0 File Offset: 0x000258C0
		[global::System.Xml.Serialization.XmlElement(Order = 1)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange del
		{
			get
			{
				return this.delField;
			}
			set
			{
				this.delField = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000276C9 File Offset: 0x000258C9
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x000276D1 File Offset: 0x000258D1
		[global::System.Xml.Serialization.XmlElement(Order = 2)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveFrom
		{
			get
			{
				return this.moveFromField;
			}
			set
			{
				this.moveFromField = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x000276DA File Offset: 0x000258DA
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x000276E2 File Offset: 0x000258E2
		[global::System.Xml.Serialization.XmlElement(Order = 3)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveTo
		{
			get
			{
				return this.moveToField;
			}
			set
			{
				this.moveToField = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000276EB File Offset: 0x000258EB
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x000276F3 File Offset: 0x000258F3
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000276FC File Offset: 0x000258FC
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00027704 File Offset: 0x00025904
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0002770D File Offset: 0x0002590D
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00027715 File Offset: 0x00025915
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0002771E File Offset: 0x0002591E
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x00027726 File Offset: 0x00025926
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0002772F File Offset: 0x0002592F
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x00027737 File Offset: 0x00025937
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00027740 File Offset: 0x00025940
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x00027748 File Offset: 0x00025948
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00027751 File Offset: 0x00025951
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x00027759 File Offset: 0x00025959
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x00027762 File Offset: 0x00025962
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0002776A File Offset: 0x0002596A
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00027773 File Offset: 0x00025973
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0002777B File Offset: 0x0002597B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00027784 File Offset: 0x00025984
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0002778C File Offset: 0x0002598C
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00027795 File Offset: 0x00025995
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0002779D File Offset: 0x0002599D
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x000277A6 File Offset: 0x000259A6
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x000277AE File Offset: 0x000259AE
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x000277B7 File Offset: 0x000259B7
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x000277BF File Offset: 0x000259BF
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x000277C8 File Offset: 0x000259C8
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x000277D0 File Offset: 0x000259D0
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x000277D9 File Offset: 0x000259D9
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x000277E1 File Offset: 0x000259E1
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x000277EA File Offset: 0x000259EA
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x000277F2 File Offset: 0x000259F2
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x000277FB File Offset: 0x000259FB
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x00027803 File Offset: 0x00025A03
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0002780C File Offset: 0x00025A0C
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00027814 File Offset: 0x00025A14
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002781D File Offset: 0x00025A1D
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x00027825 File Offset: 0x00025A25
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0002782E File Offset: 0x00025A2E
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x00027836 File Offset: 0x00025A36
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0002783F File Offset: 0x00025A3F
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x00027847 File Offset: 0x00025A47
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00027850 File Offset: 0x00025A50
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00027858 File Offset: 0x00025A58
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00027861 File Offset: 0x00025A61
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00027869 File Offset: 0x00025A69
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00027872 File Offset: 0x00025A72
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0002787A File Offset: 0x00025A7A
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00027883 File Offset: 0x00025A83
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0002788B File Offset: 0x00025A8B
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00027894 File Offset: 0x00025A94
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0002789C File Offset: 0x00025A9C
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x000278A5 File Offset: 0x00025AA5
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x000278AD File Offset: 0x00025AAD
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x000278B6 File Offset: 0x00025AB6
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x000278BE File Offset: 0x00025ABE
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000278C7 File Offset: 0x00025AC7
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x000278CF File Offset: 0x00025ACF
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x000278D8 File Offset: 0x00025AD8
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x000278E0 File Offset: 0x00025AE0
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x000278E9 File Offset: 0x00025AE9
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x000278F1 File Offset: 0x00025AF1
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x000278FA File Offset: 0x00025AFA
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00027902 File Offset: 0x00025B02
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0002790B File Offset: 0x00025B0B
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00027913 File Offset: 0x00025B13
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0002791C File Offset: 0x00025B1C
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00027924 File Offset: 0x00025B24
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0002792D File Offset: 0x00025B2D
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00027935 File Offset: 0x00025B35
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0002793E File Offset: 0x00025B3E
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x00027946 File Offset: 0x00025B46
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0002794F File Offset: 0x00025B4F
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00027957 File Offset: 0x00025B57
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00027960 File Offset: 0x00025B60
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00027968 File Offset: 0x00025B68
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00027971 File Offset: 0x00025B71
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x00027979 File Offset: 0x00025B79
		[global::System.Xml.Serialization.XmlElement(Order = 4)]
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

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00027984 File Offset: 0x00025B84
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrOriginal Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrOriginal ct_ParaRPrOriginal = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_ParaRPrOriginal();
			ct_ParaRPrOriginal.webHidden = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.b = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.bCs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.bdr = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border>();
			ct_ParaRPrOriginal.caps = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.color = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color>();
			ct_ParaRPrOriginal.cs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.dstrike = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.eastAsianLayout = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout>();
			ct_ParaRPrOriginal.effect = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect>();
			ct_ParaRPrOriginal.em = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em>();
			ct_ParaRPrOriginal.emboss = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.fitText = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText>();
			ct_ParaRPrOriginal.highlight = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight>();
			ct_ParaRPrOriginal.i = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.iCs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.imprint = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.kern = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure>();
			ct_ParaRPrOriginal.lang = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language>();
			ct_ParaRPrOriginal.noProof = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.oMath = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.outline = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.position = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure>();
			ct_ParaRPrOriginal.rFonts = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts>();
			ct_ParaRPrOriginal.rStyle = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String>();
			ct_ParaRPrOriginal.rtl = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.shadow = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.shd = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd>();
			ct_ParaRPrOriginal.smallCaps = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.snapToGrid = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.spacing = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure>();
			ct_ParaRPrOriginal.specVanish = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.strike = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.sz = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure>();
			ct_ParaRPrOriginal.szCs = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure>();
			ct_ParaRPrOriginal.u = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline>();
			ct_ParaRPrOriginal.vanish = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>();
			ct_ParaRPrOriginal.vertAlign = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun>();
			ct_ParaRPrOriginal.w = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale>();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "ins")
				{
					ct_ParaRPrOriginal.ins = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "del")
				{
					ct_ParaRPrOriginal.del = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "moveFrom")
				{
					ct_ParaRPrOriginal.moveFrom = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "moveTo")
				{
					ct_ParaRPrOriginal.moveTo = global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "webHidden")
				{
					ct_ParaRPrOriginal.webHidden.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "b")
				{
					ct_ParaRPrOriginal.b.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bCs")
				{
					ct_ParaRPrOriginal.bCs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "bdr")
				{
					ct_ParaRPrOriginal.bdr.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "caps")
				{
					ct_ParaRPrOriginal.caps.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "color")
				{
					ct_ParaRPrOriginal.color.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "cs")
				{
					ct_ParaRPrOriginal.cs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "dstrike")
				{
					ct_ParaRPrOriginal.dstrike.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "eastAsianLayout")
				{
					ct_ParaRPrOriginal.eastAsianLayout.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "effect")
				{
					ct_ParaRPrOriginal.effect.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "em")
				{
					ct_ParaRPrOriginal.em.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "emboss")
				{
					ct_ParaRPrOriginal.emboss.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "fitText")
				{
					ct_ParaRPrOriginal.fitText.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "highlight")
				{
					ct_ParaRPrOriginal.highlight.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "i")
				{
					ct_ParaRPrOriginal.i.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "iCs")
				{
					ct_ParaRPrOriginal.iCs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "imprint")
				{
					ct_ParaRPrOriginal.imprint.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "kern")
				{
					ct_ParaRPrOriginal.kern.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "lang")
				{
					ct_ParaRPrOriginal.lang.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "noProof")
				{
					ct_ParaRPrOriginal.noProof.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "oMath")
				{
					ct_ParaRPrOriginal.oMath.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "outline")
				{
					ct_ParaRPrOriginal.outline.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "position")
				{
					ct_ParaRPrOriginal.position.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rFonts")
				{
					ct_ParaRPrOriginal.rFonts.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rStyle")
				{
					ct_ParaRPrOriginal.rStyle.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "rtl")
				{
					ct_ParaRPrOriginal.rtl.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "shadow")
				{
					ct_ParaRPrOriginal.shadow.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "shd")
				{
					ct_ParaRPrOriginal.shd.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "smallCaps")
				{
					ct_ParaRPrOriginal.smallCaps.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "snapToGrid")
				{
					ct_ParaRPrOriginal.snapToGrid.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "spacing")
				{
					ct_ParaRPrOriginal.spacing.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "specVanish")
				{
					ct_ParaRPrOriginal.specVanish.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "strike")
				{
					ct_ParaRPrOriginal.strike.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "sz")
				{
					ct_ParaRPrOriginal.sz.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "szCs")
				{
					ct_ParaRPrOriginal.szCs.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "u")
				{
					ct_ParaRPrOriginal.u.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "vanish")
				{
					ct_ParaRPrOriginal.vanish.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "vertAlign")
				{
					ct_ParaRPrOriginal.vertAlign.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun.Parse(xmlNode, namespaceManager));
				}
				else if (xmlNode.LocalName == "w")
				{
					ct_ParaRPrOriginal.w.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale.Parse(xmlNode, namespaceManager));
				}
			}
			return ct_ParaRPrOriginal;
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00028264 File Offset: 0x00026464
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}>", nodeName));
			if (this.ins != null)
			{
				this.ins.Write(sw, "ins");
			}
			if (this.del != null)
			{
				this.del.Write(sw, "del");
			}
			if (this.moveFrom != null)
			{
				this.moveFrom.Write(sw, "moveFrom");
			}
			if (this.moveTo != null)
			{
				this.moveTo.Write(sw, "moveTo");
			}
			if (this.webHidden != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff in this.webHidden)
				{
					ct_OnOff.Write(sw, "webHidden");
				}
			}
			if (this.b != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff2 in this.b)
				{
					ct_OnOff2.Write(sw, "b");
				}
			}
			if (this.bCs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff3 in this.bCs)
				{
					ct_OnOff3.Write(sw, "bCs");
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
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff4 in this.caps)
				{
					ct_OnOff4.Write(sw, "caps");
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
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff5 in this.cs)
				{
					ct_OnOff5.Write(sw, "cs");
				}
			}
			if (this.dstrike != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff6 in this.dstrike)
				{
					ct_OnOff6.Write(sw, "dstrike");
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
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff7 in this.emboss)
				{
					ct_OnOff7.Write(sw, "emboss");
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
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff8 in this.i)
				{
					ct_OnOff8.Write(sw, "i");
				}
			}
			if (this.iCs != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff9 in this.iCs)
				{
					ct_OnOff9.Write(sw, "iCs");
				}
			}
			if (this.imprint != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff10 in this.imprint)
				{
					ct_OnOff10.Write(sw, "imprint");
				}
			}
			if (this.kern != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure ct_HpsMeasure in this.kern)
				{
					ct_HpsMeasure.Write(sw, "kern");
				}
			}
			if (this.lang != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language ct_Language in this.lang)
				{
					ct_Language.Write(sw, "lang");
				}
			}
			if (this.noProof != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff11 in this.noProof)
				{
					ct_OnOff11.Write(sw, "noProof");
				}
			}
			if (this.oMath != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff12 in this.oMath)
				{
					ct_OnOff12.Write(sw, "oMath");
				}
			}
			if (this.outline != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff13 in this.outline)
				{
					ct_OnOff13.Write(sw, "outline");
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
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff14 in this.rtl)
				{
					ct_OnOff14.Write(sw, "rtl");
				}
			}
			if (this.shadow != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff15 in this.shadow)
				{
					ct_OnOff15.Write(sw, "shadow");
				}
			}
			if (this.shd != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd ct_Shd in this.shd)
				{
					ct_Shd.Write(sw, "shd");
				}
			}
			if (this.smallCaps != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff16 in this.smallCaps)
				{
					ct_OnOff16.Write(sw, "smallCaps");
				}
			}
			if (this.snapToGrid != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff17 in this.snapToGrid)
				{
					ct_OnOff17.Write(sw, "snapToGrid");
				}
			}
			if (this.spacing != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure ct_SignedTwipsMeasure in this.spacing)
				{
					ct_SignedTwipsMeasure.Write(sw, "spacing");
				}
			}
			if (this.specVanish != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff18 in this.specVanish)
				{
					ct_OnOff18.Write(sw, "specVanish");
				}
			}
			if (this.strike != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff19 in this.strike)
				{
					ct_OnOff19.Write(sw, "strike");
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
			if (this.u != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline ct_Underline in this.u)
				{
					ct_Underline.Write(sw, "u");
				}
			}
			if (this.vanish != null)
			{
				foreach (global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff ct_OnOff20 in this.vanish)
				{
					ct_OnOff20.Write(sw, "vanish");
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
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x04000A5B RID: 2651
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange insField;

		// Token: 0x04000A5C RID: 2652
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange delField;

		// Token: 0x04000A5D RID: 2653
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveFromField;

		// Token: 0x04000A5E RID: 2654
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrackChange moveToField;

		// Token: 0x04000A5F RID: 2655
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> webHiddenField;

		// Token: 0x04000A60 RID: 2656
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> bField;

		// Token: 0x04000A61 RID: 2657
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> bCsField;

		// Token: 0x04000A62 RID: 2658
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Border> bdrField;

		// Token: 0x04000A63 RID: 2659
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> capsField;

		// Token: 0x04000A64 RID: 2660
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Color> colorField;

		// Token: 0x04000A65 RID: 2661
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> csField;

		// Token: 0x04000A66 RID: 2662
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> dstrikeField;

		// Token: 0x04000A67 RID: 2663
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_EastAsianLayout> eastAsianLayoutField;

		// Token: 0x04000A68 RID: 2664
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextEffect> effectField;

		// Token: 0x04000A69 RID: 2665
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Em> emField;

		// Token: 0x04000A6A RID: 2666
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> embossField;

		// Token: 0x04000A6B RID: 2667
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FitText> fitTextField;

		// Token: 0x04000A6C RID: 2668
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Highlight> highlightField;

		// Token: 0x04000A6D RID: 2669
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> iField;

		// Token: 0x04000A6E RID: 2670
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> iCsField;

		// Token: 0x04000A6F RID: 2671
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> imprintField;

		// Token: 0x04000A70 RID: 2672
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> kernField;

		// Token: 0x04000A71 RID: 2673
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Language> langField;

		// Token: 0x04000A72 RID: 2674
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> noProofField;

		// Token: 0x04000A73 RID: 2675
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> oMathField;

		// Token: 0x04000A74 RID: 2676
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> outlineField;

		// Token: 0x04000A75 RID: 2677
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedHpsMeasure> positionField;

		// Token: 0x04000A76 RID: 2678
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Fonts> rFontsField;

		// Token: 0x04000A77 RID: 2679
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String> rStyleField;

		// Token: 0x04000A78 RID: 2680
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> rtlField;

		// Token: 0x04000A79 RID: 2681
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> shadowField;

		// Token: 0x04000A7A RID: 2682
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Shd> shdField;

		// Token: 0x04000A7B RID: 2683
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> smallCapsField;

		// Token: 0x04000A7C RID: 2684
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> snapToGridField;

		// Token: 0x04000A7D RID: 2685
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SignedTwipsMeasure> spacingField;

		// Token: 0x04000A7E RID: 2686
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> specVanishField;

		// Token: 0x04000A7F RID: 2687
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> strikeField;

		// Token: 0x04000A80 RID: 2688
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> szField;

		// Token: 0x04000A81 RID: 2689
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_HpsMeasure> szCsField;

		// Token: 0x04000A82 RID: 2690
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Underline> uField;

		// Token: 0x04000A83 RID: 2691
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> vanishField;

		// Token: 0x04000A84 RID: 2692
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_VerticalAlignRun> vertAlignField;

		// Token: 0x04000A85 RID: 2693
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_TextScale> wField;
	}
}
