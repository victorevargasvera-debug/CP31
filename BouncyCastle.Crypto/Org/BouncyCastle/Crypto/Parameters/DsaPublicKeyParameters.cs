using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D4 RID: 980
	public class DsaPublicKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters
	{
		// Token: 0x0600275B RID: 10075 RVA: 0x000AABA0 File Offset: 0x000A8DA0
		private static global::Org.BouncyCastle.Math.BigInteger Validate(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters)
		{
			if (parameters != null && (y.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) < 0 || y.CompareTo(parameters.P.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two)) > 0 || !y.ModPow(parameters.Q, parameters.P).Equals(global::Org.BouncyCastle.Math.BigInteger.One)))
			{
				throw new global::System.ArgumentException("y value does not appear to be in correct group");
			}
			return y;
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000AAC01 File Offset: 0x000A8E01
		public DsaPublicKeyParameters(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters) : base(false, parameters)
		{
			if (y == null)
			{
				throw new global::System.ArgumentNullException("y");
			}
			this.y = global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters.Validate(y, parameters);
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x000AAC26 File Offset: 0x000A8E26
		public global::Org.BouncyCastle.Math.BigInteger Y
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000AAC30 File Offset: 0x000A8E30
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000AAC56 File Offset: 0x000A8E56
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters other)
		{
			return this.y.Equals(other.y) && base.Equals(other);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000AAC74 File Offset: 0x000A8E74
		public override int GetHashCode()
		{
			return this.y.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x04000FF9 RID: 4089
		private readonly global::Org.BouncyCastle.Math.BigInteger y;
	}
}
