using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000357 RID: 855
	public class HSSFIconMultiStateFormatting : global::NPOI.SS.UserModel.IIconMultiStateFormatting
	{
		// Token: 0x06001973 RID: 6515 RVA: 0x0004DEE5 File Offset: 0x0004C0E5
		protected internal HSSFIconMultiStateFormatting(global::NPOI.HSSF.Record.CFRule12Record cfRule12Record, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			this.sheet = sheet;
			this.cfRule12Record = cfRule12Record;
			this.iconFormatting = this.cfRule12Record.MultiStateFormatting;
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x0004DF0C File Offset: 0x0004C10C
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x0004DF19 File Offset: 0x0004C119
		public global::NPOI.SS.UserModel.IconSet IconSet
		{
			get
			{
				return this.iconFormatting.IconSet;
			}
			set
			{
				this.iconFormatting.IconSet = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x0004DF27 File Offset: 0x0004C127
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x0004DF34 File Offset: 0x0004C134
		public bool IsIconOnly
		{
			get
			{
				return this.iconFormatting.IsIconOnly;
			}
			set
			{
				this.iconFormatting.IsIconOnly = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001978 RID: 6520 RVA: 0x0004DF42 File Offset: 0x0004C142
		// (set) Token: 0x06001979 RID: 6521 RVA: 0x0004DF4F File Offset: 0x0004C14F
		public bool IsReversed
		{
			get
			{
				return this.iconFormatting.IsReversed;
			}
			set
			{
				this.iconFormatting.IsReversed = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0004DF60 File Offset: 0x0004C160
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0004DFA4 File Offset: 0x0004C1A4
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold[] Thresholds
		{
			get
			{
				global::NPOI.HSSF.Record.CF.Threshold[] thresholds = this.iconFormatting.Thresholds;
				global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold[] array = new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold[thresholds.Length];
				for (int i = 0; i < thresholds.Length; i++)
				{
					array[i] = new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(thresholds[i], this.sheet);
				}
				return array;
			}
			set
			{
				global::NPOI.HSSF.Record.CF.Threshold[] array = new global::NPOI.HSSF.Record.CF.Threshold[value.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ((global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold)value[i]).Threshold;
				}
				this.iconFormatting.Thresholds = array;
			}
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0004DFE4 File Offset: 0x0004C1E4
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold CreateThreshold()
		{
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(new global::NPOI.HSSF.Record.CF.IconMultiStateThreshold(), this.sheet);
		}

		// Token: 0x04000A1C RID: 2588
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;

		// Token: 0x04000A1D RID: 2589
		private global::NPOI.HSSF.Record.CFRule12Record cfRule12Record;

		// Token: 0x04000A1E RID: 2590
		private global::NPOI.HSSF.Record.CF.IconMultiStateFormatting iconFormatting;
	}
}
