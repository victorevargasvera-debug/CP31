using System;
using System.Collections.Generic;

namespace CefSharp.Handler
{
	// Token: 0x0200010B RID: 267
	public class FrameHandler : global::CefSharp.IFrameHandler
	{
		// Token: 0x060007E4 RID: 2020 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		void global::CefSharp.IFrameHandler.OnFrameAttached(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, bool reattached)
		{
			global::CefSharp.IFrame frameById = this.GetFrameById(frame.Identifier);
			this.OnFrameAttached(chromiumWebBrowser, browser, frameById ?? frame, reattached);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000C9D2 File Offset: 0x0000ABD2
		protected virtual void OnFrameAttached(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, bool reattached)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		void global::CefSharp.IFrameHandler.OnFrameCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
			this.frames.Add(frame.Identifier, frame);
			this.OnFrameCreated(chromiumWebBrowser, browser, frame);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
		protected virtual void OnFrameCreated(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
		void global::CefSharp.IFrameHandler.OnFrameDetached(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
			this.frames.Remove(frame.Identifier);
			this.OnFrameDetached(chromiumWebBrowser, browser, frame);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000CA10 File Offset: 0x0000AC10
		protected virtual void OnFrameDetached(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0000CA14 File Offset: 0x0000AC14
		void global::CefSharp.IFrameHandler.OnMainFrameChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame oldFrame, global::CefSharp.IFrame newFrame)
		{
			global::CefSharp.IFrame frame = (newFrame == null) ? null : this.GetFrameById(newFrame.Identifier);
			this.OnMainFrameChanged(chromiumWebBrowser, browser, oldFrame, frame ?? newFrame);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000CA46 File Offset: 0x0000AC46
		protected virtual void OnMainFrameChanged(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.IFrame oldFrame, global::CefSharp.IFrame newFrame)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000CA48 File Offset: 0x0000AC48
		private global::CefSharp.IFrame GetFrameById(long frameId)
		{
			global::CefSharp.IFrame result;
			if (this.frames.TryGetValue(frameId, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x040003DE RID: 990
		private global::System.Collections.Generic.Dictionary<long, global::CefSharp.IFrame> frames = new global::System.Collections.Generic.Dictionary<long, global::CefSharp.IFrame>();
	}
}
