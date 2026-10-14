using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000EC RID: 236
	public sealed class SessionParameters
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x00022D8C File Offset: 0x00020F8C
		private SessionParameters(int cipherSuite, global::Org.BouncyCastle.Tls.Certificate localCertificate, global::Org.BouncyCastle.Tls.Crypto.TlsSecret masterSecret, global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion, global::Org.BouncyCastle.Tls.Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions, bool extendedMasterSecret)
		{
			this.m_cipherSuite = cipherSuite;
			this.m_localCertificate = localCertificate;
			this.m_masterSecret = masterSecret;
			this.m_negotiatedVersion = negotiatedVersion;
			this.m_peerCertificate = peerCertificate;
			this.m_pskIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(pskIdentity);
			this.m_srpIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(srpIdentity);
			this.m_encodedServerExtensions = encodedServerExtensions;
			this.m_extendedMasterSecret = extendedMasterSecret;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00022DEE File Offset: 0x00020FEE
		public int CipherSuite
		{
			get
			{
				return this.m_cipherSuite;
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00022DF6 File Offset: 0x00020FF6
		public void Clear()
		{
			if (this.m_masterSecret != null)
			{
				this.m_masterSecret.Destroy();
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00022E0C File Offset: 0x0002100C
		public global::Org.BouncyCastle.Tls.SessionParameters Copy()
		{
			return new global::Org.BouncyCastle.Tls.SessionParameters(this.m_cipherSuite, this.m_localCertificate, this.m_masterSecret, this.m_negotiatedVersion, this.m_peerCertificate, this.m_pskIdentity, this.m_srpIdentity, this.m_encodedServerExtensions, this.m_extendedMasterSecret);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00022E54 File Offset: 0x00021054
		public bool IsExtendedMasterSecret
		{
			get
			{
				return this.m_extendedMasterSecret;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00022E5C File Offset: 0x0002105C
		public global::Org.BouncyCastle.Tls.Certificate LocalCertificate
		{
			get
			{
				return this.m_localCertificate;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x00022E64 File Offset: 0x00021064
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret MasterSecret
		{
			get
			{
				return this.m_masterSecret;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00022E6C File Offset: 0x0002106C
		public global::Org.BouncyCastle.Tls.ProtocolVersion NegotiatedVersion
		{
			get
			{
				return this.m_negotiatedVersion;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00022E74 File Offset: 0x00021074
		public global::Org.BouncyCastle.Tls.Certificate PeerCertificate
		{
			get
			{
				return this.m_peerCertificate;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00022E7C File Offset: 0x0002107C
		public byte[] PskIdentity
		{
			get
			{
				return this.m_pskIdentity;
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00022E84 File Offset: 0x00021084
		public global::System.Collections.IDictionary ReadServerExtensions()
		{
			if (this.m_encodedServerExtensions == null)
			{
				return null;
			}
			return global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensions(new global::System.IO.MemoryStream(this.m_encodedServerExtensions, false));
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00022EA1 File Offset: 0x000210A1
		public byte[] SrpIdentity
		{
			get
			{
				return this.m_srpIdentity;
			}
		}

		// Token: 0x0400067F RID: 1663
		private readonly int m_cipherSuite;

		// Token: 0x04000680 RID: 1664
		private readonly global::Org.BouncyCastle.Tls.Certificate m_localCertificate;

		// Token: 0x04000681 RID: 1665
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_masterSecret;

		// Token: 0x04000682 RID: 1666
		private readonly global::Org.BouncyCastle.Tls.ProtocolVersion m_negotiatedVersion;

		// Token: 0x04000683 RID: 1667
		private readonly global::Org.BouncyCastle.Tls.Certificate m_peerCertificate;

		// Token: 0x04000684 RID: 1668
		private readonly byte[] m_pskIdentity;

		// Token: 0x04000685 RID: 1669
		private readonly byte[] m_srpIdentity;

		// Token: 0x04000686 RID: 1670
		private readonly byte[] m_encodedServerExtensions;

		// Token: 0x04000687 RID: 1671
		private readonly bool m_extendedMasterSecret;

		// Token: 0x020007AC RID: 1964
		public sealed class Builder
		{
			// Token: 0x06004523 RID: 17699 RVA: 0x00132A60 File Offset: 0x00130C60
			public global::Org.BouncyCastle.Tls.SessionParameters Build()
			{
				this.Validate(this.m_cipherSuite >= 0, "cipherSuite");
				this.Validate(this.m_masterSecret != null, "masterSecret");
				return new global::Org.BouncyCastle.Tls.SessionParameters(this.m_cipherSuite, this.m_localCertificate, this.m_masterSecret, this.m_negotiatedVersion, this.m_peerCertificate, this.m_pskIdentity, this.m_srpIdentity, this.m_encodedServerExtensions, this.m_extendedMasterSecret);
			}

			// Token: 0x06004524 RID: 17700 RVA: 0x00132AD3 File Offset: 0x00130CD3
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetCipherSuite(int cipherSuite)
			{
				this.m_cipherSuite = cipherSuite;
				return this;
			}

			// Token: 0x06004525 RID: 17701 RVA: 0x00132ADD File Offset: 0x00130CDD
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetExtendedMasterSecret(bool extendedMasterSecret)
			{
				this.m_extendedMasterSecret = extendedMasterSecret;
				return this;
			}

			// Token: 0x06004526 RID: 17702 RVA: 0x00132AE7 File Offset: 0x00130CE7
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetLocalCertificate(global::Org.BouncyCastle.Tls.Certificate localCertificate)
			{
				this.m_localCertificate = localCertificate;
				return this;
			}

			// Token: 0x06004527 RID: 17703 RVA: 0x00132AF1 File Offset: 0x00130CF1
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetMasterSecret(global::Org.BouncyCastle.Tls.Crypto.TlsSecret masterSecret)
			{
				this.m_masterSecret = masterSecret;
				return this;
			}

			// Token: 0x06004528 RID: 17704 RVA: 0x00132AFB File Offset: 0x00130CFB
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetNegotiatedVersion(global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion)
			{
				this.m_negotiatedVersion = negotiatedVersion;
				return this;
			}

			// Token: 0x06004529 RID: 17705 RVA: 0x00132B05 File Offset: 0x00130D05
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetPeerCertificate(global::Org.BouncyCastle.Tls.Certificate peerCertificate)
			{
				this.m_peerCertificate = peerCertificate;
				return this;
			}

			// Token: 0x0600452A RID: 17706 RVA: 0x00132B0F File Offset: 0x00130D0F
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetPskIdentity(byte[] pskIdentity)
			{
				this.m_pskIdentity = pskIdentity;
				return this;
			}

			// Token: 0x0600452B RID: 17707 RVA: 0x00132B19 File Offset: 0x00130D19
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetSrpIdentity(byte[] srpIdentity)
			{
				this.m_srpIdentity = srpIdentity;
				return this;
			}

			// Token: 0x0600452C RID: 17708 RVA: 0x00132B24 File Offset: 0x00130D24
			public global::Org.BouncyCastle.Tls.SessionParameters.Builder SetServerExtensions(global::System.Collections.IDictionary serverExtensions)
			{
				if (serverExtensions == null || serverExtensions.Count < 1)
				{
					this.m_encodedServerExtensions = null;
				}
				else
				{
					global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
					global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensions(buf, serverExtensions);
					this.m_encodedServerExtensions = buf.ToArray();
				}
				return this;
			}

			// Token: 0x0600452D RID: 17709 RVA: 0x00132B60 File Offset: 0x00130D60
			private void Validate(bool condition, string parameter)
			{
				if (!condition)
				{
					throw new global::System.InvalidOperationException("Required session parameter '" + parameter + "' not configured");
				}
			}

			// Token: 0x04002323 RID: 8995
			private int m_cipherSuite = -1;

			// Token: 0x04002324 RID: 8996
			private global::Org.BouncyCastle.Tls.Certificate m_localCertificate;

			// Token: 0x04002325 RID: 8997
			private global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_masterSecret;

			// Token: 0x04002326 RID: 8998
			private global::Org.BouncyCastle.Tls.ProtocolVersion m_negotiatedVersion;

			// Token: 0x04002327 RID: 8999
			private global::Org.BouncyCastle.Tls.Certificate m_peerCertificate;

			// Token: 0x04002328 RID: 9000
			private byte[] m_pskIdentity;

			// Token: 0x04002329 RID: 9001
			private byte[] m_srpIdentity;

			// Token: 0x0400232A RID: 9002
			private byte[] m_encodedServerExtensions;

			// Token: 0x0400232B RID: 9003
			private bool m_extendedMasterSecret;
		}
	}
}
