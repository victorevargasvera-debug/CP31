using System;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;

namespace Motorola.Common.Communication.TLS.OpenSslCompatibility
{
	// Token: 0x0200002A RID: 42
	internal class TlsBlockCipher : global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000CBD4 File Offset: 0x0000ADD4
		public TlsBlockCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.IBlockCipher clientWriteCipher, global::Org.BouncyCastle.Crypto.IBlockCipher serverWriteCipher, global::Org.BouncyCastle.Crypto.IDigest clientWriteDigest, global::Org.BouncyCastle.Crypto.IDigest serverWriteDigest, int cipherKeySize) : base(context, clientWriteCipher, serverWriteCipher, clientWriteDigest, serverWriteDigest, cipherKeySize)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		public bool SuppressAddingExtraPadBlocks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1047992961;
				short num2 = num;
				num = (short)1265375873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1930690560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799815169;
				if (num != 0)
				{
				}
				num = (short)1906376704;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1738906898;
				short num2 = num;
				num = (short)1457102098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)65536000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1348206593;
				if (num != 0)
				{
				}
				num = (short)327352320;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000CD54 File Offset: 0x0000AF54
		protected override int ChooseExtraPadBlocks(global::Org.BouncyCastle.Security.SecureRandom r, int max)
		{
			if (!this.SuppressAddingExtraPadBlocks)
			{
				short num = (short)578103678;
				short num2 = num;
				num = (short)766257534;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1463091201;
					if (num != 0)
					{
					}
					num = (short)1843003392;
					short num3 = num;
					num = (short)684457984;
					if (num != 0)
					{
					}
					break;
				}
				}
				return base.ChooseExtraPadBlocks(r, max);
			}
			return 0;
		}

		// Token: 0x0400005B RID: 91
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;
	}
}
