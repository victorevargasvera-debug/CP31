using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000355 RID: 853
	public class HSSFDataBarFormatting : global::NPOI.SS.UserModel.IDataBarFormatting
	{
		// Token: 0x06001953 RID: 6483 RVA: 0x0004DC2F File Offset: 0x0004BE2F
		protected internal HSSFDataBarFormatting(global::NPOI.HSSF.Record.CFRule12Record cfRule12Record, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			this.sheet = sheet;
			this.cfRule12Record = cfRule12Record;
			this.databarFormatting = this.cfRule12Record.DataBarFormatting;
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x0004DC56 File Offset: 0x0004BE56
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x0004DC66 File Offset: 0x0004BE66
		public bool IsLeftToRight
		{
			get
			{
				return !this.databarFormatting.IsReversed;
			}
			set
			{
				this.databarFormatting.IsReversed = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x0004DC74 File Offset: 0x0004BE74
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x0004DC81 File Offset: 0x0004BE81
		public int WidthMin
		{
			get
			{
				return (int)this.databarFormatting.PercentMin;
			}
			set
			{
				this.databarFormatting.PercentMin = (byte)value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x0004DC90 File Offset: 0x0004BE90
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x0004DC9D File Offset: 0x0004BE9D
		public int WidthMax
		{
			get
			{
				return (int)this.databarFormatting.PercentMax;
			}
			set
			{
				this.databarFormatting.PercentMax = (byte)value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x0004DCAC File Offset: 0x0004BEAC
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x0004DCC0 File Offset: 0x0004BEC0
		public global::NPOI.SS.UserModel.IColor Color
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFExtendedColor(this.databarFormatting.Color);
			}
			set
			{
				global::NPOI.HSSF.UserModel.HSSFExtendedColor hssfextendedColor = (global::NPOI.HSSF.UserModel.HSSFExtendedColor)value;
				this.databarFormatting.Color = hssfextendedColor.ExtendedColor;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0004DCE5 File Offset: 0x0004BEE5
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold MinThreshold
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(this.databarFormatting.ThresholdMin, this.sheet);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x0004DCFD File Offset: 0x0004BEFD
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold MaxThreshold
		{
			get
			{
				return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(this.databarFormatting.ThresholdMax, this.sheet);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0004DD15 File Offset: 0x0004BF15
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x0004DD22 File Offset: 0x0004BF22
		public bool IsIconOnly
		{
			get
			{
				return this.databarFormatting.IsIconOnly;
			}
			set
			{
				this.databarFormatting.IsIconOnly = value;
			}
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0004DD30 File Offset: 0x0004BF30
		public global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold CreateThreshold()
		{
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(new global::NPOI.HSSF.Record.CF.DataBarThreshold(), this.sheet);
		}

		// Token: 0x04000A18 RID: 2584
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;

		// Token: 0x04000A19 RID: 2585
		private global::NPOI.HSSF.Record.CFRule12Record cfRule12Record;

		// Token: 0x04000A1A RID: 2586
		private global::NPOI.HSSF.Record.CF.DataBarFormatting databarFormatting;
	}
}
