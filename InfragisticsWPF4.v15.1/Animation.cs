using System;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Infragistics
{
	// Token: 0x020000D2 RID: 210
	public class Animation
	{
		// Token: 0x060007C7 RID: 1991 RVA: 0x0001BE30 File Offset: 0x0001A030
		public Animation()
		{
			this.EasingFunction = new global::System.Windows.Media.Animation.SineEase();
			this.Duration = 8;
			this._timer = new global::System.Windows.Threading.DispatcherTimer();
			this._timer.Tick += this.timer_Tick;
			this._timer.Interval = global::System.TimeSpan.FromMilliseconds(1.0);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0001BE90 File Offset: 0x0001A090
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0001BE98 File Offset: 0x0001A098
		public int Duration { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0001BEA1 File Offset: 0x0001A0A1
		public bool IsPlaying
		{
			get
			{
				return this._isPlaying;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0001BEA9 File Offset: 0x0001A0A9
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x0001BEB1 File Offset: 0x0001A0B1
		public int Time { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x0001BEBA File Offset: 0x0001A0BA
		// (set) Token: 0x060007CE RID: 1998 RVA: 0x0001BEC2 File Offset: 0x0001A0C2
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunction { get; set; }

		// Token: 0x060007CF RID: 1999 RVA: 0x0001BECB File Offset: 0x0001A0CB
		public void Play()
		{
			this.Time = 0;
			this._prevValue = 0.0;
			this._timer.Start();
			this._isPlaying = true;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0001BEF5 File Offset: 0x0001A0F5
		public void Continue()
		{
			if (this.Time < this.Duration)
			{
				this._timer.Start();
				this._isPlaying = true;
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0001BF17 File Offset: 0x0001A117
		public void Stop()
		{
			this._timer.Stop();
			this._isPlaying = false;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0001BF2B File Offset: 0x0001A12B
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

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060007D3 RID: 2003 RVA: 0x0001BF5C File Offset: 0x0001A15C
		// (remove) Token: 0x060007D4 RID: 2004 RVA: 0x0001BF94 File Offset: 0x0001A194
		public event global::System.EventHandler<global::Infragistics.AnimationEventArgs> Tick;

		// Token: 0x060007D5 RID: 2005 RVA: 0x0001BFCC File Offset: 0x0001A1CC
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

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060007D6 RID: 2006 RVA: 0x0001C044 File Offset: 0x0001A244
		// (remove) Token: 0x060007D7 RID: 2007 RVA: 0x0001C07C File Offset: 0x0001A27C
		public event global::System.EventHandler Complete;

		// Token: 0x060007D8 RID: 2008 RVA: 0x0001C0B1 File Offset: 0x0001A2B1
		protected virtual void OnComplete()
		{
			if (this.Complete != null)
			{
				this.Complete(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x040003CC RID: 972
		private global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x040003CD RID: 973
		private bool _isPlaying;

		// Token: 0x040003CE RID: 974
		private double _prevValue;
	}
}
