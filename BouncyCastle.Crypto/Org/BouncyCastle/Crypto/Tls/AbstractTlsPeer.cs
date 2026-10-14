using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F9 RID: 761
	public abstract class AbstractTlsPeer : global::Org.BouncyCastle.Crypto.Tls.TlsPeer
	{
		// Token: 0x0600208E RID: 8334 RVA: 0x000918B4 File Offset: 0x0008FAB4
		public virtual void Cancel()
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsCloseable closeHandle = this.mCloseHandle;
			if (closeHandle != null)
			{
				closeHandle.Close();
			}
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x000918D3 File Offset: 0x0008FAD3
		public virtual void NotifyCloseHandle(global::Org.BouncyCastle.Crypto.Tls.TlsCloseable closeHandle)
		{
			this.mCloseHandle = closeHandle;
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x000918DE File Offset: 0x0008FADE
		public virtual int GetHandshakeTimeoutMillis()
		{
			return 0;
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x000918E1 File Offset: 0x0008FAE1
		public virtual bool RequiresExtendedMasterSecret()
		{
			return false;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x000918E4 File Offset: 0x0008FAE4
		public virtual bool ShouldUseGmtUnixTime()
		{
			return false;
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x000918E7 File Offset: 0x0008FAE7
		public virtual void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			if (!secureRenegotiation)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
		}

		// Token: 0x06002094 RID: 8340
		public abstract global::Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression();

		// Token: 0x06002095 RID: 8341
		public abstract global::Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher();

		// Token: 0x06002096 RID: 8342 RVA: 0x000918F4 File Offset: 0x0008FAF4
		public virtual void NotifyAlertRaised(byte alertLevel, byte alertDescription, string message, global::System.Exception cause)
		{
		}

		// Token: 0x06002097 RID: 8343 RVA: 0x000918F6 File Offset: 0x0008FAF6
		public virtual void NotifyAlertReceived(byte alertLevel, byte alertDescription)
		{
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000918F8 File Offset: 0x0008FAF8
		public virtual void NotifyHandshakeComplete()
		{
		}

		// Token: 0x04000B50 RID: 2896
		private volatile global::Org.BouncyCastle.Crypto.Tls.TlsCloseable mCloseHandle;
	}
}
