using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003DB RID: 987
	public class ECPrivateKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters
	{
		// Token: 0x06002794 RID: 10132 RVA: 0x000AB314 File Offset: 0x000A9514
		public ECPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger d, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters) : this("EC", d, parameters)
		{
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000AB323 File Offset: 0x000A9523
		[global::System.Obsolete("Use version with explicit 'algorithm' parameter")]
		public ECPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger d, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base("ECGOST3410", true, publicKeyParamSet)
		{
			this.d = base.Parameters.ValidatePrivateScalar(d);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000AB344 File Offset: 0x000A9544
		public ECPrivateKeyParameters(string algorithm, global::Org.BouncyCastle.Math.BigInteger d, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters) : base(algorithm, true, parameters)
		{
			this.d = base.Parameters.ValidatePrivateScalar(d);
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x000AB361 File Offset: 0x000A9561
		public ECPrivateKeyParameters(string algorithm, global::Org.BouncyCastle.Math.BigInteger d, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base(algorithm, true, publicKeyParamSet)
		{
			this.d = base.Parameters.ValidatePrivateScalar(d);
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x000AB37E File Offset: 0x000A957E
		public global::Org.BouncyCastle.Math.BigInteger D
		{
			get
			{
				return this.d;
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x000AB388 File Offset: 0x000A9588
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x000AB3AE File Offset: 0x000A95AE
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters other)
		{
			return this.d.Equals(other.d) && base.Equals(other);
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x000AB3CC File Offset: 0x000A95CC
		public override int GetHashCode()
		{
			return this.d.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x0400100D RID: 4109
		private readonly global::Org.BouncyCastle.Math.BigInteger d;
	}
}
