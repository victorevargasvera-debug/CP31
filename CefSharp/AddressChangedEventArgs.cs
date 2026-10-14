using System;

namespace CefSharp
{
	// Token: 0x02000047 RID: 71
	public class AddressChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000030BD File Offset: 0x000012BD
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000030C5 File Offset: 0x000012C5
		public global::CefSharp.IBrowser Browser { get; private set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000030CE File Offset: 0x000012CE
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000030D6 File Offset: 0x000012D6
		public string Address { get; private set; }

		// Token: 0x060000DD RID: 221 RVA: 0x000030DF File Offset: 0x000012DF
		public AddressChangedEventArgs(global::CefSharp.IBrowser browser, string address)
		{
			this.Browser = browser;
			this.Address = address;
		}
	}
}
