using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000124 RID: 292
	[global::System.Windows.StyleTypedProperty(Property = "HeaderStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorHeaderCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "FooterStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorFooterCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorCellControl))]
	public class RowSelectorSettings : global::Infragistics.Controls.Grids.VisualSettingsBase
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x00025749 File Offset: 0x00023949
		public RowSelectorSettings()
		{
			base.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00025758 File Offset: 0x00023958
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0002576A File Offset: 0x0002396A
		public bool EnableRowNumbering
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.EnableRowNumberingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.EnableRowNumberingProperty, value);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00025780 File Offset: 0x00023980
		private static void EnableRowNumberingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettings rowSelectorSettings = (global::Infragistics.Controls.Grids.RowSelectorSettings)obj;
			rowSelectorSettings.OnPropertyChanged("EnableRowNumbering");
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002579F File Offset: 0x0002399F
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x000257B1 File Offset: 0x000239B1
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.HeaderStyleProperty, value);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000257C0 File Offset: 0x000239C0
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettings rowSelectorSettings = (global::Infragistics.Controls.Grids.RowSelectorSettings)obj;
			if (rowSelectorSettings.Grid != null)
			{
				rowSelectorSettings.Grid.ResetPanelRows();
			}
			rowSelectorSettings.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x000257F2 File Offset: 0x000239F2
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00025804 File Offset: 0x00023A04
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.FooterStyleProperty, value);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00025814 File Offset: 0x00023A14
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettings rowSelectorSettings = (global::Infragistics.Controls.Grids.RowSelectorSettings)obj;
			if (rowSelectorSettings.Grid != null)
			{
				rowSelectorSettings.Grid.ResetPanelRows();
			}
			rowSelectorSettings.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00025846 File Offset: 0x00023A46
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00025858 File Offset: 0x00023A58
		public int RowNumberingSeed
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.RowNumberingSeedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettings.RowNumberingSeedProperty, value);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0002586C File Offset: 0x00023A6C
		private static void RowNumberingSeedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettings rowSelectorSettings = (global::Infragistics.Controls.Grids.RowSelectorSettings)obj;
			rowSelectorSettings.OnPropertyChanged("RowNumberingSeed");
		}

		// Token: 0x0400025E RID: 606
		public static readonly global::System.Windows.DependencyProperty EnableRowNumberingProperty = global::System.Windows.DependencyProperty.Register("EnableRowNumbering", typeof(bool), typeof(global::Infragistics.Controls.Grids.RowSelectorSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettings.EnableRowNumberingChanged)));

		// Token: 0x0400025F RID: 607
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.RowSelectorSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettings.HeaderStyleChanged)));

		// Token: 0x04000260 RID: 608
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.RowSelectorSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettings.FooterStyleChanged)));

		// Token: 0x04000261 RID: 609
		public static readonly global::System.Windows.DependencyProperty RowNumberingSeedProperty = global::System.Windows.DependencyProperty.Register("RowNumberingSeed", typeof(int), typeof(global::Infragistics.Controls.Grids.RowSelectorSettings), new global::System.Windows.PropertyMetadata(1, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettings.RowNumberingSeedChanged)));
	}
}
