using System;
using CefSharp.Event;
using CefSharp.JavascriptBinding;

namespace CefSharp
{
	// Token: 0x02000073 RID: 115
	public interface IJavascriptObjectRepository : global::System.IDisposable
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600028F RID: 655
		global::CefSharp.JavascriptBinding.JavascriptBindingSettings Settings { get; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000290 RID: 656
		// (set) Token: 0x06000291 RID: 657
		global::CefSharp.JavascriptBinding.IJavascriptNameConverter NameConverter { get; set; }

		// Token: 0x06000292 RID: 658
		void Register(string name, object objectToBind, bool isAsync, global::CefSharp.BindingOptions options = null);

		// Token: 0x06000293 RID: 659
		void UnRegisterAll();

		// Token: 0x06000294 RID: 660
		bool UnRegister(string name);

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000295 RID: 661
		bool HasBoundObjects { get; }

		// Token: 0x06000296 RID: 662
		bool IsBound(string name);

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000297 RID: 663
		// (remove) Token: 0x06000298 RID: 664
		event global::System.EventHandler<global::CefSharp.Event.JavascriptBindingEventArgs> ResolveObject;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000299 RID: 665
		// (remove) Token: 0x0600029A RID: 666
		event global::System.EventHandler<global::CefSharp.Event.JavascriptBindingCompleteEventArgs> ObjectBoundInJavascript;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600029B RID: 667
		// (remove) Token: 0x0600029C RID: 668
		event global::System.EventHandler<global::CefSharp.Event.JavascriptBindingMultipleCompleteEventArgs> ObjectsBoundInJavascript;
	}
}
