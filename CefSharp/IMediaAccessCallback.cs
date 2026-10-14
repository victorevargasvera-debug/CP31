using System;

namespace CefSharp
{
	// Token: 0x0200000E RID: 14
	public interface IMediaAccessCallback : global::System.IDisposable
	{
		// Token: 0x0600002D RID: 45
		void Continue(global::CefSharp.MediaAccessPermissionType allowedPermissions);

		// Token: 0x0600002E RID: 46
		void Cancel();
	}
}
