using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000141 RID: 321
	public class CustomFilteringDialogFilterMenuCommandSource : global::Infragistics.Controls.Grids.CustomFilteringDialogCommandSource
	{
		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00028287 File Offset: 0x00026487
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00028299 File Offset: 0x00026499
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> ConditionalCommandParameter
		{
			get
			{
				return (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CustomFilteringDialogFilterMenuCommandSource.ConditionalCommandParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CustomFilteringDialogFilterMenuCommandSource.ConditionalCommandParameterProperty, value);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000282A8 File Offset: 0x000264A8
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			global::Infragistics.Controls.Grids.CustomFilteringDialogCommand commandType = base.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.CustomFilteringDialogCommand.ShowCustomFilterDialog)
			{
				result = new global::Infragistics.Controls.Grids.Primitives.ShowCustomFilterDialogFilterMenuConditionalCommand();
			}
			return result;
		}

		// Token: 0x0400028E RID: 654
		public static readonly global::System.Windows.DependencyProperty ConditionalCommandParameterProperty = global::System.Windows.DependencyProperty.Register("ConditionalCommandParameter", typeof(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>), typeof(global::Infragistics.Controls.Grids.Primitives.CustomFilteringDialogFilterMenuCommandSource), null);
	}
}
