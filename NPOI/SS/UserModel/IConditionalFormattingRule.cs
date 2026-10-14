using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000057 RID: 87
	public interface IConditionalFormattingRule
	{
		// Token: 0x0600033F RID: 831
		global::NPOI.SS.UserModel.IBorderFormatting CreateBorderFormatting();

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000340 RID: 832
		global::NPOI.SS.UserModel.IBorderFormatting BorderFormatting { get; }

		// Token: 0x06000341 RID: 833
		global::NPOI.SS.UserModel.IFontFormatting CreateFontFormatting();

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000342 RID: 834
		global::NPOI.SS.UserModel.IFontFormatting FontFormatting { get; }

		// Token: 0x06000343 RID: 835
		global::NPOI.SS.UserModel.IPatternFormatting CreatePatternFormatting();

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000344 RID: 836
		global::NPOI.SS.UserModel.IPatternFormatting PatternFormatting { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000345 RID: 837
		global::NPOI.SS.UserModel.IDataBarFormatting DataBarFormatting { get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000346 RID: 838
		global::NPOI.SS.UserModel.IIconMultiStateFormatting MultiStateFormatting { get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000347 RID: 839
		global::NPOI.SS.UserModel.IColorScaleFormatting ColorScaleFormatting { get; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000348 RID: 840
		global::NPOI.SS.UserModel.ConditionType ConditionType { get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000349 RID: 841
		global::NPOI.SS.UserModel.ComparisonOperator ComparisonOperation { get; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600034A RID: 842
		string Formula1 { get; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600034B RID: 843
		string Formula2 { get; }
	}
}
