using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E6 RID: 230
	public sealed class SecurityParameters
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x00022710 File Offset: 0x00020910
		internal void Clear()
		{
			this.m_sessionHash = null;
			this.m_sessionID = null;
			this.m_clientCertTypes = null;
			this.m_clientServerNames = null;
			this.m_clientSigAlgs = null;
			this.m_clientSigAlgsCert = null;
			this.m_clientSupportedGroups = null;
			this.m_serverSigAlgs = null;
			this.m_serverSigAlgsCert = null;
			this.m_serverSupportedGroups = null;
			this.m_statusRequestVersion = 0;
			this.m_baseKeyClient = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_baseKeyClient);
			this.m_baseKeyServer = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_baseKeyServer);
			this.m_earlyExporterMasterSecret = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_earlyExporterMasterSecret);
			this.m_earlySecret = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_earlySecret);
			this.m_exporterMasterSecret = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_exporterMasterSecret);
			this.m_handshakeSecret = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_handshakeSecret);
			this.m_masterSecret = global::Org.BouncyCastle.Tls.SecurityParameters.ClearSecret(this.m_masterSecret);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000227E1 File Offset: 0x000209E1
		public global::Org.BouncyCastle.Tls.ProtocolName ApplicationProtocol
		{
			get
			{
				return this.m_applicationProtocol;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000227E9 File Offset: 0x000209E9
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret BaseKeyClient
		{
			get
			{
				return this.m_baseKeyClient;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x000227F1 File Offset: 0x000209F1
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret BaseKeyServer
		{
			get
			{
				return this.m_baseKeyServer;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000227F9 File Offset: 0x000209F9
		public int CipherSuite
		{
			get
			{
				return this.m_cipherSuite;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00022801 File Offset: 0x00020A01
		public short[] ClientCertTypes
		{
			get
			{
				return this.m_clientCertTypes;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00022809 File Offset: 0x00020A09
		public byte[] ClientRandom
		{
			get
			{
				return this.m_clientRandom;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00022811 File Offset: 0x00020A11
		public global::System.Collections.IList ClientServerNames
		{
			get
			{
				return this.m_clientServerNames;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00022819 File Offset: 0x00020A19
		public global::System.Collections.IList ClientSigAlgs
		{
			get
			{
				return this.m_clientSigAlgs;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00022821 File Offset: 0x00020A21
		public global::System.Collections.IList ClientSigAlgsCert
		{
			get
			{
				return this.m_clientSigAlgsCert;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00022829 File Offset: 0x00020A29
		public int[] ClientSupportedGroups
		{
			get
			{
				return this.m_clientSupportedGroups;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00022831 File Offset: 0x00020A31
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret EarlyExporterMasterSecret
		{
			get
			{
				return this.m_earlyExporterMasterSecret;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00022839 File Offset: 0x00020A39
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret EarlySecret
		{
			get
			{
				return this.m_earlySecret;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00022841 File Offset: 0x00020A41
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret ExporterMasterSecret
		{
			get
			{
				return this.m_exporterMasterSecret;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00022849 File Offset: 0x00020A49
		public int Entity
		{
			get
			{
				return this.m_entity;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00022851 File Offset: 0x00020A51
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret HandshakeSecret
		{
			get
			{
				return this.m_handshakeSecret;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00022859 File Offset: 0x00020A59
		public bool IsApplicationProtocolSet
		{
			get
			{
				return this.m_applicationProtocolSet;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00022861 File Offset: 0x00020A61
		public bool IsEncryptThenMac
		{
			get
			{
				return this.m_encryptThenMac;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00022869 File Offset: 0x00020A69
		public bool IsExtendedMasterSecret
		{
			get
			{
				return this.m_extendedMasterSecret;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00022871 File Offset: 0x00020A71
		public bool IsExtendedPadding
		{
			get
			{
				return this.m_extendedPadding;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00022879 File Offset: 0x00020A79
		public bool IsSecureRenegotiation
		{
			get
			{
				return this.m_secureRenegotiation;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00022881 File Offset: 0x00020A81
		public bool IsTruncatedHmac
		{
			get
			{
				return this.m_truncatedHmac;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00022889 File Offset: 0x00020A89
		public int KeyExchangeAlgorithm
		{
			get
			{
				return this.m_keyExchangeAlgorithm;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00022891 File Offset: 0x00020A91
		public global::Org.BouncyCastle.Tls.Certificate LocalCertificate
		{
			get
			{
				return this.m_localCertificate;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00022899 File Offset: 0x00020A99
		public byte[] LocalVerifyData
		{
			get
			{
				return this.m_localVerifyData;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000228A1 File Offset: 0x00020AA1
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret MasterSecret
		{
			get
			{
				return this.m_masterSecret;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x000228A9 File Offset: 0x00020AA9
		public short MaxFragmentLength
		{
			get
			{
				return this.m_maxFragmentLength;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x000228B1 File Offset: 0x00020AB1
		public global::Org.BouncyCastle.Tls.ProtocolVersion NegotiatedVersion
		{
			get
			{
				return this.m_negotiatedVersion;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x000228B9 File Offset: 0x00020AB9
		public global::Org.BouncyCastle.Tls.Certificate PeerCertificate
		{
			get
			{
				return this.m_peerCertificate;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x000228C1 File Offset: 0x00020AC1
		public byte[] PeerVerifyData
		{
			get
			{
				return this.m_peerVerifyData;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000228C9 File Offset: 0x00020AC9
		public int PrfAlgorithm
		{
			get
			{
				return this.m_prfAlgorithm;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x000228D1 File Offset: 0x00020AD1
		public int PrfCryptoHashAlgorithm
		{
			get
			{
				return this.m_prfCryptoHashAlgorithm;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x000228D9 File Offset: 0x00020AD9
		public int PrfHashLength
		{
			get
			{
				return this.m_prfHashLength;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x000228E1 File Offset: 0x00020AE1
		public byte[] PskIdentity
		{
			get
			{
				return this.m_pskIdentity;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000228E9 File Offset: 0x00020AE9
		public byte[] ServerRandom
		{
			get
			{
				return this.m_serverRandom;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x000228F1 File Offset: 0x00020AF1
		public global::System.Collections.IList ServerSigAlgs
		{
			get
			{
				return this.m_serverSigAlgs;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000228F9 File Offset: 0x00020AF9
		public global::System.Collections.IList ServerSigAlgsCert
		{
			get
			{
				return this.m_serverSigAlgsCert;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00022901 File Offset: 0x00020B01
		public int[] ServerSupportedGroups
		{
			get
			{
				return this.m_serverSupportedGroups;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00022909 File Offset: 0x00020B09
		public byte[] SessionHash
		{
			get
			{
				return this.m_sessionHash;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00022911 File Offset: 0x00020B11
		public byte[] SessionID
		{
			get
			{
				return this.m_sessionID;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00022919 File Offset: 0x00020B19
		public byte[] SrpIdentity
		{
			get
			{
				return this.m_srpIdentity;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00022921 File Offset: 0x00020B21
		public int StatusRequestVersion
		{
			get
			{
				return this.m_statusRequestVersion;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00022929 File Offset: 0x00020B29
		public byte[] TlsServerEndPoint
		{
			get
			{
				return this.m_tlsServerEndPoint;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00022931 File Offset: 0x00020B31
		public byte[] TlsUnique
		{
			get
			{
				return this.m_tlsUnique;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00022939 File Offset: 0x00020B39
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret TrafficSecretClient
		{
			get
			{
				return this.m_trafficSecretClient;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00022941 File Offset: 0x00020B41
		public global::Org.BouncyCastle.Tls.Crypto.TlsSecret TrafficSecretServer
		{
			get
			{
				return this.m_trafficSecretServer;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00022949 File Offset: 0x00020B49
		public int VerifyDataLength
		{
			get
			{
				return this.m_verifyDataLength;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00022951 File Offset: 0x00020B51
		private static global::Org.BouncyCastle.Tls.Crypto.TlsSecret ClearSecret(global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret)
		{
			if (secret != null)
			{
				secret.Destroy();
			}
			return null;
		}

		// Token: 0x04000644 RID: 1604
		internal int m_entity = -1;

		// Token: 0x04000645 RID: 1605
		internal bool m_secureRenegotiation;

		// Token: 0x04000646 RID: 1606
		internal int m_cipherSuite;

		// Token: 0x04000647 RID: 1607
		internal short m_maxFragmentLength = -1;

		// Token: 0x04000648 RID: 1608
		internal int m_prfAlgorithm = -1;

		// Token: 0x04000649 RID: 1609
		internal int m_prfCryptoHashAlgorithm = -1;

		// Token: 0x0400064A RID: 1610
		internal int m_prfHashLength = -1;

		// Token: 0x0400064B RID: 1611
		internal int m_verifyDataLength = -1;

		// Token: 0x0400064C RID: 1612
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_baseKeyClient;

		// Token: 0x0400064D RID: 1613
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_baseKeyServer;

		// Token: 0x0400064E RID: 1614
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_earlyExporterMasterSecret;

		// Token: 0x0400064F RID: 1615
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_earlySecret;

		// Token: 0x04000650 RID: 1616
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_exporterMasterSecret;

		// Token: 0x04000651 RID: 1617
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_handshakeSecret;

		// Token: 0x04000652 RID: 1618
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_masterSecret;

		// Token: 0x04000653 RID: 1619
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_trafficSecretClient;

		// Token: 0x04000654 RID: 1620
		internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret m_trafficSecretServer;

		// Token: 0x04000655 RID: 1621
		internal byte[] m_clientRandom;

		// Token: 0x04000656 RID: 1622
		internal byte[] m_serverRandom;

		// Token: 0x04000657 RID: 1623
		internal byte[] m_sessionHash;

		// Token: 0x04000658 RID: 1624
		internal byte[] m_sessionID;

		// Token: 0x04000659 RID: 1625
		internal byte[] m_pskIdentity;

		// Token: 0x0400065A RID: 1626
		internal byte[] m_srpIdentity;

		// Token: 0x0400065B RID: 1627
		internal byte[] m_tlsServerEndPoint;

		// Token: 0x0400065C RID: 1628
		internal byte[] m_tlsUnique;

		// Token: 0x0400065D RID: 1629
		internal bool m_encryptThenMac;

		// Token: 0x0400065E RID: 1630
		internal bool m_extendedMasterSecret;

		// Token: 0x0400065F RID: 1631
		internal bool m_extendedPadding;

		// Token: 0x04000660 RID: 1632
		internal bool m_truncatedHmac;

		// Token: 0x04000661 RID: 1633
		internal global::Org.BouncyCastle.Tls.ProtocolName m_applicationProtocol;

		// Token: 0x04000662 RID: 1634
		internal bool m_applicationProtocolSet;

		// Token: 0x04000663 RID: 1635
		internal short[] m_clientCertTypes;

		// Token: 0x04000664 RID: 1636
		internal global::System.Collections.IList m_clientServerNames;

		// Token: 0x04000665 RID: 1637
		internal global::System.Collections.IList m_clientSigAlgs;

		// Token: 0x04000666 RID: 1638
		internal global::System.Collections.IList m_clientSigAlgsCert;

		// Token: 0x04000667 RID: 1639
		internal int[] m_clientSupportedGroups;

		// Token: 0x04000668 RID: 1640
		internal global::System.Collections.IList m_serverSigAlgs;

		// Token: 0x04000669 RID: 1641
		internal global::System.Collections.IList m_serverSigAlgsCert;

		// Token: 0x0400066A RID: 1642
		internal int[] m_serverSupportedGroups;

		// Token: 0x0400066B RID: 1643
		internal int m_keyExchangeAlgorithm = -1;

		// Token: 0x0400066C RID: 1644
		internal global::Org.BouncyCastle.Tls.Certificate m_localCertificate;

		// Token: 0x0400066D RID: 1645
		internal global::Org.BouncyCastle.Tls.Certificate m_peerCertificate;

		// Token: 0x0400066E RID: 1646
		internal global::Org.BouncyCastle.Tls.ProtocolVersion m_negotiatedVersion;

		// Token: 0x0400066F RID: 1647
		internal int m_statusRequestVersion;

		// Token: 0x04000670 RID: 1648
		internal byte[] m_localVerifyData;

		// Token: 0x04000671 RID: 1649
		internal byte[] m_peerVerifyData;
	}
}
