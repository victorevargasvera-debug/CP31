using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000042 RID: 66
	internal class SelectionStrategyNone : global::Infragistics.Controls.Primitives.SelectionStrategyBase
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x0000E258 File Offset: 0x0000C458
		public SelectionStrategyNone(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000E264 File Offset: 0x0000C464
		public override bool OnMouseLeftButtonDown(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			base.InitialXPos = mousePointInRootElementCoordinates.X;
			base.InitialYPos = mousePointInRootElementCoordinates.Y;
			base.IgnoreNextMouseMove = false;
			if (!base.SelectionHost.ActivateItem(item, false))
			{
				return false;
			}
			base.CurrentSelectableItem = item;
			return true;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		public override bool OnMouseMove(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.InDragMode)
			{
				base.DragMove(e);
				return true;
			}
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			if (this.ShouldStartDrag(mousePointInRootElementCoordinates.X, mousePointInRootElementCoordinates.Y))
			{
				base.DragStart(e);
			}
			return true;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		public override void OnMouseLeftButtonUp(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			base.StopHorizontalAutoScrollTimer();
			base.StopVerticalAutoScrollTimer();
			base.SelectionHost.OnDragEnd(false);
			base.InDragMode = false;
			base.ReleaseRootElementCapture();
			base.SelectionHost.OnMouseUp(e);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000E32B File Offset: 0x0000C52B
		public override bool SelectItemViaKeyboard(global::Infragistics.Controls.Primitives.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle)
		{
			if (forceToggle)
			{
				return false;
			}
			if (!base.SelectionHost.ActivateItem(item, false))
			{
				return false;
			}
			base.CurrentSelectableItem = item;
			return true;
		}
	}
}
