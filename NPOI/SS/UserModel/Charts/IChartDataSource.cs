using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000093 RID: 147
	public interface IChartDataSource<T>
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000592 RID: 1426
		int PointCount { get; }

		// Token: 0x06000593 RID: 1427
		T GetPointAt(int index);

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000594 RID: 1428
		bool IsReference { get; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000595 RID: 1429
		bool IsNumeric { get; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000596 RID: 1430
		string FormulaString { get; }
	}
}
