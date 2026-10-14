using System;

namespace AcpCryptoLib
{
	// Token: 0x02000009 RID: 9
	internal static class AcpCryptoDefs
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00003EE8 File Offset: 0x000020E8
		// Note: this type is marked as 'beforefieldinit'.
		static AcpCryptoDefs()
		{
			short num = (short)1430570592;
			short num2 = num;
			num = (short)1559414368;
			switch (num2 == num)
			{
			}
			num = (short)296026112;
			if (num != 0)
			{
			}
			num = (short)1960312833;
			if (num != 0)
			{
			}
			num = (short)2050162688;
			short num3 = num;
			global::AcpCryptoLib.AcpCryptoDefs.randomFactors = new int[]
			{
				47381,
				11,
				5443,
				11927,
				33289,
				3083,
				5443,
				21013,
				6373,
				997,
				36929,
				557,
				1231,
				10211,
				29587,
				8831,
				4133,
				16811,
				12713,
				21013
			};
		}

		// Token: 0x04000007 RID: 7
		internal const int ACP_AES_KEY_LENGTH = 256;

		// Token: 0x04000008 RID: 8
		internal const int ACP_AES_BLOCK_SIZE = 128;

		// Token: 0x04000009 RID: 9
		internal const int ACP_AES_IV_LENGTH = 16;

		// Token: 0x0400000A RID: 10
		internal const int ACP_MIN_SALT_LEN = 4;

		// Token: 0x0400000B RID: 11
		internal const int ACP_MAX_SALT_LEN = 128;

		// Token: 0x0400000C RID: 12
		internal const int ACP_START_ENCRYPT = 9;

		// Token: 0x0400000D RID: 13
		internal const int ACP_HDR_LEN_ADDR = 7;

		// Token: 0x0400000E RID: 14
		internal const int ACP_HDR_KEY1_ADDR = 5;

		// Token: 0x0400000F RID: 15
		internal const int ACP_HDR_KEY2_ADDR = 6;

		// Token: 0x04000010 RID: 16
		internal const int ACP_HDR_KEY3_ADDR = 8;

		// Token: 0x04000011 RID: 17
		internal const int ACP_RANDOM_GEN1 = 25173;

		// Token: 0x04000012 RID: 18
		internal const int ACP_RANDOM_GEN2 = 13849;

		// Token: 0x04000013 RID: 19
		internal const int ACP_RANDOM_MODULUS = 256;

		// Token: 0x04000014 RID: 20
		internal const int ACP_PASSWD_MODULUS = 1024;

		// Token: 0x04000015 RID: 21
		internal const int ACP_RANDOM_TIME_MODULUS = 65536;

		// Token: 0x04000016 RID: 22
		internal const int ACP_HASH_LENGTH = 20;

		// Token: 0x04000017 RID: 23
		internal static readonly int[] randomFactors;
	}
}
