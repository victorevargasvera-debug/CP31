using System;
using System.Text;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x0200019A RID: 410
	public class PkixCertPathBuilderResult : global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult
	{
		// Token: 0x06000F17 RID: 3863 RVA: 0x00037F93 File Offset: 0x00036193
		public PkixCertPathBuilderResult(global::Org.BouncyCastle.Pkix.PkixCertPath certPath, global::Org.BouncyCastle.Pkix.TrustAnchor trustAnchor, global::Org.BouncyCastle.Pkix.PkixPolicyNode policyTree, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter subjectPublicKey) : base(trustAnchor, policyTree, subjectPublicKey)
		{
			if (certPath == null)
			{
				throw new global::System.ArgumentNullException("certPath");
			}
			this.certPath = certPath;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000F18 RID: 3864 RVA: 0x00037FB4 File Offset: 0x000361B4
		public global::Org.BouncyCastle.Pkix.PkixCertPath CertPath
		{
			get
			{
				return this.certPath;
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00037FBC File Offset: 0x000361BC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("SimplePKIXCertPathBuilderResult: [\n");
			stringBuilder.Append("  Certification Path: ").Append(this.CertPath).Append('\n');
			stringBuilder.Append("  Trust Anchor: ").Append(base.TrustAnchor.TrustedCert.IssuerDN.ToString()).Append('\n');
			stringBuilder.Append("  Subject Public Key: ").Append(base.SubjectPublicKey).Append("\n]");
			return stringBuilder.ToString();
		}

		// Token: 0x04000856 RID: 2134
		private global::Org.BouncyCastle.Pkix.PkixCertPath certPath;
	}
}
