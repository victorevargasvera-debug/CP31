using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x0200009D RID: 157
	public interface IChartAxis
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005A4 RID: 1444
		long Id { get; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005A5 RID: 1445
		// (set) Token: 0x060005A6 RID: 1446
		global::NPOI.SS.UserModel.Charts.AxisPosition Position { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005A7 RID: 1447
		// (set) Token: 0x060005A8 RID: 1448
		string NumberFormat { get; set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005A9 RID: 1449
		bool IsSetLogBase { get; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005AA RID: 1450
		// (set) Token: 0x060005AB RID: 1451
		double LogBase { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005AC RID: 1452
		bool IsSetMinimum { get; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005AD RID: 1453
		// (set) Token: 0x060005AE RID: 1454
		double Minimum { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005AF RID: 1455
		bool IsSetMaximum { get; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005B0 RID: 1456
		// (set) Token: 0x060005B1 RID: 1457
		double Maximum { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005B2 RID: 1458
		// (set) Token: 0x060005B3 RID: 1459
		global::NPOI.SS.UserModel.Charts.AxisOrientation Orientation { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005B4 RID: 1460
		// (set) Token: 0x060005B5 RID: 1461
		global::NPOI.SS.UserModel.Charts.AxisCrosses Crosses { get; set; }

		// Token: 0x060005B6 RID: 1462
		void CrossAxis(global::NPOI.SS.UserModel.Charts.IChartAxis axis);

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005B7 RID: 1463
		// (set) Token: 0x060005B8 RID: 1464
		bool IsVisible { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005B9 RID: 1465
		// (set) Token: 0x060005BA RID: 1466
		global::NPOI.SS.UserModel.Charts.AxisTickMark MajorTickMark { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005BB RID: 1467
		// (set) Token: 0x060005BC RID: 1468
		global::NPOI.SS.UserModel.Charts.AxisTickMark MinorTickMark { get; set; }
	}
}
