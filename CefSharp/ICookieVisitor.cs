using System;

namespace CefSharp
{
	// Token: 0x0200009E RID: 158
	public interface ICookieVisitor : global::System.IDisposable
	{
		// Token: 0x06000495 RID: 1173
		bool Visit(global::CefSharp.Cookie cookie, int count, int total, ref bool deleteCookie);
	}
}
