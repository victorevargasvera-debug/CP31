using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000125 RID: 293
	[global::System.Windows.StyleTypedProperty(Property = "FooterStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorFooterCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "HeaderStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorHeaderCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.RowSelectorCellControl))]
	public class RowSelectorSettingsOverride : global::Infragistics.Controls.Grids.VisualSettingsOverrideBase
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00025978 File Offset: 0x00023B78
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.RowSelectorSettings;
				}
				return result;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000259AE File Offset: 0x00023BAE
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000259C0 File Offset: 0x00023BC0
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.HeaderStyleProperty, value);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000259D0 File Offset: 0x00023BD0
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettingsOverride rowSelectorSettingsOverride = (global::Infragistics.Controls.Grids.RowSelectorSettingsOverride)obj;
			if (rowSelectorSettingsOverride.ColumnLayout != null && rowSelectorSettingsOverride.ColumnLayout.Grid != null)
			{
				rowSelectorSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			rowSelectorSettingsOverride.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00025A14 File Offset: 0x00023C14
		public global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				if (this.HeaderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.RowSelectorSettings)this.SettingsObject).HeaderStyle;
				}
				return this.HeaderStyle;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00025A3D File Offset: 0x00023C3D
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00025A4F File Offset: 0x00023C4F
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.FooterStyleProperty, value);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00025A60 File Offset: 0x00023C60
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettingsOverride rowSelectorSettingsOverride = (global::Infragistics.Controls.Grids.RowSelectorSettingsOverride)obj;
			if (rowSelectorSettingsOverride.ColumnLayout != null && rowSelectorSettingsOverride.ColumnLayout.Grid != null)
			{
				rowSelectorSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			rowSelectorSettingsOverride.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00025AA4 File Offset: 0x00023CA4
		public global::System.Windows.Style FooterStyleResolved
		{
			get
			{
				if (this.FooterStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.RowSelectorSettings)this.SettingsObject).FooterStyle;
				}
				return this.FooterStyle;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00025ACD File Offset: 0x00023CCD
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x00025ADF File Offset: 0x00023CDF
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableIntConverter))]
		public int? RowNumberingSeed
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.RowNumberingSeedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.RowNumberingSeedProperty, value);
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00025AF4 File Offset: 0x00023CF4
		private static void RowNumberingSeedChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettingsOverride rowSelectorSettingsOverride = (global::Infragistics.Controls.Grids.RowSelectorSettingsOverride)obj;
			if (rowSelectorSettingsOverride.ColumnLayout != null && rowSelectorSettingsOverride.ColumnLayout.Grid != null)
			{
				rowSelectorSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			rowSelectorSettingsOverride.OnPropertyChanged("RowNumberingSeed");
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00025B38 File Offset: 0x00023D38
		public int RowNumberingSeedResolved
		{
			get
			{
				if (this.RowNumberingSeed != null)
				{
					return this.RowNumberingSeed.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.RowSelectorSettings)this.SettingsObject).RowNumberingSeed;
				}
				return (int)global::Infragistics.Controls.Grids.RowSelectorSettings.RowNumberingSeedProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.RowSelectorSettings)).DefaultValue;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00025B9B File Offset: 0x00023D9B
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00025BAD File Offset: 0x00023DAD
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? EnableRowNumbering
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.EnableRowNumberingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.EnableRowNumberingProperty, value);
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00025BC0 File Offset: 0x00023DC0
		private static void EnableRowNumberingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowSelectorSettingsOverride rowSelectorSettingsOverride = (global::Infragistics.Controls.Grids.RowSelectorSettingsOverride)obj;
			rowSelectorSettingsOverride.OnPropertyChanged("EnableRowNumbering");
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00025BE0 File Offset: 0x00023DE0
		public bool EnableRowNumberingResolved
		{
			get
			{
				if (this.EnableRowNumbering != null)
				{
					return this.EnableRowNumbering.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.RowSelectorSettings)this.SettingsObject).EnableRowNumbering;
				}
				return (bool)global::Infragistics.Controls.Grids.RowSelectorSettings.EnableRowNumberingProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.RowSelectorSettings)).DefaultValue;
			}
		}

		// Token: 0x04000262 RID: 610
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.HeaderStyleChanged)));

		// Token: 0x04000263 RID: 611
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.FooterStyleChanged)));

		// Token: 0x04000264 RID: 612
		public static readonly global::System.Windows.DependencyProperty RowNumberingSeedProperty = global::System.Windows.DependencyProperty.Register("RowNumberingSeed", typeof(int?), typeof(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.RowNumberingSeedChanged)));

		// Token: 0x04000265 RID: 613
		public static readonly global::System.Windows.DependencyProperty EnableRowNumberingProperty = global::System.Windows.DependencyProperty.Register("EnableRowNumbering", typeof(bool?), typeof(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.RowSelectorSettingsOverride.EnableRowNumberingChanged)));
	}
}
