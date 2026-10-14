using System;
using System.Text;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x0200019E RID: 414
	public class PkixCertPathValidatorResult
	{
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x00038792 File Offset: 0x00036992
		public global::Org.BouncyCastle.Pkix.PkixPolicyNode PolicyTree
		{
			get
			{
				return this.policyTree;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0003879A File Offset: 0x0003699A
		public global::Org.BouncyCastle.Pkix.TrustAnchor TrustAnchor
		{
			get
			{
				return this.trustAnchor;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x000387A2 File Offset: 0x000369A2
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter SubjectPublicKey
		{
			get
			{
				return this.subjectPublicKey;
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000387AA File Offset: 0x000369AA
		public PkixCertPathValidatorResult(global::Org.BouncyCastle.Pkix.TrustAnchor trustAnchor, global::Org.BouncyCastle.Pkix.PkixPolicyNode policyTree, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter subjectPublicKey)
		{
			if (subjectPublicKey == null)
			{
				throw new global::System.NullReferenceException("subjectPublicKey must be non-null");
			}
			if (trustAnchor == null)
			{
				throw new global::System.NullReferenceException("trustAnchor must be non-null");
			}
			this.trustAnchor = trustAnchor;
			this.policyTree = policyTree;
			this.subjectPublicKey = subjectPublicKey;
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000387E3 File Offset: 0x000369E3
		public object Clone()
		{
			return new global::Org.BouncyCastle.Pkix.PkixCertPathValidatorResult(this.TrustAnchor, this.PolicyTree, this.SubjectPublicKey);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x000387FC File Offset: 0x000369FC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("PKIXCertPathValidatorResult: [ \n");
			stringBuilder.Append("  Trust Anchor: ").Append(this.TrustAnchor).Append('\n');
			stringBuilder.Append("  Policy Tree: ").Append(this.PolicyTree).Append('\n');
			stringBuilder.Append("  Subject Public Key: ").Append(this.SubjectPublicKey).Append("\n]");
			return stringBuilder.ToString();
		}

		// Token: 0x0400085A RID: 2138
		private global::Org.BouncyCastle.Pkix.TrustAnchor trustAnchor;

		// Token: 0x0400085B RID: 2139
		private global::Org.BouncyCastle.Pkix.PkixPolicyNode policyTree;

		// Token: 0x0400085C RID: 2140
		private global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter subjectPublicKey;
	}
}
