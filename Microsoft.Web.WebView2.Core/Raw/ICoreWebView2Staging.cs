using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x0200006C RID: 108
	[global::System.Runtime.InteropServices.Guid("2C94DD56-E252-40A1-BA7E-B19417B26A60")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2Staging
	{
		// Token: 0x06000325 RID: 805
		void AddHostObjectHelper(global::Microsoft.Web.WebView2.Core.Raw.ICoreWebView2StagingHostObjectHelper helper);
	}
}
