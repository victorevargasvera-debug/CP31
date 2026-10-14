using System;

namespace Infragistics.Controls.Menus.Primitives
{
	// Token: 0x0200001E RID: 30
	public abstract class XamContextMenuCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06000121 RID: 289 RVA: 0x00005B8C File Offset: 0x00003D8C
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = parameter as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null)
			{
				return this.CanExecuteCommand(xamContextMenu);
			}
			return base.CanExecute(parameter);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Menus.XamContextMenu xamContextMenu = parameter as global::Infragistics.Controls.Menus.XamContextMenu;
			if (xamContextMenu != null)
			{
				this.ExecuteCommand(xamContextMenu);
				if (base.CommandSource != null)
				{
					base.CommandSource.Handled = true;
				}
			}
			base.Execute(parameter);
		}

		// Token: 0x06000123 RID: 291
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Menus.XamContextMenu contextMenu);

		// Token: 0x06000124 RID: 292
		protected abstract bool CanExecuteCommand(global::Infragistics.Controls.Menus.XamContextMenu contextMenu);
	}
}
