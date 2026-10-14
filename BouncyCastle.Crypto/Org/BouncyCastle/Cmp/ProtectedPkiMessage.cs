using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crmf;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000563 RID: 1379
	public class ProtectedPkiMessage
	{
		// Token: 0x060034B6 RID: 13494 RVA: 0x000FBA4D File Offset: 0x000F9C4D
		public ProtectedPkiMessage(global::Org.BouncyCastle.Cmp.GeneralPkiMessage pkiMessage)
		{
			if (!pkiMessage.HasProtection)
			{
				throw new global::System.ArgumentException("pki message not protected");
			}
			this.pkiMessage = pkiMessage.ToAsn1Structure();
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000FBA74 File Offset: 0x000F9C74
		public ProtectedPkiMessage(global::Org.BouncyCastle.Asn1.Cmp.PkiMessage pkiMessage)
		{
			if (pkiMessage.Header.ProtectionAlg == null)
			{
				throw new global::System.ArgumentException("pki message not protected");
			}
			this.pkiMessage = pkiMessage;
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x000FBA9B File Offset: 0x000F9C9B
		public global::Org.BouncyCastle.Asn1.Cmp.PkiHeader Header
		{
			get
			{
				return this.pkiMessage.Header;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x000FBAA8 File Offset: 0x000F9CA8
		public global::Org.BouncyCastle.Asn1.Cmp.PkiBody Body
		{
			get
			{
				return this.pkiMessage.Body;
			}
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x000FBAB5 File Offset: 0x000F9CB5
		public global::Org.BouncyCastle.Asn1.Cmp.PkiMessage ToAsn1Message()
		{
			return this.pkiMessage;
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x000FBABD File Offset: 0x000F9CBD
		public bool HasPasswordBasedMacProtected
		{
			get
			{
				return this.Header.ProtectionAlg.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Cmp.CmpObjectIdentifiers.passwordBasedMac);
			}
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000FBADC File Offset: 0x000F9CDC
		public global::Org.BouncyCastle.X509.X509Certificate[] GetCertificates()
		{
			global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] certs = this.pkiMessage.GetExtraCerts();
			if (certs == null)
			{
				return new global::Org.BouncyCastle.X509.X509Certificate[0];
			}
			global::Org.BouncyCastle.X509.X509Certificate[] res = new global::Org.BouncyCastle.X509.X509Certificate[certs.Length];
			for (int t = 0; t < certs.Length; t++)
			{
				res[t] = new global::Org.BouncyCastle.X509.X509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(certs[t].GetEncoded()));
			}
			return res;
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000FBB2C File Offset: 0x000F9D2C
		public bool Verify(global::Org.BouncyCastle.Crypto.IVerifierFactory verifierFactory)
		{
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = verifierFactory.CreateCalculator();
			return ((global::Org.BouncyCastle.Crypto.IVerifier)this.Process(streamCalculator)).IsVerified(this.pkiMessage.Protection.GetBytes());
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000FBB64 File Offset: 0x000F9D64
		private object Process(global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator)
		{
			byte[] enc = new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1EncodableVector
			{
				this.pkiMessage.Header,
				this.pkiMessage.Body
			}).GetDerEncoded();
			streamCalculator.Stream.Write(enc, 0, enc.Length);
			streamCalculator.Stream.Flush();
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			return streamCalculator.GetResult();
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x000FBBD0 File Offset: 0x000F9DD0
		public bool Verify(global::Org.BouncyCastle.Crmf.PKMacBuilder pkMacBuilder, char[] password)
		{
			if (!global::Org.BouncyCastle.Asn1.Cmp.CmpObjectIdentifiers.passwordBasedMac.Equals(this.pkiMessage.Header.ProtectionAlg.Algorithm))
			{
				throw new global::System.InvalidOperationException("protection algorithm is not mac based");
			}
			global::Org.BouncyCastle.Asn1.Cmp.PbmParameter parameter = global::Org.BouncyCastle.Asn1.Cmp.PbmParameter.GetInstance(this.pkiMessage.Header.ProtectionAlg.Parameters);
			pkMacBuilder.SetParameters(parameter);
			return global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(((global::Org.BouncyCastle.Crypto.IBlockResult)this.Process(pkMacBuilder.Build(password).CreateCalculator())).Collect(), this.pkiMessage.Protection.GetBytes());
		}

		// Token: 0x04001792 RID: 6034
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiMessage pkiMessage;
	}
}
