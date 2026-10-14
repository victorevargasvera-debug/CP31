using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D7 RID: 1495
	public class SignerUserId : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x0600381B RID: 14363 RVA: 0x00108BB8 File Offset: 0x00106DB8
		private static byte[] UserIdToBytes(string id)
		{
			byte[] idData = new byte[id.Length];
			for (int i = 0; i != id.Length; i++)
			{
				idData[i] = (byte)id[i];
			}
			return idData;
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00108BEE File Offset: 0x00106DEE
		public SignerUserId(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.SignerUserId, critical, isLongLength, data)
		{
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x00108BFB File Offset: 0x00106DFB
		public SignerUserId(bool critical, string userId) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.SignerUserId, critical, false, global::Org.BouncyCastle.Bcpg.Sig.SignerUserId.UserIdToBytes(userId))
		{
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00108C10 File Offset: 0x00106E10
		public string GetId()
		{
			char[] chars = new char[this.data.Length];
			for (int i = 0; i != chars.Length; i++)
			{
				chars[i] = (char)(this.data[i] & byte.MaxValue);
			}
			return new string(chars);
		}
	}
}
