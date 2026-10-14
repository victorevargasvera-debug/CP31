using System;
using CefSharp.ModelBinding;

namespace CefSharp
{
	// Token: 0x0200004B RID: 75
	public class JavascriptMessageReceivedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00003261 File Offset: 0x00001461
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00003269 File Offset: 0x00001469
		public global::CefSharp.IFrame Frame { get; private set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003272 File Offset: 0x00001472
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000327A File Offset: 0x0000147A
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003283 File Offset: 0x00001483
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000328B File Offset: 0x0000148B
		public object Message { get; private set; }

		// Token: 0x06000101 RID: 257 RVA: 0x00003294 File Offset: 0x00001494
		public JavascriptMessageReceivedEventArgs(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, object message)
		{
			this.Browser = browser;
			this.Frame = frame;
			this.Message = message;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000032B4 File Offset: 0x000014B4
		public T ConvertMessageTo<T>()
		{
			if (this.Message == null)
			{
				return default(T);
			}
			return (T)((object)global::CefSharp.JavascriptMessageReceivedEventArgs.Binder.Bind(this.Message, typeof(T)));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000032F2 File Offset: 0x000014F2
		public static void SetBinder(global::CefSharp.ModelBinding.IBinder binder)
		{
			if (binder == null)
			{
				throw new global::System.ArgumentNullException("binder");
			}
			global::CefSharp.JavascriptMessageReceivedEventArgs.Binder = binder;
		}

		// Token: 0x04000281 RID: 641
		private static global::CefSharp.ModelBinding.IBinder Binder = new global::CefSharp.ModelBinding.DefaultBinder(null);
	}
}
