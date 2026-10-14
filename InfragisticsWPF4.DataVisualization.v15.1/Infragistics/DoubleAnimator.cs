using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Infragistics
{
	// Token: 0x02000096 RID: 150
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class DoubleAnimator
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0001C520 File Offset: 0x0001A720
		public bool NeedsFlush
		{
			get
			{
				return this.TransitionProgress == 0.0;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001C533 File Offset: 0x0001A733
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x0001C53B File Offset: 0x0001A73B
		public double TransitionProgress
		{
			get
			{
				return this._transitionProgress;
			}
			set
			{
				this._transitionProgress = value;
				if (this.PropertyChanged != null)
				{
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs("TransitionProgress"));
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001C562 File Offset: 0x0001A762
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x0001C56A File Offset: 0x0001A76A
		public int IntervalMilliseconds
		{
			get
			{
				return this._intervalMilliseconds;
			}
			set
			{
				this._intervalMilliseconds = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001C573 File Offset: 0x0001A773
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0001C57B File Offset: 0x0001A77B
		public global::System.Windows.Media.Animation.EasingFunctionBase EasingFunction
		{
			get
			{
				return this._easingFunction;
			}
			set
			{
				this._easingFunction = value;
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001C584 File Offset: 0x0001A784
		internal DoubleAnimator()
		{
			this._from = 0.0;
			this._to = 1.0;
			this._intervalMilliseconds = 0;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001C5C4 File Offset: 0x0001A7C4
		public DoubleAnimator(double from, double to, int intervalMilliseconds)
		{
			this._from = from;
			this._to = to;
			this._intervalMilliseconds = intervalMilliseconds;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001C5F4 File Offset: 0x0001A7F4
		private void CompositionTarget_Rendering(object sender, global::System.EventArgs e)
		{
			this.Update(false);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001C5FD File Offset: 0x0001A7FD
		public void Flush()
		{
			this.Update(true);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001C608 File Offset: 0x0001A808
		internal void Update(bool flush)
		{
			if (this._active)
			{
				global::System.TimeSpan elapsed = this._watch.Elapsed;
				if (elapsed.TotalMilliseconds - this._lastElapsed.TotalMilliseconds < (double)this._throttleMilliseconds && !flush)
				{
					return;
				}
				this._lastElapsed = elapsed;
				this._currentTime = elapsed.TotalMilliseconds / (double)this._intervalMilliseconds;
				if (this._currentTime >= 1.0)
				{
					this._currentTime = 1.0;
					this.Stop();
				}
				this.Tick();
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001C694 File Offset: 0x0001A894
		public double GetElapsedMilliseconds()
		{
			if (!this._active || this._watch == null)
			{
				return 0.0;
			}
			return this._watch.Elapsed.TotalMilliseconds;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001C6D0 File Offset: 0x0001A8D0
		private void Tick()
		{
			if (this.EasingFunction == null)
			{
				this.TransitionProgress = this._from + (this._to - this._from) * this._currentTime;
				return;
			}
			this.TransitionProgress = this._from + (this._to - this._from) * this.EasingFunction.Ease(this._currentTime);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001C734 File Offset: 0x0001A934
		public void Start()
		{
			bool active = this._active;
			if (this._active)
			{
				this._active = false;
				this._watch.Reset();
			}
			this._lastElapsed = global::System.TimeSpan.FromSeconds(0.0);
			this._active = true;
			this._watch.Start();
			this._currentTime = 0.0;
			if (!active)
			{
				global::System.Windows.Media.CompositionTarget.Rendering += this.CompositionTarget_Rendering;
			}
			this.Tick();
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001C7B1 File Offset: 0x0001A9B1
		public void Stop()
		{
			if (this._active)
			{
				this._active = false;
				this._watch.Reset();
				global::System.Windows.Media.CompositionTarget.Rendering -= this.CompositionTarget_Rendering;
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001C7DE File Offset: 0x0001A9DE
		public virtual bool AnimationActive()
		{
			return this._active;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060006A7 RID: 1703 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		// (remove) Token: 0x060006A8 RID: 1704 RVA: 0x0001C820 File Offset: 0x0001AA20
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0400028A RID: 650
		private double _transitionProgress;

		// Token: 0x0400028B RID: 651
		private int _intervalMilliseconds;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Media.Animation.EasingFunctionBase _easingFunction;

		// Token: 0x0400028D RID: 653
		private double _from;

		// Token: 0x0400028E RID: 654
		private double _to;

		// Token: 0x0400028F RID: 655
		private bool _active;

		// Token: 0x04000290 RID: 656
		private global::System.TimeSpan _lastElapsed;

		// Token: 0x04000291 RID: 657
		private int _throttleMilliseconds = 10;

		// Token: 0x04000292 RID: 658
		private double _currentTime;

		// Token: 0x04000293 RID: 659
		private global::System.Diagnostics.Stopwatch _watch = new global::System.Diagnostics.Stopwatch();
	}
}
