using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000233 RID: 563
	public abstract class EffectStop : global::Infragistics.DependencyObjectNotifier, global::System.IComparable
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x0005B6F3 File Offset: 0x000598F3
		protected EffectStop()
		{
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0005B6FC File Offset: 0x000598FC
		protected EffectStop(double offset, double value)
		{
			base.SetValue(global::Infragistics.Windows.Controls.EffectStop.OffsetProperty, global::System.Math.Max(global::System.Math.Min(offset, 1.0), 0.0));
			base.SetValue(global::Infragistics.Windows.Controls.EffectStop.ValueProperty, value);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x0005B74D File Offset: 0x0005994D
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			base.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x0005B768 File Offset: 0x00059968
		private static void OnOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.EffectStop effectStop = d as global::Infragistics.Windows.Controls.EffectStop;
			if (effectStop != null)
			{
				effectStop._cachedOffset = (double)e.NewValue;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0005B791 File Offset: 0x00059991
		private static bool OnValidateOffset(object value)
		{
			return (double)value >= 0.0 && (double)value <= 1.0;
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0005B7B8 File Offset: 0x000599B8
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x0005B7C0 File Offset: 0x000599C0
		[global::System.ComponentModel.Bindable(true)]
		public double Offset
		{
			get
			{
				return this._cachedOffset;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.EffectStop.OffsetProperty, value);
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0005B7D4 File Offset: 0x000599D4
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.EffectStop effectStop = d as global::Infragistics.Windows.Controls.EffectStop;
			if (effectStop != null)
			{
				effectStop._cachedValue = (double)e.NewValue;
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0005B800 File Offset: 0x00059A00
		private static object OnCoerceValue(global::System.Windows.DependencyObject d, object value)
		{
			if (d is global::Infragistics.Windows.Controls.ScalingEffectStop)
			{
				if ((double)value < 0.0 || (double)value > 10.0)
				{
					return 1.0;
				}
				return value;
			}
			else if (d is global::Infragistics.Windows.Controls.ZOrderEffectStop)
			{
				if ((double)value < 0.0 || (double)value > 1.0)
				{
					return 0.0;
				}
				return value;
			}
			else if (d is global::Infragistics.Windows.Controls.SkewAngleXEffectStop)
			{
				if ((double)value < -360.0 || (double)value > 360.0)
				{
					return 0.0;
				}
				return value;
			}
			else if (d is global::Infragistics.Windows.Controls.SkewAngleYEffectStop)
			{
				if ((double)value < -360.0 || (double)value > 360.0)
				{
					return 0.0;
				}
				return value;
			}
			else
			{
				if (!(d is global::Infragistics.Windows.Controls.OpacityEffectStop))
				{
					return 0.0;
				}
				if ((double)value < 0.0 || (double)value > 1.0)
				{
					return 0.0;
				}
				return value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0005B942 File Offset: 0x00059B42
		// (set) Token: 0x06001772 RID: 6002 RVA: 0x0005B94A File Offset: 0x00059B4A
		[global::System.ComponentModel.Bindable(true)]
		public double Value
		{
			get
			{
				return this._cachedValue;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.EffectStop.ValueProperty, value);
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0005B960 File Offset: 0x00059B60
		int global::System.IComparable.CompareTo(object obj)
		{
			global::Infragistics.Windows.Controls.EffectStop effectStop = (global::Infragistics.Windows.Controls.EffectStop)obj;
			if (this.Offset == effectStop.Offset)
			{
				return 0;
			}
			if (this.Offset < effectStop.Offset)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x04000B5A RID: 2906
		private double _cachedOffset;

		// Token: 0x04000B5B RID: 2907
		private double _cachedValue;

		// Token: 0x04000B5C RID: 2908
		public static readonly global::System.Windows.DependencyProperty OffsetProperty = global::System.Windows.DependencyProperty.Register("Offset", typeof(double), typeof(global::Infragistics.Windows.Controls.EffectStop), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.EffectStop.OnOffsetChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.EffectStop.OnValidateOffset));

		// Token: 0x04000B5D RID: 2909
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(double), typeof(global::Infragistics.Windows.Controls.EffectStop), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.EffectStop.OnValueChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.EffectStop.OnCoerceValue)));
	}
}
