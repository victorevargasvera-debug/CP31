using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000575 RID: 1397
	public class ECSecretBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x0600354B RID: 13643 RVA: 0x000FDED0 File Offset: 0x000FC0D0
		public ECSecretBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.x = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
		}

		// Token: 0x0600354C RID: 13644 RVA: 0x000FDEE4 File Offset: 0x000FC0E4
		public ECSecretBcpgKey(global::Org.BouncyCastle.Math.BigInteger x)
		{
			this.x = new global::Org.BouncyCastle.Bcpg.MPInteger(x);
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600354D RID: 13645 RVA: 0x000FDEF8 File Offset: 0x000FC0F8
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x000FDF00 File Offset: 0x000FC100
		public override byte[] GetEncoded()
		{
			byte[] result;
			try
			{
				result = base.GetEncoded();
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x000FDF2C File Offset: 0x000FC12C
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObject(this.x);
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x000FDF3A File Offset: 0x000FC13A
		public virtual global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x.Value;
			}
		}

		// Token: 0x040017D8 RID: 6104
		internal global::Org.BouncyCastle.Bcpg.MPInteger x;
	}
}
