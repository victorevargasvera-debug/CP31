using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000496 RID: 1174
	public class ChaChaEngine : global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine
	{
		// Token: 0x06002D2F RID: 11567 RVA: 0x000C93A6 File Offset: 0x000C75A6
		public ChaChaEngine()
		{
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000C93AE File Offset: 0x000C75AE
		public ChaChaEngine(int rounds) : base(rounds)
		{
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x000C93B7 File Offset: 0x000C75B7
		public override string AlgorithmName
		{
			get
			{
				return "ChaCha" + this.rounds.ToString();
			}
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000C93D0 File Offset: 0x000C75D0
		protected override void AdvanceCounter()
		{
			uint[] engineState = this.engineState;
			int num = 12;
			uint num2 = engineState[num] + 1U;
			engineState[num] = num2;
			if (num2 == 0U)
			{
				this.engineState[13] += 1U;
			}
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000C9408 File Offset: 0x000C7608
		protected override void ResetCounter()
		{
			this.engineState[12] = (this.engineState[13] = 0U);
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000C942C File Offset: 0x000C762C
		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
			if (keyBytes != null)
			{
				if (keyBytes.Length != 16 && keyBytes.Length != 32)
				{
					throw new global::System.ArgumentException(this.AlgorithmName + " requires 128 bit or 256 bit key");
				}
				base.PackTauOrSigma(keyBytes.Length, this.engineState, 0);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(keyBytes, 0, this.engineState, 4, 4);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(keyBytes, keyBytes.Length - 16, this.engineState, 8, 4);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(ivBytes, 0, this.engineState, 14, 2);
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x000C94A3 File Offset: 0x000C76A3
		protected override void GenerateKeyStream(byte[] output)
		{
			global::Org.BouncyCastle.Crypto.Engines.ChaChaEngine.ChachaCore(this.rounds, this.engineState, this.x);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.x, output, 0);
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x000C94CC File Offset: 0x000C76CC
		internal static void ChachaCore(int rounds, uint[] input, uint[] x)
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
				x2 += x6;
				x14 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x14 ^ x2, 16);
				x10 += x14;
				x6 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x6 ^ x10, 12);
				x2 += x6;
				x14 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x14 ^ x2, 8);
				x10 += x14;
				x6 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x6 ^ x10, 7);
				x3 += x7;
				x15 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x15 ^ x3, 16);
				x11 += x15;
				x7 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x7 ^ x11, 12);
				x3 += x7;
				x15 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x15 ^ x3, 8);
				x11 += x15;
				x7 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x7 ^ x11, 7);
				x4 += x8;
				x16 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x16 ^ x4, 16);
				x12 += x16;
				x8 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x8 ^ x12, 12);
				x4 += x8;
				x16 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x16 ^ x4, 8);
				x12 += x16;
				x8 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x8 ^ x12, 7);
				x5 += x9;
				x17 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x17 ^ x5, 16);
				x13 += x17;
				x9 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x9 ^ x13, 12);
				x5 += x9;
				x17 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x17 ^ x5, 8);
				x13 += x17;
				x9 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x9 ^ x13, 7);
				x2 += x7;
				x17 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x17 ^ x2, 16);
				x12 += x17;
				x7 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x7 ^ x12, 12);
				x2 += x7;
				x17 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x17 ^ x2, 8);
				x12 += x17;
				x7 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x7 ^ x12, 7);
				x3 += x8;
				x14 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x14 ^ x3, 16);
				x13 += x14;
				x8 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x8 ^ x13, 12);
				x3 += x8;
				x14 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x14 ^ x3, 8);
				x13 += x14;
				x8 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x8 ^ x13, 7);
				x4 += x9;
				x15 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x15 ^ x4, 16);
				x10 += x15;
				x9 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x9 ^ x10, 12);
				x4 += x9;
				x15 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x15 ^ x4, 8);
				x10 += x15;
				x9 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x9 ^ x10, 7);
				x5 += x6;
				x16 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x16 ^ x5, 16);
				x11 += x16;
				x6 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x6 ^ x11, 12);
				x5 += x6;
				x16 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x16 ^ x5, 8);
				x11 += x16;
				x6 = global::Org.BouncyCastle.Utilities.Integers.RotateLeft(x6 ^ x11, 7);
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
	}
}
