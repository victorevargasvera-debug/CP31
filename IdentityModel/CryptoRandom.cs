using System;
using System.Security.Cryptography;
using System.Text;

namespace IdentityModel
{
	// Token: 0x02000006 RID: 6
	public class CryptoRandom : global::System.Random
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002280 File Offset: 0x00000480
		public static byte[] CreateRandomKey(int length)
		{
			byte[] array = new byte[length];
			global::IdentityModel.CryptoRandom.Rng.GetBytes(array);
			return array;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022A0 File Offset: 0x000004A0
		public static string CreateRandomKeyString(int length)
		{
			byte[] array = new byte[length];
			global::IdentityModel.CryptoRandom.Rng.GetBytes(array);
			return global::System.Convert.ToBase64String(array);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022C8 File Offset: 0x000004C8
		public static string CreateUniqueId(int length = 32)
		{
			byte[] array = new byte[length];
			global::IdentityModel.CryptoRandom.Rng.GetBytes(array);
			return global::IdentityModel.CryptoRandom.ByteArrayToString(array);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022F0 File Offset: 0x000004F0
		private static string ByteArrayToString(byte[] ba)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002334 File Offset: 0x00000534
		public CryptoRandom()
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002348 File Offset: 0x00000548
		public CryptoRandom(int ignoredSeed)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000235C File Offset: 0x0000055C
		public override int Next()
		{
			global::IdentityModel.CryptoRandom.Rng.GetBytes(this._uint32Buffer);
			return global::System.BitConverter.ToInt32(this._uint32Buffer, 0) & int.MaxValue;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002380 File Offset: 0x00000580
		public override int Next(int maxValue)
		{
			if (maxValue < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("maxValue");
			}
			return this.Next(0, maxValue);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000239C File Offset: 0x0000059C
		public override int Next(int minValue, int maxValue)
		{
			if (minValue > maxValue)
			{
				throw new global::System.ArgumentOutOfRangeException("minValue");
			}
			if (minValue == maxValue)
			{
				return minValue;
			}
			long num = (long)(maxValue - minValue);
			uint num2;
			long num3;
			long num4;
			do
			{
				global::IdentityModel.CryptoRandom.Rng.GetBytes(this._uint32Buffer);
				num2 = global::System.BitConverter.ToUInt32(this._uint32Buffer, 0);
				num3 = 4294967296L;
				num4 = num3 % num;
			}
			while ((ulong)num2 >= (ulong)(num3 - num4));
			return (int)((long)minValue + (long)((ulong)num2 % (ulong)num));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002400 File Offset: 0x00000600
		public override double NextDouble()
		{
			global::IdentityModel.CryptoRandom.Rng.GetBytes(this._uint32Buffer);
			return global::System.BitConverter.ToUInt32(this._uint32Buffer, 0) / 4294967296.0;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000242C File Offset: 0x0000062C
		public override void NextBytes(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			global::IdentityModel.CryptoRandom.Rng.GetBytes(buffer);
		}

		// Token: 0x04000002 RID: 2
		private static readonly global::System.Security.Cryptography.RandomNumberGenerator Rng = global::System.Security.Cryptography.RandomNumberGenerator.Create();

		// Token: 0x04000003 RID: 3
		private readonly byte[] _uint32Buffer = new byte[4];
	}
}
