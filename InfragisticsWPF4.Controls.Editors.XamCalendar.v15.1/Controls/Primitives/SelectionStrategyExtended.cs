using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000043 RID: 67
	internal class SelectionStrategyExtended : global::Infragistics.Controls.Primitives.SelectionStrategyBase
	{
		// Token: 0x060002EB RID: 747 RVA: 0x0000E34C File Offset: 0x0000C54C
		public SelectionStrategyExtended(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000E35C File Offset: 0x0000C55C
		public override bool IsMultiSelect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000E35F File Offset: 0x0000C55F
		public virtual bool IsDiscontiguousAllowed
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000E362 File Offset: 0x0000C562
		public override bool CanItemBeNavigatedTo(global::Infragistics.Controls.Primitives.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown)
		{
			return base.CanItemBeNavigatedTo(item, shiftKeyDown, controlKeyDown) && ((!shiftKeyDown && !controlKeyDown) || base.SelectionHost.IsItemSelectableWithCurrentSelection(item));
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000E385 File Offset: 0x0000C585
		protected override void OnDragStartCanceled()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000E387 File Offset: 0x0000C587
		public override bool OnMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, false);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000E394 File Offset: 0x0000C594
		public override bool OnMouseMove(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.InDragMode)
			{
				base.DragMove(e);
				return true;
			}
			if (base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag && this._isInManualDragMode)
			{
				base.ReleaseRootElementCapture();
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
				return true;
			}
			bool flag = false;
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			if ((base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag || base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag) && this.ShouldStartDrag(mousePointInRootElementCoordinates.X, mousePointInRootElementCoordinates.Y))
			{
				if (base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag)
				{
					base.DragStart(e);
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
					return true;
				}
				flag = true;
				this.StopDragDelayTimer();
			}
			if (!base.IsMouseCaptured)
			{
				base.StopHorizontalAutoScrollTimer();
				base.StopVerticalAutoScrollTimer();
			}
			else
			{
				this.ManageTimers(e);
			}
			if (base.IgnoreNextMouseMove || !base.IsMouseCaptured)
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
			if (base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag && (this._selectionDragCanceled || flag))
			{
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
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

		// Token: 0x060002F2 RID: 754 RVA: 0x0000E51C File Offset: 0x0000C71C
		public override void OnMouseLeftButtonUp(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
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
				if (base.CurrentSelectionState != global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag && base.CurrentSelectionState != global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag)
				{
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
				}
				else
				{
					item = base.SelectionHost.TranslateItem(item);
					if (item != null && base.CurrentSelectableItem != null && !(item.GetType() != base.CurrentSelectableItem.GetType()))
					{
						if (base.CurrentSelectionState != global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag || base.CurrentSelectionState != global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag || !base.IsShiftKeyPressed)
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

		// Token: 0x060002F3 RID: 755 RVA: 0x0000E648 File Offset: 0x0000C848
		public override bool SelectItemViaKeyboard(global::Infragistics.Controls.Primitives.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle)
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
			base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
			base.SelectionHost.SetPivotItem(item, shiftKeyDown);
			if (!flag && item.IsSelected && item.IsDraggable && forceToggle)
			{
				return false;
			}
			if (flag)
			{
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ControlClick;
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000E7DD File Offset: 0x0000C9DD
		protected virtual double DragDelayTimerInterval
		{
			get
			{
				return 750.0;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
		protected bool ShouldSelect
		{
			get
			{
				return this._shouldSelect;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		protected virtual bool ProcessMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e, bool forceDrag)
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
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag;
				}
				else if (!flag)
				{
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag;
					this._selectionDragCanceled = false;
					this.StartDragDelayTimer();
				}
				else
				{
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
				}
				if (isShiftKeyPressed && (base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag || base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PotentialPreDrag))
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
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ExtSelect;
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
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.ControlClick;
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

		// Token: 0x060002F7 RID: 759 RVA: 0x0000EA60 File Offset: 0x0000CC60
		protected void StartDragDelayTimer()
		{
			this.StopDragDelayTimer();
			this._dragDelayTimer = new global::System.Windows.Threading.DispatcherTimer();
			this._dragDelayTimer.Interval = global::System.TimeSpan.FromMilliseconds(this.DragDelayTimerInterval);
			this._dragDelayTimer.Tick += this.OnDragDelayTimerTick;
			this._dragDelayTimer.Start();
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000EAB6 File Offset: 0x0000CCB6
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

		// Token: 0x060002F9 RID: 761 RVA: 0x0000EAE7 File Offset: 0x0000CCE7
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

		// Token: 0x040001B2 RID: 434
		private bool _isInManualDragMode;

		// Token: 0x040001B3 RID: 435
		private bool _shouldSelect = true;

		// Token: 0x040001B4 RID: 436
		private bool _selectionDragCanceled;

		// Token: 0x040001B5 RID: 437
		private global::System.Windows.Threading.DispatcherTimer _dragDelayTimer;

		// Token: 0x040001B6 RID: 438
		private global::System.Windows.Input.MouseEventArgs _initialMouseDownEventArgs;
	}
}
