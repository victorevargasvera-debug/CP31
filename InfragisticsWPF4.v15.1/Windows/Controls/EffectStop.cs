using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000268 RID: 616
	public abstract class EffectStop : global::Infragistics.DependencyObjectNotifier, global::System.IComparable
	{
		// Token: 0x0600196A RID: 6506 RVA: 0x0006216B File Offset: 0x0006036B
		protected EffectStop()
		{
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x00062174 File Offset: 0x00060374
		protected EffectStop(double offset, double value)
		{
			base.SetValue(global::Infragistics.Windows.Controls.EffectStop.OffsetProperty, global::System.Math.Max(global::System.Math.Min(offset, 1.0), 0.0));
			base.SetValue(global::Infragistics.Windows.Controls.EffectStop.ValueProperty, value);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x000621C5 File Offset: 0x000603C5
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			base.RaisePropertyChangedEvent(e.Property.Name);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000621E0 File Offset: 0x000603E0
		private static void OnOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.EffectStop effectStop = d as global::Infragistics.Windows.Controls.EffectStop;
			if (effectStop != null)
			{
				effectStop._cachedOffset = (double)e.NewValue;
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00062209 File Offset: 0x00060409
		private static bool OnValidateOffset(object value)
		{
			return (double)value >= 0.0 && (double)value <= 1.0;
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00062230 File Offset: 0x00060430
		// (set) Token: 0x06001970 RID: 6512 RVA: 0x00062238 File Offset: 0x00060438
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

		// Token: 0x06001971 RID: 6513 RVA: 0x0006224C File Offset: 0x0006044C
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.EffectStop effectStop = d as global::Infragistics.Windows.Controls.EffectStop;
			if (effectStop != null)
			{
				effectStop._cachedValue = (double)e.NewValue;
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00062278 File Offset: 0x00060478
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

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x000623BA File Offset: 0x000605BA
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x000623C2 File Offset: 0x000605C2
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

		// Token: 0x06001975 RID: 6517 RVA: 0x000623D8 File Offset: 0x000605D8
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

		// Token: 0x04000CBD RID: 3261
		private double _cachedOffset;

		// Token: 0x04000CBE RID: 3262
		private double _cachedValue;

		// Token: 0x04000CBF RID: 3263
		public static readonly global::System.Windows.DependencyProperty OffsetProperty = global::System.Windows.DependencyProperty.Register("Offset", typeof(double), typeof(global::Infragistics.Windows.Controls.EffectStop), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.EffectStop.OnOffsetChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Controls.EffectStop.OnValidateOffset));

		// Token: 0x04000CC0 RID: 3264
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(double), typeof(global::Infragistics.Windows.Controls.EffectStop), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.EffectStop.OnValueChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.EffectStop.OnCoerceValue)));
	}
}
