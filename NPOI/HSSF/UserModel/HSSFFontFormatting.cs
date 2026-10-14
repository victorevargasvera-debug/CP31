using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000377 RID: 887
	public class HSSFFontFormatting : global::NPOI.SS.UserModel.IFontFormatting
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x000554CD File Offset: 0x000536CD
		public HSSFFontFormatting(global::NPOI.HSSF.Record.CFRuleBase cfRuleRecord, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			this.fontFormatting = cfRuleRecord.FontFormatting;
			this.workbook = workbook;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x000554E8 File Offset: 0x000536E8
		protected global::NPOI.HSSF.Record.CF.FontFormatting GetFontFormattingBlock()
		{
			return this.fontFormatting;
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000554F0 File Offset: 0x000536F0
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x000554FD File Offset: 0x000536FD
		public global::NPOI.SS.UserModel.FontSuperScript EscapementType
		{
			get
			{
				return this.fontFormatting.EscapementType;
			}
			set
			{
				if (value != global::NPOI.SS.UserModel.FontSuperScript.None)
				{
					if (value - global::NPOI.SS.UserModel.FontSuperScript.Super <= 1)
					{
						this.fontFormatting.EscapementType = value;
						this.fontFormatting.IsEscapementTypeModified = true;
						return;
					}
				}
				else
				{
					this.fontFormatting.EscapementType = value;
					this.fontFormatting.IsEscapementTypeModified = false;
				}
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x00055539 File Offset: 0x00053739
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x00055546 File Offset: 0x00053746
		public short FontColorIndex
		{
			get
			{
				return this.fontFormatting.FontColorIndex;
			}
			set
			{
				this.fontFormatting.FontColorIndex = value;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00055554 File Offset: 0x00053754
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0005556C File Offset: 0x0005376C
		public global::NPOI.SS.UserModel.IColor FontColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.FontColorIndex);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.fontFormatting.FontColorIndex = 0;
					return;
				}
				this.fontFormatting.FontColorIndex = hssfcolor.Indexed;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001C0E RID: 7182 RVA: 0x000555A1 File Offset: 0x000537A1
		// (set) Token: 0x06001C0F RID: 7183 RVA: 0x000555AE File Offset: 0x000537AE
		public int FontHeight
		{
			get
			{
				return this.fontFormatting.FontHeight;
			}
			set
			{
				this.fontFormatting.FontHeight = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001C10 RID: 7184 RVA: 0x000555BC File Offset: 0x000537BC
		public short FontWeight
		{
			get
			{
				return this.fontFormatting.FontWeight;
			}
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000555C9 File Offset: 0x000537C9
		protected byte[] GetRawRecord()
		{
			return this.fontFormatting.RawRecord;
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000555D6 File Offset: 0x000537D6
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x000555E3 File Offset: 0x000537E3
		public global::NPOI.SS.UserModel.FontUnderlineType UnderlineType
		{
			get
			{
				return this.fontFormatting.UnderlineType;
			}
			set
			{
				if (value != global::NPOI.SS.UserModel.FontUnderlineType.None)
				{
					if (value - global::NPOI.SS.UserModel.FontUnderlineType.Single <= 1 || value - global::NPOI.SS.UserModel.FontUnderlineType.SingleAccounting <= 1)
					{
						this.fontFormatting.UnderlineType = value;
						this.IsUnderlineTypeModified = true;
						return;
					}
				}
				else
				{
					this.fontFormatting.UnderlineType = value;
					this.IsUnderlineTypeModified = false;
				}
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001C14 RID: 7188 RVA: 0x0005561C File Offset: 0x0005381C
		public bool IsBold
		{
			get
			{
				return this.fontFormatting.IsFontWeightModified && this.fontFormatting.IsBold;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x00055638 File Offset: 0x00053838
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x00055645 File Offset: 0x00053845
		public bool IsEscapementTypeModified
		{
			get
			{
				return this.fontFormatting.IsEscapementTypeModified;
			}
			set
			{
				this.fontFormatting.IsEscapementTypeModified = value;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00055653 File Offset: 0x00053853
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00055660 File Offset: 0x00053860
		public bool IsFontCancellationModified
		{
			get
			{
				return this.fontFormatting.IsFontCancellationModified;
			}
			set
			{
				this.fontFormatting.IsFontCancellationModified = value;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0005566E File Offset: 0x0005386E
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0005567B File Offset: 0x0005387B
		public bool IsFontOutlineModified
		{
			get
			{
				return this.fontFormatting.IsFontOutlineModified;
			}
			set
			{
				this.fontFormatting.IsFontOutlineModified = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x00055689 File Offset: 0x00053889
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x00055696 File Offset: 0x00053896
		public bool IsFontShadowModified
		{
			get
			{
				return this.fontFormatting.IsFontShadowModified;
			}
			set
			{
				this.fontFormatting.IsFontShadowModified = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x000556A4 File Offset: 0x000538A4
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x000556B1 File Offset: 0x000538B1
		public bool IsFontStyleModified
		{
			get
			{
				return this.fontFormatting.IsFontStyleModified;
			}
			set
			{
				this.fontFormatting.IsFontStyleModified = value;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x000556BF File Offset: 0x000538BF
		public bool IsItalic
		{
			get
			{
				return this.fontFormatting.IsFontStyleModified && this.fontFormatting.IsItalic;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000556DB File Offset: 0x000538DB
		// (set) Token: 0x06001C21 RID: 7201 RVA: 0x000556F7 File Offset: 0x000538F7
		public bool IsOutlineOn
		{
			get
			{
				return this.fontFormatting.IsFontOutlineModified && this.fontFormatting.IsOutlineOn;
			}
			set
			{
				this.fontFormatting.IsOutlineOn = value;
				this.fontFormatting.IsFontOutlineModified = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00055711 File Offset: 0x00053911
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x0005572D File Offset: 0x0005392D
		public bool IsShadowOn
		{
			get
			{
				return this.fontFormatting.IsFontOutlineModified && this.fontFormatting.IsShadowOn;
			}
			set
			{
				this.fontFormatting.IsShadowOn = value;
				this.fontFormatting.IsFontShadowModified = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00055747 File Offset: 0x00053947
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00055763 File Offset: 0x00053963
		public bool IsStrikeout
		{
			get
			{
				return this.fontFormatting.IsFontCancellationModified && this.fontFormatting.IsStruckout;
			}
			set
			{
				this.fontFormatting.IsStruckout = value;
				this.fontFormatting.IsFontCancellationModified = value;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0005577D File Offset: 0x0005397D
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x0005578A File Offset: 0x0005398A
		public bool IsUnderlineTypeModified
		{
			get
			{
				return this.fontFormatting.IsUnderlineTypeModified;
			}
			set
			{
				this.fontFormatting.IsUnderlineTypeModified = value;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00055798 File Offset: 0x00053998
		public bool IsFontWeightModified
		{
			get
			{
				return this.fontFormatting.IsFontWeightModified;
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000557A8 File Offset: 0x000539A8
		public void SetFontStyle(bool italic, bool bold)
		{
			bool flag = italic || bold;
			this.fontFormatting.IsItalic = italic;
			this.fontFormatting.IsBold = bold;
			this.fontFormatting.IsFontStyleModified = flag;
			this.fontFormatting.IsFontWeightModified = flag;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000557E9 File Offset: 0x000539E9
		public void ResetFontStyle()
		{
			this.SetFontStyle(false, false);
		}

		// Token: 0x04000B53 RID: 2899
		private global::NPOI.HSSF.Record.CF.FontFormatting fontFormatting;

		// Token: 0x04000B54 RID: 2900
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;
	}
}
