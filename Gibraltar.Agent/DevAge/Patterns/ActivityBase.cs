using System;
using System.Threading;

namespace DevAge.Patterns
{
	// Token: 0x020002A5 RID: 677
	internal abstract class ActivityBase : global::DevAge.Patterns.IActivity
	{
		// Token: 0x060021BC RID: 8636 RVA: 0x00077D34 File Offset: 0x00075F34
		public ActivityBase()
		{
			int num;
			lock (global::DevAge.Patterns.ActivityBase.sLock)
			{
				global::DevAge.Patterns.ActivityBase.sActivityCount++;
				num = global::DevAge.Patterns.ActivityBase.sActivityCount;
			}
			this.Name = "Activity " + num.ToString();
			this.mSubActivities = new global::DevAge.Patterns.ActivityCollection(this);
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00077DC8 File Offset: 0x00075FC8
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x00077DD0 File Offset: 0x00075FD0
		public int SubActivitiesTimeOut
		{
			get
			{
				return this.mSubActivitiesTimeOut;
			}
			set
			{
				this.mSubActivitiesTimeOut = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x00077DDC File Offset: 0x00075FDC
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x00077DE4 File Offset: 0x00075FE4
		public bool PropagateException
		{
			get
			{
				return this.mPropagateException;
			}
			set
			{
				this.mPropagateException = value;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00077DF0 File Offset: 0x00075FF0
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x00077DF8 File Offset: 0x00075FF8
		public global::DevAge.Patterns.SubActivityWaitMode SubActivityWaitMode
		{
			get
			{
				return this.mSubActivityWaitMode;
			}
			set
			{
				this.mSubActivityWaitMode = value;
			}
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00077E04 File Offset: 0x00076004
		protected virtual void ResetRunningStatus()
		{
			if (this.mStatus == global::DevAge.Patterns.ActivityStatus.Running)
			{
				throw new global::DevAge.Patterns.ActivityStatusNotValidException();
			}
			this.mIsCanceled = false;
			this.mStatus = global::DevAge.Patterns.ActivityStatus.Pending;
			this.mException = null;
			this.mWaitHandle.Set();
		}

		// Token: 0x060021C4 RID: 8644
		protected abstract void OnWork();

		// Token: 0x060021C5 RID: 8645 RVA: 0x00077E3C File Offset: 0x0007603C
		protected void DoWork()
		{
			bool flag = false;
			try
			{
				this.OnWork();
				for (int i = 0; i < this.SubActivities.Count; i++)
				{
					if (this.mIsCanceled)
					{
						throw new global::DevAge.Patterns.ActivityCanceledException();
					}
					this.SubActivities[i].Start(this.mEvents);
					if (this.SubActivityWaitMode == global::DevAge.Patterns.SubActivityWaitMode.WaitOnEach)
					{
						global::DevAge.Patterns.ActivityBase.WaitActivity(this.SubActivities[i], this.SubActivitiesTimeOut);
						global::DevAge.Patterns.ActivityBase.CheckActivityException(this.SubActivities[i]);
					}
				}
				if (this.SubActivityWaitMode == global::DevAge.Patterns.SubActivityWaitMode.WaitAtTheEnd)
				{
					global::DevAge.Patterns.ActivityBase.WaitActivities(this.SubActivities, this.SubActivitiesTimeOut);
					if (this.PropagateException)
					{
						global::DevAge.Patterns.ActivityBase.CheckActivitiesException(this.SubActivities);
					}
				}
				flag = true;
			}
			catch (global::System.Exception e)
			{
				this.OnException(e);
			}
			if (flag)
			{
				this.OnCompleted();
			}
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00077F2C File Offset: 0x0007612C
		public static void WaitActivities(global::DevAge.Patterns.ActivityCollection activities, int timeout)
		{
			for (int i = 0; i < activities.Count; i++)
			{
				global::DevAge.Patterns.ActivityBase.WaitActivity(activities[i], timeout);
			}
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00077F60 File Offset: 0x00076160
		public static void WaitActivity(global::DevAge.Patterns.IActivity activity, int timeout)
		{
			if (activity.Status == global::DevAge.Patterns.ActivityStatus.Pending)
			{
				throw new global::DevAge.DevAgeApplicationException("Activity not started");
			}
			if (activity.Status == global::DevAge.Patterns.ActivityStatus.Running && !activity.WaitHandle.WaitOne(timeout, false))
			{
				throw new global::DevAge.Patterns.TimeOutActivityException();
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00077FB0 File Offset: 0x000761B0
		public static void CheckActivitiesException(global::DevAge.Patterns.ActivityCollection activities)
		{
			for (int i = 0; i < activities.Count; i++)
			{
				global::DevAge.Patterns.ActivityBase.CheckActivityException(activities[i]);
			}
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00077FE4 File Offset: 0x000761E4
		public static void CheckActivityException(global::DevAge.Patterns.IActivity activity)
		{
			if (activity.Status == global::DevAge.Patterns.ActivityStatus.Exception)
			{
				throw new global::DevAge.Patterns.SubActivityException(activity.Name, activity.Exception);
			}
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00078004 File Offset: 0x00076204
		protected virtual void StartActivity()
		{
			this.DoWork();
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0007800C File Offset: 0x0007620C
		protected virtual void OnStarted()
		{
			this.mWaitHandle.Reset();
			this.mStatus = global::DevAge.Patterns.ActivityStatus.Running;
			if (this.mEvents != null)
			{
				this.mEvents.ActivityStarted(this);
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00078038 File Offset: 0x00076238
		protected virtual void OnCompleted()
		{
			this.mStatus = global::DevAge.Patterns.ActivityStatus.Completed;
			this.mWaitHandle.Set();
			if (this.mEvents != null)
			{
				this.mEvents.ActivityCompleted(this);
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00078064 File Offset: 0x00076264
		protected virtual void OnException(global::System.Exception e)
		{
			this.mStatus = global::DevAge.Patterns.ActivityStatus.Exception;
			this.mException = e;
			this.mWaitHandle.Set();
			if (this.mEvents != null)
			{
				this.mEvents.ActivityException(this, e);
			}
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00078098 File Offset: 0x00076298
		public void Start(global::DevAge.Patterns.IActivityEvents events)
		{
			this.ResetRunningStatus();
			if (this.mStatus != global::DevAge.Patterns.ActivityStatus.Pending)
			{
				throw new global::DevAge.Patterns.ActivityStatusNotValidException();
			}
			this.mEvents = events;
			try
			{
				this.OnStarted();
				this.StartActivity();
			}
			catch (global::System.Exception e)
			{
				this.OnException(e);
			}
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000780F4 File Offset: 0x000762F4
		public void Cancel()
		{
			this.mIsCanceled = true;
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00078100 File Offset: 0x00076300
		public global::DevAge.Patterns.ActivityCollection SubActivities
		{
			get
			{
				return this.mSubActivities;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00078108 File Offset: 0x00076308
		public global::DevAge.Patterns.ActivityStatus Status
		{
			get
			{
				return this.mStatus;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x00078110 File Offset: 0x00076310
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00078118 File Offset: 0x00076318
		public string Name
		{
			get
			{
				return this.mName;
			}
			set
			{
				this.mName = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x00078124 File Offset: 0x00076324
		public virtual global::System.Threading.WaitHandle WaitHandle
		{
			get
			{
				return this.mWaitHandle;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0007812C File Offset: 0x0007632C
		public global::System.Exception Exception
		{
			get
			{
				return this.mException;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x00078134 File Offset: 0x00076334
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x0007813C File Offset: 0x0007633C
		public global::DevAge.Patterns.IActivity Parent
		{
			get
			{
				return this.mParent;
			}
			set
			{
				if (this.mParent != null && value != null)
				{
					throw new global::DevAge.DevAgeApplicationException("Activity already has a parent");
				}
				this.mParent = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x00078164 File Offset: 0x00076364
		public string FullName
		{
			get
			{
				if (this.Parent == null)
				{
					return this.Name;
				}
				return this.Parent.Name + "\\" + this.Name;
			}
		}

		// Token: 0x04000C46 RID: 3142
		private global::DevAge.Patterns.ActivityCollection mSubActivities;

		// Token: 0x04000C47 RID: 3143
		private bool mIsCanceled;

		// Token: 0x04000C48 RID: 3144
		private global::DevAge.Patterns.ActivityStatus mStatus;

		// Token: 0x04000C49 RID: 3145
		private global::DevAge.Patterns.IActivityEvents mEvents;

		// Token: 0x04000C4A RID: 3146
		private string mName;

		// Token: 0x04000C4B RID: 3147
		private int mSubActivitiesTimeOut = -1;

		// Token: 0x04000C4C RID: 3148
		private static int sActivityCount = 0;

		// Token: 0x04000C4D RID: 3149
		private static readonly object sLock = new object();

		// Token: 0x04000C4E RID: 3150
		private global::DevAge.Patterns.SubActivityWaitMode mSubActivityWaitMode = global::DevAge.Patterns.SubActivityWaitMode.WaitOnEach;

		// Token: 0x04000C4F RID: 3151
		private bool mPropagateException = true;

		// Token: 0x04000C50 RID: 3152
		private global::System.Exception mException;

		// Token: 0x04000C51 RID: 3153
		private global::DevAge.Patterns.IActivity mParent;

		// Token: 0x04000C52 RID: 3154
		private global::System.Threading.ManualResetEvent mWaitHandle = new global::System.Threading.ManualResetEvent(true);
	}
}
