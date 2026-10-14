using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000577 RID: 1399
	public class ElGamalSecretBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x06003559 RID: 13657 RVA: 0x000FE024 File Offset: 0x000FC224
		public ElGamalSecretBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.x = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x000FE038 File Offset: 0x000FC238
		public ElGamalSecretBcpgKey(global::Org.BouncyCastle.Math.BigInteger x)
		{
			this.x = new global::Org.BouncyCastle.Bcpg.MPInteger(x);
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600355B RID: 13659 RVA: 0x000FE04C File Offset: 0x000FC24C
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x000FE053 File Offset: 0x000FC253
		public global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x.Value;
			}
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x000FE060 File Offset: 0x000FC260
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

		// Token: 0x0600355E RID: 13662 RVA: 0x000FE08C File Offset: 0x000FC28C
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObject(this.x);
		}

		// Token: 0x040017DC RID: 6108
		internal global::Org.BouncyCastle.Bcpg.MPInteger x;
	}
}
