using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x02000415 RID: 1045
	public class ISO10126d2Padding : global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding
	{
		// Token: 0x060028C6 RID: 10438 RVA: 0x000AD64B File Offset: 0x000AB84B
		public void Init(global::Org.BouncyCastle.Security.SecureRandom random)
		{
			this.random = ((random != null) ? random : new global::Org.BouncyCastle.Security.SecureRandom());
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x000AD65E File Offset: 0x000AB85E
		public string PaddingName
		{
			get
			{
				return "ISO10126-2";
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x000AD668 File Offset: 0x000AB868
		public int AddPadding(byte[] input, int inOff)
		{
			byte code = (byte)(input.Length - inOff);
			while (inOff < input.Length - 1)
			{
				input[inOff] = (byte)this.random.NextInt();
				inOff++;
			}
			input[inOff] = code;
			return (int)code;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x000AD69F File Offset: 0x000AB89F
		public int PadCount(byte[] input)
		{
			byte b = input[input.Length - 1] & byte.MaxValue;
			if ((int)b > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("pad block corrupted");
			}
			return (int)b;
		}

		// Token: 0x04001093 RID: 4243
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
