using System;
using CefSharp.Structs;

namespace CefSharp
{
	// Token: 0x02000051 RID: 81
	public interface IAudioHandler : global::System.IDisposable
	{
		// Token: 0x06000127 RID: 295
		bool GetAudioParameters(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ref global::CefSharp.Structs.AudioParameters parameters);

		// Token: 0x06000128 RID: 296
		void OnAudioStreamStarted(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.Structs.AudioParameters parameters, int channels);

		// Token: 0x06000129 RID: 297
		void OnAudioStreamPacket(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.IntPtr data, int noOfFrames, long pts);

		// Token: 0x0600012A RID: 298
		void OnAudioStreamStopped(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser);

		// Token: 0x0600012B RID: 299
		void OnAudioStreamError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string errorMessage);
	}
}
