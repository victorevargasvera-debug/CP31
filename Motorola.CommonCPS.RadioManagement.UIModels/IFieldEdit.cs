using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200009D RID: 157
	public interface IFieldEdit
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060005BE RID: 1470
		bool IsApplicable { get; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060005BF RID: 1471
		// (set) Token: 0x060005C0 RID: 1472
		bool IsEditable { get; set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060005C1 RID: 1473
		bool IsValid { get; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060005C2 RID: 1474
		bool IsVisible { get; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060005C3 RID: 1475
		string Name { get; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060005C4 RID: 1476
		// (set) Token: 0x060005C5 RID: 1477
		string Label { get; set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060005C6 RID: 1478
		// (set) Token: 0x060005C7 RID: 1479
		bool IsSelfChangeOnly { get; set; }

		// Token: 0x060005C8 RID: 1480
		void RaisePropertyChanged();
	}
}
