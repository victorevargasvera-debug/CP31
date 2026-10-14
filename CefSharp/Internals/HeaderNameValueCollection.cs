using System;
using System.Collections.Specialized;

namespace CefSharp.Internals
{
	// Token: 0x020000D3 RID: 211
	public class HeaderNameValueCollection : global::System.Collections.Specialized.NameValueCollection
	{
		// Token: 0x06000636 RID: 1590 RVA: 0x0000A077 File Offset: 0x00008277
		public void SetReadOnly()
		{
			base.IsReadOnly = true;
		}
	}
}
