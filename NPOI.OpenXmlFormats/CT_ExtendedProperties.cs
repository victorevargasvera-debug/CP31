using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200000E RID: 14
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties")]
	[global::System.Xml.Serialization.XmlRoot("Properties", Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/extended-properties", IsNullable = true)]
	[global::System.Serializable]
	public class CT_ExtendedProperties
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000026A8 File Offset: 0x000008A8
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000026B0 File Offset: 0x000008B0
		[global::System.Xml.Serialization.XmlElement]
		public string Template
		{
			get
			{
				return this.templateField;
			}
			set
			{
				this.templateField = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000026B9 File Offset: 0x000008B9
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000026C1 File Offset: 0x000008C1
		[global::System.Xml.Serialization.XmlElement]
		public string Manager
		{
			get
			{
				return this.managerField;
			}
			set
			{
				this.managerField = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000026CA File Offset: 0x000008CA
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000026D2 File Offset: 0x000008D2
		[global::System.Xml.Serialization.XmlElement]
		public string Company
		{
			get
			{
				return this.companyField;
			}
			set
			{
				this.companyField = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000026DB File Offset: 0x000008DB
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000026E3 File Offset: 0x000008E3
		[global::System.Xml.Serialization.XmlElement]
		public int Pages
		{
			get
			{
				return this.pagesField;
			}
			set
			{
				this.pagesField = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000026EC File Offset: 0x000008EC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000026F4 File Offset: 0x000008F4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool PagesSpecified
		{
			get
			{
				return this.pagesFieldSpecified;
			}
			set
			{
				this.pagesFieldSpecified = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000026FD File Offset: 0x000008FD
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002705 File Offset: 0x00000905
		[global::System.Xml.Serialization.XmlElement]
		public int Words
		{
			get
			{
				return this.wordsField;
			}
			set
			{
				this.wordsField = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000270E File Offset: 0x0000090E
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002716 File Offset: 0x00000916
		[global::System.Xml.Serialization.XmlIgnore]
		public bool WordsSpecified
		{
			get
			{
				return this.wordsFieldSpecified;
			}
			set
			{
				this.wordsFieldSpecified = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000271F File Offset: 0x0000091F
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002727 File Offset: 0x00000927
		[global::System.Xml.Serialization.XmlElement]
		public int Characters
		{
			get
			{
				return this.charactersField;
			}
			set
			{
				this.charactersField = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002738 File Offset: 0x00000938
		[global::System.Xml.Serialization.XmlIgnore]
		public bool CharactersSpecified
		{
			get
			{
				return this.charactersFieldSpecified;
			}
			set
			{
				this.charactersFieldSpecified = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002741 File Offset: 0x00000941
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002749 File Offset: 0x00000949
		[global::System.Xml.Serialization.XmlElement]
		public string PresentationFormat
		{
			get
			{
				return this.presentationFormatField;
			}
			set
			{
				this.presentationFormatField = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002752 File Offset: 0x00000952
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000275A File Offset: 0x0000095A
		[global::System.Xml.Serialization.XmlElement]
		public int Lines
		{
			get
			{
				return this.linesField;
			}
			set
			{
				this.linesField = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002763 File Offset: 0x00000963
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000276B File Offset: 0x0000096B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool LinesSpecified
		{
			get
			{
				return this.linesFieldSpecified;
			}
			set
			{
				this.linesFieldSpecified = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002774 File Offset: 0x00000974
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000277C File Offset: 0x0000097C
		[global::System.Xml.Serialization.XmlElement]
		public int Paragraphs
		{
			get
			{
				return this.paragraphsField;
			}
			set
			{
				this.paragraphsField = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002785 File Offset: 0x00000985
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000278D File Offset: 0x0000098D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool ParagraphsSpecified
		{
			get
			{
				return this.paragraphsFieldSpecified;
			}
			set
			{
				this.paragraphsFieldSpecified = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002796 File Offset: 0x00000996
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000279E File Offset: 0x0000099E
		[global::System.Xml.Serialization.XmlElement]
		public int Slides
		{
			get
			{
				return this.slidesField;
			}
			set
			{
				this.slidesField = value;
				this.slidesFieldSpecified = true;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000027AE File Offset: 0x000009AE
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000027B6 File Offset: 0x000009B6
		[global::System.Xml.Serialization.XmlIgnore]
		public bool SlidesSpecified
		{
			get
			{
				return this.slidesFieldSpecified;
			}
			set
			{
				this.slidesFieldSpecified = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000027BF File Offset: 0x000009BF
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000027C7 File Offset: 0x000009C7
		[global::System.Xml.Serialization.XmlElement]
		public int Notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
				this.notesFieldSpecified = true;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000027D7 File Offset: 0x000009D7
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000027DF File Offset: 0x000009DF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool NotesSpecified
		{
			get
			{
				return this.notesFieldSpecified;
			}
			set
			{
				this.notesFieldSpecified = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000027E8 File Offset: 0x000009E8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000027F0 File Offset: 0x000009F0
		[global::System.Xml.Serialization.XmlElement]
		public int TotalTime
		{
			get
			{
				return this.totalTimeField;
			}
			set
			{
				this.totalTimeField = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000027F9 File Offset: 0x000009F9
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002801 File Offset: 0x00000A01
		[global::System.Xml.Serialization.XmlIgnore]
		public bool TotalTimeSpecified
		{
			get
			{
				return this.totalTimeFieldSpecified;
			}
			set
			{
				this.totalTimeFieldSpecified = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000280A File Offset: 0x00000A0A
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002812 File Offset: 0x00000A12
		[global::System.Xml.Serialization.XmlElement]
		public int HiddenSlides
		{
			get
			{
				return this.hiddenSlidesField;
			}
			set
			{
				this.hiddenSlidesField = value;
				this.hiddenSlidesFieldSpecified = true;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002822 File Offset: 0x00000A22
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000282A File Offset: 0x00000A2A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool HiddenSlidesSpecified
		{
			get
			{
				return this.hiddenSlidesFieldSpecified;
			}
			set
			{
				this.hiddenSlidesFieldSpecified = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002833 File Offset: 0x00000A33
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000283B File Offset: 0x00000A3B
		[global::System.Xml.Serialization.XmlElement]
		public int MMClips
		{
			get
			{
				return this.mMClipsField;
			}
			set
			{
				this.mMClipsField = value;
				this.mMClipsFieldSpecified = true;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000284B File Offset: 0x00000A4B
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002853 File Offset: 0x00000A53
		[global::System.Xml.Serialization.XmlIgnore]
		public bool MMClipsSpecified
		{
			get
			{
				return this.mMClipsFieldSpecified;
			}
			set
			{
				this.mMClipsFieldSpecified = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000285C File Offset: 0x00000A5C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002864 File Offset: 0x00000A64
		[global::System.Xml.Serialization.XmlElement]
		public bool ScaleCrop
		{
			get
			{
				return this.scaleCropField;
			}
			set
			{
				this.scaleCropField = value;
				this.scaleCropFieldSpecified = true;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002874 File Offset: 0x00000A74
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000287C File Offset: 0x00000A7C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool ScaleCropSpecified
		{
			get
			{
				return this.scaleCropFieldSpecified;
			}
			set
			{
				this.scaleCropFieldSpecified = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002885 File Offset: 0x00000A85
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000288D File Offset: 0x00000A8D
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.CT_VectorVariant HeadingPairs
		{
			get
			{
				return this.headingPairsField;
			}
			set
			{
				this.headingPairsField = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002896 File Offset: 0x00000A96
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000289E File Offset: 0x00000A9E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.CT_VectorLpstr TitlesOfParts
		{
			get
			{
				return this.titlesOfPartsField;
			}
			set
			{
				this.titlesOfPartsField = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x000028A7 File Offset: 0x00000AA7
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000028AF File Offset: 0x00000AAF
		[global::System.Xml.Serialization.XmlElement]
		public bool LinksUpToDate
		{
			get
			{
				return this.linksUpToDateField;
			}
			set
			{
				this.linksUpToDateField = value;
				this.linksUpToDateFieldSpecified = true;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000028BF File Offset: 0x00000ABF
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000028C7 File Offset: 0x00000AC7
		[global::System.Xml.Serialization.XmlIgnore]
		public bool LinksUpToDateSpecified
		{
			get
			{
				return this.linksUpToDateFieldSpecified;
			}
			set
			{
				this.linksUpToDateFieldSpecified = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000028D0 File Offset: 0x00000AD0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000028D8 File Offset: 0x00000AD8
		[global::System.Xml.Serialization.XmlElement]
		public int CharactersWithSpaces
		{
			get
			{
				return this.charactersWithSpacesField;
			}
			set
			{
				this.charactersWithSpacesField = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000028E1 File Offset: 0x00000AE1
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000028E9 File Offset: 0x00000AE9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool CharactersWithSpacesSpecified
		{
			get
			{
				return this.charactersWithSpacesFieldSpecified;
			}
			set
			{
				this.charactersWithSpacesFieldSpecified = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000028F2 File Offset: 0x00000AF2
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000028FA File Offset: 0x00000AFA
		[global::System.Xml.Serialization.XmlElement]
		public bool SharedDoc
		{
			get
			{
				return this.sharedDocField;
			}
			set
			{
				this.sharedDocField = value;
				this.sharedDocFieldSpecified = true;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000290A File Offset: 0x00000B0A
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002912 File Offset: 0x00000B12
		[global::System.Xml.Serialization.XmlIgnore]
		public bool SharedDocSpecified
		{
			get
			{
				return this.sharedDocFieldSpecified;
			}
			set
			{
				this.sharedDocFieldSpecified = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000291B File Offset: 0x00000B1B
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002923 File Offset: 0x00000B23
		[global::System.Xml.Serialization.XmlElement]
		public string HyperlinkBase
		{
			get
			{
				return this.hyperlinkBaseField;
			}
			set
			{
				this.hyperlinkBaseField = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000292C File Offset: 0x00000B2C
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002934 File Offset: 0x00000B34
		public global::NPOI.OpenXmlFormats.CT_VectorVariant HLinks
		{
			get
			{
				return this.hLinksField;
			}
			set
			{
				this.hLinksField = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000293D File Offset: 0x00000B3D
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002945 File Offset: 0x00000B45
		[global::System.Xml.Serialization.XmlElement]
		public bool HyperlinksChanged
		{
			get
			{
				return this.hyperlinksChangedField;
			}
			set
			{
				this.hyperlinksChangedField = value;
				this.hyperlinksChangedFieldSpecified = true;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002955 File Offset: 0x00000B55
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000295D File Offset: 0x00000B5D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool HyperlinksChangedSpecified
		{
			get
			{
				return this.hyperlinksChangedFieldSpecified;
			}
			set
			{
				this.hyperlinksChangedFieldSpecified = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002966 File Offset: 0x00000B66
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000296E File Offset: 0x00000B6E
		[global::System.Xml.Serialization.XmlElement]
		public global::NPOI.OpenXmlFormats.CT_DigSigBlob DigSig
		{
			get
			{
				return this.digSigField;
			}
			set
			{
				this.digSigField = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002977 File Offset: 0x00000B77
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000297F File Offset: 0x00000B7F
		[global::System.Xml.Serialization.XmlElement]
		public string Application
		{
			get
			{
				return this.applicationField;
			}
			set
			{
				this.applicationField = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002990 File Offset: 0x00000B90
		[global::System.Xml.Serialization.XmlElement]
		public string AppVersion
		{
			get
			{
				return this.appVersionField;
			}
			set
			{
				this.appVersionField = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002999 File Offset: 0x00000B99
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000029A1 File Offset: 0x00000BA1
		[global::System.Xml.Serialization.XmlElement]
		public int DocSecurity
		{
			get
			{
				return this.docSecurityField;
			}
			set
			{
				this.docSecurityField = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000029AA File Offset: 0x00000BAA
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000029B2 File Offset: 0x00000BB2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool DocSecuritySpecified
		{
			get
			{
				return this.docSecurityFieldSpecified;
			}
			set
			{
				this.docSecurityFieldSpecified = value;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000029BC File Offset: 0x00000BBC
		public global::NPOI.OpenXmlFormats.CT_ExtendedProperties Copy()
		{
			return new global::NPOI.OpenXmlFormats.CT_ExtendedProperties
			{
				applicationField = this.applicationField,
				appVersionField = this.appVersionField,
				charactersField = this.charactersField,
				charactersWithSpacesField = this.charactersWithSpacesField,
				companyField = this.companyField,
				digSigField = this.digSigField,
				docSecurityField = this.docSecurityField,
				headingPairsField = this.headingPairsField,
				hiddenSlidesField = this.hiddenSlidesField,
				hLinksField = this.hLinksField,
				hyperlinkBaseField = this.hyperlinkBaseField,
				hyperlinksChangedField = this.hyperlinksChangedField,
				hyperlinksChangedFieldSpecified = this.hyperlinksChangedFieldSpecified,
				linesField = this.linesField,
				linksUpToDateFieldSpecified = this.linksUpToDateFieldSpecified,
				linksUpToDateField = this.linksUpToDateField,
				managerField = this.managerField,
				mMClipsField = this.mMClipsField,
				mMClipsFieldSpecified = this.mMClipsFieldSpecified,
				notesField = this.notesField,
				notesFieldSpecified = this.notesFieldSpecified,
				pagesField = this.pagesField,
				pagesFieldSpecified = this.pagesFieldSpecified,
				paragraphsField = this.paragraphsField,
				paragraphsFieldSpecified = this.paragraphsFieldSpecified,
				presentationFormatField = this.presentationFormatField,
				scaleCropField = this.scaleCropField,
				scaleCropFieldSpecified = this.scaleCropFieldSpecified,
				sharedDocField = this.sharedDocField,
				sharedDocFieldSpecified = this.sharedDocFieldSpecified,
				slidesField = this.slidesField,
				templateField = this.templateField,
				titlesOfPartsField = this.titlesOfPartsField,
				totalTimeField = this.totalTimeField,
				totalTimeFieldSpecified = this.totalTimeFieldSpecified,
				wordsField = this.wordsField
			};
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000024E5 File Offset: 0x000006E5
		public global::NPOI.OpenXmlFormats.CT_VectorVariant GetHeadingPairs()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002822 File Offset: 0x00000A22
		public bool IsSetHiddenSlides()
		{
			return this.hiddenSlidesFieldSpecified;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002B7E File Offset: 0x00000D7E
		public bool IsSetHLinks()
		{
			return this.hLinksField != null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002955 File Offset: 0x00000B55
		public bool IsSetHyperlinksChanged()
		{
			return this.hyperlinksChangedFieldSpecified;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000028BF File Offset: 0x00000ABF
		public bool IsSetLinksUpToDate()
		{
			return this.linksUpToDateFieldSpecified;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000284B File Offset: 0x00000A4B
		public bool IsSetMMClips()
		{
			return this.mMClipsFieldSpecified;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000027D7 File Offset: 0x000009D7
		public bool IsSetNotes()
		{
			return this.notesFieldSpecified;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002874 File Offset: 0x00000A74
		public bool IsSetScaleCrop()
		{
			return this.scaleCropFieldSpecified;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000290A File Offset: 0x00000B0A
		public bool IsSetSharedDoc()
		{
			return this.sharedDocFieldSpecified;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000027AE File Offset: 0x000009AE
		public bool IsSetSlides()
		{
			return this.slidesFieldSpecified;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000024E5 File Offset: 0x000006E5
		public bool IsSetHyperlinkBase()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000027F9 File Offset: 0x000009F9
		public bool IsSetTotalTime()
		{
			return this.totalTimeFieldSpecified;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002785 File Offset: 0x00000985
		public bool IsSetParagraphs()
		{
			return this.paragraphsFieldSpecified;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002763 File Offset: 0x00000963
		public bool IsSetLines()
		{
			return this.linesFieldSpecified;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002B89 File Offset: 0x00000D89
		public bool IsSetTemplate()
		{
			return this.templateField != null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002B94 File Offset: 0x00000D94
		public bool IsSetManager()
		{
			return this.managerField != null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002B9F File Offset: 0x00000D9F
		public bool IsSetCompany()
		{
			return this.companyField != null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002BAA File Offset: 0x00000DAA
		public bool IsSetPresentationFormat()
		{
			return this.presentationFormatField != null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002BB5 File Offset: 0x00000DB5
		public bool IsSetApplication()
		{
			return this.applicationField != null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002BC0 File Offset: 0x00000DC0
		public bool IsSetAppVersion()
		{
			return this.appVersionField != null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000270E File Offset: 0x0000090E
		public bool IsSetWords()
		{
			return this.wordsFieldSpecified;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000026EC File Offset: 0x000008EC
		public bool IsSetPages()
		{
			return this.pagesFieldSpecified;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002730 File Offset: 0x00000930
		public bool IsSetCharacters()
		{
			return this.charactersFieldSpecified;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000028E1 File Offset: 0x00000AE1
		public bool IsSetCharactersWithSpaces()
		{
			return this.charactersWithSpacesFieldSpecified;
		}

		// Token: 0x0400004C RID: 76
		private string templateField;

		// Token: 0x0400004D RID: 77
		private string managerField;

		// Token: 0x0400004E RID: 78
		private string companyField;

		// Token: 0x0400004F RID: 79
		private int pagesField;

		// Token: 0x04000050 RID: 80
		private bool pagesFieldSpecified;

		// Token: 0x04000051 RID: 81
		private int wordsField;

		// Token: 0x04000052 RID: 82
		private bool wordsFieldSpecified;

		// Token: 0x04000053 RID: 83
		private int charactersField;

		// Token: 0x04000054 RID: 84
		private bool charactersFieldSpecified;

		// Token: 0x04000055 RID: 85
		private string presentationFormatField;

		// Token: 0x04000056 RID: 86
		private int linesField;

		// Token: 0x04000057 RID: 87
		private bool linesFieldSpecified;

		// Token: 0x04000058 RID: 88
		private int paragraphsField;

		// Token: 0x04000059 RID: 89
		private bool paragraphsFieldSpecified;

		// Token: 0x0400005A RID: 90
		private int slidesField;

		// Token: 0x0400005B RID: 91
		private bool slidesFieldSpecified;

		// Token: 0x0400005C RID: 92
		private int notesField;

		// Token: 0x0400005D RID: 93
		private bool notesFieldSpecified;

		// Token: 0x0400005E RID: 94
		private int totalTimeField;

		// Token: 0x0400005F RID: 95
		private bool totalTimeFieldSpecified;

		// Token: 0x04000060 RID: 96
		private int hiddenSlidesField;

		// Token: 0x04000061 RID: 97
		private bool hiddenSlidesFieldSpecified;

		// Token: 0x04000062 RID: 98
		private int mMClipsField;

		// Token: 0x04000063 RID: 99
		private bool mMClipsFieldSpecified;

		// Token: 0x04000064 RID: 100
		private bool scaleCropField;

		// Token: 0x04000065 RID: 101
		private bool scaleCropFieldSpecified;

		// Token: 0x04000066 RID: 102
		private global::NPOI.OpenXmlFormats.CT_VectorVariant headingPairsField;

		// Token: 0x04000067 RID: 103
		private global::NPOI.OpenXmlFormats.CT_VectorLpstr titlesOfPartsField;

		// Token: 0x04000068 RID: 104
		private bool linksUpToDateField;

		// Token: 0x04000069 RID: 105
		private bool linksUpToDateFieldSpecified;

		// Token: 0x0400006A RID: 106
		private int charactersWithSpacesField;

		// Token: 0x0400006B RID: 107
		private bool charactersWithSpacesFieldSpecified;

		// Token: 0x0400006C RID: 108
		private bool sharedDocField;

		// Token: 0x0400006D RID: 109
		private bool sharedDocFieldSpecified;

		// Token: 0x0400006E RID: 110
		private string hyperlinkBaseField;

		// Token: 0x0400006F RID: 111
		private global::NPOI.OpenXmlFormats.CT_VectorVariant hLinksField;

		// Token: 0x04000070 RID: 112
		private bool hyperlinksChangedField;

		// Token: 0x04000071 RID: 113
		private bool hyperlinksChangedFieldSpecified;

		// Token: 0x04000072 RID: 114
		private global::NPOI.OpenXmlFormats.CT_DigSigBlob digSigField;

		// Token: 0x04000073 RID: 115
		private string applicationField;

		// Token: 0x04000074 RID: 116
		private string appVersionField;

		// Token: 0x04000075 RID: 117
		private int docSecurityField;

		// Token: 0x04000076 RID: 118
		private bool docSecurityFieldSpecified;
	}
}
