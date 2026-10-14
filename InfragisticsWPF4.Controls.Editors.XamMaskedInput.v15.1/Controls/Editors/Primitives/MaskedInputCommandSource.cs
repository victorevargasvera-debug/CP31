using System;
using System.Windows.Input;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200000A RID: 10
	public class MaskedInputCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002895 File Offset: 0x00000A95
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000289D File Offset: 0x00000A9D
		public global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId CommandId { get; set; }

		// Token: 0x06000020 RID: 32 RVA: 0x000028A6 File Offset: 0x00000AA6
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			return new global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand(this.CommandId);
		}
	}
}
