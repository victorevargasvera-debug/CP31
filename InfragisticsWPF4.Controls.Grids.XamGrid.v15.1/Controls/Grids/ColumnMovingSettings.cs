using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000020 RID: 32
	public class ColumnMovingSettings : global::Infragistics.Controls.Grids.SettingsBase
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00009501 File Offset: 0x00007701
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00009513 File Offset: 0x00007713
		public global::System.Windows.Style IndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.IndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.IndicatorStyleProperty, value);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00009524 File Offset: 0x00007724
		private static void IndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettings columnMovingSettings = (global::Infragistics.Controls.Grids.ColumnMovingSettings)obj;
			columnMovingSettings.OnPropertyChanged("IndicatorStyle");
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00009543 File Offset: 0x00007743
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00009555 File Offset: 0x00007755
		public global::Infragistics.Controls.Grids.ColumnMovingType AllowColumnMoving
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnMovingType)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.AllowColumnMovingTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.AllowColumnMovingTypeProperty, value);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00009568 File Offset: 0x00007768
		private static void AllowColumnMovingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettings columnMovingSettings = (global::Infragistics.Controls.Grids.ColumnMovingSettings)obj;
			columnMovingSettings.OnPropertyChanged("AllowColumnMoving");
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00009587 File Offset: 0x00007787
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00009599 File Offset: 0x00007799
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return (global::System.Windows.Media.Animation.EasingFunctionBase)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.EasingFunctionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.EasingFunctionProperty, value);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000095A8 File Offset: 0x000077A8
		private static void EasingFunctionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettings columnMovingSettings = (global::Infragistics.Controls.Grids.ColumnMovingSettings)obj;
			columnMovingSettings.OnPropertyChanged("EasingFunction");
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000095C7 File Offset: 0x000077C7
		// (set) Token: 0x0600017D RID: 381 RVA: 0x000095D9 File Offset: 0x000077D9
		public int AnimationDuration
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.AnimationDurationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettings.AnimationDurationProperty, value);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000095EC File Offset: 0x000077EC
		private static void AnimationDurationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettings columnMovingSettings = (global::Infragistics.Controls.Grids.ColumnMovingSettings)obj;
			columnMovingSettings.OnPropertyChanged("AnimationDuration");
		}

		// Token: 0x0400005C RID: 92
		public static readonly global::System.Windows.DependencyProperty IndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("IndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettings.IndicatorStyleChanged)));

		// Token: 0x0400005D RID: 93
		public static readonly global::System.Windows.DependencyProperty AllowColumnMovingTypeProperty = global::System.Windows.DependencyProperty.Register("AllowColumnMoving", typeof(global::Infragistics.Controls.Grids.ColumnMovingType), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Grids.ColumnMovingType.Disabled, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettings.AllowColumnMovingChanged)));

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Windows.DependencyProperty EasingFunctionProperty = global::System.Windows.DependencyProperty.Register("EasingFunction", typeof(global::System.Windows.Media.Animation.EasingFunctionBase), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings), new global::System.Windows.PropertyMetadata(new global::System.Windows.Media.Animation.SineEase
		{
			EasingMode = global::System.Windows.Media.Animation.EasingMode.EaseInOut
		}, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettings.EasingFunctionChanged)));

		// Token: 0x0400005F RID: 95
		public static readonly global::System.Windows.DependencyProperty AnimationDurationProperty = global::System.Windows.DependencyProperty.Register("AnimationDuration", typeof(int), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings), new global::System.Windows.PropertyMetadata(8, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettings.AnimationDurationChanged)));
	}
}
