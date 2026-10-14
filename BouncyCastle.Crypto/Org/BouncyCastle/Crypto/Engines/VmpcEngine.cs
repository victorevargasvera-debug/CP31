using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004BF RID: 1215
	public class VmpcEngine : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000DAA3F File Offset: 0x000D8C3F
		public virtual string AlgorithmName
		{
			get
			{
				return "VMPC";
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000DAA48 File Offset: 0x000D8C48
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV))
			{
				throw new global::System.ArgumentException("VMPC Init parameters must include an IV");
			}
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV ivParams = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV)parameters;
			if (!(ivParams.Parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("VMPC Init parameters must include a key");
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)ivParams.Parameters;
			this.workingIV = ivParams.GetIV();
			if (this.workingIV == null || this.workingIV.Length < 1 || this.workingIV.Length > 768)
			{
				throw new global::System.ArgumentException("VMPC requires 1 to 768 bytes of IV");
			}
			this.workingKey = key.GetKey();
			this.InitKey(this.workingKey, this.workingIV);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000DAAEC File Offset: 0x000D8CEC
		protected virtual void InitKey(byte[] keyBytes, byte[] ivBytes)
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

		// Token: 0x06002F1C RID: 12060 RVA: 0x000DAC40 File Offset: 0x000D8E40
		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, len, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, len, "output buffer too short");
			for (int i = 0; i < len; i++)
			{
				this.s = this.P[(int)(this.s + this.P[(int)(this.n & byte.MaxValue)] & byte.MaxValue)];
				byte z = this.P[(int)(this.P[(int)(this.P[(int)(this.s & byte.MaxValue)] & byte.MaxValue)] + 1 & byte.MaxValue)];
				byte temp = this.P[(int)(this.n & byte.MaxValue)];
				this.P[(int)(this.n & byte.MaxValue)] = this.P[(int)(this.s & byte.MaxValue)];
				this.P[(int)(this.s & byte.MaxValue)] = temp;
				this.n = (this.n + 1 & byte.MaxValue);
				output[i + outOff] = (input[i + inOff] ^ z);
			}
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000DAD4A File Offset: 0x000D8F4A
		public virtual void Reset()
		{
			this.InitKey(this.workingKey, this.workingIV);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000DAD60 File Offset: 0x000D8F60
		public virtual byte ReturnByte(byte input)
		{
			this.s = this.P[(int)(this.s + this.P[(int)(this.n & byte.MaxValue)] & byte.MaxValue)];
			byte z = this.P[(int)(this.P[(int)(this.P[(int)(this.s & byte.MaxValue)] & byte.MaxValue)] + 1 & byte.MaxValue)];
			byte temp = this.P[(int)(this.n & byte.MaxValue)];
			this.P[(int)(this.n & byte.MaxValue)] = this.P[(int)(this.s & byte.MaxValue)];
			this.P[(int)(this.s & byte.MaxValue)] = temp;
			this.n = (this.n + 1 & byte.MaxValue);
			return input ^ z;
		}

		// Token: 0x04001436 RID: 5174
		protected byte n;

		// Token: 0x04001437 RID: 5175
		protected byte[] P;

		// Token: 0x04001438 RID: 5176
		protected byte s;

		// Token: 0x04001439 RID: 5177
		protected byte[] workingIV;

		// Token: 0x0400143A RID: 5178
		protected byte[] workingKey;
	}
}
