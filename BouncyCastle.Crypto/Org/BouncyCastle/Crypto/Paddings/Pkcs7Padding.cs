using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x02000418 RID: 1048
	public class Pkcs7Padding : global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding
	{
		// Token: 0x060028D8 RID: 10456 RVA: 0x000ADAA8 File Offset: 0x000ABCA8
		public void Init(global::Org.BouncyCastle.Security.SecureRandom random)
		{
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x000ADAAA File Offset: 0x000ABCAA
		public string PaddingName
		{
			get
			{
				return "PKCS7";
			}
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000ADAB4 File Offset: 0x000ABCB4
		public int AddPadding(byte[] input, int inOff)
		{
			byte code = (byte)(input.Length - inOff);
			while (inOff < input.Length)
			{
				input[inOff] = code;
				inOff++;
			}
			return (int)code;
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x000ADADC File Offset: 0x000ABCDC
		public int PadCount(byte[] input)
		{
			byte countAsByte = input[input.Length - 1];
			int count = (int)countAsByte;
			if (count < 1 || count > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("pad block corrupted");
			}
			for (int i = 2; i <= count; i++)
			{
				if (input[input.Length - i] != countAsByte)
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("pad block corrupted");
				}
			}
			return count;
		}
	}
}
