using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x0200041A RID: 1050
	public class X923Padding : global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding
	{
		// Token: 0x060028E2 RID: 10466 RVA: 0x000ADBCA File Offset: 0x000ABDCA
		public void Init(global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.random = random;
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000ADBD3 File Offset: 0x000ABDD3
		public string PaddingName
		{
			get
			{
				return "X9.23";
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000ADBDC File Offset: 0x000ABDDC
		public int AddPadding(byte[] input, int inOff)
		{
			byte code = (byte)(input.Length - inOff);
			while (inOff < input.Length - 1)
			{
				if (this.random == null)
				{
					input[inOff] = 0;
				}
				else
				{
					input[inOff] = (byte)this.random.NextInt();
				}
				inOff++;
			}
			input[inOff] = code;
			return (int)code;
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000ADC21 File Offset: 0x000ABE21
		public int PadCount(byte[] input)
		{
			byte b = input[input.Length - 1] & byte.MaxValue;
			if ((int)b > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("pad block corrupted");
			}
			return (int)b;
		}

		// Token: 0x04001095 RID: 4245
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
