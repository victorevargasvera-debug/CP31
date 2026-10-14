using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200035E RID: 862
	public class TlsClientProtocol : global::Org.BouncyCastle.Crypto.Tls.TlsProtocol
	{
		// Token: 0x06002314 RID: 8980 RVA: 0x00099BF0 File Offset: 0x00097DF0
		public TlsClientProtocol(global::System.IO.Stream stream, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(stream, secureRandom)
		{
		}

		// Token: 0x06002315 RID: 8981 RVA: 0x00099BFA File Offset: 0x00097DFA
		public TlsClientProtocol(global::System.IO.Stream input, global::System.IO.Stream output, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(input, output, secureRandom)
		{
		}

		// Token: 0x06002316 RID: 8982 RVA: 0x00099C05 File Offset: 0x00097E05
		public TlsClientProtocol(global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(secureRandom)
		{
		}

		// Token: 0x06002317 RID: 8983 RVA: 0x00099C10 File Offset: 0x00097E10
		public virtual void Connect(global::Org.BouncyCastle.Crypto.Tls.TlsClient tlsClient)
		{
			if (tlsClient == null)
			{
				throw new global::System.ArgumentNullException("tlsClient");
			}
			if (this.mTlsClient != null)
			{
				throw new global::System.InvalidOperationException("'Connect' can only be called once");
			}
			this.mTlsClient = tlsClient;
			this.mSecurityParameters = new global::Org.BouncyCastle.Crypto.Tls.SecurityParameters();
			this.mSecurityParameters.entity = 1;
			this.mTlsClientContext = new global::Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl(this.mSecureRandom, this.mSecurityParameters);
			this.mSecurityParameters.clientRandom = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRandomBlock(tlsClient.ShouldUseGmtUnixTime(), this.mTlsClientContext.NonceRandomGenerator);
			this.mTlsClient.Init(this.mTlsClientContext);
			this.mRecordStream.Init(this.mTlsClientContext);
			tlsClient.NotifyCloseHandle(this);
			global::Org.BouncyCastle.Crypto.Tls.TlsSession sessionToResume = tlsClient.GetSessionToResume();
			if (sessionToResume != null && sessionToResume.IsResumable)
			{
				global::Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
				if (sessionParameters != null && sessionParameters.IsExtendedMasterSecret)
				{
					this.mTlsSession = sessionToResume;
					this.mSessionParameters = sessionParameters;
				}
			}
			this.SendClientHelloMessage();
			this.mConnectionState = 1;
			this.BlockForHandshake();
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00099D02 File Offset: 0x00097F02
		protected override void CleanupHandshake()
		{
			base.CleanupHandshake();
			this.mSelectedSessionID = null;
			this.mKeyExchange = null;
			this.mAuthentication = null;
			this.mCertificateStatus = null;
			this.mCertificateRequest = null;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x00099D2D File Offset: 0x00097F2D
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsContext Context
		{
			get
			{
				return this.mTlsClientContext;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x00099D35 File Offset: 0x00097F35
		internal override global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext ContextAdmin
		{
			get
			{
				return this.mTlsClientContext;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x00099D3D File Offset: 0x00097F3D
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsPeer Peer
		{
			get
			{
				return this.mTlsClient;
			}
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00099D48 File Offset: 0x00097F48
		protected override void HandleHandshakeMessage(byte type, global::System.IO.MemoryStream buf)
		{
			if (!this.mResumedSession)
			{
				switch (type)
				{
				case 0:
					global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
					if (this.mConnectionState == 16)
					{
						this.RefuseRenegotiation();
						return;
					}
					return;
				case 2:
					if (this.mConnectionState != 1)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					this.ReceiveServerHelloMessage(buf);
					this.mConnectionState = 2;
					this.mRecordStream.NotifyHelloComplete();
					this.ApplyMaxFragmentLengthExtension();
					if (this.mResumedSession)
					{
						this.mSecurityParameters.masterSecret = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mSessionParameters.MasterSecret);
						this.mRecordStream.SetPendingConnectionState(this.Peer.GetCompression(), this.Peer.GetCipher());
						return;
					}
					this.InvalidateSession();
					if (this.mSelectedSessionID.Length != 0)
					{
						this.mTlsSession = new global::Org.BouncyCastle.Crypto.Tls.TlsSessionImpl(this.mSelectedSessionID, null);
						return;
					}
					return;
				case 4:
					if (this.mConnectionState != 13)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					if (!this.mExpectSessionTicket)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					this.InvalidateSession();
					this.ReceiveNewSessionTicketMessage(buf);
					this.mConnectionState = 14;
					return;
				case 11:
				{
					short mConnectionState = this.mConnectionState;
					if (mConnectionState - 2 <= 1)
					{
						if (this.mConnectionState == 2)
						{
							this.HandleSupplementalData(null);
						}
						this.mPeerCertificate = global::Org.BouncyCastle.Crypto.Tls.Certificate.Parse(buf);
						global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
						if (this.mPeerCertificate == null || this.mPeerCertificate.IsEmpty)
						{
							this.mAllowCertificateStatus = false;
						}
						this.mKeyExchange.ProcessServerCertificate(this.mPeerCertificate);
						this.mAuthentication = this.mTlsClient.GetAuthentication();
						this.mAuthentication.NotifyServerCertificate(this.mPeerCertificate);
						this.mConnectionState = 4;
						return;
					}
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				case 12:
				{
					short mConnectionState = this.mConnectionState;
					if (mConnectionState - 2 <= 3)
					{
						if (this.mConnectionState < 3)
						{
							this.HandleSupplementalData(null);
						}
						if (this.mConnectionState < 4)
						{
							this.mKeyExchange.SkipServerCredentials();
							this.mAuthentication = null;
						}
						this.mKeyExchange.ProcessServerKeyExchange(buf);
						global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
						this.mConnectionState = 6;
						return;
					}
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				case 13:
				{
					short mConnectionState = this.mConnectionState;
					if (mConnectionState - 4 > 2)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					if (this.mConnectionState != 6)
					{
						this.mKeyExchange.SkipServerKeyExchange();
					}
					if (this.mAuthentication == null)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
					}
					this.mCertificateRequest = global::Org.BouncyCastle.Crypto.Tls.CertificateRequest.Parse(this.Context, buf);
					global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
					this.mKeyExchange.ValidateCertificateRequest(this.mCertificateRequest);
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.TrackHashAlgorithms(this.mRecordStream.HandshakeHash, this.mCertificateRequest.SupportedSignatureAlgorithms);
					this.mConnectionState = 7;
					return;
				}
				case 14:
				{
					short mConnectionState = this.mConnectionState;
					if (mConnectionState - 2 <= 5)
					{
						if (this.mConnectionState < 3)
						{
							this.HandleSupplementalData(null);
						}
						if (this.mConnectionState < 4)
						{
							this.mKeyExchange.SkipServerCredentials();
							this.mAuthentication = null;
						}
						if (this.mConnectionState < 6)
						{
							this.mKeyExchange.SkipServerKeyExchange();
						}
						global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
						this.mConnectionState = 8;
						this.mRecordStream.HandshakeHash.SealHashAlgorithms();
						global::System.Collections.IList clientSupplementalData = this.mTlsClient.GetClientSupplementalData();
						if (clientSupplementalData != null)
						{
							this.SendSupplementalDataMessage(clientSupplementalData);
						}
						this.mConnectionState = 9;
						global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCreds = null;
						if (this.mCertificateRequest == null)
						{
							this.mKeyExchange.SkipClientCredentials();
						}
						else
						{
							clientCreds = this.mAuthentication.GetClientCredentials(this.mCertificateRequest);
							if (clientCreds == null)
							{
								this.mKeyExchange.SkipClientCredentials();
								this.SendCertificateMessage(global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain);
							}
							else
							{
								this.mKeyExchange.ProcessClientCredentials(clientCreds);
								this.SendCertificateMessage(clientCreds.Certificate);
							}
						}
						this.mConnectionState = 10;
						this.SendClientKeyExchangeMessage();
						this.mConnectionState = 11;
						if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.Context))
						{
							global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(this.Context, this.mKeyExchange);
						}
						global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash prepareFinishHash = this.mRecordStream.PrepareToFinish();
						this.mSecurityParameters.sessionHash = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(this.Context, prepareFinishHash, null);
						if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.Context))
						{
							global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(this.Context, this.mKeyExchange);
						}
						this.mRecordStream.SetPendingConnectionState(this.Peer.GetCompression(), this.Peer.GetCipher());
						if (clientCreds != null && clientCreds is global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)
						{
							global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials signerCredentials = (global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials)clientCreds;
							global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(this.Context, signerCredentials);
							byte[] hash;
							if (signatureAndHashAlgorithm == null)
							{
								hash = this.mSecurityParameters.SessionHash;
							}
							else
							{
								hash = prepareFinishHash.GetFinalHash(signatureAndHashAlgorithm.Hash);
							}
							byte[] signature = signerCredentials.GenerateCertificateSignature(hash);
							global::Org.BouncyCastle.Crypto.Tls.DigitallySigned certificateVerify = new global::Org.BouncyCastle.Crypto.Tls.DigitallySigned(signatureAndHashAlgorithm, signature);
							this.SendCertificateVerifyMessage(certificateVerify);
							this.mConnectionState = 12;
						}
						this.SendChangeCipherSpecMessage();
						this.SendFinishedMessage();
						this.mConnectionState = 13;
						return;
					}
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				case 20:
				{
					short mConnectionState = this.mConnectionState;
					if (mConnectionState - 13 > 1)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					if (this.mConnectionState == 13 && this.mExpectSessionTicket)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					this.ProcessFinishedMessage(buf);
					this.mConnectionState = 15;
					this.CompleteHandshake();
					return;
				}
				case 22:
					if (this.mConnectionState != 4)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					if (!this.mAllowCertificateStatus)
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
					}
					this.mCertificateStatus = global::Org.BouncyCastle.Crypto.Tls.CertificateStatus.Parse(buf);
					global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
					this.mConnectionState = 5;
					return;
				case 23:
					if (this.mConnectionState == 2)
					{
						this.HandleSupplementalData(global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadSupplementalDataMessage(buf));
						return;
					}
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			if (type != 20 || this.mConnectionState != 2)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			this.ProcessFinishedMessage(buf);
			this.mConnectionState = 15;
			this.SendChangeCipherSpecMessage();
			this.SendFinishedMessage();
			this.mConnectionState = 13;
			this.CompleteHandshake();
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0009A316 File Offset: 0x00098516
		protected virtual void HandleSupplementalData(global::System.Collections.IList serverSupplementalData)
		{
			this.mTlsClient.ProcessServerSupplementalData(serverSupplementalData);
			this.mConnectionState = 3;
			this.mKeyExchange = this.mTlsClient.GetKeyExchange();
			this.mKeyExchange.Init(this.Context);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x0009A350 File Offset: 0x00098550
		protected virtual void ReceiveNewSessionTicketMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket = global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket.Parse(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			this.mTlsClient.NotifyNewSessionTicket(newSessionTicket);
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x0009A378 File Offset: 0x00098578
		protected virtual void ReceiveServerHelloMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion server_version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(buf);
			if (server_version.IsDtls)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			if (!server_version.Equals(this.mRecordStream.ReadVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion client_version = this.Context.ClientVersion;
			if (!server_version.IsEqualOrEarlierVersionOf(client_version))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			this.mRecordStream.SetWriteVersion(server_version);
			this.ContextAdmin.SetServerVersion(server_version);
			this.mTlsClient.NotifyServerVersion(server_version);
			this.mSecurityParameters.serverRandom = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(32, buf);
			this.mSelectedSessionID = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(buf);
			if (this.mSelectedSessionID.Length > 32)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			this.mTlsClient.NotifySessionID(this.mSelectedSessionID);
			this.mResumedSession = (this.mSelectedSessionID.Length != 0 && this.mTlsSession != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.mSelectedSessionID, this.mTlsSession.SessionID));
			int selectedCipherSuite = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || global::Org.BouncyCastle.Crypto.Tls.CipherSuite.IsScsv(selectedCipherSuite) || !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, this.Context.ServerVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			this.mTlsClient.NotifySelectedCipherSuite(selectedCipherSuite);
			byte selectedCompressionMethod = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf);
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCompressionMethods, selectedCompressionMethod))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			this.mTlsClient.NotifySelectedCompressionMethod(selectedCompressionMethod);
			this.mServerExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(buf);
			this.mSecurityParameters.extendedMasterSecret = (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.mTlsClientContext) && global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(this.mServerExtensions));
			if (!this.mSecurityParameters.IsExtendedMasterSecret && (this.mResumedSession || this.mTlsClient.RequiresExtendedMasterSecret()))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			if (this.mServerExtensions != null)
			{
				foreach (object obj in this.mServerExtensions.Keys)
				{
					int extType = (int)obj;
					if (extType != 65281)
					{
						if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(this.mClientExtensions, extType) == null)
						{
							throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(110);
						}
						bool mResumedSession = this.mResumedSession;
					}
				}
			}
			byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(this.mServerExtensions, 65281);
			if (renegExtData != null)
			{
				this.mSecureRenegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
			}
			this.mTlsClient.NotifySecureRenegotiation(this.mSecureRenegotiation);
			global::System.Collections.IDictionary sessionClientExtensions = this.mClientExtensions;
			global::System.Collections.IDictionary sessionServerExtensions = this.mServerExtensions;
			if (this.mResumedSession)
			{
				if (selectedCipherSuite != this.mSessionParameters.CipherSuite || selectedCompressionMethod != this.mSessionParameters.CompressionAlgorithm)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				sessionClientExtensions = null;
				sessionServerExtensions = this.mSessionParameters.ReadServerExtensions();
			}
			this.mSecurityParameters.cipherSuite = selectedCipherSuite;
			this.mSecurityParameters.compressionAlgorithm = selectedCompressionMethod;
			if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
			{
				bool serverSentEncryptThenMAC = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
				if (serverSentEncryptThenMAC && !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsBlockCipherSuite(selectedCipherSuite))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				this.mSecurityParameters.encryptThenMac = serverSentEncryptThenMAC;
				this.mSecurityParameters.maxFragmentLength = this.ProcessMaxFragmentLengthExtension(sessionClientExtensions, sessionServerExtensions, 47);
				this.mSecurityParameters.truncatedHMac = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasTruncatedHMacExtension(sessionServerExtensions);
				this.mAllowCertificateStatus = (!this.mResumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47));
				this.mExpectSessionTicket = (!this.mResumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47));
			}
			if (sessionClientExtensions != null)
			{
				this.mTlsClient.ProcessServerExtensions(sessionServerExtensions);
			}
			this.mSecurityParameters.prfAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetPrfAlgorithm(this.Context, this.mSecurityParameters.CipherSuite);
			this.mSecurityParameters.verifyDataLength = 12;
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x0009A740 File Offset: 0x00098940
		protected virtual void SendCertificateVerifyMessage(global::Org.BouncyCastle.Crypto.Tls.DigitallySigned certificateVerify)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(15);
			certificateVerify.Encode(message);
			message.WriteToRecordStream(this);
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x0009A764 File Offset: 0x00098964
		protected virtual void SendClientHelloMessage()
		{
			this.mRecordStream.SetWriteVersion(this.mTlsClient.ClientHelloRecordLayerVersion);
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion client_version = this.mTlsClient.ClientVersion;
			if (client_version.IsDtls)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.ContextAdmin.SetClientVersion(client_version);
			byte[] session_id = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			if (this.mTlsSession != null)
			{
				session_id = this.mTlsSession.SessionID;
				if (session_id == null || session_id.Length > 32)
				{
					session_id = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
				}
			}
			bool isFallback = this.mTlsClient.IsFallback;
			this.mOfferedCipherSuites = this.mTlsClient.GetCipherSuites();
			this.mOfferedCompressionMethods = this.mTlsClient.GetCompressionMethods();
			if (session_id.Length != 0 && this.mSessionParameters != null && (!this.mSessionParameters.IsExtendedMasterSecret || !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, this.mSessionParameters.CipherSuite) || !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCompressionMethods, this.mSessionParameters.CompressionAlgorithm)))
			{
				session_id = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			}
			this.mClientExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(this.mTlsClient.GetClientExtensions());
			if (!client_version.IsSsl)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(this.mClientExtensions);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(1);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(client_version, message);
			message.Write(this.mSecurityParameters.ClientRandom);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(session_id, message);
			byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(this.mClientExtensions, 65281);
			bool flag = renegExtData == null;
			bool noRenegScsv = !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, 255);
			if (flag && noRenegScsv)
			{
				this.mOfferedCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(this.mOfferedCipherSuites, 255);
			}
			if (isFallback && !global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, 22016))
			{
				this.mOfferedCipherSuites = global::Org.BouncyCastle.Utilities.Arrays.Append(this.mOfferedCipherSuites, 22016);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(this.mOfferedCipherSuites, message);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(this.mOfferedCompressionMethods, message);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(message, this.mClientExtensions);
			message.WriteToRecordStream(this);
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x0009A940 File Offset: 0x00098B40
		protected virtual void SendClientKeyExchangeMessage()
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(16);
			this.mKeyExchange.GenerateClientKeyExchange(message);
			message.WriteToRecordStream(this);
		}

		// Token: 0x04000E42 RID: 3650
		protected global::Org.BouncyCastle.Crypto.Tls.TlsClient mTlsClient;

		// Token: 0x04000E43 RID: 3651
		internal global::Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl mTlsClientContext;

		// Token: 0x04000E44 RID: 3652
		protected byte[] mSelectedSessionID;

		// Token: 0x04000E45 RID: 3653
		protected global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange mKeyExchange;

		// Token: 0x04000E46 RID: 3654
		protected global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication mAuthentication;

		// Token: 0x04000E47 RID: 3655
		protected global::Org.BouncyCastle.Crypto.Tls.CertificateStatus mCertificateStatus;

		// Token: 0x04000E48 RID: 3656
		protected global::Org.BouncyCastle.Crypto.Tls.CertificateRequest mCertificateRequest;
	}
}
