using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000385 RID: 901
	public class TlsServerProtocol : global::Org.BouncyCastle.Crypto.Tls.TlsProtocol
	{
		// Token: 0x0600249C RID: 9372 RVA: 0x0009EDA5 File Offset: 0x0009CFA5
		public TlsServerProtocol(global::System.IO.Stream stream, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(stream, secureRandom)
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0009EDB6 File Offset: 0x0009CFB6
		public TlsServerProtocol(global::System.IO.Stream input, global::System.IO.Stream output, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(input, output, secureRandom)
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0009EDC8 File Offset: 0x0009CFC8
		public TlsServerProtocol(global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(secureRandom)
		{
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0009EDD8 File Offset: 0x0009CFD8
		public virtual void Accept(global::Org.BouncyCastle.Crypto.Tls.TlsServer tlsServer)
		{
			if (tlsServer == null)
			{
				throw new global::System.ArgumentNullException("tlsServer");
			}
			if (this.mTlsServer != null)
			{
				throw new global::System.InvalidOperationException("'Accept' can only be called once");
			}
			this.mTlsServer = tlsServer;
			this.mSecurityParameters = new global::Org.BouncyCastle.Crypto.Tls.SecurityParameters();
			this.mSecurityParameters.entity = 0;
			this.mTlsServerContext = new global::Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl(this.mSecureRandom, this.mSecurityParameters);
			this.mSecurityParameters.serverRandom = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRandomBlock(tlsServer.ShouldUseGmtUnixTime(), this.mTlsServerContext.NonceRandomGenerator);
			this.mTlsServer.Init(this.mTlsServerContext);
			this.mRecordStream.Init(this.mTlsServerContext);
			tlsServer.NotifyCloseHandle(this);
			this.mRecordStream.SetRestrictReadVersion(false);
			this.BlockForHandshake();
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0009EE97 File Offset: 0x0009D097
		protected override void CleanupHandshake()
		{
			base.CleanupHandshake();
			this.mKeyExchange = null;
			this.mServerCredentials = null;
			this.mCertificateRequest = null;
			this.mPrepareFinishHash = null;
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x0009EEBB File Offset: 0x0009D0BB
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsContext Context
		{
			get
			{
				return this.mTlsServerContext;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0009EEC3 File Offset: 0x0009D0C3
		internal override global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext ContextAdmin
		{
			get
			{
				return this.mTlsServerContext;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x0009EECB File Offset: 0x0009D0CB
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsPeer Peer
		{
			get
			{
				return this.mTlsServer;
			}
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0009EED4 File Offset: 0x0009D0D4
		protected override void HandleHandshakeMessage(byte type, global::System.IO.MemoryStream buf)
		{
			switch (type)
			{
			case 1:
			{
				short mConnectionState = this.mConnectionState;
				if (mConnectionState == 0)
				{
					this.ReceiveClientHelloMessage(buf);
					this.mConnectionState = 1;
					this.SendServerHelloMessage();
					this.mConnectionState = 2;
					this.mRecordStream.NotifyHelloComplete();
					global::System.Collections.IList serverSupplementalData = this.mTlsServer.GetServerSupplementalData();
					if (serverSupplementalData != null)
					{
						this.SendSupplementalDataMessage(serverSupplementalData);
					}
					this.mConnectionState = 3;
					this.mKeyExchange = this.mTlsServer.GetKeyExchange();
					this.mKeyExchange.Init(this.Context);
					this.mServerCredentials = this.mTlsServer.GetCredentials();
					global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate = null;
					if (this.mServerCredentials == null)
					{
						this.mKeyExchange.SkipServerCredentials();
					}
					else
					{
						this.mKeyExchange.ProcessServerCredentials(this.mServerCredentials);
						serverCertificate = this.mServerCredentials.Certificate;
						this.SendCertificateMessage(serverCertificate);
					}
					this.mConnectionState = 4;
					if (serverCertificate == null || serverCertificate.IsEmpty)
					{
						this.mAllowCertificateStatus = false;
					}
					if (this.mAllowCertificateStatus)
					{
						global::Org.BouncyCastle.Crypto.Tls.CertificateStatus certificateStatus = this.mTlsServer.GetCertificateStatus();
						if (certificateStatus != null)
						{
							this.SendCertificateStatusMessage(certificateStatus);
						}
					}
					this.mConnectionState = 5;
					byte[] serverKeyExchange = this.mKeyExchange.GenerateServerKeyExchange();
					if (serverKeyExchange != null)
					{
						this.SendServerKeyExchangeMessage(serverKeyExchange);
					}
					this.mConnectionState = 6;
					if (this.mServerCredentials != null)
					{
						this.mCertificateRequest = this.mTlsServer.GetCertificateRequest();
						if (this.mCertificateRequest != null)
						{
							if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.Context) != (this.mCertificateRequest.SupportedSignatureAlgorithms != null))
							{
								throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
							}
							this.mKeyExchange.ValidateCertificateRequest(this.mCertificateRequest);
							this.SendCertificateRequestMessage(this.mCertificateRequest);
							global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.TrackHashAlgorithms(this.mRecordStream.HandshakeHash, this.mCertificateRequest.SupportedSignatureAlgorithms);
						}
					}
					this.mConnectionState = 7;
					this.SendServerHelloDoneMessage();
					this.mConnectionState = 8;
					this.mRecordStream.HandshakeHash.SealHashAlgorithms();
					return;
				}
				if (mConnectionState != 16)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.RefuseRenegotiation();
				return;
			}
			case 11:
			{
				short mConnectionState = this.mConnectionState;
				if (mConnectionState - 8 > 1)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				if (this.mConnectionState < 9)
				{
					this.mTlsServer.ProcessClientSupplementalData(null);
				}
				if (this.mCertificateRequest == null)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.ReceiveCertificateMessage(buf);
				this.mConnectionState = 10;
				return;
			}
			case 15:
				if (this.mConnectionState != 11)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				if (!this.ExpectCertificateVerifyMessage())
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.ReceiveCertificateVerifyMessage(buf);
				this.mConnectionState = 12;
				return;
			case 16:
			{
				short mConnectionState = this.mConnectionState;
				if (mConnectionState - 8 <= 2)
				{
					if (this.mConnectionState < 9)
					{
						this.mTlsServer.ProcessClientSupplementalData(null);
					}
					if (this.mConnectionState < 10)
					{
						if (this.mCertificateRequest == null)
						{
							this.mKeyExchange.SkipClientCredentials();
						}
						else
						{
							if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.Context))
							{
								throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
							}
							if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.Context))
							{
								if (this.mPeerCertificate == null)
								{
									throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
								}
							}
							else
							{
								this.NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain);
							}
						}
					}
					this.ReceiveClientKeyExchangeMessage(buf);
					this.mConnectionState = 11;
					return;
				}
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			case 20:
			{
				short mConnectionState = this.mConnectionState;
				if (mConnectionState - 11 > 1)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				if (this.mConnectionState < 12 && this.ExpectCertificateVerifyMessage())
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
				}
				this.ProcessFinishedMessage(buf);
				this.mConnectionState = 13;
				if (this.mExpectSessionTicket)
				{
					this.SendNewSessionTicketMessage(this.mTlsServer.GetNewSessionTicket());
				}
				this.mConnectionState = 14;
				this.SendChangeCipherSpecMessage();
				this.SendFinishedMessage();
				this.mConnectionState = 15;
				this.CompleteHandshake();
				return;
			}
			case 23:
				if (this.mConnectionState == 8)
				{
					this.mTlsServer.ProcessClientSupplementalData(global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadSupplementalDataMessage(buf));
					this.mConnectionState = 9;
					return;
				}
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0009F2E8 File Offset: 0x0009D4E8
		protected override void HandleAlertWarningMessage(byte alertDescription)
		{
			if (41 == alertDescription && this.mCertificateRequest != null && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.mTlsServerContext))
			{
				short mConnectionState = this.mConnectionState;
				if (mConnectionState - 8 <= 1)
				{
					if (this.mConnectionState < 9)
					{
						this.mTlsServer.ProcessClientSupplementalData(null);
					}
					this.NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain);
					this.mConnectionState = 10;
					return;
				}
			}
			base.HandleAlertWarningMessage(alertDescription);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0009F350 File Offset: 0x0009D550
		protected virtual void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			if (this.mCertificateRequest == null)
			{
				throw new global::System.InvalidOperationException();
			}
			if (this.mPeerCertificate != null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
			this.mPeerCertificate = clientCertificate;
			if (clientCertificate.IsEmpty)
			{
				this.mKeyExchange.SkipClientCredentials();
			}
			else
			{
				this.mClientCertificateType = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetClientCertificateType(clientCertificate, this.mServerCredentials.Certificate);
				this.mKeyExchange.ProcessClientCertificate(clientCertificate);
			}
			this.mTlsServer.NotifyClientCertificate(clientCertificate);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0009F3C8 File Offset: 0x0009D5C8
		protected virtual void ReceiveCertificateMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate = global::Org.BouncyCastle.Crypto.Tls.Certificate.Parse(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			this.NotifyClientCertificate(clientCertificate);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0009F3EC File Offset: 0x0009D5EC
		protected virtual void ReceiveCertificateVerifyMessage(global::System.IO.MemoryStream buf)
		{
			if (this.mCertificateRequest == null)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Org.BouncyCastle.Crypto.Tls.DigitallySigned clientCertificateVerify = global::Org.BouncyCastle.Crypto.Tls.DigitallySigned.Parse(this.Context, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			try
			{
				global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAlgorithm = clientCertificateVerify.Algorithm;
				byte[] hash;
				if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(this.Context))
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.VerifySupportedSignatureAlgorithm(this.mCertificateRequest.SupportedSignatureAlgorithms, signatureAlgorithm);
					hash = this.mPrepareFinishHash.GetFinalHash(signatureAlgorithm.Hash);
				}
				else
				{
					hash = this.mSecurityParameters.SessionHash;
				}
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(this.mPeerCertificate.GetCertificateAt(0).SubjectPublicKeyInfo);
				global::Org.BouncyCastle.Crypto.Tls.TlsSigner tlsSigner = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateTlsSigner((byte)this.mClientCertificateType);
				tlsSigner.Init(this.Context);
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

		// Token: 0x060024A9 RID: 9385 RVA: 0x0009F4D4 File Offset: 0x0009D6D4
		protected virtual void ReceiveClientHelloMessage(global::System.IO.MemoryStream buf)
		{
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion client_version = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(buf);
			this.mRecordStream.SetWriteVersion(client_version);
			if (client_version.IsDtls)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			byte[] client_random = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(32, buf);
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(buf).Length > 32)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			int cipher_suites_length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
			if (cipher_suites_length < 2 || (cipher_suites_length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			this.mOfferedCipherSuites = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16Array(cipher_suites_length / 2, buf);
			int compression_methods_length = (int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf);
			if (compression_methods_length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			this.mOfferedCompressionMethods = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8Array(compression_methods_length, buf);
			this.mClientExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(buf);
			this.mSecurityParameters.extendedMasterSecret = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(this.mClientExtensions);
			if (!this.mSecurityParameters.IsExtendedMasterSecret && this.mTlsServer.RequiresExtendedMasterSecret())
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
			}
			this.ContextAdmin.SetClientVersion(client_version);
			this.mTlsServer.NotifyClientVersion(client_version);
			this.mTlsServer.NotifyFallback(global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, 22016));
			this.mSecurityParameters.clientRandom = client_random;
			this.mTlsServer.NotifyOfferedCipherSuites(this.mOfferedCipherSuites);
			this.mTlsServer.NotifyOfferedCompressionMethods(this.mOfferedCompressionMethods);
			if (global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, 255))
			{
				this.mSecureRenegotiation = true;
			}
			byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(this.mClientExtensions, 65281);
			if (renegExtData != null)
			{
				this.mSecureRenegotiation = true;
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(renegExtData, global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes)))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
				}
			}
			this.mTlsServer.NotifySecureRenegotiation(this.mSecureRenegotiation);
			if (this.mClientExtensions != null)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetPaddingExtension(this.mClientExtensions);
				this.mTlsServer.ProcessClientExtensions(this.mClientExtensions);
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0009F694 File Offset: 0x0009D894
		protected virtual void ReceiveClientKeyExchangeMessage(global::System.IO.MemoryStream buf)
		{
			this.mKeyExchange.ProcessClientKeyExchange(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.Context))
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(this.Context, this.mKeyExchange);
			}
			this.mPrepareFinishHash = this.mRecordStream.PrepareToFinish();
			this.mSecurityParameters.sessionHash = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(this.Context, this.mPrepareFinishHash, null);
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.Context))
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(this.Context, this.mKeyExchange);
			}
			this.mRecordStream.SetPendingConnectionState(this.Peer.GetCompression(), this.Peer.GetCipher());
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0009F740 File Offset: 0x0009D940
		protected virtual void SendCertificateRequestMessage(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(13);
			certificateRequest.Encode(message);
			message.WriteToRecordStream(this);
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0009F764 File Offset: 0x0009D964
		protected virtual void SendCertificateStatusMessage(global::Org.BouncyCastle.Crypto.Tls.CertificateStatus certificateStatus)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(22);
			certificateStatus.Encode(message);
			message.WriteToRecordStream(this);
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0009F788 File Offset: 0x0009D988
		protected virtual void SendNewSessionTicketMessage(global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket)
		{
			if (newSessionTicket == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(4);
			newSessionTicket.Encode(message);
			message.WriteToRecordStream(this);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0009F7B8 File Offset: 0x0009D9B8
		protected virtual void SendServerHelloMessage()
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage message = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(2);
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion server_version = this.mTlsServer.GetServerVersion();
			if (!server_version.IsEqualOrEarlierVersionOf(this.Context.ClientVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.mRecordStream.ReadVersion = server_version;
			this.mRecordStream.SetWriteVersion(server_version);
			this.mRecordStream.SetRestrictReadVersion(true);
			this.ContextAdmin.SetServerVersion(server_version);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(server_version, message);
			message.Write(this.mSecurityParameters.serverRandom);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes, message);
			int selectedCipherSuite = this.mTlsServer.GetSelectedCipherSuite();
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || global::Org.BouncyCastle.Crypto.Tls.CipherSuite.IsScsv(selectedCipherSuite) || !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, this.Context.ServerVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.mSecurityParameters.cipherSuite = selectedCipherSuite;
			byte selectedCompressionMethod = this.mTlsServer.GetSelectedCompressionMethod();
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCompressionMethods, selectedCompressionMethod))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.mSecurityParameters.compressionAlgorithm = selectedCompressionMethod;
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(selectedCipherSuite, message);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(selectedCompressionMethod, message);
			this.mServerExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(this.mTlsServer.GetServerExtensions());
			if (this.mSecureRenegotiation)
			{
				byte[] renegExtData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(this.mServerExtensions, 65281);
				if (renegExtData == null)
				{
					this.mServerExtensions[65281] = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes);
				}
			}
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.mTlsServerContext))
			{
				this.mSecurityParameters.extendedMasterSecret = false;
			}
			else if (this.mSecurityParameters.IsExtendedMasterSecret)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddExtendedMasterSecretExtension(this.mServerExtensions);
			}
			if (this.mServerExtensions.Count > 0)
			{
				this.mSecurityParameters.encryptThenMac = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(this.mServerExtensions);
				this.mSecurityParameters.maxFragmentLength = this.ProcessMaxFragmentLengthExtension(this.mClientExtensions, this.mServerExtensions, 80);
				this.mSecurityParameters.truncatedHMac = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasTruncatedHMacExtension(this.mServerExtensions);
				this.mAllowCertificateStatus = (!this.mResumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(this.mServerExtensions, 5, 80));
				this.mExpectSessionTicket = (!this.mResumedSession && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(this.mServerExtensions, 35, 80));
				global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(message, this.mServerExtensions);
			}
			this.mSecurityParameters.prfAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetPrfAlgorithm(this.Context, this.mSecurityParameters.CipherSuite);
			this.mSecurityParameters.verifyDataLength = 12;
			this.ApplyMaxFragmentLengthExtension();
			message.WriteToRecordStream(this);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0009FA3C File Offset: 0x0009DC3C
		protected virtual void SendServerHelloDoneMessage()
		{
			byte[] message = new byte[4];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(14, message, 0);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(0, message, 1);
			this.WriteHandshakeMessage(message, 0, message.Length);
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0009FA6C File Offset: 0x0009DC6C
		protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage handshakeMessage = new global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.HandshakeMessage(12, serverKeyExchange.Length);
			handshakeMessage.Write(serverKeyExchange);
			handshakeMessage.WriteToRecordStream(this);
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0009FA85 File Offset: 0x0009DC85
		protected virtual bool ExpectCertificateVerifyMessage()
		{
			return this.mClientCertificateType >= 0 && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasSigningCapability((byte)this.mClientCertificateType);
		}

		// Token: 0x04000EBD RID: 3773
		protected global::Org.BouncyCastle.Crypto.Tls.TlsServer mTlsServer;

		// Token: 0x04000EBE RID: 3774
		internal global::Org.BouncyCastle.Crypto.Tls.TlsServerContextImpl mTlsServerContext;

		// Token: 0x04000EBF RID: 3775
		protected global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange mKeyExchange;

		// Token: 0x04000EC0 RID: 3776
		protected global::Org.BouncyCastle.Crypto.Tls.TlsCredentials mServerCredentials;

		// Token: 0x04000EC1 RID: 3777
		protected global::Org.BouncyCastle.Crypto.Tls.CertificateRequest mCertificateRequest;

		// Token: 0x04000EC2 RID: 3778
		protected short mClientCertificateType = -1;

		// Token: 0x04000EC3 RID: 3779
		protected global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash mPrepareFinishHash;
	}
}
