using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003DC RID: 988
	public class ECPublicKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters
	{
		// Token: 0x0600279C RID: 10140 RVA: 0x000AB3E0 File Offset: 0x000A95E0
		public ECPublicKeyParameters(global::Org.BouncyCastle.Math.EC.ECPoint q, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters) : this("EC", q, parameters)
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000AB3EF File Offset: 0x000A95EF
		[global::System.Obsolete("Use version with explicit 'algorithm' parameter")]
		public ECPublicKeyParameters(global::Org.BouncyCastle.Math.EC.ECPoint q, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base("ECGOST3410", false, publicKeyParamSet)
		{
			this.q = global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters.ValidatePublicPoint(base.Parameters.Curve, q);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000AB415 File Offset: 0x000A9615
		public ECPublicKeyParameters(string algorithm, global::Org.BouncyCastle.Math.EC.ECPoint q, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters) : base(algorithm, false, parameters)
		{
			this.q = global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters.ValidatePublicPoint(base.Parameters.Curve, q);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000AB437 File Offset: 0x000A9637
		public ECPublicKeyParameters(string algorithm, global::Org.BouncyCastle.Math.EC.ECPoint q, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base(algorithm, false, publicKeyParamSet)
		{
			this.q = global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters.ValidatePublicPoint(base.Parameters.Curve, q);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000AB459 File Offset: 0x000A9659
		public global::Org.BouncyCastle.Math.EC.ECPoint Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x000AB464 File Offset: 0x000A9664
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x000AB48A File Offset: 0x000A968A
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters other)
		{
			return this.q.Equals(other.q) && base.Equals(other);
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x000AB4A8 File Offset: 0x000A96A8
		public override int GetHashCode()
		{
			return this.q.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x0400100E RID: 4110
		private readonly global::Org.BouncyCastle.Math.EC.ECPoint q;
	}
}
