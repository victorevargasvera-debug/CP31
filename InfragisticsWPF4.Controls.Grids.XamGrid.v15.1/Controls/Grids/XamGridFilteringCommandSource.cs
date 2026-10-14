using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000BC RID: 188
	public class XamGridFilteringCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001D823 File Offset: 0x0001BA23
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x0001D82B File Offset: 0x0001BA2B
		public global::Infragistics.Controls.Grids.XamGridFilteringCommand CommandType { get; set; }

		// Token: 0x060006AB RID: 1707 RVA: 0x0001D834 File Offset: 0x0001BA34
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			global::Infragistics.Controls.Grids.XamGridFilteringCommand commandType = this.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.XamGridFilteringCommand.ClearFilters)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ClearFilters();
			}
			return result;
		}
	}
}
