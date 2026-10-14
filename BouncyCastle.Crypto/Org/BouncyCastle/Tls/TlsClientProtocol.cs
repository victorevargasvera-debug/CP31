using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000FC RID: 252
	public class TlsClientProtocol : global::Org.BouncyCastle.Tls.TlsProtocol
	{
		// Token: 0x06000903 RID: 2307 RVA: 0x00023C2A File Offset: 0x00021E2A
		public TlsClientProtocol()
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00023C32 File Offset: 0x00021E32
		public TlsClientProtocol(global::System.IO.Stream stream) : base(stream)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00023C3B File Offset: 0x00021E3B
		public TlsClientProtocol(global::System.IO.Stream input, global::System.IO.Stream output) : base(input, output)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00023C48 File Offset: 0x00021E48
		public virtual void Connect(global::Org.BouncyCastle.Tls.TlsClient tlsClient)
		{
			if (tlsClient == null)
			{
				throw new global::System.ArgumentNullException("tlsClient");
			}
			if (this.m_tlsClient != null)
			{
				throw new global::System.InvalidOperationException("'Connect' can only be called once");
			}
			this.m_tlsClient = tlsClient;
			this.m_tlsClientContext = new global::Org.BouncyCastle.Tls.TlsClientContextImpl(tlsClient.Crypto);
			tlsClient.Init(this.m_tlsClientContext);
			tlsClient.NotifyCloseHandle(this);
			this.BeginHandshake();
			if (this.m_blocking)
			{
				this.BlockForHandshake();
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00023CB5 File Offset: 0x00021EB5
		protected override void BeginHandshake()
		{
			base.BeginHandshake();
			this.SendClientHello();
			this.m_connectionState = 1;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00023CCA File Offset: 0x00021ECA
		protected override void CleanupHandshake()
		{
			base.CleanupHandshake();
			this.m_clientAgreements = null;
			this.m_clientBinders = null;
			this.m_clientHello = null;
			this.m_keyExchange = null;
			this.m_authentication = null;
			this.m_certificateStatus = null;
			this.m_certificateRequest = null;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00023D03 File Offset: 0x00021F03
		protected override global::Org.BouncyCastle.Tls.TlsContext Context
		{
			get
			{
				return this.m_tlsClientContext;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00023D0B File Offset: 0x00021F0B
		internal override global::Org.BouncyCastle.Tls.AbstractTlsContext ContextAdmin
		{
			get
			{
				return this.m_tlsClientContext;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00023D13 File Offset: 0x00021F13
		protected override global::Org.BouncyCastle.Tls.TlsPeer Peer
		{
			get
			{
				return this.m_tlsClient;
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00023D1C File Offset: 0x00021F1C
		protected virtual void Handle13HandshakeMessage(short type, global::Org.BouncyCastle.Tls.HandshakeMessageInput buf)
		{
			if (!base.IsTlsV13ConnectionState() || this.m_resumedSession)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			switch (type)
			{
			case 0:
			case 1:
			case 3:
			case 5:
			case 6:
			case 7:
			case 9:
			case 10:
			case 12:
			case 14:
			case 16:
			case 17:
			case 18:
			case 19:
			case 21:
			case 22:
			case 23:
				break;
			case 2:
			{
				short connectionState = this.m_connectionState;
				if (connectionState == 1)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				if (connectionState != 3)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				global::Org.BouncyCastle.Tls.ServerHello serverHello = this.ReceiveServerHelloMessage(buf);
				if (serverHello.IsHelloRetryRequest())
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.Process13ServerHello(serverHello, true);
				buf.UpdateHash(this.m_handshakeHash);
				this.m_connectionState = 4;
				this.Process13ServerHelloCoda(serverHello, true);
				return;
			}
			case 4:
				this.Receive13NewSessionTicket(buf);
				return;
			case 8:
				if (this.m_connectionState == 4)
				{
					this.Receive13EncryptedExtensions(buf);
					this.m_connectionState = 5;
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			case 11:
			{
				short connectionState = this.m_connectionState;
				if (connectionState == 5 || connectionState == 11)
				{
					if (this.m_connectionState != 11)
					{
						this.Skip13CertificateRequest();
					}
					this.Receive13ServerCertificate(buf);
					this.m_connectionState = 7;
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			case 13:
			{
				short connectionState = this.m_connectionState;
				if (connectionState != 5)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				this.Receive13CertificateRequest(buf, false);
				this.m_connectionState = 11;
				return;
			}
			case 15:
				if (this.m_connectionState == 7)
				{
					this.Receive13ServerCertificateVerify(buf);
					buf.UpdateHash(this.m_handshakeHash);
					this.m_connectionState = 9;
					return;
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			case 20:
			{
				short connectionState = this.m_connectionState;
				if (connectionState == 5 || connectionState == 9 || connectionState == 11)
				{
					if (this.m_connectionState == 5)
					{
						this.Skip13CertificateRequest();
					}
					if (this.m_connectionState != 9)
					{
						this.Skip13ServerCertificate();
					}
					this.Receive13ServerFinished(buf);
					buf.UpdateHash(this.m_handshakeHash);
					this.m_connectionState = 20;
					byte[] serverFinishedTranscriptHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(this.m_handshakeHash);
					this.m_recordStream.SetIgnoreChangeCipherSpec(false);
					if (this.m_certificateRequest != null)
					{
						global::Org.BouncyCastle.Tls.TlsCredentialedSigner clientCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.Establish13ClientCredentials(this.m_authentication, this.m_certificateRequest);
						global::Org.BouncyCastle.Tls.Certificate clientCertificate = null;
						if (clientCredentials != null)
						{
							clientCertificate = clientCredentials.Certificate;
						}
						if (clientCertificate == null)
						{
							clientCertificate = global::Org.BouncyCastle.Tls.Certificate.EmptyChainTls13;
						}
						this.Send13CertificateMessage(clientCertificate);
						this.m_connectionState = 15;
						if (clientCredentials != null)
						{
							global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.TlsUtilities.Generate13CertificateVerify(this.m_tlsClientContext, clientCredentials, this.m_handshakeHash);
							this.Send13CertificateVerifyMessage(certificateVerify);
							this.m_connectionState = 17;
						}
					}
					this.Send13FinishedMessage();
					this.m_connectionState = 18;
					global::Org.BouncyCastle.Tls.TlsUtilities.Establish13PhaseApplication(this.m_tlsClientContext, serverFinishedTranscriptHash, this.m_recordStream);
					this.m_recordStream.EnablePendingCipherWrite();
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

		// Token: 0x0600090D RID: 2317 RVA: 0x00023FF8 File Offset: 0x000221F8
		protected override void HandleHandshakeMessage(short type, global::Org.BouncyCastle.Tls.HandshakeMessageInput buf)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsClientContext.SecurityParameters;
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
					global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
					if (base.IsApplicationDataReady)
					{
						this.RefuseRenegotiation();
						return;
					}
					return;
				case 1:
				case 3:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 21:
				case 24:
					break;
				case 2:
				{
					if (this.m_connectionState != 1)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					global::Org.BouncyCastle.Tls.ServerHello serverHello = this.ReceiveServerHelloMessage(buf);
					if (serverHello.IsHelloRetryRequest())
					{
						this.Process13HelloRetryRequest(serverHello);
						this.m_handshakeHash.NotifyPrfDetermined();
						global::Org.BouncyCastle.Tls.TlsUtilities.AdjustTranscriptForRetry(this.m_handshakeHash);
						buf.UpdateHash(this.m_handshakeHash);
						this.m_connectionState = 2;
						this.Send13ClientHelloRetry();
						this.m_handshakeHash.SealHashAlgorithms();
						this.m_connectionState = 3;
						return;
					}
					this.ProcessServerHello(serverHello);
					this.m_handshakeHash.NotifyPrfDetermined();
					buf.UpdateHash(this.m_handshakeHash);
					this.m_connectionState = 4;
					if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
					{
						this.m_handshakeHash.SealHashAlgorithms();
						this.Process13ServerHelloCoda(serverHello, false);
						return;
					}
					return;
				}
				case 4:
					if (this.m_connectionState != 18)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					if (!this.m_expectSessionTicket)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					securityParameters.m_sessionID = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
					this.InvalidateSession();
					this.m_tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, null);
					this.ReceiveNewSessionTicket(buf);
					this.m_connectionState = 19;
					return;
				case 11:
				{
					short connectionState = this.m_connectionState;
					if (connectionState == 4 || connectionState == 6)
					{
						if (this.m_connectionState != 6)
						{
							this.HandleSupplementalData(null);
						}
						this.m_authentication = global::Org.BouncyCastle.Tls.TlsUtilities.ReceiveServerCertificate(this.m_tlsClientContext, this.m_tlsClient, buf);
						this.m_connectionState = 7;
						return;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				case 12:
				{
					short connectionState = this.m_connectionState;
					if (connectionState == 4 || connectionState - 6 <= 2)
					{
						if (this.m_connectionState == 4)
						{
							this.HandleSupplementalData(null);
						}
						if (this.m_connectionState != 7 && this.m_connectionState != 8)
						{
							this.m_authentication = null;
						}
						this.HandleServerCertificate();
						this.m_keyExchange.ProcessServerKeyExchange(buf);
						global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
						this.m_connectionState = 10;
						return;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				case 13:
				{
					short connectionState = this.m_connectionState;
					if (connectionState - 7 <= 1 || connectionState == 10)
					{
						if (this.m_connectionState != 10)
						{
							this.HandleServerCertificate();
							this.m_keyExchange.SkipServerKeyExchange();
						}
						this.ReceiveCertificateRequest(buf);
						global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerSigAlgs(securityParameters, this.m_certificateRequest);
						global::Org.BouncyCastle.Tls.TlsUtilities.TrackHashAlgorithms(this.m_handshakeHash, securityParameters.ServerSigAlgs);
						this.m_connectionState = 11;
						return;
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				}
				case 14:
					switch (this.m_connectionState)
					{
					case 4:
					case 6:
					case 7:
					case 8:
					case 10:
					case 11:
					{
						if (this.m_connectionState == 4)
						{
							this.HandleSupplementalData(null);
						}
						if (this.m_connectionState == 4 || this.m_connectionState == 6)
						{
							this.m_authentication = null;
						}
						if (this.m_connectionState != 10 && this.m_connectionState != 11)
						{
							this.HandleServerCertificate();
							this.m_keyExchange.SkipServerKeyExchange();
						}
						global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
						this.m_connectionState = 12;
						global::System.Collections.IList clientSupplementalData = this.m_tlsClient.GetClientSupplementalData();
						if (clientSupplementalData != null)
						{
							this.SendSupplementalDataMessage(clientSupplementalData);
							this.m_connectionState = 14;
						}
						global::Org.BouncyCastle.Tls.TlsCredentialedSigner credentialedSigner = null;
						global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner streamSigner = null;
						if (this.m_certificateRequest == null)
						{
							this.m_keyExchange.SkipClientCredentials();
						}
						else
						{
							global::Org.BouncyCastle.Tls.Certificate clientCertificate = null;
							global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientCredentials(this.m_authentication, this.m_certificateRequest);
							if (clientCredentials == null)
							{
								this.m_keyExchange.SkipClientCredentials();
							}
							else
							{
								this.m_keyExchange.ProcessClientCredentials(clientCredentials);
								clientCertificate = clientCredentials.Certificate;
								if (clientCredentials is global::Org.BouncyCastle.Tls.TlsCredentialedSigner)
								{
									credentialedSigner = (global::Org.BouncyCastle.Tls.TlsCredentialedSigner)clientCredentials;
									streamSigner = credentialedSigner.GetStreamSigner();
								}
							}
							this.SendCertificateMessage(clientCertificate, null);
							this.m_connectionState = 15;
						}
						bool forceBuffering = streamSigner != null;
						global::Org.BouncyCastle.Tls.TlsUtilities.SealHandshakeHash(this.m_tlsClientContext, this.m_handshakeHash, forceBuffering);
						this.SendClientKeyExchange();
						this.m_connectionState = 16;
						bool flag = global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(this.m_tlsClientContext);
						if (flag)
						{
							global::Org.BouncyCastle.Tls.TlsProtocol.EstablishMasterSecret(this.m_tlsClientContext, this.m_keyExchange);
						}
						securityParameters.m_sessionHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(this.m_handshakeHash);
						if (!flag)
						{
							global::Org.BouncyCastle.Tls.TlsProtocol.EstablishMasterSecret(this.m_tlsClientContext, this.m_keyExchange);
						}
						this.m_recordStream.SetPendingCipher(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(this.m_tlsClientContext));
						if (credentialedSigner != null)
						{
							global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.TlsUtilities.GenerateCertificateVerifyClient(this.m_tlsClientContext, credentialedSigner, streamSigner, this.m_handshakeHash);
							this.SendCertificateVerifyMessage(certificateVerify);
							this.m_connectionState = 17;
						}
						this.m_handshakeHash = this.m_handshakeHash.StopTracking();
						this.SendChangeCipherSpec();
						this.SendFinishedMessage();
						this.m_connectionState = 18;
						return;
					}
					}
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
				case 20:
				{
					short connectionState = this.m_connectionState;
					if (connectionState - 18 > 1)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					if (this.m_connectionState != 19 && this.m_expectSessionTicket)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					this.ProcessFinishedMessage(buf);
					this.m_connectionState = 20;
					this.CompleteHandshake();
					return;
				}
				case 22:
					if (this.m_connectionState != 7)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					if (securityParameters.StatusRequestVersion < 1)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
					}
					this.m_certificateStatus = global::Org.BouncyCastle.Tls.CertificateStatus.Parse(this.m_tlsClientContext, buf);
					global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
					this.m_connectionState = 8;
					return;
				case 23:
					if (this.m_connectionState == 4)
					{
						this.HandleSupplementalData(global::Org.BouncyCastle.Tls.TlsProtocol.ReadSupplementalDataMessage(buf));
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
			if (type != 20 || this.m_connectionState != 4)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			this.ProcessFinishedMessage(buf);
			buf.UpdateHash(this.m_handshakeHash);
			this.m_connectionState = 20;
			this.SendChangeCipherSpec();
			this.SendFinishedMessage();
			this.m_connectionState = 18;
			this.CompleteHandshake();
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000245FE File Offset: 0x000227FE
		protected virtual void HandleServerCertificate()
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.ProcessServerCertificate(this.m_tlsClientContext, this.m_certificateStatus, this.m_keyExchange, this.m_authentication, this.m_clientExtensions, this.m_serverExtensions);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00024629 File Offset: 0x00022829
		protected virtual void HandleSupplementalData(global::System.Collections.IList serverSupplementalData)
		{
			this.m_tlsClient.ProcessServerSupplementalData(serverSupplementalData);
			this.m_connectionState = 6;
			this.m_keyExchange = global::Org.BouncyCastle.Tls.TlsUtilities.InitKeyExchangeClient(this.m_tlsClientContext, this.m_tlsClient);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00024658 File Offset: 0x00022858
		protected virtual void Process13HelloRetryRequest(global::Org.BouncyCastle.Tls.ServerHello helloRetryRequest)
		{
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_record_version = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
			this.m_recordStream.SetWriteVersion(legacy_record_version);
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsClientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = helloRetryRequest.Version;
			byte[] legacy_session_id_echo = helloRetryRequest.SessionID;
			int cipherSuite = helloRetryRequest.CipherSuite;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.Equals(legacy_version) || !global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.m_clientHello.SessionID, legacy_session_id_echo) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(this.m_clientHello.CipherSuites, cipherSuite))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::System.Collections.IDictionary extensions = helloRetryRequest.Extensions;
			if (extensions == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckExtensionData13(extensions, 6, 47);
			foreach (object obj in extensions.Keys)
			{
				int extType = (int)obj;
				if (44 != extType && global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_clientExtensions, extType) == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(110);
				}
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion server_version = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
			if (server_version == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(109);
			}
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(server_version) || !global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(this.m_tlsClientContext.ClientSupportedVersions, server_version) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, server_version))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			if (this.m_clientBinders != null && !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.m_clientBinders.m_pskKeyExchangeModes, 1))
			{
				this.m_clientBinders = null;
				this.m_tlsClient.NotifySelectedPsk(null);
			}
			int selected_group = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetKeyShareHelloRetryRequest(extensions);
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidKeyShareSelection(server_version, securityParameters.ClientSupportedGroups, this.m_clientAgreements, selected_group))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			byte[] cookie = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetCookieExtension(extensions);
			securityParameters.m_negotiatedVersion = server_version;
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersionTlsClient(this.m_tlsClientContext, this.m_tlsClient);
			this.m_resumedSession = false;
			securityParameters.m_sessionID = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			this.m_tlsClient.NotifySessionID(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			this.m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
			this.m_clientAgreements = null;
			this.m_retryCookie = cookie;
			this.m_retryGroup = selected_group;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00024870 File Offset: 0x00022A70
		protected virtual void Process13ServerHello(global::Org.BouncyCastle.Tls.ServerHello serverHello, bool afterHelloRetryRequest)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsClientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = serverHello.Version;
			byte[] legacy_session_id_echo = serverHello.SessionID;
			int cipherSuite = serverHello.CipherSuite;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.Equals(legacy_version) || !global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.m_clientHello.SessionID, legacy_session_id_echo))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::System.Collections.IDictionary extensions = serverHello.Extensions;
			if (extensions == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckExtensionData13(extensions, 2, 47);
			if (afterHelloRetryRequest)
			{
				global::Org.BouncyCastle.Tls.ProtocolVersion server_version = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
				if (server_version == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(109);
				}
				if (!securityParameters.NegotiatedVersion.Equals(server_version) || securityParameters.CipherSuite != cipherSuite)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
			}
			else
			{
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(this.m_clientHello.CipherSuites, cipherSuite) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				this.m_resumedSession = false;
				securityParameters.m_sessionID = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
				this.m_tlsClient.NotifySessionID(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes);
				global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
				this.m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
			}
			this.m_clientHello = null;
			securityParameters.m_serverRandom = serverHello.Random;
			securityParameters.m_secureRenegotiation = false;
			securityParameters.m_extendedMasterSecret = true;
			securityParameters.m_statusRequestVersion = (this.m_clientExtensions.Contains(5) ? 1 : 0);
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret pskEarlySecret = null;
			int selected_identity = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetPreSharedKeyServerHello(extensions);
			global::Org.BouncyCastle.Tls.TlsPsk selectedPsk = null;
			if (selected_identity >= 0)
			{
				if (this.m_clientBinders == null || selected_identity >= this.m_clientBinders.m_psks.Length)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				selectedPsk = this.m_clientBinders.m_psks[selected_identity];
				if (selectedPsk.PrfAlgorithm != securityParameters.PrfAlgorithm)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				pskEarlySecret = this.m_clientBinders.m_earlySecrets[selected_identity];
				this.m_selectedPsk13 = true;
			}
			this.m_tlsClient.NotifySelectedPsk(selectedPsk);
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret sharedSecret = null;
			global::Org.BouncyCastle.Tls.KeyShareEntry keyShareEntry = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetKeyShareServerHello(extensions);
			if (keyShareEntry == null)
			{
				if (afterHelloRetryRequest || pskEarlySecret == null || !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.m_clientBinders.m_pskKeyExchangeModes, 0))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
			}
			else
			{
				if (pskEarlySecret != null && !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.m_clientBinders.m_pskKeyExchangeModes, 1))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				global::Org.BouncyCastle.Tls.Crypto.TlsAgreement agreement = (global::Org.BouncyCastle.Tls.Crypto.TlsAgreement)this.m_clientAgreements[keyShareEntry.NamedGroup];
				if (agreement == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				agreement.ReceivePeerValue(keyShareEntry.KeyExchange);
				sharedSecret = agreement.CalculateSecret();
			}
			this.m_clientAgreements = null;
			this.m_clientBinders = null;
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13PhaseSecrets(this.m_tlsClientContext, pskEarlySecret, sharedSecret);
			this.InvalidateSession();
			this.m_tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, null);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00024B00 File Offset: 0x00022D00
		protected virtual void Process13ServerHelloCoda(global::Org.BouncyCastle.Tls.ServerHello serverHello, bool afterHelloRetryRequest)
		{
			byte[] serverHelloTranscriptHash = global::Org.BouncyCastle.Tls.TlsUtilities.GetCurrentPrfHash(this.m_handshakeHash);
			global::Org.BouncyCastle.Tls.TlsUtilities.Establish13PhaseHandshake(this.m_tlsClientContext, serverHelloTranscriptHash, this.m_recordStream);
			if (!afterHelloRetryRequest)
			{
				this.m_recordStream.SetIgnoreChangeCipherSpec(true);
				this.SendChangeCipherSpecMessage();
			}
			this.m_recordStream.EnablePendingCipherWrite();
			this.m_recordStream.EnablePendingCipherRead(false);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00024B58 File Offset: 0x00022D58
		protected virtual void ProcessServerHello(global::Org.BouncyCastle.Tls.ServerHello serverHello)
		{
			global::System.Collections.IDictionary serverHelloExtensions = serverHello.Extensions;
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = serverHello.Version;
			global::Org.BouncyCastle.Tls.ProtocolVersion supported_version = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(serverHelloExtensions);
			global::Org.BouncyCastle.Tls.ProtocolVersion server_version;
			if (supported_version == null)
			{
				server_version = legacy_version;
			}
			else
			{
				if (!global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.Equals(legacy_version) || !global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(supported_version))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				server_version = supported_version;
			}
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsClientContext.SecurityParameters;
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(this.m_tlsClientContext.ClientSupportedVersions, server_version))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(70);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_record_version = server_version.IsLaterVersionOf(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12) ? global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12 : server_version;
			this.m_recordStream.SetWriteVersion(legacy_record_version);
			securityParameters.m_negotiatedVersion = server_version;
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedVersionTlsClient(this.m_tlsClientContext, this.m_tlsClient);
			if (global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(server_version))
			{
				this.Process13ServerHello(serverHello, false);
				return;
			}
			int[] cipherSuites = this.m_clientHello.CipherSuites;
			this.m_clientHello = null;
			this.m_retryCookie = null;
			this.m_retryGroup = -1;
			securityParameters.m_serverRandom = serverHello.Random;
			if (!this.m_tlsClientContext.ClientVersion.Equals(server_version))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.CheckDowngradeMarker(server_version, securityParameters.ServerRandom);
			}
			byte[] selectedSessionID = serverHello.SessionID;
			securityParameters.m_sessionID = selectedSessionID;
			this.m_tlsClient.NotifySessionID(selectedSessionID);
			this.m_resumedSession = (selectedSessionID.Length != 0 && this.m_tlsSession != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(selectedSessionID, this.m_tlsSession.SessionID));
			int cipherSuite = serverHello.CipherSuite;
			if (!global::Org.BouncyCastle.Tls.TlsUtilities.IsValidCipherSuiteSelection(cipherSuites, cipherSuite) || !global::Org.BouncyCastle.Tls.TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			this.m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
			this.m_serverExtensions = serverHelloExtensions;
			if (this.m_serverExtensions != null)
			{
				foreach (object obj in this.m_serverExtensions.Keys)
				{
					int extType = (int)obj;
					if (65281 != extType)
					{
						if (global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_clientExtensions, extType) == null)
						{
							throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(110);
						}
						bool resumedSession = this.m_resumedSession;
					}
				}
			}
			byte[] renegExtData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_serverExtensions, 65281);
			if (renegExtData == null)
			{
				securityParameters.m_secureRenegotiation = false;
			}
			else
			{
				securityParameters.m_secureRenegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
			}
			this.m_tlsClient.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
			bool acceptedExtendedMasterSecret = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(this.m_serverExtensions);
			if (acceptedExtendedMasterSecret)
			{
				if (server_version.IsSsl || (!this.m_resumedSession && !this.m_tlsClient.ShouldUseExtendedMasterSecret()))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
				}
			}
			else if (this.m_tlsClient.RequiresExtendedMasterSecret() || (this.m_resumedSession && !this.m_tlsClient.AllowLegacyResumption()))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			securityParameters.m_extendedMasterSecret = acceptedExtendedMasterSecret;
			securityParameters.m_applicationProtocol = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionServer(this.m_serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			global::System.Collections.IDictionary sessionClientExtensions = this.m_clientExtensions;
			global::System.Collections.IDictionary sessionServerExtensions = this.m_serverExtensions;
			if (this.m_resumedSession)
			{
				if (securityParameters.CipherSuite != this.m_sessionParameters.CipherSuite || !server_version.Equals(this.m_sessionParameters.NegotiatedVersion))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				sessionClientExtensions = null;
				sessionServerExtensions = this.m_sessionParameters.ReadServerExtensions();
			}
			if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
			{
				bool serverSentEncryptThenMAC = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
				if (serverSentEncryptThenMAC && !global::Org.BouncyCastle.Tls.TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				securityParameters.m_encryptThenMac = serverSentEncryptThenMAC;
				securityParameters.m_maxFragmentLength = this.ProcessMaxFragmentLengthExtension(sessionClientExtensions, sessionServerExtensions, 47);
				securityParameters.m_truncatedHmac = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.HasTruncatedHmacExtension(sessionServerExtensions);
				if (!this.m_resumedSession)
				{
					if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 17, 47))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
					this.m_expectSessionTicket = global::Org.BouncyCastle.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47);
				}
			}
			if (sessionClientExtensions != null)
			{
				this.m_tlsClient.ProcessServerExtensions(sessionServerExtensions);
			}
			this.ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
			if (this.m_resumedSession)
			{
				securityParameters.m_masterSecret = this.m_sessionMasterSecret;
				this.m_recordStream.SetPendingCipher(global::Org.BouncyCastle.Tls.TlsUtilities.InitCipher(this.m_tlsClientContext));
				return;
			}
			this.InvalidateSession();
			this.m_tlsSession = global::Org.BouncyCastle.Tls.TlsUtilities.ImportSession(securityParameters.SessionID, null);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00024FB4 File Offset: 0x000231B4
		protected virtual void Receive13CertificateRequest(global::System.IO.MemoryStream buf, bool postHandshakeAuth)
		{
			if (postHandshakeAuth)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (this.m_selectedPsk13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest = global::Org.BouncyCastle.Tls.CertificateRequest.Parse(this.m_tlsClientContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			if (!certificateRequest.HasCertificateRequestContext(global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			this.m_certificateRequest = certificateRequest;
			global::Org.BouncyCastle.Tls.TlsUtilities.EstablishServerSigAlgs(this.m_tlsClientContext.SecurityParameters, certificateRequest);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0002501C File Offset: 0x0002321C
		protected virtual void Receive13EncryptedExtensions(global::System.IO.MemoryStream buf)
		{
			byte[] extBytes = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			this.m_serverExtensions = global::Org.BouncyCastle.Tls.TlsProtocol.ReadExtensionsData13(8, extBytes);
			foreach (object obj in this.m_serverExtensions.Keys)
			{
				int extType = (int)obj;
				if (global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_clientExtensions, extType) == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(110);
				}
			}
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsClientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			securityParameters.m_applicationProtocol = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetAlpnExtensionServer(this.m_serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			global::System.Collections.IDictionary sessionClientExtensions = this.m_clientExtensions;
			global::System.Collections.IDictionary sessionServerExtensions = this.m_serverExtensions;
			if (this.m_resumedSession)
			{
				if (securityParameters.CipherSuite != this.m_sessionParameters.CipherSuite || !negotiatedVersion.Equals(this.m_sessionParameters.NegotiatedVersion))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				sessionClientExtensions = null;
				sessionServerExtensions = this.m_sessionParameters.ReadServerExtensions();
			}
			securityParameters.m_maxFragmentLength = this.ProcessMaxFragmentLengthExtension(sessionClientExtensions, sessionServerExtensions, 47);
			securityParameters.m_encryptThenMac = false;
			securityParameters.m_truncatedHmac = false;
			securityParameters.m_statusRequestVersion = (this.m_clientExtensions.Contains(5) ? 1 : 0);
			this.m_expectSessionTicket = false;
			if (sessionClientExtensions != null)
			{
				this.m_tlsClient.ProcessServerExtensions(this.m_serverExtensions);
			}
			this.ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00025190 File Offset: 0x00023390
		protected virtual void Receive13NewSessionTicket(global::System.IO.MemoryStream buf)
		{
			if (!base.IsApplicationDataReady)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint32(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint32(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000251CB File Offset: 0x000233CB
		protected virtual void Receive13ServerCertificate(global::System.IO.MemoryStream buf)
		{
			if (this.m_selectedPsk13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			this.m_authentication = global::Org.BouncyCastle.Tls.TlsUtilities.Receive13ServerCertificate(this.m_tlsClientContext, this.m_tlsClient, buf);
			this.HandleServerCertificate();
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000251FC File Offset: 0x000233FC
		protected virtual void Receive13ServerCertificateVerify(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.Certificate serverCertificate = this.m_tlsClientContext.SecurityParameters.PeerCertificate;
			if (serverCertificate == null || serverCertificate.IsEmpty)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify = global::Org.BouncyCastle.Tls.DigitallySigned.Parse(this.m_tlsClientContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.Verify13CertificateVerifyServer(this.m_tlsClientContext, certificateVerify, this.m_handshakeHash);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00025252 File Offset: 0x00023452
		protected virtual void Receive13ServerFinished(global::System.IO.MemoryStream buf)
		{
			this.Process13FinishedMessage(buf);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0002525C File Offset: 0x0002345C
		protected virtual void ReceiveCertificateRequest(global::System.IO.MemoryStream buf)
		{
			if (this.m_authentication == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest = global::Org.BouncyCastle.Tls.CertificateRequest.Parse(this.m_tlsClientContext, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			this.m_certificateRequest = global::Org.BouncyCastle.Tls.TlsUtilities.ValidateCertificateRequest(certificateRequest, this.m_keyExchange);
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000252A0 File Offset: 0x000234A0
		protected virtual void ReceiveNewSessionTicket(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket = global::Org.BouncyCastle.Tls.NewSessionTicket.Parse(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			this.m_tlsClient.NotifyNewSessionTicket(newSessionTicket);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000252C6 File Offset: 0x000234C6
		protected virtual global::Org.BouncyCastle.Tls.ServerHello ReceiveServerHelloMessage(global::System.IO.MemoryStream buf)
		{
			return global::Org.BouncyCastle.Tls.ServerHello.Parse(buf);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x000252D0 File Offset: 0x000234D0
		protected virtual void Send13ClientHelloRetry()
		{
			global::System.Collections.IDictionary clientHelloExtensions = this.m_clientHello.Extensions;
			clientHelloExtensions.Remove(44);
			clientHelloExtensions.Remove(42);
			clientHelloExtensions.Remove(51);
			clientHelloExtensions.Remove(41);
			if (this.m_retryCookie != null)
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddCookieExtension(clientHelloExtensions, this.m_retryCookie);
				this.m_retryCookie = null;
			}
			if (this.m_clientBinders != null)
			{
				this.m_clientBinders = global::Org.BouncyCastle.Tls.TlsUtilities.AddPreSharedKeyToClientHelloRetry(this.m_tlsClientContext, this.m_clientBinders, clientHelloExtensions);
				if (this.m_clientBinders == null)
				{
					this.m_tlsClient.NotifySelectedPsk(null);
				}
			}
			if (this.m_retryGroup < 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_clientAgreements = global::Org.BouncyCastle.Tls.TlsUtilities.AddKeyShareToClientHelloRetry(this.m_tlsClientContext, clientHelloExtensions, this.m_retryGroup);
			this.m_recordStream.SetIgnoreChangeCipherSpec(true);
			this.SendChangeCipherSpecMessage();
			this.SendClientHelloMessage();
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x000253B0 File Offset: 0x000235B0
		protected virtual void SendCertificateVerifyMessage(global::Org.BouncyCastle.Tls.DigitallySigned certificateVerify)
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(15);
			certificateVerify.Encode(message);
			message.Send(this);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x000253D4 File Offset: 0x000235D4
		protected virtual void SendClientHello()
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = this.m_tlsClientContext.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion[] supportedVersions = this.m_tlsClient.GetProtocolVersions();
			if (global::Org.BouncyCastle.Tls.ProtocolVersion.Contains(supportedVersions, global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3))
			{
				this.m_recordStream.SetWriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion.SSLv3);
			}
			else
			{
				this.m_recordStream.SetWriteVersion(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
			}
			global::Org.BouncyCastle.Tls.ProtocolVersion earliestVersion = global::Org.BouncyCastle.Tls.ProtocolVersion.GetEarliestTls(supportedVersions);
			global::Org.BouncyCastle.Tls.ProtocolVersion latestVersion = global::Org.BouncyCastle.Tls.ProtocolVersion.GetLatestTls(supportedVersions);
			if (!global::Org.BouncyCastle.Tls.ProtocolVersion.IsSupportedTlsVersionClient(latestVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_tlsClientContext.SetClientVersion(latestVersion);
			this.m_tlsClientContext.SetClientSupportedVersions(supportedVersions);
			bool offeringTlsV12Minus = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.IsEqualOrLaterVersionOf(earliestVersion);
			bool offeringTlsV13Plus = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(latestVersion);
			this.EstablishSession(offeringTlsV12Minus ? this.m_tlsClient.GetSessionToResume() : null);
			this.m_tlsClient.NotifySessionToResume(this.m_tlsSession);
			byte[] legacy_session_id = global::Org.BouncyCastle.Tls.TlsUtilities.GetSessionID(this.m_tlsSession);
			bool flag = this.m_tlsClient.IsFallback();
			int[] offeredCipherSuites = this.m_tlsClient.GetCipherSuites();
			if (legacy_session_id.Length != 0 && this.m_sessionParameters != null && !global::Org.BouncyCastle.Utilities.Arrays.Contains(offeredCipherSuites, this.m_sessionParameters.CipherSuite))
			{
				legacy_session_id = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
			}
			this.m_clientExtensions = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(this.m_tlsClient.GetClientExtensions());
			global::Org.BouncyCastle.Tls.ProtocolVersion legacy_version = latestVersion;
			if (offeringTlsV13Plus)
			{
				legacy_version = global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12;
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddSupportedVersionsExtensionClient(this.m_clientExtensions, supportedVersions);
				if (legacy_session_id.Length < 1)
				{
					legacy_session_id = this.m_tlsClientContext.NonceGenerator.GenerateNonce(32);
				}
			}
			this.m_tlsClientContext.SetRsaPreMasterSecretVersion(legacy_version);
			securityParameters.m_clientServerNames = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetServerNameExtensionClient(this.m_clientExtensions);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(latestVersion))
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.EstablishClientSigAlgs(securityParameters, this.m_clientExtensions);
			}
			securityParameters.m_clientSupportedGroups = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.GetSupportedGroupsExtension(this.m_clientExtensions);
			this.m_clientBinders = global::Org.BouncyCastle.Tls.TlsUtilities.AddPreSharedKeyToClientHello(this.m_tlsClientContext, this.m_tlsClient, this.m_clientExtensions, offeredCipherSuites);
			this.m_clientAgreements = global::Org.BouncyCastle.Tls.TlsUtilities.AddKeyShareToClientHello(this.m_tlsClientContext, this.m_tlsClient, this.m_clientExtensions);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsExtendedMasterSecretOptionalTls(supportedVersions) && (this.m_tlsClient.ShouldUseExtendedMasterSecret() || (this.m_sessionParameters != null && this.m_sessionParameters.IsExtendedMasterSecret)))
			{
				global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(this.m_clientExtensions);
			}
			else if (!offeringTlsV13Plus && this.m_tlsClient.RequiresExtendedMasterSecret())
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			bool useGmtUnixTime = !offeringTlsV13Plus && this.m_tlsClient.ShouldUseGmtUnixTime();
			securityParameters.m_clientRandom = global::Org.BouncyCastle.Tls.TlsProtocol.CreateRandomBlock(useGmtUnixTime, this.m_tlsClientContext);
			bool flag2 = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(this.m_clientExtensions, 65281) == null;
			bool noRenegScsv = !global::Org.BouncyCastle.Utilities.Arrays.Contains(offeredCipherSuites, 255);
			if (flag2 && noRenegScsv)
			{
				offeredCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(offeredCipherSuites, 255);
			}
			if (flag && !global::Org.BouncyCastle.Utilities.Arrays.Contains(offeredCipherSuites, 22016))
			{
				offeredCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(offeredCipherSuites, 22016);
			}
			int bindersSize = (this.m_clientBinders == null) ? 0 : this.m_clientBinders.m_bindersSize;
			this.m_clientHello = new global::Org.BouncyCastle.Tls.ClientHello(legacy_version, securityParameters.ClientRandom, legacy_session_id, null, offeredCipherSuites, this.m_clientExtensions, bindersSize);
			this.SendClientHelloMessage();
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000256C4 File Offset: 0x000238C4
		protected virtual void SendClientHelloMessage()
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(1);
			this.m_clientHello.Encode(this.m_tlsClientContext, message);
			message.PrepareClientHello(this.m_handshakeHash, this.m_clientHello.BindersSize);
			if (this.m_clientBinders != null)
			{
				global::Org.BouncyCastle.Tls.OfferedPsks.EncodeBinders(message, this.m_tlsClientContext.Crypto, this.m_handshakeHash, this.m_clientBinders);
			}
			message.SendClientHello(this, this.m_handshakeHash, this.m_clientHello.BindersSize);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00025740 File Offset: 0x00023940
		protected virtual void SendClientKeyExchange()
		{
			global::Org.BouncyCastle.Tls.HandshakeMessageOutput message = new global::Org.BouncyCastle.Tls.HandshakeMessageOutput(16);
			this.m_keyExchange.GenerateClientKeyExchange(message);
			message.Send(this);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00025768 File Offset: 0x00023968
		protected virtual void Skip13CertificateRequest()
		{
			this.m_certificateRequest = null;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00025771 File Offset: 0x00023971
		protected virtual void Skip13ServerCertificate()
		{
			if (!this.m_selectedPsk13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			this.m_authentication = global::Org.BouncyCastle.Tls.TlsUtilities.Skip13ServerCertificate(this.m_tlsClientContext);
		}

		// Token: 0x040006D8 RID: 1752
		protected global::Org.BouncyCastle.Tls.TlsClient m_tlsClient;

		// Token: 0x040006D9 RID: 1753
		internal global::Org.BouncyCastle.Tls.TlsClientContextImpl m_tlsClientContext;

		// Token: 0x040006DA RID: 1754
		protected global::System.Collections.IDictionary m_clientAgreements;

		// Token: 0x040006DB RID: 1755
		internal global::Org.BouncyCastle.Tls.OfferedPsks.BindersConfig m_clientBinders;

		// Token: 0x040006DC RID: 1756
		protected global::Org.BouncyCastle.Tls.ClientHello m_clientHello;

		// Token: 0x040006DD RID: 1757
		protected global::Org.BouncyCastle.Tls.TlsKeyExchange m_keyExchange;

		// Token: 0x040006DE RID: 1758
		protected global::Org.BouncyCastle.Tls.TlsAuthentication m_authentication;

		// Token: 0x040006DF RID: 1759
		protected global::Org.BouncyCastle.Tls.CertificateStatus m_certificateStatus;

		// Token: 0x040006E0 RID: 1760
		protected global::Org.BouncyCastle.Tls.CertificateRequest m_certificateRequest;
	}
}
