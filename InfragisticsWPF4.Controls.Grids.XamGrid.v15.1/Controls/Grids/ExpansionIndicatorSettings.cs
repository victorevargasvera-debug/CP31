using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000068 RID: 104
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell))]
	public class ExpansionIndicatorSettings : global::Infragistics.Controls.Grids.VisualSettingsBase
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0001030F File Offset: 0x0000E50F
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00010321 File Offset: 0x0000E521
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings.HeaderStyleProperty, value);
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00010330 File Offset: 0x0000E530
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ExpansionIndicatorSettings expansionIndicatorSettings = (global::Infragistics.Controls.Grids.ExpansionIndicatorSettings)obj;
			if (expansionIndicatorSettings.Grid != null)
			{
				expansionIndicatorSettings.Grid.ResetPanelRows();
			}
			expansionIndicatorSettings.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00010362 File Offset: 0x0000E562
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00010374 File Offset: 0x0000E574
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings.FooterStyleProperty, value);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00010384 File Offset: 0x0000E584
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ExpansionIndicatorSettings expansionIndicatorSettings = (global::Infragistics.Controls.Grids.ExpansionIndicatorSettings)obj;
			if (expansionIndicatorSettings.Grid != null)
			{
				expansionIndicatorSettings.Grid.ResetPanelRows();
			}
			expansionIndicatorSettings.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings.HeaderStyleChanged)));

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ExpansionIndicatorSettings.FooterStyleChanged)));
	}
}
