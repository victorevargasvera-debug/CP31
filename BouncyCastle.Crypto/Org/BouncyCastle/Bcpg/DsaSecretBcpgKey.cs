using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000571 RID: 1393
	public class DsaSecretBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x06003531 RID: 13617 RVA: 0x000FDBC6 File Offset: 0x000FBDC6
		public DsaSecretBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.x = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x000FDBDA File Offset: 0x000FBDDA
		public DsaSecretBcpgKey(global::Org.BouncyCastle.Math.BigInteger x)
		{
			this.x = new global::Org.BouncyCastle.Bcpg.MPInteger(x);
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06003533 RID: 13619 RVA: 0x000FDBEE File Offset: 0x000FBDEE
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000FDBF8 File Offset: 0x000FBDF8
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

		// Token: 0x06003535 RID: 13621 RVA: 0x000FDC24 File Offset: 0x000FBE24
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObject(this.x);
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x000FDC32 File Offset: 0x000FBE32
		public global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x.Value;
			}
		}

		// Token: 0x040017D2 RID: 6098
		internal global::Org.BouncyCastle.Bcpg.MPInteger x;
	}
}
