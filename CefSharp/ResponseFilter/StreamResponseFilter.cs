using System;
using System.IO;

namespace CefSharp.ResponseFilter
{
	// Token: 0x020000B6 RID: 182
	public sealed class StreamResponseFilter : global::CefSharp.IResponseFilter, global::System.IDisposable
	{
		// Token: 0x0600058B RID: 1419 RVA: 0x00008B33 File Offset: 0x00006D33
		public StreamResponseFilter(global::System.IO.Stream stream)
		{
			this.responseStream = stream;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00008B42 File Offset: 0x00006D42
		bool global::CefSharp.IResponseFilter.InitFilter()
		{
			return this.responseStream != null && this.responseStream.CanWrite;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00008B5C File Offset: 0x00006D5C
		global::CefSharp.FilterStatus global::CefSharp.IResponseFilter.Filter(global::System.IO.Stream dataIn, out long dataInRead, global::System.IO.Stream dataOut, out long dataOutWritten)
		{
			if (dataIn == null)
			{
				dataInRead = 0L;
				dataOutWritten = 0L;
				return global::CefSharp.FilterStatus.Done;
			}
			dataInRead = global::System.Math.Min(dataIn.Length, dataOut.Length);
			dataOutWritten = dataInRead;
			byte[] array = new byte[dataInRead];
			dataIn.Read(array, 0, array.Length);
			dataOut.Write(array, 0, array.Length);
			this.responseStream.Write(array, 0, array.Length);
			if (dataInRead < dataIn.Length)
			{
				return global::CefSharp.FilterStatus.NeedMoreData;
			}
			return global::CefSharp.FilterStatus.Done;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00008BCC File Offset: 0x00006DCC
		public void Dispose()
		{
			this.responseStream = null;
		}

		// Token: 0x04000347 RID: 839
		private global::System.IO.Stream responseStream;
	}
}
