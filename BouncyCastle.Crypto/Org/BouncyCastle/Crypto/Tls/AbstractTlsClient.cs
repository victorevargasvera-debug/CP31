using System;
using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F4 RID: 756
	public abstract class AbstractTlsClient : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsPeer, global::Org.BouncyCastle.Crypto.Tls.TlsClient, global::Org.BouncyCastle.Crypto.Tls.TlsPeer
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x000912E4 File Offset: 0x0008F4E4
		public AbstractTlsClient() : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory())
		{
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000912F1 File Offset: 0x0008F4F1
		public AbstractTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory)
		{
			this.mCipherFactory = cipherFactory;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00091300 File Offset: 0x0008F500
		protected virtual bool AllowUnexpectedServerExtension(int extensionType, byte[] extensionData)
		{
			if (extensionType == 10)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedEllipticCurvesExtension(extensionData);
				return true;
			}
			if (extensionType != 11)
			{
				return false;
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedPointFormatsExtension(extensionData);
			return true;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00091324 File Offset: 0x0008F524
		protected virtual void CheckForUnexpectedServerExtension(global::System.Collections.IDictionary serverExtensions, int extensionType)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(serverExtensions, extensionType);
			if (extensionData != null && !this.AllowUnexpectedServerExtension(extensionType, extensionData))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0009134E File Offset: 0x0008F54E
		public virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsClientContext context)
		{
			this.mContext = context;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00091357 File Offset: 0x0008F557
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsSession GetSessionToResume()
		{
			return null;
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0009135A File Offset: 0x0008F55A
		public virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientHelloRecordLayerVersion
		{
			get
			{
				return this.ClientVersion;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00091362 File Offset: 0x0008F562
		public virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00091369 File Offset: 0x0008F569
		public virtual bool IsFallback
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0009136C File Offset: 0x0008F56C
		public virtual global::System.Collections.IDictionary GetClientExtensions()
		{
			global::System.Collections.IDictionary clientExtensions = null;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(this.mContext.ClientVersion))
			{
				this.mSupportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultSupportedSignatureAlgorithms();
				clientExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(clientExtensions);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.AddSignatureAlgorithmsExtension(clientExtensions, this.mSupportedSignatureAlgorithms);
			}
			if (global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ContainsEccCipherSuites(this.GetCipherSuites()))
			{
				this.mNamedCurves = new int[]
				{
					23,
					24
				};
				this.mClientECPointFormats = new byte[]
				{
					0,
					1,
					2
				};
				clientExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(clientExtensions);
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.AddSupportedEllipticCurvesExtension(clientExtensions, this.mNamedCurves);
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.AddSupportedPointFormatsExtension(clientExtensions, this.mClientECPointFormats);
			}
			return clientExtensions;
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x00091402 File Offset: 0x0008F602
		public virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00091409 File Offset: 0x0008F609
		public virtual void NotifyServerVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion)
		{
			if (!this.MinimumVersion.IsEqualOrEarlierVersionOf(serverVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(70);
			}
		}

		// Token: 0x0600205B RID: 8283
		public abstract int[] GetCipherSuites();

		// Token: 0x0600205C RID: 8284 RVA: 0x00091421 File Offset: 0x0008F621
		public virtual byte[] GetCompressionMethods()
		{
			return new byte[1];
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00091429 File Offset: 0x0008F629
		public virtual void NotifySessionID(byte[] sessionID)
		{
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0009142B File Offset: 0x0008F62B
		public virtual void NotifySelectedCipherSuite(int selectedCipherSuite)
		{
			this.mSelectedCipherSuite = selectedCipherSuite;
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00091434 File Offset: 0x0008F634
		public virtual void NotifySelectedCompressionMethod(byte selectedCompressionMethod)
		{
			this.mSelectedCompressionMethod = (short)selectedCompressionMethod;
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00091440 File Offset: 0x0008F640
		public virtual void ProcessServerExtensions(global::System.Collections.IDictionary serverExtensions)
		{
			if (serverExtensions != null)
			{
				this.CheckForUnexpectedServerExtension(serverExtensions, 13);
				this.CheckForUnexpectedServerExtension(serverExtensions, 10);
				if (global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsEccCipherSuite(this.mSelectedCipherSuite))
				{
					this.mServerECPointFormats = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetSupportedPointFormatsExtension(serverExtensions);
				}
				else
				{
					this.CheckForUnexpectedServerExtension(serverExtensions, 11);
				}
				this.CheckForUnexpectedServerExtension(serverExtensions, 21);
			}
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0009148F File Offset: 0x0008F68F
		public virtual void ProcessServerSupplementalData(global::System.Collections.IList serverSupplementalData)
		{
			if (serverSupplementalData != null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x06002062 RID: 8290
		public abstract global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange();

		// Token: 0x06002063 RID: 8291
		public abstract global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication();

		// Token: 0x06002064 RID: 8292 RVA: 0x0009149C File Offset: 0x0008F69C
		public virtual global::System.Collections.IList GetClientSupplementalData()
		{
			return null;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000914A0 File Offset: 0x0008F6A0
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression()
		{
			short num = this.mSelectedCompressionMethod;
			if (num == 0)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.TlsNullCompression();
			}
			if (num != 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDeflateCompression();
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000914D0 File Offset: 0x0008F6D0
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher()
		{
			int encryptionAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetEncryptionAlgorithm(this.mSelectedCipherSuite);
			int macAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetMacAlgorithm(this.mSelectedCipherSuite);
			return this.mCipherFactory.CreateCipher(this.mContext, encryptionAlgorithm, macAlgorithm);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00091508 File Offset: 0x0008F708
		public virtual void NotifyNewSessionTicket(global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket)
		{
		}

		// Token: 0x04000B3D RID: 2877
		protected global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory mCipherFactory;

		// Token: 0x04000B3E RID: 2878
		protected global::Org.BouncyCastle.Crypto.Tls.TlsClientContext mContext;

		// Token: 0x04000B3F RID: 2879
		protected global::System.Collections.IList mSupportedSignatureAlgorithms;

		// Token: 0x04000B40 RID: 2880
		protected int[] mNamedCurves;

		// Token: 0x04000B41 RID: 2881
		protected byte[] mClientECPointFormats;

		// Token: 0x04000B42 RID: 2882
		protected byte[] mServerECPointFormats;

		// Token: 0x04000B43 RID: 2883
		protected int mSelectedCipherSuite;

		// Token: 0x04000B44 RID: 2884
		protected short mSelectedCompressionMethod;
	}
}
