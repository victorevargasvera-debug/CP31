using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200013F RID: 319
	public class XamGridPopupFilterMenuConditionalCommandSource : global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommandSource
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x000281B5 File Offset: 0x000263B5
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000281C7 File Offset: 0x000263C7
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> ConditionalCommandParameter
		{
			get
			{
				return (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>)base.GetValue(global::Infragistics.Controls.Grids.Primitives.XamGridPopupFilterMenuConditionalCommandSource.ConditionalCommandParameterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.XamGridPopupFilterMenuConditionalCommandSource.ConditionalCommandParameterProperty, value);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x000281D8 File Offset: 0x000263D8
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommand commandType = base.CommandType;
			if (commandType == global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommand.ClosePopup)
			{
				return new global::Infragistics.Controls.Grids.Primitives.ClosePopupConditionalCommand();
			}
			return base.ResolveCommand();
		}

		// Token: 0x0400028D RID: 653
		public static readonly global::System.Windows.DependencyProperty ConditionalCommandParameterProperty = global::System.Windows.DependencyProperty.Register("ConditionalCommandParameter", typeof(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>), typeof(global::Infragistics.Controls.Grids.Primitives.XamGridPopupFilterMenuConditionalCommandSource), null);
	}
}
