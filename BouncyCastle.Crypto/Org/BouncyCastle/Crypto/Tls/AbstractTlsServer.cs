using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002FA RID: 762
	public abstract class AbstractTlsServer : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsPeer, global::Org.BouncyCastle.Crypto.Tls.TlsServer, global::Org.BouncyCastle.Crypto.Tls.TlsPeer
	{
		// Token: 0x0600209A RID: 8346 RVA: 0x00091902 File Offset: 0x0008FB02
		public AbstractTlsServer() : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory())
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x0009190F File Offset: 0x0008FB0F
		public AbstractTlsServer(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory)
		{
			this.mCipherFactory = cipherFactory;
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0009191E File Offset: 0x0008FB1E
		protected virtual bool AllowEncryptThenMac
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x00091921 File Offset: 0x0008FB21
		protected virtual bool AllowTruncatedHMac
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00091924 File Offset: 0x0008FB24
		protected virtual global::System.Collections.IDictionary CheckServerExtensions()
		{
			return this.mServerExtensions = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(this.mServerExtensions);
		}

		// Token: 0x0600209F RID: 8351
		protected abstract int[] GetCipherSuites();

		// Token: 0x060020A0 RID: 8352 RVA: 0x00091945 File Offset: 0x0008FB45
		protected byte[] GetCompressionMethods()
		{
			return new byte[1];
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0009194D File Offset: 0x0008FB4D
		protected virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MaximumVersion
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00091954 File Offset: 0x0008FB54
		protected virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
			}
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0009195C File Offset: 0x0008FB5C
		protected virtual bool SupportsClientEccCapabilities(int[] namedCurves, byte[] ecPointFormats)
		{
			if (namedCurves == null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.HasAnySupportedNamedCurves();
			}
			foreach (int namedCurve in namedCurves)
			{
				if (global::Org.BouncyCastle.Crypto.Tls.NamedCurve.IsValid(namedCurve) && (!global::Org.BouncyCastle.Crypto.Tls.NamedCurve.RefersToASpecificNamedCurve(namedCurve) || global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsSupportedNamedCurve(namedCurve)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0009199F File Offset: 0x0008FB9F
		public virtual void Init(global::Org.BouncyCastle.Crypto.Tls.TlsServerContext context)
		{
			this.mContext = context;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x000919A8 File Offset: 0x0008FBA8
		public virtual void NotifyClientVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion)
		{
			this.mClientVersion = clientVersion;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x000919B1 File Offset: 0x0008FBB1
		public virtual void NotifyFallback(bool isFallback)
		{
			if (isFallback && this.MaximumVersion.IsLaterVersionOf(this.mClientVersion))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(86);
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x000919D1 File Offset: 0x0008FBD1
		public virtual void NotifyOfferedCipherSuites(int[] offeredCipherSuites)
		{
			this.mOfferedCipherSuites = offeredCipherSuites;
			this.mEccCipherSuitesOffered = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ContainsEccCipherSuites(this.mOfferedCipherSuites);
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x000919EB File Offset: 0x0008FBEB
		public virtual void NotifyOfferedCompressionMethods(byte[] offeredCompressionMethods)
		{
			this.mOfferedCompressionMethods = offeredCompressionMethods;
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x000919F4 File Offset: 0x0008FBF4
		public virtual void ProcessClientExtensions(global::System.Collections.IDictionary clientExtensions)
		{
			this.mClientExtensions = clientExtensions;
			if (clientExtensions != null)
			{
				this.mEncryptThenMacOffered = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(clientExtensions);
				this.mMaxFragmentLengthOffered = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions);
				if (this.mMaxFragmentLengthOffered >= 0 && !global::Org.BouncyCastle.Crypto.Tls.MaxFragmentLength.IsValid((byte)this.mMaxFragmentLengthOffered))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				this.mTruncatedHMacOffered = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasTruncatedHMacExtension(clientExtensions);
				this.mSupportedSignatureAlgorithms = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAlgorithmsExtension(clientExtensions);
				if (this.mSupportedSignatureAlgorithms != null && !global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(this.mClientVersion))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				this.mNamedCurves = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetSupportedEllipticCurvesExtension(clientExtensions);
				this.mClientECPointFormats = global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetSupportedPointFormatsExtension(clientExtensions);
			}
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00091A94 File Offset: 0x0008FC94
		public virtual global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetServerVersion()
		{
			if (this.MinimumVersion.IsEqualOrEarlierVersionOf(this.mClientVersion))
			{
				global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion maximumVersion = this.MaximumVersion;
				if (this.mClientVersion.IsEqualOrEarlierVersionOf(maximumVersion))
				{
					return this.mServerVersion = this.mClientVersion;
				}
				if (this.mClientVersion.IsLaterVersionOf(maximumVersion))
				{
					return this.mServerVersion = maximumVersion;
				}
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(70);
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00091AFC File Offset: 0x0008FCFC
		public virtual int GetSelectedCipherSuite()
		{
			global::System.Collections.IList sigAlgs = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetUsableSignatureAlgorithms(this.mSupportedSignatureAlgorithms);
			bool eccCipherSuitesEnabled = this.SupportsClientEccCapabilities(this.mNamedCurves, this.mClientECPointFormats);
			foreach (int cipherSuite in this.GetCipherSuites())
			{
				if (global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCipherSuites, cipherSuite) && (eccCipherSuitesEnabled || !global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsEccCipherSuite(cipherSuite)) && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForVersion(cipherSuite, this.mServerVersion) && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForSignatureAlgorithms(cipherSuite, sigAlgs))
				{
					return this.mSelectedCipherSuite = cipherSuite;
				}
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00091B8C File Offset: 0x0008FD8C
		public virtual byte GetSelectedCompressionMethod()
		{
			byte[] compressionMethods = this.GetCompressionMethods();
			for (int i = 0; i < compressionMethods.Length; i++)
			{
				if (global::Org.BouncyCastle.Utilities.Arrays.Contains(this.mOfferedCompressionMethods, compressionMethods[i]))
				{
					return this.mSelectedCompressionMethod = compressionMethods[i];
				}
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(40);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00091BD4 File Offset: 0x0008FDD4
		public virtual global::System.Collections.IDictionary GetServerExtensions()
		{
			if (this.mEncryptThenMacOffered && this.AllowEncryptThenMac && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsBlockCipherSuite(this.mSelectedCipherSuite))
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddEncryptThenMacExtension(this.CheckServerExtensions());
			}
			if (this.mMaxFragmentLengthOffered >= 0 && global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8((int)this.mMaxFragmentLengthOffered) && global::Org.BouncyCastle.Crypto.Tls.MaxFragmentLength.IsValid((byte)this.mMaxFragmentLengthOffered))
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddMaxFragmentLengthExtension(this.CheckServerExtensions(), (byte)this.mMaxFragmentLengthOffered);
			}
			if (this.mTruncatedHMacOffered && this.AllowTruncatedHMac)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddTruncatedHMacExtension(this.CheckServerExtensions());
			}
			if (this.mClientECPointFormats != null && global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsEccCipherSuite(this.mSelectedCipherSuite))
			{
				this.mServerECPointFormats = new byte[]
				{
					0,
					1,
					2
				};
				global::Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.AddSupportedPointFormatsExtension(this.CheckServerExtensions(), this.mServerECPointFormats);
			}
			return this.mServerExtensions;
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x00091C9A File Offset: 0x0008FE9A
		public virtual global::System.Collections.IList GetServerSupplementalData()
		{
			return null;
		}

		// Token: 0x060020AF RID: 8367
		public abstract global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials();

		// Token: 0x060020B0 RID: 8368 RVA: 0x00091C9D File Offset: 0x0008FE9D
		public virtual global::Org.BouncyCastle.Crypto.Tls.CertificateStatus GetCertificateStatus()
		{
			return null;
		}

		// Token: 0x060020B1 RID: 8369
		public abstract global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange();

		// Token: 0x060020B2 RID: 8370 RVA: 0x00091CA0 File Offset: 0x0008FEA0
		public virtual global::Org.BouncyCastle.Crypto.Tls.CertificateRequest GetCertificateRequest()
		{
			return null;
		}

		// Token: 0x060020B3 RID: 8371 RVA: 0x00091CA3 File Offset: 0x0008FEA3
		public virtual void ProcessClientSupplementalData(global::System.Collections.IList clientSupplementalData)
		{
			if (clientSupplementalData != null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(10);
			}
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00091CB0 File Offset: 0x0008FEB0
		public virtual void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate)
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00091CB9 File Offset: 0x0008FEB9
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression()
		{
			if (this.mSelectedCompressionMethod == 0)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.TlsNullCompression();
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00091CD4 File Offset: 0x0008FED4
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher()
		{
			int encryptionAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetEncryptionAlgorithm(this.mSelectedCipherSuite);
			int macAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetMacAlgorithm(this.mSelectedCipherSuite);
			return this.mCipherFactory.CreateCipher(this.mContext, encryptionAlgorithm, macAlgorithm);
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00091D0C File Offset: 0x0008FF0C
		public virtual global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket GetNewSessionTicket()
		{
			return new global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket(0L, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes);
		}

		// Token: 0x04000B51 RID: 2897
		protected global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory mCipherFactory;

		// Token: 0x04000B52 RID: 2898
		protected global::Org.BouncyCastle.Crypto.Tls.TlsServerContext mContext;

		// Token: 0x04000B53 RID: 2899
		protected global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mClientVersion;

		// Token: 0x04000B54 RID: 2900
		protected int[] mOfferedCipherSuites;

		// Token: 0x04000B55 RID: 2901
		protected byte[] mOfferedCompressionMethods;

		// Token: 0x04000B56 RID: 2902
		protected global::System.Collections.IDictionary mClientExtensions;

		// Token: 0x04000B57 RID: 2903
		protected bool mEncryptThenMacOffered;

		// Token: 0x04000B58 RID: 2904
		protected short mMaxFragmentLengthOffered;

		// Token: 0x04000B59 RID: 2905
		protected bool mTruncatedHMacOffered;

		// Token: 0x04000B5A RID: 2906
		protected global::System.Collections.IList mSupportedSignatureAlgorithms;

		// Token: 0x04000B5B RID: 2907
		protected bool mEccCipherSuitesOffered;

		// Token: 0x04000B5C RID: 2908
		protected int[] mNamedCurves;

		// Token: 0x04000B5D RID: 2909
		protected byte[] mClientECPointFormats;

		// Token: 0x04000B5E RID: 2910
		protected byte[] mServerECPointFormats;

		// Token: 0x04000B5F RID: 2911
		protected global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion mServerVersion;

		// Token: 0x04000B60 RID: 2912
		protected int mSelectedCipherSuite;

		// Token: 0x04000B61 RID: 2913
		protected byte mSelectedCompressionMethod;

		// Token: 0x04000B62 RID: 2914
		protected global::System.Collections.IDictionary mServerExtensions;
	}
}
