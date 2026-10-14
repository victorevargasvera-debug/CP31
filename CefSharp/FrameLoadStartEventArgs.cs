using System;

namespace CefSharp
{
	// Token: 0x0200004A RID: 74
	public class FrameLoadStartEventArgs : global::System.EventArgs
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000031EC File Offset: 0x000013EC
		public FrameLoadStartEventArgs(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.TransitionType transitionType)
		{
			this.Browser = browser;
			this.Frame = frame;
			if (frame.IsValid)
			{
				this.Url = frame.Url;
			}
			this.TransitionType = transitionType;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000321D File Offset: 0x0000141D
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00003225 File Offset: 0x00001425
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000322E File Offset: 0x0000142E
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00003236 File Offset: 0x00001436
		public global::CefSharp.IFrame Frame { get; private set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000323F File Offset: 0x0000143F
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00003247 File Offset: 0x00001447
		public string Url { get; private set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00003250 File Offset: 0x00001450
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00003258 File Offset: 0x00001458
		public global::CefSharp.TransitionType TransitionType { get; private set; }
	}
}
