using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004C1 RID: 1217
	public class XSalsa20Engine : global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine
	{
		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x000DB02E File Offset: 0x000D922E
		public override string AlgorithmName
		{
			get
			{
				return "XSalsa20";
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000DB035 File Offset: 0x000D9235
		protected override int NonceSize
		{
			get
			{
				return 24;
			}
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x000DB03C File Offset: 0x000D923C
		protected override void SetKey(byte[] keyBytes, byte[] ivBytes)
		{
			if (keyBytes == null)
			{
				throw new global::System.ArgumentException(this.AlgorithmName + " doesn't support re-init with null key");
			}
			if (keyBytes.Length != 32)
			{
				throw new global::System.ArgumentException(this.AlgorithmName + " requires a 256 bit key");
			}
			base.SetKey(keyBytes, ivBytes);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(ivBytes, 8, this.engineState, 8, 2);
			uint[] hsalsa20Out = new uint[this.engineState.Length];
			global::Org.BouncyCastle.Crypto.Engines.Salsa20Engine.SalsaCore(20, this.engineState, hsalsa20Out);
			this.engineState[1] = hsalsa20Out[0] - this.engineState[0];
			this.engineState[2] = hsalsa20Out[5] - this.engineState[5];
			this.engineState[3] = hsalsa20Out[10] - this.engineState[10];
			this.engineState[4] = hsalsa20Out[15] - this.engineState[15];
			this.engineState[11] = hsalsa20Out[6] - this.engineState[6];
			this.engineState[12] = hsalsa20Out[7] - this.engineState[7];
			this.engineState[13] = hsalsa20Out[8] - this.engineState[8];
			this.engineState[14] = hsalsa20Out[9] - this.engineState[9];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(ivBytes, 16, this.engineState, 6, 2);
		}
	}
}
