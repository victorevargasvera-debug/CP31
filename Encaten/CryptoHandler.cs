using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Encaten
{
	// Token: 0x02000006 RID: 6
	public static class CryptoHandler
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002640 File Offset: 0x00000840
		public static byte[] Encrypt(string pwd, byte[] data)
		{
			short num = (short)478019584;
			short num2 = num;
			num = (short)1556898412;
			short num3 = num;
			num = (short)328229484;
			switch (num3 == num)
			{
			}
			num = (short)1970143233;
			if (num != 0)
			{
			}
			num = (short)1756102656;
			if (num != 0)
			{
			}
			return global::Encaten.Rc4.Encrypt(global::Encaten.CryptoHandler.a(pwd), data);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000026F4 File Offset: 0x000008F4
		public static byte[] Decrypt(string pwd, byte[] data)
		{
			short num = (short)1265369088;
			short num2 = num;
			num = (short)1314501021;
			short num3 = num;
			num = (short)3453341;
			switch (num3 == num)
			{
			}
			num = (short)796000256;
			if (num != 0)
			{
			}
			num = (short)914620417;
			if (num != 0)
			{
			}
			return global::Encaten.Rc4.Decrypt(global::Encaten.CryptoHandler.a(pwd), data);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027A8 File Offset: 0x000009A8
		private static byte[] a(string A_0)
		{
			short num = (short)1642594304;
			short num2 = num;
			num = (short)219681567;
			short num3 = num;
			num = (short)1579422495;
			switch (num3 == num)
			{
			}
			num = (short)1164115969;
			if (num != 0)
			{
			}
			num = (short)428277760;
			if (num != 0)
			{
			}
			global::System.Security.Cryptography.HashAlgorithm hashAlgorithm = global::System.Security.Cryptography.MD5.Create();
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(A_0);
			byte[] first = hashAlgorithm.ComputeHash(bytes).Take(5).ToArray<byte>();
			byte[] second = new byte[11];
			return first.Concat(second).ToArray<byte>();
		}
	}
}
