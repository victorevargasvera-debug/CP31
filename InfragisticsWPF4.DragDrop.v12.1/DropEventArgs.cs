using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000F RID: 15
	public class DropEventArgs : global::Infragistics.DragDrop.DragDropMoveEventArgs
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00005DA5 File Offset: 0x00003FA5
		internal DropEventArgs(global::Infragistics.DragDrop.DragDropEventArgs baseArgs, global::System.Windows.Input.MouseEventArgs mouseEventArgs) : base(baseArgs, mouseEventArgs)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00005DAF File Offset: 0x00003FAF
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Windows.UIElement> DropTargetElements { get; internal set; }
	}
}
