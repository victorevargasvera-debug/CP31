using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x020000A5 RID: 165
	public interface IManualLayout
	{
		// Token: 0x060005C8 RID: 1480
		void SetTarget(global::NPOI.SS.UserModel.Charts.LayoutTarget target);

		// Token: 0x060005C9 RID: 1481
		global::NPOI.SS.UserModel.Charts.LayoutTarget GetTarget();

		// Token: 0x060005CA RID: 1482
		void SetXMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode);

		// Token: 0x060005CB RID: 1483
		global::NPOI.SS.UserModel.Charts.LayoutMode GetXMode();

		// Token: 0x060005CC RID: 1484
		void SetYMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode);

		// Token: 0x060005CD RID: 1485
		global::NPOI.SS.UserModel.Charts.LayoutMode GetYMode();

		// Token: 0x060005CE RID: 1486
		double GetX();

		// Token: 0x060005CF RID: 1487
		void SetX(double x);

		// Token: 0x060005D0 RID: 1488
		double GetY();

		// Token: 0x060005D1 RID: 1489
		void SetY(double y);

		// Token: 0x060005D2 RID: 1490
		void SetWidthMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode);

		// Token: 0x060005D3 RID: 1491
		global::NPOI.SS.UserModel.Charts.LayoutMode GetWidthMode();

		// Token: 0x060005D4 RID: 1492
		void SetHeightMode(global::NPOI.SS.UserModel.Charts.LayoutMode mode);

		// Token: 0x060005D5 RID: 1493
		global::NPOI.SS.UserModel.Charts.LayoutMode GetHeightMode();

		// Token: 0x060005D6 RID: 1494
		void SetWidthRatio(double ratio);

		// Token: 0x060005D7 RID: 1495
		double GetWidthRatio();

		// Token: 0x060005D8 RID: 1496
		void SetHeightRatio(double ratio);

		// Token: 0x060005D9 RID: 1497
		double GetHeightRatio();
	}
}
