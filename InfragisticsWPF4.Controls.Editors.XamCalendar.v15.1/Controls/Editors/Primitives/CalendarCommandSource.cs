using System;
using System.Windows.Input;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000034 RID: 52
	public class CalendarCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000CC11 File Offset: 0x0000AE11
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0000CC19 File Offset: 0x0000AE19
		public global::Infragistics.Controls.Editors.CalendarCommandType CommandType { get; set; }

		// Token: 0x0600025F RID: 607 RVA: 0x0000CC22 File Offset: 0x0000AE22
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			return new global::Infragistics.Controls.Editors.Primitives.CalendarCommand(this.CommandType);
		}
	}
}
