using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003AC RID: 940
	public class RandomDsaKCalculator : global::Org.BouncyCastle.Crypto.Signers.IDsaKCalculator
	{
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06002649 RID: 9801 RVA: 0x000A6E43 File Offset: 0x000A5043
		public virtual bool IsDeterministic
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000A6E46 File Offset: 0x000A5046
		public virtual void Init(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.q = n;
			this.random = random;
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000A6E56 File Offset: 0x000A5056
		public virtual void Init(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger d, byte[] message)
		{
			throw new global::System.InvalidOperationException("Operation not supported");
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000A6E64 File Offset: 0x000A5064
		public virtual global::Org.BouncyCastle.Math.BigInteger NextK()
		{
			int qBitLength = this.q.BitLength;
			global::Org.BouncyCastle.Math.BigInteger i;
			do
			{
				i = new global::Org.BouncyCastle.Math.BigInteger(qBitLength, this.random);
			}
			while (i.SignValue < 1 || i.CompareTo(this.q) >= 0);
			return i;
		}

		// Token: 0x04000F68 RID: 3944
		private global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04000F69 RID: 3945
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
