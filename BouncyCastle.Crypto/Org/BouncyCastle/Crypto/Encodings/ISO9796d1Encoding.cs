using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Encodings
{
	// Token: 0x020004C3 RID: 1219
	public class ISO9796d1Encoding : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x06002F31 RID: 12081 RVA: 0x000DB3B3 File Offset: 0x000D95B3
		public ISO9796d1Encoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
		{
			this.engine = cipher;
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x000DB3C2 File Offset: 0x000D95C2
		public string AlgorithmName
		{
			get
			{
				return this.engine.AlgorithmName + "/ISO9796-1Padding";
			}
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000DB3D9 File Offset: 0x000D95D9
		public global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher GetUnderlyingCipher()
		{
			return this.engine;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000DB3E4 File Offset: 0x000D95E4
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters kParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			else
			{
				kParam = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)parameters;
			}
			this.engine.Init(forEncryption, parameters);
			this.modulus = kParam.Modulus;
			this.bitSize = this.modulus.BitLength;
			this.forEncryption = forEncryption;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000DB444 File Offset: 0x000D9644
		public int GetInputBlockSize()
		{
			int baseBlockSize = this.engine.GetInputBlockSize();
			if (this.forEncryption)
			{
				return (baseBlockSize + 1) / 2;
			}
			return baseBlockSize;
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000DB46C File Offset: 0x000D966C
		public int GetOutputBlockSize()
		{
			int baseBlockSize = this.engine.GetOutputBlockSize();
			if (this.forEncryption)
			{
				return baseBlockSize;
			}
			return (baseBlockSize + 1) / 2;
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000DB494 File Offset: 0x000D9694
		public void SetPadBits(int padBits)
		{
			if (padBits > 7)
			{
				throw new global::System.ArgumentException("padBits > 7");
			}
			this.padBits = padBits;
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000DB4AC File Offset: 0x000D96AC
		public int GetPadBits()
		{
			return this.padBits;
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000DB4B4 File Offset: 0x000D96B4
		public byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			if (this.forEncryption)
			{
				return this.EncodeBlock(input, inOff, length);
			}
			return this.DecodeBlock(input, inOff, length);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000DB4D4 File Offset: 0x000D96D4
		private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
		{
			byte[] block = new byte[(this.bitSize + 7) / 8];
			int r = this.padBits + 1;
			int t = (this.bitSize + 13) / 16;
			for (int i = 0; i < t; i += inLen)
			{
				if (i > t - inLen)
				{
					global::System.Array.Copy(input, inOff + inLen - (t - i), block, block.Length - t, t - i);
				}
				else
				{
					global::System.Array.Copy(input, inOff, block, block.Length - (i + inLen), inLen);
				}
			}
			for (int j = block.Length - 2 * t; j != block.Length; j += 2)
			{
				byte val = block[block.Length - t + j / 2];
				block[j] = (byte)((int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows[(int)((uint)(val & byte.MaxValue) >> 4)] << 4 | (int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows[(int)(val & 15)]);
				block[j + 1] = val;
			}
			byte[] array = block;
			int num = block.Length - 2 * inLen;
			array[num] ^= (byte)r;
			block[block.Length - 1] = (byte)((int)block[block.Length - 1] << 4 | 6);
			int maxBit = 8 - (this.bitSize - 1) % 8;
			int offSet = 0;
			if (maxBit != 8)
			{
				byte[] array2 = block;
				int num2 = 0;
				array2[num2] &= (byte)(255 >> maxBit);
				byte[] array3 = block;
				int num3 = 0;
				array3[num3] |= (byte)(128 >> maxBit);
			}
			else
			{
				block[0] = 0;
				byte[] array4 = block;
				int num4 = 1;
				array4[num4] |= 128;
				offSet = 1;
			}
			return this.engine.ProcessBlock(block, offSet, block.Length - offSet);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000DB638 File Offset: 0x000D9838
		private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
		{
			byte[] block = this.engine.ProcessBlock(input, inOff, inLen);
			int r = 1;
			int t = (this.bitSize + 13) / 16;
			global::Org.BouncyCastle.Math.BigInteger iS = new global::Org.BouncyCastle.Math.BigInteger(1, block);
			global::Org.BouncyCastle.Math.BigInteger iR;
			if (iS.Mod(global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Sixteen).Equals(global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Six))
			{
				iR = iS;
			}
			else
			{
				iR = this.modulus.Subtract(iS);
				if (!iR.Mod(global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Sixteen).Equals(global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.Six))
				{
					throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("resulting integer iS or (modulus - iS) is not congruent to 6 mod 16");
				}
			}
			block = iR.ToByteArrayUnsigned();
			if ((block[block.Length - 1] & 15) != 6)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("invalid forcing byte in block");
			}
			block[block.Length - 1] = (byte)((ushort)(block[block.Length - 1] & byte.MaxValue) >> 4 | (int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.inverse[(block[block.Length - 2] & byte.MaxValue) >> 4] << 4);
			block[0] = (byte)((int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows[(int)((uint)(block[1] & byte.MaxValue) >> 4)] << 4 | (int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows[(int)(block[1] & 15)]);
			bool boundaryFound = false;
			int boundary = 0;
			for (int i = block.Length - 1; i >= block.Length - 2 * t; i -= 2)
			{
				int val = (int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows[(int)((uint)(block[i] & byte.MaxValue) >> 4)] << 4 | (int)global::Org.BouncyCastle.Crypto.Encodings.ISO9796d1Encoding.shadows[(int)(block[i] & 15)];
				if ((((int)block[i - 1] ^ val) & 255) != 0)
				{
					if (boundaryFound)
					{
						throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("invalid tsums in block");
					}
					boundaryFound = true;
					r = (((int)block[i - 1] ^ val) & 255);
					boundary = i - 1;
				}
			}
			block[boundary] = 0;
			byte[] nblock = new byte[(block.Length - boundary) / 2];
			for (int j = 0; j < nblock.Length; j++)
			{
				nblock[j] = block[2 * j + boundary + 1];
			}
			this.padBits = r - 1;
			return nblock;
		}

		// Token: 0x04001443 RID: 5187
		private static readonly global::Org.BouncyCastle.Math.BigInteger Sixteen = global::Org.BouncyCastle.Math.BigInteger.ValueOf(16L);

		// Token: 0x04001444 RID: 5188
		private static readonly global::Org.BouncyCastle.Math.BigInteger Six = global::Org.BouncyCastle.Math.BigInteger.ValueOf(6L);

		// Token: 0x04001445 RID: 5189
		private static readonly byte[] shadows = new byte[]
		{
			14,
			3,
			5,
			8,
			9,
			4,
			2,
			15,
			0,
			13,
			11,
			6,
			7,
			10,
			12,
			1
		};

		// Token: 0x04001446 RID: 5190
		private static readonly byte[] inverse = new byte[]
		{
			8,
			15,
			6,
			1,
			5,
			2,
			11,
			12,
			3,
			4,
			13,
			10,
			14,
			9,
			0,
			7
		};

		// Token: 0x04001447 RID: 5191
		private readonly global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;

		// Token: 0x04001448 RID: 5192
		private bool forEncryption;

		// Token: 0x04001449 RID: 5193
		private int bitSize;

		// Token: 0x0400144A RID: 5194
		private int padBits;

		// Token: 0x0400144B RID: 5195
		private global::Org.BouncyCastle.Math.BigInteger modulus;
	}
}
