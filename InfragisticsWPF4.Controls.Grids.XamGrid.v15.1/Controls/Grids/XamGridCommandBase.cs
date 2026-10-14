using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000298 RID: 664
	public abstract class XamGridCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06001800 RID: 6144 RVA: 0x0005E649 File Offset: 0x0005C849
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0005E64C File Offset: 0x0005C84C
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.XamGrid xamGrid = parameter as global::Infragistics.Controls.Grids.XamGrid;
			if (xamGrid != null)
			{
				this.Execute(xamGrid);
			}
			base.Execute(parameter);
		}

		// Token: 0x06001802 RID: 6146
		protected abstract void Execute(global::Infragistics.Controls.Grids.XamGrid parameter);
	}
}
