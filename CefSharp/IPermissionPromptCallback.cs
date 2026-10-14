using System;

namespace CefSharp
{
	// Token: 0x0200000F RID: 15
	public interface IPermissionPromptCallback : global::System.IDisposable
	{
		// Token: 0x0600002F RID: 47
		void Continue(global::CefSharp.PermissionRequestResult result);
	}
}
