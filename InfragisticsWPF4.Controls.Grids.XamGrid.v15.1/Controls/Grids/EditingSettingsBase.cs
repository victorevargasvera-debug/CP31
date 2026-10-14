using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200000B RID: 11
	public class EditingSettingsBase : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000745C File Offset: 0x0000565C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000746E File Offset: 0x0000566E
		public bool IsF2EditingEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsF2EditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsF2EditingEnabledProperty, value);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007484 File Offset: 0x00005684
		private static void IsF2EditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBase editingSettingsBase = (global::Infragistics.Controls.Grids.EditingSettingsBase)obj;
			editingSettingsBase.OnPropertyChanged("IsF2EditingEnabled");
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000074A3 File Offset: 0x000056A3
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000074B5 File Offset: 0x000056B5
		public bool IsEnterKeyEditingEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsEnterKeyEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsEnterKeyEditingEnabledProperty, value);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000074C8 File Offset: 0x000056C8
		private static void IsEnterKeyEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBase editingSettingsBase = (global::Infragistics.Controls.Grids.EditingSettingsBase)obj;
			editingSettingsBase.OnPropertyChanged("IsEnterKeyEditingEnabled");
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000074E7 File Offset: 0x000056E7
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000074F9 File Offset: 0x000056F9
		public global::Infragistics.Controls.Grids.MouseEditingAction IsMouseActionEditingEnabled
		{
			get
			{
				return (global::Infragistics.Controls.Grids.MouseEditingAction)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsMouseActionEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsMouseActionEditingEnabledProperty, value);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000750C File Offset: 0x0000570C
		private static void IsMouseActionEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBase editingSettingsBase = (global::Infragistics.Controls.Grids.EditingSettingsBase)obj;
			editingSettingsBase.OnPropertyChanged("IsMouseActionEditingEnabled");
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000752B File Offset: 0x0000572B
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000753D File Offset: 0x0000573D
		public bool IsOnCellActiveEditingEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsOnCellActiveEditingEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.EditingSettingsBase.IsOnCellActiveEditingEnabledProperty, value);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007550 File Offset: 0x00005750
		private static void IsOnCellActiveEditingEnabledChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.EditingSettingsBase editingSettingsBase = (global::Infragistics.Controls.Grids.EditingSettingsBase)obj;
			editingSettingsBase.OnPropertyChanged("IsOnCellActiveEditingEnabled");
		}

		// Token: 0x04000029 RID: 41
		public static readonly global::System.Windows.DependencyProperty IsF2EditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsF2EditingEnabled", typeof(bool), typeof(global::Infragistics.Controls.Grids.EditingSettingsBase), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBase.IsF2EditingEnabledChanged)));

		// Token: 0x0400002A RID: 42
		public static readonly global::System.Windows.DependencyProperty IsEnterKeyEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsEnterKeyEditingEnabled", typeof(bool), typeof(global::Infragistics.Controls.Grids.EditingSettingsBase), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBase.IsEnterKeyEditingEnabledChanged)));

		// Token: 0x0400002B RID: 43
		public static readonly global::System.Windows.DependencyProperty IsMouseActionEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsMouseActionEditingEnabled", typeof(global::Infragistics.Controls.Grids.MouseEditingAction), typeof(global::Infragistics.Controls.Grids.EditingSettingsBase), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.MouseEditingAction.DoubleClick, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBase.IsMouseActionEditingEnabledChanged)));

		// Token: 0x0400002C RID: 44
		public static readonly global::System.Windows.DependencyProperty IsOnCellActiveEditingEnabledProperty = global::System.Windows.DependencyProperty.Register("IsOnCellActiveEditingEnabled", typeof(bool), typeof(global::Infragistics.Controls.Grids.EditingSettingsBase), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.EditingSettingsBase.IsOnCellActiveEditingEnabledChanged)));
	}
}
