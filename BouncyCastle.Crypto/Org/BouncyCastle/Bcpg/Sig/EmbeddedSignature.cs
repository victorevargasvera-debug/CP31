using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005CB RID: 1483
	public class EmbeddedSignature : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060037E8 RID: 14312 RVA: 0x001084A0 File Offset: 0x001066A0
		public EmbeddedSignature(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.EmbeddedSignature, critical, isLongLength, data)
		{
		}
	}
}
