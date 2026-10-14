using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005CC RID: 1484
	public class Exportable : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060037E9 RID: 14313 RVA: 0x001084B0 File Offset: 0x001066B0
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

		// Token: 0x060037EA RID: 14314 RVA: 0x001084CE File Offset: 0x001066CE
		public Exportable(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Exportable, critical, isLongLength, data)
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x001084DA File Offset: 0x001066DA
		public Exportable(bool critical, bool isExportable) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.Exportable, critical, false, global::Org.BouncyCastle.Bcpg.Sig.Exportable.BooleanToByteArray(isExportable))
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x001084EB File Offset: 0x001066EB
		public bool IsExportable()
		{
			return this.data[0] > 0;
		}
	}
}
