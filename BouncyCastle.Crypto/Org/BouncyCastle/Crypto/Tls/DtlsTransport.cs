using System;
using System.IO;
using System.Net.Sockets;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200032A RID: 810
	public class DtlsTransport : global::Org.BouncyCastle.Crypto.Tls.DatagramTransport, global::Org.BouncyCastle.Crypto.Tls.TlsCloseable
	{
		// Token: 0x06002213 RID: 8723 RVA: 0x00097267 File Offset: 0x00095467
		internal DtlsTransport(global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer)
		{
			this.mRecordLayer = recordLayer;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00097276 File Offset: 0x00095476
		public virtual int GetReceiveLimit()
		{
			return this.mRecordLayer.GetReceiveLimit();
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00097283 File Offset: 0x00095483
		public virtual int GetSendLimit()
		{
			return this.mRecordLayer.GetSendLimit();
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00097290 File Offset: 0x00095490
		public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (off < 0 || off >= buf.Length)
			{
				throw new global::System.ArgumentException("invalid offset: " + off.ToString(), "off");
			}
			if (len < 0 || len > buf.Length - off)
			{
				throw new global::System.ArgumentException("invalid length: " + len.ToString(), "len");
			}
			if (waitMillis < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "waitMillis");
			}
			int result;
			try
			{
				result = this.mRecordLayer.Receive(buf, off, len, waitMillis);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert fatalAlert)
			{
				this.mRecordLayer.Fail(fatalAlert.AlertDescription);
				throw fatalAlert;
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsTimeoutException ex)
			{
				throw ex;
			}
			catch (global::System.Net.Sockets.SocketException e)
			{
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTimeout(e))
				{
					throw e;
				}
				this.mRecordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			catch (global::System.IO.IOException ex2)
			{
				this.mRecordLayer.Fail(80);
				throw ex2;
			}
			catch (global::System.Exception e2)
			{
				this.mRecordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e2);
			}
			return result;
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x000973C0 File Offset: 0x000955C0
		public virtual void Send(byte[] buf, int off, int len)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (off < 0 || off >= buf.Length)
			{
				throw new global::System.ArgumentException("invalid offset: " + off.ToString(), "off");
			}
			if (len < 0 || len > buf.Length - off)
			{
				throw new global::System.ArgumentException("invalid length: " + len.ToString(), "len");
			}
			try
			{
				this.mRecordLayer.Send(buf, off, len);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert fatalAlert)
			{
				this.mRecordLayer.Fail(fatalAlert.AlertDescription);
				throw fatalAlert;
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsTimeoutException ex)
			{
				throw ex;
			}
			catch (global::System.Net.Sockets.SocketException e)
			{
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTimeout(e))
				{
					throw e;
				}
				this.mRecordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			catch (global::System.IO.IOException ex2)
			{
				this.mRecordLayer.Fail(80);
				throw ex2;
			}
			catch (global::System.Exception e2)
			{
				this.mRecordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e2);
			}
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x000974D8 File Offset: 0x000956D8
		public virtual void Close()
		{
			this.mRecordLayer.Close();
		}

		// Token: 0x04000D15 RID: 3349
		private readonly global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer mRecordLayer;
	}
}
