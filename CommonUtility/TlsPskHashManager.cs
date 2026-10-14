using System;
using System.Security.Cryptography;

namespace CommonUtility
{
	// Token: 0x02000055 RID: 85
	public static class TlsPskHashManager
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x0002ED04 File Offset: 0x0002CF04
		public static string Hash(string input, int iterations = 4000, int hashSize = 16)
		{
			short num = (short)497745920;
			short num2 = num;
			num = (short)1884684289;
			if (num != 0)
			{
			}
			num = (short)2039676435;
			short num3 = num;
			num = (short)233897491;
			switch (num3 == num)
			{
			}
			num = (short)447414272;
			if (num != 0)
			{
			}
			return global::CommonUtility.TlsPskHashManager.ConvertBytesToHexString(new global::System.Security.Cryptography.Rfc2898DeriveBytes(input, global::CommonUtility.TlsPskHashManager.a, iterations).GetBytes(hashSize));
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0002EDC8 File Offset: 0x0002CFC8
		public static string ConvertBytesToHexString(byte[] bytes)
		{
			int a_ = 17;
			short num = (short)1543766016;
			short num2 = num;
			num = (short)291887888;
			short num3 = num;
			num = (short)2058279696;
			switch (num3 == num)
			{
			}
			num = (short)1078591489;
			if (num != 0)
			{
			}
			num = (short)1585512448;
			if (num != 0)
			{
			}
			return global::System.BitConverter.ToString(bytes).Replace(global::CommonUtility.VersionUtility.b("潁", a_), string.Empty);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0002EE98 File Offset: 0x0002D098
		// Note: this type is marked as 'beforefieldinit'.
		static TlsPskHashManager()
		{
			short num = (short)1875378176;
			short num2 = num;
			num = (short)207922950;
			short num3 = num;
			num = (short)532981510;
			switch (num3 == num)
			{
			}
			num = (short)1542651905;
			if (num != 0)
			{
			}
			num = (short)693239808;
			if (num != 0)
			{
			}
			global::CommonUtility.TlsPskHashManager.a = new byte[]
			{
				89,
				70,
				82,
				52,
				37,
				36,
				98,
				94,
				48,
				33,
				35,
				46,
				67,
				53,
				117,
				126,
				95,
				45,
				95,
				99,
				110,
				103,
				55,
				72,
				78,
				126,
				75,
				46,
				40,
				86,
				97,
				51
			};
		}

		// Token: 0x04000118 RID: 280
		private static readonly byte[] a;
	}
}
