using System;
using System.IO;
using System.Net.Sockets;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C1 RID: 193
	public class DtlsTransport : global::Org.BouncyCastle.Tls.DatagramTransport, global::Org.BouncyCastle.Tls.DatagramReceiver, global::Org.BouncyCastle.Tls.DatagramSender, global::Org.BouncyCastle.Tls.TlsCloseable
	{
		// Token: 0x0600075B RID: 1883 RVA: 0x0001F85A File Offset: 0x0001DA5A
		internal DtlsTransport(global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer)
		{
			this.m_recordLayer = recordLayer;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0001F869 File Offset: 0x0001DA69
		public virtual int GetReceiveLimit()
		{
			return this.m_recordLayer.GetReceiveLimit();
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001F876 File Offset: 0x0001DA76
		public virtual int GetSendLimit()
		{
			return this.m_recordLayer.GetSendLimit();
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001F884 File Offset: 0x0001DA84
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
				result = this.m_recordLayer.Receive(buf, off, len, waitMillis);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert fatalAlert)
			{
				this.m_recordLayer.Fail(fatalAlert.AlertDescription);
				throw fatalAlert;
			}
			catch (global::Org.BouncyCastle.Tls.TlsTimeoutException ex)
			{
				throw ex;
			}
			catch (global::System.Net.Sockets.SocketException e)
			{
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTimeout(e))
				{
					throw e;
				}
				this.m_recordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			catch (global::System.IO.IOException ex2)
			{
				this.m_recordLayer.Fail(80);
				throw ex2;
			}
			catch (global::System.Exception e2)
			{
				this.m_recordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e2);
			}
			return result;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0001F9B4 File Offset: 0x0001DBB4
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
				this.m_recordLayer.Send(buf, off, len);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert fatalAlert)
			{
				this.m_recordLayer.Fail(fatalAlert.AlertDescription);
				throw fatalAlert;
			}
			catch (global::Org.BouncyCastle.Tls.TlsTimeoutException ex)
			{
				throw ex;
			}
			catch (global::System.Net.Sockets.SocketException e)
			{
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTimeout(e))
				{
					throw e;
				}
				this.m_recordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			catch (global::System.IO.IOException ex2)
			{
				this.m_recordLayer.Fail(80);
				throw ex2;
			}
			catch (global::System.Exception e2)
			{
				this.m_recordLayer.Fail(80);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e2);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001FACC File Offset: 0x0001DCCC
		public virtual void Close()
		{
			this.m_recordLayer.Close();
		}

		// Token: 0x04000516 RID: 1302
		private readonly global::Org.BouncyCastle.Tls.DtlsRecordLayer m_recordLayer;
	}
}
