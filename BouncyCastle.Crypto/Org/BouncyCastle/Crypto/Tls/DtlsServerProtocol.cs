using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000329 RID: 809
	public class DtlsServerProtocol : global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol
	{
		// Token: 0x06002201 RID: 8705 RVA: 0x000966C8 File Offset: 0x000948C8
		public DtlsServerProtocol(global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(secureRandom)
		{
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x000966D8 File Offset: 0x000948D8
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x000966E0 File Offset: 0x000948E0
		public virtual bool VerifyRequests
		{
			get
			{
				return this.mVerifyRequests;
			}
			set
			{
				this.mVerifyRequests = value;
			}
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000966EC File Offset: 0x000948EC
		public virtual global::Org.BouncyCastle.Crypto.Tls.DtlsTransport Accept(global::Org.BouncyCastle.Crypto.Tls.TlsServer server, global::Org.BouncyCastle.Crypto.Tls.DatagramTransport transport)
		{
			if (server == null)
			{
				throw new global::System.ArgumentNullException("server");
			}
			if (transport == null)
			{
				throw new global::System.ArgumentNullException("transport");
			}
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = new global::Org.BouncyCastle.Crypto.Tls.SecurityParameters();
			securityParameters.entity = 0;
			global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state = new global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState();
			state.server = server;
			state.serverContext = new global::Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl(this.mSecureRandom, securityParameters);
			securityParameters.serverRandom = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRandomBlock(server.ShouldUseGmtUnixTime(), state.serverContext.NonceRandomGenerator);
			server.Init(state.serverContext);
			global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer = new global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer(transport, state.serverContext, server, 22);
			server.NotifyCloseHandle(recordLayer);
			global::Org.BouncyCastle.Crypto.Tls.DtlsTransport result;
			try
			{
				result = this.ServerHandshake(state, recordLayer);
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert fatalAlert)
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
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			finally
			{
				securityParameters.Clear();
			}
			return result;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000967FC File Offset: 0x000949FC
		internal virtual void AbortServerHandshake(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer, byte alertDescription)
		{
			recordLayer.Fail(alertDescription);
			this.InvalidateSession(state);
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x0009680C File Offset: 0x00094A0C
		internal virtual global::Org.BouncyCastle.Crypto.Tls.DtlsTransport ServerHandshake(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.DtlsRecordLayer recordLayer)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = state.serverContext.SecurityParameters;
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake handshake = new global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake(state.serverContext, recordLayer, state.server.GetHandshakeTimeoutMillis());
			global::Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake.Message clientMessage = handshake.ReceiveMessage();
			if (clientMessage.Type != 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			this.ProcessClientHello(state, clientMessage.Body);
			byte[] serverHelloBody = this.GenerateServerHello(state);
			global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.maxFragmentLength);
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion recordLayerVersion = state.serverContext.ServerVersion;
			recordLayer.ReadVersion = recordLayerVersion;
			recordLayer.SetWriteVersion(recordLayerVersion);
			handshake.SendMessage(2, serverHelloBody);
			handshake.NotifyHelloComplete();
			global::System.Collections.IList serverSupplementalData = state.server.GetServerSupplementalData();
			if (serverSupplementalData != null)
			{
				byte[] supplementalDataBody = global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.GenerateSupplementalData(serverSupplementalData);
				handshake.SendMessage(23, supplementalDataBody);
			}
			state.keyExchange = state.server.GetKeyExchange();
			state.keyExchange.Init(state.serverContext);
			state.serverCredentials = state.server.GetCredentials();
			global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate = null;
			if (state.serverCredentials == null)
			{
				state.keyExchange.SkipServerCredentials();
			}
			else
			{
				state.keyExchange.ProcessServerCredentials(state.serverCredentials);
				serverCertificate = state.serverCredentials.Certificate;
				byte[] certificateBody = global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.GenerateCertificate(serverCertificate);
				handshake.SendMessage(11, certificateBody);
			}
			if (serverCertificate == null || serverCertificate.IsEmpty)
			{
				state.allowCertificateStatus = false;
			}
			if (state.allowCertificateStatus)
			{
				global::Org.BouncyCastle.Crypto.Tls.CertificateStatus certificateStatus = state.server.GetCertificateStatus();
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
				if (state.certificateRequest != null)
				{
					if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(state.serverContext) != (state.certificateRequest.SupportedSignatureAlgorithms != null))
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
					}
					state.keyExchange.ValidateCertificateRequest(state.certificateRequest);
					byte[] certificateRequestBody = this.GenerateCertificateRequest(state, state.certificateRequest);
					handshake.SendMessage(13, certificateRequestBody);
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, state.certificateRequest.SupportedSignatureAlgorithms);
				}
			}
			handshake.SendMessage(14, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes);
			handshake.HandshakeHash.SealHashAlgorithms();
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
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(state.serverContext))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.NotifyClientCertificate(state, global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain);
			}
			if (clientMessage.Type == 16)
			{
				this.ProcessClientKeyExchange(state, clientMessage.Body);
				global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash prepareFinishHash = handshake.PrepareToFinish();
				securityParameters.sessionHash = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.serverContext, prepareFinishHash, null);
				global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(state.serverContext, state.keyExchange);
				recordLayer.InitPendingEpoch(state.server.GetCipher());
				if (this.ExpectCertificateVerifyMessage(state))
				{
					byte[] certificateVerifyBody = handshake.ReceiveMessageBody(15);
					this.ProcessCertificateVerify(state, certificateVerifyBody, prepareFinishHash);
				}
				byte[] expectedClientVerifyData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(state.serverContext, "client finished", global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.serverContext, handshake.HandshakeHash, null));
				this.ProcessFinished(handshake.ReceiveMessageBody(20), expectedClientVerifyData);
				if (state.expectSessionTicket)
				{
					global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket = state.server.GetNewSessionTicket();
					byte[] newSessionTicketBody = this.GenerateNewSessionTicket(state, newSessionTicket);
					handshake.SendMessage(4, newSessionTicketBody);
				}
				byte[] serverVerifyData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateVerifyData(state.serverContext, "server finished", global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(state.serverContext, handshake.HandshakeHash, null));
				handshake.SendMessage(20, serverVerifyData);
				handshake.Finish();
				state.server.NotifyHandshakeComplete();
				return new global::Org.BouncyCastle.Crypto.Tls.DtlsTransport(recordLayer);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00096BE3 File Offset: 0x00094DE3
		protected virtual void InvalidateSession(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state)
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

		// Token: 0x06002208 RID: 8712 RVA: 0x00096C1C File Offset: 0x00094E1C
		protected virtual byte[] GenerateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificateRequest.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00096C3C File Offset: 0x00094E3C
		protected virtual byte[] GenerateCertificateStatus(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.CertificateStatus certificateStatus)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			certificateStatus.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00096C5C File Offset: 0x00094E5C
		protected virtual byte[] GenerateNewSessionTicket(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			newSessionTicket.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00096C7C File Offset: 0x00094E7C
		protected virtual byte[] GenerateServerHello(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = state.serverContext.SecurityParameters;
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion server_version = state.server.GetServerVersion();
			if (!server_version.IsEqualOrEarlierVersionOf(state.serverContext.ClientVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			state.serverContext.SetServerVersion(server_version);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(state.serverContext.ServerVersion, buf);
			buf.Write(securityParameters.ServerRandom, 0, securityParameters.ServerRandom.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, buf);
			int selectedCipherSuite = state.server.GetSelectedCipherSuite();
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || global::Org.BouncyCastle.Crypto.Tls.CipherSuite.IsScsv(selectedCipherSuite) || !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, state.serverContext.ServerVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.ValidateSelectedCipherSuite(selectedCipherSuite, 80);
			securityParameters.cipherSuite = selectedCipherSuite;
			byte selectedCompressionMethod = state.server.GetSelectedCompressionMethod();
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCompressionMethods, selectedCompressionMethod))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			securityParameters.compressionAlgorithm = selectedCompressionMethod;
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(selectedCipherSuite, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(selectedCompressionMethod, buf);
			state.serverExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(state.server.GetServerExtensions());
			if (state.secure_renegotiation)
			{
				byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
				if (renegExtData == null)
				{
					state.serverExtensions[65281] = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes);
				}
			}
			if (securityParameters.IsExtendedMasterSecret)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.serverExtensions);
			}
			if (state.serverExtensions.Count > 0)
			{
				securityParameters.encryptThenMac = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(state.serverExtensions);
				securityParameters.maxFragmentLength = global::Org.BouncyCastle.Crypto.Tls.DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, state.clientExtensions, state.serverExtensions, 80);
				securityParameters.truncatedHMac = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasTruncatedHMacExtension(state.serverExtensions);
				state.allowCertificateStatus = (!state.resumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 5, 80));
				state.expectSessionTicket = (!state.resumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 35, 80));
				global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(buf, state.serverExtensions);
			}
			securityParameters.prfAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetPrfAlgorithm(state.serverContext, securityParameters.CipherSuite);
			securityParameters.verifyDataLength = 12;
			return buf.ToArray();
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00096EB4 File Offset: 0x000950B4
		protected virtual void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			if (state.certificateRequest == null)
			{
				throw new global::System.InvalidOperationException();
			}
			if (state.clientCertificate != null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			state.clientCertificate = clientCertificate;
			if (clientCertificate.IsEmpty)
			{
				state.keyExchange.SkipClientCredentials();
			}
			else
			{
				state.clientCertificateType = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetClientCertificateType(clientCertificate, state.serverCredentials.Certificate);
				state.keyExchange.ProcessClientCertificate(clientCertificate);
			}
			state.server.NotifyClientCertificate(clientCertificate);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00096F2C File Offset: 0x0009512C
		protected virtual void ProcessClientCertificate(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate = global::Org.BouncyCastle.Crypto.Tls.Certificate.Parse(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			this.NotifyClientCertificate(state, clientCertificate);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00096F54 File Offset: 0x00095154
		protected virtual void ProcessCertificateVerify(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body, global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash prepareFinishHash)
		{
			if (state.certificateRequest == null)
			{
				throw new global::System.InvalidOperationException();
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl context = state.serverContext;
			global::Org.BouncyCastle.Crypto.Tls.DigitallySigned clientCertificateVerify = global::Org.BouncyCastle.Crypto.Tls.DigitallySigned.Parse(context, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			try
			{
				global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAlgorithm = clientCertificateVerify.Algorithm;
				byte[] hash;
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(state.certificateRequest.SupportedSignatureAlgorithms, signatureAlgorithm);
					hash = prepareFinishHash.GetFinalHash(signatureAlgorithm.Hash);
				}
				else
				{
					hash = context.SecurityParameters.SessionHash;
				}
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(state.clientCertificate.GetCertificateAt(0).SubjectPublicKeyInfo);
				global::Org.BouncyCastle.Crypto.Tls.TlsSigner tlsSigner = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateTlsSigner((byte)state.clientCertificateType);
				tlsSigner.Init(context);
				if (!tlsSigner.VerifyRawSignature(signatureAlgorithm, clientCertificateVerify.Signature, publicKey, hash))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(51);
				}
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert tlsFatalAlert)
			{
				throw tlsFatalAlert;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(51, e);
			}
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0009703C File Offset: 0x0009523C
		protected virtual void ProcessClientHello(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion client_version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(buf);
			if (!client_version.IsDtls)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			byte[] client_random = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(32, buf);
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(buf).Length > 32)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(buf);
			int cipher_suites_length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
			if (cipher_suites_length < 2 || (cipher_suites_length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			state.offeredCipherSuites = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16Array(cipher_suites_length / 2, buf);
			int compression_methods_length = (int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf);
			if (compression_methods_length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			state.offeredCompressionMethods = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8Array(compression_methods_length, buf);
			state.clientExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl serverContext = state.serverContext;
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = serverContext.SecurityParameters;
			securityParameters.extendedMasterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.clientExtensions);
			if (!securityParameters.IsExtendedMasterSecret && state.server.RequiresExtendedMasterSecret())
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			serverContext.SetClientVersion(client_version);
			state.server.NotifyClientVersion(client_version);
			state.server.NotifyFallback(global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 22016));
			securityParameters.clientRandom = client_random;
			state.server.NotifyOfferedCipherSuites(state.offeredCipherSuites);
			state.server.NotifyOfferedCompressionMethods(state.offeredCompressionMethods);
			if (global::Org.BouncyCastle.Utilities.Arrays.Contains(state.offeredCipherSuites, 255))
			{
				state.secure_renegotiation = true;
			}
			byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
			if (renegExtData != null)
			{
				state.secure_renegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
			}
			state.server.NotifySecureRenegotiation(state.secure_renegotiation);
			if (state.clientExtensions != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetPaddingExtension(state.clientExtensions);
				state.server.ProcessClientExtensions(state.clientExtensions);
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00097200 File Offset: 0x00095400
		protected virtual void ProcessClientKeyExchange(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(body, false);
			state.keyExchange.ProcessClientKeyExchange(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00097228 File Offset: 0x00095428
		protected virtual void ProcessClientSupplementalData(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state, byte[] body)
		{
			global::System.Collections.IList clientSupplementalData = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadSupplementalDataMessage(new global::System.IO.MemoryStream(body, false));
			state.server.ProcessClientSupplementalData(clientSupplementalData);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0009724E File Offset: 0x0009544E
		protected virtual bool ExpectCertificateVerifyMessage(global::Org.BouncyCastle.Crypto.Tls.DtlsServerProtocol.ServerHandshakeState state)
		{
			return state.clientCertificateType >= 0 && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasSigningCapability((byte)state.clientCertificateType);
		}

		// Token: 0x04000D14 RID: 3348
		protected bool mVerifyRequests = true;

		// Token: 0x020007FA RID: 2042
		protected internal class ServerHandshakeState
		{
			// Token: 0x04002495 RID: 9365
			internal global::Org.BouncyCastle.Crypto.Tls.TlsServer server;

			// Token: 0x04002496 RID: 9366
			internal global::Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl serverContext;

			// Token: 0x04002497 RID: 9367
			internal global::Org.BouncyCastle.Crypto.Tls.TlsSession tlsSession;

			// Token: 0x04002498 RID: 9368
			internal global::Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters;

			// Token: 0x04002499 RID: 9369
			internal global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder sessionParametersBuilder;

			// Token: 0x0400249A RID: 9370
			internal int[] offeredCipherSuites;

			// Token: 0x0400249B RID: 9371
			internal byte[] offeredCompressionMethods;

			// Token: 0x0400249C RID: 9372
			internal global::System.Collections.IDictionary clientExtensions;

			// Token: 0x0400249D RID: 9373
			internal global::System.Collections.IDictionary serverExtensions;

			// Token: 0x0400249E RID: 9374
			internal bool resumedSession;

			// Token: 0x0400249F RID: 9375
			internal bool secure_renegotiation;

			// Token: 0x040024A0 RID: 9376
			internal bool allowCertificateStatus;

			// Token: 0x040024A1 RID: 9377
			internal bool expectSessionTicket;

			// Token: 0x040024A2 RID: 9378
			internal global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange keyExchange;

			// Token: 0x040024A3 RID: 9379
			internal global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials;

			// Token: 0x040024A4 RID: 9380
			internal global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest;

			// Token: 0x040024A5 RID: 9381
			internal short clientCertificateType = -1;

			// Token: 0x040024A6 RID: 9382
			internal global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate;
		}
	}
}
