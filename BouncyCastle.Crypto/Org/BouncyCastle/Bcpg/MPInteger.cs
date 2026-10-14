using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200057F RID: 1407
	public class MPInteger : global::Org.BouncyCastle.Bcpg.BcpgObject
	{
		// Token: 0x06003571 RID: 13681 RVA: 0x000FE26C File Offset: 0x000FC46C
		public MPInteger(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn)
		{
			if (bcpgIn == null)
			{
				throw new global::System.ArgumentNullException("bcpgIn");
			}
			byte[] bytes = new byte[((bcpgIn.ReadByte() << 8 | bcpgIn.ReadByte()) + 7) / 8];
			bcpgIn.ReadFully(bytes);
			this.val = new global::Org.BouncyCastle.Math.BigInteger(1, bytes);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x000FE2BA File Offset: 0x000FC4BA
		public MPInteger(global::Org.BouncyCastle.Math.BigInteger val)
		{
			if (val == null)
			{
				throw new global::System.ArgumentNullException("val");
			}
			if (val.SignValue < 0)
			{
				throw new global::System.ArgumentException("Values must be positive", "val");
			}
			this.val = val;
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06003573 RID: 13683 RVA: 0x000FE2F0 File Offset: 0x000FC4F0
		public global::Org.BouncyCastle.Math.BigInteger Value
		{
			get
			{
				return this.val;
			}
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x000FE2F8 File Offset: 0x000FC4F8
		public override void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut)
		{
			bcpgOut.WriteShort((short)this.val.BitLength);
			bcpgOut.Write(this.val.ToByteArrayUnsigned());
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x000FE31D File Offset: 0x000FC51D
		internal static void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut, global::Org.BouncyCastle.Math.BigInteger val)
		{
			bcpgOut.WriteShort((short)val.BitLength);
			bcpgOut.Write(val.ToByteArrayUnsigned());
		}

		// Token: 0x040017F1 RID: 6129
		private readonly global::Org.BouncyCastle.Math.BigInteger val;
	}
}
