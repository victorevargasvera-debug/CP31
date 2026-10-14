using System;
using System.IO;
using System.Net;
using NLog.Common;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x02000134 RID: 308
	internal class HttpNetworkSender : global::NLog.Internal.NetworkSenders.NetworkSender
	{
		// Token: 0x06000DF7 RID: 3575 RVA: 0x000237C6 File Offset: 0x000219C6
		public HttpNetworkSender(string url) : base(url)
		{
			this._addressUri = new global::System.Uri(base.Address);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000237E0 File Offset: 0x000219E0
		protected override void DoSend(byte[] bytes, int offset, int length, global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			global::System.Net.WebRequest webRequest = global::System.Net.WebRequest.Create(this._addressUri);
			webRequest.Method = "POST";
			global::System.AsyncCallback onResponse = delegate(global::System.IAsyncResult r)
			{
				try
				{
					using (webRequest.EndGetResponse(r))
					{
					}
					asyncContinuation(null);
				}
				catch (global::System.Exception exception)
				{
					if (exception.MustBeRethrownImmediately())
					{
						throw;
					}
					asyncContinuation(exception);
				}
			};
			global::System.AsyncCallback callback = delegate(global::System.IAsyncResult r)
			{
				try
				{
					using (global::System.IO.Stream stream = webRequest.EndGetRequestStream(r))
					{
						stream.Write(bytes, offset, length);
					}
					webRequest.BeginGetResponse(onResponse, null);
				}
				catch (global::System.Exception exception)
				{
					if (exception.MustBeRethrown())
					{
						throw;
					}
					asyncContinuation(exception);
				}
			};
			webRequest.BeginGetRequestStream(callback, null);
		}

		// Token: 0x040003DC RID: 988
		private readonly global::System.Uri _addressUri;
	}
}
