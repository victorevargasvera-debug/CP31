using System;

namespace System.Windows.Controls.Primitives
{
	// Token: 0x0200000F RID: 15
	public abstract class Clipper : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00005A05 File Offset: 0x00003C05
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00005A17 File Offset: 0x00003C17
		public double RatioVisible
		{
			get
			{
				return (double)base.GetValue(global::System.Windows.Controls.Primitives.Clipper.RatioVisibleProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Primitives.Clipper.RatioVisibleProperty, value);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00005A2C File Offset: 0x00003C2C
		private static void OnRatioVisibleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Primitives.Clipper clipper = (global::System.Windows.Controls.Primitives.Clipper)d;
			double oldValue = (double)e.OldValue;
			double newValue = (double)e.NewValue;
			clipper.OnRatioVisibleChanged(oldValue, newValue);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00005A64 File Offset: 0x00003C64
		protected virtual void OnRatioVisibleChanged(double oldValue, double newValue)
		{
			if (newValue >= 0.0 && newValue <= 1.0)
			{
				this.ClipContent();
				return;
			}
			if (newValue < 0.0)
			{
				this.RatioVisible = 0.0;
				return;
			}
			if (newValue > 1.0)
			{
				this.RatioVisible = 1.0;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00005AD0 File Offset: 0x00003CD0
		protected Clipper()
		{
			base.SizeChanged += delegate(object A_1, global::System.Windows.SizeChangedEventArgs A_2)
			{
				this.ClipContent();
			};
		}

		// Token: 0x0600010A RID: 266
		protected abstract void ClipContent();

		// Token: 0x0400004D RID: 77
		public static readonly global::System.Windows.DependencyProperty RatioVisibleProperty = global::System.Windows.DependencyProperty.Register("RatioVisible", typeof(double), typeof(global::System.Windows.Controls.Primitives.Clipper), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Primitives.Clipper.OnRatioVisibleChanged)));
	}
}
