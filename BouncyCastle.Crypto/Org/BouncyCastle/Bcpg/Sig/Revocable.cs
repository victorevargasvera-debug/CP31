using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D4 RID: 1492
	public class Revocable : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x0600380F RID: 14351 RVA: 0x00108A40 File Offset: 0x00106C40
		private static byte[] BooleanToByteArray(bool value)
		{
			byte[] data = new byte[1];
			if (value)
			{
				data[0] = 1;
				return data;
			}
			return data;
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00108A5E File Offset: 0x00106C5E
		public Revocable(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Revocable, critical, isLongLength, data)
		{
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00108A6A File Offset: 0x00106C6A
		public Revocable(bool critical, bool isRevocable) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Revocable, critical, false, global::Org.BouncyCastle.Bcpg.Sig.Revocable.BooleanToByteArray(isRevocable))
		{
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00108A7B File Offset: 0x00106C7B
		public bool IsRevocable()
		{
			return this.data[0] > 0;
		}
	}
}
