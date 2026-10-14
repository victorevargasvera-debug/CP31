using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000035 RID: 53
	public interface IColorScaleFormatting
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000202 RID: 514
		// (set) Token: 0x06000203 RID: 515
		int NumControlPoints { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000204 RID: 516
		// (set) Token: 0x06000205 RID: 517
		global::NPOI.SS.UserModel.IColor[] Colors { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000206 RID: 518
		// (set) Token: 0x06000207 RID: 519
		global::NPOI.SS.UserModel.IConditionalFormattingThreshold[] Thresholds { get; set; }

		// Token: 0x06000208 RID: 520
		global::NPOI.SS.UserModel.IConditionalFormattingThreshold CreateThreshold();
	}
}
