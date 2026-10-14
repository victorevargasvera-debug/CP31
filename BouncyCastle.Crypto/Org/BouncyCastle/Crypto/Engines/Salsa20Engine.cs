using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004B3 RID: 1203
	public class Salsa20Engine : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x06002E73 RID: 11891 RVA: 0x000D27AC File Offset: 0x000D09AC
		internal void PackTauOrSigma(int keyLength, uint[] state, int stateOffset)
		{
			int tsOff = (keyLength - 16) / 4;
			state[stateOffset] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff];
			state[stateOffset + 1] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff + 1];
			state[stateOffset + 2] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff + 2];
			state[stateOffset + 3] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff + 3];
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000D27F4 File Offset: 0x000D09F4
		public Salsa20Engine() : this(global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.DEFAULT_ROUNDS)
		{
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000D2804 File Offset: 0x000D0A04
		public Salsa20Engine(int rounds)
		{
			if (rounds <= 0 || (rounds & 1) != 0)
			{
				throw new global::System.ArgumentException("'rounds' must be a positive, even number");
			}
			this.rounds = rounds;
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000D285C File Offset: 0x000D0A5C
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV parametersWithIV = parameters as global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV;
			if (parametersWithIV == null)
			{
				throw new global::System.ArgumentException(this.AlgorithmName + " Init requires an IV", "parameters");
			}
			byte[] iv = parametersWithIV.GetIV();
			if (iv == null || iv.Length != this.NonceSize)
			{
				throw new global::System.ArgumentException(this.AlgorithmName + " requires exactly " + this.NonceSize.ToString() + " bytes of IV");
			}
			global::Org.BouncyCastle.Crypto.ICipherParameters keyParam = parametersWithIV.Parameters;
			if (keyParam == null)
			{
				if (!this.initialised)
				{
					throw new global::System.InvalidOperationException(this.AlgorithmName + " KeyParameter can not be null for first initialisation");
				}
				this.SetKey(null, iv);
			}
			else
			{
				if (!(keyParam is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter))
				{
					throw new global::System.ArgumentException(this.AlgorithmName + " Init parameters must contain a KeyParameter (or null for re-init)");
				}
				this.SetKey(((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)keyParam).GetKey(), iv);
			}
			this.Reset();
			this.initialised = true;
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x000D293B File Offset: 0x000D0B3B
		protected virtual int NonceSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06002E78 RID: 11896 RVA: 0x000D2940 File Offset: 0x000D0B40
		public virtual string AlgorithmName
		{
			get
			{
				string name = "Salsa20";
				if (this.rounds != global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.DEFAULT_ROUNDS)
				{
					name = name + "/" + this.rounds.ToString();
				}
				return name;
			}
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000D2978 File Offset: 0x000D0B78
		public virtual byte ReturnByte(byte input)
		{
			if (this.LimitExceeded())
			{
				throw new global::Org.BouncyCastle.Crypto.MaxBytesExceededException("2^70 byte limit per IV; Change IV");
			}
			if (this.index == 0)
			{
				this.GenerateKeyStream(this.keyStream);
				this.AdvanceCounter();
			}
			byte result = this.keyStream[this.index] ^ input;
			this.index = (this.index + 1 & 63);
			return result;
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000D29D4 File Offset: 0x000D0BD4
		protected virtual void AdvanceCounter()
		{
			uint[] array = this.engineState;
			int num = 8;
			uint num2 = array[num] + 1U;
			array[num] = num2;
			if (num2 == 0U)
			{
				this.engineState[9] += 1U;
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000D2A0C File Offset: 0x000D0C0C
		public virtual void ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
		{
			if (!this.initialised)
			{
				throw new global::System.InvalidOperationException(this.AlgorithmName + " not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(inBytes, inOff, len, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(outBytes, outOff, len, "output buffer too short");
			if (this.LimitExceeded((uint)len))
			{
				throw new global::Org.BouncyCastle.Crypto.MaxBytesExceededException("2^70 byte limit per IV would be exceeded; Change IV");
			}
			for (int i = 0; i < len; i++)
			{
				if (this.index == 0)
				{
					this.GenerateKeyStream(this.keyStream);
					this.AdvanceCounter();
				}
				outBytes[i + outOff] = (this.keyStream[this.index] ^ inBytes[i + inOff]);
				this.index = (this.index + 1 & 63);
			}
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000D2AB9 File Offset: 0x000D0CB9
		public virtual void Reset()
		{
			this.index = 0;
			this.ResetLimitCounter();
			this.ResetCounter();
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000D2AD0 File Offset: 0x000D0CD0
		protected virtual void ResetCounter()
		{
			this.engineState[8] = (this.engineState[9] = 0U);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000D2AF4 File Offset: 0x000D0CF4
		protected virtual void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
			if (keyBytes != null)
			{
				if (keyBytes.Length != 16 && keyBytes.Length != 32)
				{
					throw new global::System.ArgumentException(this.AlgorithmName + " requires 128 bit or 256 bit key");
				}
				int tsOff = (keyBytes.Length - 16) / 4;
				this.engineState[0] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff];
				this.engineState[5] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff + 1];
				this.engineState[10] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff + 2];
				this.engineState[15] = global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.TAU_SIGMA[tsOff + 3];
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(keyBytes, 0, this.engineState, 1, 4);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(keyBytes, keyBytes.Length - 16, this.engineState, 11, 4);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(ivBytes, 0, this.engineState, 6, 2);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000D2BAB File Offset: 0x000D0DAB
		protected virtual void GenerateKeyStream(byte[] output)
		{
			global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.SalsaCore(this.rounds, this.engineState, this.x);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.x, output, 0);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x000D2BD4 File Offset: 0x000D0DD4
		internal static void SalsaCore(int rounds, uint[] input, uint[] x)
		{
			if (input.Length != 16)
			{
				throw new global::System.ArgumentException();
			}
			if (x.Length != 16)
			{
				throw new global::System.ArgumentException();
			}
			if (rounds % 2 != 0)
			{
				throw new global::System.ArgumentException("Number of rounds must be even");
			}
			uint x2 = input[0];
			uint x3 = input[1];
			uint x4 = input[2];
			uint x5 = input[3];
			uint x6 = input[4];
			uint x7 = input[5];
			uint x8 = input[6];
			uint x9 = input[7];
			uint x10 = input[8];
			uint x11 = input[9];
			uint x12 = input[10];
			uint x13 = input[11];
			uint x14 = input[12];
			uint x15 = input[13];
			uint x16 = input[14];
			uint x17 = input[15];
			for (int i = rounds; i > 0; i -= 2)
			{
				x6 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x2 + x14, 7);
				x10 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x6 + x2, 9);
				x14 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x10 + x6, 13);
				x2 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x14 + x10, 18);
				x11 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x7 + x3, 7);
				x15 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x11 + x7, 9);
				x3 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x15 + x11, 13);
				x7 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x3 + x15, 18);
				x16 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x12 + x8, 7);
				x4 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x16 + x12, 9);
				x8 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x4 + x16, 13);
				x12 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x8 + x4, 18);
				x5 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x17 + x13, 7);
				x9 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x5 + x17, 9);
				x13 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x9 + x5, 13);
				x17 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x13 + x9, 18);
				x3 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x2 + x5, 7);
				x4 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x3 + x2, 9);
				x5 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x4 + x3, 13);
				x2 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x5 + x4, 18);
				x8 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x7 + x6, 7);
				x9 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x8 + x7, 9);
				x6 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x9 + x8, 13);
				x7 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x6 + x9, 18);
				x13 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x12 + x11, 7);
				x10 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x13 + x12, 9);
				x11 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x10 + x13, 13);
				x12 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x11 + x10, 18);
				x14 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x17 + x16, 7);
				x15 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x14 + x17, 9);
				x16 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x15 + x14, 13);
				x17 ^= global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x16 + x15, 18);
			}
			x[0] = x2 + input[0];
			x[1] = x3 + input[1];
			x[2] = x4 + input[2];
			x[3] = x5 + input[3];
			x[4] = x6 + input[4];
			x[5] = x7 + input[5];
			x[6] = x8 + input[6];
			x[7] = x9 + input[7];
			x[8] = x10 + input[8];
			x[9] = x11 + input[9];
			x[10] = x12 + input[10];
			x[11] = x13 + input[11];
			x[12] = x14 + input[12];
			x[13] = x15 + input[13];
			x[14] = x16 + input[14];
			x[15] = x17 + input[15];
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000D2F06 File Offset: 0x000D1106
		private void ResetLimitCounter()
		{
			this.cW0 = 0U;
			this.cW1 = 0U;
			this.cW2 = 0U;
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000D2F20 File Offset: 0x000D1120
		private bool LimitExceeded()
		{
			uint num = this.cW0 + 1U;
			this.cW0 = num;
			if (num == 0U)
			{
				num = this.cW1 + 1U;
				this.cW1 = num;
				if (num == 0U)
				{
					num = this.cW2 + 1U;
					this.cW2 = num;
					return (num & 32U) > 0U;
				}
			}
			return false;
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000D2F6C File Offset: 0x000D116C
		private bool LimitExceeded(uint len)
		{
			uint old = this.cW0;
			this.cW0 += len;
			if (this.cW0 < old)
			{
				uint num = this.cW1 + 1U;
				this.cW1 = num;
				if (num == 0U)
				{
					num = this.cW2 + 1U;
					this.cW2 = num;
					return (num & 32U) > 0U;
				}
			}
			return false;
		}

		// Token: 0x040013B9 RID: 5049
		public static readonly int DEFAULT_ROUNDS = 20;

		// Token: 0x040013BA RID: 5050
		private const int StateSize = 16;

		// Token: 0x040013BB RID: 5051
		private static readonly uint[] TAU_SIGMA = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray("expand 16-byte kexpand 32-byte k"), 0, 8);

		// Token: 0x040013BC RID: 5052
		[global::System.Obsolete]
		protected static readonly byte[] sigma = global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray("expand 32-byte k");

		// Token: 0x040013BD RID: 5053
		[global::System.Obsolete]
		protected static readonly byte[] tau = global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray("expand 16-byte k");

		// Token: 0x040013BE RID: 5054
		protected int rounds;

		// Token: 0x040013BF RID: 5055
		private int index;

		// Token: 0x040013C0 RID: 5056
		internal uint[] engineState = new uint[16];

		// Token: 0x040013C1 RID: 5057
		internal uint[] x = new uint[16];

		// Token: 0x040013C2 RID: 5058
		private byte[] keyStream = new byte[64];

		// Token: 0x040013C3 RID: 5059
		private bool initialised;

		// Token: 0x040013C4 RID: 5060
		private uint cW0;

		// Token: 0x040013C5 RID: 5061
		private uint cW1;

		// Token: 0x040013C6 RID: 5062
		private uint cW2;
	}
}
