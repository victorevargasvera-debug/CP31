using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000538 RID: 1336
	public class CT_DateGroupItem
	{
		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x0009104B File Offset: 0x0008F24B
		// (set) Token: 0x06003A8A RID: 14986 RVA: 0x00091053 File Offset: 0x0008F253
		public ushort year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06003A8B RID: 14987 RVA: 0x0009105C File Offset: 0x0008F25C
		// (set) Token: 0x06003A8C RID: 14988 RVA: 0x00091064 File Offset: 0x0008F264
		public ushort month
		{
			get
			{
				return this.monthField;
			}
			set
			{
				this.monthField = value;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06003A8D RID: 14989 RVA: 0x0009106D File Offset: 0x0008F26D
		// (set) Token: 0x06003A8E RID: 14990 RVA: 0x00091075 File Offset: 0x0008F275
		[global::System.Xml.Serialization.XmlIgnore]
		public bool monthSpecified
		{
			get
			{
				return this.monthFieldSpecified;
			}
			set
			{
				this.monthFieldSpecified = value;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x0009107E File Offset: 0x0008F27E
		// (set) Token: 0x06003A90 RID: 14992 RVA: 0x00091086 File Offset: 0x0008F286
		public ushort day
		{
			get
			{
				return this.dayField;
			}
			set
			{
				this.dayField = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x0009108F File Offset: 0x0008F28F
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x00091097 File Offset: 0x0008F297
		[global::System.Xml.Serialization.XmlIgnore]
		public bool daySpecified
		{
			get
			{
				return this.dayFieldSpecified;
			}
			set
			{
				this.dayFieldSpecified = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x000910A0 File Offset: 0x0008F2A0
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x000910A8 File Offset: 0x0008F2A8
		public ushort hour
		{
			get
			{
				return this.hourField;
			}
			set
			{
				this.hourField = value;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x000910B1 File Offset: 0x0008F2B1
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x000910B9 File Offset: 0x0008F2B9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool hourSpecified
		{
			get
			{
				return this.hourFieldSpecified;
			}
			set
			{
				this.hourFieldSpecified = value;
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x000910C2 File Offset: 0x0008F2C2
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x000910CA File Offset: 0x0008F2CA
		public ushort minute
		{
			get
			{
				return this.minuteField;
			}
			set
			{
				this.minuteField = value;
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x000910D3 File Offset: 0x0008F2D3
		// (set) Token: 0x06003A9A RID: 15002 RVA: 0x000910DB File Offset: 0x0008F2DB
		[global::System.Xml.Serialization.XmlIgnore]
		public bool minuteSpecified
		{
			get
			{
				return this.minuteFieldSpecified;
			}
			set
			{
				this.minuteFieldSpecified = value;
			}
		}

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x000910E4 File Offset: 0x0008F2E4
		// (set) Token: 0x06003A9C RID: 15004 RVA: 0x000910EC File Offset: 0x0008F2EC
		public ushort second
		{
			get
			{
				return this.secondField;
			}
			set
			{
				this.secondField = value;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x000910F5 File Offset: 0x0008F2F5
		// (set) Token: 0x06003A9E RID: 15006 RVA: 0x000910FD File Offset: 0x0008F2FD
		[global::System.Xml.Serialization.XmlIgnore]
		public bool secondSpecified
		{
			get
			{
				return this.secondFieldSpecified;
			}
			set
			{
				this.secondFieldSpecified = value;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00091106 File Offset: 0x0008F306
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x0009110E File Offset: 0x0008F30E
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_DateTimeGrouping dateTimeGrouping
		{
			get
			{
				return this.dateTimeGroupingField;
			}
			set
			{
				this.dateTimeGroupingField = value;
			}
		}

		// Token: 0x0400256E RID: 9582
		private ushort yearField;

		// Token: 0x0400256F RID: 9583
		private ushort monthField;

		// Token: 0x04002570 RID: 9584
		private bool monthFieldSpecified;

		// Token: 0x04002571 RID: 9585
		private ushort dayField;

		// Token: 0x04002572 RID: 9586
		private bool dayFieldSpecified;

		// Token: 0x04002573 RID: 9587
		private ushort hourField;

		// Token: 0x04002574 RID: 9588
		private bool hourFieldSpecified;

		// Token: 0x04002575 RID: 9589
		private ushort minuteField;

		// Token: 0x04002576 RID: 9590
		private bool minuteFieldSpecified;

		// Token: 0x04002577 RID: 9591
		private ushort secondField;

		// Token: 0x04002578 RID: 9592
		private bool secondFieldSpecified;

		// Token: 0x04002579 RID: 9593
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_DateTimeGrouping dateTimeGroupingField;
	}
}
