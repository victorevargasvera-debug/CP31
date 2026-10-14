using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x02000075 RID: 117
	public class HeapProfilerClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00006DDC File Offset: 0x00004FDC
		public HeapProfilerClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600042F RID: 1071 RVA: 0x00006DEB File Offset: 0x00004FEB
		// (remove) Token: 0x06000430 RID: 1072 RVA: 0x00006DFE File Offset: 0x00004FFE
		public event global::System.EventHandler<global::CefSharp.DevTools.HeapProfiler.AddHeapSnapshotChunkEventArgs> AddHeapSnapshotChunk
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.HeapProfiler.AddHeapSnapshotChunkEventArgs>("HeapProfiler.addHeapSnapshotChunk", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.HeapProfiler.AddHeapSnapshotChunkEventArgs>("HeapProfiler.addHeapSnapshotChunk", value);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000431 RID: 1073 RVA: 0x00006E12 File Offset: 0x00005012
		// (remove) Token: 0x06000432 RID: 1074 RVA: 0x00006E25 File Offset: 0x00005025
		public event global::System.EventHandler<global::CefSharp.DevTools.HeapProfiler.HeapStatsUpdateEventArgs> HeapStatsUpdate
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.HeapProfiler.HeapStatsUpdateEventArgs>("HeapProfiler.heapStatsUpdate", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.HeapProfiler.HeapStatsUpdateEventArgs>("HeapProfiler.heapStatsUpdate", value);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000433 RID: 1075 RVA: 0x00006E39 File Offset: 0x00005039
		// (remove) Token: 0x06000434 RID: 1076 RVA: 0x00006E4C File Offset: 0x0000504C
		public event global::System.EventHandler<global::CefSharp.DevTools.HeapProfiler.LastSeenObjectIdEventArgs> LastSeenObjectId
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.HeapProfiler.LastSeenObjectIdEventArgs>("HeapProfiler.lastSeenObjectId", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.HeapProfiler.LastSeenObjectIdEventArgs>("HeapProfiler.lastSeenObjectId", value);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000435 RID: 1077 RVA: 0x00006E60 File Offset: 0x00005060
		// (remove) Token: 0x06000436 RID: 1078 RVA: 0x00006E73 File Offset: 0x00005073
		public event global::System.EventHandler<global::CefSharp.DevTools.HeapProfiler.ReportHeapSnapshotProgressEventArgs> ReportHeapSnapshotProgress
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.HeapProfiler.ReportHeapSnapshotProgressEventArgs>("HeapProfiler.reportHeapSnapshotProgress", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.HeapProfiler.ReportHeapSnapshotProgressEventArgs>("HeapProfiler.reportHeapSnapshotProgress", value);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000437 RID: 1079 RVA: 0x00006E87 File Offset: 0x00005087
		// (remove) Token: 0x06000438 RID: 1080 RVA: 0x00006E9A File Offset: 0x0000509A
		public event global::System.EventHandler<global::System.EventArgs> ResetProfiles
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("HeapProfiler.resetProfiles", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("HeapProfiler.resetProfiles", value);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00006EB0 File Offset: 0x000050B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> AddInspectedHeapObjectAsync(string heapObjectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("heapObjectId", heapObjectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.addInspectedHeapObject", dictionary);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00006EE0 File Offset: 0x000050E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CollectGarbageAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.collectGarbage", parameters);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00006F00 File Offset: 0x00005100
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.disable", parameters);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00006F20 File Offset: 0x00005120
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.enable", parameters);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00006F40 File Offset: 0x00005140
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.HeapProfiler.GetHeapObjectIdResponse> GetHeapObjectIdAsync(string objectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.HeapProfiler.GetHeapObjectIdResponse>("HeapProfiler.getHeapObjectId", dictionary);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00006F70 File Offset: 0x00005170
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.HeapProfiler.GetObjectByHeapObjectIdResponse> GetObjectByHeapObjectIdAsync(string objectId, string objectGroup = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			if (!string.IsNullOrEmpty(objectGroup))
			{
				dictionary.Add("objectGroup", objectGroup);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.HeapProfiler.GetObjectByHeapObjectIdResponse>("HeapProfiler.getObjectByHeapObjectId", dictionary);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00006FB4 File Offset: 0x000051B4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.HeapProfiler.GetSamplingProfileResponse> GetSamplingProfileAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.HeapProfiler.GetSamplingProfileResponse>("HeapProfiler.getSamplingProfile", parameters);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00006FD4 File Offset: 0x000051D4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartSamplingAsync(double? samplingInterval = null, bool? includeObjectsCollectedByMajorGC = null, bool? includeObjectsCollectedByMinorGC = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (samplingInterval != null)
			{
				dictionary.Add("samplingInterval", samplingInterval.Value);
			}
			if (includeObjectsCollectedByMajorGC != null)
			{
				dictionary.Add("includeObjectsCollectedByMajorGC", includeObjectsCollectedByMajorGC.Value);
			}
			if (includeObjectsCollectedByMinorGC != null)
			{
				dictionary.Add("includeObjectsCollectedByMinorGC", includeObjectsCollectedByMinorGC.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.startSampling", dictionary);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00007058 File Offset: 0x00005258
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartTrackingHeapObjectsAsync(bool? trackAllocations = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (trackAllocations != null)
			{
				dictionary.Add("trackAllocations", trackAllocations.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.startTrackingHeapObjects", dictionary);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000709C File Offset: 0x0000529C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.HeapProfiler.StopSamplingResponse> StopSamplingAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.HeapProfiler.StopSamplingResponse>("HeapProfiler.stopSampling", parameters);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000070BC File Offset: 0x000052BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopTrackingHeapObjectsAsync(bool? reportProgress = null, bool? treatGlobalObjectsAsRoots = null, bool? captureNumericValue = null, bool? exposeInternals = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (reportProgress != null)
			{
				dictionary.Add("reportProgress", reportProgress.Value);
			}
			if (treatGlobalObjectsAsRoots != null)
			{
				dictionary.Add("treatGlobalObjectsAsRoots", treatGlobalObjectsAsRoots.Value);
			}
			if (captureNumericValue != null)
			{
				dictionary.Add("captureNumericValue", captureNumericValue.Value);
			}
			if (exposeInternals != null)
			{
				dictionary.Add("exposeInternals", exposeInternals.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.stopTrackingHeapObjects", dictionary);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00007160 File Offset: 0x00005360
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TakeHeapSnapshotAsync(bool? reportProgress = null, bool? treatGlobalObjectsAsRoots = null, bool? captureNumericValue = null, bool? exposeInternals = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (reportProgress != null)
			{
				dictionary.Add("reportProgress", reportProgress.Value);
			}
			if (treatGlobalObjectsAsRoots != null)
			{
				dictionary.Add("treatGlobalObjectsAsRoots", treatGlobalObjectsAsRoots.Value);
			}
			if (captureNumericValue != null)
			{
				dictionary.Add("captureNumericValue", captureNumericValue.Value);
			}
			if (exposeInternals != null)
			{
				dictionary.Add("exposeInternals", exposeInternals.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("HeapProfiler.takeHeapSnapshot", dictionary);
		}

		// Token: 0x0400019B RID: 411
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
