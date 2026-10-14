using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace Gibraltar
{
	// Token: 0x020000C4 RID: 196
	[global::System.Diagnostics.DebuggerDisplay("{Title}:{StatusMessage}, Completed {CompletedSteps} of {MaximumSteps}. {Count} monitors")]
	internal class ProgressMonitorStack : global::System.IDisposable
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000833 RID: 2099 RVA: 0x000114B0 File Offset: 0x0000F6B0
		// (remove) Token: 0x06000834 RID: 2100 RVA: 0x000114EC File Offset: 0x0000F6EC
		public event global::System.EventHandler<global::Gibraltar.ProgressMonitorStackEventArgs> Canceled;

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000835 RID: 2101 RVA: 0x00011528 File Offset: 0x0000F728
		// (remove) Token: 0x06000836 RID: 2102 RVA: 0x00011564 File Offset: 0x0000F764
		public event global::System.EventHandler<global::Gibraltar.ProgressMonitorEventArgs> Changed;

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000837 RID: 2103 RVA: 0x000115A0 File Offset: 0x0000F7A0
		// (remove) Token: 0x06000838 RID: 2104 RVA: 0x000115DC File Offset: 0x0000F7DC
		public event global::System.EventHandler<global::Gibraltar.ProgressMonitorStackEventArgs> Completed;

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000839 RID: 2105 RVA: 0x00011618 File Offset: 0x0000F818
		// (remove) Token: 0x0600083A RID: 2106 RVA: 0x00011654 File Offset: 0x0000F854
		public event global::System.EventHandler<global::Gibraltar.ProgressMonitorStackEventArgs> Updated;

		// Token: 0x0600083B RID: 2107 RVA: 0x00011690 File Offset: 0x0000F890
		public ProgressMonitorStack(string title)
		{
			this.m_Title = title;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000116B8 File Offset: 0x0000F8B8
		public void Cancel()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_Complete)
				{
					if (!this.m_ReadOnly)
					{
						this.m_ReadOnly = true;
						while (this.m_Stack.Count > 0)
						{
							this.m_Stack.Peek().Cancel();
						}
						this.m_Canceled = true;
						this.m_ReadOnly = true;
						this.OnCanceled();
					}
				}
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0001174C File Offset: 0x0000F94C
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00011754 File Offset: 0x0000F954
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
							this.m_Complete = true;
							this.m_ReadOnly = true;
							while (this.m_Stack.Count > 0)
							{
								this.m_Stack.Peek().Complete = true;
							}
							this.OnCompleted();
						}
					}
				}
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000117F0 File Offset: 0x0000F9F0
		public int CompletedSteps
		{
			get
			{
				object @lock = this.m_Lock;
				int completedSteps;
				lock (@lock)
				{
					completedSteps = this.m_CompletedSteps;
				}
				return completedSteps;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00011830 File Offset: 0x0000FA30
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_Stack.Count;
				}
				return count;
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00011874 File Offset: 0x0000FA74
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00011884 File Offset: 0x0000FA84
		public int MaximumSteps
		{
			get
			{
				object @lock = this.m_Lock;
				int maximumSteps;
				lock (@lock)
				{
					maximumSteps = this.m_MaximumSteps;
				}
				return maximumSteps;
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000118C4 File Offset: 0x0000FAC4
		public global::Gibraltar.ProgressMonitor NewMonitor(object owner, string status, int maxSteps)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.ProgressMonitor result;
			lock (@lock)
			{
				if (this.m_ReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The monitor has been marked complete and is now read only.");
				}
				global::Gibraltar.ProgressMonitor progressMonitor = new global::Gibraltar.ProgressMonitor(this, owner, status, maxSteps);
				this.PushMonitor(progressMonitor);
				result = progressMonitor;
			}
			return result;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00011924 File Offset: 0x0000FB24
		public string StatusMessage
		{
			get
			{
				object @lock = this.m_Lock;
				string statusMessage;
				lock (@lock)
				{
					statusMessage = this.m_StatusMessage;
				}
				return statusMessage;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00011964 File Offset: 0x0000FB64
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0001196C File Offset: 0x0000FB6C
		public bool IsCanceled
		{
			get
			{
				object @lock = this.m_Lock;
				bool canceled;
				lock (@lock)
				{
					canceled = this.m_Canceled;
				}
				return canceled;
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000119AC File Offset: 0x0000FBAC
		protected virtual void OnCanceled()
		{
			global::Gibraltar.ProgressMonitorStackEventArgs e = new global::Gibraltar.ProgressMonitorStackEventArgs(this, this.m_StatusMessage, this.m_CompletedSteps, this.m_MaximumSteps);
			global::System.EventHandler<global::Gibraltar.ProgressMonitorStackEventArgs> canceled = this.Canceled;
			if (canceled != null)
			{
				canceled(this, e);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000119EC File Offset: 0x0000FBEC
		protected virtual void OnChanged()
		{
			global::Gibraltar.ProgressMonitor progressMonitor = null;
			if (this.m_Stack.Count > 0)
			{
				progressMonitor = this.m_Stack.Peek();
			}
			global::Gibraltar.ProgressMonitorEventArgs e = new global::Gibraltar.ProgressMonitorEventArgs(this, progressMonitor);
			global::System.EventHandler<global::Gibraltar.ProgressMonitorEventArgs> changed = this.Changed;
			if (changed != null)
			{
				changed(this, e);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00011A3C File Offset: 0x0000FC3C
		protected virtual void OnCompleted()
		{
			global::Gibraltar.ProgressMonitorStackEventArgs e = new global::Gibraltar.ProgressMonitorStackEventArgs(this, this.m_StatusMessage, this.m_CompletedSteps, this.m_MaximumSteps);
			global::System.EventHandler<global::Gibraltar.ProgressMonitorStackEventArgs> completed = this.Completed;
			if (completed != null)
			{
				completed(this, e);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00011A7C File Offset: 0x0000FC7C
		protected virtual void OnUpdated()
		{
			global::Gibraltar.ProgressMonitorStackEventArgs e = new global::Gibraltar.ProgressMonitorStackEventArgs(this, this.m_StatusMessage, this.m_CompletedSteps, this.m_MaximumSteps);
			global::System.EventHandler<global::Gibraltar.ProgressMonitorStackEventArgs> updated = this.Updated;
			if (updated != null)
			{
				updated(this, e);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00011ABC File Offset: 0x0000FCBC
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged && !this.m_ReadOnly)
			{
				this.Complete = true;
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		protected virtual void UpdateProgress()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			string text = string.Empty;
			int num;
			int num2;
			if (this.m_Stack.Count == 0)
			{
				text = this.m_Title;
				num = 0;
				num2 = 0;
			}
			else
			{
				foreach (global::Gibraltar.ProgressMonitor progressMonitor in this.m_Stack.ToArray())
				{
					if (!string.IsNullOrEmpty(progressMonitor.StatusMessage))
					{
						text = progressMonitor.StatusMessage;
						break;
					}
				}
				global::Gibraltar.ProgressMonitor[] array;
				if (array[array.Length - 1].MaxSteps == 0)
				{
					num = 0;
					num2 = 0;
				}
				else
				{
					int num3 = 0;
					int num4 = 100;
					for (int j = array.Length - 1; j >= 0; j--)
					{
						global::Gibraltar.ProgressMonitor progressMonitor2 = array[j];
						if (num4 == num3)
						{
							break;
						}
						if (progressMonitor2.MaxSteps != 0)
						{
							double num5 = (double)(num4 - num3) / (double)progressMonitor2.MaxSteps;
							num3 += (int)(num5 * (double)progressMonitor2.CompletedSteps);
							num4 = (int)((double)num3 + num5);
						}
					}
					num = num3;
					num2 = 100;
					if ((double)num / (double)num2 < (double)this.m_CompletedSteps / (double)this.m_MaximumSteps)
					{
						num = this.m_CompletedSteps;
						num2 = this.m_MaximumSteps;
					}
				}
			}
			if (this.m_StatusMessage != text || this.m_CompletedSteps != num || this.m_MaximumSteps != num2)
			{
				this.m_StatusMessage = text;
				this.m_CompletedSteps = num;
				this.m_MaximumSteps = num2;
				this.OnUpdated();
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00011C5C File Offset: 0x0000FE5C
		internal void PopMonitor(global::Gibraltar.ProgressMonitor progressMonitor)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Stack.Contains(progressMonitor))
				{
					global::Gibraltar.ProgressMonitor progressMonitor2 = this.m_Stack.Pop();
					progressMonitor2.Updated -= this.TopMonitor_MonitorUpdated;
					while (progressMonitor2 != progressMonitor)
					{
						progressMonitor2 = this.m_Stack.Pop();
					}
					if (this.m_Stack.Count == 0)
					{
						if (!this.m_ReadOnly && !this.m_Complete)
						{
							this.Complete = true;
						}
					}
					else
					{
						this.UpdateProgress();
						this.OnChanged();
						progressMonitor2 = this.m_Stack.Peek();
						progressMonitor2.Updated += this.TopMonitor_MonitorUpdated;
					}
				}
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00011D34 File Offset: 0x0000FF34
		internal void PushMonitor(global::Gibraltar.ProgressMonitor progressMonitor)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Stack.Count > 0)
				{
					this.m_Stack.Peek().Updated -= this.TopMonitor_MonitorUpdated;
				}
				this.m_Stack.Push(progressMonitor);
				this.UpdateProgress();
				this.OnChanged();
				this.m_Stack.Peek().Updated += this.TopMonitor_MonitorUpdated;
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00011DCC File Offset: 0x0000FFCC
		private void TopMonitor_MonitorUpdated(object sender, global::Gibraltar.ProgressMonitorEventArgs e)
		{
			this.UpdateProgress();
		}

		// Token: 0x040001C0 RID: 448
		public const int DefaultMaximumSteps = 100;

		// Token: 0x040001C1 RID: 449
		private readonly object m_Lock = new object();

		// Token: 0x040001C2 RID: 450
		private readonly global::System.Collections.Generic.Stack<global::Gibraltar.ProgressMonitor> m_Stack = new global::System.Collections.Generic.Stack<global::Gibraltar.ProgressMonitor>();

		// Token: 0x040001C3 RID: 451
		private readonly string m_Title;

		// Token: 0x040001C4 RID: 452
		private bool m_Complete;

		// Token: 0x040001C5 RID: 453
		private bool m_ReadOnly;

		// Token: 0x040001C6 RID: 454
		private string m_StatusMessage;

		// Token: 0x040001C7 RID: 455
		private int m_CompletedSteps;

		// Token: 0x040001C8 RID: 456
		private int m_MaximumSteps;

		// Token: 0x040001C9 RID: 457
		private bool m_Canceled;
	}
}
