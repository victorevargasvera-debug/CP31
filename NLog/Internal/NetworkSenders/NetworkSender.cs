using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using NLog.Common;

namespace NLog.Internal.NetworkSenders
{
	// Token: 0x02000137 RID: 311
	internal abstract class NetworkSender : global::System.IDisposable
	{
		// Token: 0x06000DFE RID: 3582 RVA: 0x0002385C File Offset: 0x00021A5C
		protected NetworkSender(string url)
		{
			this.Address = url;
			this.LastSendTime = global::System.Threading.Interlocked.Increment(ref global::NLog.Internal.NetworkSenders.NetworkSender.currentSendTime);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0002387B File Offset: 0x00021A7B
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00023883 File Offset: 0x00021A83
		public string Address { get; private set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0002388C File Offset: 0x00021A8C
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00023894 File Offset: 0x00021A94
		public int LastSendTime { get; private set; }

		// Token: 0x06000E03 RID: 3587 RVA: 0x0002389D File Offset: 0x00021A9D
		public void Initialize()
		{
			this.DoInitialize();
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000238A5 File Offset: 0x00021AA5
		public void Close(global::NLog.Common.AsyncContinuation continuation)
		{
			this.DoClose(continuation);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000238AE File Offset: 0x00021AAE
		public void FlushAsync(global::NLog.Common.AsyncContinuation continuation)
		{
			this.DoFlush(continuation);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000238B7 File Offset: 0x00021AB7
		public void Send(byte[] bytes, int offset, int length, global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this.LastSendTime = global::System.Threading.Interlocked.Increment(ref global::NLog.Internal.NetworkSenders.NetworkSender.currentSendTime);
			this.DoSend(bytes, offset, length, asyncContinuation);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000238D4 File Offset: 0x00021AD4
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x000238E3 File Offset: 0x00021AE3
		protected virtual void DoInitialize()
		{
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000238E5 File Offset: 0x00021AE5
		protected virtual void DoClose(global::NLog.Common.AsyncContinuation continuation)
		{
			continuation(null);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000238EE File Offset: 0x00021AEE
		protected virtual void DoFlush(global::NLog.Common.AsyncContinuation continuation)
		{
			continuation(null);
		}

		// Token: 0x06000E0B RID: 3595
		protected abstract void DoSend(byte[] bytes, int offset, int length, global::NLog.Common.AsyncContinuation asyncContinuation);

		// Token: 0x06000E0C RID: 3596 RVA: 0x000238F8 File Offset: 0x00021AF8
		protected virtual global::System.Net.EndPoint ParseEndpointAddress(global::System.Uri uri, global::System.Net.Sockets.AddressFamily addressFamily)
		{
			global::System.UriHostNameType hostNameType = uri.HostNameType;
			if (hostNameType - global::System.UriHostNameType.IPv4 <= 1)
			{
				return new global::System.Net.IPEndPoint(global::System.Net.IPAddress.Parse(uri.Host), uri.Port);
			}
			foreach (global::System.Net.IPAddress ipaddress in global::System.Net.Dns.GetHostEntry(uri.Host).AddressList)
			{
				if (ipaddress.AddressFamily == addressFamily || addressFamily == global::System.Net.Sockets.AddressFamily.Unspecified)
				{
					return new global::System.Net.IPEndPoint(ipaddress, uri.Port);
				}
			}
			throw new global::System.IO.IOException(string.Format("Cannot resolve '{0}' to an address in '{1}'", uri.Host, addressFamily));
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x00023980 File Offset: 0x00021B80
		public virtual void CheckSocket()
		{
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00023982 File Offset: 0x00021B82
		private void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.Close(delegate(global::System.Exception ex)
				{
				});
			}
		}

		// Token: 0x040003DD RID: 989
		private static int currentSendTime;
	}
}
