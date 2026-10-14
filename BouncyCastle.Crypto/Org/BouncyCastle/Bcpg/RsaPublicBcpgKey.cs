using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000588 RID: 1416
	public class RsaPublicBcpgKey : global::Org.BouncyCastle.Bcpg.BcpgObject, global::Org.BouncyCastle.Bcpg.IBcpgKey
	{
		// Token: 0x06003594 RID: 13716 RVA: 0x000FE985 File Offset: 0x000FCB85
		public RsaPublicBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			this.n = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
			this.e = new global::Org.BouncyCastle.Bcpg.MPInteger(bcpgIn);
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x000FE9A5 File Offset: 0x000FCBA5
		public RsaPublicBcpgKey(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger e)
		{
			this.n = new global::Org.BouncyCastle.Bcpg.MPInteger(n);
			this.e = new global::Org.BouncyCastle.Bcpg.MPInteger(e);
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06003596 RID: 13718 RVA: 0x000FE9C5 File Offset: 0x000FCBC5
		public global::Org.BouncyCastle.Math.BigInteger PublicExponent
		{
			get
			{
				return this.e.Value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x000FE9D2 File Offset: 0x000FCBD2
		public global::Org.BouncyCastle.Math.BigInteger Modulus
		{
			get
			{
				return this.n.Value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x000FE9DF File Offset: 0x000FCBDF
		public string Format
		{
			get
			{
				return "PGP";
			}
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x000FE9E8 File Offset: 0x000FCBE8
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

		// Token: 0x0600359A RID: 13722 RVA: 0x000FEA14 File Offset: 0x000FCC14
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteObjects(new global::Org.BouncyCastle.Bcpg.BcpgObject[]
			{
				this.n,
				this.e
			});
		}

		// Token: 0x04001830 RID: 6192
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger n;

		// Token: 0x04001831 RID: 6193
		private readonly global::Org.BouncyCastle.Bcpg.MPInteger e;
	}
}
