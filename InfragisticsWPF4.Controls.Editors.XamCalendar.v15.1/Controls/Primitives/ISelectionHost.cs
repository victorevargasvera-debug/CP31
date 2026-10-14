using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000038 RID: 56
	internal interface ISelectionHost
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000279 RID: 633
		global::System.Windows.FrameworkElement RootElement { get; }

		// Token: 0x0600027A RID: 634
		bool ActivateItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool preventScrollItemIntoView);

		// Token: 0x0600027B RID: 635
		void ClearSnapshot();

		// Token: 0x0600027C RID: 636
		bool DeselectItem(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x0600027D RID: 637
		bool DeselectRange(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x0600027E RID: 638
		void DoAutoScrollHorizontal(global::Infragistics.Controls.Primitives.ISelectableItem item, global::Infragistics.Controls.Primitives.ScrollDirection direction, global::Infragistics.Controls.Primitives.ScrollSpeed speed);

		// Token: 0x0600027F RID: 639
		void DoAutoScrollVertical(global::Infragistics.Controls.Primitives.ISelectableItem item, global::Infragistics.Controls.Primitives.ScrollDirection direction, global::Infragistics.Controls.Primitives.ScrollSpeed speed);

		// Token: 0x06000280 RID: 640
		void EnterSnakingMode(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x06000281 RID: 641
		global::Infragistics.Controls.Primitives.AutoScrollInfo GetAutoScrollInfo(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x06000282 RID: 642
		global::Infragistics.Controls.Primitives.ISelectableItem GetNearestCompatibleItem(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06000283 RID: 643
		global::Infragistics.Controls.Primitives.ISelectableItem GetPivotItem(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x06000284 RID: 644
		global::Infragistics.Controls.Primitives.SelectionStrategyBase GetSelectionStrategyForItem(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x06000285 RID: 645
		bool IsItemSelectableWithCurrentSelection(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x06000286 RID: 646
		bool IsMaxSelectedItemsReached(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x06000287 RID: 647
		bool OnDragStart(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06000288 RID: 648
		void OnDragMove(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06000289 RID: 649
		void OnDragEnd(bool canceled);

		// Token: 0x0600028A RID: 650
		void OnMouseUp(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x0600028B RID: 651
		bool SelectItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool clearExistingSelection);

		// Token: 0x0600028C RID: 652
		bool SelectRange(global::Infragistics.Controls.Primitives.ISelectableItem item, bool clearExistingSelection);

		// Token: 0x0600028D RID: 653
		void SetPivotItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool isRangeSelect);

		// Token: 0x0600028E RID: 654
		void SnapshotSelection(global::Infragistics.Controls.Primitives.ISelectableItem item);

		// Token: 0x0600028F RID: 655
		global::Infragistics.Controls.Primitives.ISelectableItem TranslateItem(global::Infragistics.Controls.Primitives.ISelectableItem item);
	}
}
