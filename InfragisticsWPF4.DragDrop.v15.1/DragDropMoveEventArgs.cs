using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000C RID: 12
	public class DragDropMoveEventArgs : global::Infragistics.DragDrop.DragDropEventArgs
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00005DE0 File Offset: 0x00003FE0
		internal DragDropMoveEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs, global::System.Windows.Input.MouseEventArgs mouseEventArgs)
		{
			base.CopyCursorTemplate = baseArgs.CopyCursorTemplate;
			base.Data = baseArgs.Data;
			base.DragTemplate = baseArgs.DragTemplate;
			base.DragSource = baseArgs.DragSource;
			base.OriginalDragSource = baseArgs.OriginalDragSource;
			base.MoveCursorTemplate = baseArgs.MoveCursorTemplate;
			base.DropNotAllowedCursorTemplate = baseArgs.DropNotAllowedCursorTemplate;
			base.OperationType = baseArgs.OperationType;
			this._mouseEventArgs = mouseEventArgs;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005E5C File Offset: 0x0000405C
		public global::System.Windows.Point GetPosition(global::System.Windows.UIElement relativeTo)
		{
			if (this._mouseEventArgs != null)
			{
				return this._mouseEventArgs.GetPosition(relativeTo);
			}
			return default(global::System.Windows.Point);
		}

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Input.MouseEventArgs _mouseEventArgs;
	}
}
