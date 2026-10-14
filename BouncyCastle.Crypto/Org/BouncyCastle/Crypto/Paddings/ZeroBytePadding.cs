using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x0200041B RID: 1051
	public class ZeroBytePadding : global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding
	{
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000ADC49 File Offset: 0x000ABE49
		public string PaddingName
		{
			get
			{
				return "ZeroBytePadding";
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000ADC50 File Offset: 0x000ABE50
		public void Init(global::Org.BouncyCastle.Security.SecureRandom random)
		{
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000ADC54 File Offset: 0x000ABE54
		public int AddPadding(byte[] input, int inOff)
		{
			int added = input.Length - inOff;
			while (inOff < input.Length)
			{
				input[inOff] = 0;
				inOff++;
			}
			return added;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x000ADC7C File Offset: 0x000ABE7C
		public int PadCount(byte[] input)
		{
			int count = input.Length;
			while (count > 0 && input[count - 1] == 0)
			{
				count--;
			}
			return input.Length - count;
		}
	}
}
