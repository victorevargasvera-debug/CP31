using System;
using System.Windows;
using System.Windows.Interactivity;
using System.Windows.Threading;

namespace Microsoft.Expression.Interactivity.Core
{
	// Token: 0x0200002B RID: 43
	public sealed class TimerTrigger : global::System.Windows.Interactivity.EventTrigger
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00008C46 File Offset: 0x00006E46
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00008C58 File Offset: 0x00006E58
		public double MillisecondsPerTick
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Interactivity.Core.TimerTrigger.MillisecondsPerTickProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.TimerTrigger.MillisecondsPerTickProperty, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00008C6B File Offset: 0x00006E6B
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00008C7D File Offset: 0x00006E7D
		public int TotalTicks
		{
			get
			{
				return (int)base.GetValue(global::Microsoft.Expression.Interactivity.Core.TimerTrigger.TotalTicksProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Interactivity.Core.TimerTrigger.TotalTicksProperty, value);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008C90 File Offset: 0x00006E90
		protected override void OnEvent(global::System.EventArgs eventArgs)
		{
			this.StopTimer();
			this.eventArgs = eventArgs;
			this.tickCount = 0;
			this.StartTimer();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00008CAC File Offset: 0x00006EAC
		protected override void OnDetaching()
		{
			this.StopTimer();
			base.OnDetaching();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00008CBC File Offset: 0x00006EBC
		internal void StartTimer()
		{
			this.timer = new global::System.Windows.Threading.DispatcherTimer();
			this.timer.Interval = global::System.TimeSpan.FromMilliseconds(this.MillisecondsPerTick);
			this.timer.Tick += this.OnTimerTick;
			this.timer.Start();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00008D0C File Offset: 0x00006F0C
		internal void StopTimer()
		{
			if (this.timer != null)
			{
				this.timer.Stop();
				this.timer = null;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00008D28 File Offset: 0x00006F28
		private void OnTimerTick(object sender, global::System.EventArgs e)
		{
			if (this.TotalTicks > 0 && ++this.tickCount >= this.TotalTicks)
			{
				this.StopTimer();
			}
			base.InvokeActions(this.eventArgs);
		}

		// Token: 0x04000080 RID: 128
		public static readonly global::System.Windows.DependencyProperty MillisecondsPerTickProperty = global::System.Windows.DependencyProperty.Register("MillisecondsPerTick", typeof(double), typeof(global::Microsoft.Expression.Interactivity.Core.TimerTrigger), new global::System.Windows.FrameworkPropertyMetadata(1000.0));

		// Token: 0x04000081 RID: 129
		public static readonly global::System.Windows.DependencyProperty TotalTicksProperty = global::System.Windows.DependencyProperty.Register("TotalTicks", typeof(int), typeof(global::Microsoft.Expression.Interactivity.Core.TimerTrigger), new global::System.Windows.FrameworkPropertyMetadata(-1));

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Threading.DispatcherTimer timer;

		// Token: 0x04000083 RID: 131
		private global::System.EventArgs eventArgs;

		// Token: 0x04000084 RID: 132
		private int tickCount;
	}
}
