using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002BA RID: 698
	public class SelectionStrategyNone : global::Infragistics.Windows.Selection.SelectionStrategyBase
	{
		// Token: 0x06001B7B RID: 7035 RVA: 0x00067C8C File Offset: 0x00065E8C
		public SelectionStrategyNone(global::Infragistics.Windows.Selection.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x00067C98 File Offset: 0x00065E98
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

		// Token: 0x06001B7D RID: 7037 RVA: 0x00067CF0 File Offset: 0x00065EF0
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

		// Token: 0x06001B7E RID: 7038 RVA: 0x00067D34 File Offset: 0x00065F34
		public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			base.StopHorizontalAutoScrollTimer();
			base.StopVerticalAutoScrollTimer();
			base.SelectionHost.OnDragEnd(false);
			base.InDragMode = false;
			base.SelectionHost.RootElement.ReleaseMouseCapture();
			base.SelectionHost.OnMouseUp(e, false);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x00067D72 File Offset: 0x00065F72
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
