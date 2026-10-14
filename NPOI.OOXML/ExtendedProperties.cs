using System;
using NPOI.OpenXmlFormats;

namespace NPOI
{
	// Token: 0x02000007 RID: 7
	public class ExtendedProperties
	{
		// Token: 0x06000066 RID: 102 RVA: 0x000031F0 File Offset: 0x000013F0
		internal ExtendedProperties(global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument props)
		{
			this.props = props;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000031FF File Offset: 0x000013FF
		public global::NPOI.OpenXmlFormats.CT_ExtendedProperties GetUnderlyingProperties()
		{
			return this.props.GetProperties();
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000320C File Offset: 0x0000140C
		public string Template
		{
			get
			{
				return this.props.GetProperties().Template;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000321E File Offset: 0x0000141E
		public string Manager
		{
			get
			{
				return this.props.GetProperties().Manager;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003230 File Offset: 0x00001430
		public string Company
		{
			get
			{
				return this.props.GetProperties().Company;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003242 File Offset: 0x00001442
		public string PresentationFormat
		{
			get
			{
				return this.props.GetProperties().PresentationFormat;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003254 File Offset: 0x00001454
		public string Application
		{
			get
			{
				return this.props.GetProperties().Application;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003266 File Offset: 0x00001466
		public string AppVersion
		{
			get
			{
				return this.props.GetProperties().AppVersion;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003278 File Offset: 0x00001478
		public int Pages
		{
			get
			{
				if (this.props.GetProperties().IsSetPages())
				{
					return this.props.GetProperties().Pages;
				}
				return -1;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000329E File Offset: 0x0000149E
		public int Words
		{
			get
			{
				if (this.props.GetProperties().IsSetWords())
				{
					return this.props.GetProperties().Words;
				}
				return -1;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000032C4 File Offset: 0x000014C4
		public int Characters
		{
			get
			{
				if (this.props.GetProperties().IsSetCharacters())
				{
					return this.props.GetProperties().Characters;
				}
				return -1;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000032EA File Offset: 0x000014EA
		public int CharactersWithSpaces
		{
			get
			{
				if (this.props.GetProperties().IsSetCharactersWithSpaces())
				{
					return this.props.GetProperties().CharactersWithSpaces;
				}
				return -1;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00003310 File Offset: 0x00001510
		public int Lines
		{
			get
			{
				if (this.props.GetProperties().IsSetLines())
				{
					return this.props.GetProperties().Lines;
				}
				return -1;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003336 File Offset: 0x00001536
		public int Paragraphs
		{
			get
			{
				if (this.props.GetProperties().IsSetParagraphs())
				{
					return this.props.GetProperties().Paragraphs;
				}
				return -1;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000335C File Offset: 0x0000155C
		public int Slides
		{
			get
			{
				if (this.props.GetProperties().IsSetSlides())
				{
					return this.props.GetProperties().Slides;
				}
				return -1;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003382 File Offset: 0x00001582
		public int Notes
		{
			get
			{
				if (this.props.GetProperties().IsSetNotes())
				{
					return this.props.GetProperties().Notes;
				}
				return -1;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000033A8 File Offset: 0x000015A8
		public int TotalTime
		{
			get
			{
				if (this.props.GetProperties().IsSetTotalTime())
				{
					return this.props.GetProperties().TotalTime;
				}
				return -1;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000033CE File Offset: 0x000015CE
		public int HiddenSlides
		{
			get
			{
				if (this.props.GetProperties().IsSetHiddenSlides())
				{
					return this.props.GetProperties().HiddenSlides;
				}
				return -1;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000033F4 File Offset: 0x000015F4
		public int MMClips
		{
			get
			{
				if (this.props.GetProperties().IsSetMMClips())
				{
					return this.props.GetProperties().MMClips;
				}
				return -1;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000341A File Offset: 0x0000161A
		public string HyperlinkBase
		{
			get
			{
				return this.props.GetProperties().HyperlinkBase;
			}
		}

		// Token: 0x04000012 RID: 18
		public global::NPOI.OpenXmlFormats.ExtendedPropertiesDocument props;
	}
}
