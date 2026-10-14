using System;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x02000020 RID: 32
	public class CloseCommand : global::Infragistics.Controls.Menus.Primitives.XamContextMenuCommandBase
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00005C32 File Offset: 0x00003E32
		protected override void ExecuteCommand(global::Infragistics.Controls.Menus.XamContextMenu contextMenu)
		{
			contextMenu.IsOpen = false;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005C3B File Offset: 0x00003E3B
		protected override bool CanExecuteCommand(global::Infragistics.Controls.Menus.XamContextMenu contextMenu)
		{
			return contextMenu != null && contextMenu.IsOpen;
		}
	}
}
