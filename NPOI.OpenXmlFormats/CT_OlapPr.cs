using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200002F RID: 47
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_OlapPr
	{
		// Token: 0x060001AB RID: 427 RVA: 0x000036B6 File Offset: 0x000018B6
		public CT_OlapPr()
		{
			this.localField = false;
			this.localRefreshField = true;
			this.sendLocaleField = false;
			this.serverFillField = true;
			this.serverNumberFormatField = true;
			this.serverFontField = true;
			this.serverFontColorField = true;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000036EF File Offset: 0x000018EF
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000036F7 File Offset: 0x000018F7
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool local
		{
			get
			{
				return this.localField;
			}
			set
			{
				this.localField = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00003700 File Offset: 0x00001900
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00003708 File Offset: 0x00001908
		[global::System.Xml.Serialization.XmlAttribute]
		public string localConnection
		{
			get
			{
				return this.localConnectionField;
			}
			set
			{
				this.localConnectionField = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00003711 File Offset: 0x00001911
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00003719 File Offset: 0x00001919
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool localRefresh
		{
			get
			{
				return this.localRefreshField;
			}
			set
			{
				this.localRefreshField = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00003722 File Offset: 0x00001922
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000372A File Offset: 0x0000192A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool sendLocale
		{
			get
			{
				return this.sendLocaleField;
			}
			set
			{
				this.sendLocaleField = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003733 File Offset: 0x00001933
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000373B File Offset: 0x0000193B
		[global::System.Xml.Serialization.XmlAttribute]
		public uint rowDrillCount
		{
			get
			{
				return this.rowDrillCountField;
			}
			set
			{
				this.rowDrillCountField = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00003744 File Offset: 0x00001944
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000374C File Offset: 0x0000194C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool rowDrillCountSpecified
		{
			get
			{
				return this.rowDrillCountFieldSpecified;
			}
			set
			{
				this.rowDrillCountFieldSpecified = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00003755 File Offset: 0x00001955
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000375D File Offset: 0x0000195D
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool serverFill
		{
			get
			{
				return this.serverFillField;
			}
			set
			{
				this.serverFillField = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00003766 File Offset: 0x00001966
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000376E File Offset: 0x0000196E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool serverNumberFormat
		{
			get
			{
				return this.serverNumberFormatField;
			}
			set
			{
				this.serverNumberFormatField = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00003777 File Offset: 0x00001977
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000377F File Offset: 0x0000197F
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool serverFont
		{
			get
			{
				return this.serverFontField;
			}
			set
			{
				this.serverFontField = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00003788 File Offset: 0x00001988
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00003790 File Offset: 0x00001990
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool serverFontColor
		{
			get
			{
				return this.serverFontColorField;
			}
			set
			{
				this.serverFontColorField = value;
			}
		}

		// Token: 0x04000140 RID: 320
		private bool localField;

		// Token: 0x04000141 RID: 321
		private string localConnectionField;

		// Token: 0x04000142 RID: 322
		private bool localRefreshField;

		// Token: 0x04000143 RID: 323
		private bool sendLocaleField;

		// Token: 0x04000144 RID: 324
		private uint rowDrillCountField;

		// Token: 0x04000145 RID: 325
		private bool rowDrillCountFieldSpecified;

		// Token: 0x04000146 RID: 326
		private bool serverFillField;

		// Token: 0x04000147 RID: 327
		private bool serverNumberFormatField;

		// Token: 0x04000148 RID: 328
		private bool serverFontField;

		// Token: 0x04000149 RID: 329
		private bool serverFontColorField;
	}
}
