using System;
using System.Windows.Input;
using Infragistics.Controls.Menus.Primitives;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200001D RID: 29
	public class XamContextMenuCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00005B3F File Offset: 0x00003D3F
		// (set) Token: 0x0600011E RID: 286 RVA: 0x00005B47 File Offset: 0x00003D47
		public global::Infragistics.Controls.Menus.XamContextMenuCommand CommandType { get; set; }

		// Token: 0x0600011F RID: 287 RVA: 0x00005B50 File Offset: 0x00003D50
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Menus.XamContextMenuCommand.Open:
				return new global::Infragistics.Controls.Menus.Primitives.OpenCommand();
			case global::Infragistics.Controls.Menus.XamContextMenuCommand.Close:
				return new global::Infragistics.Controls.Menus.Primitives.CloseCommand();
			default:
				return null;
			}
		}
	}
}
