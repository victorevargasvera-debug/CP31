using System;
using System.Collections.ObjectModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200009E RID: 158
	public interface IListEdit
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060005C9 RID: 1481
		global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> Items { get; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060005CA RID: 1482
		// (set) Token: 0x060005CB RID: 1483
		int SelectedIndex { get; set; }

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060005CC RID: 1484
		bool IsReferField { get; }

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060005CD RID: 1485
		bool SortedDefaultValue { get; }

		// Token: 0x060005CE RID: 1486
		void RefreshChoices(bool isSortRequired);
	}
}
