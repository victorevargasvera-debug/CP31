using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000021 RID: 33
	public class ColumnMovingSettingsOverride : global::Infragistics.Controls.Grids.SettingsOverrideBase
	{
		// Token: 0x06000181 RID: 385 RVA: 0x0000970C File Offset: 0x0000790C
		public ColumnMovingSettingsOverride()
		{
			this._indicator = new global::Infragistics.Controls.Grids.Primitives.MovingIndicator();
			this._indicatorContainer = new global::System.Windows.Controls.Primitives.Popup();
			this._indicatorContainer.Child = this._indicator;
			this._contentContainer = new global::System.Windows.Controls.Primitives.Popup();
			this._contentContainer.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._contentContainer.AllowsTransparency = true;
			this._indicatorContainer.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Relative;
			this._indicatorContainer.AllowsTransparency = true;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00009781 File Offset: 0x00007981
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00009793 File Offset: 0x00007993
		public global::System.Windows.Style IndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.IndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.IndicatorStyleProperty, value);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000097A4 File Offset: 0x000079A4
		private static void IndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride columnMovingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride)obj;
			columnMovingSettingsOverride.OnPropertyChanged("IndicatorStyle");
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000097C3 File Offset: 0x000079C3
		public global::System.Windows.Style IndicatorStyleResolved
		{
			get
			{
				if (this.IndicatorStyle == null && this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnMovingSettings)this.SettingsObject).IndicatorStyle;
				}
				return this.IndicatorStyle;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000097EC File Offset: 0x000079EC
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000097FE File Offset: 0x000079FE
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.NullableEnumTypeConverter<global::Infragistics.Controls.Grids.ColumnMovingType>))]
		public global::Infragistics.Controls.Grids.ColumnMovingType? AllowColumnMoving
		{
			get
			{
				return (global::Infragistics.Controls.Grids.ColumnMovingType?)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.AllowColumnMovingTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.AllowColumnMovingTypeProperty, value);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00009814 File Offset: 0x00007A14
		private static void AllowColumnMovingTypeChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride columnMovingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride)obj;
			columnMovingSettingsOverride.OnPropertyChanged("AllowColumnMoving");
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009834 File Offset: 0x00007A34
		public global::Infragistics.Controls.Grids.ColumnMovingType AllowColumnMovingResolved
		{
			get
			{
				if (this.AllowColumnMoving != null)
				{
					return this.AllowColumnMoving.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnMovingSettings)this.SettingsObject).AllowColumnMoving;
				}
				return (global::Infragistics.Controls.Grids.ColumnMovingType)global::Infragistics.Controls.Grids.ColumnMovingSettings.AllowColumnMovingTypeProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings)).DefaultValue;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00009897 File Offset: 0x00007A97
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000098A9 File Offset: 0x00007AA9
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return (global::System.Windows.Media.Animation.EasingFunctionBase)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.EasingFunctionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.EasingFunctionProperty, value);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000098B8 File Offset: 0x00007AB8
		private static void EasingFunctionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride columnMovingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride)obj;
			columnMovingSettingsOverride.OnPropertyChanged("EasingFunction");
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000098D8 File Offset: 0x00007AD8
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunctionResolved
		{
			get
			{
				if (this.EasingFunction != null)
				{
					return this.EasingFunction;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnMovingSettings)this.SettingsObject).EasingFunction;
				}
				return (global::System.Windows.Media.Animation.EasingFunctionBase)global::Infragistics.Controls.Grids.ColumnMovingSettings.EasingFunctionProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings)).DefaultValue;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0000992B File Offset: 0x00007B2B
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000993D File Offset: 0x00007B3D
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Grids.Primitives.NullableIntConverter))]
		public int? AnimationDuration
		{
			get
			{
				return (int?)base.GetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.AnimationDurationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.AnimationDurationProperty, value);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009950 File Offset: 0x00007B50
		private static void AnimationDurationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride columnMovingSettingsOverride = (global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride)obj;
			columnMovingSettingsOverride.OnPropertyChanged("AnimationDuration");
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00009970 File Offset: 0x00007B70
		public int AnimationDurationResolved
		{
			get
			{
				if (this.AnimationDuration != null)
				{
					return this.AnimationDuration.Value;
				}
				if (this.SettingsObject != null)
				{
					return ((global::Infragistics.Controls.Grids.ColumnMovingSettings)this.SettingsObject).AnimationDuration;
				}
				return (int)global::Infragistics.Controls.Grids.ColumnMovingSettings.AnimationDurationProperty.GetMetadata(typeof(global::Infragistics.Controls.Grids.ColumnMovingSettings)).DefaultValue;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000099D4 File Offset: 0x00007BD4
		internal global::Infragistics.Controls.Grids.Primitives.MovingIndicator Indicator
		{
			get
			{
				global::System.Windows.Style indicatorStyleResolved = this.IndicatorStyleResolved;
				if (this._indicator.Style != indicatorStyleResolved && indicatorStyleResolved != null)
				{
					this._indicator.Style = indicatorStyleResolved;
				}
				return this._indicator;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00009A0B File Offset: 0x00007C0B
		internal global::System.Windows.Controls.Primitives.Popup IndicatorContainer
		{
			get
			{
				return this._indicatorContainer;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00009A13 File Offset: 0x00007C13
		internal global::System.Windows.Controls.Primitives.Popup ContentContainer
		{
			get
			{
				return this._contentContainer;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00009A1C File Offset: 0x00007C1C
		protected override global::Infragistics.Controls.Grids.SettingsBase SettingsObject
		{
			get
			{
				global::Infragistics.Controls.Grids.SettingsBase result = null;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					result = base.ColumnLayout.Grid.ColumnMovingSettings;
				}
				return result;
			}
		}

		// Token: 0x04000060 RID: 96
		private global::Infragistics.Controls.Grids.Primitives.MovingIndicator _indicator;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Controls.Primitives.Popup _indicatorContainer;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Controls.Primitives.Popup _contentContainer;

		// Token: 0x04000063 RID: 99
		public static readonly global::System.Windows.DependencyProperty IndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("IndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.IndicatorStyleChanged)));

		// Token: 0x04000064 RID: 100
		public static readonly global::System.Windows.DependencyProperty AllowColumnMovingTypeProperty = global::System.Windows.DependencyProperty.Register("AllowColumnMoving", typeof(global::Infragistics.Controls.Grids.ColumnMovingType?), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.AllowColumnMovingTypeChanged)));

		// Token: 0x04000065 RID: 101
		public static readonly global::System.Windows.DependencyProperty EasingFunctionProperty = global::System.Windows.DependencyProperty.Register("EasingFunction", typeof(global::System.Windows.Media.Animation.EasingFunctionBase), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.EasingFunctionChanged)));

		// Token: 0x04000066 RID: 102
		public static readonly global::System.Windows.DependencyProperty AnimationDurationProperty = global::System.Windows.DependencyProperty.Register("AnimationDuration", typeof(int?), typeof(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.ColumnMovingSettingsOverride.AnimationDurationChanged)));
	}
}
