using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200009A RID: 154
	public class DebuggerClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600055A RID: 1370 RVA: 0x00007BD5 File Offset: 0x00005DD5
		public DebuggerClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600055B RID: 1371 RVA: 0x00007BE4 File Offset: 0x00005DE4
		// (remove) Token: 0x0600055C RID: 1372 RVA: 0x00007BF7 File Offset: 0x00005DF7
		public event global::System.EventHandler<global::CefSharp.DevTools.Debugger.BreakpointResolvedEventArgs> BreakpointResolved
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Debugger.BreakpointResolvedEventArgs>("Debugger.breakpointResolved", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Debugger.BreakpointResolvedEventArgs>("Debugger.breakpointResolved", value);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600055D RID: 1373 RVA: 0x00007C0B File Offset: 0x00005E0B
		// (remove) Token: 0x0600055E RID: 1374 RVA: 0x00007C1E File Offset: 0x00005E1E
		public event global::System.EventHandler<global::CefSharp.DevTools.Debugger.PausedEventArgs> Paused
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Debugger.PausedEventArgs>("Debugger.paused", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Debugger.PausedEventArgs>("Debugger.paused", value);
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600055F RID: 1375 RVA: 0x00007C32 File Offset: 0x00005E32
		// (remove) Token: 0x06000560 RID: 1376 RVA: 0x00007C45 File Offset: 0x00005E45
		public event global::System.EventHandler<global::System.EventArgs> Resumed
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Debugger.resumed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Debugger.resumed", value);
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000561 RID: 1377 RVA: 0x00007C59 File Offset: 0x00005E59
		// (remove) Token: 0x06000562 RID: 1378 RVA: 0x00007C6C File Offset: 0x00005E6C
		public event global::System.EventHandler<global::CefSharp.DevTools.Debugger.ScriptFailedToParseEventArgs> ScriptFailedToParse
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Debugger.ScriptFailedToParseEventArgs>("Debugger.scriptFailedToParse", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Debugger.ScriptFailedToParseEventArgs>("Debugger.scriptFailedToParse", value);
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000563 RID: 1379 RVA: 0x00007C80 File Offset: 0x00005E80
		// (remove) Token: 0x06000564 RID: 1380 RVA: 0x00007C93 File Offset: 0x00005E93
		public event global::System.EventHandler<global::CefSharp.DevTools.Debugger.ScriptParsedEventArgs> ScriptParsed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Debugger.ScriptParsedEventArgs>("Debugger.scriptParsed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Debugger.ScriptParsedEventArgs>("Debugger.scriptParsed", value);
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00007CA8 File Offset: 0x00005EA8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ContinueToLocationAsync(global::CefSharp.DevTools.Debugger.Location location, global::CefSharp.DevTools.Debugger.ContinueToLocationTargetCallFrames? targetCallFrames = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("location", location.ToDictionary());
			if (targetCallFrames != null)
			{
				dictionary.Add("targetCallFrames", base.EnumToString(targetCallFrames));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.continueToLocation", dictionary);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00007D00 File Offset: 0x00005F00
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.disable", parameters);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00007D20 File Offset: 0x00005F20
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.EnableResponse> EnableAsync(double? maxScriptsCacheSize = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (maxScriptsCacheSize != null)
			{
				dictionary.Add("maxScriptsCacheSize", maxScriptsCacheSize.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.EnableResponse>("Debugger.enable", dictionary);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00007D64 File Offset: 0x00005F64
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.EvaluateOnCallFrameResponse> EvaluateOnCallFrameAsync(string callFrameId, string expression, string objectGroup = null, bool? includeCommandLineAPI = null, bool? silent = null, bool? returnByValue = null, bool? generatePreview = null, bool? throwOnSideEffect = null, double? timeout = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("callFrameId", callFrameId);
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
			if (returnByValue != null)
			{
				dictionary.Add("returnByValue", returnByValue.Value);
			}
			if (generatePreview != null)
			{
				dictionary.Add("generatePreview", generatePreview.Value);
			}
			if (throwOnSideEffect != null)
			{
				dictionary.Add("throwOnSideEffect", throwOnSideEffect.Value);
			}
			if (timeout != null)
			{
				dictionary.Add("timeout", timeout.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.EvaluateOnCallFrameResponse>("Debugger.evaluateOnCallFrame", dictionary);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00007E74 File Offset: 0x00006074
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.GetPossibleBreakpointsResponse> GetPossibleBreakpointsAsync(global::CefSharp.DevTools.Debugger.Location start, global::CefSharp.DevTools.Debugger.Location end = null, bool? restrictToFunction = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("start", start.ToDictionary());
			if (end != null)
			{
				dictionary.Add("end", end.ToDictionary());
			}
			if (restrictToFunction != null)
			{
				dictionary.Add("restrictToFunction", restrictToFunction.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.GetPossibleBreakpointsResponse>("Debugger.getPossibleBreakpoints", dictionary);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00007EE0 File Offset: 0x000060E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.GetScriptSourceResponse> GetScriptSourceAsync(string scriptId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scriptId", scriptId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.GetScriptSourceResponse>("Debugger.getScriptSource", dictionary);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00007F10 File Offset: 0x00006110
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.DisassembleWasmModuleResponse> DisassembleWasmModuleAsync(string scriptId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scriptId", scriptId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.DisassembleWasmModuleResponse>("Debugger.disassembleWasmModule", dictionary);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00007F40 File Offset: 0x00006140
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.NextWasmDisassemblyChunkResponse> NextWasmDisassemblyChunkAsync(string streamId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("streamId", streamId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.NextWasmDisassemblyChunkResponse>("Debugger.nextWasmDisassemblyChunk", dictionary);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00007F70 File Offset: 0x00006170
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.GetStackTraceResponse> GetStackTraceAsync(global::CefSharp.DevTools.Runtime.StackTraceId stackTraceId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("stackTraceId", stackTraceId.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.GetStackTraceResponse>("Debugger.getStackTrace", dictionary);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00007FA8 File Offset: 0x000061A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> PauseAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.pause", parameters);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00007FC8 File Offset: 0x000061C8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveBreakpointAsync(string breakpointId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("breakpointId", breakpointId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.removeBreakpoint", dictionary);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00007FF8 File Offset: 0x000061F8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.RestartFrameResponse> RestartFrameAsync(string callFrameId, global::CefSharp.DevTools.Debugger.RestartFrameMode? mode = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("callFrameId", callFrameId);
			if (mode != null)
			{
				dictionary.Add("mode", base.EnumToString(mode));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.RestartFrameResponse>("Debugger.restartFrame", dictionary);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00008048 File Offset: 0x00006248
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ResumeAsync(bool? terminateOnResume = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (terminateOnResume != null)
			{
				dictionary.Add("terminateOnResume", terminateOnResume.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.resume", dictionary);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000808C File Offset: 0x0000628C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.SearchInContentResponse> SearchInContentAsync(string scriptId, string query, bool? caseSensitive = null, bool? isRegex = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scriptId", scriptId);
			dictionary.Add("query", query);
			if (caseSensitive != null)
			{
				dictionary.Add("caseSensitive", caseSensitive.Value);
			}
			if (isRegex != null)
			{
				dictionary.Add("isRegex", isRegex.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.SearchInContentResponse>("Debugger.searchInContent", dictionary);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00008108 File Offset: 0x00006308
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAsyncCallStackDepthAsync(int maxDepth)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("maxDepth", maxDepth);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setAsyncCallStackDepth", dictionary);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00008140 File Offset: 0x00006340
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBlackboxPatternsAsync(string[] patterns)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("patterns", patterns);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setBlackboxPatterns", dictionary);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00008170 File Offset: 0x00006370
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBlackboxedRangesAsync(string scriptId, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.ScriptPosition> positions)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scriptId", scriptId);
			dictionary.Add("positions", from x in positions
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setBlackboxedRanges", dictionary);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000081D0 File Offset: 0x000063D0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.SetBreakpointResponse> SetBreakpointAsync(global::CefSharp.DevTools.Debugger.Location location, string condition = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("location", location.ToDictionary());
			if (!string.IsNullOrEmpty(condition))
			{
				dictionary.Add("condition", condition);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.SetBreakpointResponse>("Debugger.setBreakpoint", dictionary);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000821C File Offset: 0x0000641C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.SetInstrumentationBreakpointResponse> SetInstrumentationBreakpointAsync(global::CefSharp.DevTools.Debugger.SetInstrumentationBreakpointInstrumentation instrumentation)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("instrumentation", base.EnumToString(instrumentation));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.SetInstrumentationBreakpointResponse>("Debugger.setInstrumentationBreakpoint", dictionary);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00008258 File Offset: 0x00006458
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.SetBreakpointByUrlResponse> SetBreakpointByUrlAsync(int lineNumber, string url = null, string urlRegex = null, string scriptHash = null, int? columnNumber = null, string condition = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("lineNumber", lineNumber);
			if (!string.IsNullOrEmpty(url))
			{
				dictionary.Add("url", url);
			}
			if (!string.IsNullOrEmpty(urlRegex))
			{
				dictionary.Add("urlRegex", urlRegex);
			}
			if (!string.IsNullOrEmpty(scriptHash))
			{
				dictionary.Add("scriptHash", scriptHash);
			}
			if (columnNumber != null)
			{
				dictionary.Add("columnNumber", columnNumber.Value);
			}
			if (!string.IsNullOrEmpty(condition))
			{
				dictionary.Add("condition", condition);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.SetBreakpointByUrlResponse>("Debugger.setBreakpointByUrl", dictionary);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00008304 File Offset: 0x00006504
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.SetBreakpointOnFunctionCallResponse> SetBreakpointOnFunctionCallAsync(string objectId, string condition = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			if (!string.IsNullOrEmpty(condition))
			{
				dictionary.Add("condition", condition);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.SetBreakpointOnFunctionCallResponse>("Debugger.setBreakpointOnFunctionCall", dictionary);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00008348 File Offset: 0x00006548
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBreakpointsActiveAsync(bool active)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("active", active);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setBreakpointsActive", dictionary);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00008380 File Offset: 0x00006580
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPauseOnExceptionsAsync(global::CefSharp.DevTools.Debugger.SetPauseOnExceptionsState state)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("state", base.EnumToString(state));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setPauseOnExceptions", dictionary);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000083BC File Offset: 0x000065BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetReturnValueAsync(global::CefSharp.DevTools.Runtime.CallArgument newValue)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("newValue", newValue.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setReturnValue", dictionary);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000083F4 File Offset: 0x000065F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Debugger.SetScriptSourceResponse> SetScriptSourceAsync(string scriptId, string scriptSource, bool? dryRun = null, bool? allowTopFrameEditing = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scriptId", scriptId);
			dictionary.Add("scriptSource", scriptSource);
			if (dryRun != null)
			{
				dictionary.Add("dryRun", dryRun.Value);
			}
			if (allowTopFrameEditing != null)
			{
				dictionary.Add("allowTopFrameEditing", allowTopFrameEditing.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Debugger.SetScriptSourceResponse>("Debugger.setScriptSource", dictionary);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00008470 File Offset: 0x00006670
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetSkipAllPausesAsync(bool skip)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("skip", skip);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setSkipAllPauses", dictionary);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000084A8 File Offset: 0x000066A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetVariableValueAsync(int scopeNumber, string variableName, global::CefSharp.DevTools.Runtime.CallArgument newValue, string callFrameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scopeNumber", scopeNumber);
			dictionary.Add("variableName", variableName);
			dictionary.Add("newValue", newValue.ToDictionary());
			dictionary.Add("callFrameId", callFrameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.setVariableValue", dictionary);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00008508 File Offset: 0x00006708
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StepIntoAsync(bool? breakOnAsyncCall = null, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.LocationRange> skipList = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (breakOnAsyncCall != null)
			{
				dictionary.Add("breakOnAsyncCall", breakOnAsyncCall.Value);
			}
			if (skipList != null)
			{
				dictionary.Add("skipList", from x in skipList
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.stepInto", dictionary);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00008580 File Offset: 0x00006780
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StepOutAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.stepOut", parameters);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000085A0 File Offset: 0x000067A0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StepOverAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.LocationRange> skipList = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (skipList != null)
			{
				dictionary.Add("skipList", from x in skipList
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Debugger.stepOver", dictionary);
		}

		// Token: 0x04000237 RID: 567
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
