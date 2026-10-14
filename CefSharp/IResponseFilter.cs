using System;
using System.IO;

namespace CefSharp
{
	// Token: 0x0200007F RID: 127
	public interface IResponseFilter : global::System.IDisposable
	{
		// Token: 0x0600033C RID: 828
		bool InitFilter();

		// Token: 0x0600033D RID: 829
		global::CefSharp.FilterStatus Filter(global::System.IO.Stream dataIn, out long dataInRead, global::System.IO.Stream dataOut, out long dataOutWritten);
	}
}
