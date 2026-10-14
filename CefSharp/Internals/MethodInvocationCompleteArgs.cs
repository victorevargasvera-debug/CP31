using System;

namespace CefSharp.Internals
{
	// Token: 0x020000E6 RID: 230
	public sealed class MethodInvocationCompleteArgs : global::System.EventArgs
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0000B49E File Offset: 0x0000969E
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0000B4A6 File Offset: 0x000096A6
		public global::CefSharp.Internals.MethodInvocationResult Result { get; private set; }

		// Token: 0x060006FA RID: 1786 RVA: 0x0000B4AF File Offset: 0x000096AF
		public MethodInvocationCompleteArgs(global::CefSharp.Internals.MethodInvocationResult result)
		{
			this.Result = result;
		}
	}
}
