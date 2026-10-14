using System;
using System.Windows.Input;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200000B RID: 11
	public class MaskedInputCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002F5D File Offset: 0x0000115D
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002F65 File Offset: 0x00001165
		public global::Infragistics.Controls.Editors.Primitives.MaskedInputCommandId CommandId { get; set; }

		// Token: 0x06000024 RID: 36 RVA: 0x00002F6E File Offset: 0x0000116E
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			return new global::Infragistics.Controls.Editors.Primitives.MaskedInputCommand(this.CommandId);
		}
	}
}
