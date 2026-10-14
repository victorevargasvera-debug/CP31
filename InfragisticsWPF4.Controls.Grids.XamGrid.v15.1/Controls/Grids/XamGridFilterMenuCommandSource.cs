using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000BD RID: 189
	public class XamGridFilterMenuCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0001D85D File Offset: 0x0001BA5D
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0001D86F File Offset: 0x0001BA6F
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> CommandType
		{
			get
			{
				return (global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>)base.GetValue(global::Infragistics.Controls.Grids.XamGridFilterMenuCommandSource.CommandTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGridFilterMenuCommandSource.CommandTypeProperty, value);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001D87D File Offset: 0x0001BA7D
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FilterMenuCommands();
		}

		// Token: 0x040001B2 RID: 434
		public static readonly global::System.Windows.DependencyProperty CommandTypeProperty = global::System.Windows.DependencyProperty.Register("CommandType", typeof(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>), typeof(global::Infragistics.Controls.Grids.XamGridFilterMenuCommandSource), null);
	}
}
