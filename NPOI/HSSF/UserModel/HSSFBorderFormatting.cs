using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000369 RID: 873
	public class HSSFBorderFormatting : global::NPOI.SS.UserModel.IBorderFormatting
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x000515ED File Offset: 0x0004F7ED
		public HSSFBorderFormatting(global::NPOI.HSSF.Record.CFRuleBase cfRuleRecord, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			this.workbook = workbook;
			this.cfRuleRecord = cfRuleRecord;
			this.borderFormatting = cfRuleRecord.BorderFormatting;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0005160F File Offset: 0x0004F80F
		public global::NPOI.HSSF.Record.CF.BorderFormatting GetBorderFormattingBlock()
		{
			return this.borderFormatting;
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001A8A RID: 6794 RVA: 0x00051617 File Offset: 0x0004F817
		// (set) Token: 0x06001A8B RID: 6795 RVA: 0x00051624 File Offset: 0x0004F824
		public global::NPOI.SS.UserModel.BorderStyle BorderBottom
		{
			get
			{
				return this.borderFormatting.BorderBottom;
			}
			set
			{
				this.borderFormatting.BorderBottom = value;
				if (value != global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this.cfRuleRecord.IsBottomBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsBottomBorderModified = false;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0005164E File Offset: 0x0004F84E
		// (set) Token: 0x06001A8D RID: 6797 RVA: 0x0005165C File Offset: 0x0004F85C
		public global::NPOI.SS.UserModel.BorderStyle BorderDiagonal
		{
			get
			{
				return this.borderFormatting.BorderDiagonal;
			}
			set
			{
				this.borderFormatting.BorderDiagonal = value;
				if (value != global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this.cfRuleRecord.IsBottomLeftTopRightBorderModified = true;
					this.cfRuleRecord.IsTopLeftBottomRightBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsBottomLeftTopRightBorderModified = false;
				this.cfRuleRecord.IsTopLeftBottomRightBorderModified = false;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x000516A9 File Offset: 0x0004F8A9
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x000516B6 File Offset: 0x0004F8B6
		public global::NPOI.SS.UserModel.BorderStyle BorderLeft
		{
			get
			{
				return this.borderFormatting.BorderLeft;
			}
			set
			{
				this.borderFormatting.BorderLeft = value;
				if (value != global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this.cfRuleRecord.IsLeftBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsLeftBorderModified = false;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x000516E0 File Offset: 0x0004F8E0
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x000516ED File Offset: 0x0004F8ED
		public global::NPOI.SS.UserModel.BorderStyle BorderRight
		{
			get
			{
				return this.borderFormatting.BorderRight;
			}
			set
			{
				this.borderFormatting.BorderRight = value;
				if (value != global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this.cfRuleRecord.IsRightBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsRightBorderModified = false;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00051717 File Offset: 0x0004F917
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x00051724 File Offset: 0x0004F924
		public global::NPOI.SS.UserModel.BorderStyle BorderTop
		{
			get
			{
				return this.borderFormatting.BorderTop;
			}
			set
			{
				this.borderFormatting.BorderTop = value;
				if (value != global::NPOI.SS.UserModel.BorderStyle.None)
				{
					this.cfRuleRecord.IsTopBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsTopBorderModified = false;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0005174E File Offset: 0x0004F94E
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0005175B File Offset: 0x0004F95B
		public short BottomBorderColor
		{
			get
			{
				return this.borderFormatting.BottomBorderColor;
			}
			set
			{
				this.borderFormatting.BottomBorderColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsBottomBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsBottomBorderModified = false;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x00051785 File Offset: 0x0004F985
		// (set) Token: 0x06001A97 RID: 6807 RVA: 0x000517A4 File Offset: 0x0004F9A4
		public global::NPOI.SS.UserModel.IColor BottomBorderColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.borderFormatting.BottomBorderColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.BottomBorderColor = 0;
					return;
				}
				this.BottomBorderColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x000517CF File Offset: 0x0004F9CF
		// (set) Token: 0x06001A99 RID: 6809 RVA: 0x000517DC File Offset: 0x0004F9DC
		public short DiagonalBorderColor
		{
			get
			{
				return this.borderFormatting.DiagonalBorderColor;
			}
			set
			{
				this.borderFormatting.DiagonalBorderColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsBottomLeftTopRightBorderModified = true;
					this.cfRuleRecord.IsTopLeftBottomRightBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsBottomLeftTopRightBorderModified = false;
				this.cfRuleRecord.IsTopLeftBottomRightBorderModified = false;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00051829 File Offset: 0x0004FA29
		// (set) Token: 0x06001A9B RID: 6811 RVA: 0x00051848 File Offset: 0x0004FA48
		public global::NPOI.SS.UserModel.IColor DiagonalBorderColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.borderFormatting.DiagonalBorderColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.DiagonalBorderColor = 0;
					return;
				}
				this.DiagonalBorderColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00051873 File Offset: 0x0004FA73
		// (set) Token: 0x06001A9D RID: 6813 RVA: 0x00051880 File Offset: 0x0004FA80
		public short LeftBorderColor
		{
			get
			{
				return this.borderFormatting.LeftBorderColor;
			}
			set
			{
				this.borderFormatting.LeftBorderColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsLeftBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsLeftBorderModified = false;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x000518AA File Offset: 0x0004FAAA
		// (set) Token: 0x06001A9F RID: 6815 RVA: 0x000518C8 File Offset: 0x0004FAC8
		public global::NPOI.SS.UserModel.IColor LeftBorderColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.borderFormatting.LeftBorderColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.LeftBorderColor = 0;
					return;
				}
				this.LeftBorderColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000518F3 File Offset: 0x0004FAF3
		// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x00051900 File Offset: 0x0004FB00
		public short RightBorderColor
		{
			get
			{
				return this.borderFormatting.RightBorderColor;
			}
			set
			{
				this.borderFormatting.RightBorderColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsRightBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsRightBorderModified = false;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x0005192A File Offset: 0x0004FB2A
		// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x00051948 File Offset: 0x0004FB48
		public global::NPOI.SS.UserModel.IColor RightBorderColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.borderFormatting.RightBorderColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.RightBorderColor = 0;
					return;
				}
				this.RightBorderColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00051973 File Offset: 0x0004FB73
		// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x00051980 File Offset: 0x0004FB80
		public short TopBorderColor
		{
			get
			{
				return this.borderFormatting.TopBorderColor;
			}
			set
			{
				this.borderFormatting.TopBorderColor = value;
				if (value != 0)
				{
					this.cfRuleRecord.IsTopBorderModified = true;
					return;
				}
				this.cfRuleRecord.IsTopBorderModified = false;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x000519AA File Offset: 0x0004FBAA
		// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x000519C8 File Offset: 0x0004FBC8
		public global::NPOI.SS.UserModel.IColor TopBorderColorColor
		{
			get
			{
				return this.workbook.GetCustomPalette().GetColor(this.borderFormatting.TopBorderColor);
			}
			set
			{
				global::NPOI.HSSF.Util.HSSFColor hssfcolor = global::NPOI.HSSF.Util.HSSFColor.ToHSSFColor(value);
				if (hssfcolor == null)
				{
					this.TopBorderColor = 0;
					return;
				}
				this.TopBorderColor = hssfcolor.Indexed;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x000519F3 File Offset: 0x0004FBF3
		// (set) Token: 0x06001AA9 RID: 6825 RVA: 0x00051A00 File Offset: 0x0004FC00
		public bool IsBackwardDiagonalOn
		{
			get
			{
				return this.borderFormatting.IsBackwardDiagonalOn;
			}
			set
			{
				this.borderFormatting.IsBackwardDiagonalOn = value;
				if (value)
				{
					this.cfRuleRecord.IsTopLeftBottomRightBorderModified = value;
				}
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x00051A1D File Offset: 0x0004FC1D
		// (set) Token: 0x06001AAB RID: 6827 RVA: 0x00051A2A File Offset: 0x0004FC2A
		public bool IsForwardDiagonalOn
		{
			get
			{
				return this.borderFormatting.IsForwardDiagonalOn;
			}
			set
			{
				this.borderFormatting.IsForwardDiagonalOn = value;
				if (value)
				{
					this.cfRuleRecord.IsBottomLeftTopRightBorderModified = value;
				}
			}
		}

		// Token: 0x04000B1E RID: 2846
		private global::NPOI.HSSF.UserModel.HSSFWorkbook workbook;

		// Token: 0x04000B1F RID: 2847
		private global::NPOI.HSSF.Record.CFRuleBase cfRuleRecord;

		// Token: 0x04000B20 RID: 2848
		private global::NPOI.HSSF.Record.CF.BorderFormatting borderFormatting;
	}
}
