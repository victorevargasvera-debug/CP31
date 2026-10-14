using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000030 RID: 48
	public class TreeEditingSettingsOverride : global::Infragistics.Controls.Menus.SettingsBaseOverride
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000094E8 File Offset: 0x000076E8
		protected override global::Infragistics.Controls.Menus.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Menus.SettingsBase result = null;
				if (base.NodeLayout != null && base.NodeLayout.Tree != null)
				{
					result = base.NodeLayout.Tree.EditingSettings;
				}
				return result;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000951E File Offset: 0x0000771E
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00009530 File Offset: 0x00007730
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AllowEditing
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.AllowEditingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.AllowEditingProperty, value);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009544 File Offset: 0x00007744
		private static void AllowEditingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride treeEditingSettingsOverride = (global::Infragistics.Controls.Menus.TreeEditingSettingsOverride)obj;
			treeEditingSettingsOverride.OnPropertyChanged("AllowEditing");
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00009564 File Offset: 0x00007764
		public bool AllowEditingResolved
		{
			get
			{
				if (this.AllowEditing == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Menus.TreeEditingSettings)this.SettingsObject).AllowEditing;
				}
				return this.AllowEditing.Value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000095A8 File Offset: 0x000077A8
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x000095BA File Offset: 0x000077BA
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsF2EditingEnabled
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsF2EditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsF2EditingEnabledProperty, value);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000095D0 File Offset: 0x000077D0
		private static void IsF2EditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride treeEditingSettingsOverride = (global::Infragistics.Controls.Menus.TreeEditingSettingsOverride)obj;
			treeEditingSettingsOverride.OnPropertyChanged("IsF2EditingEnabled");
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000095F0 File Offset: 0x000077F0
		public bool IsF2EditingEnabledResolved
		{
			get
			{
				if (this.IsF2EditingEnabled == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Menus.TreeEditingSettings)this.SettingsObject).IsF2EditingEnabled;
				}
				return this.IsF2EditingEnabled.Value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00009634 File Offset: 0x00007834
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00009646 File Offset: 0x00007846
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsEnterKeyEditingEnabled
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsEnterKeyEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsEnterKeyEditingEnabledProperty, value);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000965C File Offset: 0x0000785C
		private static void IsEnterKeyEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride treeEditingSettingsOverride = (global::Infragistics.Controls.Menus.TreeEditingSettingsOverride)obj;
			treeEditingSettingsOverride.OnPropertyChanged("IsEnterKeyEditingEnabled");
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000967C File Offset: 0x0000787C
		public bool IsEnterKeyEditingEnabledResolved
		{
			get
			{
				if (this.IsEnterKeyEditingEnabled == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Menus.TreeEditingSettings)this.SettingsObject).IsEnterKeyEditingEnabled;
				}
				return this.IsEnterKeyEditingEnabled.Value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000096C0 File Offset: 0x000078C0
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000096D2 File Offset: 0x000078D2
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Menus.TreeMouseEditingAction>))]
		public global::Infragistics.Controls.Menus.TreeMouseEditingAction? IsMouseActionEditingEnabled
		{
			get
			{
				return (global::Infragistics.Controls.Menus.TreeMouseEditingAction?)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsMouseActionEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsMouseActionEditingEnabledProperty, value);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000096E8 File Offset: 0x000078E8
		private static void IsMouseActionEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride treeEditingSettingsOverride = (global::Infragistics.Controls.Menus.TreeEditingSettingsOverride)obj;
			treeEditingSettingsOverride.OnPropertyChanged("IsMouseActionEditingEnabled");
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00009708 File Offset: 0x00007908
		public global::Infragistics.Controls.Menus.TreeMouseEditingAction IsMouseActionEditingEnabledResolved
		{
			get
			{
				if (this.IsMouseActionEditingEnabled == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Menus.TreeEditingSettings)this.SettingsObject).IsMouseActionEditingEnabled;
				}
				return this.IsMouseActionEditingEnabled.Value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000974C File Offset: 0x0000794C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000975E File Offset: 0x0000795E
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? IsOnNodeActiveEditingEnabled
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsOnNodeActiveEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsOnNodeActiveEditingEnabledProperty, value);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00009774 File Offset: 0x00007974
		private static void IsOnNodeActiveEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride treeEditingSettingsOverride = (global::Infragistics.Controls.Menus.TreeEditingSettingsOverride)obj;
			treeEditingSettingsOverride.OnPropertyChanged("IsOnNodeActiveEditingEnabled");
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00009794 File Offset: 0x00007994
		public bool IsOnNodeActiveEditingEnabledResolved
		{
			get
			{
				if (this.IsOnNodeActiveEditingEnabled == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Menus.TreeEditingSettings)this.SettingsObject).IsOnNodeActiveEditingEnabled;
				}
				return this.IsOnNodeActiveEditingEnabled.Value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000097D8 File Offset: 0x000079D8
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000097EA File Offset: 0x000079EA
		public bool? AllowDeletion
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.AllowDeletionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.AllowDeletionProperty, value);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00009800 File Offset: 0x00007A00
		private static void AllowDeletionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettingsOverride treeEditingSettingsOverride = (global::Infragistics.Controls.Menus.TreeEditingSettingsOverride)obj;
			treeEditingSettingsOverride.OnPropertyChanged("AllowDeletion");
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00009820 File Offset: 0x00007A20
		public bool AllowDeletionResolved
		{
			get
			{
				if (this.AllowDeletion == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Menus.TreeEditingSettings)this.SettingsObject).AllowDeletion;
				}
				return this.AllowDeletion.Value;
			}
		}

		// Token: 0x0400009E RID: 158
		public static readonly global::System.Windows.DependencyProperty AllowEditingProperty = global::System.Windows.DependencyProperty.Register("AllowEditing", typeof(bool?), typeof(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.AllowEditingChanged)));

		// Token: 0x0400009F RID: 159
		public static readonly global::System.Windows.DependencyProperty IsF2EditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsF2EditingEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsF2EditingEnabledChanged)));

		// Token: 0x040000A0 RID: 160
		public static readonly global::System.Windows.DependencyProperty IsEnterKeyEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnterKeyEditingEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsEnterKeyEditingEnabledChanged)));

		// Token: 0x040000A1 RID: 161
		public static readonly global::System.Windows.DependencyProperty IsMouseActionEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsMouseActionEditingEnabled", typeof(global::Infragistics.Controls.Menus.TreeMouseEditingAction?), typeof(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsMouseActionEditingEnabledChanged)));

		// Token: 0x040000A2 RID: 162
		public static readonly global::System.Windows.DependencyProperty IsOnNodeActiveEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsOnCellActiveEditingEnabled", typeof(bool?), typeof(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.IsOnNodeActiveEditingEnabledChanged)));

		// Token: 0x040000A3 RID: 163
		public static readonly global::System.Windows.DependencyProperty AllowDeletionProperty = global::System.Windows.DependencyProperty.Register("AllowDeletion", typeof(bool?), typeof(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettingsOverride.AllowDeletionChanged)));
	}
}
