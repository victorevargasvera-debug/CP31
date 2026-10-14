using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000495 RID: 1173
	public class ChaCha7539Engine : global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine
	{
		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000C92DD File Offset: 0x000C74DD
		public override string AlgorithmName
		{
			get
			{
				return "ChaCha7539";
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x000C92E4 File Offset: 0x000C74E4
		protected override int NonceSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000C92E8 File Offset: 0x000C74E8
		protected override void AdvanceCounter()
		{
			uint[] engineState = this.engineState;
			int num = 12;
			uint num2 = engineState[num] + 1U;
			engineState[num] = num2;
			if (num2 == 0U)
			{
				throw new global::System.InvalidOperationException("attempt to increase counter past 2^32.");
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000C9317 File Offset: 0x000C7517
		protected override void ResetCounter()
		{
			this.engineState[12] = 0U;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000C9324 File Offset: 0x000C7524
		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
			if (keyBytes != null)
			{
				if (keyBytes.Length != 32)
				{
					throw new global::System.ArgumentException(this.AlgorithmName + " requires 256 bit key");
				}
				base.PackTauOrSigma(keyBytes.Length, this.engineState, 0);
				global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(keyBytes, 0, this.engineState, 4, 8);
			}
			global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(ivBytes, 0, this.engineState, 13, 3);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000C9380 File Offset: 0x000C7580
		protected override void GenerateKeyStream(byte[] output)
		{
			global::Org.BouncyCastle.Crypto.Engines.ChaChaEngine.ChachaCore(this.rounds, this.engineState, this.x);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(this.x, output, 0);
		}
	}
}
