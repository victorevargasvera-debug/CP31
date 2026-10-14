using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000321 RID: 801
	public class DtlsClientProtocol : global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol
	{
		// Token: 0x060021AA RID: 8618 RVA: 0x00094368 File Offset: 0x00092568
		public DtlsClientProtocol(global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(secureRandom)
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00094374 File Offset: 0x00092574
		public virtual global::Org.BouncyCastle.Crypto.Tls.DtlsTransport Connect(global::Org.BouncyCastle.Crypto.Tls.TlsClient client, global::Org.BouncyCastle.Crypto.Tls.DatagramTransport transport)
		{
			if (client == null)
			{
				throw new global::System.ArgumentNullException("client");
			}
			if (transport == null)
			{
				throw new global::System.ArgumentNullException("transport");
			}
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = new global::Org.BouncyCastle.Crypto.Tls.SecurityParameters();
			securityParameters.entity = 1;
			global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state = new global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState();
			state.client = client;
			state.clientContext = new global::Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl(this.mSecureRandom, securityParameters);
			securityParameters.clientRandom = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRandomBlock(client.ShouldUseGmtUnixTime(), state.clientContext.NonceRandomGenerator);
			client.Init(state.clientContext);
			global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer = new global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer(transport, state.clientContext, client, 22);
			client.NotifyCloseHandle(recordLayer);
			global::Org.BouncyCastle.Crypto.Tls.TlsSession sessionToResume = state.client.GetSessionToResume();
			if (sessionToResume != null && sessionToResume.IsResumable)
			{
				global::Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
				if (sessionParameters != null && sessionParameters.IsExtendedMasterSecret)
				{
					state.tlsSession = sessionToResume;
					state.sessionParameters = sessionParameters;
				}
			}
			global::Org.BouncyCastle.Crypto.Tls.DtlsTransport result;
			try
			{
				result = this.ClientHandshake(state, recordLayer);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert fatalAlert)
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
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			finally
			{
				securityParameters.Clear();
			}
			return result;
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000944C4 File Offset: 0x000926C4
		internal virtual void AbortClientHandshake(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer, byte alertDescription)
		{
			recordLayer.Fail(alertDescription);
			this.InvalidateSession(state);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000944D4 File Offset: 0x000926D4
		internal virtual global::Org.BouncyCastle.Crypto.Tls.DtlsTransport ClientHandshake(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = state.clientContext.SecurityParameters;
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake handshake = new global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake(state.clientContext, recordLayer, state.client.GetHandshakeTimeoutMillis());
			byte[] clientHelloBody = this.GenerateClientHello(state, state.client);
			recordLayer.SetWriteVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv10);
			handshake.SendMessage(1, clientHelloBody);
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message serverMessage = handshake.ReceiveMessage();
			while (serverMessage.Type == 3)
			{
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion readVersion = recordLayer.ReadVersion;
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion client_version = state.clientContext.ClientVersion;
				if (!readVersion.IsEqualOrEarlierVersionOf(client_version))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				recordLayer.ReadVersion = null;
				byte[] cookie = this.ProcessHelloVerifyRequest(state, serverMessage.Body);
				byte[] patched = global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.PatchClientHelloWithCookie(clientHelloBody, cookie);
				handshake.ResetHandshakeMessagesDigest();
				handshake.SendMessage(1, patched);
				serverMessage = handshake.ReceiveMessage();
			}
			if (serverMessage.Type != 2)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion recordLayerVersion = recordLayer.ReadVersion;
			this.ReportServerVersion(state, recordLayerVersion);
			recordLayer.SetWriteVersion(recordLayerVersion);
			this.ProcessServerHello(state, serverMessage.Body);
			handshake.NotifyHelloComplete();
			global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.maxFragmentLength);
			if (state.resumedSession)
			{
				securityParameters.masterSecret = global::Org.BouncyCastle.Utilities.Arrays.Clone(state.sessionParameters.MasterSecret);
				recordLayer.InitPendingEpoch(state.client.GetCipher());
				byte[] resExpectedServerVerifyData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, "server finished", global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
				this.ProcessFinished(handshake.ReceiveMessageBody(20), resExpectedServerVerifyData);
				byte[] resClientVerifyData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, "client finished", global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
				handshake.SendMessage(20, resClientVerifyData);
				handshake.Finish();
				state.clientContext.SetResumableSession(state.tlsSession);
				state.client.NotifyHandshakeComplete();
				return new global::Org.BouncyCastle.Crypto.Tls.DtlsTransport(recordLayer);
			}
			this.InvalidateSession(state);
			if (state.selectedSessionID.Length != 0)
			{
				state.tlsSession = new global::Org.BouncyCastle.Crypto.Tls.TlsSessionImpl(state.selectedSessionID, null);
			}
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
			state.keyExchange = state.client.GetKeyExchange();
			state.keyExchange.Init(state.clientContext);
			global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate = null;
			if (serverMessage.Type == 11)
			{
				serverCertificate = this.ProcessServerCertificate(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.keyExchange.SkipServerCredentials();
			}
			if (serverCertificate == null || serverCertificate.IsEmpty)
			{
				state.allowCertificateStatus = false;
			}
			if (serverMessage.Type == 22)
			{
				this.ProcessCertificateStatus(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
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
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, state.certificateRequest.SupportedSignatureAlgorithms);
				serverMessage = handshake.ReceiveMessage();
			}
			if (serverMessage.Type != 14)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			if (serverMessage.Body.Length != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			handshake.HandshakeHash.SealHashAlgorithms();
			global::System.Collections.IList clientSupplementalData = state.client.GetClientSupplementalData();
			if (clientSupplementalData != null)
			{
				byte[] supplementalDataBody = global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.GenerateSupplementalData(clientSupplementalData);
				handshake.SendMessage(23, supplementalDataBody);
			}
			if (state.certificateRequest != null)
			{
				state.clientCredentials = state.authentication.GetClientCredentials(state.certificateRequest);
				global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate = null;
				if (state.clientCredentials != null)
				{
					clientCertificate = state.clientCredentials.Certificate;
				}
				if (clientCertificate == null)
				{
					clientCertificate = global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain;
				}
				byte[] certificateBody = global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.GenerateCertificate(clientCertificate);
				handshake.SendMessage(11, certificateBody);
			}
			if (state.clientCredentials != null)
			{
				state.keyExchange.ProcessClientCredentials(state.clientCredentials);
			}
			else
			{
				state.keyExchange.SkipClientCredentials();
			}
			byte[] clientKeyExchangeBody = this.GenerateClientKeyExchange(state);
			handshake.SendMessage(16, clientKeyExchangeBody);
			global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash prepareFinishHash = handshake.PrepareToFinish();
			securityParameters.sessionHash = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.clientContext, prepareFinishHash, null);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(state.clientContext, state.keyExchange);
			recordLayer.InitPendingEpoch(state.client.GetCipher());
			if (state.clientCredentials != null && state.clientCredentials is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials signerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)state.clientCredentials;
				global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(state.clientContext, signerCredentials);
				byte[] hash;
				if (signatureAndHashAlgorithm == null)
				{
					hash = securityParameters.SessionHash;
				}
				else
				{
					hash = prepareFinishHash.GetFinalHash(signatureAndHashAlgorithm.Hash);
				}
				byte[] signature = signerCredentials.GenerateCertificateSignature(hash);
				global::Org.BouncyCastle.Crypto.Tls.DigitallySigned certificateVerify = new global::Org.BouncyCastle.Crypto.Tls.DigitallySigned(signatureAndHashAlgorithm, signature);
				byte[] certificateVerifyBody = this.GenerateCertificateVerify(state, certificateVerify);
				handshake.SendMessage(15, certificateVerifyBody);
			}
			byte[] clientVerifyData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, "client finished", global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
			handshake.SendMessage(20, clientVerifyData);
			if (state.expectSessionTicket)
			{
				serverMessage = handshake.ReceiveMessage();
				if (serverMessage.Type != 4)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.ProcessNewSessionTicket(state, serverMessage.Body);
			}
			byte[] expectedServerVerifyData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(state.clientContext, "server finished", global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
			this.ProcessFinished(handshake.ReceiveMessageBody(20), expectedServerVerifyData);
			handshake.Finish();
			if (state.tlsSession != null)
			{
				state.sessionParameters = new global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetCompressionAlgorithm(securityParameters.CompressionAlgorithm).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetMasterSecret(securityParameters.MasterSecret).SetPeerCertificate(serverCertificate).SetPskIdentity(securityParameters.PskIdentity).SetSrpIdentity(securityParameters.SrpIdentity).SetServerExtensions(state.serverExtensions).Build();
				state.tlsSession = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ImportSession(state.tlsSession.SessionID, state.sessionParameters);
				state.clientContext.SetResumableSession(state.tlsSession);
			}
			state.client.NotifyHandshakeComplete();
			return new global::Org.BouncyCastle.Crypto.Tls.DtlsTransport(recordLayer);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00094AB0 File Offset: 0x00092CB0
		protected virtual byte[] GenerateCertificateVerify(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.DigitallySigned certificateVerify)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificateVerify.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00094AD0 File Offset: 0x00092CD0
		protected virtual byte[] GenerateClientHello(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.TlsClient client)
		{
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion client_version = client.ClientVersion;
			if (!client_version.IsDtls)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl clientContext = state.clientContext;
			clientContext.SetClientVersion(client_version);
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = clientContext.SecurityParameters;
			byte[] session_id = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			if (state.tlsSession != null)
			{
				session_id = state.tlsSession.SessionID;
				if (session_id == null || session_id.Length > 32)
				{
					session_id = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
				}
			}
			bool isFallback = client.IsFallback;
			state.offeredCipherSuites = client.GetCipherSuites();
			if (session_id.Length != 0 && state.sessionParameters != null && (!state.sessionParameters.IsExtendedMasterSecret || !global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, state.sessionParameters.CipherSuite) || state.sessionParameters.CompressionAlgorithm != 0))
			{
				session_id = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			}
			state.clientExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(client.GetClientExtensions());
			global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.clientExtensions);
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(client_version, buf);
			buf.Write(securityParameters.ClientRandom, 0, securityParameters.ClientRandom.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(session_id, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, buf);
			byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
			bool flag = renegExtData == null;
			bool noRenegSCSV = !global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 255);
			if (flag && noRenegSCSV)
			{
				state.offeredCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(state.offeredCipherSuites, 255);
			}
			if (isFallback && !global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 22016))
			{
				state.offeredCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(state.offeredCipherSuites, 22016);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(state.offeredCipherSuites, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(new byte[1], buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(buf, state.clientExtensions);
			return buf.ToArray();
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00094C74 File Offset: 0x00092E74
		protected virtual byte[] GenerateClientKeyExchange(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			state.keyExchange.GenerateClientKeyExchange(buf);
			return buf.ToArray();
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00094C99 File Offset: 0x00092E99
		protected virtual void InvalidateSession(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state)
		{
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

		// Token: 0x060021B2 RID: 8626 RVA: 0x00094CD0 File Offset: 0x00092ED0
		protected virtual void ProcessCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			if (state.authentication == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.certificateRequest = global::Org.BouncyCastle.Crypto.Tls.CertificateRequest.Parse(state.clientContext, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			state.keyExchange.ValidateCertificateRequest(state.certificateRequest);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00094D20 File Offset: 0x00092F20
		protected virtual void ProcessCertificateStatus(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			if (!state.allowCertificateStatus)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.certificateStatus = global::Org.BouncyCastle.Crypto.Tls.CertificateStatus.Parse(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00094D58 File Offset: 0x00092F58
		protected virtual byte[] ProcessHelloVerifyRequest(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion server_version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(memoryStream);
			byte[] cookie = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			if (!server_version.IsEqualOrEarlierVersionOf(state.clientContext.ClientVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			if (!global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.DTLSv12.IsEqualOrEarlierVersionOf(server_version) && cookie.Length > 32)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return cookie;
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00094DB8 File Offset: 0x00092FB8
		protected virtual void ProcessNewSessionTicket(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket = global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket.Parse(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			state.client.NotifyNewSessionTicket(newSessionTicket);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00094DE4 File Offset: 0x00092FE4
		protected virtual global::Org.BouncyCastle.Crypto.Tls.Certificate ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate = global::Org.BouncyCastle.Crypto.Tls.Certificate.Parse(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			state.keyExchange.ProcessServerCertificate(serverCertificate);
			state.authentication = state.client.GetAuthentication();
			state.authentication.NotifyServerCertificate(serverCertificate);
			return serverCertificate;
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00094E30 File Offset: 0x00093030
		protected virtual void ProcessServerHello(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = state.clientContext.SecurityParameters;
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion server_version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(buf);
			this.ReportServerVersion(state, server_version);
			securityParameters.serverRandom = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(32, buf);
			state.selectedSessionID = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(buf);
			if (state.selectedSessionID.Length > 32)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			state.client.NotifySessionID(state.selectedSessionID);
			state.resumedSession = (state.selectedSessionID.Length != 0 && state.tlsSession != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(state.selectedSessionID, state.tlsSession.SessionID));
			int selectedCipherSuite = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || global::Org.BouncyCastle.Crypto.Tls.CipherSuite.IsScsv(selectedCipherSuite) || !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, state.clientContext.ServerVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.ValidateSelectedCipherSuite(selectedCipherSuite, 47);
			state.client.NotifySelectedCipherSuite(selectedCipherSuite);
			byte selectedCompressionMethod = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf);
			if (selectedCompressionMethod != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			state.client.NotifySelectedCompressionMethod(selectedCompressionMethod);
			state.serverExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(buf);
			securityParameters.extendedMasterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.serverExtensions);
			if (!securityParameters.IsExtendedMasterSecret && (state.resumedSession || state.client.RequiresExtendedMasterSecret()))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			if (state.serverExtensions != null)
			{
				foreach (object obj in state.serverExtensions.Keys)
				{
					int extType = (int)obj;
					if (extType != 65281)
					{
						if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(state.clientExtensions, extType) == null)
						{
							throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(110);
						}
						bool resumedSession = state.resumedSession;
					}
				}
			}
			byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
			if (renegExtData != null)
			{
				state.secure_renegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
			}
			state.client.NotifySecureRenegotiation(state.secure_renegotiation);
			global::System.Collections.IDictionary sessionClientExtensions = state.clientExtensions;
			global::System.Collections.IDictionary sessionServerExtensions = state.serverExtensions;
			if (state.resumedSession)
			{
				if (selectedCipherSuite != state.sessionParameters.CipherSuite || selectedCompressionMethod != state.sessionParameters.CompressionAlgorithm)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				sessionClientExtensions = null;
				sessionServerExtensions = state.sessionParameters.ReadServerExtensions();
			}
			securityParameters.cipherSuite = selectedCipherSuite;
			securityParameters.compressionAlgorithm = selectedCompressionMethod;
			if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
			{
				bool serverSentEncryptThenMAC = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
				if (serverSentEncryptThenMAC && !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				securityParameters.encryptThenMac = serverSentEncryptThenMAC;
				securityParameters.maxFragmentLength = global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, sessionClientExtensions, sessionServerExtensions, 47);
				securityParameters.truncatedHMac = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasTruncatedHMacExtension(sessionServerExtensions);
				state.allowCertificateStatus = (!state.resumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47));
				state.expectSessionTicket = (!state.resumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47));
			}
			if (sessionClientExtensions != null)
			{
				state.client.ProcessServerExtensions(sessionServerExtensions);
			}
			securityParameters.prfAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetPrfAlgorithm(state.clientContext, securityParameters.CipherSuite);
			securityParameters.verifyDataLength = 12;
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00095170 File Offset: 0x00093370
		protected virtual void ProcessServerKeyExchange(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.keyExchange.ProcessServerKeyExchange(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x00095198 File Offset: 0x00093398
		protected virtual void ProcessServerSupplementalData(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, byte[] body)
		{
			global::System.Collections.IList serverSupplementalData = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadSupplementalDataMessage(new global::System.IO.MemoryStream(body, false));
			state.client.ProcessServerSupplementalData(serverSupplementalData);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000951C0 File Offset: 0x000933C0
		protected virtual void ReportServerVersion(global::Org.BouncyCastle.Crypto.Tls.DtlsClientProtocol.ClientHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion server_version)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl clientContext = state.clientContext;
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion currentServerVersion = clientContext.ServerVersion;
			if (currentServerVersion == null)
			{
				clientContext.SetServerVersion(server_version);
				state.client.NotifyServerVersion(server_version);
				return;
			}
			if (!currentServerVersion.Equals(server_version))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00095204 File Offset: 0x00093404
		protected static byte[] PatchClientHelloWithCookie(byte[] clientHelloBody, byte[] cookie)
		{
			int sessionIDPos = 34;
			int sessionIDLength = (int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(clientHelloBody, sessionIDPos);
			int cookieLengthPos = sessionIDPos + 1 + sessionIDLength;
			int cookiePos = cookieLengthPos + 1;
			byte[] patched = new byte[clientHelloBody.Length + cookie.Length];
			global::System.Array.Copy(clientHelloBody, 0, patched, 0, cookieLengthPos);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(cookie.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8((byte)cookie.Length, patched, cookieLengthPos);
			global::System.Array.Copy(cookie, 0, patched, cookiePos, cookie.Length);
			global::System.Array.Copy(clientHelloBody, cookiePos, patched, cookiePos + cookie.Length, clientHelloBody.Length - cookiePos);
			return patched;
		}

		// Token: 0x020007F5 RID: 2037
		protected internal class ClientHandshakeState
		{
			// Token: 0x0400247D RID: 9341
			internal global::Org.BouncyCastle.Crypto.Tls.TlsClient client;

			// Token: 0x0400247E RID: 9342
			internal global::Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl clientContext;

			// Token: 0x0400247F RID: 9343
			internal global::Org.BouncyCastle.Crypto.Tls.TlsSession tlsSession;

			// Token: 0x04002480 RID: 9344
			internal global::Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters;

			// Token: 0x04002481 RID: 9345
			internal global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder sessionParametersBuilder;

			// Token: 0x04002482 RID: 9346
			internal int[] offeredCipherSuites;

			// Token: 0x04002483 RID: 9347
			internal global::System.Collections.IDictionary clientExtensions;

			// Token: 0x04002484 RID: 9348
			internal global::System.Collections.IDictionary serverExtensions;

			// Token: 0x04002485 RID: 9349
			internal byte[] selectedSessionID;

			// Token: 0x04002486 RID: 9350
			internal bool resumedSession;

			// Token: 0x04002487 RID: 9351
			internal bool secure_renegotiation;

			// Token: 0x04002488 RID: 9352
			internal bool allowCertificateStatus;

			// Token: 0x04002489 RID: 9353
			internal bool expectSessionTicket;

			// Token: 0x0400248A RID: 9354
			internal global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange keyExchange;

			// Token: 0x0400248B RID: 9355
			internal global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication authentication;

			// Token: 0x0400248C RID: 9356
			internal global::Org.BouncyCastle.Crypto.Tls.CertificateStatus certificateStatus;

			// Token: 0x0400248D RID: 9357
			internal global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest;

			// Token: 0x0400248E RID: 9358
			internal global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials;
		}
	}
}
