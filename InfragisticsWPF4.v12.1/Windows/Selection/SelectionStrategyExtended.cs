using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Infragistics.Windows.Selection
{
	// Token: 0x0200027E RID: 638
	public class SelectionStrategyExtended : global::Infragistics.Windows.Selection.SelectionStrategyBase
	{
		// Token: 0x06001953 RID: 6483 RVA: 0x00060C16 File Offset: 0x0005EE16
		public SelectionStrategyExtended(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x00060C26 File Offset: 0x0005EE26
		public override bool IsMultiSelect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00060C29 File Offset: 0x0005EE29
		public virtual bool IsDiscontiguousAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00060C2C File Offset: 0x0005EE2C
		public override bool CanItemBeNavigatedTo(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown)
		{
			return base.CanItemBeNavigatedTo(item, shiftKeyDown, controlKeyDown) && ((!shiftKeyDown && !controlKeyDown) || base.SelectionHost.IsItemSelectableWithCurrentSelection(item));
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00060C4F File Offset: 0x0005EE4F
		protected override void OnDragStartCanceled()
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00060C51 File Offset: 0x0005EE51
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, false);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00060C5C File Offset: 0x0005EE5C
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
			if (!base.SelectionHost.ActivateItem(item, false))
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

		// Token: 0x0600195A RID: 6490 RVA: 0x00060DEC File Offset: 0x0005EFEC
		public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
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
							bool flag = false;
							if (base.IsCtrlKeyPressed && this.IsDiscontiguousAllowed)
							{
								flag = true;
							}
							if (flag)
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
				base.SelectionHost.OnMouseUp(e);
			}
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00060F18 File Offset: 0x0005F118
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x000610AD File Offset: 0x0005F2AD
		protected virtual global::System.Windows.Threading.DispatcherPriority DragDelayTimerDispatcherPriority
		{
			get
			{
				return global::System.Windows.Threading.DispatcherPriority.Normal;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x000610B1 File Offset: 0x0005F2B1
		protected virtual double DragDelayTimerInterval
		{
			get
			{
				return 750.0;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x000610BC File Offset: 0x0005F2BC
		protected bool ShouldSelect
		{
			get
			{
				return this._shouldSelect;
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000610C4 File Offset: 0x0005F2C4
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

		// Token: 0x06001960 RID: 6496 RVA: 0x00061334 File Offset: 0x0005F534
		protected void StartDragDelayTimer()
		{
			this.StopDragDelayTimer();
			this._dragDelayTimer = new global::System.Windows.Threading.DispatcherTimer(this.DragDelayTimerDispatcherPriority);
			this._dragDelayTimer.Interval = global::System.TimeSpan.FromMilliseconds(this.DragDelayTimerInterval);
			this._dragDelayTimer.Tick += this.OnDragDelayTimerTick;
			this._dragDelayTimer.Start();
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00061390 File Offset: 0x0005F590
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

		// Token: 0x06001962 RID: 6498 RVA: 0x000613C1 File Offset: 0x0005F5C1
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

		// Token: 0x04000C28 RID: 3112
		private bool _isInManualDragMode;

		// Token: 0x04000C29 RID: 3113
		private bool _shouldSelect = true;

		// Token: 0x04000C2A RID: 3114
		private bool _selectionDragCanceled;

		// Token: 0x04000C2B RID: 3115
		private global::System.Windows.Threading.DispatcherTimer _dragDelayTimer;

		// Token: 0x04000C2C RID: 3116
		private global::System.Windows.Input.MouseEventArgs _initialMouseDownEventArgs;
	}
}
