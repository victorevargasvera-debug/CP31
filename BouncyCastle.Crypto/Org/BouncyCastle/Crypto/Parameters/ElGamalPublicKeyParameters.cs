using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E7 RID: 999
	public class ElGamalPublicKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters
	{
		// Token: 0x060027DF RID: 10207 RVA: 0x000ABCF4 File Offset: 0x000A9EF4
		public ElGamalPublicKeyParameters(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters) : base(false, parameters)
		{
			if (y == null)
			{
				throw new global::System.ArgumentNullException("y");
			}
			this.y = y;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x000ABD13 File Offset: 0x000A9F13
		public global::Org.BouncyCastle.Math.BigInteger Y
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000ABD1C File Offset: 0x000A9F1C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000ABD42 File Offset: 0x000A9F42
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters other)
		{
			return this.y.Equals(other.y) && base.Equals(other);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000ABD60 File Offset: 0x000A9F60
		public override int GetHashCode()
		{
			return this.y.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x04001021 RID: 4129
		private readonly global::Org.BouncyCastle.Math.BigInteger y;
	}
}
