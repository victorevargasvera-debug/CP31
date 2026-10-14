using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x02000419 RID: 1049
	public class TbcPadding : global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x000ADB32 File Offset: 0x000ABD32
		public string PaddingName
		{
			get
			{
				return "TBC";
			}
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x000ADB39 File Offset: 0x000ABD39
		public virtual void Init(global::Org.BouncyCastle.Security.SecureRandom random)
		{
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000ADB3C File Offset: 0x000ABD3C
		public virtual int AddPadding(byte[] input, int inOff)
		{
			int count = input.Length - inOff;
			byte code;
			if (inOff > 0)
			{
				code = (((input[inOff - 1] & 1) == 0) ? byte.MaxValue : 0);
			}
			else
			{
				code = (((input[input.Length - 1] & 1) == 0) ? byte.MaxValue : 0);
			}
			while (inOff < input.Length)
			{
				input[inOff] = code;
				inOff++;
			}
			return count;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000ADB90 File Offset: 0x000ABD90
		public virtual int PadCount(byte[] input)
		{
			byte code = input[input.Length - 1];
			int index = input.Length - 1;
			while (index > 0 && input[index - 1] == code)
			{
				index--;
			}
			return input.Length - index;
		}
	}
}
