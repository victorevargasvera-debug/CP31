using System;

namespace CefSharp
{
	// Token: 0x02000010 RID: 16
	public interface IPrintToPdfCallback : global::System.IDisposable
	{
		// Token: 0x06000030 RID: 48
		void OnPdfPrintFinished(string path, bool ok);

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000031 RID: 49
		bool IsDisposed { get; }
	}
}
