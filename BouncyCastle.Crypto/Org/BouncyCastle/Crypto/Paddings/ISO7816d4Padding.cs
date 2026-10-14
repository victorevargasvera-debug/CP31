using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x02000416 RID: 1046
	public class ISO7816d4Padding : global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding
	{
		// Token: 0x060028CB RID: 10443 RVA: 0x000AD6C7 File Offset: 0x000AB8C7
		public void Init(global::Org.BouncyCastle.Security.SecureRandom random)
		{
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000AD6C9 File Offset: 0x000AB8C9
		public string PaddingName
		{
			get
			{
				return "ISO7816-4";
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000AD6D0 File Offset: 0x000AB8D0
		public int AddPadding(byte[] input, int inOff)
		{
			int added = input.Length - inOff;
			input[inOff] = 128;
			for (inOff++; inOff < input.Length; inOff++)
			{
				input[inOff] = 0;
			}
			return added;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000AD704 File Offset: 0x000AB904
		public int PadCount(byte[] input)
		{
			int count = input.Length - 1;
			while (count > 0 && input[count] == 0)
			{
				count--;
			}
			if (input[count] != 128)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("pad block corrupted");
			}
			return input.Length - count;
		}
	}
}
