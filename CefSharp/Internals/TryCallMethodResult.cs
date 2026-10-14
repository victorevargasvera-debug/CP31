using System;

namespace CefSharp.Internals
{
	// Token: 0x020000F5 RID: 245
	public class TryCallMethodResult
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0000BE4B File Offset: 0x0000A04B
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0000BE53 File Offset: 0x0000A053
		public string Exception { get; private set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0000BE5C File Offset: 0x0000A05C
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0000BE64 File Offset: 0x0000A064
		public object ReturnValue { get; private set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0000BE6D File Offset: 0x0000A06D
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0000BE75 File Offset: 0x0000A075
		public bool Success { get; private set; }

		// Token: 0x06000748 RID: 1864 RVA: 0x0000BE7E File Offset: 0x0000A07E
		public TryCallMethodResult(bool success, object returnValue, string exception)
		{
			this.Success = success;
			this.ReturnValue = returnValue;
			this.Exception = exception;
		}
	}
}
