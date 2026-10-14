using System;
using System.Diagnostics;
using System.Threading;

namespace Gibraltar
{
	// Token: 0x020000AC RID: 172
	internal class AsynchronousTask
	{
		// Token: 0x06000719 RID: 1817 RVA: 0x0000CE48 File Offset: 0x0000B048
		public void Execute(global::System.Threading.WaitCallback callBack, string title, object state)
		{
			global::Gibraltar.AsyncTaskArguments asyncTaskArguments = new global::Gibraltar.AsyncTaskArguments(title, state);
			this.m_ProgressMonitors = asyncTaskArguments.ProgressMonitors;
			this.m_ProgressMonitors.Canceled += this.Monitors_Canceled;
			this.m_ProgressMonitors.Completed += this.Monitors_Completed;
			global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncTaskExec), new object[]
			{
				callBack,
				asyncTaskArguments
			});
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
		public bool Canceled { get; private set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000CED8 File Offset: 0x0000B0D8
		public bool Completed { get; private set; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		public global::Gibraltar.AsyncTaskResultEventArgs TaskResults { get; private set; }

		// Token: 0x06000720 RID: 1824 RVA: 0x0000CEF8 File Offset: 0x0000B0F8
		private void AsyncTaskExec(object stateInfo)
		{
			try
			{
				object[] array = (object[])stateInfo;
				global::System.Threading.WaitCallback waitCallback = (global::System.Threading.WaitCallback)array[0];
				global::Gibraltar.AsyncTaskArguments asyncTaskArguments = (global::Gibraltar.AsyncTaskArguments)array[1];
				if (waitCallback == null || asyncTaskArguments == null)
				{
					global::System.Diagnostics.Trace.TraceError("Unable to execute progress dialog task because one of the arguments is null.  This represents an implementation defect.");
				}
				else
				{
					waitCallback(asyncTaskArguments);
					this.CompleteProgress();
					this.TaskResults = asyncTaskArguments.TaskResult;
				}
			}
			catch (global::System.Exception ex)
			{
				try
				{
					this.TaskResults = new global::Gibraltar.AsyncTaskResultEventArgs(global::Gibraltar.AsyncTaskResult.Error, ex.Message, ex);
					this.CancelProgress();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000CF9C File Offset: 0x0000B19C
		private void CancelProgress()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			this.Canceled = true;
			this.m_ReadOnly = true;
			this.Completed = true;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		private void CompleteProgress()
		{
			if (this.m_ReadOnly)
			{
				return;
			}
			this.m_ReadOnly = true;
			this.Completed = true;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		private void Monitors_Canceled(object sender, global::Gibraltar.ProgressMonitorStackEventArgs e)
		{
			this.CancelProgress();
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000CFE4 File Offset: 0x0000B1E4
		private void Monitors_Completed(object sender, global::Gibraltar.ProgressMonitorStackEventArgs e)
		{
			this.CompleteProgress();
		}

		// Token: 0x04000143 RID: 323
		private global::Gibraltar.ProgressMonitorStack m_ProgressMonitors;

		// Token: 0x04000144 RID: 324
		private bool m_ReadOnly;
	}
}
