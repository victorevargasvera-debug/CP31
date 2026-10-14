using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Macs
{
	// Token: 0x02000459 RID: 1113
	public class VmpcMac : global::Org.BouncyCastle.Crypto.IMac
	{
		// Token: 0x06002B29 RID: 11049 RVA: 0x000B9498 File Offset: 0x000B7698
		public virtual int DoFinal(byte[] output, int outOff)
		{
			for (int r = 1; r < 25; r++)
			{
				this.s = this.P[(int)(this.s + this.P[(int)(this.n & byte.MaxValue)] & byte.MaxValue)];
				this.x4 = this.P[(int)(this.x4 + this.x3) + r & 255];
				this.x3 = this.P[(int)(this.x3 + this.x2) + r & 255];
				this.x2 = this.P[(int)(this.x2 + this.x1) + r & 255];
				this.x1 = this.P[(int)(this.x1 + this.s) + r & 255];
				this.T[(int)(this.g & 31)] = (this.T[(int)(this.g & 31)] ^ this.x1);
				this.T[(int)(this.g + 1 & 31)] = (this.T[(int)(this.g + 1 & 31)] ^ this.x2);
				this.T[(int)(this.g + 2 & 31)] = (this.T[(int)(this.g + 2 & 31)] ^ this.x3);
				this.T[(int)(this.g + 3 & 31)] = (this.T[(int)(this.g + 3 & 31)] ^ this.x4);
				this.g = (this.g + 4 & 31);
				byte temp = this.P[(int)(this.n & byte.MaxValue)];
				this.P[(int)(this.n & byte.MaxValue)] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp;
				this.n = (this.n + 1 & byte.MaxValue);
			}
			for (int i = 0; i < 768; i++)
			{
				this.s = this.P[(int)(this.s + this.P[i & 255] + this.T[i & 31] & byte.MaxValue)];
				byte temp2 = this.P[i & 255];
				this.P[i & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp2;
			}
			byte[] M = new byte[20];
			for (int j = 0; j < 20; j++)
			{
				this.s = this.P[(int)(this.s + this.P[j & 255] & byte.MaxValue)];
				M[j] = this.P[(int)(this.P[(int)(this.P[(int)(this.s & byte.MaxValue)] & byte.MaxValue)] + 1 & byte.MaxValue)];
				byte temp3 = this.P[j & 255];
				this.P[j & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp3;
			}
			global::System.Array.Copy(M, 0, output, outOff, M.Length);
			this.Reset();
			return M.Length;
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06002B2A RID: 11050 RVA: 0x000B97F3 File Offset: 0x000B79F3
		public virtual string AlgorithmName
		{
			get
			{
				return "VMPC-MAC";
			}
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x000B97FA File Offset: 0x000B79FA
		public virtual int GetMacSize()
		{
			return 20;
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x000B9800 File Offset: 0x000B7A00
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
			{
				throw new global::System.ArgumentException("VMPC-MAC Init parameters must include an IV", "parameters");
			}
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV ivParams = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)ivParams.Parameters;
			if (!(ivParams.Parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("VMPC-MAC Init parameters must include a key", "parameters");
			}
			this.workingIV = ivParams.GetIV();
			if (this.workingIV == null || this.workingIV.Length < 1 || this.workingIV.Length > 768)
			{
				throw new global::System.ArgumentException("VMPC-MAC requires 1 to 768 bytes of IV", "parameters");
			}
			this.workingKey = key.GetKey();
			this.Reset();
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000B98A8 File Offset: 0x000B7AA8
		private void initKey(byte[] keyBytes, byte[] ivBytes)
		{
			this.s = 0;
			this.P = new byte[256];
			for (int i = 0; i < 256; i++)
			{
				this.P[i] = (byte)i;
			}
			for (int j = 0; j < 768; j++)
			{
				this.s = this.P[(int)(this.s + this.P[j & 255] + keyBytes[j % keyBytes.Length] & byte.MaxValue)];
				byte temp = this.P[j & 255];
				this.P[j & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp;
			}
			for (int k = 0; k < 768; k++)
			{
				this.s = this.P[(int)(this.s + this.P[k & 255] + ivBytes[k % ivBytes.Length] & byte.MaxValue)];
				byte temp2 = this.P[k & 255];
				this.P[k & 255] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp2;
			}
			this.n = 0;
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x000B99FC File Offset: 0x000B7BFC
		public virtual void Reset()
		{
			this.initKey(this.workingKey, this.workingIV);
			this.g = (this.x1 = (this.x2 = (this.x3 = (this.x4 = (this.n = 0)))));
			this.T = new byte[32];
			for (int i = 0; i < 32; i++)
			{
				this.T[i] = 0;
			}
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x000B9A74 File Offset: 0x000B7C74
		public virtual void Update(byte input)
		{
			this.s = this.P[(int)(this.s + this.P[(int)(this.n & byte.MaxValue)] & byte.MaxValue)];
			byte c = input ^ this.P[(int)(this.P[(int)(this.P[(int)(this.s & byte.MaxValue)] & byte.MaxValue)] + 1 & byte.MaxValue)];
			this.x4 = this.P[(int)(this.x4 + this.x3 & byte.MaxValue)];
			this.x3 = this.P[(int)(this.x3 + this.x2 & byte.MaxValue)];
			this.x2 = this.P[(int)(this.x2 + this.x1 & byte.MaxValue)];
			this.x1 = this.P[(int)(this.x1 + this.s + c & byte.MaxValue)];
			this.T[(int)(this.g & 31)] = (this.T[(int)(this.g & 31)] ^ this.x1);
			this.T[(int)(this.g + 1 & 31)] = (this.T[(int)(this.g + 1 & 31)] ^ this.x2);
			this.T[(int)(this.g + 2 & 31)] = (this.T[(int)(this.g + 2 & 31)] ^ this.x3);
			this.T[(int)(this.g + 3 & 31)] = (this.T[(int)(this.g + 3 & 31)] ^ this.x4);
			this.g = (this.g + 4 & 31);
			byte temp = this.P[(int)(this.n & byte.MaxValue)];
			this.P[(int)(this.n & byte.MaxValue)] = this.P[(int)(this.s & byte.MaxValue)];
			this.P[(int)(this.s & byte.MaxValue)] = temp;
			this.n = (this.n + 1 & byte.MaxValue);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x000B9C84 File Offset: 0x000B7E84
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
			if (inOff + len > input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("input buffer too short");
			}
			for (int i = 0; i < len; i++)
			{
				this.Update(input[inOff + i]);
			}
		}

		// Token: 0x040011E2 RID: 4578
		private byte g;

		// Token: 0x040011E3 RID: 4579
		private byte n;

		// Token: 0x040011E4 RID: 4580
		private byte[] P;

		// Token: 0x040011E5 RID: 4581
		private byte s;

		// Token: 0x040011E6 RID: 4582
		private byte[] T;

		// Token: 0x040011E7 RID: 4583
		private byte[] workingIV;

		// Token: 0x040011E8 RID: 4584
		private byte[] workingKey;

		// Token: 0x040011E9 RID: 4585
		private byte x1;

		// Token: 0x040011EA RID: 4586
		private byte x2;

		// Token: 0x040011EB RID: 4587
		private byte x3;

		// Token: 0x040011EC RID: 4588
		private byte x4;
	}
}
