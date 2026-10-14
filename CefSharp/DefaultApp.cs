using System;
using System.Collections.Generic;

namespace CefSharp
{
	// Token: 0x02000020 RID: 32
	public class DefaultApp : global::CefSharp.IApp, global::System.IDisposable
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002974 File Offset: 0x00000B74
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000297C File Offset: 0x00000B7C
		public global::CefSharp.IBrowserProcessHandler BrowserProcessHandler { get; private set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002985 File Offset: 0x00000B85
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000298D File Offset: 0x00000B8D
		public global::System.Collections.Generic.IEnumerable<global::CefSharp.CefCustomScheme> Schemes { get; private set; }

		// Token: 0x060000A3 RID: 163 RVA: 0x00002996 File Offset: 0x00000B96
		public DefaultApp(global::CefSharp.IBrowserProcessHandler browserProcessHandler, global::System.Collections.Generic.IEnumerable<global::CefSharp.CefCustomScheme> schemes)
		{
			this.BrowserProcessHandler = browserProcessHandler;
			this.Schemes = schemes;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000029AC File Offset: 0x00000BAC
		void global::CefSharp.IApp.OnRegisterCustomSchemes(global::CefSharp.ISchemeRegistrar registrar)
		{
			this.OnRegisterCustomSchemes(registrar);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000029B8 File Offset: 0x00000BB8
		protected virtual void OnRegisterCustomSchemes(global::CefSharp.ISchemeRegistrar registrar)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::CefSharp.CefCustomScheme cefCustomScheme in this.Schemes)
			{
				if (!(cefCustomScheme.SchemeName == "http") && !(cefCustomScheme.SchemeName == "https") && !list.Contains(cefCustomScheme.SchemeName))
				{
					bool flag = registrar.AddCustomScheme(cefCustomScheme.SchemeName, cefCustomScheme.Options);
					if (flag)
					{
						list.Add(cefCustomScheme.SchemeName);
					}
					else
					{
						string text = "CefSchemeRegistrar::AddCustomScheme failed for schemeName:" + cefCustomScheme.SchemeName;
					}
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002A6C File Offset: 0x00000C6C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				if (disposing)
				{
					global::CefSharp.IBrowserProcessHandler browserProcessHandler = this.BrowserProcessHandler;
					if (browserProcessHandler != null)
					{
						browserProcessHandler.Dispose();
					}
					this.BrowserProcessHandler = null;
				}
				this.isDisposed = true;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002A98 File Offset: 0x00000C98
		void global::System.IDisposable.Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400002B RID: 43
		private bool isDisposed;
	}
}
