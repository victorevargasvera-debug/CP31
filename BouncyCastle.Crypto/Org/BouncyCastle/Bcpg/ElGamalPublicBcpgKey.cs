using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000576 RID: 1398
	public class ElGamalPublicBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x06003551 RID: 13649 RVA: 0x000FDF47 File Offset: 0x000FC147
		public ElGamalPublicBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.p = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.g = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.y = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x000FDF73 File Offset: 0x000FC173
		public ElGamalPublicBcpgKey(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger y)
		{
			this.p = new global::Org.BouncyCastle.Bcpg.MPInteger(p);
			this.g = new global::Org.BouncyCastle.Bcpg.MPInteger(g);
			this.y = new global::Org.BouncyCastle.Bcpg.MPInteger(y);
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06003553 RID: 13651 RVA: 0x000FDF9F File Offset: 0x000FC19F
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x000FDFA8 File Offset: 0x000FC1A8
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

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06003555 RID: 13653 RVA: 0x000FDFD4 File Offset: 0x000FC1D4
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.Value;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x000FDFE1 File Offset: 0x000FC1E1
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g.Value;
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x000FDFEE File Offset: 0x000FC1EE
		public global::Org.BouncyCastle.Math.BigInteger Y
		{
			get
			{
				return this.y.Value;
			}
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x000FDFFB File Offset: 0x000FC1FB
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObjects(new global::Org.BouncyCastle.Bcpg.BcpgObject[]
			{
				this.p,
				this.g,
				this.y
			});
		}

		// Token: 0x040017D9 RID: 6105
		internal global::Org.BouncyCastle.Bcpg.MPInteger p;

		// Token: 0x040017DA RID: 6106
		internal global::Org.BouncyCastle.Bcpg.MPInteger g;

		// Token: 0x040017DB RID: 6107
		internal global::Org.BouncyCastle.Bcpg.MPInteger y;
	}
}
