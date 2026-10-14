using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000349 RID: 841
	public sealed class SessionParameters
	{
		// Token: 0x060022A6 RID: 8870 RVA: 0x00098810 File Offset: 0x00096A10
		private SessionParameters(int cipherSuite, byte compressionAlgorithm, byte[] masterSecret, global::Org.BouncyCastle.Crypto.Tls.Certificate peerCertificate, byte[] pskIdentity, byte[] srpIdentity, byte[] encodedServerExtensions, bool extendedMasterSecret)
		{
			this.mCipherSuite = cipherSuite;
			this.mCompressionAlgorithm = compressionAlgorithm;
			this.mMasterSecret = global::Org.BouncyCastle.Utilities.Arrays.Clone(masterSecret);
			this.mPeerCertificate = peerCertificate;
			this.mPskIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(pskIdentity);
			this.mSrpIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(srpIdentity);
			this.mEncodedServerExtensions = encodedServerExtensions;
			this.mExtendedMasterSecret = extendedMasterSecret;
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0009886F File Offset: 0x00096A6F
		public void Clear()
		{
			if (this.mMasterSecret != null)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(this.mMasterSecret, 0);
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00098885 File Offset: 0x00096A85
		public global::Org.BouncyCastle.Crypto.Tls.SessionParameters Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Tls.SessionParameters(this.mCipherSuite, this.mCompressionAlgorithm, this.mMasterSecret, this.mPeerCertificate, this.mPskIdentity, this.mSrpIdentity, this.mEncodedServerExtensions, this.mExtendedMasterSecret);
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x000988BC File Offset: 0x00096ABC
		public int CipherSuite
		{
			get
			{
				return this.mCipherSuite;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x000988C4 File Offset: 0x00096AC4
		public byte CompressionAlgorithm
		{
			get
			{
				return this.mCompressionAlgorithm;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x000988CC File Offset: 0x00096ACC
		public bool IsExtendedMasterSecret
		{
			get
			{
				return this.mExtendedMasterSecret;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x000988D4 File Offset: 0x00096AD4
		public byte[] MasterSecret
		{
			get
			{
				return this.mMasterSecret;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x000988DC File Offset: 0x00096ADC
		public global::Org.BouncyCastle.Crypto.Tls.Certificate PeerCertificate
		{
			get
			{
				return this.mPeerCertificate;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x000988E4 File Offset: 0x00096AE4
		public byte[] PskIdentity
		{
			get
			{
				return this.mPskIdentity;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x000988EC File Offset: 0x00096AEC
		public byte[] SrpIdentity
		{
			get
			{
				return this.mSrpIdentity;
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x000988F4 File Offset: 0x00096AF4
		public global::System.Collections.IDictionary ReadServerExtensions()
		{
			if (this.mEncodedServerExtensions == null)
			{
				return null;
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(new global::System.IO.MemoryStream(this.mEncodedServerExtensions, false));
		}

		// Token: 0x04000E05 RID: 3589
		private int mCipherSuite;

		// Token: 0x04000E06 RID: 3590
		private byte mCompressionAlgorithm;

		// Token: 0x04000E07 RID: 3591
		private byte[] mMasterSecret;

		// Token: 0x04000E08 RID: 3592
		private global::Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate;

		// Token: 0x04000E09 RID: 3593
		private byte[] mPskIdentity;

		// Token: 0x04000E0A RID: 3594
		private byte[] mSrpIdentity;

		// Token: 0x04000E0B RID: 3595
		private byte[] mEncodedServerExtensions;

		// Token: 0x04000E0C RID: 3596
		private bool mExtendedMasterSecret;

		// Token: 0x020007FE RID: 2046
		public sealed class Builder
		{
			// Token: 0x06004640 RID: 17984 RVA: 0x001363B8 File Offset: 0x001345B8
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters Build()
			{
				this.Validate(this.mCipherSuite >= 0, "cipherSuite");
				this.Validate(this.mCompressionAlgorithm >= 0, "compressionAlgorithm");
				this.Validate(this.mMasterSecret != null, "masterSecret");
				return new global::Org.BouncyCastle.Crypto.Tls.SessionParameters(this.mCipherSuite, (byte)this.mCompressionAlgorithm, this.mMasterSecret, this.mPeerCertificate, this.mPskIdentity, this.mSrpIdentity, this.mEncodedServerExtensions, this.mExtendedMasterSecret);
			}

			// Token: 0x06004641 RID: 17985 RVA: 0x0013643D File Offset: 0x0013463D
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetCipherSuite(int cipherSuite)
			{
				this.mCipherSuite = cipherSuite;
				return this;
			}

			// Token: 0x06004642 RID: 17986 RVA: 0x00136447 File Offset: 0x00134647
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetCompressionAlgorithm(byte compressionAlgorithm)
			{
				this.mCompressionAlgorithm = (short)compressionAlgorithm;
				return this;
			}

			// Token: 0x06004643 RID: 17987 RVA: 0x00136451 File Offset: 0x00134651
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetExtendedMasterSecret(bool extendedMasterSecret)
			{
				this.mExtendedMasterSecret = extendedMasterSecret;
				return this;
			}

			// Token: 0x06004644 RID: 17988 RVA: 0x0013645B File Offset: 0x0013465B
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetMasterSecret(byte[] masterSecret)
			{
				this.mMasterSecret = masterSecret;
				return this;
			}

			// Token: 0x06004645 RID: 17989 RVA: 0x00136465 File Offset: 0x00134665
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetPeerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate peerCertificate)
			{
				this.mPeerCertificate = peerCertificate;
				return this;
			}

			// Token: 0x06004646 RID: 17990 RVA: 0x0013646F File Offset: 0x0013466F
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetPskIdentity(byte[] pskIdentity)
			{
				this.mPskIdentity = pskIdentity;
				return this;
			}

			// Token: 0x06004647 RID: 17991 RVA: 0x00136479 File Offset: 0x00134679
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetSrpIdentity(byte[] srpIdentity)
			{
				this.mSrpIdentity = srpIdentity;
				return this;
			}

			// Token: 0x06004648 RID: 17992 RVA: 0x00136484 File Offset: 0x00134684
			public global::Org.BouncyCastle.Crypto.Tls.SessionParameters.Builder SetServerExtensions(global::System.Collections.IDictionary serverExtensions)
			{
				if (serverExtensions == null)
				{
					this.mEncodedServerExtensions = null;
				}
				else
				{
					global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
					global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(buf, serverExtensions);
					this.mEncodedServerExtensions = buf.ToArray();
				}
				return this;
			}

			// Token: 0x06004649 RID: 17993 RVA: 0x001364B7 File Offset: 0x001346B7
			private void Validate(bool condition, string parameter)
			{
				if (!condition)
				{
					throw new global::System.InvalidOperationException("Required session parameter '" + parameter + "' not configured");
				}
			}

			// Token: 0x040024AA RID: 9386
			private int mCipherSuite = -1;

			// Token: 0x040024AB RID: 9387
			private short mCompressionAlgorithm = -1;

			// Token: 0x040024AC RID: 9388
			private byte[] mMasterSecret;

			// Token: 0x040024AD RID: 9389
			private global::Org.BouncyCastle.Crypto.Tls.Certificate mPeerCertificate;

			// Token: 0x040024AE RID: 9390
			private byte[] mPskIdentity;

			// Token: 0x040024AF RID: 9391
			private byte[] mSrpIdentity;

			// Token: 0x040024B0 RID: 9392
			private byte[] mEncodedServerExtensions;

			// Token: 0x040024B1 RID: 9393
			private bool mExtendedMasterSecret;
		}
	}
}
