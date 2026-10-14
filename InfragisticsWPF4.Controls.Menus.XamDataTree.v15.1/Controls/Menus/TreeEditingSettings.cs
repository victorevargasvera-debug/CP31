using System;
using System.Windows;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200002F RID: 47
	public class TreeEditingSettings : global::Infragistics.Controls.Menus.SettingsBase
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000091DB File Offset: 0x000073DB
		// (set) Token: 0x060001DE RID: 478 RVA: 0x000091ED File Offset: 0x000073ED
		public bool AllowEditing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.AllowEditingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.AllowEditingProperty, value);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00009200 File Offset: 0x00007400
		private static void AllowEditingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettings treeEditingSettings = (global::Infragistics.Controls.Menus.TreeEditingSettings)obj;
			treeEditingSettings.OnPropertyChanged("AllowEditing");
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000921F File Offset: 0x0000741F
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00009231 File Offset: 0x00007431
		public bool IsF2EditingEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsF2EditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsF2EditingEnabledProperty, value);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00009244 File Offset: 0x00007444
		private static void IsF2EditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettings treeEditingSettings = (global::Infragistics.Controls.Menus.TreeEditingSettings)obj;
			treeEditingSettings.OnPropertyChanged("IsF2EditingEnabled");
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00009263 File Offset: 0x00007463
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00009275 File Offset: 0x00007475
		public bool IsEnterKeyEditingEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsEnterKeyEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsEnterKeyEditingEnabledProperty, value);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00009288 File Offset: 0x00007488
		private static void IsEnterKeyEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettings treeEditingSettings = (global::Infragistics.Controls.Menus.TreeEditingSettings)obj;
			treeEditingSettings.OnPropertyChanged("IsEnterKeyEditingEnabled");
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x000092A7 File Offset: 0x000074A7
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000092B9 File Offset: 0x000074B9
		public global::Infragistics.Controls.Menus.TreeMouseEditingAction IsMouseActionEditingEnabled
		{
			get
			{
				return (global::Infragistics.Controls.Menus.TreeMouseEditingAction)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsMouseActionEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsMouseActionEditingEnabledProperty, value);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000092CC File Offset: 0x000074CC
		private static void IsMouseActionEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettings treeEditingSettings = (global::Infragistics.Controls.Menus.TreeEditingSettings)obj;
			treeEditingSettings.OnPropertyChanged("IsMouseActionEditingEnabled");
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000092EB File Offset: 0x000074EB
		// (set) Token: 0x060001EA RID: 490 RVA: 0x000092FD File Offset: 0x000074FD
		public bool IsOnNodeActiveEditingEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsOnNodeActiveEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.IsOnNodeActiveEditingEnabledProperty, value);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00009310 File Offset: 0x00007510
		private static void IsOnNodeActiveEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettings treeEditingSettings = (global::Infragistics.Controls.Menus.TreeEditingSettings)obj;
			treeEditingSettings.OnPropertyChanged("IsOnNodeActiveEditingEnabled");
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000932F File Offset: 0x0000752F
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00009341 File Offset: 0x00007541
		public bool AllowDeletion
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.AllowDeletionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.TreeEditingSettings.AllowDeletionProperty, value);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00009354 File Offset: 0x00007554
		private static void AllowDeletionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.TreeEditingSettings treeEditingSettings = (global::Infragistics.Controls.Menus.TreeEditingSettings)obj;
			treeEditingSettings.OnPropertyChanged("AllowDeletion");
		}

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty AllowEditingProperty = global::System.Windows.DependencyProperty.Register("AllowEditing", typeof(bool), typeof(global::Infragistics.Controls.Menus.TreeEditingSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettings.AllowEditingChanged)));

		// Token: 0x04000099 RID: 153
		public static readonly global::System.Windows.DependencyProperty IsF2EditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsF2EditingEnabled", typeof(bool), typeof(global::Infragistics.Controls.Menus.TreeEditingSettings), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettings.IsF2EditingEnabledChanged)));

		// Token: 0x0400009A RID: 154
		public static readonly global::System.Windows.DependencyProperty IsEnterKeyEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnterKeyEditingEnabled", typeof(bool), typeof(global::Infragistics.Controls.Menus.TreeEditingSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettings.IsEnterKeyEditingEnabledChanged)));

		// Token: 0x0400009B RID: 155
		public static readonly global::System.Windows.DependencyProperty IsMouseActionEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsMouseActionEditingEnabled", typeof(global::Infragistics.Controls.Menus.TreeMouseEditingAction), typeof(global::Infragistics.Controls.Menus.TreeEditingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Menus.TreeMouseEditingAction.DoubleClick, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettings.IsMouseActionEditingEnabledChanged)));

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty IsOnNodeActiveEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsOnNodeActiveEditingEnabled", typeof(bool), typeof(global::Infragistics.Controls.Menus.TreeEditingSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettings.IsOnNodeActiveEditingEnabledChanged)));

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty AllowDeletionProperty = global::System.Windows.DependencyProperty.Register("AllowDeletion", typeof(bool), typeof(global::Infragistics.Controls.Menus.TreeEditingSettings), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.TreeEditingSettings.AllowDeletionChanged)));
	}
}
