using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D3 RID: 979
	public class DsaPrivateKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters
	{
		// Token: 0x06002756 RID: 10070 RVA: 0x000AAB1E File Offset: 0x000A8D1E
		public DsaPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters) : base(true, parameters)
		{
			if (x == null)
			{
				throw new global::System.ArgumentNullException("x");
			}
			this.x = x;
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x000AAB3D File Offset: 0x000A8D3D
		public global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x;
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x000AAB48 File Offset: 0x000A8D48
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000AAB6E File Offset: 0x000A8D6E
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters other)
		{
			return this.x.Equals(other.x) && base.Equals(other);
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x000AAB8C File Offset: 0x000A8D8C
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x04000FF8 RID: 4088
		private readonly global::Org.BouncyCastle.Math.BigInteger x;
	}
}
