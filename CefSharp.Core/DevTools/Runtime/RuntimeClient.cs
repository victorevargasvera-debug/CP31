using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200005B RID: 91
	public class RuntimeClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000363 RID: 867 RVA: 0x00005C38 File Offset: 0x00003E38
		public RuntimeClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000364 RID: 868 RVA: 0x00005C47 File Offset: 0x00003E47
		// (remove) Token: 0x06000365 RID: 869 RVA: 0x00005C5A File Offset: 0x00003E5A
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.BindingCalledEventArgs> BindingCalled
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.BindingCalledEventArgs>("Runtime.bindingCalled", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.BindingCalledEventArgs>("Runtime.bindingCalled", value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000366 RID: 870 RVA: 0x00005C6E File Offset: 0x00003E6E
		// (remove) Token: 0x06000367 RID: 871 RVA: 0x00005C81 File Offset: 0x00003E81
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.ConsoleAPICalledEventArgs> ConsoleAPICalled
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.ConsoleAPICalledEventArgs>("Runtime.consoleAPICalled", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.ConsoleAPICalledEventArgs>("Runtime.consoleAPICalled", value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000368 RID: 872 RVA: 0x00005C95 File Offset: 0x00003E95
		// (remove) Token: 0x06000369 RID: 873 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.ExceptionRevokedEventArgs> ExceptionRevoked
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.ExceptionRevokedEventArgs>("Runtime.exceptionRevoked", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.ExceptionRevokedEventArgs>("Runtime.exceptionRevoked", value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600036A RID: 874 RVA: 0x00005CBC File Offset: 0x00003EBC
		// (remove) Token: 0x0600036B RID: 875 RVA: 0x00005CCF File Offset: 0x00003ECF
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.ExceptionThrownEventArgs> ExceptionThrown
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.ExceptionThrownEventArgs>("Runtime.exceptionThrown", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.ExceptionThrownEventArgs>("Runtime.exceptionThrown", value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600036C RID: 876 RVA: 0x00005CE3 File Offset: 0x00003EE3
		// (remove) Token: 0x0600036D RID: 877 RVA: 0x00005CF6 File Offset: 0x00003EF6
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.ExecutionContextCreatedEventArgs> ExecutionContextCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.ExecutionContextCreatedEventArgs>("Runtime.executionContextCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.ExecutionContextCreatedEventArgs>("Runtime.executionContextCreated", value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600036E RID: 878 RVA: 0x00005D0A File Offset: 0x00003F0A
		// (remove) Token: 0x0600036F RID: 879 RVA: 0x00005D1D File Offset: 0x00003F1D
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.ExecutionContextDestroyedEventArgs> ExecutionContextDestroyed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.ExecutionContextDestroyedEventArgs>("Runtime.executionContextDestroyed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.ExecutionContextDestroyedEventArgs>("Runtime.executionContextDestroyed", value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000370 RID: 880 RVA: 0x00005D31 File Offset: 0x00003F31
		// (remove) Token: 0x06000371 RID: 881 RVA: 0x00005D44 File Offset: 0x00003F44
		public event global::System.EventHandler<global::System.EventArgs> ExecutionContextsCleared
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Runtime.executionContextsCleared", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Runtime.executionContextsCleared", value);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000372 RID: 882 RVA: 0x00005D58 File Offset: 0x00003F58
		// (remove) Token: 0x06000373 RID: 883 RVA: 0x00005D6B File Offset: 0x00003F6B
		public event global::System.EventHandler<global::CefSharp.DevTools.Runtime.InspectRequestedEventArgs> InspectRequested
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Runtime.InspectRequestedEventArgs>("Runtime.inspectRequested", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Runtime.InspectRequestedEventArgs>("Runtime.inspectRequested", value);
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00005D80 File Offset: 0x00003F80
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.AwaitPromiseResponse> AwaitPromiseAsync(string promiseObjectId, bool? returnByValue = null, bool? generatePreview = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("promiseObjectId", promiseObjectId);
			if (returnByValue != null)
			{
				dictionary.Add("returnByValue", returnByValue.Value);
			}
			if (generatePreview != null)
			{
				dictionary.Add("generatePreview", generatePreview.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.AwaitPromiseResponse>("Runtime.awaitPromise", dictionary);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00005DF0 File Offset: 0x00003FF0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.CallFunctionOnResponse> CallFunctionOnAsync(string functionDeclaration, string objectId = null, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.CallArgument> arguments = null, bool? silent = null, bool? returnByValue = null, bool? generatePreview = null, bool? userGesture = null, bool? awaitPromise = null, int? executionContextId = null, string objectGroup = null, bool? throwOnSideEffect = null, string uniqueContextId = null, bool? generateWebDriverValue = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("functionDeclaration", functionDeclaration);
			if (!string.IsNullOrEmpty(objectId))
			{
				dictionary.Add("objectId", objectId);
			}
			if (arguments != null)
			{
				dictionary.Add("arguments", from x in arguments
				select x.ToDictionary());
			}
			if (silent != null)
			{
				dictionary.Add("silent", silent.Value);
			}
			if (returnByValue != null)
			{
				dictionary.Add("returnByValue", returnByValue.Value);
			}
			if (generatePreview != null)
			{
				dictionary.Add("generatePreview", generatePreview.Value);
			}
			if (userGesture != null)
			{
				dictionary.Add("userGesture", userGesture.Value);
			}
			if (awaitPromise != null)
			{
				dictionary.Add("awaitPromise", awaitPromise.Value);
			}
			if (executionContextId != null)
			{
				dictionary.Add("executionContextId", executionContextId.Value);
			}
			if (!string.IsNullOrEmpty(objectGroup))
			{
				dictionary.Add("objectGroup", objectGroup);
			}
			if (throwOnSideEffect != null)
			{
				dictionary.Add("throwOnSideEffect", throwOnSideEffect.Value);
			}
			if (!string.IsNullOrEmpty(uniqueContextId))
			{
				dictionary.Add("uniqueContextId", uniqueContextId);
			}
			if (generateWebDriverValue != null)
			{
				dictionary.Add("generateWebDriverValue", generateWebDriverValue.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.CallFunctionOnResponse>("Runtime.callFunctionOn", dictionary);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00005F94 File Offset: 0x00004194
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.CompileScriptResponse> CompileScriptAsync(string expression, string sourceURL, bool persistScript, int? executionContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("expression", expression);
			dictionary.Add("sourceURL", sourceURL);
			dictionary.Add("persistScript", persistScript);
			if (executionContextId != null)
			{
				dictionary.Add("executionContextId", executionContextId.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.CompileScriptResponse>("Runtime.compileScript", dictionary);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00006004 File Offset: 0x00004204
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.disable", parameters);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00006024 File Offset: 0x00004224
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DiscardConsoleEntriesAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.discardConsoleEntries", parameters);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00006044 File Offset: 0x00004244
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.enable", parameters);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00006064 File Offset: 0x00004264
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.EvaluateResponse> EvaluateAsync(string expression, string objectGroup = null, bool? includeCommandLineAPI = null, bool? silent = null, int? contextId = null, bool? returnByValue = null, bool? generatePreview = null, bool? userGesture = null, bool? awaitPromise = null, bool? throwOnSideEffect = null, double? timeout = null, bool? disableBreaks = null, bool? replMode = null, bool? allowUnsafeEvalBlockedByCSP = null, string uniqueContextId = null, bool? generateWebDriverValue = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("expression", expression);
			if (!string.IsNullOrEmpty(objectGroup))
			{
				dictionary.Add("objectGroup", objectGroup);
			}
			if (includeCommandLineAPI != null)
			{
				dictionary.Add("includeCommandLineAPI", includeCommandLineAPI.Value);
			}
			if (silent != null)
			{
				dictionary.Add("silent", silent.Value);
			}
			if (contextId != null)
			{
				dictionary.Add("contextId", contextId.Value);
			}
			if (returnByValue != null)
			{
				dictionary.Add("returnByValue", returnByValue.Value);
			}
			if (generatePreview != null)
			{
				dictionary.Add("generatePreview", generatePreview.Value);
			}
			if (userGesture != null)
			{
				dictionary.Add("userGesture", userGesture.Value);
			}
			if (awaitPromise != null)
			{
				dictionary.Add("awaitPromise", awaitPromise.Value);
			}
			if (throwOnSideEffect != null)
			{
				dictionary.Add("throwOnSideEffect", throwOnSideEffect.Value);
			}
			if (timeout != null)
			{
				dictionary.Add("timeout", timeout.Value);
			}
			if (disableBreaks != null)
			{
				dictionary.Add("disableBreaks", disableBreaks.Value);
			}
			if (replMode != null)
			{
				dictionary.Add("replMode", replMode.Value);
			}
			if (allowUnsafeEvalBlockedByCSP != null)
			{
				dictionary.Add("allowUnsafeEvalBlockedByCSP", allowUnsafeEvalBlockedByCSP.Value);
			}
			if (!string.IsNullOrEmpty(uniqueContextId))
			{
				dictionary.Add("uniqueContextId", uniqueContextId);
			}
			if (generateWebDriverValue != null)
			{
				dictionary.Add("generateWebDriverValue", generateWebDriverValue.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.EvaluateResponse>("Runtime.evaluate", dictionary);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00006260 File Offset: 0x00004460
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.GetIsolateIdResponse> GetIsolateIdAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.GetIsolateIdResponse>("Runtime.getIsolateId", parameters);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00006280 File Offset: 0x00004480
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.GetHeapUsageResponse> GetHeapUsageAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.GetHeapUsageResponse>("Runtime.getHeapUsage", parameters);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000062A0 File Offset: 0x000044A0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.GetPropertiesResponse> GetPropertiesAsync(string objectId, bool? ownProperties = null, bool? accessorPropertiesOnly = null, bool? generatePreview = null, bool? nonIndexedPropertiesOnly = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			if (ownProperties != null)
			{
				dictionary.Add("ownProperties", ownProperties.Value);
			}
			if (accessorPropertiesOnly != null)
			{
				dictionary.Add("accessorPropertiesOnly", accessorPropertiesOnly.Value);
			}
			if (generatePreview != null)
			{
				dictionary.Add("generatePreview", generatePreview.Value);
			}
			if (nonIndexedPropertiesOnly != null)
			{
				dictionary.Add("nonIndexedPropertiesOnly", nonIndexedPropertiesOnly.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.GetPropertiesResponse>("Runtime.getProperties", dictionary);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00006350 File Offset: 0x00004550
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.GlobalLexicalScopeNamesResponse> GlobalLexicalScopeNamesAsync(int? executionContextId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (executionContextId != null)
			{
				dictionary.Add("executionContextId", executionContextId.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.GlobalLexicalScopeNamesResponse>("Runtime.globalLexicalScopeNames", dictionary);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00006394 File Offset: 0x00004594
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.QueryObjectsResponse> QueryObjectsAsync(string prototypeObjectId, string objectGroup = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("prototypeObjectId", prototypeObjectId);
			if (!string.IsNullOrEmpty(objectGroup))
			{
				dictionary.Add("objectGroup", objectGroup);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.QueryObjectsResponse>("Runtime.queryObjects", dictionary);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000063D8 File Offset: 0x000045D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ReleaseObjectAsync(string objectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.releaseObject", dictionary);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00006408 File Offset: 0x00004608
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ReleaseObjectGroupAsync(string objectGroup)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectGroup", objectGroup);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.releaseObjectGroup", dictionary);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00006438 File Offset: 0x00004638
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RunIfWaitingForDebuggerAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.runIfWaitingForDebugger", parameters);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00006458 File Offset: 0x00004658
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.RunScriptResponse> RunScriptAsync(string scriptId, int? executionContextId = null, string objectGroup = null, bool? silent = null, bool? includeCommandLineAPI = null, bool? returnByValue = null, bool? generatePreview = null, bool? awaitPromise = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scriptId", scriptId);
			if (executionContextId != null)
			{
				dictionary.Add("executionContextId", executionContextId.Value);
			}
			if (!string.IsNullOrEmpty(objectGroup))
			{
				dictionary.Add("objectGroup", objectGroup);
			}
			if (silent != null)
			{
				dictionary.Add("silent", silent.Value);
			}
			if (includeCommandLineAPI != null)
			{
				dictionary.Add("includeCommandLineAPI", includeCommandLineAPI.Value);
			}
			if (returnByValue != null)
			{
				dictionary.Add("returnByValue", returnByValue.Value);
			}
			if (generatePreview != null)
			{
				dictionary.Add("generatePreview", generatePreview.Value);
			}
			if (awaitPromise != null)
			{
				dictionary.Add("awaitPromise", awaitPromise.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.RunScriptResponse>("Runtime.runScript", dictionary);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000655C File Offset: 0x0000475C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAsyncCallStackDepthAsync(int maxDepth)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("maxDepth", maxDepth);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.setAsyncCallStackDepth", dictionary);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00006594 File Offset: 0x00004794
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetCustomObjectFormatterEnabledAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.setCustomObjectFormatterEnabled", dictionary);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000065CC File Offset: 0x000047CC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetMaxCallStackSizeToCaptureAsync(int size)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("size", size);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.setMaxCallStackSizeToCapture", dictionary);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00006604 File Offset: 0x00004804
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> TerminateExecutionAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.terminateExecution", parameters);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00006624 File Offset: 0x00004824
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> AddBindingAsync(string name, int? executionContextId = null, string executionContextName = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("name", name);
			if (executionContextId != null)
			{
				dictionary.Add("executionContextId", executionContextId.Value);
			}
			if (!string.IsNullOrEmpty(executionContextName))
			{
				dictionary.Add("executionContextName", executionContextName);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.addBinding", dictionary);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00006688 File Offset: 0x00004888
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveBindingAsync(string name)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("name", name);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Runtime.removeBinding", dictionary);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000066B8 File Offset: 0x000048B8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Runtime.GetExceptionDetailsResponse> GetExceptionDetailsAsync(string errorObjectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("errorObjectId", errorObjectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Runtime.GetExceptionDetailsResponse>("Runtime.getExceptionDetails", dictionary);
		}

		// Token: 0x04000160 RID: 352
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
