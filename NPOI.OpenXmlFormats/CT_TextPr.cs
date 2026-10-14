using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000034 RID: 52
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextPr
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x00003918 File Offset: 0x00001B18
		public CT_TextPr()
		{
			this.promptField = true;
			this.fileTypeField = global::NPOI.OpenXmlFormats.ST_FileType.win;
			this.codePageField = 1252U;
			this.firstRowField = 1U;
			this.sourceFileField = "";
			this.delimitedField = true;
			this.decimalField = ".";
			this.thousandsField = ",";
			this.tabField = true;
			this.spaceField = false;
			this.commaField = false;
			this.semicolonField = false;
			this.consecutiveField = false;
			this.qualifierField = global::NPOI.OpenXmlFormats.ST_Qualifier.doubleQuote;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000399D File Offset: 0x00001B9D
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000039A5 File Offset: 0x00001BA5
		public global::NPOI.OpenXmlFormats.CT_TextFields textFields
		{
			get
			{
				return this.textFieldsField;
			}
			set
			{
				this.textFieldsField = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000039AE File Offset: 0x00001BAE
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000039B6 File Offset: 0x00001BB6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool prompt
		{
			get
			{
				return this.promptField;
			}
			set
			{
				this.promptField = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000039BF File Offset: 0x00001BBF
		// (set) Token: 0x060001EB RID: 491 RVA: 0x000039C7 File Offset: 0x00001BC7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.ST_FileType.win)]
		public global::NPOI.OpenXmlFormats.ST_FileType fileType
		{
			get
			{
				return this.fileTypeField;
			}
			set
			{
				this.fileTypeField = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000039D0 File Offset: 0x00001BD0
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000039D8 File Offset: 0x00001BD8
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1252")]
		public uint codePage
		{
			get
			{
				return this.codePageField;
			}
			set
			{
				this.codePageField = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000039E1 File Offset: 0x00001BE1
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000039E9 File Offset: 0x00001BE9
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(uint), "1")]
		public uint firstRow
		{
			get
			{
				return this.firstRowField;
			}
			set
			{
				this.firstRowField = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000039F2 File Offset: 0x00001BF2
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000039FA File Offset: 0x00001BFA
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue("")]
		public string sourceFile
		{
			get
			{
				return this.sourceFileField;
			}
			set
			{
				this.sourceFileField = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00003A03 File Offset: 0x00001C03
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00003A0B File Offset: 0x00001C0B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool delimited
		{
			get
			{
				return this.delimitedField;
			}
			set
			{
				this.delimitedField = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00003A14 File Offset: 0x00001C14
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00003A1C File Offset: 0x00001C1C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(".")]
		public string @decimal
		{
			get
			{
				return this.decimalField;
			}
			set
			{
				this.decimalField = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00003A25 File Offset: 0x00001C25
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00003A2D File Offset: 0x00001C2D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(",")]
		public string thousands
		{
			get
			{
				return this.thousandsField;
			}
			set
			{
				this.thousandsField = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00003A36 File Offset: 0x00001C36
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00003A3E File Offset: 0x00001C3E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool tab
		{
			get
			{
				return this.tabField;
			}
			set
			{
				this.tabField = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00003A47 File Offset: 0x00001C47
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00003A4F File Offset: 0x00001C4F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool space
		{
			get
			{
				return this.spaceField;
			}
			set
			{
				this.spaceField = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00003A58 File Offset: 0x00001C58
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00003A60 File Offset: 0x00001C60
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool comma
		{
			get
			{
				return this.commaField;
			}
			set
			{
				this.commaField = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00003A69 File Offset: 0x00001C69
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00003A71 File Offset: 0x00001C71
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool semicolon
		{
			get
			{
				return this.semicolonField;
			}
			set
			{
				this.semicolonField = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00003A7A File Offset: 0x00001C7A
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00003A82 File Offset: 0x00001C82
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool consecutive
		{
			get
			{
				return this.consecutiveField;
			}
			set
			{
				this.consecutiveField = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00003A8B File Offset: 0x00001C8B
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00003A93 File Offset: 0x00001C93
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.ST_Qualifier.doubleQuote)]
		public global::NPOI.OpenXmlFormats.ST_Qualifier qualifier
		{
			get
			{
				return this.qualifierField;
			}
			set
			{
				this.qualifierField = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00003A9C File Offset: 0x00001C9C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00003AA4 File Offset: 0x00001CA4
		[global::System.Xml.Serialization.XmlAttribute]
		public string delimiter
		{
			get
			{
				return this.delimiterField;
			}
			set
			{
				this.delimiterField = value;
			}
		}

		// Token: 0x0400015F RID: 351
		private global::NPOI.OpenXmlFormats.CT_TextFields textFieldsField;

		// Token: 0x04000160 RID: 352
		private bool promptField;

		// Token: 0x04000161 RID: 353
		private global::NPOI.OpenXmlFormats.ST_FileType fileTypeField;

		// Token: 0x04000162 RID: 354
		private uint codePageField;

		// Token: 0x04000163 RID: 355
		private uint firstRowField;

		// Token: 0x04000164 RID: 356
		private string sourceFileField;

		// Token: 0x04000165 RID: 357
		private bool delimitedField;

		// Token: 0x04000166 RID: 358
		private string decimalField;

		// Token: 0x04000167 RID: 359
		private string thousandsField;

		// Token: 0x04000168 RID: 360
		private bool tabField;

		// Token: 0x04000169 RID: 361
		private bool spaceField;

		// Token: 0x0400016A RID: 362
		private bool commaField;

		// Token: 0x0400016B RID: 363
		private bool semicolonField;

		// Token: 0x0400016C RID: 364
		private bool consecutiveField;

		// Token: 0x0400016D RID: 365
		private global::NPOI.OpenXmlFormats.ST_Qualifier qualifierField;

		// Token: 0x0400016E RID: 366
		private string delimiterField;
	}
}
