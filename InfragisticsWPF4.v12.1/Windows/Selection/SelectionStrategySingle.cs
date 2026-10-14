using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x0200027C RID: 636
	public class SelectionStrategySingle : global::Infragistics.Windows.Selection.SelectionStrategyBase
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x00060838 File Offset: 0x0005EA38
		public SelectionStrategySingle(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00060848 File Offset: 0x0005EA48
		public override bool IsSingleSelect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0006084B File Offset: 0x0005EA4B
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, false);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00060858 File Offset: 0x0005EA58
		public override bool OnMouseMove(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.InDragMode)
			{
				base.DragMove(e);
				return true;
			}
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			if (base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag && this.ShouldStartDrag(mousePointInRootElementCoordinates.X, mousePointInRootElementCoordinates.Y))
			{
				base.DragStart(e);
				return true;
			}
			this.ManageTimers(e);
			if (this.ShouldSelectOnDrag)
			{
				if (item != null && !base.SelectionHost.ActivateItem(item, false))
				{
					return false;
				}
				this.SelectItemAtPoint(e);
			}
			return true;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x000608D4 File Offset: 0x0005EAD4
		public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			base.StopHorizontalAutoScrollTimer();
			base.StopVerticalAutoScrollTimer();
			if (base.InDragMode)
			{
				base.SelectionHost.OnDragEnd(false);
				base.InDragMode = false;
			}
			base.SelectionHost.RootElement.ReleaseMouseCapture();
			base.SelectionHost.OnMouseUp(e);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00060924 File Offset: 0x0005EB24
		public override bool SelectItemViaKeyboard(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle)
		{
			if (forceToggle && (!this._allowToggle || !controlKeyDown))
			{
				return false;
			}
			base.CurrentSelectableItem = item;
			if (!base.SelectionHost.ActivateItem(item, false))
			{
				return false;
			}
			base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.SingleSelect;
			if (!base.CurrentSelectableItem.IsSelected)
			{
				base.SelectionHost.SelectItem(item, true);
			}
			else if (forceToggle && this._allowToggle)
			{
				base.SelectionHost.DeselectItem(base.CurrentSelectableItem);
			}
			return true;
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x0006099D File Offset: 0x0005EB9D
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x000609A5 File Offset: 0x0005EBA5
		public bool AllowToggle
		{
			get
			{
				return this._allowToggle;
			}
			set
			{
				this._allowToggle = value;
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000609B0 File Offset: 0x0005EBB0
		protected virtual bool ProcessMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e, bool forceDrag)
		{
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			base.InitialXPos = mousePointInRootElementCoordinates.X;
			base.InitialYPos = mousePointInRootElementCoordinates.Y;
			base.CurrentSelectableItem = item;
			if (!base.SelectionHost.ActivateItem(item, true))
			{
				return false;
			}
			if (!base.CurrentSelectableItem.IsSelected)
			{
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.SingleSelect;
				base.SelectionHost.SelectItem(base.CurrentSelectableItem, true);
				if (forceDrag && base.CurrentSelectableItem.IsDraggable)
				{
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag;
				}
				return true;
			}
			if (this._allowToggle && base.IsCtrlKeyPressed)
			{
				base.SelectionHost.DeselectItem(base.CurrentSelectableItem);
				return false;
			}
			if (base.CurrentSelectableItem.IsDraggable)
			{
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag;
			}
			else
			{
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreEdit;
			}
			return true;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00060A7C File Offset: 0x0005EC7C
		protected virtual void SelectItemAtPoint(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (base.IgnoreNextMouseMove || !base.IsLeftMouseButtonDown)
			{
				base.IgnoreNextMouseMove = false;
				base.StopHorizontalAutoScrollTimer();
				base.StopVerticalAutoScrollTimer();
				return;
			}
			global::Infragistics.Windows.Selection.ISelectableItem nearestCompatibleItem = base.SelectionHost.GetNearestCompatibleItem(base.CurrentSelectableItem, mouseEventArgs);
			if (nearestCompatibleItem == null || (nearestCompatibleItem == base.CurrentSelectableItem && nearestCompatibleItem.IsSelected) || (base.CurrentSelectableItem != null && nearestCompatibleItem.GetType() != base.CurrentSelectableItem.GetType()))
			{
				return;
			}
			bool flag = base.SelectionHost.SelectItem(nearestCompatibleItem, true);
			if (flag)
			{
				base.CurrentSelectableItem = nearestCompatibleItem;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00060B0D File Offset: 0x0005ED0D
		protected virtual bool ShouldSelectOnDrag
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000C27 RID: 3111
		private bool _allowToggle = true;
	}
}
