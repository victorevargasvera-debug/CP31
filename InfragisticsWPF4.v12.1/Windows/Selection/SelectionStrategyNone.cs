using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x0200027D RID: 637
	public class SelectionStrategyNone : global::Infragistics.Windows.Selection.SelectionStrategyBase
	{
		// Token: 0x0600194E RID: 6478 RVA: 0x00060B10 File Offset: 0x0005ED10
		public SelectionStrategyNone(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00060B1C File Offset: 0x0005ED1C
		public override bool OnMouseLeftButtonDown(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point mousePointInRootElementCoordinates = base.GetMousePointInRootElementCoordinates(e);
			base.InitialXPos = mousePointInRootElementCoordinates.X;
			base.InitialYPos = mousePointInRootElementCoordinates.Y;
			if (base.IsLeftMouseButtonDown)
			{
				base.IgnoreNextMouseMove = false;
			}
			if (!base.SelectionHost.ActivateItem(item, false))
			{
				return false;
			}
			base.CurrentSelectableItem = item;
			return true;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00060B74 File Offset: 0x0005ED74
		public override bool OnMouseMove(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
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

		// Token: 0x06001951 RID: 6481 RVA: 0x00060BB8 File Offset: 0x0005EDB8
		public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			base.StopHorizontalAutoScrollTimer();
			base.StopVerticalAutoScrollTimer();
			base.SelectionHost.OnDragEnd(false);
			base.InDragMode = false;
			base.SelectionHost.RootElement.ReleaseMouseCapture();
			base.SelectionHost.OnMouseUp(e);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00060BF5 File Offset: 0x0005EDF5
		public override bool SelectItemViaKeyboard(global::Infragistics.Windows.Selection.ISelectableItem item, bool shiftKeyDown, bool controlKeyDown, bool forceToggle)
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
