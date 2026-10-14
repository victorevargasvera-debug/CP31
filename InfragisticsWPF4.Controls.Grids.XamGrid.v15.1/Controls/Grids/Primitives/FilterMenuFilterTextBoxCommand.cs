using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C3 RID: 195
	public class FilterMenuFilterTextBoxCommand : global::Infragistics.CommandBase
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0001DAFD File Offset: 0x0001BCFD
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x0001DB05 File Offset: 0x0001BD05
		protected global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl FilterSelectionControl { get; set; }

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001DB0E File Offset: 0x0001BD0E
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001DB14 File Offset: 0x0001BD14
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl filterSelectionControl = ((global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource)base.CommandSource).FilterSelectionControl;
			if (filterSelectionControl != null)
			{
				this.FilterSelectionControl = filterSelectionControl;
				this.ExecuteCommand(parameter);
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001DB43 File Offset: 0x0001BD43
		protected virtual void ExecuteCommand(object parameter)
		{
		}
	}
}
