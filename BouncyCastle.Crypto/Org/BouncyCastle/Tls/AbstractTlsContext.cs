using System;
using System.Threading;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000087 RID: 135
	internal abstract class AbstractTlsContext : global::Org.BouncyCastle.Tls.TlsContext
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x0001880B File Offset: 0x00016A0B
		private static long NextCounterValue()
		{
			return global::System.Threading.Interlocked.Increment(ref global::Org.BouncyCastle.Tls.AbstractTlsContext.counter);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00018818 File Offset: 0x00016A18
		private static global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator CreateNonceGenerator(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int connectionEnd)
		{
			byte[] additionalSeedMaterial = new byte[16];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)global::Org.BouncyCastle.Tls.AbstractTlsContext.NextCounterValue(), additionalSeedMaterial, 0);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)global::Org.BouncyCastle.Utilities.Times.NanoTime(), additionalSeedMaterial, 8);
			byte[] array = additionalSeedMaterial;
			int num = 0;
			array[num] &= 127;
			byte[] array2 = additionalSeedMaterial;
			int num2 = 0;
			array2[num2] |= (byte)(connectionEnd << 7);
			return crypto.CreateNonceGenerator(additionalSeedMaterial);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0001886A File Offset: 0x00016A6A
		internal AbstractTlsContext(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, int connectionEnd)
		{
			this.m_crypto = crypto;
			this.m_connectionEnd = connectionEnd;
			this.m_nonceGenerator = global::Org.BouncyCastle.Tls.AbstractTlsContext.CreateNonceGenerator(crypto, connectionEnd);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00018890 File Offset: 0x00016A90
		internal void HandshakeBeginning(global::Org.BouncyCastle.Tls.TlsPeer peer)
		{
			lock (this)
			{
				if (this.m_securityParameters != null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, "Handshake already started");
				}
				this.m_securityParameters = new global::Org.BouncyCastle.Tls.SecurityParameters();
				this.m_securityParameters.m_entity = this.m_connectionEnd;
			}
			peer.NotifyHandshakeBeginning();
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000188FC File Offset: 0x00016AFC
		internal void HandshakeComplete(global::Org.BouncyCastle.Tls.TlsPeer peer, global::Org.BouncyCastle.Tls.TlsSession session)
		{
			lock (this)
			{
				if (this.m_securityParameters == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				this.m_session = session;
				this.m_connected = true;
			}
			peer.NotifyHandshakeComplete();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00018958 File Offset: 0x00016B58
		internal bool IsConnected
		{
			get
			{
				bool connected;
				lock (this)
				{
					connected = this.m_connected;
				}
				return connected;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00018998 File Offset: 0x00016B98
		internal bool IsHandshaking
		{
			get
			{
				bool result;
				lock (this)
				{
					result = (!this.m_connected && this.m_securityParameters != null);
				}
				return result;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000189E4 File Offset: 0x00016BE4
		public global::Org.BouncyCastle.Tls.Crypto.TlsCrypto Crypto
		{
			get
			{
				return this.m_crypto;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000189EC File Offset: 0x00016BEC
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator NonceGenerator
		{
			get
			{
				return this.m_nonceGenerator;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x000189F4 File Offset: 0x00016BF4
		public global::Org.BouncyCastle.Tls.SecurityParameters SecurityParameters
		{
			get
			{
				global::Org.BouncyCastle.Tls.SecurityParameters securityParameters;
				lock (this)
				{
					securityParameters = this.m_securityParameters;
				}
				return securityParameters;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600057A RID: 1402
		public abstract bool IsServer { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00018A34 File Offset: 0x00016C34
		public virtual global::Org.BouncyCastle.Tls.ProtocolVersion[] ClientSupportedVersions
		{
			get
			{
				return this.m_clientSupportedVersions;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00018A3C File Offset: 0x00016C3C
		internal void SetClientSupportedVersions(global::Org.BouncyCastle.Tls.ProtocolVersion[] clientSupportedVersions)
		{
			this.m_clientSupportedVersions = clientSupportedVersions;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00018A45 File Offset: 0x00016C45
		public virtual global::Org.BouncyCastle.Tls.ProtocolVersion ClientVersion
		{
			get
			{
				return this.m_clientVersion;
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00018A4D File Offset: 0x00016C4D
		internal void SetClientVersion(global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion)
		{
			this.m_clientVersion = clientVersion;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00018A56 File Offset: 0x00016C56
		public virtual global::Org.BouncyCastle.Tls.ProtocolVersion RsaPreMasterSecretVersion
		{
			get
			{
				return this.m_rsaPreMasterSecretVersion;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00018A5E File Offset: 0x00016C5E
		internal void SetRsaPreMasterSecretVersion(global::Org.BouncyCastle.Tls.ProtocolVersion rsaPreMasterSecretVersion)
		{
			this.m_rsaPreMasterSecretVersion = rsaPreMasterSecretVersion;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00018A67 File Offset: 0x00016C67
		public virtual global::Org.BouncyCastle.Tls.ProtocolVersion ServerVersion
		{
			get
			{
				return this.SecurityParameters.NegotiatedVersion;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00018A74 File Offset: 0x00016C74
		public virtual global::Org.BouncyCastle.Tls.TlsSession ResumableSession
		{
			get
			{
				global::Org.BouncyCastle.Tls.TlsSession session = this.Session;
				if (session == null || !session.IsResumable)
				{
					return null;
				}
				return session;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00018A96 File Offset: 0x00016C96
		public virtual global::Org.BouncyCastle.Tls.TlsSession Session
		{
			get
			{
				return this.m_session;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00018A9E File Offset: 0x00016C9E
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00018AA6 File Offset: 0x00016CA6
		public virtual object UserObject
		{
			get
			{
				return this.m_userObject;
			}
			set
			{
				this.m_userObject = value;
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00018AB0 File Offset: 0x00016CB0
		public virtual byte[] ExportChannelBinding(int channelBinding)
		{
			if (!this.IsConnected)
			{
				throw new global::System.InvalidOperationException("Export of channel bindings unavailable before handshake completion");
			}
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.SecurityParameters;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
			{
				return null;
			}
			switch (channelBinding)
			{
			case 0:
			{
				byte[] tlsServerEndPoint = securityParameters.TlsServerEndPoint;
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(tlsServerEndPoint))
				{
					return global::Org.BouncyCastle.Utilities.Arrays.Clone(tlsServerEndPoint);
				}
				return null;
			}
			case 1:
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(securityParameters.TlsUnique);
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00018B24 File Offset: 0x00016D24
		public virtual byte[] ExportEarlyKeyingMaterial(string asciiLabel, byte[] context, int length)
		{
			if (!this.IsConnected)
			{
				throw new global::System.InvalidOperationException("Export of early key material only available during handshake");
			}
			global::Org.BouncyCastle.Tls.SecurityParameters sp = this.SecurityParameters;
			return this.ExportKeyingMaterial13(this.CheckEarlyExportSecret(sp.EarlyExporterMasterSecret), sp.PrfCryptoHashAlgorithm, asciiLabel, context, length);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00018B68 File Offset: 0x00016D68
		public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context, int length)
		{
			if (!this.IsConnected)
			{
				throw new global::System.InvalidOperationException("Export of key material unavailable before handshake completion");
			}
			global::Org.BouncyCastle.Tls.SecurityParameters sp = this.SecurityParameters;
			if (!sp.IsExtendedMasterSecret)
			{
				throw new global::System.InvalidOperationException("Export of key material requires extended_master_secret");
			}
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(sp.NegotiatedVersion))
			{
				return this.ExportKeyingMaterial13(this.CheckExportSecret(sp.ExporterMasterSecret), sp.PrfCryptoHashAlgorithm, asciiLabel, context, length);
			}
			byte[] seed = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateExporterSeed(sp, context);
			return global::Org.BouncyCastle.Tls.TlsUtilities.Prf(sp, this.CheckExportSecret(sp.MasterSecret), asciiLabel, seed, length).Extract();
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00018BED File Offset: 0x00016DED
		protected virtual byte[] ExportKeyingMaterial13(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, int cryptoHashAlgorithm, string asciiLabel, byte[] context, int length)
		{
			if (context == null)
			{
				context = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			}
			else if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidUint16(context.Length))
			{
				throw new global::System.ArgumentException("must have length less than 2^16 (or be null)", "context");
			}
			return global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, asciiLabel, context, length).Extract();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00018C28 File Offset: 0x00016E28
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret CheckEarlyExportSecret(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret)
		{
			if (secret == null)
			{
				throw new global::System.InvalidOperationException("Export of early key material not available for this handshake");
			}
			return secret;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00018C39 File Offset: 0x00016E39
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret CheckExportSecret(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret)
		{
			if (secret == null)
			{
				throw new global::System.InvalidOperationException("Export of key material only available from NotifyHandshakeComplete()");
			}
			return secret;
		}

		// Token: 0x040002E7 RID: 743
		private static long counter = global::Org.BouncyCastle.Utilities.Times.NanoTime();

		// Token: 0x040002E8 RID: 744
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsCrypto m_crypto;

		// Token: 0x040002E9 RID: 745
		private readonly int m_connectionEnd;

		// Token: 0x040002EA RID: 746
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator m_nonceGenerator;

		// Token: 0x040002EB RID: 747
		private global::Org.BouncyCastle.Tls.SecurityParameters m_securityParameters;

		// Token: 0x040002EC RID: 748
		private global::Org.BouncyCastle.Tls.ProtocolVersion[] m_clientSupportedVersions;

		// Token: 0x040002ED RID: 749
		private global::Org.BouncyCastle.Tls.ProtocolVersion m_clientVersion;

		// Token: 0x040002EE RID: 750
		private global::Org.BouncyCastle.Tls.ProtocolVersion m_rsaPreMasterSecretVersion;

		// Token: 0x040002EF RID: 751
		private global::Org.BouncyCastle.Tls.TlsSession m_session;

		// Token: 0x040002F0 RID: 752
		private object m_userObject;

		// Token: 0x040002F1 RID: 753
		private bool m_connected;
	}
}
