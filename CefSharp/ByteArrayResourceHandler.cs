using System;
using System.IO;
using CefSharp.Callback;

namespace CefSharp
{
	// Token: 0x02000075 RID: 117
	public class ByteArrayResourceHandler : global::CefSharp.IResourceHandler, global::System.IDisposable
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000348C File Offset: 0x0000168C
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00003494 File Offset: 0x00001694
		public byte[] Data { get; private set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000349D File Offset: 0x0000169D
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x000034A5 File Offset: 0x000016A5
		public string MimeType { get; set; }

		// Token: 0x060002D2 RID: 722 RVA: 0x000034B0 File Offset: 0x000016B0
		public ByteArrayResourceHandler(string mimeType, byte[] data)
		{
			if (string.IsNullOrEmpty(mimeType))
			{
				throw new global::System.ArgumentNullException("mimeType", "Please provide a valid mimeType");
			}
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data", "Please provide a valid array");
			}
			if (data.Length == 0)
			{
				throw new global::System.Exception("Unable to load byte[] with length 0.");
			}
			this.MimeType = mimeType;
			this.Data = data;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000350B File Offset: 0x0000170B
		bool global::CefSharp.IResourceHandler.ProcessRequest(global::CefSharp.IRequest request, global::CefSharp.ICallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003517 File Offset: 0x00001717
		void global::CefSharp.IResourceHandler.GetResponseHeaders(global::CefSharp.IResponse response, out long responseLength, out string redirectUrl)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003523 File Offset: 0x00001723
		bool global::CefSharp.IResourceHandler.ReadResponse(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.ICallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000352F File Offset: 0x0000172F
		void global::CefSharp.IResourceHandler.Cancel()
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000353B File Offset: 0x0000173B
		bool global::CefSharp.IResourceHandler.Open(global::CefSharp.IRequest request, out bool handleRequest, global::CefSharp.ICallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00003547 File Offset: 0x00001747
		bool global::CefSharp.IResourceHandler.Skip(long bytesToSkip, out long bytesSkipped, global::CefSharp.Callback.IResourceSkipCallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00003553 File Offset: 0x00001753
		bool global::CefSharp.IResourceHandler.Read(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.Callback.IResourceReadCallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000355F File Offset: 0x0000175F
		void global::System.IDisposable.Dispose()
		{
		}
	}
}
