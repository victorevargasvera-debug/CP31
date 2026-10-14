using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D8 RID: 1496
	public class TrustSignature : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x0600381F RID: 14367 RVA: 0x00108C51 File Offset: 0x00106E51
		private static byte[] IntToByteArray(int v1, int v2)
		{
			return new byte[]
			{
				(byte)v1,
				(byte)v2
			};
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00108C63 File Offset: 0x00106E63
		public TrustSignature(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.TrustSig, critical, isLongLength, data)
		{
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00108C6F File Offset: 0x00106E6F
		public TrustSignature(bool critical, int depth, int trustAmount) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.TrustSig, critical, false, global::Org.BouncyCastle.Bcpg.Sig.TrustSignature.IntToByteArray(depth, trustAmount))
		{
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x00108C81 File Offset: 0x00106E81
		public int Depth
		{
			get
			{
				return (int)(this.data[0] & byte.MaxValue);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x00108C91 File Offset: 0x00106E91
		public int TrustAmount
		{
			get
			{
				return (int)(this.data[1] & byte.MaxValue);
			}
		}
	}
}
