using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000271 RID: 625
	public interface ISelectionHost
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060018DC RID: 6364
		global::System.Windows.FrameworkElement RootElement { get; }

		// Token: 0x060018DD RID: 6365
		bool ActivateItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool preventScrollItemIntoView);

		// Token: 0x060018DE RID: 6366
		void ClearSnapshot();

		// Token: 0x060018DF RID: 6367
		bool DeselectItem(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E0 RID: 6368
		bool DeselectRange(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E1 RID: 6369
		void DoAutoScrollHorizontal(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed);

		// Token: 0x060018E2 RID: 6370
		void DoAutoScrollVertical(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed);

		// Token: 0x060018E3 RID: 6371
		void EnterSnakingMode(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E4 RID: 6372
		global::Infragistics.Windows.Selection.AutoScrollInfo GetAutoScrollInfo(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E5 RID: 6373
		global::Infragistics.Windows.Selection.ISelectableItem GetNearestCompatibleItem(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060018E6 RID: 6374
		global::Infragistics.Windows.Selection.ISelectableItem GetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E7 RID: 6375
		global::Infragistics.Windows.Selection.SelectionStrategyBase GetSelectionStrategyForItem(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E8 RID: 6376
		bool IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018E9 RID: 6377
		bool IsMaxSelectedItemsReached(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018EA RID: 6378
		bool OnDragStart(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060018EB RID: 6379
		void OnDragMove(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060018EC RID: 6380
		void OnDragEnd(bool canceled);

		// Token: 0x060018ED RID: 6381
		void OnMouseUp(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x060018EE RID: 6382
		bool SelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection);

		// Token: 0x060018EF RID: 6383
		bool SelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection);

		// Token: 0x060018F0 RID: 6384
		void SetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool isRangeSelect);

		// Token: 0x060018F1 RID: 6385
		void SnapshotSelection(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x060018F2 RID: 6386
		global::Infragistics.Windows.Selection.ISelectableItem TranslateItem(global::Infragistics.Windows.Selection.ISelectableItem item);
	}
}
