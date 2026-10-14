using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002B9 RID: 697
	public class SelectionStrategySingle : global::Infragistics.Windows.Selection.SelectionStrategyBase
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x00067998 File Offset: 0x00065B98
		public SelectionStrategySingle(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x000679A8 File Offset: 0x00065BA8
		public override bool IsSingleSelect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000679AB File Offset: 0x00065BAB
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, false);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000679B8 File Offset: 0x00065BB8
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
				if (item != null && !base.IgnoreNextMouseMove && !base.SelectionHost.ActivateItem(item, false))
				{
					return false;
				}
				this.SelectItemAtPoint(e);
			}
			return true;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00067A3C File Offset: 0x00065C3C
		public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			base.StopHorizontalAutoScrollTimer();
			base.StopVerticalAutoScrollTimer();
			bool inDragMode = base.InDragMode;
			if (base.InDragMode)
			{
				base.SelectionHost.OnDragEnd(false);
				base.InDragMode = false;
			}
			base.SelectionHost.RootElement.ReleaseMouseCapture();
			base.SelectionHost.OnMouseUp(e, !inDragMode && base.IsWithinDblClickThreshold());
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00067AA0 File Offset: 0x00065CA0
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

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x00067B19 File Offset: 0x00065D19
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x00067B21 File Offset: 0x00065D21
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

		// Token: 0x06001B78 RID: 7032 RVA: 0x00067B2C File Offset: 0x00065D2C
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

		// Token: 0x06001B79 RID: 7033 RVA: 0x00067BF8 File Offset: 0x00065DF8
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

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00067C89 File Offset: 0x00065E89
		protected virtual bool ShouldSelectOnDrag
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04000D9A RID: 3482
		private bool _allowToggle = true;
	}
}
