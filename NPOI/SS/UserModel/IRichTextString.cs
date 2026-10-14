using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000082 RID: 130
	public interface IRichTextString
	{
		// Token: 0x0600047D RID: 1149
		void ApplyFont(int startIndex, int endIndex, short fontIndex);

		// Token: 0x0600047E RID: 1150
		void ApplyFont(int startIndex, int endIndex, global::NPOI.SS.UserModel.IFont font);

		// Token: 0x0600047F RID: 1151
		void ApplyFont(global::NPOI.SS.UserModel.IFont font);

		// Token: 0x06000480 RID: 1152
		void ClearFormatting();

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000481 RID: 1153
		string String { get; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000482 RID: 1154
		int Length { get; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000483 RID: 1155
		int NumFormattingRuns { get; }

		// Token: 0x06000484 RID: 1156
		int GetIndexOfFormattingRun(int index);

		// Token: 0x06000485 RID: 1157
		void ApplyFont(short fontIndex);
	}
}
