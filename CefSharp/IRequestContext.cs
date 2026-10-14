using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CefSharp
{
	// Token: 0x0200007C RID: 124
	public interface IRequestContext : global::System.IDisposable
	{
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000314 RID: 788
		bool IsDisposed { get; }

		// Token: 0x06000315 RID: 789
		bool IsSame(global::CefSharp.IRequestContext context);

		// Token: 0x06000316 RID: 790
		bool IsSharingWith(global::CefSharp.IRequestContext context);

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000317 RID: 791
		bool IsGlobal { get; }

		// Token: 0x06000318 RID: 792
		global::CefSharp.ICookieManager GetCookieManager(global::CefSharp.ICompletionCallback callback);

		// Token: 0x06000319 RID: 793
		bool RegisterSchemeHandlerFactory(string schemeName, string domainName, global::CefSharp.ISchemeHandlerFactory factory);

		// Token: 0x0600031A RID: 794
		bool ClearSchemeHandlerFactories();

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600031B RID: 795
		string CachePath { get; }

		// Token: 0x0600031C RID: 796
		bool HasPreference(string name);

		// Token: 0x0600031D RID: 797
		object GetPreference(string name);

		// Token: 0x0600031E RID: 798
		global::System.Collections.Generic.IDictionary<string, object> GetAllPreferences(bool includeDefaults);

		// Token: 0x0600031F RID: 799
		bool CanSetPreference(string name);

		// Token: 0x06000320 RID: 800
		bool SetPreference(string name, object value, out string error);

		// Token: 0x06000321 RID: 801
		void ClearCertificateExceptions(global::CefSharp.ICompletionCallback callback);

		// Token: 0x06000322 RID: 802
		void ClearHttpAuthCredentials(global::CefSharp.ICompletionCallback callback = null);

		// Token: 0x06000323 RID: 803
		void CloseAllConnections(global::CefSharp.ICompletionCallback callback);

		// Token: 0x06000324 RID: 804
		global::System.Threading.Tasks.Task<global::CefSharp.ResolveCallbackResult> ResolveHostAsync(global::System.Uri origin);

		// Token: 0x06000325 RID: 805
		bool DidLoadExtension(string extensionId);

		// Token: 0x06000326 RID: 806
		global::CefSharp.IExtension GetExtension(string extensionId);

		// Token: 0x06000327 RID: 807
		bool GetExtensions(out global::System.Collections.Generic.IList<string> extensionIds);

		// Token: 0x06000328 RID: 808
		bool HasExtension(string extensionId);

		// Token: 0x06000329 RID: 809
		void LoadExtension(string rootDirectory, string manifestJson, global::CefSharp.IExtensionHandler handler);

		// Token: 0x0600032A RID: 810
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::CefSharp.IRequestContext UnWrap();
	}
}
