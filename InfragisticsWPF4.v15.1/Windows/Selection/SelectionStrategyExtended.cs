using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002BB RID: 699
	public class SelectionStrategyExtended : global::Infragistics.Windows.Selection.SelectionStrategyBase
	{
		// Token: 0x06001B80 RID: 7040 RVA: 0x00067D93 File Offset: 0x00065F93
		public SelectionStrategyExtended(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x00067DA3 File Offset: 0x00065FA3
		public override bool IsMultiSelect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x00067DA6 File Offset: 0x00065FA6
		public virtual bool IsDiscontiguousAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00067DA9 File Offset: 0x00065FA9
		public override bool CanItemBeNavigatedTo(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown)
		{
			return base.CanItemBeNavigatedTo(item, shiftKeyDown, controlKeyDown) && ((!shiftKeyDown && !controlKeyDown) || base.SelectionHost.IsItemSelectableWithCurrentSelection(item));
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00067DCC File Offset: 0x00065FCC
		protected override void OnDragStartCanceled()
		{
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00067DCE File Offset: 0x00065FCE
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, false);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00067DDC File Offset: 0x00065FDC
		public override bool OnMouseMove(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.InDragMode)
			{
				base.DragMove(e);
				return true;
			}
			if (base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag && this._isInManualDragMode)
			{
				base.SelectionHost.RootElement.ReleaseMouseCapture();
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
				return true;
			}
			bool flag = false;
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			if ((base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag || base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag) && this.ShouldStartDrag(mousePointInRootElementCoordinates.X, mousePointInRootElementCoordinates.Y))
			{
				if (base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag)
				{
					base.DragStart(e);
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
					return true;
				}
				flag = true;
				this.StopDragDelayTimer();
			}
			if (!base.IsLeftMouseButtonDown)
			{
				base.StopHorizontalAutoScrollTimer();
				base.StopVerticalAutoScrollTimer();
			}
			else
			{
				this.ManageTimers(e);
			}
			if (base.IgnoreNextMouseMove || !base.IsLeftMouseButtonDown)
			{
				base.IgnoreNextMouseMove = false;
				return true;
			}
			item = base.SelectionHost.GetNearestCompatibleItem(base.CurrentSelectableItem, e);
			if (item == null)
			{
				return true;
			}
			item = base.SelectionHost.TranslateItem(item);
			if (item == null)
			{
				return true;
			}
			if (base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag && (this._selectionDragCanceled || flag))
			{
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
			}
			else if (item == base.CurrentSelectableItem)
			{
				return true;
			}
			base.CurrentSelectableItem = item;
			if (!base.SelectionHost.ActivateItem(item, base.IsWithinDblClickThreshold() && !base.InDragMode))
			{
				return false;
			}
			bool flag2 = base.IsCtrlKeyPressed && this.IsDiscontiguousAllowed;
			if (flag2)
			{
				if (this._shouldSelect)
				{
					base.SelectionHost.SelectRange(item, false);
				}
				else
				{
					base.SelectionHost.DeselectRange(item);
				}
			}
			else
			{
				base.SelectionHost.SelectRange(item, true);
			}
			base.IgnoreNextMouseMove = true;
			return true;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00067F80 File Offset: 0x00066180
		public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			bool flag = this._isInManualDragMode || base.InDragMode;
			try
			{
				this.StopDragDelayTimer();
				base.StopHorizontalAutoScrollTimer();
				base.StopVerticalAutoScrollTimer();
				if (this._isInManualDragMode)
				{
					base.SelectionHost.OnDragEnd(false);
					this._isInManualDragMode = false;
				}
				base.IgnoreNextMouseMove = false;
				if (base.CurrentSelectionState != global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag && base.CurrentSelectionState != global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag)
				{
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
				}
				else
				{
					item = base.SelectionHost.TranslateItem(item);
					if (item != null && base.CurrentSelectableItem != null && !(item.GetType() != base.CurrentSelectableItem.GetType()))
					{
						if (base.CurrentSelectionState != global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag || base.CurrentSelectionState != global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag || !base.IsShiftKeyPressed)
						{
							base.SelectionHost.SetPivotItem(item, false);
							bool flag2 = false;
							if (base.IsCtrlKeyPressed && this.IsDiscontiguousAllowed)
							{
								flag2 = true;
							}
							if (flag2)
							{
								if (this.ShouldSelect)
								{
									base.SelectionHost.SelectItem(item, false);
								}
								else
								{
									base.SelectionHost.DeselectItem(item);
								}
							}
							else
							{
								base.SelectionHost.SelectItem(item, true);
							}
						}
					}
				}
			}
			finally
			{
				base.SelectionHost.OnMouseUp(e, !flag && base.IsWithinDblClickThreshold());
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x000680C8 File Offset: 0x000662C8
		public override bool SelectItemViaKeyboard(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle)
		{
			bool flag = (controlKeyDown || forceToggle) && this.IsDiscontiguousAllowed;
			if (shiftKeyDown && !base.SelectionHost.IsItemSelectableWithCurrentSelection(item))
			{
				return false;
			}
			if (!base.SelectionHost.ActivateItem(item, false))
			{
				return false;
			}
			if (!shiftKeyDown && flag && !forceToggle)
			{
				return true;
			}
			base.CurrentSelectableItem = item;
			this._shouldSelect = true;
			base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
			base.SelectionHost.SetPivotItem(item, shiftKeyDown);
			if (!flag && item.IsSelected && item.IsDraggable && forceToggle)
			{
				return false;
			}
			if (flag)
			{
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ControlClick;
				if (!shiftKeyDown)
				{
					this._shouldSelect = !item.IsSelected;
				}
				else
				{
					this._shouldSelect = base.SelectionHost.GetPivotItem(item).IsSelected;
				}
			}
			if (this._shouldSelect && flag && base.SelectionHost.IsMaxSelectedItemsReached(item))
			{
				return false;
			}
			if (!flag)
			{
				base.SelectionHost.ClearSnapshot();
			}
			if (flag && !shiftKeyDown)
			{
				base.SelectionHost.SnapshotSelection(item);
			}
			if (shiftKeyDown)
			{
				if (flag)
				{
					base.SelectionHost.EnterSnakingMode(item);
					if (this._shouldSelect)
					{
						base.SelectionHost.SelectRange(item, false);
					}
					else
					{
						base.SelectionHost.DeselectRange(item);
					}
				}
				else
				{
					base.SelectionHost.SelectRange(item, true);
				}
			}
			else if (flag)
			{
				if (this._shouldSelect)
				{
					base.SelectionHost.SelectItem(item, false);
				}
				else
				{
					base.SelectionHost.DeselectItem(item);
				}
			}
			else
			{
				base.SelectionHost.SelectItem(item, true);
			}
			return !this._shouldSelect || !base.SelectionHost.IsMaxSelectedItemsReached(item);
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0006825D File Offset: 0x0006645D
		protected virtual global::System.Windows.Threading.DispatcherPriority DragDelayTimerDispatcherPriority
		{
			get
			{
				return global::System.Windows.Threading.DispatcherPriority.Normal;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00068261 File Offset: 0x00066461
		protected virtual double DragDelayTimerInterval
		{
			get
			{
				return 750.0;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0006826C File Offset: 0x0006646C
		protected bool ShouldSelect
		{
			get
			{
				return this._shouldSelect;
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00068274 File Offset: 0x00066474
		protected virtual bool ProcessMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e, bool forceDrag)
		{
			this._isInManualDragMode = false;
			bool isShiftKeyPressed = base.IsShiftKeyPressed;
			bool flag = false;
			if (base.IsCtrlKeyPressed && this.IsDiscontiguousAllowed)
			{
				flag = true;
			}
			if ((isShiftKeyPressed || flag) && !base.SelectionHost.IsItemSelectableWithCurrentSelection(item))
			{
				return false;
			}
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			base.InitialXPos = mousePointInRootElementCoordinates.X;
			base.InitialYPos = mousePointInRootElementCoordinates.Y;
			this._initialMouseDownEventArgs = e;
			base.CurrentSelectableItem = item;
			this._shouldSelect = true;
			if (!base.SelectionHost.ActivateItem(item, true))
			{
				return false;
			}
			if (item.IsSelected || !item.IsSelectable || forceDrag)
			{
				if (item.IsDraggable)
				{
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag;
				}
				else if (!flag)
				{
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag;
					this._selectionDragCanceled = false;
					this.StartDragDelayTimer();
				}
				else
				{
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
				}
				if (isShiftKeyPressed && (base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PreDrag || base.CurrentSelectionState == global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.PotentialPreDrag))
				{
					base.SelectionHost.ClearSnapshot();
					if (flag)
					{
						base.SelectionHost.SnapshotSelection(item);
						this._shouldSelect = base.SelectionHost.GetPivotItem(item).IsSelected;
						if (this._shouldSelect)
						{
							base.SelectionHost.SelectRange(item, false);
						}
						else
						{
							base.SelectionHost.DeselectRange(item);
						}
					}
					else
					{
						base.SelectionHost.SelectRange(item, true);
					}
					return false;
				}
			}
			else
			{
				base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ExtSelect;
			}
			base.SelectionHost.SetPivotItem(item, isShiftKeyPressed);
			if (item.IsSelected && item.IsDraggable)
			{
				if (flag)
				{
					this._shouldSelect = false;
				}
				return true;
			}
			if (flag)
			{
				if (!forceDrag)
				{
					base.CurrentSelectionState = global::Infragistics.Windows.Selection.SelectionStrategyBase.SelectionState.ControlClick;
				}
				if (!isShiftKeyPressed)
				{
					this._shouldSelect = !item.IsSelected;
				}
				else
				{
					this._shouldSelect = base.SelectionHost.GetPivotItem(item).IsSelected;
				}
			}
			else if (item.IsSelected)
			{
				return true;
			}
			base.SelectionHost.ClearSnapshot();
			if (flag)
			{
				base.SelectionHost.SnapshotSelection(item);
			}
			if (isShiftKeyPressed)
			{
				if (flag)
				{
					if (this._shouldSelect)
					{
						base.SelectionHost.SelectRange(item, false);
					}
					else
					{
						base.SelectionHost.DeselectRange(item);
					}
				}
				else
				{
					base.SelectionHost.SelectRange(item, true);
				}
			}
			else if (flag)
			{
				if (this._shouldSelect)
				{
					base.SelectionHost.SelectItem(item, false);
				}
				else
				{
					base.SelectionHost.DeselectItem(item);
				}
			}
			else
			{
				base.SelectionHost.SelectItem(item, true);
			}
			return !this._shouldSelect || !base.SelectionHost.IsMaxSelectedItemsReached(item);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000684E4 File Offset: 0x000666E4
		protected void StartDragDelayTimer()
		{
			this.StopDragDelayTimer();
			this._dragDelayTimer = new global::System.Windows.Threading.DispatcherTimer(this.DragDelayTimerDispatcherPriority);
			this._dragDelayTimer.Interval = global::System.TimeSpan.FromMilliseconds(this.DragDelayTimerInterval);
			this._dragDelayTimer.Tick += this.OnDragDelayTimerTick;
			this._dragDelayTimer.Start();
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00068540 File Offset: 0x00066740
		private void OnDragDelayTimerTick(object sender, global::System.EventArgs e)
		{
			if (!base.SelectionHost.OnDragStart(base.CurrentSelectableItem, this._initialMouseDownEventArgs))
			{
				this._selectionDragCanceled = true;
			}
			else
			{
				this._isInManualDragMode = true;
			}
			this.StopDragDelayTimer();
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00068571 File Offset: 0x00066771
		protected void StopDragDelayTimer()
		{
			if (this._dragDelayTimer == null)
			{
				return;
			}
			this._dragDelayTimer.Stop();
			this._dragDelayTimer.Tick -= this.OnDragDelayTimerTick;
			this._dragDelayTimer = null;
		}

		// Token: 0x04000D9B RID: 3483
		private bool _isInManualDragMode;

		// Token: 0x04000D9C RID: 3484
		private bool _shouldSelect = true;

		// Token: 0x04000D9D RID: 3485
		private bool _selectionDragCanceled;

		// Token: 0x04000D9E RID: 3486
		private global::System.Windows.Threading.DispatcherTimer _dragDelayTimer;

		// Token: 0x04000D9F RID: 3487
		private global::System.Windows.Input.MouseEventArgs _initialMouseDownEventArgs;
	}
}
