using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A2 RID: 1186
	public class IsaacEngine : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x000CDECC File Offset: 0x000CC0CC
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
			{
				throw new global::System.ArgumentException("invalid parameter passed to ISAAC Init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters), "parameters");
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter p = (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters;
			this.setKey(p.GetKey());
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000CDF10 File Offset: 0x000CC110
		public virtual byte ReturnByte(byte input)
		{
			if (this.index == 0)
			{
				this.isaac();
				this.keyStream = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.results);
			}
			byte result = this.keyStream[this.index] ^ input;
			this.index = (this.index + 1 & 1023);
			return result;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000CDF60 File Offset: 0x000CC160
		public virtual void ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, len, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, len, "output buffer too short");
			for (int i = 0; i < len; i++)
			{
				if (this.index == 0)
				{
					this.isaac();
					this.keyStream = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.results);
				}
				output[i + outOff] = (this.keyStream[this.index] ^ input[i + inOff]);
				this.index = (this.index + 1 & 1023);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000CE001 File Offset: 0x000CC201
		public virtual string AlgorithmName
		{
			get
			{
				return "ISAAC";
			}
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x000CE008 File Offset: 0x000CC208
		public virtual void Reset()
		{
			this.setKey(this.workingKey);
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x000CE018 File Offset: 0x000CC218
		private void setKey(byte[] keyBytes)
		{
			this.workingKey = keyBytes;
			if (this.engineState == null)
			{
				this.engineState = new uint[global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.stateArraySize];
			}
			if (this.results == null)
			{
				this.results = new uint[global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.stateArraySize];
			}
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.stateArraySize; i++)
			{
				this.engineState[i] = (this.results[i] = 0U);
			}
			this.a = (this.b = (this.c = 0U));
			this.index = 0;
			byte[] t = new byte[keyBytes.Length + (keyBytes.Length & 3)];
			global::System.Array.Copy(keyBytes, 0, t, 0, keyBytes.Length);
			for (int i = 0; i < t.Length; i += 4)
			{
				this.results[i >> 2] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(t, i);
			}
			uint[] abcdefgh = new uint[global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.sizeL];
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.sizeL; i++)
			{
				abcdefgh[i] = 2654435769U;
			}
			for (int i = 0; i < 4; i++)
			{
				this.mix(abcdefgh);
			}
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.stateArraySize; j += global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.sizeL)
				{
					for (int k = 0; k < global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.sizeL; k++)
					{
						abcdefgh[k] += ((i < 1) ? this.results[j + k] : this.engineState[j + k]);
					}
					this.mix(abcdefgh);
					for (int k = 0; k < global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.sizeL; k++)
					{
						this.engineState[j + k] = abcdefgh[k];
					}
				}
			}
			this.isaac();
			this.initialised = true;
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x000CE1A4 File Offset: 0x000CC3A4
		private void isaac()
		{
			uint num = this.b;
			uint num2 = this.c + 1U;
			this.c = num2;
			this.b = num + num2;
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.stateArraySize; i++)
			{
				uint x = this.engineState[i];
				switch (i & 3)
				{
				case 0:
					this.a ^= this.a << 13;
					break;
				case 1:
					this.a ^= this.a >> 6;
					break;
				case 2:
					this.a ^= this.a << 2;
					break;
				case 3:
					this.a ^= this.a >> 16;
					break;
				}
				this.a += this.engineState[i + 128 & 255];
				uint y = this.engineState[i] = this.engineState[(int)(x >> 2 & 255U)] + this.a + this.b;
				this.results[i] = (this.b = this.engineState[(int)(y >> 10 & 255U)] + x);
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x000CE2D8 File Offset: 0x000CC4D8
		private void mix(uint[] x)
		{
			x[0] ^= x[1] << 11;
			x[3] += x[0];
			x[1] += x[2];
			x[1] ^= x[2] >> 2;
			x[4] += x[1];
			x[2] += x[3];
			x[2] ^= x[3] << 8;
			x[5] += x[2];
			x[3] += x[4];
			x[3] ^= x[4] >> 16;
			x[6] += x[3];
			x[4] += x[5];
			x[4] ^= x[5] << 10;
			x[7] += x[4];
			x[5] += x[6];
			x[5] ^= x[6] >> 4;
			x[0] += x[5];
			x[6] += x[7];
			x[6] ^= x[7] << 8;
			x[1] += x[6];
			x[7] += x[0];
			x[7] ^= x[0] >> 9;
			x[2] += x[7];
			x[0] += x[1];
		}

		// Token: 0x04001356 RID: 4950
		private static readonly int sizeL = 8;

		// Token: 0x04001357 RID: 4951
		private static readonly int stateArraySize = global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.sizeL << 5;

		// Token: 0x04001358 RID: 4952
		private uint[] engineState;

		// Token: 0x04001359 RID: 4953
		private uint[] results;

		// Token: 0x0400135A RID: 4954
		private uint a;

		// Token: 0x0400135B RID: 4955
		private uint b;

		// Token: 0x0400135C RID: 4956
		private uint c;

		// Token: 0x0400135D RID: 4957
		private int index;

		// Token: 0x0400135E RID: 4958
		private byte[] keyStream = new byte[global::Org.BouncyCastle.Crypto.Engines.IsaacEngine.stateArraySize << 2];

		// Token: 0x0400135F RID: 4959
		private byte[] workingKey;

		// Token: 0x04001360 RID: 4960
		private bool initialised;
	}
}
