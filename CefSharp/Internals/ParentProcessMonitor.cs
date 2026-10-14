using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000ED RID: 237
	public static class ParentProcessMonitor
	{
		// Token: 0x06000724 RID: 1828 RVA: 0x0000B820 File Offset: 0x00009A20
		public static void StartMonitorTask(int parentProcessId)
		{
			global::System.Threading.Tasks.Task.Factory.StartNew(delegate()
			{
				global::CefSharp.Internals.ParentProcessMonitor.AwaitParentProcessExit(parentProcessId);
			}, global::System.Threading.Tasks.TaskCreationOptions.LongRunning);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000B854 File Offset: 0x00009A54
		private static void AwaitParentProcessExit(int parentProcessId)
		{
			global::CefSharp.Internals.ParentProcessMonitor.<AwaitParentProcessExit>d__1 <AwaitParentProcessExit>d__;
			<AwaitParentProcessExit>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
			<AwaitParentProcessExit>d__.parentProcessId = parentProcessId;
			<AwaitParentProcessExit>d__.<>1__state = -1;
			<AwaitParentProcessExit>d__.<>t__builder.Start<global::CefSharp.Internals.ParentProcessMonitor.<AwaitParentProcessExit>d__1>(ref <AwaitParentProcessExit>d__);
		}
	}
}
