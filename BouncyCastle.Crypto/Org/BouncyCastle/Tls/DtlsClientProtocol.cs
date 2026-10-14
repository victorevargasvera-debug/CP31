using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B7 RID: 183
	public class DtlsClientProtocol : global::Org.BouncyCastle.Tls.DtlsProtocol
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x0001BDC4 File Offset: 0x00019FC4
		public virtual global::Org.BouncyCastle.Tls.DtlsTransport Connect(global::Org.BouncyCastle.Tls.TlsClient client, global::Org.BouncyCastle.Tls.DatagramTransport transport)
		{
			if (client == null)
			{
				throw new global::System.ArgumentNullException("client");
			}
			if (transport == null)
			{
				throw new global::System.ArgumentNullException("transport");
			}
			global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state = new global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState();
			state.client = client;
			state.clientContext = new global::Org.BouncyCastle.Tls.TlsClientContextImpl(client.Crypto);
			client.Init(state.clientContext);
			state.clientContext.HandshakeBeginning(client);
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = state.clientContext.SecurityParameters;
			securityParameters.m_extendedPadding = client.ShouldUseExtendedPadding();
			global::Org.BouncyCastle.Tls.TlsSession sessionToResume = state.client.GetSessionToResume();
			if (sessionToResume != null && sessionToResume.IsResumable)
			{
				global::Org.BouncyCastle.Tls.SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
				if (sessionParameters != null && (sessionParameters.IsExtendedMasterSecret || (!state.client.RequiresExtendedMasterSecret() && state.client.AllowLegacyResumption())))
				{
					global::Org.BouncyCastle.Tls.Crypto.TlsSecret masterSecret = sessionParameters.MasterSecret;
					global::Org.BouncyCastle.Tls.Crypto.TlsSecret obj = masterSecret;
					lock (obj)
					{
						if (masterSecret.IsAlive())
						{
							state.tlsSession = sessionToResume;
							state.sessionParameters = sessionParameters;
							state.sessionMasterSecret = state.clientContext.Crypto.AdoptSecret(masterSecret);
						}
					}
				}
			}
			global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer = new global::Org.BouncyCastle.Tls.DtlsRecordLayer(state.clientContext, state.client, transport);
			client.NotifyCloseHandle(recordLayer);
			global::Org.BouncyCastle.Tls.DtlsTransport result;
			try
			{
				result = this.ClientHandshake(state, recordLayer);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert fatalAlert)
			{
				this.AbortClientHandshake(state, recordLayer, fatalAlert.AlertDescription);
				throw fatalAlert;
			}
			catch (global::System.IO.IOException ex)
			{
				this.AbortClientHandshake(state, recordLayer, 80);
				throw ex;
			}
			catch (global::System.Exception e)
			{
				this.AbortClientHandshake(state, recordLayer, 80);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			finally
			{
				securityParameters.Clear();
			}
			return result;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001BF84 File Offset: 0x0001A184
		internal virtual void AbortClientHandshake(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer, short alertDescription)
		{
			recordLayer.Fail(alertDescription);
			this.InvalidateSession(state);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001BF94 File Offset: 0x0001A194
		internal virtual global::Org.BouncyCastle.Tls.DtlsTransport ClientHandshake(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = state.clientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake handshake = new global::Org.BouncyCastle.Tls.DtlsReliableHandshake(state.clientContext, recordLayer, state.client.GetHandshakeTimeoutMillis(), null);
			byte[] clientHelloBody = this.GenerateClientHello(state);
			recordLayer.SetWriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10);
			handshake.SendMessage(1, clientHelloBody);
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message serverMessage = handshake.ReceiveMessage();
			while (serverMessage.Type == 3)
			{
				byte[] cookie = this.ProcessHelloVerifyRequest(state, serverMessage.Body);
				byte[] patched = global::Org.BouncyCastle.Tls.DtlsClientProtocol.PatchClientHelloWithCookie(clientHelloBody, cookie);
				handshake.ResetAfterHelloVerifyRequestClient();
				handshake.SendMessage(1, patched);
				serverMessage = handshake.ReceiveMessage();
			}
			if (serverMessage.Type != 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion recordLayerVersion = recordLayer.ReadVersion;
			this.ReportServerVersion(state, recordLayerVersion);
			recordLayer.SetWriteVersion(recordLayerVersion);
			this.ProcessServerHello(state, serverMessage.Body);
			handshake.HandshakeHash.NotifyPrfDetermined();
			global::Org.BouncyCastle.Tls.DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.MaxFragmentLength);
			if (state.resumedSession)
			{
				securityParameters.m_masterSecret = state.sessionMasterSecret;
				recordLayer.InitPendingEpoch(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(state.clientContext));
				securityParameters.m_peerVerifyData = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, true);
				this.ProcessFinished(handshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
				securityParameters.m_localVerifyData = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, false);
				handshake.SendMessage(20, securityParameters.LocalVerifyData);
				handshake.Finish();
				if (securityParameters.IsExtendedMasterSecret)
				{
					securityParameters.m_tlsUnique = securityParameters.PeerVerifyData;
				}
				securityParameters.m_localCertificate = state.sessionParameters.LocalCertificate;
				securityParameters.m_peerCertificate = state.sessionParameters.PeerCertificate;
				securityParameters.m_pskIdentity = state.sessionParameters.PskIdentity;
				securityParameters.m_srpIdentity = state.sessionParameters.SrpIdentity;
				state.clientContext.HandshakeComplete(state.client, state.tlsSession);
				recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
				return new global::Org.BouncyCastle.Tls.DtlsTransport(recordLayer);
			}
			this.InvalidateSession(state);
			state.tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, null);
			serverMessage = handshake.ReceiveMessage();
			if (serverMessage.Type == 23)
			{
				this.ProcessServerSupplementalData(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.client.ProcessServerSupplementalData(null);
			}
			state.keyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.InitKeyExchangeClient(state.clientContext, state.client);
			if (serverMessage.Type == 11)
			{
				this.ProcessServerCertificate(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.authentication = null;
			}
			if (serverMessage.Type == 22)
			{
				if (securityParameters.StatusRequestVersion < 1)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.ProcessCertificateStatus(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.ProcessServerCertificate(state.clientContext, state.certificateStatus, state.keyExchange, state.authentication, state.clientExtensions, state.serverExtensions);
			if (serverMessage.Type == 12)
			{
				this.ProcessServerKeyExchange(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.keyExchange.SkipServerKeyExchange();
			}
			if (serverMessage.Type == 13)
			{
				this.ProcessCertificateRequest(state, serverMessage.Body);
				global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerSigAlgs(securityParameters, state.certificateRequest);
				global::Org.BouncyCastle.Tls.TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, securityParameters.ServerSigAlgs);
				serverMessage = handshake.ReceiveMessage();
			}
			if (serverMessage.Type != 14)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			if (serverMessage.Body.Length != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IList clientSupplementalData = state.client.GetClientSupplementalData();
			if (clientSupplementalData != null)
			{
				byte[] supplementalDataBody = global::Org.BouncyCastle.Tls.DtlsProtocol.GenerateSupplementalData(clientSupplementalData);
				handshake.SendMessage(23, supplementalDataBody);
			}
			if (state.certificateRequest != null)
			{
				state.clientCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientCredentials(state.authentication, state.certificateRequest);
				global::Org.BouncyCastle.Tls.Certificate clientCertificate = null;
				if (state.clientCredentials != null)
				{
					clientCertificate = state.clientCredentials.Certificate;
				}
				global::Org.BouncyCastle.Tls.DtlsProtocol.SendCertificateMessage(state.clientContext, handshake, clientCertificate, null);
			}
			global::Org.BouncyCastle.Tls.TlsCredentialedSigner credentialedSigner = null;
			global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner streamSigner = null;
			if (state.clientCredentials != null)
			{
				state.keyExchange.ProcessClientCredentials(state.clientCredentials);
				if (state.clientCredentials is global::Org.BouncyCastle.Tls.TlsCredentialedSigner)
				{
					credentialedSigner = (global::Org.BouncyCastle.Tls.TlsCredentialedSigner)state.clientCredentials;
					streamSigner = credentialedSigner.GetStreamSigner();
				}
			}
			else
			{
				state.keyExchange.SkipClientCredentials();
			}
			bool forceBuffering = streamSigner != null;
			global::Org.BouncyCastle.Tls.TlsUtilities.SealHandshakeHash(state.clientContext, handshake.HandshakeHash, forceBuffering);
			byte[] clientKeyExchangeBody = this.GenerateClientKeyExchange(state);
			handshake.SendMessage(16, clientKeyExchangeBody);
			securityParameters.m_sessionHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshake.HandshakeHash);
			global::Org.BouncyCastle.Tls.TlsProtocol.EstablishMasterSecret(state.clientContext, state.keyExchange);
			recordLayer.InitPendingEpoch(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(state.clientContext));
			if (credentialedSigner != null)
			{
				global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.TlsUtilities.GenerateCertificateVerifyClient(state.clientContext, credentialedSigner, streamSigner, handshake.HandshakeHash);
				byte[] certificateVerifyBody = this.GenerateCertificateVerify(state, certificateVerify);
				handshake.SendMessage(15, certificateVerifyBody);
			}
			handshake.PrepareToFinish();
			securityParameters.m_localVerifyData = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, false);
			handshake.SendMessage(20, securityParameters.LocalVerifyData);
			if (state.expectSessionTicket)
			{
				serverMessage = handshake.ReceiveMessage();
				if (serverMessage.Type != 4)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				securityParameters.m_sessionID = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
				this.InvalidateSession(state);
				state.tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, null);
				this.ProcessNewSessionTicket(state, serverMessage.Body);
			}
			securityParameters.m_peerVerifyData = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, true);
			this.ProcessFinished(handshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
			handshake.Finish();
			state.sessionMasterSecret = securityParameters.MasterSecret;
			state.sessionParameters = new global::Org.BouncyCastle.Tls.SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate).SetMasterSecret(state.clientContext.Crypto.AdoptSecret(state.sessionMasterSecret)).SetNegotiatedVersion(securityParameters.NegotiatedVersion).SetPeerCertificate(securityParameters.PeerCertificate).SetPskIdentity(securityParameters.PskIdentity).SetSrpIdentity(securityParameters.SrpIdentity).SetServerExtensions(state.serverExtensions).Build();
			state.tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, state.sessionParameters);
			securityParameters.m_tlsUnique = securityParameters.LocalVerifyData;
			state.clientContext.HandshakeComplete(state.client, state.tlsSession);
			recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
			return new global::Org.BouncyCastle.Tls.DtlsTransport(recordLayer);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001C5C8 File Offset: 0x0001A7C8
		protected virtual byte[] GenerateCertificateVerify(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificateVerify.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
		protected virtual byte[] GenerateClientHello(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state)
		{
			global::Org.BouncyCastle.Tls.TlsClientContextImpl context = state.clientContext;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			context.SetClientSupportedVersions(state.client.GetProtocolVersions());
			global::Org.BouncyCastle.Tls.ProtocolVersion client_version = global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestDtls(context.ClientSupportedVersions);
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.IsSupportedDtlsVersionClient(client_version))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			context.SetClientVersion(client_version);
			byte[] session_id = global::Org.BouncyCastle.Tls.TlsUtilities.GetSessionID(state.tlsSession);
			bool flag = state.client.IsFallback();
			state.offeredCipherSuites = state.client.GetCipherSuites();
			if (session_id.Length != 0 && state.sessionParameters != null && !global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, state.sessionParameters.CipherSuite))
			{
				session_id = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			}
			state.clientExtensions = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(state.client.GetClientExtensions());
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = client_version;
			if (client_version.IsLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12))
			{
				legacy_version = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedVersionsExtensionClient(state.clientExtensions, context.ClientSupportedVersions);
			}
			context.SetRsaPreMasterSecretVersion(legacy_version);
			securityParameters.m_clientServerNames = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetServerNameExtensionClient(state.clientExtensions);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(client_version))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientSigAlgs(securityParameters, state.clientExtensions);
			}
			securityParameters.m_clientSupportedGroups = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedGroupsExtension(state.clientExtensions);
			state.clientAgreements = global::Org.BouncyCastle.Tls.TlsUtilities.AddKeyShareToClientHello(state.clientContext, state.client, state.clientExtensions);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsExtendedMasterSecretOptionalDtls(context.ClientSupportedVersions) && state.client.ShouldUseExtendedMasterSecret())
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.clientExtensions);
			}
			else if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(client_version) && state.client.RequiresExtendedMasterSecret())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			bool useGmtUnixTime = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(client_version) && state.client.ShouldUseGmtUnixTime();
			securityParameters.m_clientRandom = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRandomBlock(useGmtUnixTime, state.clientContext);
			bool flag2 = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(state.clientExtensions, 65281) == null;
			bool noRenegScsv = !global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 255);
			if (flag2 && noRenegScsv)
			{
				state.offeredCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(state.offeredCipherSuites, 255);
			}
			if (flag && !global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 22016))
			{
				state.offeredCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(state.offeredCipherSuites, 22016);
			}
			state.heartbeat = state.client.GetHeartbeat();
			state.heartbeatPolicy = state.client.GetHeartbeatPolicy();
			if (state.heartbeat != null || 1 == state.heartbeatPolicy)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddHeartbeatExtension(state.clientExtensions, new global::Org.BouncyCastle.Tls.HeartbeatExtension(state.heartbeatPolicy));
			}
			global::Org.BouncyCastle.Tls.ClientHello clientHello = new global::Org.BouncyCastle.Tls.ClientHello(legacy_version, securityParameters.ClientRandom, session_id, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, state.offeredCipherSuites, state.clientExtensions, 0);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			clientHello.Encode(state.clientContext, buf);
			return buf.ToArray();
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001C888 File Offset: 0x0001AA88
		protected virtual byte[] GenerateClientKeyExchange(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			state.keyExchange.GenerateClientKeyExchange(buf);
			return buf.ToArray();
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
		protected virtual void InvalidateSession(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state)
		{
			if (state.sessionMasterSecret != null)
			{
				state.sessionMasterSecret.Destroy();
				state.sessionMasterSecret = null;
			}
			if (state.sessionParameters != null)
			{
				state.sessionParameters.Clear();
				state.sessionParameters = null;
			}
			if (state.tlsSession != null)
			{
				state.tlsSession.Invalidate();
				state.tlsSession = null;
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001C90C File Offset: 0x0001AB0C
		protected virtual void ProcessCertificateRequest(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			if (state.authentication == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest = global::Org.BouncyCastle.Tls.CertificateRequest.Parse(state.clientContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			state.certificateRequest = global::Org.BouncyCastle.Tls.TlsUtilities.ValidateCertificateRequest(certificateRequest, state.keyExchange);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001C958 File Offset: 0x0001AB58
		protected virtual void ProcessCertificateStatus(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.certificateStatus = global::Org.BouncyCastle.Tls.CertificateStatus.Parse(state.clientContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001C988 File Offset: 0x0001AB88
		protected virtual byte[] ProcessHelloVerifyRequest(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Tls.ProtocolVersion server_version = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(memoryStream);
			int maxCookieLength = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12.IsEqualOrEarlierVersionOf(server_version) ? 255 : 32;
			byte[] cookie = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(memoryStream, 0, maxCookieLength);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			if (!server_version.IsEqualOrEarlierVersionOf(state.clientContext.ClientVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return cookie;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
		protected virtual void ProcessNewSessionTicket(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket = global::Org.BouncyCastle.Tls.NewSessionTicket.Parse(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			state.client.NotifyNewSessionTicket(newSessionTicket);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001CA10 File Offset: 0x0001AC10
		protected virtual void ProcessServerCertificate(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			state.authentication = global::Org.BouncyCastle.Tls.TlsUtilities.ReceiveServerCertificate(state.clientContext, state.client, new global::System.IO.MemoryStream(body, false));
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001CA30 File Offset: 0x0001AC30
		protected virtual void ProcessServerHello(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::Org.BouncyCastle.Tls.ServerHello serverHello = global::Org.BouncyCastle.Tls.ServerHello.Parse(new global::System.IO.MemoryStream(body, false));
			global::Org.BouncyCastle.Tls.ProtocolVersion server_version = serverHello.Version;
			state.serverExtensions = serverHello.Extensions;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = state.clientContext.SecurityParameters;
			this.ReportServerVersion(state, server_version);
			securityParameters.m_serverRandom = serverHello.Random;
			if (!state.clientContext.ClientVersion.Equals(server_version))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckDowngradeMarker(server_version, securityParameters.ServerRandom);
			}
			byte[] selectedSessionID = serverHello.SessionID;
			securityParameters.m_sessionID = selectedSessionID;
			state.client.NotifySessionID(selectedSessionID);
			state.resumedSession = (selectedSessionID.Length != 0 && state.tlsSession != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(selectedSessionID, state.tlsSession.SessionID));
			int cipherSuite = global::Org.BouncyCastle.Tls.DtlsProtocol.ValidateSelectedCipherSuite(serverHello.CipherSuite, 47);
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(state.offeredCipherSuites, cipherSuite) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			state.client.NotifySelectedCipherSuite(cipherSuite);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(server_version))
			{
				securityParameters.m_extendedMasterSecret = true;
			}
			else
			{
				bool acceptedExtendedMasterSecret = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.serverExtensions);
				if (acceptedExtendedMasterSecret)
				{
					if (!state.resumedSession && !state.client.ShouldUseExtendedMasterSecret())
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
					}
				}
				else if (state.client.RequiresExtendedMasterSecret() || (state.resumedSession && !state.client.AllowLegacyResumption()))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
				securityParameters.m_extendedMasterSecret = acceptedExtendedMasterSecret;
			}
			if (state.serverExtensions != null)
			{
				foreach (object obj in state.serverExtensions.Keys)
				{
					int extType = (int)obj;
					if (extType != 65281)
					{
						if (global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(state.clientExtensions, extType) == null)
						{
							throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(110);
						}
						bool resumedSession = state.resumedSession;
					}
				}
			}
			byte[] renegExtData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
			if (renegExtData != null)
			{
				securityParameters.m_secureRenegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
			}
			state.client.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
			securityParameters.m_applicationProtocol = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionServer(state.serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			global::Org.BouncyCastle.Tls.HeartbeatExtension heartbeatExtension = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetHeartbeatExtension(state.serverExtensions);
			if (heartbeatExtension == null)
			{
				state.heartbeat = null;
				state.heartbeatPolicy = 2;
			}
			else if (1 != heartbeatExtension.Mode)
			{
				state.heartbeat = null;
			}
			global::System.Collections.IDictionary sessionClientExtensions = state.clientExtensions;
			global::System.Collections.IDictionary sessionServerExtensions = state.serverExtensions;
			if (state.resumedSession)
			{
				if (securityParameters.CipherSuite != state.sessionParameters.CipherSuite || !server_version.Equals(state.sessionParameters.NegotiatedVersion))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				sessionClientExtensions = null;
				sessionServerExtensions = state.sessionParameters.ReadServerExtensions();
			}
			if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
			{
				bool serverSentEncryptThenMac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
				if (serverSentEncryptThenMac && !global::Org.BouncyCastle.Tls.TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				securityParameters.m_encryptThenMac = serverSentEncryptThenMac;
				securityParameters.m_maxFragmentLength = global::Org.BouncyCastle.Tls.DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, sessionClientExtensions, sessionServerExtensions, 47);
				securityParameters.m_truncatedHmac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasTruncatedHmacExtension(sessionServerExtensions);
				if (!state.resumedSession)
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 17, 47))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
				}
				state.expectSessionTicket = (!state.resumedSession && global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47));
			}
			if (sessionClientExtensions != null)
			{
				state.client.ProcessServerExtensions(sessionServerExtensions);
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001CDC4 File Offset: 0x0001AFC4
		protected virtual void ProcessServerKeyExchange(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.keyExchange.ProcessServerKeyExchange(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		protected virtual void ProcessServerSupplementalData(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.Collections.IList serverSupplementalData = global::Org.BouncyCastle.Tls.TlsProtocol.ReadSupplementalDataMessage(new global::System.IO.MemoryStream(body, false));
			state.client.ProcessServerSupplementalData(serverSupplementalData);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001CE14 File Offset: 0x0001B014
		protected virtual void ReportServerVersion(global::Org.BouncyCastle.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Tls.ProtocolVersion server_version)
		{
			global::Org.BouncyCastle.Tls.TlsClientContextImpl context = state.clientContext;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion currentServerVersion = securityParameters.NegotiatedVersion;
			if (currentServerVersion != null)
			{
				if (!currentServerVersion.Equals(server_version))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				return;
			}
			else
			{
				if (!global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(context.ClientSupportedVersions, server_version))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(70);
				}
				securityParameters.m_negotiatedVersion = server_version;
				global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersionDtlsClient(state.clientContext, state.client);
				return;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001CE7C File Offset: 0x0001B07C
		protected static byte[] PatchClientHelloWithCookie(byte[] clientHelloBody, byte[] cookie)
		{
			int sessionIDPos = 34;
			int sessionIDLength = (int)global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(clientHelloBody, sessionIDPos);
			int cookieLengthPos = sessionIDPos + 1 + sessionIDLength;
			int cookiePos = cookieLengthPos + 1;
			byte[] patched = new byte[clientHelloBody.Length + cookie.Length];
			global::System.Array.Copy(clientHelloBody, 0, patched, 0, cookieLengthPos);
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint8(cookie.Length);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(cookie.Length, patched, cookieLengthPos);
			global::System.Array.Copy(cookie, 0, patched, cookiePos, cookie.Length);
			global::System.Array.Copy(clientHelloBody, cookiePos, patched, cookiePos + cookie.Length, clientHelloBody.Length - cookiePos);
			return patched;
		}

		// Token: 0x020007A2 RID: 1954
		protected internal class ClientHandshakeState
		{
			// Token: 0x040022EC RID: 8940
			internal global::Org.BouncyCastle.Tls.TlsClient client;

			// Token: 0x040022ED RID: 8941
			internal global::Org.BouncyCastle.Tls.TlsClientContextImpl clientContext;

			// Token: 0x040022EE RID: 8942
			internal global::Org.BouncyCastle.Tls.TlsSession tlsSession;

			// Token: 0x040022EF RID: 8943
			internal global::Org.BouncyCastle.Tls.SessionParameters sessionParameters;

			// Token: 0x040022F0 RID: 8944
			internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret sessionMasterSecret;

			// Token: 0x040022F1 RID: 8945
			internal global::Org.BouncyCastle.Tls.SessionParameters.Builder sessionParametersBuilder;

			// Token: 0x040022F2 RID: 8946
			internal int[] offeredCipherSuites;

			// Token: 0x040022F3 RID: 8947
			internal global::System.Collections.IDictionary clientExtensions;

			// Token: 0x040022F4 RID: 8948
			internal global::System.Collections.IDictionary serverExtensions;

			// Token: 0x040022F5 RID: 8949
			internal bool resumedSession;

			// Token: 0x040022F6 RID: 8950
			internal bool expectSessionTicket;

			// Token: 0x040022F7 RID: 8951
			internal global::System.Collections.IDictionary clientAgreements;

			// Token: 0x040022F8 RID: 8952
			internal global::Org.BouncyCastle.Tls.TlsKeyExchange keyExchange;

			// Token: 0x040022F9 RID: 8953
			internal global::Org.BouncyCastle.Tls.TlsAuthentication authentication;

			// Token: 0x040022FA RID: 8954
			internal global::Org.BouncyCastle.Tls.CertificateStatus certificateStatus;

			// Token: 0x040022FB RID: 8955
			internal global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest;

			// Token: 0x040022FC RID: 8956
			internal global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials;

			// Token: 0x040022FD RID: 8957
			internal global::Org.BouncyCastle.Tls.TlsHeartbeat heartbeat;

			// Token: 0x040022FE RID: 8958
			internal short heartbeatPolicy = 2;
		}
	}
}
