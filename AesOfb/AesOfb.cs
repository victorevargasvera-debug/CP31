using System;

namespace AesOfb
{
	// Token: 0x02000003 RID: 3
	public class AesOfb
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002124 File Offset: 0x00000324
		public byte[] Encrypt(byte[] input, byte[] key)
		{
			short num = (short)250561593;
			short num2 = num;
			num = (short)2104247353;
			switch (num2 == num)
			{
			}
			num = (short)1906835457;
			if (num != 0)
			{
			}
			num = (short)1592197120;
			short num3 = num;
			num = (short)1978073088;
			if (num != 0)
			{
			}
			return this.a.RunCipher(new global::AesOfb.AesOfbConfiguration
			{
				Input = input,
				Key = key
			});
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021EC File Offset: 0x000003EC
		public byte[] Encrypt(byte[] input, byte[] key, int blockNumber)
		{
			short num = (short)117013100;
			short num2 = num;
			num = (short)184121964;
			switch (num2 == num)
			{
			}
			num = (short)964624385;
			if (num != 0)
			{
			}
			num = (short)724762624;
			short num3 = num;
			num = (short)504299520;
			if (num != 0)
			{
			}
			return this.a.RunCipher(new global::AesOfb.AesOfbConfiguration
			{
				Input = input,
				Key = key,
				BlockNumber = blockNumber
			});
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022BC File Offset: 0x000004BC
		public byte[] Encrypt(byte[] input, byte[] key, byte[] iv)
		{
			short num = (short)958267393;
			if (num != 0)
			{
			}
			num = (short)136145736;
			short num2 = num;
			num = (short)869231432;
			switch (num2 == num)
			{
			}
			num = (short)336658432;
			short num3 = num;
			num = (short)983236608;
			if (num != 0)
			{
			}
			return this.a.RunCipher(new global::AesOfb.AesOfbConfiguration
			{
				Input = input,
				Key = key,
				InitializationVector = iv
			});
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000238C File Offset: 0x0000058C
		public byte[] Decrypt(byte[] input, byte[] key)
		{
			short num = (short)313434689;
			short num2 = num;
			num = (short)93495873;
			switch (num2 == num)
			{
			default:
			{
				num = (short)853999616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1570242560;
			if (num != 0)
			{
			}
			num = (short)693436417;
			if (num != 0)
			{
			}
			return this.a.RunCipher(new global::AesOfb.AesOfbConfiguration
			{
				Input = input,
				Key = key
			});
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002454 File Offset: 0x00000654
		public byte[] Decrypt(byte[] input, byte[] key, int blockNumber)
		{
			short num = (short)1718180656;
			short num2 = num;
			num = (short)564288304;
			switch (num2 == num)
			{
			default:
			{
				num = (short)170000384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1473511424;
			if (num != 0)
			{
			}
			num = (short)1503264769;
			if (num != 0)
			{
			}
			return this.a.RunCipher(new global::AesOfb.AesOfbConfiguration
			{
				Input = input,
				Key = key,
				BlockNumber = blockNumber
			});
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002524 File Offset: 0x00000724
		public byte[] Decrypt(byte[] input, byte[] key, byte[] iv)
		{
			short num = (short)252656441;
			short num2 = num;
			num = (short)1701395257;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1545469952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1436418048;
			if (num != 0)
			{
			}
			num = (short)693633025;
			if (num != 0)
			{
			}
			return this.a.RunCipher(new global::AesOfb.AesOfbConfiguration
			{
				Input = input,
				Key = key,
				InitializationVector = iv
			});
		}

		// Token: 0x04000003 RID: 3
		private readonly global::AesOfb.AesOfbCipher a = new global::AesOfb.AesOfbCipher();
	}
}
