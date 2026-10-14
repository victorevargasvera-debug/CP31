using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000069 RID: 105
	public abstract class VisualSettingsOverrideBase : global::Infragistics.Controls.Grids.StyleSettingsOverrideBase
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0001042D File Offset: 0x0000E62D
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0001043F File Offset: 0x0000E63F
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? Visibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Controls.Grids.VisualSettingsOverrideBase.VisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.VisualSettingsOverrideBase.VisibilityProperty, value);
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00010454 File Offset: 0x0000E654
		private static void VisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.VisualSettingsOverrideBase visualSettingsOverrideBase = (global::Infragistics.Controls.Grids.VisualSettingsOverrideBase)obj;
			visualSettingsOverrideBase.OnPropertyChanged("Visibility");
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00010474 File Offset: 0x0000E674
		public global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				if (this.Visibility == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.VisualSettingsBase)this.SettingsObject).Visibility;
				}
				if (!(this.Visibility == global::System.Windows.Visibility.Visible))
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Controls.Grids.VisualSettingsOverrideBase), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.VisualSettingsOverrideBase.VisibilityChanged)));
	}
}
