using System;
using System.Collections.Specialized;
using System.IO;
using CefSharp.Callback;

namespace CefSharp.Lagacy
{
	// Token: 0x020000C3 RID: 195
	public class ResourceHandler : global::CefSharp.IResourceHandler, global::System.IDisposable
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00009223 File Offset: 0x00007423
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x0000922B File Offset: 0x0000742B
		public string Charset { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00009234 File Offset: 0x00007434
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x0000923C File Offset: 0x0000743C
		public string MimeType { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00009245 File Offset: 0x00007445
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x0000924D File Offset: 0x0000744D
		public global::System.IO.Stream Stream { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00009256 File Offset: 0x00007456
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0000925E File Offset: 0x0000745E
		public int StatusCode { get; set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00009267 File Offset: 0x00007467
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0000926F File Offset: 0x0000746F
		public string StatusText { get; set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00009278 File Offset: 0x00007478
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00009280 File Offset: 0x00007480
		public long? ResponseLength { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00009289 File Offset: 0x00007489
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00009291 File Offset: 0x00007491
		public global::System.Collections.Specialized.NameValueCollection Headers { get; private set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0000929A File Offset: 0x0000749A
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000092A2 File Offset: 0x000074A2
		public bool AutoDisposeStream { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x000092AB File Offset: 0x000074AB
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000092B3 File Offset: 0x000074B3
		public global::CefSharp.CefErrorCode? ErrorCode { get; set; }

		// Token: 0x060005D3 RID: 1491 RVA: 0x000092BC File Offset: 0x000074BC
		public ResourceHandler(string mimeType = "text/html", global::System.IO.Stream stream = null, bool autoDisposeStream = false, string charset = null)
		{
			if (string.IsNullOrEmpty(mimeType))
			{
				throw new global::System.ArgumentNullException("mimeType", "Please provide a valid mimeType");
			}
			this.StatusCode = 200;
			this.StatusText = "OK";
			this.MimeType = mimeType;
			this.Headers = new global::System.Collections.Specialized.NameValueCollection();
			this.Stream = stream;
			this.AutoDisposeStream = autoDisposeStream;
			this.Charset = charset;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00009325 File Offset: 0x00007525
		protected virtual bool ProcessRequestAsync(global::CefSharp.IRequest request, global::CefSharp.ICallback callback)
		{
			callback.Continue();
			return true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000932E File Offset: 0x0000752E
		protected virtual void Cancel()
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00009330 File Offset: 0x00007530
		protected virtual void Dispose()
		{
			if (this.AutoDisposeStream && this.Stream != null)
			{
				this.Stream.Dispose();
				this.Stream = null;
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00009354 File Offset: 0x00007554
		protected virtual global::System.IO.Stream GetResponse(global::CefSharp.IResponse response, out long responseLength, out string redirectUrl)
		{
			redirectUrl = null;
			responseLength = -1L;
			response.MimeType = this.MimeType;
			response.StatusCode = this.StatusCode;
			response.StatusText = this.StatusText;
			response.Headers = this.Headers;
			if (!string.IsNullOrEmpty(this.Charset))
			{
				response.Charset = this.Charset;
			}
			if (this.ResponseLength != null)
			{
				responseLength = this.ResponseLength.Value;
			}
			else if (this.Stream != null && this.Stream.CanSeek)
			{
				responseLength = this.Stream.Length;
			}
			return this.Stream;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000093FB File Offset: 0x000075FB
		void global::CefSharp.IResourceHandler.Cancel()
		{
			this.Cancel();
			this.Stream = null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000940A File Offset: 0x0000760A
		void global::System.IDisposable.Dispose()
		{
			this.Dispose();
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00009414 File Offset: 0x00007614
		void global::CefSharp.IResourceHandler.GetResponseHeaders(global::CefSharp.IResponse response, out long responseLength, out string redirectUrl)
		{
			if (this.ErrorCode != null)
			{
				responseLength = 0L;
				redirectUrl = null;
				response.ErrorCode = this.ErrorCode.Value;
				return;
			}
			this.Stream = this.GetResponse(response, out responseLength, out redirectUrl);
			if (this.Stream != null && this.Stream.CanSeek)
			{
				this.Stream.Position = 0L;
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000947E File Offset: 0x0000767E
		bool global::CefSharp.IResourceHandler.Open(global::CefSharp.IRequest request, out bool handleRequest, global::CefSharp.ICallback callback)
		{
			callback.Dispose();
			handleRequest = false;
			return false;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000948A File Offset: 0x0000768A
		bool global::CefSharp.IResourceHandler.ProcessRequest(global::CefSharp.IRequest request, global::CefSharp.ICallback callback)
		{
			return this.ProcessRequestAsync(request, callback);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00009494 File Offset: 0x00007694
		bool global::CefSharp.IResourceHandler.Read(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.Callback.IResourceReadCallback callback)
		{
			bytesRead = -1;
			return false;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000949C File Offset: 0x0000769C
		bool global::CefSharp.IResourceHandler.ReadResponse(global::System.IO.Stream dataOut, out int bytesRead, global::CefSharp.ICallback callback)
		{
			callback.Dispose();
			if (this.Stream == null)
			{
				bytesRead = 0;
				return false;
			}
			byte[] array = new byte[dataOut.Length];
			bytesRead = this.Stream.Read(array, 0, array.Length);
			if (bytesRead == 0)
			{
				return false;
			}
			dataOut.Write(array, 0, array.Length);
			return bytesRead > 0;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000094F1 File Offset: 0x000076F1
		bool global::CefSharp.IResourceHandler.Skip(long bytesToSkip, out long bytesSkipped, global::CefSharp.Callback.IResourceSkipCallback callback)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
