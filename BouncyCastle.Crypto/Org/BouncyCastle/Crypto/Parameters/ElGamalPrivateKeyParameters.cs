using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E6 RID: 998
	public class ElGamalPrivateKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x000ABC72 File Offset: 0x000A9E72
		public ElGamalPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters) : base(true, parameters)
		{
			if (x == null)
			{
				throw new global::System.ArgumentNullException("x");
			}
			this.x = x;
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000ABC91 File Offset: 0x000A9E91
		public global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x;
			}
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x000ABC9C File Offset: 0x000A9E9C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x000ABCC2 File Offset: 0x000A9EC2
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters other)
		{
			return other.x.Equals(this.x) && base.Equals(other);
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x000ABCE0 File Offset: 0x000A9EE0
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x04001020 RID: 4128
		private readonly global::Org.BouncyCastle.Math.BigInteger x;
	}
}
