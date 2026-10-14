using System;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000561 RID: 1377
	public class CT_RevisionComment
	{
		// Token: 0x06003BDD RID: 15325 RVA: 0x0009316A File Offset: 0x0009136A
		public CT_RevisionComment()
		{
			this.actionField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_RevisionAction.add;
			this.alwaysShowField = false;
			this.oldField = false;
			this.hiddenRowField = false;
			this.hiddenColumnField = false;
			this.oldLengthField = 0U;
			this.newLengthField = 0U;
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x000931A3 File Offset: 0x000913A3
		// (set) Token: 0x06003BDF RID: 15327 RVA: 0x000931AB File Offset: 0x000913AB
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06003BE0 RID: 15328 RVA: 0x000931B4 File Offset: 0x000913B4
		// (set) Token: 0x06003BE1 RID: 15329 RVA: 0x000931BC File Offset: 0x000913BC
		public string cell
		{
			get
			{
				return this.cellField;
			}
			set
			{
				this.cellField = value;
			}
		}

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06003BE2 RID: 15330 RVA: 0x000931C5 File Offset: 0x000913C5
		// (set) Token: 0x06003BE3 RID: 15331 RVA: 0x000931CD File Offset: 0x000913CD
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x06003BE4 RID: 15332 RVA: 0x000931D6 File Offset: 0x000913D6
		// (set) Token: 0x06003BE5 RID: 15333 RVA: 0x000931DE File Offset: 0x000913DE
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_RevisionAction.add)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_RevisionAction action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x000931E7 File Offset: 0x000913E7
		// (set) Token: 0x06003BE7 RID: 15335 RVA: 0x000931EF File Offset: 0x000913EF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool alwaysShow
		{
			get
			{
				return this.alwaysShowField;
			}
			set
			{
				this.alwaysShowField = value;
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06003BE8 RID: 15336 RVA: 0x000931F8 File Offset: 0x000913F8
		// (set) Token: 0x06003BE9 RID: 15337 RVA: 0x00093200 File Offset: 0x00091400
		[global::System.ComponentModel.DefaultValue(false)]
		public bool old
		{
			get
			{
				return this.oldField;
			}
			set
			{
				this.oldField = value;
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x00093209 File Offset: 0x00091409
		// (set) Token: 0x06003BEB RID: 15339 RVA: 0x00093211 File Offset: 0x00091411
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hiddenRow
		{
			get
			{
				return this.hiddenRowField;
			}
			set
			{
				this.hiddenRowField = value;
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06003BEC RID: 15340 RVA: 0x0009321A File Offset: 0x0009141A
		// (set) Token: 0x06003BED RID: 15341 RVA: 0x00093222 File Offset: 0x00091422
		[global::System.ComponentModel.DefaultValue(false)]
		public bool hiddenColumn
		{
			get
			{
				return this.hiddenColumnField;
			}
			set
			{
				this.hiddenColumnField = value;
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06003BEE RID: 15342 RVA: 0x0009322B File Offset: 0x0009142B
		// (set) Token: 0x06003BEF RID: 15343 RVA: 0x00093233 File Offset: 0x00091433
		public string author
		{
			get
			{
				return this.authorField;
			}
			set
			{
				this.authorField = value;
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x0009323C File Offset: 0x0009143C
		// (set) Token: 0x06003BF1 RID: 15345 RVA: 0x00093244 File Offset: 0x00091444
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint oldLength
		{
			get
			{
				return this.oldLengthField;
			}
			set
			{
				this.oldLengthField = value;
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06003BF2 RID: 15346 RVA: 0x0009324D File Offset: 0x0009144D
		// (set) Token: 0x06003BF3 RID: 15347 RVA: 0x00093255 File Offset: 0x00091455
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint newLength
		{
			get
			{
				return this.newLengthField;
			}
			set
			{
				this.newLengthField = value;
			}
		}

		// Token: 0x0400265E RID: 9822
		private uint sheetIdField;

		// Token: 0x0400265F RID: 9823
		private string cellField;

		// Token: 0x04002660 RID: 9824
		private string guidField;

		// Token: 0x04002661 RID: 9825
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_RevisionAction actionField;

		// Token: 0x04002662 RID: 9826
		private bool alwaysShowField;

		// Token: 0x04002663 RID: 9827
		private bool oldField;

		// Token: 0x04002664 RID: 9828
		private bool hiddenRowField;

		// Token: 0x04002665 RID: 9829
		private bool hiddenColumnField;

		// Token: 0x04002666 RID: 9830
		private string authorField;

		// Token: 0x04002667 RID: 9831
		private uint oldLengthField;

		// Token: 0x04002668 RID: 9832
		private uint newLengthField;
	}
}
