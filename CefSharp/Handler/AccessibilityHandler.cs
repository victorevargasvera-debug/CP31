using System;

namespace CefSharp.Handler
{
	// Token: 0x020000FF RID: 255
	public class AccessibilityHandler : global::CefSharp.IAccessibilityHandler
	{
		// Token: 0x06000779 RID: 1913 RVA: 0x0000C669 File Offset: 0x0000A869
		void global::CefSharp.IAccessibilityHandler.OnAccessibilityLocationChange(global::CefSharp.IValue value)
		{
			this.OnAccessibilityLocationChange(value);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0000C672 File Offset: 0x0000A872
		protected virtual void OnAccessibilityLocationChange(global::CefSharp.IValue value)
		{
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000C674 File Offset: 0x0000A874
		void global::CefSharp.IAccessibilityHandler.OnAccessibilityTreeChange(global::CefSharp.IValue value)
		{
			this.OnAccessibilityTreeChange(value);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0000C67D File Offset: 0x0000A87D
		protected virtual void OnAccessibilityTreeChange(global::CefSharp.IValue value)
		{
		}
	}
}
