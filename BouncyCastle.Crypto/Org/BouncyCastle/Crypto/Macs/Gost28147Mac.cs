using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000452 RID: 1106
	public class Gost28147Mac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002AD5 RID: 10965 RVA: 0x000B75B8 File Offset: 0x000B57B8
		public Gost28147Mac()
		{
			this.mac = new byte[8];
			this.buf = new byte[8];
			this.bufOff = 0;
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000B760C File Offset: 0x000B580C
		private static int[] GenerateWorkingKey(byte[] userKey)
		{
			if (userKey.Length != 32)
			{
				throw new global::System.ArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
			}
			int[] key = new int[8];
			for (int i = 0; i != 8; i++)
			{
				key[i] = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.bytesToint(userKey, i * 4);
			}
			return key;
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000B764C File Offset: 0x000B584C
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.Reset();
			this.buf = new byte[8];
			this.macIV = null;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox param = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox)parameters;
				param.GetSBox().CopyTo(this.S, 0);
				if (param.Parameters != null)
				{
					this.workingKey = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.GenerateWorkingKey(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)param.Parameters).GetKey());
					return;
				}
				return;
			}
			else
			{
				if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
				{
					this.workingKey = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.GenerateWorkingKey(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
					return;
				}
				if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)
				{
					global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV p = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
					this.workingKey = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.GenerateWorkingKey(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)p.Parameters).GetKey());
					global::System.Array.Copy(p.GetIV(), 0, this.mac, 0, this.mac.Length);
					this.macIV = p.GetIV();
					return;
				}
				throw new global::System.ArgumentException("invalid parameter passed to Gost28147 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002AD8 RID: 10968 RVA: 0x000B7741 File Offset: 0x000B5941
		public string AlgorithmName
		{
			get
			{
				return "Gost28147Mac";
			}
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000B7748 File Offset: 0x000B5948
		public int GetMacSize()
		{
			return 4;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000B774C File Offset: 0x000B594C
		private int gost28147_mainStep(int n1, int key)
		{
			int cm = key + n1;
			int num = (int)this.S[cm & 15] + ((int)this.S[16 + (cm >> 4 & 15)] << 4) + ((int)this.S[32 + (cm >> 8 & 15)] << 8) + ((int)this.S[48 + (cm >> 12 & 15)] << 12) + ((int)this.S[64 + (cm >> 16 & 15)] << 16) + ((int)this.S[80 + (cm >> 20 & 15)] << 20) + ((int)this.S[96 + (cm >> 24 & 15)] << 24) + ((int)this.S[112 + (cm >> 28 & 15)] << 28);
			int omLeft = num << 11;
			int omRight = (int)((uint)num >> 21);
			return omLeft | omRight;
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000B7804 File Offset: 0x000B5A04
		private void gost28147MacFunc(int[] workingKey, byte[] input, int inOff, byte[] output, int outOff)
		{
			int N = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.bytesToint(input, inOff);
			int N2 = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.bytesToint(input, inOff + 4);
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					int num = N;
					N = (N2 ^ this.gost28147_mainStep(N, workingKey[j]));
					N2 = num;
				}
			}
			global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.intTobytes(N, output, outOff);
			global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.intTobytes(N2, output, outOff + 4);
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000B7860 File Offset: 0x000B5A60
		private static int bytesToint(byte[] input, int inOff)
		{
			return (int)((long)((long)input[inOff + 3] << 24) & (long)((ulong)-16777216)) + ((int)input[inOff + 2] << 16 & 16711680) + ((int)input[inOff + 1] << 8 & 65280) + (int)(input[inOff] & byte.MaxValue);
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000B789A File Offset: 0x000B5A9A
		private static void intTobytes(int num, byte[] output, int outOff)
		{
			output[outOff + 3] = (byte)(num >> 24);
			output[outOff + 2] = (byte)(num >> 16);
			output[outOff + 1] = (byte)(num >> 8);
			output[outOff] = (byte)num;
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000B78C0 File Offset: 0x000B5AC0
		private static byte[] CM5func(byte[] buf, int bufOff, byte[] mac)
		{
			byte[] sum = new byte[buf.Length - bufOff];
			global::System.Array.Copy(buf, bufOff, sum, 0, mac.Length);
			for (int i = 0; i != mac.Length; i++)
			{
				sum[i] ^= mac[i];
			}
			return sum;
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000B7900 File Offset: 0x000B5B00
		public void Update(byte input)
		{
			if (this.bufOff == this.buf.Length)
			{
				byte[] sumbuf = new byte[this.buf.Length];
				global::System.Array.Copy(this.buf, 0, sumbuf, 0, this.mac.Length);
				if (this.firstStep)
				{
					this.firstStep = false;
					if (this.macIV != null)
					{
						sumbuf = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(this.buf, 0, this.macIV);
					}
				}
				else
				{
					sumbuf = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(this.buf, 0, this.mac);
				}
				this.gost28147MacFunc(this.workingKey, sumbuf, 0, this.mac, 0);
				this.bufOff = 0;
			}
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000B79B8 File Offset: 0x000B5BB8
		public void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int gapLen = 8 - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.buf, this.bufOff, gapLen);
				byte[] sumbuf = new byte[this.buf.Length];
				global::System.Array.Copy(this.buf, 0, sumbuf, 0, this.mac.Length);
				if (this.firstStep)
				{
					this.firstStep = false;
					if (this.macIV != null)
					{
						sumbuf = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(this.buf, 0, this.macIV);
					}
				}
				else
				{
					sumbuf = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(this.buf, 0, this.mac);
				}
				this.gost28147MacFunc(this.workingKey, sumbuf, 0, this.mac, 0);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				while (len > 8)
				{
					sumbuf = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(input, inOff, this.mac);
					this.gost28147MacFunc(this.workingKey, sumbuf, 0, this.mac, 0);
					len -= 8;
					inOff += 8;
				}
			}
			global::System.Array.Copy(input, inOff, this.buf, this.bufOff, len);
			this.bufOff += len;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000B7AD8 File Offset: 0x000B5CD8
		public int DoFinal(byte[] output, int outOff)
		{
			while (this.bufOff < 8)
			{
				byte[] array = this.buf;
				int num = this.bufOff;
				this.bufOff = num + 1;
				array[num] = 0;
			}
			byte[] sumbuf = new byte[this.buf.Length];
			global::System.Array.Copy(this.buf, 0, sumbuf, 0, this.mac.Length);
			if (this.firstStep)
			{
				this.firstStep = false;
			}
			else
			{
				sumbuf = global::Org.BouncyCastle.Crypto.Macs.Gost28147Mac.CM5func(this.buf, 0, this.mac);
			}
			this.gost28147MacFunc(this.workingKey, sumbuf, 0, this.mac, 0);
			global::System.Array.Copy(this.mac, this.mac.Length / 2 - 4, output, outOff, 4);
			this.Reset();
			return 4;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000B7B87 File Offset: 0x000B5D87
		public void Reset()
		{
			global::System.Array.Clear(this.buf, 0, this.buf.Length);
			this.bufOff = 0;
			this.firstStep = true;
		}

		// Token: 0x0400119B RID: 4507
		private const int blockSize = 8;

		// Token: 0x0400119C RID: 4508
		private const int macSize = 4;

		// Token: 0x0400119D RID: 4509
		private int bufOff;

		// Token: 0x0400119E RID: 4510
		private byte[] buf;

		// Token: 0x0400119F RID: 4511
		private byte[] mac;

		// Token: 0x040011A0 RID: 4512
		private bool firstStep = true;

		// Token: 0x040011A1 RID: 4513
		private int[] workingKey;

		// Token: 0x040011A2 RID: 4514
		private byte[] macIV;

		// Token: 0x040011A3 RID: 4515
		private byte[] S = new byte[]
		{
			9,
			6,
			3,
			2,
			8,
			11,
			1,
			7,
			10,
			4,
			14,
			15,
			12,
			0,
			13,
			5,
			3,
			7,
			14,
			9,
			8,
			10,
			15,
			0,
			5,
			2,
			6,
			12,
			11,
			4,
			13,
			1,
			14,
			4,
			6,
			2,
			11,
			3,
			13,
			8,
			12,
			15,
			5,
			10,
			0,
			7,
			1,
			9,
			14,
			7,
			10,
			12,
			13,
			1,
			3,
			9,
			0,
			2,
			11,
			4,
			15,
			8,
			5,
			6,
			11,
			5,
			1,
			9,
			8,
			13,
			15,
			0,
			14,
			4,
			2,
			3,
			12,
			7,
			10,
			6,
			3,
			10,
			13,
			12,
			1,
			2,
			0,
			11,
			7,
			5,
			9,
			4,
			8,
			15,
			14,
			6,
			1,
			13,
			2,
			9,
			7,
			10,
			6,
			0,
			8,
			12,
			4,
			5,
			15,
			3,
			11,
			14,
			11,
			10,
			15,
			5,
			0,
			12,
			14,
			8,
			6,
			2,
			3,
			9,
			1,
			7,
			13,
			4
		};
	}
}
