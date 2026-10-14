using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000085 RID: 133
	public interface IShape
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060004A4 RID: 1188
		global::NPOI.SS.UserModel.IShape Parent { get; }

		// Token: 0x060004A5 RID: 1189
		void SetLineStyleColor(int lineStyleColor);

		// Token: 0x060004A6 RID: 1190
		void SetLineStyleColor(int red, int green, int blue);

		// Token: 0x060004A7 RID: 1191
		void SetFillColor(int red, int green, int blue);

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060004A8 RID: 1192
		int LineStyleColor { get; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060004A9 RID: 1193
		// (set) Token: 0x060004AA RID: 1194
		int FillColor { get; set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004AB RID: 1195
		// (set) Token: 0x060004AC RID: 1196
		double LineWidth { get; set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004AD RID: 1197
		// (set) Token: 0x060004AE RID: 1198
		global::NPOI.SS.UserModel.LineStyle LineStyle { get; set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004AF RID: 1199
		// (set) Token: 0x060004B0 RID: 1200
		bool IsNoFill { get; set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004B1 RID: 1201
		int CountOfAllChildren { get; }
	}
}
