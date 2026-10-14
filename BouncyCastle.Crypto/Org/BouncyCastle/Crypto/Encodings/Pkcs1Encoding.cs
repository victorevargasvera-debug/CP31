using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Encodings
{
	// Token: 0x020004C5 RID: 1221
	public class Pkcs1Encoding : global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher
	{
		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002F4B RID: 12107 RVA: 0x000DBDEB File Offset: 0x000D9FEB
		// (set) Token: 0x06002F4C RID: 12108 RVA: 0x000DBDF4 File Offset: 0x000D9FF4
		public static bool StrictLengthEnabled
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled[0];
			}
			set
			{
				global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled[0] = value;
			}
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000DBE00 File Offset: 0x000DA000
		static Pkcs1Encoding()
		{
			string strictProperty = global::Org.BouncyCastle.Utilities.Platform.GetEnvironmentVariable("Org.BouncyCastle.Pkcs1.Strict");
			global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.strictLengthEnabled = new bool[]
			{
				strictProperty == null || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase("true", strictProperty)
			};
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000DBE37 File Offset: 0x000DA037
		public Pkcs1Encoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher)
		{
			this.engine = cipher;
			this.useStrictLength = global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabled;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x000DBE58 File Offset: 0x000DA058
		public Pkcs1Encoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, int pLen)
		{
			this.engine = cipher;
			this.useStrictLength = global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabled;
			this.pLen = pLen;
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000DBE80 File Offset: 0x000DA080
		public Pkcs1Encoding(global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, byte[] fallback)
		{
			this.engine = cipher;
			this.useStrictLength = global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.StrictLengthEnabled;
			this.fallback = fallback;
			this.pLen = fallback.Length;
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x000DBEB1 File Offset: 0x000DA0B1
		public global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher GetUnderlyingCipher()
		{
			return this.engine;
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002F52 RID: 12114 RVA: 0x000DBEB9 File Offset: 0x000DA0B9
		public string AlgorithmName
		{
			get
			{
				return this.engine.AlgorithmName + "/PKCS1Padding";
			}
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x000DBED0 File Offset: 0x000DA0D0
		public void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter kParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				this.random = rParam.Random;
				kParam = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)rParam.Parameters;
			}
			else
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
				kParam = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)parameters;
			}
			this.engine.Init(forEncryption, parameters);
			this.forPrivateKey = kParam.IsPrivate;
			this.forEncryption = forEncryption;
			this.blockBuffer = new byte[this.engine.GetOutputBlockSize()];
			if (this.pLen > 0 && this.fallback == null && this.random == null)
			{
				throw new global::System.ArgumentException("encoder requires random");
			}
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x000DBF74 File Offset: 0x000DA174
		public int GetInputBlockSize()
		{
			int baseBlockSize = this.engine.GetInputBlockSize();
			if (!this.forEncryption)
			{
				return baseBlockSize;
			}
			return baseBlockSize - 10;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x000DBF9C File Offset: 0x000DA19C
		public int GetOutputBlockSize()
		{
			int baseBlockSize = this.engine.GetOutputBlockSize();
			if (!this.forEncryption)
			{
				return baseBlockSize - 10;
			}
			return baseBlockSize;
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x000DBFC3 File Offset: 0x000DA1C3
		public byte[] ProcessBlock(byte[] input, int inOff, int length)
		{
			if (!this.forEncryption)
			{
				return this.DecodeBlock(input, inOff, length);
			}
			return this.EncodeBlock(input, inOff, length);
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000DBFE0 File Offset: 0x000DA1E0
		private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
		{
			if (inLen > this.GetInputBlockSize())
			{
				throw new global::System.ArgumentException("input data too large", "inLen");
			}
			byte[] block = new byte[this.engine.GetInputBlockSize()];
			if (this.forPrivateKey)
			{
				block[0] = 1;
				for (int i = 1; i != block.Length - inLen - 1; i++)
				{
					block[i] = byte.MaxValue;
				}
			}
			else
			{
				this.random.NextBytes(block);
				block[0] = 2;
				for (int j = 1; j != block.Length - inLen - 1; j++)
				{
					while (block[j] == 0)
					{
						block[j] = (byte)this.random.NextInt();
					}
				}
			}
			block[block.Length - inLen - 1] = 0;
			global::System.Array.Copy(input, inOff, block, block.Length - inLen, inLen);
			return this.engine.ProcessBlock(block, 0, block.Length);
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x000DC0A0 File Offset: 0x000DA2A0
		private static int CheckPkcs1Encoding(byte[] encoded, int pLen)
		{
			int correct = 0;
			correct |= (int)(encoded[0] ^ 2);
			int plen = encoded.Length - (pLen + 1);
			for (int i = 1; i < plen; i++)
			{
				int tmp = (int)encoded[i];
				tmp |= tmp >> 1;
				tmp |= tmp >> 2;
				tmp |= tmp >> 4;
				correct |= (tmp & 1) - 1;
			}
			correct |= (int)encoded[encoded.Length - (pLen + 1)];
			correct |= correct >> 1;
			correct |= correct >> 2;
			correct |= correct >> 4;
			return ~((correct & 1) - 1);
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000DC110 File Offset: 0x000DA310
		private byte[] DecodeBlockOrRandom(byte[] input, int inOff, int inLen)
		{
			if (!this.forPrivateKey)
			{
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("sorry, this method is only for decryption, not for signing");
			}
			byte[] block = this.engine.ProcessBlock(input, inOff, inLen);
			byte[] random;
			if (this.fallback == null)
			{
				random = new byte[this.pLen];
				this.random.NextBytes(random);
			}
			else
			{
				random = this.fallback;
			}
			byte[] data = (this.useStrictLength & block.Length != this.engine.GetOutputBlockSize()) ? this.blockBuffer : block;
			int correct = global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding.CheckPkcs1Encoding(data, this.pLen);
			byte[] result = new byte[this.pLen];
			for (int i = 0; i < this.pLen; i++)
			{
				result[i] = (byte)(((int)data[i + (data.Length - this.pLen)] & ~correct) | ((int)random[i] & correct));
			}
			global::Org.BouncyCastle.Utilities.Arrays.Fill(data, 0);
			return result;
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x000DC1E8 File Offset: 0x000DA3E8
		private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
		{
			if (this.pLen != -1)
			{
				return this.DecodeBlockOrRandom(input, inOff, inLen);
			}
			byte[] block = this.engine.ProcessBlock(input, inOff, inLen);
			bool flag = this.useStrictLength & block.Length != this.engine.GetOutputBlockSize();
			byte[] data;
			if (block.Length < this.GetOutputBlockSize())
			{
				data = this.blockBuffer;
			}
			else
			{
				data = block;
			}
			byte expectedType = this.forPrivateKey ? 2 : 1;
			byte type = data[0];
			bool flag2 = type != expectedType;
			int start = this.FindStart(type, data);
			start++;
			if (flag2 | start < 10)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(data, 0);
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("block incorrect");
			}
			if (flag)
			{
				global::Org.BouncyCastle.Utilities.Arrays.Fill(data, 0);
				throw new global::Org.BouncyCastle.Crypto.InvalidCipherTextException("block incorrect size");
			}
			byte[] result = new byte[data.Length - start];
			global::System.Array.Copy(data, start, result, 0, result.Length);
			return result;
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000DC2C0 File Offset: 0x000DA4C0
		private int FindStart(byte type, byte[] block)
		{
			int start = -1;
			bool padErr = false;
			for (int i = 1; i != block.Length; i++)
			{
				byte pad = block[i];
				if (pad == 0 & start < 0)
				{
					start = i;
				}
				padErr |= (type == 1 & start < 0 & pad != byte.MaxValue);
			}
			if (!padErr)
			{
				return start;
			}
			return -1;
		}

		// Token: 0x04001451 RID: 5201
		public const string StrictLengthEnabledProperty = "Org.BouncyCastle.Pkcs1.Strict";

		// Token: 0x04001452 RID: 5202
		private const int HeaderLength = 10;

		// Token: 0x04001453 RID: 5203
		private static readonly bool[] strictLengthEnabled;

		// Token: 0x04001454 RID: 5204
		private global::Org.BouncyCastle.Security.SecureRandom random;

		// Token: 0x04001455 RID: 5205
		private global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher engine;

		// Token: 0x04001456 RID: 5206
		private bool forEncryption;

		// Token: 0x04001457 RID: 5207
		private bool forPrivateKey;

		// Token: 0x04001458 RID: 5208
		private bool useStrictLength;

		// Token: 0x04001459 RID: 5209
		private int pLen = -1;

		// Token: 0x0400145A RID: 5210
		private byte[] fallback;

		// Token: 0x0400145B RID: 5211
		private byte[] blockBuffer;
	}
}
