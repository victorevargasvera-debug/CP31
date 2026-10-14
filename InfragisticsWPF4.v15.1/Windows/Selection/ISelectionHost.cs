using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002AE RID: 686
	public interface ISelectionHost
	{
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001B06 RID: 6918
		global::System.Windows.FrameworkElement RootElement { get; }

		// Token: 0x06001B07 RID: 6919
		bool ActivateItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool preventScrollItemIntoView);

		// Token: 0x06001B08 RID: 6920
		void ClearSnapshot();

		// Token: 0x06001B09 RID: 6921
		bool DeselectItem(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B0A RID: 6922
		bool DeselectRange(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B0B RID: 6923
		void DoAutoScrollHorizontal(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed);

		// Token: 0x06001B0C RID: 6924
		void DoAutoScrollVertical(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed);

		// Token: 0x06001B0D RID: 6925
		void EnterSnakingMode(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B0E RID: 6926
		global::Infragistics.Windows.Selection.AutoScrollInfo GetAutoScrollInfo(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B0F RID: 6927
		global::Infragistics.Windows.Selection.ISelectableItem GetNearestCompatibleItem(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001B10 RID: 6928
		global::Infragistics.Windows.Selection.ISelectableItem GetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B11 RID: 6929
		global::Infragistics.Windows.Selection.SelectionStrategyBase GetSelectionStrategyForItem(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B12 RID: 6930
		bool IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B13 RID: 6931
		bool IsMaxSelectedItemsReached(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B14 RID: 6932
		bool OnDragStart(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001B15 RID: 6933
		void OnDragMove(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001B16 RID: 6934
		void OnDragEnd(bool canceled);

		// Token: 0x06001B17 RID: 6935
		void OnMouseUp(global::System.Windows.Input.MouseEventArgs e, bool preventScrollItemIntoView);

		// Token: 0x06001B18 RID: 6936
		void ScrollPendingItemIntoView();

		// Token: 0x06001B19 RID: 6937
		bool SelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection);

		// Token: 0x06001B1A RID: 6938
		bool SelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection);

		// Token: 0x06001B1B RID: 6939
		void SetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool isRangeSelect);

		// Token: 0x06001B1C RID: 6940
		void SnapshotSelection(global::Infragistics.Windows.Selection.ISelectableItem item);

		// Token: 0x06001B1D RID: 6941
		global::Infragistics.Windows.Selection.ISelectableItem TranslateItem(global::Infragistics.Windows.Selection.ISelectableItem item);
	}
}
