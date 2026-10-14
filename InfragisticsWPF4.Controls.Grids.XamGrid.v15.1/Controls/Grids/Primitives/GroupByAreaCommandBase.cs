using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000FB RID: 251
	public abstract class GroupByAreaCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x0002168D File Offset: 0x0001F88D
		public override void Execute(object parameter)
		{
			base.Execute(parameter);
			this.Execute((global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl)parameter);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000216A2 File Offset: 0x0001F8A2
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000858 RID: 2136
		public abstract void Execute(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByArea);
	}
}
