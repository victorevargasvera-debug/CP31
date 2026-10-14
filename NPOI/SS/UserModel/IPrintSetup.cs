using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000081 RID: 129
	public interface IPrintSetup
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000455 RID: 1109
		// (set) Token: 0x06000456 RID: 1110
		short PaperSize { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000457 RID: 1111
		// (set) Token: 0x06000458 RID: 1112
		short Scale { get; set; }

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000459 RID: 1113
		// (set) Token: 0x0600045A RID: 1114
		short PageStart { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600045B RID: 1115
		// (set) Token: 0x0600045C RID: 1116
		short FitWidth { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600045D RID: 1117
		// (set) Token: 0x0600045E RID: 1118
		short FitHeight { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600045F RID: 1119
		// (set) Token: 0x06000460 RID: 1120
		bool LeftToRight { get; set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000461 RID: 1121
		// (set) Token: 0x06000462 RID: 1122
		bool Landscape { get; set; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000463 RID: 1123
		// (set) Token: 0x06000464 RID: 1124
		bool ValidSettings { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000465 RID: 1125
		// (set) Token: 0x06000466 RID: 1126
		bool NoColor { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000467 RID: 1127
		// (set) Token: 0x06000468 RID: 1128
		bool Draft { get; set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000469 RID: 1129
		// (set) Token: 0x0600046A RID: 1130
		bool Notes { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600046B RID: 1131
		// (set) Token: 0x0600046C RID: 1132
		bool NoOrientation { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600046D RID: 1133
		// (set) Token: 0x0600046E RID: 1134
		bool UsePage { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600046F RID: 1135
		// (set) Token: 0x06000470 RID: 1136
		short HResolution { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000471 RID: 1137
		// (set) Token: 0x06000472 RID: 1138
		short VResolution { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000473 RID: 1139
		// (set) Token: 0x06000474 RID: 1140
		double HeaderMargin { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000475 RID: 1141
		// (set) Token: 0x06000476 RID: 1142
		double FooterMargin { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000477 RID: 1143
		// (set) Token: 0x06000478 RID: 1144
		short Copies { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000479 RID: 1145
		// (set) Token: 0x0600047A RID: 1146
		bool EndNote { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600047B RID: 1147
		// (set) Token: 0x0600047C RID: 1148
		global::NPOI.SS.UserModel.DisplayCellErrorType CellError { get; set; }
	}
}
