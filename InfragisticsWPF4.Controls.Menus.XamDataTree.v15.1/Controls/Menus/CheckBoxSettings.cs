using System;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200002D RID: 45
	public class CheckBoxSettings : global::Infragistics.Controls.Menus.SettingsBase
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00008D57 File Offset: 0x00006F57
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00008D69 File Offset: 0x00006F69
		public global::System.Windows.Style CheckBoxStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxStyleProperty, value);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008D78 File Offset: 0x00006F78
		private static void CheckBoxStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.CheckBoxSettings checkBoxSettings = (global::Infragistics.Controls.Menus.CheckBoxSettings)obj;
			checkBoxSettings.OnPropertyChanged("CheckBoxStyle");
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00008D97 File Offset: 0x00006F97
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00008DA9 File Offset: 0x00006FA9
		public global::System.Windows.Visibility CheckBoxVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxVisibilityProperty, value);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00008DBC File Offset: 0x00006FBC
		private static void CheckBoxVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.CheckBoxSettings checkBoxSettings = (global::Infragistics.Controls.Menus.CheckBoxSettings)obj;
			checkBoxSettings.OnPropertyChanged("CheckBoxVisibility");
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00008DDB File Offset: 0x00006FDB
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00008DED File Offset: 0x00006FED
		public bool IsCheckBoxThreeState
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.IsCheckBoxThreeStateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.IsCheckBoxThreeStateProperty, value);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00008E00 File Offset: 0x00007000
		private static void IsCheckBoxThreeStateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.CheckBoxSettings checkBoxSettings = (global::Infragistics.Controls.Menus.CheckBoxSettings)obj;
			checkBoxSettings.OnPropertyChanged("IsCheckBoxThreeState");
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00008E1F File Offset: 0x0000701F
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00008E31 File Offset: 0x00007031
		public global::Infragistics.Controls.Menus.TreeCheckBoxMode CheckBoxMode
		{
			get
			{
				return (global::Infragistics.Controls.Menus.TreeCheckBoxMode)base.GetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxModeProperty, value);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008E44 File Offset: 0x00007044
		private static void CheckBoxModeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.CheckBoxSettings checkBoxSettings = (global::Infragistics.Controls.Menus.CheckBoxSettings)obj;
			checkBoxSettings.OnPropertyChanged("CheckBoxMode");
		}

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty CheckBoxStyleProperty = global::System.Windows.DependencyProperty.Register("CheckBoxStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.CheckBoxSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxStyleChanged)));

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty CheckBoxVisibilityProperty = global::System.Windows.DependencyProperty.Register("CheckBoxVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Menus.CheckBoxSettings), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxVisibilityChanged)));

		// Token: 0x04000094 RID: 148
		public static readonly global::System.Windows.DependencyProperty IsCheckBoxThreeStateProperty = global::System.Windows.DependencyProperty.Register("IsCheckBoxThreeState", typeof(bool), typeof(global::Infragistics.Controls.Menus.CheckBoxSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.CheckBoxSettings.IsCheckBoxThreeStateChanged)));

		// Token: 0x04000095 RID: 149
		public static readonly global::System.Windows.DependencyProperty CheckBoxModeProperty = global::System.Windows.DependencyProperty.Register("CheckBoxMode", typeof(global::Infragistics.Controls.Menus.TreeCheckBoxMode), typeof(global::Infragistics.Controls.Menus.CheckBoxSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.TreeCheckBoxMode.Auto, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.CheckBoxSettings.CheckBoxModeChanged)));
	}
}
