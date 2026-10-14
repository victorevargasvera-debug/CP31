using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D3 RID: 1491
	public class PrimaryUserId : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x0600380B RID: 14347 RVA: 0x001089F4 File Offset: 0x00106BF4
		private static byte[] BooleanToByteArray(bool val)
		{
			byte[] data = new byte[1];
			if (val)
			{
				data[0] = 1;
				return data;
			}
			return data;
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x00108A12 File Offset: 0x00106C12
		public PrimaryUserId(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PrimaryUserId, critical, isLongLength, data)
		{
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x00108A1F File Offset: 0x00106C1F
		public PrimaryUserId(bool critical, bool isPrimaryUserId) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.PrimaryUserId, critical, false, global::Org.BouncyCastle.Bcpg.Sig.PrimaryUserId.BooleanToByteArray(isPrimaryUserId))
		{
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x00108A31 File Offset: 0x00106C31
		public bool IsPrimaryUserId()
		{
			return this.data[0] > 0;
		}
	}
}
