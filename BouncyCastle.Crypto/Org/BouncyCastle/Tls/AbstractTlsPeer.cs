using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200008A RID: 138
	public abstract class AbstractTlsPeer : global::Org.BouncyCastle.Tls.TlsPeer
	{
		// Token: 0x060005AE RID: 1454 RVA: 0x00018D53 File Offset: 0x00016F53
		protected AbstractTlsPeer(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto)
		{
			this.m_crypto = crypto;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00018D62 File Offset: 0x00016F62
		protected virtual global::Org.BouncyCastle.Tls.ProtocolVersion[] GetSupportedVersions()
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
		}

		// Token: 0x060005B0 RID: 1456
		protected abstract int[] GetSupportedCipherSuites();

		// Token: 0x060005B1 RID: 1457 RVA: 0x00018D74 File Offset: 0x00016F74
		public virtual void Cancel()
		{
			global::Org.BouncyCastle.Tls.TlsCloseable closeHandle = this.m_closeHandle;
			if (closeHandle != null)
			{
				closeHandle.Close();
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00018D93 File Offset: 0x00016F93
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsCrypto Crypto
		{
			get
			{
				return this.m_crypto;
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00018D9B File Offset: 0x00016F9B
		public virtual void NotifyCloseHandle(global::Org.BouncyCastle.Tls.TlsCloseable closeHandle)
		{
			this.m_closeHandle = closeHandle;
		}

		// Token: 0x060005B4 RID: 1460
		public abstract global::Org.BouncyCastle.Tls.ProtocolVersion[] GetProtocolVersions();

		// Token: 0x060005B5 RID: 1461
		public abstract int[] GetCipherSuites();

		// Token: 0x060005B6 RID: 1462 RVA: 0x00018DA6 File Offset: 0x00016FA6
		public virtual void NotifyHandshakeBeginning()
		{
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00018DA8 File Offset: 0x00016FA8
		public virtual int GetHandshakeTimeoutMillis()
		{
			return 0;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00018DAB File Offset: 0x00016FAB
		public virtual bool AllowLegacyResumption()
		{
			return false;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00018DAE File Offset: 0x00016FAE
		public virtual int GetMaxCertificateChainLength()
		{
			return 10;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00018DB2 File Offset: 0x00016FB2
		public virtual int GetMaxHandshakeMessageSize()
		{
			return 32768;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00018DB9 File Offset: 0x00016FB9
		public virtual short[] GetPskKeyExchangeModes()
		{
			return new short[]
			{
				1
			};
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00018DC5 File Offset: 0x00016FC5
		public virtual bool RequiresCloseNotify()
		{
			return true;
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00018DC8 File Offset: 0x00016FC8
		public virtual bool RequiresExtendedMasterSecret()
		{
			return false;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00018DCB File Offset: 0x00016FCB
		public virtual bool ShouldCheckSigAlgOfPeerCerts()
		{
			return true;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00018DCE File Offset: 0x00016FCE
		public virtual bool ShouldUseExtendedMasterSecret()
		{
			return true;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00018DD1 File Offset: 0x00016FD1
		public virtual bool ShouldUseExtendedPadding()
		{
			return false;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00018DD4 File Offset: 0x00016FD4
		public virtual bool ShouldUseGmtUnixTime()
		{
			return false;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00018DD7 File Offset: 0x00016FD7
		public virtual void NotifySecureRenegotiation(bool secureRenegotiation)
		{
			if (!secureRenegotiation)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00018DE4 File Offset: 0x00016FE4
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchangeFactory GetKeyExchangeFactory()
		{
			return new global::Org.BouncyCastle.Tls.DefaultTlsKeyExchangeFactory();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00018DEB File Offset: 0x00016FEB
		public virtual void NotifyAlertRaised(short alertLevel, short alertDescription, string message, global::System.Exception cause)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00018DED File Offset: 0x00016FED
		public virtual void NotifyAlertReceived(short alertLevel, short alertDescription)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00018DEF File Offset: 0x00016FEF
		public virtual void NotifyHandshakeComplete()
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00018DF1 File Offset: 0x00016FF1
		public virtual global::Org.BouncyCastle.Tls.TlsHeartbeat GetHeartbeat()
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00018DF4 File Offset: 0x00016FF4
		public virtual short GetHeartbeatPolicy()
		{
			return 2;
		}

		// Token: 0x040002F4 RID: 756
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsCrypto m_crypto;

		// Token: 0x040002F5 RID: 757
		private volatile global::Org.BouncyCastle.Tls.TlsCloseable m_closeHandle;
	}
}
