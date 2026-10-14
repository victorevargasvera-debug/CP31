using System;
using System.Windows;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x0200001F RID: 31
	public class OpenCommand : global::Infragistics.Controls.Menus.Primitives.XamContextMenuCommandBase
	{
		// Token: 0x06000126 RID: 294 RVA: 0x00005BF5 File Offset: 0x00003DF5
		protected override void ExecuteCommand(global::Infragistics.Controls.Menus.XamContextMenu contextMenu)
		{
			global::Infragistics.Controls.Menus.ContextMenuService.PositionContextMenu(contextMenu, new global::System.Windows.Point(0.0, 0.0), contextMenu.ParentElement);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005C1A File Offset: 0x00003E1A
		protected override bool CanExecuteCommand(global::Infragistics.Controls.Menus.XamContextMenu contextMenu)
		{
			return contextMenu != null && !contextMenu.IsOpen;
		}
	}
}
