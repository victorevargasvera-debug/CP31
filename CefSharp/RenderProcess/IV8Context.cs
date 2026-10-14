using System;

namespace CefSharp.RenderProcess
{
	// Token: 0x020000B8 RID: 184
	public interface IV8Context
	{
		// Token: 0x06000592 RID: 1426
		bool Execute(string code, string scriptUrl, int startLine, out global::CefSharp.RenderProcess.V8Exception exception);
	}
}
