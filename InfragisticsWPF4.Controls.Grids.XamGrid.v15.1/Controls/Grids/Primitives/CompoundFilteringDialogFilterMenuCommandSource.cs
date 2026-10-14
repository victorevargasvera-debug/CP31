using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000143 RID: 323
	public class CompoundFilteringDialogFilterMenuCommandSource : global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogCommandSource
	{
		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x000283C4 File Offset: 0x000265C4
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000283D6 File Offset: 0x000265D6
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> ConditionalCommandParameter
		{
			get
			{
				return (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogFilterMenuCommandSource.ConditionalCommandParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogFilterMenuCommandSource.ConditionalCommandParameterProperty, value);
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x000283E4 File Offset: 0x000265E4
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogCommand commandType = base.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogCommand.ShowCompoundFilterDialog)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ShowCompoundFilterDialogFilterMenuConditionalCommand();
			}
			return result;
		}

		// Token: 0x0400028F RID: 655
		public static readonly global::System.Windows.DependencyProperty ConditionalCommandParameterProperty = global::System.Windows.DependencyProperty.Register("ConditionalCommandParameter", typeof(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>), typeof(global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogFilterMenuCommandSource), null);
	}
}
