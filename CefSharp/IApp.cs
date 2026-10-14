using System;

namespace CefSharp
{
	// Token: 0x02000067 RID: 103
	public interface IApp
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000183 RID: 387
		global::CefSharp.IBrowserProcessHandler BrowserProcessHandler { get; }

		// Token: 0x06000184 RID: 388
		void OnRegisterCustomSchemes(global::CefSharp.ISchemeRegistrar registrar);
	}
}
