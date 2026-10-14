using System;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000D RID: 13
	public class DragDropCancelEventArgs : global::Infragistics.DragDrop.DragDropEventArgs
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00005CF4 File Offset: 0x00003EF4
		internal DragDropCancelEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs)
		{
			base.CopyCursorTemplate = baseArgs.CopyCursorTemplate;
			base.Data = baseArgs.Data;
			base.DragTemplate = baseArgs.DragTemplate;
			base.DragSource = baseArgs.DragSource;
			base.OriginalDragSource = baseArgs.OriginalDragSource;
			base.MoveCursorTemplate = baseArgs.MoveCursorTemplate;
			base.DropNotAllowedCursorTemplate = baseArgs.DropNotAllowedCursorTemplate;
			base.OriginalDragSource = baseArgs.OriginalDragSource;
			base.OperationType = baseArgs.OperationType;
			this.Cancel = false;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00005D7A File Offset: 0x00003F7A
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00005D82 File Offset: 0x00003F82
		public bool Cancel { get; set; }
	}
}
