using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000381 RID: 897
	public class HSSFPatternFormatting : global::NPOI.SS.UserModel.IPatternFormatting
	{
		// Token: 0x06001CA1 RID: 7329 RVA: 0x00057327 File Offset: 0x00055527
		public HSSFPatternFormatting(global::NPOI.HSSF.Record.CFRuleBase cfRuleRecord, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			this.workbook = workbook;
			this.cfRuleRecord = cfRuleRecord;
			this.patternFormatting = cfRuleRecord.PatternFormatting;
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00057349 File Offset: 0x00055549
		public global::NPOI.HSSF.Record.CF.PatternFormatting PatternFormattingBlock
		{
			get
			{
				return this.patternFormatting;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00057351 File Offset: 0x00055551
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0005736C File Offset: 0x0005556C
		public global::NPOI.SS.UserModel.IColor FillBackgroundColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.FillBackgroundColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.FillBackgroundColor = 0;
					return;
				}
				this.FillBackgroundColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x00057397 File Offset: 0x00055597
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x000573B0 File Offset: 0x000555B0
		public global::NPOI.SS.UserModel.IColor FillForegroundColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.FillForegroundColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.FillForegroundColor = 0;
					return;
				}
				this.FillForegroundColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000573DB File Offset: 0x000555DB
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x000573E8 File Offset: 0x000555E8
		public short FillBackgroundColor
		{
			get
			{
				return this.patternFormatting.FillBackgroundColor;
			}
			set
			{
				this.patternFormatting.FillBackgroundColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsPatternBackgroundColorModified = true;
				}
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x00057405 File Offset: 0x00055605
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x00057412 File Offset: 0x00055612
		public short FillForegroundColor
		{
			get
			{
				return this.patternFormatting.FillForegroundColor;
			}
			set
			{
				this.patternFormatting.FillForegroundColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsPatternColorModified = true;
				}
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x0005742F File Offset: 0x0005562F
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0005743C File Offset: 0x0005563C
		public global::NPOI.SS.UserModel.FillPattern FillPattern
		{
			get
			{
				return this.patternFormatting.FillPattern;
			}
			set
			{
				this.patternFormatting.FillPattern = value;
				if (value != global::NPOI.SS.UserModel.FillPattern.NoFill)
				{
					this.cfRuleRecord.IsPatternStyleModified = true;
				}
			}
		}

		// Token: 0x04000B6B RID: 2923
		private global::NPOI.HSSF.Record.CFRuleBase cfRuleRecord;

		// Token: 0x04000B6C RID: 2924
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;

		// Token: 0x04000B6D RID: 2925
		private global::NPOI.HSSF.Record.CF.PatternFormatting patternFormatting;
	}
}
