using System;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Infragistics
{
	// Token: 0x02000003 RID: 3
	public class Animation
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000233C File Offset: 0x0000053C
		public Animation()
		{
			this.EasingFunction = new global::System.Windows.Media.Animation.SineEase();
			this.Duration = 8;
			this._timer = new global::System.Windows.Threading.DispatcherTimer();
			this._timer.Tick += this.timer_Tick;
			this._timer.Interval = global::System.TimeSpan.FromMilliseconds(1.0);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000023A4 File Offset: 0x000005A4
		public int Duration { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000023AD File Offset: 0x000005AD
		public bool IsPlaying
		{
			get
			{
				return this._isPlaying;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000023B5 File Offset: 0x000005B5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000023BD File Offset: 0x000005BD
		public int Time { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000023C6 File Offset: 0x000005C6
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000023CE File Offset: 0x000005CE
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunction { get; set; }

		// Token: 0x0600000F RID: 15 RVA: 0x000023D7 File Offset: 0x000005D7
		public void Play()
		{
			this.Time = 0;
			this._prevValue = 0.0;
			this._timer.Start();
			this._isPlaying = true;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002401 File Offset: 0x00000601
		public void Continue()
		{
			if (this.Time < this.Duration)
			{
				this._timer.Start();
				this._isPlaying = true;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002423 File Offset: 0x00000623
		public void Stop()
		{
			this._timer.Stop();
			this._isPlaying = false;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002437 File Offset: 0x00000637
		private void timer_Tick(object sender, global::System.EventArgs e)
		{
			this.Time++;
			this.OnTick();
			if (this.Time == this.Duration)
			{
				this.Stop();
				this.OnComplete();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000013 RID: 19 RVA: 0x00002468 File Offset: 0x00000668
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x000024A0 File Offset: 0x000006A0
		public event global::System.EventHandler<global::Infragistics.AnimationEventArgs> Tick;

		// Token: 0x06000015 RID: 21 RVA: 0x000024D8 File Offset: 0x000006D8
		protected virtual void OnTick()
		{
			double num = this.EasingFunction.Ease((double)this.Time / (double)this.Duration);
			if (this.Time == this.Duration)
			{
				num = 1.0;
			}
			if (this.Tick != null)
			{
				this.Tick(this, new global::Infragistics.AnimationEventArgs
				{
					Value = num,
					Difference = num - this._prevValue
				});
			}
			this._prevValue = num;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000016 RID: 22 RVA: 0x00002550 File Offset: 0x00000750
		// (remove) Token: 0x06000017 RID: 23 RVA: 0x00002588 File Offset: 0x00000788
		public event global::System.EventHandler Complete;

		// Token: 0x06000018 RID: 24 RVA: 0x000025BD File Offset: 0x000007BD
		protected virtual void OnComplete()
		{
			if (this.Complete != null)
			{
				this.Complete(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x04000004 RID: 4
		private bool _isPlaying;

		// Token: 0x04000005 RID: 5
		private double _prevValue;
	}
}
