using System;
using CefSharp.Structs;

namespace CefSharp.Handler
{
	// Token: 0x02000100 RID: 256
	public class AudioHandler : global::CefSharp.IAudioHandler, global::System.IDisposable
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0000C687 File Offset: 0x0000A887
		public bool IsDisposed
		{
			get
			{
				return this.isDisposed;
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0000C68F File Offset: 0x0000A88F
		bool global::CefSharp.IAudioHandler.GetAudioParameters(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ref global::CefSharp.Structs.AudioParameters parameters)
		{
			return this.GetAudioParameters(chromiumWebBrowser, browser, ref parameters);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0000C69A File Offset: 0x0000A89A
		protected virtual bool GetAudioParameters(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, ref global::CefSharp.Structs.AudioParameters parameters)
		{
			return false;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0000C69D File Offset: 0x0000A89D
		void global::CefSharp.IAudioHandler.OnAudioStreamStarted(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.Structs.AudioParameters parameters, int channels)
		{
			this.OnAudioStreamStarted(chromiumWebBrowser, browser, parameters, channels);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000C6AA File Offset: 0x0000A8AA
		protected virtual void OnAudioStreamStarted(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::CefSharp.Structs.AudioParameters parameters, int channels)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		void global::CefSharp.IAudioHandler.OnAudioStreamPacket(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.IntPtr data, int noOfFrames, long pts)
		{
			this.OnAudioStreamPacket(chromiumWebBrowser, browser, data, noOfFrames, pts);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0000C6BB File Offset: 0x0000A8BB
		protected virtual void OnAudioStreamPacket(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, global::System.IntPtr data, int noOfFrames, long pts)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0000C6BD File Offset: 0x0000A8BD
		void global::CefSharp.IAudioHandler.OnAudioStreamStopped(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
			this.OnAudioStreamStopped(chromiumWebBrowser, browser);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000C6C7 File Offset: 0x0000A8C7
		protected virtual void OnAudioStreamStopped(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser)
		{
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000C6C9 File Offset: 0x0000A8C9
		void global::CefSharp.IAudioHandler.OnAudioStreamError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string errorMessage)
		{
			this.OnAudioStreamError(chromiumWebBrowser, browser, errorMessage);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		protected virtual void OnAudioStreamError(global::CefSharp.IWebBrowser chromiumWebBrowser, global::CefSharp.IBrowser browser, string errorMessage)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000C6D6 File Offset: 0x0000A8D6
		protected virtual void Dispose(bool disposing)
		{
			this.isDisposed = true;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0000C6DF File Offset: 0x0000A8DF
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040003DB RID: 987
		private bool isDisposed;
	}
}
