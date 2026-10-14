using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000123 RID: 291
	public class TlsServerProtocol : global::Org.BouncyCastle.Tls.TlsProtocol
	{
		// Token: 0x06000B35 RID: 2869 RVA: 0x00029BD1 File Offset: 0x00027DD1
		public TlsServerProtocol()
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00029BD9 File Offset: 0x00027DD9
		public TlsServerProtocol(global::System.IO.Stream stream) : base(stream)
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00029BE2 File Offset: 0x00027DE2
		public TlsServerProtocol(global::System.IO.Stream input, global::System.IO.Stream output) : base(input, output)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00029BEC File Offset: 0x00027DEC
		public void Accept(global::Org.BouncyCastle.Tls.TlsServer tlsServer)
		{
			if (tlsServer == null)
			{
				throw new global::System.ArgumentNullException("tlsServer");
			}
			if (this.m_tlsServer != null)
			{
				throw new global::System.InvalidOperationException("'Accept' can only be called once");
			}
			this.m_tlsServer = tlsServer;
			this.m_tlsServerContext = new global::Org.BouncyCastle.Tls.TlsServerContextImpl(tlsServer.Crypto);
			tlsServer.Init(this.m_tlsServerContext);
			tlsServer.NotifyCloseHandle(this);
			this.BeginHandshake();
			if (this.m_blocking)
			{
				this.BlockForHandshake();
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00029C59 File Offset: 0x00027E59
		protected override void CleanupHandshake()
		{
			base.CleanupHandshake();
			this.m_offeredCipherSuites = null;
			this.m_keyExchange = null;
			this.m_certificateRequest = null;
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00029C78 File Offset: 0x00027E78
		protected virtual bool ExpectCertificateVerifyMessage()
		{
			if (this.m_certificateRequest == null)
			{
				return false;
			}
			global::Org.BouncyCastle.Tls.Certificate clientCertificate = this.m_tlsServerContext.SecurityParameters.PeerCertificate;
			return clientCertificate != null && !clientCertificate.IsEmpty && (this.m_keyExchange == null || this.m_keyExchange.RequiresCertificateVerify);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00029CC4 File Offset: 0x00027EC4
		protected virtual global::Org.BouncyCastle.Tls.ServerHello Generate13HelloRetryRequest(global::Org.BouncyCastle.Tls.ClientHello clientHello)
		{
			if (this.m_retryGroup < 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsServerContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion serverVersion = securityParameters.NegotiatedVersion;
			global::System.Collections.IDictionary serverHelloExtensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(serverHelloExtensions, serverVersion);
			if (this.m_retryGroup >= 0)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddKeyShareHelloRetryRequest(serverHelloExtensions, this.m_retryGroup);
			}
			if (this.m_retryCookie != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddCookieExtension(serverHelloExtensions, this.m_retryCookie);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckExtensionData13(serverHelloExtensions, 6, 80);
			return new global::Org.BouncyCastle.Tls.ServerHello(clientHello.SessionID, securityParameters.CipherSuite, serverHelloExtensions);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00029D48 File Offset: 0x00027F48
		protected virtual global::Org.BouncyCastle.Tls.ServerHello Generate13ServerHello(global::Org.BouncyCastle.Tls.ClientHello clientHello, global::Org.BouncyCastle.Tls.HandshakeMessageInput clientHelloMessage, bool afterHelloRetryRequest)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsServerContext.SecurityParameters;
			byte[] legacy_session_id = clientHello.SessionID;
			global::System.Collections.IDictionary clientHelloExtensions = clientHello.Extensions;
			if (clientHelloExtensions == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(109);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion serverVersion = securityParameters.NegotiatedVersion;
			global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto = this.m_tlsServerContext.Crypto;
			global::Org.BouncyCastle.Tls.OfferedPsks.SelectedConfig selectedPsk = global::Org.BouncyCastle.Tls.TlsUtilities.SelectPreSharedKey(this.m_tlsServerContext, this.m_tlsServer, clientHelloExtensions, clientHelloMessage, this.m_handshakeHash, afterHelloRetryRequest);
			global::System.Collections.IList clientShares = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetKeyShareClientHello(clientHelloExtensions);
			global::Org.BouncyCastle.Tls.KeyShareEntry clientShare;
			if (afterHelloRetryRequest)
			{
				if (this.m_retryGroup < 0)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				if (selectedPsk == null)
				{
					if (securityParameters.ClientSigAlgs == null)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(109);
					}
				}
				else if (selectedPsk.m_psk.PrfAlgorithm != securityParameters.PrfAlgorithm)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				byte[] cookie = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetCookieExtension(clientHelloExtensions);
				if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.m_retryCookie, cookie))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				this.m_retryCookie = null;
				clientShare = global::Org.BouncyCastle.Tls.TlsUtilities.SelectKeyShare(clientShares, this.m_retryGroup);
				if (clientShare == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
			}
			else
			{
				this.m_clientExtensions = clientHelloExtensions;
				securityParameters.m_secureRenegotiation = false;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetPaddingExtension(clientHelloExtensions);
				securityParameters.m_clientServerNames = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetServerNameExtensionClient(clientHelloExtensions);
				global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientSigAlgs(securityParameters, clientHelloExtensions);
				if (selectedPsk == null && securityParameters.ClientSigAlgs == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(109);
				}
				this.m_tlsServer.ProcessClientExtensions(clientHelloExtensions);
				this.m_tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, null);
				this.m_sessionParameters = null;
				this.m_sessionMasterSecret = null;
				securityParameters.m_sessionID = this.m_tlsSession.SessionID;
				this.m_tlsServer.NotifySession(this.m_tlsSession);
				global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersionTlsServer(this.m_tlsServerContext);
				securityParameters.m_serverRandom = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRandomBlock(false, this.m_tlsServerContext);
				if (!serverVersion.Equals(global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestTls(this.m_tlsServer.GetProtocolVersions())))
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteDowngradeMarker(serverVersion, securityParameters.ServerRandom);
				}
				int cipherSuite = this.m_tlsServer.GetSelectedCipherSuite();
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(this.m_offeredCipherSuites, cipherSuite) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, serverVersion))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
				int[] clientSupportedGroups = securityParameters.ClientSupportedGroups;
				int[] serverSupportedGroups = securityParameters.ServerSupportedGroups;
				clientShare = global::Org.BouncyCastle.Tls.TlsUtilities.SelectKeyShare(crypto, serverVersion, clientShares, clientSupportedGroups, serverSupportedGroups);
				if (clientShare == null)
				{
					this.m_retryGroup = global::Org.BouncyCastle.Tls.TlsUtilities.SelectKeyShareGroup(crypto, serverVersion, clientSupportedGroups, serverSupportedGroups);
					if (this.m_retryGroup < 0)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
					}
					this.m_retryCookie = this.m_tlsServerContext.NonceGenerator.GenerateNonce(16);
					return this.Generate13HelloRetryRequest(clientHello);
				}
				else
				{
					int namedGroup2 = clientShare.NamedGroup;
					int num = serverSupportedGroups[0];
				}
			}
			global::System.Collections.IDictionary serverHelloExtensions = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			global::System.Collections.IDictionary serverEncryptedExtensions = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(this.m_tlsServer.GetServerExtensions());
			this.m_tlsServer.GetServerExtensionsForConnection(serverEncryptedExtensions);
			global::Org.BouncyCastle.Tls.ProtocolVersion tlsv = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(serverHelloExtensions, serverVersion);
			securityParameters.m_extendedMasterSecret = true;
			securityParameters.m_applicationProtocol = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionServer(serverEncryptedExtensions);
			securityParameters.m_applicationProtocolSet = true;
			if (serverEncryptedExtensions.Count > 0)
			{
				securityParameters.m_maxFragmentLength = this.ProcessMaxFragmentLengthExtension(clientHelloExtensions, serverEncryptedExtensions, 80);
			}
			securityParameters.m_encryptThenMac = false;
			securityParameters.m_truncatedHmac = false;
			securityParameters.m_statusRequestVersion = (clientHelloExtensions.Contains(5) ? 1 : 0);
			this.m_expectSessionTicket = false;
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret pskEarlySecret = null;
			if (selectedPsk != null)
			{
				pskEarlySecret = selectedPsk.m_earlySecret;
				this.m_selectedPsk13 = true;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddPreSharedKeyServerHello(serverHelloExtensions, selectedPsk.m_index);
			}
			int namedGroup = clientShare.NamedGroup;
			global::Org.BouncyCastle.Tls.Crypto.TlsAgreement agreement;
			if (global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup))
			{
				agreement = crypto.CreateECDomain(new global::Org.BouncyCastle.Tls.Crypto.TlsECConfig(namedGroup)).CreateECDH();
			}
			else
			{
				if (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificFiniteField(namedGroup))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				agreement = crypto.CreateDHDomain(new global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig(namedGroup, true)).CreateDH();
			}
			byte[] key_exchange = agreement.GenerateEphemeral();
			global::Org.BouncyCastle.Tls.KeyShareEntry serverShare = new global::Org.BouncyCastle.Tls.KeyShareEntry(namedGroup, key_exchange);
			global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddKeyShareServerHello(serverHelloExtensions, serverShare);
			agreement.ReceivePeerValue(clientShare.KeyExchange);
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret sharedSecret = agreement.CalculateSecret();
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13PhaseSecrets(this.m_tlsServerContext, pskEarlySecret, sharedSecret);
			this.m_serverExtensions = serverEncryptedExtensions;
			this.ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckExtensionData13(serverHelloExtensions, 2, 80);
			return new global::Org.BouncyCastle.Tls.ServerHello(tlsv, securityParameters.ServerRandom, legacy_session_id, securityParameters.CipherSuite, serverHelloExtensions);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002A138 File Offset: 0x00028338
		protected virtual global::Org.BouncyCastle.Tls.ServerHello GenerateServerHello(global::Org.BouncyCastle.Tls.ClientHello clientHello, global::Org.BouncyCastle.Tls.HandshakeMessageInput clientHelloMessage)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion clientLegacyVersion = clientHello.Version;
			if (!clientLegacyVersion.IsTls)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			this.m_offeredCipherSuites = clientHello.CipherSuites;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsServerContext.SecurityParameters;
			this.m_tlsServerContext.SetClientSupportedVersions(global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedVersionsExtensionClient(clientHello.Extensions));
			global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion = clientLegacyVersion;
			if (this.m_tlsServerContext.ClientSupportedVersions == null)
			{
				if (clientVersion.IsLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12))
				{
					clientVersion = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
				}
				this.m_tlsServerContext.SetClientSupportedVersions(clientVersion.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3));
			}
			else
			{
				clientVersion = global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestTls(this.m_tlsServerContext.ClientSupportedVersions);
			}
			this.m_recordStream.SetWriteVersion(clientVersion);
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.SERVER_EARLIEST_SUPPORTED_TLS.IsEqualOrEarlierVersionOf(clientVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(70);
			}
			this.m_tlsServerContext.SetClientVersion(clientVersion);
			this.m_tlsServer.NotifyClientVersion(this.m_tlsServerContext.ClientVersion);
			securityParameters.m_clientRandom = clientHello.Random;
			this.m_tlsServer.NotifyFallback(global::Org.BouncyCastle.Utilities.Arrays.Contains(this.m_offeredCipherSuites, 22016));
			this.m_tlsServer.NotifyOfferedCipherSuites(this.m_offeredCipherSuites);
			global::Org.BouncyCastle.Tls.ProtocolVersion serverVersion = this.m_tlsServer.GetServerVersion();
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(this.m_tlsServerContext.ClientSupportedVersions, serverVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			securityParameters.m_negotiatedVersion = serverVersion;
			securityParameters.m_clientSupportedGroups = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedGroupsExtension(clientHello.Extensions);
			securityParameters.m_serverSupportedGroups = this.m_tlsServer.GetSupportedGroups();
			if (global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(serverVersion))
			{
				this.m_recordStream.SetIgnoreChangeCipherSpec(true);
				this.m_recordStream.SetWriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12);
				return this.Generate13ServerHello(clientHello, clientHelloMessage, false);
			}
			this.m_recordStream.SetWriteVersion(serverVersion);
			this.m_clientExtensions = clientHello.Extensions;
			byte[] clientRenegExtData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_clientExtensions, 65281);
			if (global::Org.BouncyCastle.Utilities.Arrays.Contains(this.m_offeredCipherSuites, 255))
			{
				securityParameters.m_secureRenegotiation = true;
			}
			if (clientRenegExtData != null)
			{
				securityParameters.m_secureRenegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(clientRenegExtData, global::Org.BouncyCastle.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
			}
			this.m_tlsServer.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
			bool offeredExtendedMasterSecret = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(this.m_clientExtensions);
			if (this.m_clientExtensions != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetPaddingExtension(this.m_clientExtensions);
				securityParameters.m_clientServerNames = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetServerNameExtensionClient(this.m_clientExtensions);
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(clientVersion))
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientSigAlgs(securityParameters, this.m_clientExtensions);
				}
				securityParameters.m_clientSupportedGroups = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedGroupsExtension(this.m_clientExtensions);
				this.m_tlsServer.ProcessClientExtensions(this.m_clientExtensions);
			}
			this.m_resumedSession = this.EstablishSession(this.m_tlsServer.GetSessionToResume(clientHello.SessionID));
			if (!this.m_resumedSession)
			{
				byte[] newSessionID = this.m_tlsServer.GetNewSessionID();
				if (newSessionID == null)
				{
					newSessionID = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
				}
				this.m_tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(newSessionID, null);
				this.m_sessionParameters = null;
				this.m_sessionMasterSecret = null;
			}
			securityParameters.m_sessionID = this.m_tlsSession.SessionID;
			this.m_tlsServer.NotifySession(this.m_tlsSession);
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersionTlsServer(this.m_tlsServerContext);
			bool useGmtUnixTime = this.m_tlsServer.ShouldUseGmtUnixTime();
			securityParameters.m_serverRandom = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRandomBlock(useGmtUnixTime, this.m_tlsServerContext);
			if (!serverVersion.Equals(global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestTls(this.m_tlsServer.GetProtocolVersions())))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteDowngradeMarker(serverVersion, securityParameters.ServerRandom);
			}
			int cipherSuite = this.m_resumedSession ? this.m_sessionParameters.CipherSuite : this.m_tlsServer.GetSelectedCipherSuite();
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(this.m_offeredCipherSuites, cipherSuite) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, serverVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			this.m_tlsServerContext.SetRsaPreMasterSecretVersion(clientLegacyVersion);
			global::System.Collections.IDictionary sessionServerExtensions = this.m_resumedSession ? this.m_sessionParameters.ReadServerExtensions() : this.m_tlsServer.GetServerExtensions();
			this.m_serverExtensions = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(sessionServerExtensions);
			this.m_tlsServer.GetServerExtensionsForConnection(this.m_serverExtensions);
			if (securityParameters.IsSecureRenegotiation)
			{
				byte[] serverRenegExtData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_serverExtensions, 65281);
				if (serverRenegExtData == null)
				{
					this.m_serverExtensions[65281] = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
				}
			}
			if (this.m_resumedSession)
			{
				if (!this.m_sessionParameters.IsExtendedMasterSecret)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				if (!offeredExtendedMasterSecret)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
				securityParameters.m_extendedMasterSecret = true;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(this.m_serverExtensions);
			}
			else
			{
				securityParameters.m_extendedMasterSecret = (offeredExtendedMasterSecret && !serverVersion.IsSsl && this.m_tlsServer.ShouldUseExtendedMasterSecret());
				if (securityParameters.IsExtendedMasterSecret)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(this.m_serverExtensions);
				}
				else if (this.m_tlsServer.RequiresExtendedMasterSecret())
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
			}
			securityParameters.m_applicationProtocol = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionServer(this.m_serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			if (this.m_serverExtensions.Count > 0)
			{
				securityParameters.m_encryptThenMac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(this.m_serverExtensions);
				securityParameters.m_maxFragmentLength = this.ProcessMaxFragmentLengthExtension(this.m_clientExtensions, this.m_serverExtensions, 80);
				securityParameters.m_truncatedHmac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasTruncatedHmacExtension(this.m_serverExtensions);
				if (!this.m_resumedSession)
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(this.m_serverExtensions, 17, 80))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(this.m_serverExtensions, 5, 80))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
					this.m_expectSessionTicket = global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(this.m_serverExtensions, 35, 80);
				}
			}
			this.ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
			return new global::Org.BouncyCastle.Tls.ServerHello(serverVersion, securityParameters.ServerRandom, this.m_tlsSession.SessionID, securityParameters.CipherSuite, this.m_serverExtensions);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0002A6BF File Offset: 0x000288BF
		protected override global::Org.BouncyCastle.Tls.TlsContext Context
		{
			get
			{
				return this.m_tlsServerContext;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0002A6C7 File Offset: 0x000288C7
		internal override global::Org.BouncyCastle.Tls.AbstractTlsContext ContextAdmin
		{
			get
			{
				return this.m_tlsServerContext;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0002A6CF File Offset: 0x000288CF
		protected override global::Org.BouncyCastle.Tls.TlsPeer Peer
		{
			get
			{
				return this.m_tlsServer;
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002A6D8 File Offset: 0x000288D8
		protected virtual void Handle13HandshakeMessage(short type, global::Org.BouncyCastle.Tls.HandshakeMessageInput buf)
		{
			if (!base.IsTlsV13ConnectionState())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (this.m_resumedSession)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			switch (type)
			{
			case 0:
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 12:
			case 13:
			case 14:
			case 16:
			case 17:
			case 18:
			case 19:
			case 21:
			case 22:
			case 23:
				break;
			case 1:
			{
				short connectionState = this.m_connectionState;
				if (connectionState == 0)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				if (connectionState != 2)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				global::Org.BouncyCastle.Tls.ClientHello clientHelloRetry = this.ReceiveClientHelloMessage(buf);
				this.m_connectionState = 3;
				global::Org.BouncyCastle.Tls.ServerHello serverHello = this.Generate13ServerHello(clientHelloRetry, buf, true);
				this.SendServerHelloMessage(serverHello);
				this.m_connectionState = 4;
				this.Send13ServerHelloCoda(serverHello, true);
				return;
			}
			case 11:
				if (this.m_connectionState == 20)
				{
					this.Receive13ClientCertificate(buf);
					this.m_connectionState = 15;
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			case 15:
				if (this.m_connectionState == 15)
				{
					this.Receive13ClientCertificateVerify(buf);
					buf.UpdateHash(this.m_handshakeHash);
					this.m_connectionState = 17;
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			case 20:
			{
				short connectionState = this.m_connectionState;
				if (connectionState == 15 || connectionState == 17 || connectionState == 20)
				{
					if (this.m_connectionState == 20)
					{
						this.Skip13ClientCertificate();
					}
					if (this.m_connectionState != 17)
					{
						this.Skip13ClientCertificateVerify();
					}
					this.Receive13ClientFinished(buf);
					this.m_connectionState = 18;
					this.m_recordStream.SetIgnoreChangeCipherSpec(false);
					this.m_recordStream.EnablePendingCipherRead(false);
					this.CompleteHandshake();
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			case 24:
				this.Receive13KeyUpdate(buf);
				return;
			default:
				if (type != 254)
				{
				}
				break;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002A89C File Offset: 0x00028A9C
		protected override void HandleHandshakeMessage(short type, global::Org.BouncyCastle.Tls.HandshakeMessageInput buf)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsServerContext.SecurityParameters;
			if (this.m_connectionState > 1 && global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
			{
				this.Handle13HandshakeMessage(type, buf);
				return;
			}
			if (!base.IsLegacyConnectionState())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (!this.m_resumedSession)
			{
				switch (type)
				{
				case 0:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 12:
				case 13:
				case 14:
				case 17:
				case 18:
				case 19:
				case 21:
				case 22:
				case 24:
					break;
				case 1:
				{
					if (base.IsApplicationDataReady)
					{
						this.RefuseRenegotiation();
						return;
					}
					short connectionState = this.m_connectionState;
					if (connectionState != 0)
					{
						if (connectionState == 21)
						{
							throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
						}
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					else
					{
						global::Org.BouncyCastle.Tls.ClientHello clientHello = this.ReceiveClientHelloMessage(buf);
						this.m_connectionState = 1;
						global::Org.BouncyCastle.Tls.ServerHello serverHello = this.GenerateServerHello(clientHello, buf);
						this.m_handshakeHash.NotifyPrfDetermined();
						if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
						{
							this.m_handshakeHash.SealHashAlgorithms();
							if (serverHello.IsHelloRetryRequest())
							{
								global::Org.BouncyCastle.Tls.TlsUtilities.AdjustTranscriptForRetry(this.m_handshakeHash);
								this.SendServerHelloMessage(serverHello);
								this.m_connectionState = 2;
								this.SendChangeCipherSpecMessage();
								return;
							}
							this.SendServerHelloMessage(serverHello);
							this.m_connectionState = 4;
							this.SendChangeCipherSpecMessage();
							this.Send13ServerHelloCoda(serverHello, false);
							return;
						}
						else
						{
							buf.UpdateHash(this.m_handshakeHash);
							this.SendServerHelloMessage(serverHello);
							this.m_connectionState = 4;
							if (this.m_resumedSession)
							{
								securityParameters.m_masterSecret = this.m_sessionMasterSecret;
								this.m_recordStream.SetPendingCipher(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(this.m_tlsServerContext));
								this.SendChangeCipherSpec();
								this.SendFinishedMessage();
								this.m_connectionState = 20;
								return;
							}
							global::System.Collections.IList serverSupplementalData = this.m_tlsServer.GetServerSupplementalData();
							if (serverSupplementalData != null)
							{
								this.SendSupplementalDataMessage(serverSupplementalData);
								this.m_connectionState = 6;
							}
							this.m_keyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.InitKeyExchangeServer(this.m_tlsServerContext, this.m_tlsServer);
							global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerCredentials(this.m_tlsServer);
							global::Org.BouncyCastle.Tls.Certificate serverCertificate = null;
							global::System.IO.MemoryStream endPointHash = new global::System.IO.MemoryStream();
							if (serverCredentials == null)
							{
								this.m_keyExchange.SkipServerCredentials();
							}
							else
							{
								this.m_keyExchange.ProcessServerCredentials(serverCredentials);
								serverCertificate = serverCredentials.Certificate;
								this.SendCertificateMessage(serverCertificate, endPointHash);
								this.m_connectionState = 7;
							}
							securityParameters.m_tlsServerEndPoint = endPointHash.ToArray();
							if (serverCertificate == null || serverCertificate.IsEmpty)
							{
								securityParameters.m_statusRequestVersion = 0;
							}
							if (securityParameters.StatusRequestVersion > 0)
							{
								global::Org.BouncyCastle.Tls.CertificateStatus certificateStatus = this.m_tlsServer.GetCertificateStatus();
								if (certificateStatus != null)
								{
									this.SendCertificateStatusMessage(certificateStatus);
									this.m_connectionState = 8;
								}
							}
							byte[] serverKeyExchange = this.m_keyExchange.GenerateServerKeyExchange();
							if (serverKeyExchange != null)
							{
								this.SendServerKeyExchangeMessage(serverKeyExchange);
								this.m_connectionState = 10;
							}
							if (serverCredentials != null)
							{
								this.m_certificateRequest = this.m_tlsServer.GetCertificateRequest();
								if (this.m_certificateRequest == null)
								{
									if (!this.m_keyExchange.RequiresCertificateVerify)
									{
										throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
									}
								}
								else
								{
									if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(this.m_tlsServerContext) != (this.m_certificateRequest.SupportedSignatureAlgorithms != null))
									{
										throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
									}
									this.m_certificateRequest = global::Org.BouncyCastle.Tls.TlsUtilities.ValidateCertificateRequest(this.m_certificateRequest, this.m_keyExchange);
									global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerSigAlgs(securityParameters, this.m_certificateRequest);
									global::Org.BouncyCastle.Tls.TlsUtilities.TrackHashAlgorithms(this.m_handshakeHash, securityParameters.ServerSigAlgs);
									this.SendCertificateRequestMessage(this.m_certificateRequest);
									this.m_connectionState = 11;
								}
							}
							this.SendServerHelloDoneMessage();
							this.m_connectionState = 12;
							bool forceBuffering = false;
							global::Org.BouncyCastle.Tls.TlsUtilities.SealHandshakeHash(this.m_tlsServerContext, this.m_handshakeHash, forceBuffering);
							return;
						}
					}
					break;
				}
				case 11:
				{
					short connectionState = this.m_connectionState;
					if (connectionState == 12 || connectionState == 14)
					{
						if (this.m_connectionState != 14)
						{
							this.m_tlsServer.ProcessClientSupplementalData(null);
						}
						this.ReceiveCertificateMessage(buf);
						this.m_connectionState = 15;
						return;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				case 15:
					if (this.m_connectionState != 16)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					if (!this.ExpectCertificateVerifyMessage())
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					this.ReceiveCertificateVerifyMessage(buf);
					buf.UpdateHash(this.m_handshakeHash);
					this.m_connectionState = 17;
					return;
				case 16:
				{
					short connectionState = this.m_connectionState;
					if (connectionState == 12 || connectionState - 14 <= 1)
					{
						if (this.m_connectionState == 12)
						{
							this.m_tlsServer.ProcessClientSupplementalData(null);
						}
						if (this.m_connectionState != 15)
						{
							if (this.m_certificateRequest == null)
							{
								this.m_keyExchange.SkipClientCredentials();
							}
							else
							{
								if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(this.m_tlsServerContext))
								{
									throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
								}
								if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(this.m_tlsServerContext))
								{
									throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
								}
								this.NotifyClientCertificate(global::Org.BouncyCastle.Tls.Certificate.EmptyChain);
							}
						}
						this.ReceiveClientKeyExchangeMessage(buf);
						this.m_connectionState = 16;
						return;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				case 20:
				{
					short connectionState = this.m_connectionState;
					if (connectionState - 16 > 1)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					if (this.m_connectionState != 17 && this.ExpectCertificateVerifyMessage())
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					this.ProcessFinishedMessage(buf);
					buf.UpdateHash(this.m_handshakeHash);
					this.m_connectionState = 18;
					if (this.m_expectSessionTicket)
					{
						this.SendNewSessionTicketMessage(this.m_tlsServer.GetNewSessionTicket());
						this.m_connectionState = 19;
					}
					this.SendChangeCipherSpec();
					this.SendFinishedMessage();
					this.m_connectionState = 20;
					this.CompleteHandshake();
					return;
				}
				case 23:
					if (this.m_connectionState == 12)
					{
						this.m_tlsServer.ProcessClientSupplementalData(global::Org.BouncyCastle.Tls.TlsProtocol.ReadSupplementalDataMessage(buf));
						this.m_connectionState = 14;
						return;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				default:
					if (type != 254)
					{
					}
					break;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			if (type != 20 || this.m_connectionState != 20)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			this.ProcessFinishedMessage(buf);
			this.m_connectionState = 18;
			this.CompleteHandshake();
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002AE20 File Offset: 0x00029020
		protected override void HandleAlertWarningMessage(short alertDescription)
		{
			if (41 == alertDescription && this.m_certificateRequest != null && global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(this.m_tlsServerContext))
			{
				short connectionState = this.m_connectionState;
				if (connectionState == 12 || connectionState == 14)
				{
					if (this.m_connectionState != 14)
					{
						this.m_tlsServer.ProcessClientSupplementalData(null);
					}
					this.NotifyClientCertificate(global::Org.BouncyCastle.Tls.Certificate.EmptyChain);
					this.m_connectionState = 15;
					return;
				}
			}
			base.HandleAlertWarningMessage(alertDescription);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002AE89 File Offset: 0x00029089
		protected virtual void NotifyClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			if (this.m_certificateRequest == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.ProcessClientCertificate(this.m_tlsServerContext, clientCertificate, this.m_keyExchange, this.m_tlsServer);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0002AEB4 File Offset: 0x000290B4
		protected virtual void Receive13ClientCertificate(global::System.IO.MemoryStream buf)
		{
			if (this.m_certificateRequest == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Tls.Certificate clientCertificate = global::Org.BouncyCastle.Tls.Certificate.Parse(new global::Org.BouncyCastle.Tls.Certificate.ParseOptions().SetMaxChainLength(this.m_tlsServer.GetMaxCertificateChainLength()), this.m_tlsServerContext, buf, null);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			this.NotifyClientCertificate(clientCertificate);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0002AF04 File Offset: 0x00029104
		protected void Receive13ClientCertificateVerify(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.Certificate clientCertificate = this.m_tlsServerContext.SecurityParameters.PeerCertificate;
			if (clientCertificate == null || clientCertificate.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.DigitallySigned.Parse(this.m_tlsServerContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.Verify13CertificateVerifyClient(this.m_tlsServerContext, this.m_certificateRequest, certificateVerify, this.m_handshakeHash);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002AF60 File Offset: 0x00029160
		protected virtual void Receive13ClientFinished(global::System.IO.MemoryStream buf)
		{
			this.Process13FinishedMessage(buf);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0002AF6C File Offset: 0x0002916C
		protected virtual void ReceiveCertificateMessage(global::System.IO.MemoryStream buf)
		{
			if (this.m_certificateRequest == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Tls.Certificate clientCertificate = global::Org.BouncyCastle.Tls.Certificate.Parse(new global::Org.BouncyCastle.Tls.Certificate.ParseOptions().SetMaxChainLength(this.m_tlsServer.GetMaxCertificateChainLength()), this.m_tlsServerContext, buf, null);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			this.NotifyClientCertificate(clientCertificate);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0002AFBC File Offset: 0x000291BC
		protected virtual void ReceiveCertificateVerifyMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.DigitallySigned.Parse(this.m_tlsServerContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.VerifyCertificateVerifyClient(this.m_tlsServerContext, this.m_certificateRequest, certificateVerify, this.m_handshakeHash);
			this.m_handshakeHash = this.m_handshakeHash.StopTracking();
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002B005 File Offset: 0x00029205
		protected virtual global::Org.BouncyCastle.Tls.ClientHello ReceiveClientHelloMessage(global::System.IO.MemoryStream buf)
		{
			return global::Org.BouncyCastle.Tls.ClientHello.Parse(buf, null);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002B010 File Offset: 0x00029210
		protected virtual void ReceiveClientKeyExchangeMessage(global::System.IO.MemoryStream buf)
		{
			this.m_keyExchange.ProcessClientKeyExchange(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			bool flag = global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(this.m_tlsServerContext);
			if (flag)
			{
				global::Org.BouncyCastle.Tls.TlsProtocol.EstablishMasterSecret(this.m_tlsServerContext, this.m_keyExchange);
			}
			this.m_tlsServerContext.SecurityParameters.m_sessionHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(this.m_handshakeHash);
			if (!flag)
			{
				global::Org.BouncyCastle.Tls.TlsProtocol.EstablishMasterSecret(this.m_tlsServerContext, this.m_keyExchange);
			}
			this.m_recordStream.SetPendingCipher(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(this.m_tlsServerContext));
			if (!this.ExpectCertificateVerifyMessage())
			{
				this.m_handshakeHash = this.m_handshakeHash.StopTracking();
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002B0AC File Offset: 0x000292AC
		protected virtual void Send13EncryptedExtensionsMessage(global::System.Collections.IDictionary serverExtensions)
		{
			byte[] buf = global::Org.BouncyCastle.Tls.TlsProtocol.WriteExtensionsData(serverExtensions);
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(8);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(buf, message);
			message.Send(this);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0002B0D4 File Offset: 0x000292D4
		protected virtual void Send13ServerHelloCoda(global::Org.BouncyCastle.Tls.ServerHello serverHello, bool afterHelloRetryRequest)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsServerContext.SecurityParameters;
			byte[] serverHelloTranscriptHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(this.m_handshakeHash);
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13PhaseHandshake(this.m_tlsServerContext, serverHelloTranscriptHash, this.m_recordStream);
			this.m_recordStream.EnablePendingCipherWrite();
			this.m_recordStream.EnablePendingCipherRead(true);
			this.Send13EncryptedExtensionsMessage(this.m_serverExtensions);
			this.m_connectionState = 5;
			if (!this.m_selectedPsk13)
			{
				this.m_certificateRequest = this.m_tlsServer.GetCertificateRequest();
				if (this.m_certificateRequest != null)
				{
					if (!this.m_certificateRequest.HasCertificateRequestContext(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes))
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
					global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerSigAlgs(securityParameters, this.m_certificateRequest);
					this.SendCertificateRequestMessage(this.m_certificateRequest);
					this.m_connectionState = 11;
				}
				global::Org.BouncyCastle.Tls.TlsCredentialedSigner serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.Establish13ServerCredentials(this.m_tlsServer);
				if (serverCredentials == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Tls.Certificate serverCertificate = serverCredentials.Certificate;
				this.Send13CertificateMessage(serverCertificate);
				securityParameters.m_tlsServerEndPoint = null;
				this.m_connectionState = 7;
				global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.TlsUtilities.Generate13CertificateVerify(this.m_tlsServerContext, serverCredentials, this.m_handshakeHash);
				this.Send13CertificateVerifyMessage(certificateVerify);
				this.m_connectionState = 17;
			}
			this.Send13FinishedMessage();
			this.m_connectionState = 20;
			byte[] serverFinishedTranscriptHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(this.m_handshakeHash);
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13PhaseApplication(this.m_tlsServerContext, serverFinishedTranscriptHash, this.m_recordStream);
			this.m_recordStream.EnablePendingCipherWrite();
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0002B224 File Offset: 0x00029424
		protected virtual void SendCertificateRequestMessage(global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(13);
			certificateRequest.Encode(this.m_tlsServerContext, message);
			message.Send(this);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002B250 File Offset: 0x00029450
		protected virtual void SendCertificateStatusMessage(global::Org.BouncyCastle.Tls.CertificateStatus certificateStatus)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(22);
			certificateStatus.Encode(message);
			message.Send(this);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002B273 File Offset: 0x00029473
		protected virtual void SendHelloRequestMessage()
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput.Send(this, 0, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002B284 File Offset: 0x00029484
		protected virtual void SendNewSessionTicketMessage(global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket)
		{
			if (newSessionTicket == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(4);
			newSessionTicket.Encode(message);
			message.Send(this);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002B2B1 File Offset: 0x000294B1
		protected virtual void SendServerHelloDoneMessage()
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput.Send(this, 14, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002B2C0 File Offset: 0x000294C0
		protected virtual void SendServerHelloMessage(global::Org.BouncyCastle.Tls.ServerHello serverHello)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(2);
			serverHello.Encode(this.m_tlsServerContext, message);
			message.Send(this);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002B2E8 File Offset: 0x000294E8
		protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput.Send(this, 12, serverKeyExchange);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002B2F3 File Offset: 0x000294F3
		protected virtual void Skip13ClientCertificate()
		{
			if (this.m_certificateRequest != null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002B305 File Offset: 0x00029505
		protected virtual void Skip13ClientCertificateVerify()
		{
			if (this.ExpectCertificateVerifyMessage())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x0400073E RID: 1854
		protected global::Org.BouncyCastle.Tls.TlsServer m_tlsServer;

		// Token: 0x0400073F RID: 1855
		internal global::Org.BouncyCastle.Tls.TlsServerContextImpl m_tlsServerContext;

		// Token: 0x04000740 RID: 1856
		protected int[] m_offeredCipherSuites;

		// Token: 0x04000741 RID: 1857
		protected global::Org.BouncyCastle.Tls.TlsKeyExchange m_keyExchange;

		// Token: 0x04000742 RID: 1858
		protected global::Org.BouncyCastle.Tls.CertificateRequest m_certificateRequest;
	}
}
