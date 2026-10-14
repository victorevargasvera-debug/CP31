using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200007A RID: 122
	public interface IPatternFormatting
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000436 RID: 1078
		// (set) Token: 0x06000437 RID: 1079
		short FillBackgroundColor { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000438 RID: 1080
		// (set) Token: 0x06000439 RID: 1081
		short FillForegroundColor { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600043A RID: 1082
		// (set) Token: 0x0600043B RID: 1083
		global::NPOI.SS.UserModel.IColor FillBackgroundColorColor { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600043C RID: 1084
		// (set) Token: 0x0600043D RID: 1085
		global::NPOI.SS.UserModel.IColor FillForegroundColorColor { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600043E RID: 1086
		// (set) Token: 0x0600043F RID: 1087
		global::NPOI.SS.UserModel.FillPattern FillPattern { get; set; }
	}
}
