using System;
using System.IO;
using CefSharp.Callback;

namespace CefSharp
{
	// Token: 0x02000076 RID: 118
	public class FileResourceHandler : global::CefSharp.IResourceHandler, global::System.IDisposable
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00003561 File Offset: 0x00001761
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00003569 File Offset: 0x00001769
		public string FilePath { get; private set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00003572 File Offset: 0x00001772
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000357A File Offset: 0x0000177A
		public string MimeType { get; set; }

		// Token: 0x060002DF RID: 735 RVA: 0x00003584 File Offset: 0x00001784
		public FileResourceHandler(string mimeType, string filePath)
		{
			if (string.IsNullOrEmpty(mimeType))
			{
				throw new global::System.ArgumentNullException("mimeType", "Please provide a valid mimeType");
			}
			if (string.IsNullOrEmpty(filePath))
			{
				throw new global::System.ArgumentNullException("filePath", "Please provide a valid filePath");
			}
			if (!global::System.IO.File.Exists(filePath))
			{
				throw new global::System.IO.FileNotFoundException("Unable to create FileResourceHandler", filePath);
			}
			this.MimeType = mimeType;
			this.FilePath = filePath;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000035E9 File Offset: 0x000017E9
		bool global::CefSharp.IResourceHandler.ProcessRequest(global::CefSharp.IRequest request, global::CefSharp.ICallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000035F5 File Offset: 0x000017F5
		void global::CefSharp.IResourceHandler.GetResponseHeaders(global::CefSharp.IResponse response, out long responseLength, out string redirectUrl)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00003601 File Offset: 0x00001801
		bool global::CefSharp.IResourceHandler.ReadResponse(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.ICallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000360D File Offset: 0x0000180D
		void global::CefSharp.IResourceHandler.Cancel()
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00003619 File Offset: 0x00001819
		bool global::CefSharp.IResourceHandler.Open(global::CefSharp.IRequest request, out bool handleRequest, global::CefSharp.ICallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003625 File Offset: 0x00001825
		bool global::CefSharp.IResourceHandler.Skip(long bytesToSkip, out long bytesSkipped, global::CefSharp.Callback.IResourceSkipCallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00003631 File Offset: 0x00001831
		bool global::CefSharp.IResourceHandler.Read(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.Callback.IResourceReadCallback callback)
		{
			throw new global::System.NotImplementedException("This method should never be called");
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000363D File Offset: 0x0000183D
		void global::System.IDisposable.Dispose()
		{
		}
	}
}
