using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000069 RID: 105
	public class ProfilerClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x000069ED File Offset: 0x00004BED
		public ProfilerClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060003E8 RID: 1000 RVA: 0x000069FC File Offset: 0x00004BFC
		// (remove) Token: 0x060003E9 RID: 1001 RVA: 0x00006A0F File Offset: 0x00004C0F
		public event global::System.EventHandler<global::CefSharp.DevTools.Profiler.ConsoleProfileFinishedEventArgs> ConsoleProfileFinished
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Profiler.ConsoleProfileFinishedEventArgs>("Profiler.consoleProfileFinished", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Profiler.ConsoleProfileFinishedEventArgs>("Profiler.consoleProfileFinished", value);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060003EA RID: 1002 RVA: 0x00006A23 File Offset: 0x00004C23
		// (remove) Token: 0x060003EB RID: 1003 RVA: 0x00006A36 File Offset: 0x00004C36
		public event global::System.EventHandler<global::CefSharp.DevTools.Profiler.ConsoleProfileStartedEventArgs> ConsoleProfileStarted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Profiler.ConsoleProfileStartedEventArgs>("Profiler.consoleProfileStarted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Profiler.ConsoleProfileStartedEventArgs>("Profiler.consoleProfileStarted", value);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060003EC RID: 1004 RVA: 0x00006A4A File Offset: 0x00004C4A
		// (remove) Token: 0x060003ED RID: 1005 RVA: 0x00006A5D File Offset: 0x00004C5D
		public event global::System.EventHandler<global::CefSharp.DevTools.Profiler.PreciseCoverageDeltaUpdateEventArgs> PreciseCoverageDeltaUpdate
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Profiler.PreciseCoverageDeltaUpdateEventArgs>("Profiler.preciseCoverageDeltaUpdate", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Profiler.PreciseCoverageDeltaUpdateEventArgs>("Profiler.preciseCoverageDeltaUpdate", value);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00006A74 File Offset: 0x00004C74
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Profiler.disable", parameters);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00006A94 File Offset: 0x00004C94
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Profiler.enable", parameters);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Profiler.GetBestEffortCoverageResponse> GetBestEffortCoverageAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Profiler.GetBestEffortCoverageResponse>("Profiler.getBestEffortCoverage", parameters);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00006AD4 File Offset: 0x00004CD4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetSamplingIntervalAsync(int interval)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("interval", interval);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Profiler.setSamplingInterval", dictionary);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00006B0C File Offset: 0x00004D0C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Profiler.start", parameters);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00006B2C File Offset: 0x00004D2C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Profiler.StartPreciseCoverageResponse> StartPreciseCoverageAsync(bool? callCount = null, bool? detailed = null, bool? allowTriggeredUpdates = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (callCount != null)
			{
				dictionary.Add("callCount", callCount.Value);
			}
			if (detailed != null)
			{
				dictionary.Add("detailed", detailed.Value);
			}
			if (allowTriggeredUpdates != null)
			{
				dictionary.Add("allowTriggeredUpdates", allowTriggeredUpdates.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Profiler.StartPreciseCoverageResponse>("Profiler.startPreciseCoverage", dictionary);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Profiler.StopResponse> StopAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Profiler.StopResponse>("Profiler.stop", parameters);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00006BD0 File Offset: 0x00004DD0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopPreciseCoverageAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Profiler.stopPreciseCoverage", parameters);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00006BF0 File Offset: 0x00004DF0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Profiler.TakePreciseCoverageResponse> TakePreciseCoverageAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Profiler.TakePreciseCoverageResponse>("Profiler.takePreciseCoverage", parameters);
		}

		// Token: 0x04000186 RID: 390
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
