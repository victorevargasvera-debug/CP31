using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000041 RID: 65
	internal class SelectionStrategySingle : global::Infragistics.Controls.Primitives.SelectionStrategyBase
	{
		// Token: 0x060002DB RID: 731 RVA: 0x0000DF9A File Offset: 0x0000C19A
		public SelectionStrategySingle(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000DFAA File Offset: 0x0000C1AA
		public override bool IsSingleSelect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000DFAD File Offset: 0x0000C1AD
		public override bool OnMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return this.ProcessMouseLeftButtonDown(item, e, false);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		public override bool OnMouseMove(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.InDragMode)
			{
				base.DragMove(e);
				return true;
			}
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			if (base.CurrentSelectionState == global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag && this.ShouldStartDrag(mousePointInRootElementCoordinates.X, mousePointInRootElementCoordinates.Y))
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

		// Token: 0x060002DF RID: 735 RVA: 0x0000E031 File Offset: 0x0000C231
		public override void OnMouseLeftButtonUp(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			base.StopHorizontalAutoScrollTimer();
			base.StopVerticalAutoScrollTimer();
			if (base.InDragMode)
			{
				base.SelectionHost.OnDragEnd(false);
				base.InDragMode = false;
			}
			base.ReleaseRootElementCapture();
			base.SelectionHost.OnMouseUp(e);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000E06C File Offset: 0x0000C26C
		public override bool SelectItemViaKeyboard(global::Infragistics.Controls.Primitives.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle)
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
			base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.SingleSelect;
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000E0E5 File Offset: 0x0000C2E5
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000E0ED File Offset: 0x0000C2ED
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

		// Token: 0x060002E3 RID: 739 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		protected virtual bool ProcessMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e, bool forceDrag)
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
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.SingleSelect;
				base.SelectionHost.SelectItem(base.CurrentSelectableItem, true);
				if (forceDrag && base.CurrentSelectableItem.IsDraggable)
				{
					base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag;
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
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreDrag;
			}
			else
			{
				base.CurrentSelectionState = global::Infragistics.Controls.Primitives.SelectionStrategyBase.SelectionState.PreEdit;
			}
			return true;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		protected virtual void SelectItemAtPoint(global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			if (base.IgnoreNextMouseMove || !base.IsMouseCaptured)
			{
				base.IgnoreNextMouseMove = false;
				base.StopHorizontalAutoScrollTimer();
				base.StopVerticalAutoScrollTimer();
				return;
			}
			global::Infragistics.Controls.Primitives.ISelectableItem nearestCompatibleItem = base.SelectionHost.GetNearestCompatibleItem(base.CurrentSelectableItem, mouseEventArgs);
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000E255 File Offset: 0x0000C455
		protected virtual bool ShouldSelectOnDrag
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040001B1 RID: 433
		private bool _allowToggle = true;
	}
}
