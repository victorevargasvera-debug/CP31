using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200002E RID: 46
	public class CheckBoxSettingsOverride : global::Infragistics.Controls.Menus.SettingsBaseOverride
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00008F5C File Offset: 0x0000715C
		protected override global::Infragistics.Controls.Menus.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Menus.SettingsBase result = null;
				if (base.NodeLayout != null && base.NodeLayout.Tree != null)
				{
					result = base.NodeLayout.Tree.CheckBoxSettings;
				}
				return result;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00008F92 File Offset: 0x00007192
		protected internal override void InvalidateResolvedProperties()
		{
			base.InvalidateResolvedProperties();
			this.OnPropertyChanged("CheckBoxVisibilityResolved");
			this.OnPropertyChanged("CheckBoxModeResolved");
			this.OnPropertyChanged("IsCheckBoxThreeStateResolved");
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00008FBB File Offset: 0x000071BB
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00008FCD File Offset: 0x000071CD
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::System.Windows.Visibility>))]
		public global::System.Windows.Visibility? CheckBoxVisibility
		{
			get
			{
				return (global::System.Windows.Visibility?)base.GetValue(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride.CheckBoxVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride.CheckBoxVisibilityProperty, value);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008FE0 File Offset: 0x000071E0
		private static void CheckBoxVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.CheckBoxSettingsOverride checkBoxSettingsOverride = (global::Infragistics.Controls.Menus.CheckBoxSettingsOverride)obj;
			checkBoxSettingsOverride.OnPropertyChanged("CheckBoxVisibility");
			checkBoxSettingsOverride.OnPropertyChanged("CheckBoxVisibilityResolved");
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000900C File Offset: 0x0000720C
		public global::System.Windows.Visibility CheckBoxVisibilityResolved
		{
			get
			{
				global::System.Windows.Visibility result = global::System.Windows.Visibility.Collapsed;
				if (this.CheckBoxVisibility != null)
				{
					result = this.CheckBoxVisibility.Value;
				}
				else if (this.SettingsObject != null)
				{
					result = ((global::Infragistics.Controls.Menus.CheckBoxSettings)this.SettingsObject).CheckBoxVisibility;
				}
				return result;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00009056 File Offset: 0x00007256
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00009068 File Offset: 0x00007268
		public global::System.Windows.Style CheckBoxStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride.CheckBoxStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride.CheckBoxStyleProperty, value);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00009078 File Offset: 0x00007278
		private static void CheckBoxStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.CheckBoxSettingsOverride checkBoxSettingsOverride = (global::Infragistics.Controls.Menus.CheckBoxSettingsOverride)obj;
			checkBoxSettingsOverride.OnPropertyChanged("CheckBoxStyle");
			checkBoxSettingsOverride.OnPropertyChanged("CheckBoxStyleResolved");
			if (checkBoxSettingsOverride.NodeLayout != null && checkBoxSettingsOverride.NodeLayout.Tree != null)
			{
				checkBoxSettingsOverride.NodeLayout.Tree.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000090C8 File Offset: 0x000072C8
		public global::System.Windows.Style CheckBoxStyleResolved
		{
			get
			{
				global::System.Windows.Style result = null;
				if (this.CheckBoxStyle != null)
				{
					result = this.CheckBoxStyle;
				}
				else if (this.SettingsObject != null)
				{
					result = ((global::Infragistics.Controls.Menus.CheckBoxSettings)this.SettingsObject).CheckBoxStyle;
				}
				return result;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00009104 File Offset: 0x00007304
		protected internal global::Infragistics.Controls.Menus.TreeCheckBoxMode CheckBoxModeResolved
		{
			get
			{
				global::Infragistics.Controls.Menus.TreeCheckBoxMode result = global::Infragistics.Controls.Menus.TreeCheckBoxMode.Auto;
				if (this.SettingsObject != null)
				{
					result = ((global::Infragistics.Controls.Menus.CheckBoxSettings)this.SettingsObject).CheckBoxMode;
				}
				return result;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00009130 File Offset: 0x00007330
		public bool IsCheckBoxThreeStateResolved
		{
			get
			{
				global::Infragistics.Controls.Menus.CheckBoxSettings checkBoxSettings = this.SettingsObject as global::Infragistics.Controls.Menus.CheckBoxSettings;
				return checkBoxSettings != null && checkBoxSettings.CheckBoxMode == global::Infragistics.Controls.Menus.TreeCheckBoxMode.Manual && checkBoxSettings.IsCheckBoxThreeState;
			}
		}

		// Token: 0x04000096 RID: 150
		public static readonly global::System.Windows.DependencyProperty CheckBoxVisibilityProperty = global::System.Windows.DependencyProperty.Register("CheckBoxVisiblity", typeof(global::System.Windows.Visibility?), typeof(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride.CheckBoxVisibilityChanged)));

		// Token: 0x04000097 RID: 151
		public static readonly global::System.Windows.DependencyProperty CheckBoxStyleProperty = global::System.Windows.DependencyProperty.Register("CheckBoxStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.CheckBoxSettingsOverride.CheckBoxStyleChanged)));
	}
}
