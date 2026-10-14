using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000499 RID: 1177
	public class DesEngine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002D46 RID: 11590 RVA: 0x000C9E9D File Offset: 0x000C809D
		public virtual int[] GetWorkingKey()
		{
			return this.workingKey;
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000C9EA5 File Offset: 0x000C80A5
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to DES init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
			this.workingKey = global::Org.BouncyCastle.Crypto.Engines.DesEngine.GenerateWorkingKey(forEncryption, ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000C9EDC File Offset: 0x000C80DC
		public virtual string AlgorithmName
		{
			get
			{
				return "DES";
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002D49 RID: 11593 RVA: 0x000C9EE3 File Offset: 0x000C80E3
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x000C9EE6 File Offset: 0x000C80E6
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000C9EEC File Offset: 0x000C80EC
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.workingKey == null)
			{
				throw new global::System.InvalidOperationException("DES engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 8, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 8, "output buffer too short");
			global::Org.BouncyCastle.Crypto.Engines.DesEngine.DesFunc(this.workingKey, input, inOff, output, outOff);
			return 8;
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000C9F38 File Offset: 0x000C8138
		public virtual void Reset()
		{
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000C9F3C File Offset: 0x000C813C
		protected static int[] GenerateWorkingKey(bool encrypting, byte[] key)
		{
			int[] newKey = new int[32];
			bool[] pc1m = new bool[56];
			bool[] pcr = new bool[56];
			for (int i = 0; i < 56; i++)
			{
				int j = (int)global::Org.BouncyCastle.Crypto.Engines.DesEngine.pc1[i];
				pc1m[i] = (((short)key[(int)((uint)j >> 3)] & global::Org.BouncyCastle.Crypto.Engines.DesEngine.bytebit[j & 7]) != 0);
			}
			for (int k = 0; k < 16; k++)
			{
				int l;
				if (encrypting)
				{
					l = k << 1;
				}
				else
				{
					l = 15 - k << 1;
				}
				int m = l + 1;
				newKey[l] = (newKey[m] = 0);
				for (int n = 0; n < 28; n++)
				{
					int l2 = n + (int)global::Org.BouncyCastle.Crypto.Engines.DesEngine.totrot[k];
					if (l2 < 28)
					{
						pcr[n] = pc1m[l2];
					}
					else
					{
						pcr[n] = pc1m[l2 - 28];
					}
				}
				for (int j2 = 28; j2 < 56; j2++)
				{
					int l2 = j2 + (int)global::Org.BouncyCastle.Crypto.Engines.DesEngine.totrot[k];
					if (l2 < 56)
					{
						pcr[j2] = pc1m[l2];
					}
					else
					{
						pcr[j2] = pc1m[l2 - 28];
					}
				}
				for (int j3 = 0; j3 < 24; j3++)
				{
					if (pcr[(int)global::Org.BouncyCastle.Crypto.Engines.DesEngine.pc2[j3]])
					{
						newKey[l] |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.bigbyte[j3];
					}
					if (pcr[(int)global::Org.BouncyCastle.Crypto.Engines.DesEngine.pc2[j3 + 24]])
					{
						newKey[m] |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.bigbyte[j3];
					}
				}
			}
			for (int i2 = 0; i2 != 32; i2 += 2)
			{
				int i3 = newKey[i2];
				int i4 = newKey[i2 + 1];
				newKey[i2] = ((i3 & 16515072) << 6 | (i3 & 4032) << 10 | (int)((uint)(i4 & 16515072) >> 10) | (int)((uint)(i4 & 4032) >> 6));
				newKey[i2 + 1] = ((i3 & 258048) << 12 | (i3 & 63) << 16 | (int)((uint)(i4 & 258048) >> 4) | (i4 & 63));
			}
			return newKey;
		}

		// Token: 0x06002D4E RID: 11598 RVA: 0x000CA110 File Offset: 0x000C8310
		internal static void DesFunc(int[] wKey, byte[] input, int inOff, byte[] outBytes, int outOff)
		{
			uint left = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			uint right = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff + 4);
			uint work = (left >> 4 ^ right) & 252645135U;
			right ^= work;
			left ^= work << 4;
			work = ((left >> 16 ^ right) & 65535U);
			right ^= work;
			left ^= work << 16;
			work = ((right >> 2 ^ left) & 858993459U);
			left ^= work;
			right ^= work << 2;
			work = ((right >> 8 ^ left) & 16711935U);
			left ^= work;
			right ^= work << 8;
			right = (right << 1 | right >> 31);
			work = ((left ^ right) & 2863311530U);
			left ^= work;
			right ^= work;
			left = (left << 1 | left >> 31);
			for (int round = 0; round < 8; round++)
			{
				work = (right << 28 | right >> 4);
				work ^= (uint)wKey[round * 4];
				uint fval = global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP7[(int)(work & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP5[(int)(work >> 8 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP3[(int)(work >> 16 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP1[(int)(work >> 24 & 63U)];
				work = (right ^ (uint)wKey[round * 4 + 1]);
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP8[(int)(work & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP6[(int)(work >> 8 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP4[(int)(work >> 16 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP2[(int)(work >> 24 & 63U)];
				left ^= fval;
				work = (left << 28 | left >> 4);
				work ^= (uint)wKey[round * 4 + 2];
				fval = global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP7[(int)(work & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP5[(int)(work >> 8 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP3[(int)(work >> 16 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP1[(int)(work >> 24 & 63U)];
				work = (left ^ (uint)wKey[round * 4 + 3]);
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP8[(int)(work & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP6[(int)(work >> 8 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP4[(int)(work >> 16 & 63U)];
				fval |= global::Org.BouncyCastle.Crypto.Engines.DesEngine.SP2[(int)(work >> 24 & 63U)];
				right ^= fval;
			}
			right = (right << 31 | right >> 1);
			work = ((left ^ right) & 2863311530U);
			left ^= work;
			right ^= work;
			left = (left << 31 | left >> 1);
			work = ((left >> 8 ^ right) & 16711935U);
			right ^= work;
			left ^= work << 8;
			work = ((left >> 2 ^ right) & 858993459U);
			right ^= work;
			left ^= work << 2;
			work = ((right >> 16 ^ left) & 65535U);
			left ^= work;
			right ^= work << 16;
			work = ((right >> 4 ^ left) & 252645135U);
			left ^= work;
			right ^= work << 4;
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(right, outBytes, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(left, outBytes, outOff + 4);
		}

		// Token: 0x04001301 RID: 4865
		internal const int BLOCK_SIZE = 8;

		// Token: 0x04001302 RID: 4866
		private int[] workingKey;

		// Token: 0x04001303 RID: 4867
		private static readonly short[] bytebit = new short[]
		{
			128,
			64,
			32,
			16,
			8,
			4,
			2,
			1
		};

		// Token: 0x04001304 RID: 4868
		private static readonly int[] bigbyte = new int[]
		{
			8388608,
			4194304,
			2097152,
			1048576,
			524288,
			262144,
			131072,
			65536,
			32768,
			16384,
			8192,
			4096,
			2048,
			1024,
			512,
			256,
			128,
			64,
			32,
			16,
			8,
			4,
			2,
			1
		};

		// Token: 0x04001305 RID: 4869
		private static readonly byte[] pc1 = new byte[]
		{
			56,
			48,
			40,
			32,
			24,
			16,
			8,
			0,
			57,
			49,
			41,
			33,
			25,
			17,
			9,
			1,
			58,
			50,
			42,
			34,
			26,
			18,
			10,
			2,
			59,
			51,
			43,
			35,
			62,
			54,
			46,
			38,
			30,
			22,
			14,
			6,
			61,
			53,
			45,
			37,
			29,
			21,
			13,
			5,
			60,
			52,
			44,
			36,
			28,
			20,
			12,
			4,
			27,
			19,
			11,
			3
		};

		// Token: 0x04001306 RID: 4870
		private static readonly byte[] totrot = new byte[]
		{
			1,
			2,
			4,
			6,
			8,
			10,
			12,
			14,
			15,
			17,
			19,
			21,
			23,
			25,
			27,
			28
		};

		// Token: 0x04001307 RID: 4871
		private static readonly byte[] pc2 = new byte[]
		{
			13,
			16,
			10,
			23,
			0,
			4,
			2,
			27,
			14,
			5,
			20,
			9,
			22,
			18,
			11,
			3,
			25,
			7,
			15,
			6,
			26,
			19,
			12,
			1,
			40,
			51,
			30,
			36,
			46,
			54,
			29,
			39,
			50,
			44,
			32,
			47,
			43,
			48,
			38,
			55,
			33,
			52,
			45,
			41,
			49,
			35,
			28,
			31
		};

		// Token: 0x04001308 RID: 4872
		private static readonly uint[] SP1 = new uint[]
		{
			16843776U,
			0U,
			65536U,
			16843780U,
			16842756U,
			66564U,
			4U,
			65536U,
			1024U,
			16843776U,
			16843780U,
			1024U,
			16778244U,
			16842756U,
			16777216U,
			4U,
			1028U,
			16778240U,
			16778240U,
			66560U,
			66560U,
			16842752U,
			16842752U,
			16778244U,
			65540U,
			16777220U,
			16777220U,
			65540U,
			0U,
			1028U,
			66564U,
			16777216U,
			65536U,
			16843780U,
			4U,
			16842752U,
			16843776U,
			16777216U,
			16777216U,
			1024U,
			16842756U,
			65536U,
			66560U,
			16777220U,
			1024U,
			4U,
			16778244U,
			66564U,
			16843780U,
			65540U,
			16842752U,
			16778244U,
			16777220U,
			1028U,
			66564U,
			16843776U,
			1028U,
			16778240U,
			16778240U,
			0U,
			65540U,
			66560U,
			0U,
			16842756U
		};

		// Token: 0x04001309 RID: 4873
		private static readonly uint[] SP2 = new uint[]
		{
			2148565024U,
			2147516416U,
			32768U,
			1081376U,
			1048576U,
			32U,
			2148532256U,
			2147516448U,
			2147483680U,
			2148565024U,
			2148564992U,
			2147483648U,
			2147516416U,
			1048576U,
			32U,
			2148532256U,
			1081344U,
			1048608U,
			2147516448U,
			0U,
			2147483648U,
			32768U,
			1081376U,
			2148532224U,
			1048608U,
			2147483680U,
			0U,
			1081344U,
			32800U,
			2148564992U,
			2148532224U,
			32800U,
			0U,
			1081376U,
			2148532256U,
			1048576U,
			2147516448U,
			2148532224U,
			2148564992U,
			32768U,
			2148532224U,
			2147516416U,
			32U,
			2148565024U,
			1081376U,
			32U,
			32768U,
			2147483648U,
			32800U,
			2148564992U,
			1048576U,
			2147483680U,
			1048608U,
			2147516448U,
			2147483680U,
			1048608U,
			1081344U,
			0U,
			2147516416U,
			32800U,
			2147483648U,
			2148532256U,
			2148565024U,
			1081344U
		};

		// Token: 0x0400130A RID: 4874
		private static readonly uint[] SP3 = new uint[]
		{
			520U,
			134349312U,
			0U,
			134348808U,
			134218240U,
			0U,
			131592U,
			134218240U,
			131080U,
			134217736U,
			134217736U,
			131072U,
			134349320U,
			131080U,
			134348800U,
			520U,
			134217728U,
			8U,
			134349312U,
			512U,
			131584U,
			134348800U,
			134348808U,
			131592U,
			134218248U,
			131584U,
			131072U,
			134218248U,
			8U,
			134349320U,
			512U,
			134217728U,
			134349312U,
			134217728U,
			131080U,
			520U,
			131072U,
			134349312U,
			134218240U,
			0U,
			512U,
			131080U,
			134349320U,
			134218240U,
			134217736U,
			512U,
			0U,
			134348808U,
			134218248U,
			131072U,
			134217728U,
			134349320U,
			8U,
			131592U,
			131584U,
			134217736U,
			134348800U,
			134218248U,
			520U,
			134348800U,
			131592U,
			8U,
			134348808U,
			131584U
		};

		// Token: 0x0400130B RID: 4875
		private static readonly uint[] SP4 = new uint[]
		{
			8396801U,
			8321U,
			8321U,
			128U,
			8396928U,
			8388737U,
			8388609U,
			8193U,
			0U,
			8396800U,
			8396800U,
			8396929U,
			129U,
			0U,
			8388736U,
			8388609U,
			1U,
			8192U,
			8388608U,
			8396801U,
			128U,
			8388608U,
			8193U,
			8320U,
			8388737U,
			1U,
			8320U,
			8388736U,
			8192U,
			8396928U,
			8396929U,
			129U,
			8388736U,
			8388609U,
			8396800U,
			8396929U,
			129U,
			0U,
			0U,
			8396800U,
			8320U,
			8388736U,
			8388737U,
			1U,
			8396801U,
			8321U,
			8321U,
			128U,
			8396929U,
			129U,
			1U,
			8192U,
			8388609U,
			8193U,
			8396928U,
			8388737U,
			8193U,
			8320U,
			8388608U,
			8396801U,
			128U,
			8388608U,
			8192U,
			8396928U
		};

		// Token: 0x0400130C RID: 4876
		private static readonly uint[] SP5 = new uint[]
		{
			256U,
			34078976U,
			34078720U,
			1107296512U,
			524288U,
			256U,
			1073741824U,
			34078720U,
			1074266368U,
			524288U,
			33554688U,
			1074266368U,
			1107296512U,
			1107820544U,
			524544U,
			1073741824U,
			33554432U,
			1074266112U,
			1074266112U,
			0U,
			1073742080U,
			1107820800U,
			1107820800U,
			33554688U,
			1107820544U,
			1073742080U,
			0U,
			1107296256U,
			34078976U,
			33554432U,
			1107296256U,
			524544U,
			524288U,
			1107296512U,
			256U,
			33554432U,
			1073741824U,
			34078720U,
			1107296512U,
			1074266368U,
			33554688U,
			1073741824U,
			1107820544U,
			34078976U,
			1074266368U,
			256U,
			33554432U,
			1107820544U,
			1107820800U,
			524544U,
			1107296256U,
			1107820800U,
			34078720U,
			0U,
			1074266112U,
			1107296256U,
			524544U,
			33554688U,
			1073742080U,
			524288U,
			0U,
			1074266112U,
			34078976U,
			1073742080U
		};

		// Token: 0x0400130D RID: 4877
		private static readonly uint[] SP6 = new uint[]
		{
			536870928U,
			541065216U,
			16384U,
			541081616U,
			541065216U,
			16U,
			541081616U,
			4194304U,
			536887296U,
			4210704U,
			4194304U,
			536870928U,
			4194320U,
			536887296U,
			536870912U,
			16400U,
			0U,
			4194320U,
			536887312U,
			16384U,
			4210688U,
			536887312U,
			16U,
			541065232U,
			541065232U,
			0U,
			4210704U,
			541081600U,
			16400U,
			4210688U,
			541081600U,
			536870912U,
			536887296U,
			16U,
			541065232U,
			4210688U,
			541081616U,
			4194304U,
			16400U,
			536870928U,
			4194304U,
			536887296U,
			536870912U,
			16400U,
			536870928U,
			541081616U,
			4210688U,
			541065216U,
			4210704U,
			541081600U,
			0U,
			541065232U,
			16U,
			16384U,
			541065216U,
			4210704U,
			16384U,
			4194320U,
			536887312U,
			0U,
			541081600U,
			536870912U,
			4194320U,
			536887312U
		};

		// Token: 0x0400130E RID: 4878
		private static readonly uint[] SP7 = new uint[]
		{
			2097152U,
			69206018U,
			67110914U,
			0U,
			2048U,
			67110914U,
			2099202U,
			69208064U,
			69208066U,
			2097152U,
			0U,
			67108866U,
			2U,
			67108864U,
			69206018U,
			2050U,
			67110912U,
			2099202U,
			2097154U,
			67110912U,
			67108866U,
			69206016U,
			69208064U,
			2097154U,
			69206016U,
			2048U,
			2050U,
			69208066U,
			2099200U,
			2U,
			67108864U,
			2099200U,
			67108864U,
			2099200U,
			2097152U,
			67110914U,
			67110914U,
			69206018U,
			69206018U,
			2U,
			2097154U,
			67108864U,
			67110912U,
			2097152U,
			69208064U,
			2050U,
			2099202U,
			69208064U,
			2050U,
			67108866U,
			69208066U,
			69206016U,
			2099200U,
			0U,
			2U,
			69208066U,
			0U,
			2099202U,
			69206016U,
			2048U,
			67108866U,
			67110912U,
			2048U,
			2097154U
		};

		// Token: 0x0400130F RID: 4879
		private static readonly uint[] SP8 = new uint[]
		{
			268439616U,
			4096U,
			262144U,
			268701760U,
			268435456U,
			268439616U,
			64U,
			268435456U,
			262208U,
			268697600U,
			268701760U,
			266240U,
			268701696U,
			266304U,
			4096U,
			64U,
			268697600U,
			268435520U,
			268439552U,
			4160U,
			266240U,
			262208U,
			268697664U,
			268701696U,
			4160U,
			0U,
			0U,
			268697664U,
			268435520U,
			268439552U,
			266304U,
			262144U,
			266304U,
			262144U,
			268701696U,
			4096U,
			64U,
			268697664U,
			4096U,
			266304U,
			268439552U,
			64U,
			268435520U,
			268697600U,
			268697664U,
			268435456U,
			262144U,
			268439616U,
			0U,
			268701760U,
			262208U,
			268435520U,
			268697600U,
			268439552U,
			268439616U,
			0U,
			268701760U,
			266240U,
			266240U,
			4160U,
			4160U,
			262208U,
			268435456U,
			268701696U
		};
	}
}
