using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000BE RID: 190
	public class XamGridFilterMenuFilterTextBoxCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0001D8B2 File Offset: 0x0001BAB2
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
		public global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl FilterSelectionControl
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)base.GetValue(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource.FilterSelectionControlProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource.FilterSelectionControlProperty, value);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0001D8D2 File Offset: 0x0001BAD2
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0001D8E4 File Offset: 0x0001BAE4
		public global::Infragistics.Controls.Grids.Primitives.FilterTextBoxCommand CommandType
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.FilterTextBoxCommand)base.GetValue(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource.CommandTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource.CommandTypeProperty, value);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		private static void CommandTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource xamGridFilterMenuFilterTextBoxCommandSource = (global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource)obj;
			xamGridFilterMenuFilterTextBoxCommandSource.OnPropertyChanged("CommandType");
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001D918 File Offset: 0x0001BB18
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.Primitives.FilterTextBoxCommand.Filter:
				return new global::Infragistics.Controls.Grids.Primitives.FilterMenuFilterTextBoxFilterTextCommand();
			case global::Infragistics.Controls.Grids.Primitives.FilterTextBoxCommand.ClearFilterText:
				return new global::Infragistics.Controls.Grids.Primitives.FilterMenuFilterTextBoxClearFilterTextCommand();
			default:
				return null;
			}
		}

		// Token: 0x040001B3 RID: 435
		public static readonly global::System.Windows.DependencyProperty FilterSelectionControlProperty = global::System.Windows.DependencyProperty.Register("FilterSelectionControl", typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), typeof(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource), null);

		// Token: 0x040001B4 RID: 436
		public static readonly global::System.Windows.DependencyProperty CommandTypeProperty = global::System.Windows.DependencyProperty.Register("CommandType", typeof(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxCommand), typeof(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.XamGridFilterMenuFilterTextBoxCommandSource.CommandTypeChanged)));
	}
}
