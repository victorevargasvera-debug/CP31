using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Input
{
	// Token: 0x02000270 RID: 624
	public class InputClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x000148C3 File Offset: 0x00012AC3
		public InputClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x0600130E RID: 4878 RVA: 0x000148D2 File Offset: 0x00012AD2
		// (remove) Token: 0x0600130F RID: 4879 RVA: 0x000148E5 File Offset: 0x00012AE5
		public event global::System.EventHandler<global::CefSharp.DevTools.Input.DragInterceptedEventArgs> DragIntercepted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Input.DragInterceptedEventArgs>("Input.dragIntercepted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Input.DragInterceptedEventArgs>("Input.dragIntercepted", value);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000148FC File Offset: 0x00012AFC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DispatchDragEventAsync(global::CefSharp.DevTools.Input.DispatchDragEventType type, double x, double y, global::CefSharp.DevTools.Input.DragData data, int? modifiers = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("type", base.EnumToString(type));
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			dictionary.Add("data", data.ToDictionary());
			if (modifiers != null)
			{
				dictionary.Add("modifiers", modifiers.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.dispatchDragEvent", dictionary);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0001498C File Offset: 0x00012B8C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DispatchKeyEventAsync(global::CefSharp.DevTools.Input.DispatchKeyEventType type, int? modifiers = null, double? timestamp = null, string text = null, string unmodifiedText = null, string keyIdentifier = null, string code = null, string key = null, int? windowsVirtualKeyCode = null, int? nativeVirtualKeyCode = null, bool? autoRepeat = null, bool? isKeypad = null, bool? isSystemKey = null, int? location = null, string[] commands = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("type", base.EnumToString(type));
			if (modifiers != null)
			{
				dictionary.Add("modifiers", modifiers.Value);
			}
			if (timestamp != null)
			{
				dictionary.Add("timestamp", timestamp.Value);
			}
			if (!string.IsNullOrEmpty(text))
			{
				dictionary.Add("text", text);
			}
			if (!string.IsNullOrEmpty(unmodifiedText))
			{
				dictionary.Add("unmodifiedText", unmodifiedText);
			}
			if (!string.IsNullOrEmpty(keyIdentifier))
			{
				dictionary.Add("keyIdentifier", keyIdentifier);
			}
			if (!string.IsNullOrEmpty(code))
			{
				dictionary.Add("code", code);
			}
			if (!string.IsNullOrEmpty(key))
			{
				dictionary.Add("key", key);
			}
			if (windowsVirtualKeyCode != null)
			{
				dictionary.Add("windowsVirtualKeyCode", windowsVirtualKeyCode.Value);
			}
			if (nativeVirtualKeyCode != null)
			{
				dictionary.Add("nativeVirtualKeyCode", nativeVirtualKeyCode.Value);
			}
			if (autoRepeat != null)
			{
				dictionary.Add("autoRepeat", autoRepeat.Value);
			}
			if (isKeypad != null)
			{
				dictionary.Add("isKeypad", isKeypad.Value);
			}
			if (isSystemKey != null)
			{
				dictionary.Add("isSystemKey", isSystemKey.Value);
			}
			if (location != null)
			{
				dictionary.Add("location", location.Value);
			}
			if (commands != null)
			{
				dictionary.Add("commands", commands);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.dispatchKeyEvent", dictionary);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00014B48 File Offset: 0x00012D48
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> InsertTextAsync(string text)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("text", text);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.insertText", dictionary);
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00014B78 File Offset: 0x00012D78
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ImeSetCompositionAsync(string text, int selectionStart, int selectionEnd, int? replacementStart = null, int? replacementEnd = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("text", text);
			dictionary.Add("selectionStart", selectionStart);
			dictionary.Add("selectionEnd", selectionEnd);
			if (replacementStart != null)
			{
				dictionary.Add("replacementStart", replacementStart.Value);
			}
			if (replacementEnd != null)
			{
				dictionary.Add("replacementEnd", replacementEnd.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.imeSetComposition", dictionary);
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00014C0C File Offset: 0x00012E0C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DispatchMouseEventAsync(global::CefSharp.DevTools.Input.DispatchMouseEventType type, double x, double y, int? modifiers = null, double? timestamp = null, global::CefSharp.DevTools.Input.MouseButton? button = null, int? buttons = null, int? clickCount = null, double? force = null, double? tangentialPressure = null, int? tiltX = null, int? tiltY = null, int? twist = null, double? deltaX = null, double? deltaY = null, global::CefSharp.DevTools.Input.DispatchMouseEventPointerType? pointerType = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("type", base.EnumToString(type));
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			if (modifiers != null)
			{
				dictionary.Add("modifiers", modifiers.Value);
			}
			if (timestamp != null)
			{
				dictionary.Add("timestamp", timestamp.Value);
			}
			if (button != null)
			{
				dictionary.Add("button", base.EnumToString(button));
			}
			if (buttons != null)
			{
				dictionary.Add("buttons", buttons.Value);
			}
			if (clickCount != null)
			{
				dictionary.Add("clickCount", clickCount.Value);
			}
			if (force != null)
			{
				dictionary.Add("force", force.Value);
			}
			if (tangentialPressure != null)
			{
				dictionary.Add("tangentialPressure", tangentialPressure.Value);
			}
			if (tiltX != null)
			{
				dictionary.Add("tiltX", tiltX.Value);
			}
			if (tiltY != null)
			{
				dictionary.Add("tiltY", tiltY.Value);
			}
			if (twist != null)
			{
				dictionary.Add("twist", twist.Value);
			}
			if (deltaX != null)
			{
				dictionary.Add("deltaX", deltaX.Value);
			}
			if (deltaY != null)
			{
				dictionary.Add("deltaY", deltaY.Value);
			}
			if (pointerType != null)
			{
				dictionary.Add("pointerType", base.EnumToString(pointerType));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.dispatchMouseEvent", dictionary);
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00014E0C File Offset: 0x0001300C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DispatchTouchEventAsync(global::CefSharp.DevTools.Input.DispatchTouchEventType type, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Input.TouchPoint> touchPoints, int? modifiers = null, double? timestamp = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("type", base.EnumToString(type));
			dictionary.Add("touchPoints", from x in touchPoints
			select x.ToDictionary());
			if (modifiers != null)
			{
				dictionary.Add("modifiers", modifiers.Value);
			}
			if (timestamp != null)
			{
				dictionary.Add("timestamp", timestamp.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.dispatchTouchEvent", dictionary);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00014EB8 File Offset: 0x000130B8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EmulateTouchFromMouseEventAsync(global::CefSharp.DevTools.Input.EmulateTouchFromMouseEventType type, int x, int y, global::CefSharp.DevTools.Input.MouseButton button, double? timestamp = null, double? deltaX = null, double? deltaY = null, int? modifiers = null, int? clickCount = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("type", base.EnumToString(type));
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			dictionary.Add("button", base.EnumToString(button));
			if (timestamp != null)
			{
				dictionary.Add("timestamp", timestamp.Value);
			}
			if (deltaX != null)
			{
				dictionary.Add("deltaX", deltaX.Value);
			}
			if (deltaY != null)
			{
				dictionary.Add("deltaY", deltaY.Value);
			}
			if (modifiers != null)
			{
				dictionary.Add("modifiers", modifiers.Value);
			}
			if (clickCount != null)
			{
				dictionary.Add("clickCount", clickCount.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.emulateTouchFromMouseEvent", dictionary);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00014FD0 File Offset: 0x000131D0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetIgnoreInputEventsAsync(bool ignore)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("ignore", ignore);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.setIgnoreInputEvents", dictionary);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00015008 File Offset: 0x00013208
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInterceptDragsAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.setInterceptDrags", dictionary);
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00015040 File Offset: 0x00013240
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SynthesizePinchGestureAsync(double x, double y, double scaleFactor, int? relativeSpeed = null, global::CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			dictionary.Add("scaleFactor", scaleFactor);
			if (relativeSpeed != null)
			{
				dictionary.Add("relativeSpeed", relativeSpeed.Value);
			}
			if (gestureSourceType != null)
			{
				dictionary.Add("gestureSourceType", base.EnumToString(gestureSourceType));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.synthesizePinchGesture", dictionary);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000150D8 File Offset: 0x000132D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SynthesizeScrollGestureAsync(double x, double y, double? xDistance = null, double? yDistance = null, double? xOverscroll = null, double? yOverscroll = null, bool? preventFling = null, int? speed = null, global::CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null, int? repeatCount = null, int? repeatDelayMs = null, string interactionMarkerName = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			if (xDistance != null)
			{
				dictionary.Add("xDistance", xDistance.Value);
			}
			if (yDistance != null)
			{
				dictionary.Add("yDistance", yDistance.Value);
			}
			if (xOverscroll != null)
			{
				dictionary.Add("xOverscroll", xOverscroll.Value);
			}
			if (yOverscroll != null)
			{
				dictionary.Add("yOverscroll", yOverscroll.Value);
			}
			if (preventFling != null)
			{
				dictionary.Add("preventFling", preventFling.Value);
			}
			if (speed != null)
			{
				dictionary.Add("speed", speed.Value);
			}
			if (gestureSourceType != null)
			{
				dictionary.Add("gestureSourceType", base.EnumToString(gestureSourceType));
			}
			if (repeatCount != null)
			{
				dictionary.Add("repeatCount", repeatCount.Value);
			}
			if (repeatDelayMs != null)
			{
				dictionary.Add("repeatDelayMs", repeatDelayMs.Value);
			}
			if (!string.IsNullOrEmpty(interactionMarkerName))
			{
				dictionary.Add("interactionMarkerName", interactionMarkerName);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.synthesizeScrollGesture", dictionary);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00015258 File Offset: 0x00013458
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SynthesizeTapGestureAsync(double x, double y, int? duration = null, int? tapCount = null, global::CefSharp.DevTools.Input.GestureSourceType? gestureSourceType = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("x", x);
			dictionary.Add("y", y);
			if (duration != null)
			{
				dictionary.Add("duration", duration.Value);
			}
			if (tapCount != null)
			{
				dictionary.Add("tapCount", tapCount.Value);
			}
			if (gestureSourceType != null)
			{
				dictionary.Add("gestureSourceType", base.EnumToString(gestureSourceType));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Input.synthesizeTapGesture", dictionary);
		}

		// Token: 0x04000A55 RID: 2645
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
