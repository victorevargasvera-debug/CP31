using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000570 RID: 1392
	public class DsaPublicBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x06003528 RID: 13608 RVA: 0x000FDAB9 File Offset: 0x000FBCB9
		public DsaPublicBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.p = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.q = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.g = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.y = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x000FDAF1 File Offset: 0x000FBCF1
		public DsaPublicBcpgKey(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger y)
		{
			this.p = new global::Org.BouncyCastle.Bcpg.MPInteger(p);
			this.q = new global::Org.BouncyCastle.Bcpg.MPInteger(q);
			this.g = new global::Org.BouncyCastle.Bcpg.MPInteger(g);
			this.y = new global::Org.BouncyCastle.Bcpg.MPInteger(y);
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x000FDB2A File Offset: 0x000FBD2A
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x000FDB34 File Offset: 0x000FBD34
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

		// Token: 0x0600352C RID: 13612 RVA: 0x000FDB60 File Offset: 0x000FBD60
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObjects(new global::Org.BouncyCastle.Bcpg.BcpgObject[]
			{
				this.p,
				this.q,
				this.g,
				this.y
			});
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600352D RID: 13613 RVA: 0x000FDB92 File Offset: 0x000FBD92
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g.Value;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x000FDB9F File Offset: 0x000FBD9F
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.Value;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600352F RID: 13615 RVA: 0x000FDBAC File Offset: 0x000FBDAC
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q.Value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x000FDBB9 File Offset: 0x000FBDB9
		public global::Org.BouncyCastle.Math.BigInteger Y
		{
			get
			{
				return this.y.Value;
			}
		}

		// Token: 0x040017CE RID: 6094
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger p;

		// Token: 0x040017CF RID: 6095
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger q;

		// Token: 0x040017D0 RID: 6096
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger g;

		// Token: 0x040017D1 RID: 6097
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger y;
	}
}
