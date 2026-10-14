using System;

namespace CefSharp.Internals
{
	// Token: 0x020000F1 RID: 241
	public class RenderprocessClientFactory
	{
		// Token: 0x06000731 RID: 1841 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		public static string GetServiceName(int parentProcessId, int browserId)
		{
			return string.Join("/", new object[]
			{
				"net.pipe://localhost",
				"CefSharpSubProcessProxy",
				parentProcessId,
				browserId
			});
		}

		// Token: 0x040003C7 RID: 967
		private const string BaseAddress = "net.pipe://localhost";

		// Token: 0x040003C8 RID: 968
		private const string ServiceName = "CefSharpSubProcessProxy";
	}
}
