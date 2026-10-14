using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C0 RID: 192
	public class DtlsServerProtocol : global::Org.BouncyCastle.Tls.DtlsProtocol
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0001EA9C File Offset: 0x0001CC9C
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x0001EAA4 File Offset: 0x0001CCA4
		public virtual bool VerifyRequests
		{
			get
			{
				return this.m_verifyRequests;
			}
			set
			{
				this.m_verifyRequests = value;
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0001EAAD File Offset: 0x0001CCAD
		public virtual global::Org.BouncyCastle.Tls.DtlsTransport Accept(global::Org.BouncyCastle.Tls.TlsServer server, global::Org.BouncyCastle.Tls.DatagramTransport transport)
		{
			return this.Accept(server, transport, null);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0001EAB8 File Offset: 0x0001CCB8
		public virtual global::Org.BouncyCastle.Tls.DtlsTransport Accept(global::Org.BouncyCastle.Tls.TlsServer server, global::Org.BouncyCastle.Tls.DatagramTransport transport, global::Org.BouncyCastle.Tls.DtlsRequest request)
		{
			if (server == null)
			{
				throw new global::System.ArgumentNullException("server");
			}
			if (transport == null)
			{
				throw new global::System.ArgumentNullException("transport");
			}
			global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state = new global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState();
			state.server = server;
			state.serverContext = new global::Org.BouncyCastle.Tls.TlsServerContextImpl(server.Crypto);
			server.Init(state.serverContext);
			state.serverContext.HandshakeBeginning(server);
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = state.serverContext.SecurityParameters;
			securityParameters.m_extendedPadding = server.ShouldUseExtendedPadding();
			global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer = new global::Org.BouncyCastle.Tls.DtlsRecordLayer(state.serverContext, state.server, transport);
			server.NotifyCloseHandle(recordLayer);
			global::Org.BouncyCastle.Tls.DtlsTransport result;
			try
			{
				result = this.ServerHandshake(state, recordLayer, request);
			}
			catch (global::Org.BouncyCastle.Tls.TlsFatalAlert fatalAlert)
			{
				this.AbortServerHandshake(state, recordLayer, fatalAlert.AlertDescription);
				throw fatalAlert;
			}
			catch (global::System.IO.IOException ex)
			{
				this.AbortServerHandshake(state, recordLayer, 80);
				throw ex;
			}
			catch (global::System.Exception e)
			{
				this.AbortServerHandshake(state, recordLayer, 80);
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			finally
			{
				securityParameters.Clear();
			}
			return result;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
		internal virtual void AbortServerHandshake(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer, short alertDescription)
		{
			recordLayer.Fail(alertDescription);
			this.InvalidateSession(state);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		internal virtual global::Org.BouncyCastle.Tls.DtlsTransport ServerHandshake(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer, global::Org.BouncyCastle.Tls.DtlsRequest request)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = state.serverContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake handshake = new global::Org.BouncyCastle.Tls.DtlsReliableHandshake(state.serverContext, recordLayer, state.server.GetHandshakeTimeoutMillis(), request);
			global::Org.BouncyCastle.Tls.DtlsReliableHandshake.Message clientMessage;
			if (request == null)
			{
				clientMessage = handshake.ReceiveMessage();
				if (clientMessage.Type != 1)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.ProcessClientHello(state, clientMessage.Body);
			}
			else
			{
				this.ProcessClientHello(state, request.ClientHello);
			}
			state.tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, null);
			state.sessionParameters = null;
			state.sessionMasterSecret = null;
			securityParameters.m_sessionID = state.tlsSession.SessionID;
			state.server.NotifySession(state.tlsSession);
			byte[] serverHelloBody = this.GenerateServerHello(state, recordLayer);
			global::Org.BouncyCastle.Tls.ProtocolVersion recordLayerVersion = state.serverContext.ServerVersion;
			recordLayer.ReadVersion = recordLayerVersion;
			recordLayer.SetWriteVersion(recordLayerVersion);
			handshake.SendMessage(2, serverHelloBody);
			handshake.HandshakeHash.NotifyPrfDetermined();
			global::System.Collections.IList serverSupplementalData = state.server.GetServerSupplementalData();
			if (serverSupplementalData != null)
			{
				byte[] supplementalDataBody = global::Org.BouncyCastle.Tls.DtlsProtocol.GenerateSupplementalData(serverSupplementalData);
				handshake.SendMessage(23, supplementalDataBody);
			}
			state.keyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.InitKeyExchangeServer(state.serverContext, state.server);
			state.serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerCredentials(state.server);
			global::Org.BouncyCastle.Tls.Certificate serverCertificate = null;
			global::System.IO.MemoryStream endPointHash = new global::System.IO.MemoryStream();
			if (state.serverCredentials == null)
			{
				state.keyExchange.SkipServerCredentials();
			}
			else
			{
				state.keyExchange.ProcessServerCredentials(state.serverCredentials);
				serverCertificate = state.serverCredentials.Certificate;
				global::Org.BouncyCastle.Tls.DtlsProtocol.SendCertificateMessage(state.serverContext, handshake, serverCertificate, endPointHash);
			}
			securityParameters.m_tlsServerEndPoint = endPointHash.ToArray();
			if (serverCertificate == null || serverCertificate.IsEmpty)
			{
				securityParameters.m_statusRequestVersion = 0;
			}
			if (securityParameters.StatusRequestVersion > 0)
			{
				global::Org.BouncyCastle.Tls.CertificateStatus certificateStatus = state.server.GetCertificateStatus();
				if (certificateStatus != null)
				{
					byte[] certificateStatusBody = this.GenerateCertificateStatus(state, certificateStatus);
					handshake.SendMessage(22, certificateStatusBody);
				}
			}
			byte[] serverKeyExchange = state.keyExchange.GenerateServerKeyExchange();
			if (serverKeyExchange != null)
			{
				handshake.SendMessage(12, serverKeyExchange);
			}
			if (state.serverCredentials != null)
			{
				state.certificateRequest = state.server.GetCertificateRequest();
				if (state.certificateRequest == null)
				{
					if (!state.keyExchange.RequiresCertificateVerify)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
				}
				else
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(state.serverContext) != (state.certificateRequest.SupportedSignatureAlgorithms != null))
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
					state.certificateRequest = global::Org.BouncyCastle.Tls.TlsUtilities.ValidateCertificateRequest(state.certificateRequest, state.keyExchange);
					global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerSigAlgs(securityParameters, state.certificateRequest);
					global::Org.BouncyCastle.Tls.TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, securityParameters.ServerSigAlgs);
					byte[] certificateRequestBody = this.GenerateCertificateRequest(state, state.certificateRequest);
					handshake.SendMessage(13, certificateRequestBody);
				}
			}
			handshake.SendMessage(14, global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
			bool forceBuffering = false;
			global::Org.BouncyCastle.Tls.TlsUtilities.SealHandshakeHash(state.serverContext, handshake.HandshakeHash, forceBuffering);
			clientMessage = handshake.ReceiveMessage();
			if (clientMessage.Type == 23)
			{
				this.ProcessClientSupplementalData(state, clientMessage.Body);
				clientMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.server.ProcessClientSupplementalData(null);
			}
			if (state.certificateRequest == null)
			{
				state.keyExchange.SkipClientCredentials();
			}
			else if (clientMessage.Type == 11)
			{
				this.ProcessClientCertificate(state, clientMessage.Body);
				clientMessage = handshake.ReceiveMessage();
			}
			else
			{
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV12(state.serverContext))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.NotifyClientCertificate(state, global::Org.BouncyCastle.Tls.Certificate.EmptyChain);
			}
			if (clientMessage.Type == 16)
			{
				this.ProcessClientKeyExchange(state, clientMessage.Body);
				securityParameters.m_sessionHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(handshake.HandshakeHash);
				global::Org.BouncyCastle.Tls.TlsProtocol.EstablishMasterSecret(state.serverContext, state.keyExchange);
				recordLayer.InitPendingEpoch(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(state.serverContext));
				global::Org.BouncyCastle.Tls.TlsHandshakeHash certificateVerifyHash = handshake.PrepareToFinish();
				if (this.ExpectCertificateVerifyMessage(state))
				{
					byte[] certificateVerifyBody = handshake.ReceiveMessageBody(15);
					this.ProcessCertificateVerify(state, certificateVerifyBody, certificateVerifyHash);
				}
				securityParameters.m_peerVerifyData = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(state.serverContext, handshake.HandshakeHash, false);
				this.ProcessFinished(handshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
				if (state.expectSessionTicket)
				{
					global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket = state.server.GetNewSessionTicket();
					byte[] newSessionTicketBody = this.GenerateNewSessionTicket(state, newSessionTicket);
					handshake.SendMessage(4, newSessionTicketBody);
				}
				securityParameters.m_localVerifyData = global::Org.BouncyCastle.Tls.TlsUtilities.CalculateVerifyData(state.serverContext, handshake.HandshakeHash, true);
				handshake.SendMessage(20, securityParameters.LocalVerifyData);
				handshake.Finish();
				state.sessionMasterSecret = securityParameters.MasterSecret;
				state.sessionParameters = new global::Org.BouncyCastle.Tls.SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate).SetMasterSecret(state.serverContext.Crypto.AdoptSecret(state.sessionMasterSecret)).SetNegotiatedVersion(securityParameters.NegotiatedVersion).SetPeerCertificate(securityParameters.PeerCertificate).SetPskIdentity(securityParameters.PskIdentity).SetSrpIdentity(securityParameters.SrpIdentity).SetServerExtensions(state.serverExtensions).Build();
				state.tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(state.tlsSession.SessionID, state.sessionParameters);
				securityParameters.m_tlsUnique = securityParameters.PeerVerifyData;
				state.serverContext.HandshakeComplete(state.server, state.tlsSession);
				recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
				return new global::Org.BouncyCastle.Tls.DtlsTransport(recordLayer);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0001F0FC File Offset: 0x0001D2FC
		protected virtual byte[] GenerateCertificateRequest(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificateRequest.Encode(state.serverContext, buf);
			return buf.ToArray();
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0001F124 File Offset: 0x0001D324
		protected virtual byte[] GenerateCertificateStatus(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.CertificateStatus certificateStatus)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificateStatus.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0001F144 File Offset: 0x0001D344
		protected virtual byte[] GenerateNewSessionTicket(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			newSessionTicket.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0001F164 File Offset: 0x0001D364
		internal virtual byte[] GenerateServerHello(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.DtlsRecordLayer recordLayer)
		{
			global::Org.BouncyCastle.Tls.TlsServerContextImpl context = state.serverContext;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion server_version = state.server.GetServerVersion();
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(context.ClientSupportedVersions, server_version))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			securityParameters.m_negotiatedVersion = server_version;
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersionDtlsServer(context);
			bool useGmtUnixTime = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(server_version) && state.server.ShouldUseGmtUnixTime();
			securityParameters.m_serverRandom = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRandomBlock(useGmtUnixTime, context);
			if (!server_version.Equals(global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestDtls(state.server.GetProtocolVersions())))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteDowngradeMarker(server_version, securityParameters.ServerRandom);
			}
			int cipherSuite = global::Org.BouncyCastle.Tls.DtlsProtocol.ValidateSelectedCipherSuite(state.server.GetSelectedCipherSuite(), 80);
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(state.offeredCipherSuites, cipherSuite) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			state.serverExtensions = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(state.server.GetServerExtensions());
			state.server.GetServerExtensionsForConnection(state.serverExtensions);
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = server_version;
			if (server_version.IsLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12))
			{
				legacy_version = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(state.serverExtensions, server_version);
			}
			if (securityParameters.IsSecureRenegotiation)
			{
				byte[] renegExtData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
				if (renegExtData == null)
				{
					state.serverExtensions[65281] = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
				}
			}
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(server_version))
			{
				securityParameters.m_extendedMasterSecret = true;
			}
			else
			{
				securityParameters.m_extendedMasterSecret = (state.offeredExtendedMasterSecret && state.server.ShouldUseExtendedMasterSecret());
				if (securityParameters.IsExtendedMasterSecret)
				{
					global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.serverExtensions);
				}
				else
				{
					if (state.server.RequiresExtendedMasterSecret())
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
					}
					if (state.resumedSession && !state.server.AllowLegacyResumption())
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
				}
			}
			if (state.heartbeat != null || 1 == state.heartbeatPolicy)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddHeartbeatExtension(state.serverExtensions, new global::Org.BouncyCastle.Tls.HeartbeatExtension(state.heartbeatPolicy));
			}
			securityParameters.m_applicationProtocol = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionServer(state.serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			if (state.serverExtensions.Count > 0)
			{
				securityParameters.m_encryptThenMac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(state.serverExtensions);
				securityParameters.m_maxFragmentLength = global::Org.BouncyCastle.Tls.DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, state.clientExtensions, state.serverExtensions, 80);
				securityParameters.m_truncatedHmac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasTruncatedHmacExtension(state.serverExtensions);
				if (!state.resumedSession)
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 17, 80))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 5, 80))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
				}
				state.expectSessionTicket = (!state.resumedSession && global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 35, 80));
			}
			global::Org.BouncyCastle.Tls.DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.MaxFragmentLength);
			global::Org.BouncyCastle.Tls.ServerHello serverHello = new global::Org.BouncyCastle.Tls.ServerHello(legacy_version, securityParameters.ServerRandom, state.tlsSession.SessionID, securityParameters.CipherSuite, state.serverExtensions);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			serverHello.Encode(state.serverContext, buf);
			return buf.ToArray();
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0001F470 File Offset: 0x0001D670
		protected virtual void InvalidateSession(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state)
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

		// Token: 0x06000753 RID: 1875 RVA: 0x0001F4CB File Offset: 0x0001D6CB
		protected virtual void NotifyClientCertificate(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.Certificate clientCertificate)
		{
			if (state.certificateRequest == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.ProcessClientCertificate(state.serverContext, clientCertificate, state.keyExchange, state.server);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		protected virtual void ProcessClientCertificate(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Tls.Certificate clientCertificate = global::Org.BouncyCastle.Tls.Certificate.Parse(new global::Org.BouncyCastle.Tls.Certificate.ParseOptions().SetMaxChainLength(state.server.GetMaxCertificateChainLength()), state.serverContext, buf, null);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			this.NotifyClientCertificate(state, clientCertificate);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0001F540 File Offset: 0x0001D740
		protected virtual void ProcessCertificateVerify(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body, global::Org.BouncyCastle.Tls.TlsHandshakeHash handshakeHash)
		{
			if (state.certificateRequest == null)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Tls.TlsServerContextImpl serverContext = state.serverContext;
			global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.DigitallySigned.Parse(serverContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.VerifyCertificateVerifyClient(serverContext, state.certificateRequest, certificateVerify, handshakeHash);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001F584 File Offset: 0x0001D784
		protected virtual void ProcessClientHello(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::Org.BouncyCastle.Tls.ClientHello clientHello = global::Org.BouncyCastle.Tls.ClientHello.Parse(new global::System.IO.MemoryStream(body, false), new global::Org.BouncyCastle.Utilities.IO.NullOutputStream());
			this.ProcessClientHello(state, clientHello);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0001F5AC File Offset: 0x0001D7AC
		protected virtual void ProcessClientHello(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Tls.ClientHello clientHello)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = clientHello.Version;
			state.offeredCipherSuites = clientHello.CipherSuites;
			state.clientExtensions = clientHello.Extensions;
			global::Org.BouncyCastle.Tls.TlsServerContextImpl context = state.serverContext;
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			if (!legacy_version.IsDtls)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			context.SetRsaPreMasterSecretVersion(legacy_version);
			context.SetClientSupportedVersions(global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedVersionsExtensionClient(state.clientExtensions));
			global::Org.BouncyCastle.Tls.ProtocolVersion client_version = legacy_version;
			if (context.ClientSupportedVersions == null)
			{
				if (client_version.IsLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12))
				{
					client_version = global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv12;
				}
				context.SetClientSupportedVersions(client_version.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.DTLSv10));
			}
			else
			{
				client_version = global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestDtls(context.ClientSupportedVersions);
			}
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.SERVER_EARLIEST_SUPPORTED_DTLS.IsEqualOrEarlierVersionOf(client_version))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(70);
			}
			context.SetClientVersion(client_version);
			state.server.NotifyClientVersion(context.ClientVersion);
			securityParameters.m_clientRandom = clientHello.Random;
			state.server.NotifyFallback(global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 22016));
			state.server.NotifyOfferedCipherSuites(state.offeredCipherSuites);
			if (global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 255))
			{
				securityParameters.m_secureRenegotiation = true;
			}
			byte[] renegExtData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
			if (renegExtData != null)
			{
				securityParameters.m_secureRenegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
			}
			state.server.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
			state.offeredExtendedMasterSecret = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.clientExtensions);
			if (state.clientExtensions != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetPaddingExtension(state.clientExtensions);
				securityParameters.m_clientServerNames = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetServerNameExtensionClient(state.clientExtensions);
				if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(client_version))
				{
					global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientSigAlgs(securityParameters, state.clientExtensions);
				}
				securityParameters.m_clientSupportedGroups = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedGroupsExtension(state.clientExtensions);
				global::Org.BouncyCastle.Tls.HeartbeatExtension heartbeatExtension = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetHeartbeatExtension(state.clientExtensions);
				if (heartbeatExtension != null)
				{
					if (1 == heartbeatExtension.Mode)
					{
						state.heartbeat = state.server.GetHeartbeat();
					}
					state.heartbeatPolicy = state.server.GetHeartbeatPolicy();
				}
				state.server.ProcessClientExtensions(state.clientExtensions);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
		protected virtual void ProcessClientKeyExchange(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.keyExchange.ProcessClientKeyExchange(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		protected virtual void ProcessClientSupplementalData(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.Collections.IList clientSupplementalData = global::Org.BouncyCastle.Tls.TlsProtocol.ReadSupplementalDataMessage(new global::System.IO.MemoryStream(body, false));
			state.server.ProcessClientSupplementalData(clientSupplementalData);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001F810 File Offset: 0x0001DA10
		protected virtual bool ExpectCertificateVerifyMessage(global::Org.BouncyCastle.Tls.DtlsServerProtocol.ServerHandshakeState state)
		{
			if (state.certificateRequest == null)
			{
				return false;
			}
			global::Org.BouncyCastle.Tls.Certificate clientCertificate = state.serverContext.SecurityParameters.PeerCertificate;
			return clientCertificate != null && !clientCertificate.IsEmpty && (state.keyExchange == null || state.keyExchange.RequiresCertificateVerify);
		}

		// Token: 0x04000515 RID: 1301
		protected bool m_verifyRequests = true;

		// Token: 0x020007A7 RID: 1959
		protected internal class ServerHandshakeState
		{
			// Token: 0x04002305 RID: 8965
			internal global::Org.BouncyCastle.Tls.TlsServer server;

			// Token: 0x04002306 RID: 8966
			internal global::Org.BouncyCastle.Tls.TlsServerContextImpl serverContext;

			// Token: 0x04002307 RID: 8967
			internal global::Org.BouncyCastle.Tls.TlsSession tlsSession;

			// Token: 0x04002308 RID: 8968
			internal global::Org.BouncyCastle.Tls.SessionParameters sessionParameters;

			// Token: 0x04002309 RID: 8969
			internal global::Org.BouncyCastle.Tls.Crypto.TlsSecret sessionMasterSecret;

			// Token: 0x0400230A RID: 8970
			internal global::Org.BouncyCastle.Tls.SessionParameters.Builder sessionParametersBuilder;

			// Token: 0x0400230B RID: 8971
			internal int[] offeredCipherSuites;

			// Token: 0x0400230C RID: 8972
			internal global::System.Collections.IDictionary clientExtensions;

			// Token: 0x0400230D RID: 8973
			internal global::System.Collections.IDictionary serverExtensions;

			// Token: 0x0400230E RID: 8974
			internal bool offeredExtendedMasterSecret;

			// Token: 0x0400230F RID: 8975
			internal bool resumedSession;

			// Token: 0x04002310 RID: 8976
			internal bool expectSessionTicket;

			// Token: 0x04002311 RID: 8977
			internal global::Org.BouncyCastle.Tls.TlsKeyExchange keyExchange;

			// Token: 0x04002312 RID: 8978
			internal global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials;

			// Token: 0x04002313 RID: 8979
			internal global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest;

			// Token: 0x04002314 RID: 8980
			internal global::Org.BouncyCastle.Tls.TlsHeartbeat heartbeat;

			// Token: 0x04002315 RID: 8981
			internal short heartbeatPolicy = 2;
		}
	}
}
