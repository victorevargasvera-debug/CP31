using System;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000064 RID: 100
	public class HexTranslator : global::Org.BouncyCastle.Utilities.Encoders.ITranslator
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x000158CE File Offset: 0x00013ACE
		public int GetEncodedBlockSize()
		{
			return 2;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000158D4 File Offset: 0x00013AD4
		public int Encode(byte[] input, int inOff, int length, byte[] outBytes, int outOff)
		{
			int i = 0;
			int j = 0;
			while (i < length)
			{
				outBytes[outOff + j] = global::Org.BouncyCastle.Utilities.Encoders.HexTranslator.hexTable[input[inOff] >> 4 & 15];
				outBytes[outOff + j + 1] = global::Org.BouncyCastle.Utilities.Encoders.HexTranslator.hexTable[(int)(input[inOff] & 15)];
				inOff++;
				i++;
				j += 2;
			}
			return length * 2;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00015925 File Offset: 0x00013B25
		public int GetDecodedBlockSize()
		{
			return 1;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00015928 File Offset: 0x00013B28
		public int Decode(byte[] input, int inOff, int length, byte[] outBytes, int outOff)
		{
			int halfLength = length / 2;
			for (int i = 0; i < halfLength; i++)
			{
				byte left = input[inOff + i * 2];
				byte right = input[inOff + i * 2 + 1];
				if (left < 97)
				{
					outBytes[outOff] = (byte)(left - 48 << 4);
				}
				else
				{
					outBytes[outOff] = (byte)(left - 97 + 10 << 4);
				}
				if (right < 97)
				{
					int num = outOff;
					outBytes[num] += right - 48;
				}
				else
				{
					int num2 = outOff;
					outBytes[num2] += right - 97 + 10;
				}
				outOff++;
			}
			return halfLength;
		}

		// Token: 0x04000299 RID: 665
		private static readonly byte[] hexTable = new byte[]
		{
			48,
			49,
			50,
			51,
			52,
			53,
			54,
			55,
			56,
			57,
			97,
			98,
			99,
			100,
			101,
			102
		};
	}
}
