using System;
using System.Data;
using System.Diagnostics;

namespace Gibraltar
{
	// Token: 0x020000C2 RID: 194
	[global::System.Diagnostics.DebuggerDisplay("Status: {StatusMessage}, Progress: {CompletedSteps} of {MaxSteps}")]
	internal class ProgressMonitor : global::System.IDisposable
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000819 RID: 2073 RVA: 0x00010F30 File Offset: 0x0000F130
		// (remove) Token: 0x0600081A RID: 2074 RVA: 0x00010F6C File Offset: 0x0000F16C
		public event global::System.EventHandler<global::Gibraltar.ProgressMonitorEventArgs> Canceled;

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x0600081B RID: 2075 RVA: 0x00010FA8 File Offset: 0x0000F1A8
		// (remove) Token: 0x0600081C RID: 2076 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		public event global::System.EventHandler<global::Gibraltar.ProgressMonitorEventArgs> Updated;

		// Token: 0x0600081D RID: 2077 RVA: 0x00011020 File Offset: 0x0000F220
		internal ProgressMonitor(global::Gibraltar.ProgressMonitorStack progressMonitors, object owner, string status, int maxSteps)
		{
			this.m_Owner = owner;
			this.m_ProgressMonitors = progressMonitors;
			this.m_PercentComplete = 0.0;
			this.m_CompletedSteps = 0;
			this.m_MaxSteps = maxSteps;
			this.StatusMessage = status;
			this.m_PercentCompleteValid = true;
			this.m_Complete = false;
			this.m_ReadOnly = false;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0001108C File Offset: 0x0000F28C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00011094 File Offset: 0x0000F294
		public bool Complete
		{
			get
			{
				return this.m_Complete;
			}
			set
			{
				if (value)
				{
					object @lock = this.m_Lock;
					lock (@lock)
					{
						if (!this.m_Complete)
						{
							if (this.m_ReadOnly)
							{
								throw new global::System.Data.ReadOnlyException("The monitor has been marked complete and is now read only.");
							}
							this.m_PercentComplete = 1.0;
							this.m_PercentCompleteValid = true;
							this.m_Complete = true;
							this.m_ReadOnly = true;
							this.OnMonitorUpdated();
							this.m_ProgressMonitors.PopMonitor(this);
						}
					}
				}
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0001112C File Offset: 0x0000F32C
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00011134 File Offset: 0x0000F334
		public int CompletedSteps
		{
			get
			{
				return this.m_CompletedSteps;
			}
			private set
			{
				if (value > 0 && this.m_CompletedSteps != value)
				{
					this.m_CompletedSteps = value;
					this.m_PercentCompleteValid = false;
				}
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00011158 File Offset: 0x0000F358
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00011168 File Offset: 0x0000F368
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged && !this.m_ReadOnly)
			{
				this.Complete = true;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00011184 File Offset: 0x0000F384
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x0001118C File Offset: 0x0000F38C
		public int MaxSteps
		{
			get
			{
				return this.m_MaxSteps;
			}
			private set
			{
				if (value > 0 && this.m_MaxSteps != value)
				{
					this.m_MaxSteps = value;
					this.m_PercentCompleteValid = false;
				}
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000111B0 File Offset: 0x0000F3B0
		public object Owner
		{
			get
			{
				return this.m_Owner;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x000111B8 File Offset: 0x0000F3B8
		public double PercentComplete
		{
			get
			{
				object @lock = this.m_Lock;
				double percentComplete;
				lock (@lock)
				{
					if (!this.m_PercentCompleteValid)
					{
						if (this.m_MaxSteps > 0)
						{
							this.m_PercentComplete = (double)this.m_CompletedSteps / (double)this.m_MaxSteps;
						}
						else
						{
							this.m_PercentComplete = 0.0;
						}
						if (this.m_PercentComplete > 1.0)
						{
							this.m_PercentComplete = 1.0;
						}
						this.m_PercentCompleteValid = true;
					}
					percentComplete = this.m_PercentComplete;
				}
				return percentComplete;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00011260 File Offset: 0x0000F460
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00011268 File Offset: 0x0000F468
		public string StatusMessage
		{
			get
			{
				return this.m_StatusMessage;
			}
			private set
			{
				this.m_StatusMessage = (string.IsNullOrEmpty(value) ? string.Empty : value.Trim());
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001128C File Offset: 0x0000F48C
		public void Update(string status)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_ReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The monitor has been marked complete and is now read only.");
				}
				this.StatusMessage = status;
				this.OnMonitorUpdated();
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000112E8 File Offset: 0x0000F4E8
		public void Update(string status, int completedSteps)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_ReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The monitor has been marked complete and is now read only.");
				}
				this.StatusMessage = status;
				this.CompletedSteps = completedSteps;
				this.OnMonitorUpdated();
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00011348 File Offset: 0x0000F548
		public void Update(string status, int completedSteps, int maxSteps)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_ReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The monitor has been marked complete and is now read only.");
				}
				this.StatusMessage = status;
				this.MaxSteps = maxSteps;
				this.CompletedSteps = completedSteps;
				this.OnMonitorUpdated();
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000113B0 File Offset: 0x0000F5B0
		protected virtual void OnMonitorCanceled()
		{
			global::Gibraltar.ProgressMonitorEventArgs e = new global::Gibraltar.ProgressMonitorEventArgs(this.m_ProgressMonitors, this);
			global::System.EventHandler<global::Gibraltar.ProgressMonitorEventArgs> canceled = this.Canceled;
			if (canceled != null)
			{
				canceled(this, e);
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000113E4 File Offset: 0x0000F5E4
		protected virtual void OnMonitorUpdated()
		{
			global::Gibraltar.ProgressMonitorEventArgs e = new global::Gibraltar.ProgressMonitorEventArgs(this.m_ProgressMonitors, this);
			global::System.EventHandler<global::Gibraltar.ProgressMonitorEventArgs> updated = this.Updated;
			if (updated != null)
			{
				updated(this, e);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00011418 File Offset: 0x0000F618
		internal void Cancel()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_Complete)
				{
					if (!this.m_ReadOnly)
					{
						this.m_ReadOnly = true;
						this.OnMonitorCanceled();
						this.m_ProgressMonitors.PopMonitor(this);
					}
				}
			}
		}

		// Token: 0x040001B2 RID: 434
		private readonly object m_Lock = new object();

		// Token: 0x040001B3 RID: 435
		private readonly object m_Owner;

		// Token: 0x040001B4 RID: 436
		private readonly global::Gibraltar.ProgressMonitorStack m_ProgressMonitors;

		// Token: 0x040001B5 RID: 437
		private string m_StatusMessage;

		// Token: 0x040001B6 RID: 438
		private double m_PercentComplete;

		// Token: 0x040001B7 RID: 439
		private int m_CompletedSteps;

		// Token: 0x040001B8 RID: 440
		private int m_MaxSteps;

		// Token: 0x040001B9 RID: 441
		private bool m_PercentCompleteValid;

		// Token: 0x040001BA RID: 442
		private bool m_Complete;

		// Token: 0x040001BB RID: 443
		private bool m_ReadOnly;
	}
}
