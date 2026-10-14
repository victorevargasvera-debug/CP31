using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000F RID: 15
	public class DropEventArgs : global::Infragistics.DragDrop.DragDropMoveEventArgs
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00005F39 File Offset: 0x00004139
		internal DropEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs, global::System.Windows.Input.MouseEventArgs mouseEventArgs) : base(baseArgs, mouseEventArgs)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00005F43 File Offset: 0x00004143
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00005F4B File Offset: 0x0000414B
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Windows.UIElement> DropTargetElements { get; internal set; }
	}
}
