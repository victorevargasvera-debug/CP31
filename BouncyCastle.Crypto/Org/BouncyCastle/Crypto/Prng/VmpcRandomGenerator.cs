using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003BC RID: 956
	public class VmpcRandomGenerator : global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator
	{
		// Token: 0x060026B5 RID: 9909 RVA: 0x000A84F8 File Offset: 0x000A66F8
		public virtual void AddSeedMaterial(byte[] seed)
		{
			for (int i = 0; i < seed.Length; i++)
			{
				this.s = this.P[(int)(this.s + this.P[(int)(this.n & byte.MaxValue)] + seed[i] & byte.MaxValue)];
				byte temp = this.P[(int)(this.n & byte.MaxValue)];
				this.P[(int)(this.n & byte.MaxValue)] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp;
				this.n = (this.n + 1 & byte.MaxValue);
			}
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000A85AD File Offset: 0x000A67AD
		public virtual void AddSeedMaterial(long seed)
		{
			this.AddSeedMaterial(global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE((ulong)seed));
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x000A85BB File Offset: 0x000A67BB
		public virtual void NextBytes(byte[] bytes)
		{
			this.NextBytes(bytes, 0, bytes.Length);
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x000A85C8 File Offset: 0x000A67C8
		public virtual void NextBytes(byte[] bytes, int start, int len)
		{
			byte[] p = this.P;
			lock (p)
			{
				int end = start + len;
				for (int i = start; i != end; i++)
				{
					this.s = this.P[(int)(this.s + this.P[(int)(this.n & byte.MaxValue)] & byte.MaxValue)];
					bytes[i] = this.P[(int)(this.P[(int)(this.P[(int)(this.s & byte.MaxValue)] & byte.MaxValue)] + 1 & byte.MaxValue)];
					byte temp = this.P[(int)(this.n & byte.MaxValue)];
					this.P[(int)(this.n & byte.MaxValue)] = this.P[(int)(this.s & byte.MaxValue)];
					this.P[(int)(this.s & byte.MaxValue)] = temp;
					this.n = (this.n + 1 & byte.MaxValue);
				}
			}
		}

		// Token: 0x04000F9E RID: 3998
		private byte n;

		// Token: 0x04000F9F RID: 3999
		private byte[] P = new byte[]
		{
			187,
			44,
			98,
			127,
			181,
			170,
			212,
			13,
			129,
			254,
			178,
			130,
			203,
			160,
			161,
			8,
			24,
			113,
			86,
			232,
			73,
			2,
			16,
			196,
			222,
			53,
			165,
			236,
			128,
			18,
			184,
			105,
			218,
			47,
			117,
			204,
			162,
			9,
			54,
			3,
			97,
			45,
			253,
			224,
			221,
			5,
			67,
			144,
			173,
			200,
			225,
			175,
			87,
			155,
			76,
			216,
			81,
			174,
			80,
			133,
			60,
			10,
			228,
			243,
			156,
			38,
			35,
			83,
			201,
			131,
			151,
			70,
			177,
			153,
			100,
			49,
			119,
			213,
			29,
			214,
			120,
			189,
			94,
			176,
			138,
			34,
			56,
			248,
			104,
			43,
			42,
			197,
			211,
			247,
			188,
			111,
			223,
			4,
			229,
			149,
			62,
			37,
			134,
			166,
			11,
			143,
			241,
			36,
			14,
			215,
			64,
			179,
			207,
			126,
			6,
			21,
			154,
			77,
			28,
			163,
			219,
			50,
			146,
			88,
			17,
			39,
			244,
			89,
			208,
			78,
			106,
			23,
			91,
			172,
			byte.MaxValue,
			7,
			192,
			101,
			121,
			252,
			199,
			205,
			118,
			66,
			93,
			231,
			58,
			52,
			122,
			48,
			40,
			15,
			115,
			1,
			249,
			209,
			210,
			25,
			233,
			145,
			185,
			90,
			237,
			65,
			109,
			180,
			195,
			158,
			191,
			99,
			250,
			31,
			51,
			96,
			71,
			137,
			240,
			150,
			26,
			95,
			147,
			61,
			55,
			75,
			217,
			168,
			193,
			27,
			246,
			57,
			139,
			183,
			12,
			32,
			206,
			136,
			110,
			182,
			116,
			142,
			141,
			22,
			41,
			242,
			135,
			245,
			235,
			112,
			227,
			251,
			85,
			159,
			198,
			68,
			74,
			69,
			125,
			226,
			107,
			92,
			108,
			102,
			169,
			140,
			238,
			132,
			19,
			167,
			30,
			157,
			220,
			103,
			72,
			186,
			46,
			230,
			164,
			171,
			124,
			148,
			0,
			33,
			239,
			234,
			190,
			202,
			114,
			79,
			82,
			152,
			63,
			194,
			20,
			123,
			59,
			84
		};

		// Token: 0x04000FA0 RID: 4000
		private byte s = 190;
	}
}
