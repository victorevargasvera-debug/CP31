using System;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001EB RID: 491
	[global::System.Windows.TemplatePart(Name = "Indicator", Type = typeof(global::Infragistics.Controls.Primitives.ExpansionIndicator))]
	public class ExpansionIndicatorCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x000341F8 File Offset: 0x000323F8
		public ExpansionIndicatorCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCellControl);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x00034210 File Offset: 0x00032410
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x00034218 File Offset: 0x00032418
		public global::Infragistics.Controls.Primitives.ExpansionIndicator ExpansionIndicator { get; private set; }

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00034221 File Offset: 0x00032421
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ExpansionIndicator = (base.GetTemplateChild("Indicator") as global::Infragistics.Controls.Primitives.ExpansionIndicator);
			this.EnsureContent();
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00034245 File Offset: 0x00032445
		protected override void OnLoaded()
		{
			base.OnLoaded();
			this.EnsureContent();
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00034254 File Offset: 0x00032454
		protected internal override void EnsureContent()
		{
			if (this.ExpansionIndicator != null && base.Cell != null)
			{
				if (((global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase)base.Cell.Row).HasChildren)
				{
					this.ExpansionIndicator.Visibility = global::System.Windows.Visibility.Visible;
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath("IsExpanded", new object[0]);
					binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					binding.Source = base.Cell.Row;
					this.ExpansionIndicator.SetBinding(global::Infragistics.Controls.Primitives.ExpansionIndicator.IsExpandedProperty, binding);
				}
				else
				{
					this.ExpansionIndicator.Visibility = global::System.Windows.Visibility.Collapsed;
				}
			}
			base.EnsureContent();
		}
	}
}
