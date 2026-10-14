using System;

namespace CefSharp
{
	// Token: 0x02000050 RID: 80
	public interface IAccessibilityHandler
	{
		// Token: 0x06000125 RID: 293
		void OnAccessibilityLocationChange(global::CefSharp.IValue value);

		// Token: 0x06000126 RID: 294
		void OnAccessibilityTreeChange(global::CefSharp.IValue value);
	}
}
