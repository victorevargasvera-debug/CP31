using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003CC RID: 972
	public class DHPrivateKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.DHKeyParameters
	{
		// Token: 0x0600272B RID: 10027 RVA: 0x000AA5C8 File Offset: 0x000A87C8
		public DHPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters) : base(true, parameters)
		{
			this.x = x;
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x000AA5D9 File Offset: 0x000A87D9
		public DHPrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters, global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid) : base(true, parameters, algorithmOid)
		{
			this.x = x;
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000AA5EB File Offset: 0x000A87EB
		public global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x;
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x000AA5F4 File Offset: 0x000A87F4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000AA61A File Offset: 0x000A881A
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters other)
		{
			return this.x.Equals(other.x) && base.Equals(other);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000AA638 File Offset: 0x000A8838
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x04000FE7 RID: 4071
		private readonly global::Org.BouncyCastle.Math.BigInteger x;
	}
}
