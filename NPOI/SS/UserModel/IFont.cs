using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000068 RID: 104
	public interface IFont
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003C6 RID: 966
		// (set) Token: 0x060003C7 RID: 967
		string FontName { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003C8 RID: 968
		// (set) Token: 0x060003C9 RID: 969
		double FontHeight { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003CA RID: 970
		// (set) Token: 0x060003CB RID: 971
		double FontHeightInPoints { get; set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003CC RID: 972
		// (set) Token: 0x060003CD RID: 973
		bool IsItalic { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003CE RID: 974
		// (set) Token: 0x060003CF RID: 975
		bool IsStrikeout { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003D0 RID: 976
		// (set) Token: 0x060003D1 RID: 977
		short Color { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003D2 RID: 978
		// (set) Token: 0x060003D3 RID: 979
		global::NPOI.SS.UserModel.FontSuperScript TypeOffset { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003D4 RID: 980
		// (set) Token: 0x060003D5 RID: 981
		global::NPOI.SS.UserModel.FontUnderlineType Underline { get; set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003D6 RID: 982
		// (set) Token: 0x060003D7 RID: 983
		short Charset { get; set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003D8 RID: 984
		short Index { get; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003D9 RID: 985
		// (set) Token: 0x060003DA RID: 986
		[global::System.Obsolete("deprecated POI 3.15 beta 2. Use IsBold instead.")]
		short Boldweight { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003DB RID: 987
		// (set) Token: 0x060003DC RID: 988
		bool IsBold { get; set; }

		// Token: 0x060003DD RID: 989
		void CloneStyleFrom(global::NPOI.SS.UserModel.IFont src);
	}
}
