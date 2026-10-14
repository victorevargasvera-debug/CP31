using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200006A RID: 106
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorCell))]
	public class ExpansionIndicatorSettingsOverride : global::Infragistics.Controls.Grids.VisualSettingsOverrideBase
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00010508 File Offset: 0x0000E708
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.ExpansionIndicatorSettings;
				}
				return result;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001053E File Offset: 0x0000E73E
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00010550 File Offset: 0x0000E750
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride.HeaderStyleProperty, value);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00010560 File Offset: 0x0000E760
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride expansionIndicatorSettingsOverride = (global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride)obj;
			if (expansionIndicatorSettingsOverride.ColumnLayout != null && expansionIndicatorSettingsOverride.ColumnLayout.Grid != null)
			{
				expansionIndicatorSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			expansionIndicatorSettingsOverride.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600039F RID: 927 RVA: 0x000105A4 File Offset: 0x0000E7A4
		public global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				if (this.HeaderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ExpansionIndicatorSettings)this.SettingsObject).HeaderStyle;
				}
				return this.HeaderStyle;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000105CD File Offset: 0x0000E7CD
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x000105DF File Offset: 0x0000E7DF
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride.FooterStyleProperty, value);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000105F0 File Offset: 0x0000E7F0
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride expansionIndicatorSettingsOverride = (global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride)obj;
			if (expansionIndicatorSettingsOverride.ColumnLayout != null && expansionIndicatorSettingsOverride.ColumnLayout.Grid != null)
			{
				expansionIndicatorSettingsOverride.ColumnLayout.Grid.ResetPanelRows();
			}
			expansionIndicatorSettingsOverride.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00010634 File Offset: 0x0000E834
		public global::System.Windows.Style FooterStyleResolved
		{
			get
			{
				if (this.FooterStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ExpansionIndicatorSettings)this.SettingsObject).FooterStyle;
				}
				return this.FooterStyle;
			}
		}

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride.HeaderStyleChanged)));

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ExpansionIndicatorSettingsOverride.FooterStyleChanged)));
	}
}
