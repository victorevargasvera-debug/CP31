using System;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw
{
	// Token: 0x0200006D RID: 109
	[global::System.Runtime.InteropServices.Guid("DF362C62-3B8E-484A-8DE0-FE2CB31EDBC5")]
	[global::System.Runtime.InteropServices.InterfaceType(global::System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
	public interface ICoreWebView2StagingHostObjectHelper
	{
		// Token: 0x06000326 RID: 806
		int IsMethodMember(ref object rawObject, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] [global::System.Runtime.InteropServices.In] string memberName);
	}
}
