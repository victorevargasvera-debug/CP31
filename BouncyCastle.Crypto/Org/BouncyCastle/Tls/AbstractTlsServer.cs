using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200008B RID: 139
	public abstract class AbstractTlsServer : global::Org.BouncyCastle.Tls.AbstractTlsPeer, global::Org.BouncyCastle.Tls.TlsServer, global::Org.BouncyCastle.Tls.TlsPeer
	{
		// Token: 0x060005C9 RID: 1481 RVA: 0x00018DF7 File Offset: 0x00016FF7
		public AbstractTlsServer(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto) : base(crypto)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00018E0B File Offset: 0x0001700B
		protected virtual bool AllowCertificateStatus()
		{
			return true;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00018E0E File Offset: 0x0001700E
		protected virtual bool AllowEncryptThenMac()
		{
			return true;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00018E11 File Offset: 0x00017011
		protected virtual bool AllowMultiCertStatus()
		{
			return false;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00018E14 File Offset: 0x00017014
		protected virtual bool AllowTruncatedHmac()
		{
			return false;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00018E17 File Offset: 0x00017017
		protected virtual bool AllowTrustedCAIndication()
		{
			return false;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00018E1C File Offset: 0x0001701C
		protected virtual int GetMaximumNegotiableCurveBits()
		{
			int[] clientSupportedGroups = this.m_context.SecurityParameters.ClientSupportedGroups;
			if (clientSupportedGroups == null)
			{
				return global::Org.BouncyCastle.Tls.NamedGroup.GetMaximumCurveBits();
			}
			int maxBits = 0;
			for (int i = 0; i < clientSupportedGroups.Length; i++)
			{
				maxBits = global::System.Math.Max(maxBits, global::Org.BouncyCastle.Tls.NamedGroup.GetCurveBits(clientSupportedGroups[i]));
			}
			return maxBits;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00018E64 File Offset: 0x00017064
		protected virtual int GetMaximumNegotiableFiniteFieldBits()
		{
			int[] clientSupportedGroups = this.m_context.SecurityParameters.ClientSupportedGroups;
			if (clientSupportedGroups == null)
			{
				return global::Org.BouncyCastle.Tls.NamedGroup.GetMaximumFiniteFieldBits();
			}
			int maxBits = 0;
			for (int i = 0; i < clientSupportedGroups.Length; i++)
			{
				maxBits = global::System.Math.Max(maxBits, global::Org.BouncyCastle.Tls.NamedGroup.GetFiniteFieldBits(clientSupportedGroups[i]));
			}
			return maxBits;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00018EAB File Offset: 0x000170AB
		protected virtual global::System.Collections.IList GetProtocolNames()
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00018EAE File Offset: 0x000170AE
		protected virtual bool IsSelectableCipherSuite(int cipherSuite, int availCurveBits, int availFiniteFieldBits, global::System.Collections.IList sigAlgs)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, this.m_context.ServerVersion) && availCurveBits >= global::Org.BouncyCastle.Tls.TlsEccUtilities.GetMinimumCurveBits(cipherSuite) && availFiniteFieldBits >= global::Org.BouncyCastle.Tls.TlsDHUtilities.GetMinimumFiniteFieldBits(cipherSuite) && global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteForSignatureAlgorithms(cipherSuite, sigAlgs);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00018EDF File Offset: 0x000170DF
		protected virtual bool PreferLocalCipherSuites()
		{
			return false;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00018EE2 File Offset: 0x000170E2
		protected virtual bool SelectCipherSuite(int cipherSuite)
		{
			this.m_selectedCipherSuite = cipherSuite;
			return true;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00018EEC File Offset: 0x000170EC
		protected virtual int SelectDH(int minimumFiniteFieldBits)
		{
			int[] clientSupportedGroups = this.m_context.SecurityParameters.ClientSupportedGroups;
			if (clientSupportedGroups == null)
			{
				return this.SelectDHDefault(minimumFiniteFieldBits);
			}
			foreach (int namedGroup in clientSupportedGroups)
			{
				if (global::Org.BouncyCastle.Tls.NamedGroup.GetFiniteFieldBits(namedGroup) >= minimumFiniteFieldBits)
				{
					return namedGroup;
				}
			}
			return -1;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00018F34 File Offset: 0x00017134
		protected virtual int SelectDHDefault(int minimumFiniteFieldBits)
		{
			if (minimumFiniteFieldBits <= 2048)
			{
				return 256;
			}
			if (minimumFiniteFieldBits <= 3072)
			{
				return 257;
			}
			if (minimumFiniteFieldBits <= 4096)
			{
				return 258;
			}
			if (minimumFiniteFieldBits <= 6144)
			{
				return 259;
			}
			if (minimumFiniteFieldBits > 8192)
			{
				return -1;
			}
			return 260;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00018F88 File Offset: 0x00017188
		protected virtual int SelectECDH(int minimumCurveBits)
		{
			int[] clientSupportedGroups = this.m_context.SecurityParameters.ClientSupportedGroups;
			if (clientSupportedGroups == null)
			{
				return this.SelectECDHDefault(minimumCurveBits);
			}
			foreach (int namedGroup in clientSupportedGroups)
			{
				if (global::Org.BouncyCastle.Tls.NamedGroup.GetCurveBits(namedGroup) >= minimumCurveBits)
				{
					return namedGroup;
				}
			}
			return -1;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00018FCF File Offset: 0x000171CF
		protected virtual int SelectECDHDefault(int minimumCurveBits)
		{
			if (minimumCurveBits <= 256)
			{
				return 23;
			}
			if (minimumCurveBits <= 384)
			{
				return 24;
			}
			if (minimumCurveBits > 521)
			{
				return -1;
			}
			return 25;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00018FF4 File Offset: 0x000171F4
		protected virtual global::Org.BouncyCastle.Tls.ProtocolName SelectProtocolName()
		{
			global::System.Collections.IList serverProtocolNames = this.GetProtocolNames();
			if (serverProtocolNames == null || serverProtocolNames.Count < 1)
			{
				return null;
			}
			global::Org.BouncyCastle.Tls.ProtocolName result = this.SelectProtocolName(this.m_clientProtocolNames, serverProtocolNames);
			if (result == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(120);
			}
			return result;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00019030 File Offset: 0x00017230
		protected virtual global::Org.BouncyCastle.Tls.ProtocolName SelectProtocolName(global::System.Collections.IList clientProtocolNames, global::System.Collections.IList serverProtocolNames)
		{
			foreach (object obj in serverProtocolNames)
			{
				global::Org.BouncyCastle.Tls.ProtocolName serverProtocolName = (global::Org.BouncyCastle.Tls.ProtocolName)obj;
				if (clientProtocolNames.Contains(serverProtocolName))
				{
					return serverProtocolName;
				}
			}
			return null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00019090 File Offset: 0x00017290
		protected virtual bool ShouldSelectProtocolNameEarly()
		{
			return true;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00019093 File Offset: 0x00017293
		public virtual void Init(global::Org.BouncyCastle.Tls.TlsServerContext context)
		{
			this.m_context = context;
			this.m_protocolVersions = this.GetSupportedVersions();
			this.m_cipherSuites = this.GetSupportedCipherSuites();
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x000190B4 File Offset: 0x000172B4
		public override global::Org.BouncyCastle.Tls.ProtocolVersion[] GetProtocolVersions()
		{
			return this.m_protocolVersions;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x000190BC File Offset: 0x000172BC
		public override int[] GetCipherSuites()
		{
			return this.m_cipherSuites;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000190C4 File Offset: 0x000172C4
		public override void NotifyHandshakeBeginning()
		{
			base.NotifyHandshakeBeginning();
			this.m_offeredCipherSuites = null;
			this.m_clientExtensions = null;
			this.m_encryptThenMACOffered = false;
			this.m_maxFragmentLengthOffered = 0;
			this.m_truncatedHMacOffered = false;
			this.m_clientSentECPointFormats = false;
			this.m_certificateStatusRequest = null;
			this.m_selectedCipherSuite = -1;
			this.m_selectedProtocolName = null;
			this.m_serverExtensions.Clear();
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00019121 File Offset: 0x00017321
		public virtual global::Org.BouncyCastle.Tls.TlsSession GetSessionToResume(byte[] sessionID)
		{
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00019124 File Offset: 0x00017324
		public virtual byte[] GetNewSessionID()
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00019127 File Offset: 0x00017327
		public virtual global::Org.BouncyCastle.Tls.TlsPskExternal GetExternalPsk(global::System.Collections.IList identities)
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0001912A File Offset: 0x0001732A
		public virtual void NotifySession(global::Org.BouncyCastle.Tls.TlsSession session)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0001912C File Offset: 0x0001732C
		public virtual void NotifyClientVersion(global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion)
		{
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00019130 File Offset: 0x00017330
		public virtual void NotifyFallback(bool isFallback)
		{
			if (isFallback)
			{
				global::Org.BouncyCastle.Tls.ProtocolVersion[] serverVersions = this.GetProtocolVersions();
				global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion = this.m_context.ClientVersion;
				global::Org.BouncyCastle.Tls.ProtocolVersion latestServerVersion;
				if (clientVersion.IsTls)
				{
					latestServerVersion = global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestTls(serverVersions);
				}
				else
				{
					if (!clientVersion.IsDtls)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
					latestServerVersion = global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestDtls(serverVersions);
				}
				if (latestServerVersion != null && latestServerVersion.IsLaterVersionOf(clientVersion))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(86);
				}
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00019191 File Offset: 0x00017391
		public virtual void NotifyOfferedCipherSuites(int[] offeredCipherSuites)
		{
			this.m_offeredCipherSuites = offeredCipherSuites;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001919C File Offset: 0x0001739C
		public virtual void ProcessClientExtensions(global::System.Collections.IDictionary clientExtensions)
		{
			this.m_clientExtensions = clientExtensions;
			if (clientExtensions != null)
			{
				this.m_clientProtocolNames = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionClient(clientExtensions);
				if (this.ShouldSelectProtocolNameEarly() && this.m_clientProtocolNames != null && this.m_clientProtocolNames.Count > 0)
				{
					this.m_selectedProtocolName = this.SelectProtocolName();
				}
				this.m_encryptThenMACOffered = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(clientExtensions);
				this.m_truncatedHMacOffered = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasTruncatedHmacExtension(clientExtensions);
				this.m_statusRequestV2 = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetStatusRequestV2Extension(clientExtensions);
				this.m_trustedCAKeys = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetTrustedCAKeysExtensionClient(clientExtensions);
				this.m_clientSentECPointFormats = (global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedPointFormatsExtension(clientExtensions) != null);
				this.m_certificateStatusRequest = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetStatusRequestExtension(clientExtensions);
				this.m_maxFragmentLengthOffered = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions);
				if (this.m_maxFragmentLengthOffered >= 0 && !global::Org.BouncyCastle.Tls.MaxFragmentLength.IsValid(this.m_maxFragmentLengthOffered))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00019264 File Offset: 0x00017464
		public virtual global::Org.BouncyCastle.Tls.ProtocolVersion GetServerVersion()
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion[] serverVersions = this.GetProtocolVersions();
			foreach (global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion in this.m_context.ClientSupportedVersions)
			{
				if (global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(serverVersions, clientVersion))
				{
					return clientVersion;
				}
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(70);
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000192A8 File Offset: 0x000174A8
		public virtual int[] GetSupportedGroups()
		{
			return new int[]
			{
				29,
				30,
				23,
				24,
				256,
				257,
				258
			};
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000192BC File Offset: 0x000174BC
		public virtual int GetSelectedCipherSuite()
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_context.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				int commonCipherSuite13 = global::Org.BouncyCastle.Tls.TlsUtilities.GetCommonCipherSuite13(negotiatedVersion, this.m_offeredCipherSuites, this.GetCipherSuites(), this.PreferLocalCipherSuites());
				if (commonCipherSuite13 >= 0 && this.SelectCipherSuite(commonCipherSuite13))
				{
					return commonCipherSuite13;
				}
			}
			else
			{
				global::System.Collections.IList sigAlgs = global::Org.BouncyCastle.Tls.TlsUtilities.GetUsableSignatureAlgorithms(securityParameters.ClientSigAlgs);
				int availCurveBits = this.GetMaximumNegotiableCurveBits();
				int availFiniteFieldBits = this.GetMaximumNegotiableFiniteFieldBits();
				foreach (int cipherSuite in global::Org.BouncyCastle.Tls.TlsUtilities.GetCommonCipherSuites(this.m_offeredCipherSuites, this.GetCipherSuites(), this.PreferLocalCipherSuites()))
				{
					if (this.IsSelectableCipherSuite(cipherSuite, availCurveBits, availFiniteFieldBits, sigAlgs) && this.SelectCipherSuite(cipherSuite))
					{
						return cipherSuite;
					}
				}
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40, "No selectable cipher suite");
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00019384 File Offset: 0x00017584
		public virtual global::System.Collections.IDictionary GetServerExtensions()
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(this.m_context))
			{
				if (this.m_certificateStatusRequest != null && this.AllowCertificateStatus())
				{
				}
			}
			else
			{
				if (this.m_encryptThenMACOffered && this.AllowEncryptThenMac() && global::Org.BouncyCastle.Tls.TlsUtilities.IsBlockCipherSuite(this.m_selectedCipherSuite))
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddEncryptThenMacExtension(this.m_serverExtensions);
				}
				if (this.m_truncatedHMacOffered && this.AllowTruncatedHmac())
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddTruncatedHmacExtension(this.m_serverExtensions);
				}
				if (this.m_clientSentECPointFormats && global::Org.BouncyCastle.Tls.TlsEccUtilities.IsEccCipherSuite(this.m_selectedCipherSuite))
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedPointFormatsExtension(this.m_serverExtensions, new short[1]);
				}
				if (this.m_statusRequestV2 != null && this.AllowMultiCertStatus())
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddEmptyExtensionData(this.m_serverExtensions, 17);
				}
				else if (this.m_certificateStatusRequest != null && this.AllowCertificateStatus())
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddEmptyExtensionData(this.m_serverExtensions, 5);
				}
				if (this.m_trustedCAKeys != null && this.AllowTrustedCAIndication())
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddTrustedCAKeysExtensionServer(this.m_serverExtensions);
				}
			}
			if (this.m_maxFragmentLengthOffered >= 0 && global::Org.BouncyCastle.Tls.MaxFragmentLength.IsValid(this.m_maxFragmentLengthOffered))
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddMaxFragmentLengthExtension(this.m_serverExtensions, this.m_maxFragmentLengthOffered);
			}
			return this.m_serverExtensions;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000194A8 File Offset: 0x000176A8
		public virtual void GetServerExtensionsForConnection(global::System.Collections.IDictionary serverExtensions)
		{
			if (!this.ShouldSelectProtocolNameEarly() && this.m_clientProtocolNames != null && this.m_clientProtocolNames.Count > 0)
			{
				this.m_selectedProtocolName = this.SelectProtocolName();
			}
			if (this.m_selectedProtocolName == null)
			{
				serverExtensions.Remove(16);
				return;
			}
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddAlpnExtensionServer(serverExtensions, this.m_selectedProtocolName);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00019501 File Offset: 0x00017701
		public virtual global::System.Collections.IList GetServerSupplementalData()
		{
			return null;
		}

		// Token: 0x060005EE RID: 1518
		public abstract global::Org.BouncyCastle.Tls.TlsCredentials GetCredentials();

		// Token: 0x060005EF RID: 1519 RVA: 0x00019504 File Offset: 0x00017704
		public virtual global::Org.BouncyCastle.Tls.CertificateStatus GetCertificateStatus()
		{
			return null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00019507 File Offset: 0x00017707
		public virtual global::Org.BouncyCastle.Tls.CertificateRequest GetCertificateRequest()
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0001950A File Offset: 0x0001770A
		public virtual global::Org.BouncyCastle.Tls.TlsPskIdentityManager GetPskIdentityManager()
		{
			return null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0001950D File Offset: 0x0001770D
		public virtual global::Org.BouncyCastle.Tls.TlsSrpLoginParameters GetSrpLoginParameters()
		{
			return null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00019510 File Offset: 0x00017710
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig GetDHConfig()
		{
			int minimumFiniteFieldBits = global::Org.BouncyCastle.Tls.TlsDHUtilities.GetMinimumFiniteFieldBits(this.m_selectedCipherSuite);
			int namedGroup = this.SelectDH(minimumFiniteFieldBits);
			return global::Org.BouncyCastle.Tls.TlsDHUtilities.CreateNamedDHConfig(this.m_context, namedGroup);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00019540 File Offset: 0x00017740
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsECConfig GetECDHConfig()
		{
			int minimumCurveBits = global::Org.BouncyCastle.Tls.TlsEccUtilities.GetMinimumCurveBits(this.m_selectedCipherSuite);
			int namedGroup = this.SelectECDH(minimumCurveBits);
			return global::Org.BouncyCastle.Tls.TlsEccUtilities.CreateNamedECConfig(this.m_context, namedGroup);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001956D File Offset: 0x0001776D
		public virtual void ProcessClientSupplementalData(global::System.Collections.IList clientSupplementalData)
		{
			if (clientSupplementalData != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001957A File Offset: 0x0001777A
		public virtual void NotifyClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00019583 File Offset: 0x00017783
		public virtual global::Org.BouncyCastle.Tls.NewSessionTicket GetNewSessionTicket()
		{
			return new global::Org.BouncyCastle.Tls.NewSessionTicket(0L, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
		}

		// Token: 0x040002F6 RID: 758
		protected global::Org.BouncyCastle.Tls.TlsServerContext m_context;

		// Token: 0x040002F7 RID: 759
		protected global::Org.BouncyCastle.Tls.ProtocolVersion[] m_protocolVersions;

		// Token: 0x040002F8 RID: 760
		protected int[] m_cipherSuites;

		// Token: 0x040002F9 RID: 761
		protected int[] m_offeredCipherSuites;

		// Token: 0x040002FA RID: 762
		protected global::System.Collections.IDictionary m_clientExtensions;

		// Token: 0x040002FB RID: 763
		protected bool m_encryptThenMACOffered;

		// Token: 0x040002FC RID: 764
		protected short m_maxFragmentLengthOffered;

		// Token: 0x040002FD RID: 765
		protected bool m_truncatedHMacOffered;

		// Token: 0x040002FE RID: 766
		protected bool m_clientSentECPointFormats;

		// Token: 0x040002FF RID: 767
		protected global::Org.BouncyCastle.Tls.CertificateStatusRequest m_certificateStatusRequest;

		// Token: 0x04000300 RID: 768
		protected global::System.Collections.IList m_statusRequestV2;

		// Token: 0x04000301 RID: 769
		protected global::System.Collections.IList m_trustedCAKeys;

		// Token: 0x04000302 RID: 770
		protected int m_selectedCipherSuite;

		// Token: 0x04000303 RID: 771
		protected global::System.Collections.IList m_clientProtocolNames;

		// Token: 0x04000304 RID: 772
		protected global::Org.BouncyCastle.Tls.ProtocolName m_selectedProtocolName;

		// Token: 0x04000305 RID: 773
		protected readonly global::System.Collections.IDictionary m_serverExtensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
