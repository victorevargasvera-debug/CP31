using System;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Infragistics
{
	// Token: 0x020000B6 RID: 182
	public class Animation
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x00018688 File Offset: 0x00016888
		public Animation()
		{
			this.EasingFunction = new global::System.Windows.Media.Animation.SineEase();
			this.Duration = 8;
			this._timer = new global::System.Windows.Threading.DispatcherTimer();
			this._timer.Tick += this.timer_Tick;
			this._timer.Interval = global::System.TimeSpan.FromMilliseconds(1.0);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000186E8 File Offset: 0x000168E8
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x000186F0 File Offset: 0x000168F0
		public int Duration { get; set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x000186F9 File Offset: 0x000168F9
		public bool IsPlaying
		{
			get
			{
				return this._isPlaying;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00018701 File Offset: 0x00016901
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00018709 File Offset: 0x00016909
		public int Time { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00018712 File Offset: 0x00016912
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0001871A File Offset: 0x0001691A
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunction { get; set; }

		// Token: 0x060006E4 RID: 1764 RVA: 0x00018723 File Offset: 0x00016923
		public void Play()
		{
			this.Time = 0;
			this._prevValue = 0.0;
			this._timer.Start();
			this._isPlaying = true;
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001874D File Offset: 0x0001694D
		public void Continue()
		{
			if (this.Time < this.Duration)
			{
				this._timer.Start();
				this._isPlaying = true;
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001876F File Offset: 0x0001696F
		public void Stop()
		{
			this._timer.Stop();
			this._isPlaying = false;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00018783 File Offset: 0x00016983
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
		// (add) Token: 0x060006E8 RID: 1768 RVA: 0x000187B4 File Offset: 0x000169B4
		// (remove) Token: 0x060006E9 RID: 1769 RVA: 0x000187EC File Offset: 0x000169EC
		public event global::System.EventHandler<global::Infragistics.AnimationEventArgs> Tick;

		// Token: 0x060006EA RID: 1770 RVA: 0x00018824 File Offset: 0x00016A24
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
		// (add) Token: 0x060006EB RID: 1771 RVA: 0x0001889C File Offset: 0x00016A9C
		// (remove) Token: 0x060006EC RID: 1772 RVA: 0x000188D4 File Offset: 0x00016AD4
		public event global::System.EventHandler Complete;

		// Token: 0x060006ED RID: 1773 RVA: 0x00018909 File Offset: 0x00016B09
		protected virtual void OnComplete()
		{
			if (this.Complete != null)
			{
				this.Complete(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Threading.DispatcherTimer _timer;

		// Token: 0x04000324 RID: 804
		private bool _isPlaying;

		// Token: 0x04000325 RID: 805
		private double _prevValue;
	}
}
