using System;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200006C RID: 108
	[global::System.Windows.StyleTypedProperty(Property = "HeaderStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.HeaderCellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "Style", StyleTargetType = typeof(global::Infragistics.Controls.Grids.CellControl))]
	[global::System.Windows.StyleTypedProperty(Property = "FooterStyle", StyleTargetType = typeof(global::Infragistics.Controls.Grids.Primitives.FooterCellControl))]
	public class FillerColumnSettingsOverride : global::Infragistics.Controls.Grids.StyleSettingsOverrideBase
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000107E0 File Offset: 0x0000E9E0
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.FillerColumnSettings;
				}
				return result;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00010816 File Offset: 0x0000EA16
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00010828 File Offset: 0x0000EA28
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride.HeaderStyleProperty, value);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00010838 File Offset: 0x0000EA38
		private static void HeaderStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FillerColumnSettingsOverride fillerColumnSettingsOverride = (global::Infragistics.Controls.Grids.FillerColumnSettingsOverride)obj;
			fillerColumnSettingsOverride.OnPropertyChanged("HeaderStyle");
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00010857 File Offset: 0x0000EA57
		public global::System.Windows.Style HeaderStyleResolved
		{
			get
			{
				if (this.HeaderStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FillerColumnSettings)this.SettingsObject).HeaderStyle;
				}
				return this.HeaderStyle;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00010880 File Offset: 0x0000EA80
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00010892 File Offset: 0x0000EA92
		public global::System.Windows.Style FooterStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride.FooterStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride.FooterStyleProperty, value);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000108A0 File Offset: 0x0000EAA0
		private static void FooterStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.FillerColumnSettingsOverride fillerColumnSettingsOverride = (global::Infragistics.Controls.Grids.FillerColumnSettingsOverride)obj;
			fillerColumnSettingsOverride.OnPropertyChanged("FooterStyle");
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x000108BF File Offset: 0x0000EABF
		public global::System.Windows.Style FooterStyleResolved
		{
			get
			{
				if (this.FooterStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.FillerColumnSettings)this.SettingsObject).FooterStyle;
				}
				return this.FooterStyle;
			}
		}

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride.HeaderStyleChanged)));

		// Token: 0x040000E6 RID: 230
		public static readonly global::System.Windows.DependencyProperty FooterStyleProperty = global::System.Windows.DependencyProperty.Register("FooterStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.FillerColumnSettingsOverride.FooterStyleChanged)));
	}
}
