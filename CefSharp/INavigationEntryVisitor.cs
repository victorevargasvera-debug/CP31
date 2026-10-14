using System;

namespace CefSharp
{
	// Token: 0x0200009F RID: 159
	public interface INavigationEntryVisitor : global::System.IDisposable
	{
		// Token: 0x06000496 RID: 1174
		bool Visit(global::CefSharp.NavigationEntry entry, bool current, int index, int total);
	}
}
