using System;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000017 RID: 23
	public interface IMultiSelectionListEdit
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000A1 RID: 161
		global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> Items { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A2 RID: 162
		global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> SelectedItems { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A3 RID: 163
		global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> AvailableListBoxSelectedItems { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A4 RID: 164
		global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.ObservableCollectionFast<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> SelectedListBoxSelctedItems { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A5 RID: 165
		// (set) Token: 0x060000A6 RID: 166
		int SelectedIndex { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A7 RID: 167
		bool IsInitialized { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A8 RID: 168
		global::System.Windows.Input.ICommand AddCommand { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A9 RID: 169
		global::System.Windows.Input.ICommand RemoveCommand { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AA RID: 170
		global::System.Windows.Input.ICommand AddAllCommand { get; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000AB RID: 171
		global::System.Windows.Input.ICommand RemoveAllCommand { get; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000AC RID: 172
		global::System.Windows.Input.ICommand MoveItemUpCommand { get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000AD RID: 173
		global::System.Windows.Input.ICommand MoveItemDownCommand { get; }

		// Token: 0x060000AE RID: 174
		void RefreshItemList(bool isRefreshSelectedListOnly = false);
	}
}
