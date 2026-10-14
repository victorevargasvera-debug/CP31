using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D0 RID: 1488
	public class KeyFlags : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x060037FC RID: 14332 RVA: 0x00108710 File Offset: 0x00106910
		private static byte[] IntToByteArray(int v)
		{
			byte[] tmp = new byte[4];
			int size = 0;
			for (int i = 0; i != 4; i++)
			{
				tmp[i] = (byte)(v >> i * 8);
				if (tmp[i] != 0)
				{
					size = i;
				}
			}
			byte[] data = new byte[size + 1];
			global::System.Array.Copy(tmp, 0, data, 0, data.Length);
			return data;
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x0010875B File Offset: 0x0010695B
		public KeyFlags(bool critical, bool isLongLength, byte[] data) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyFlags, critical, isLongLength, data)
		{
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00108768 File Offset: 0x00106968
		public KeyFlags(bool critical, int flags) : base(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag.KeyFlags, critical, false, global::Org.BouncyCastle.Bcpg.Sig.KeyFlags.IntToByteArray(flags))
		{
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x0010877C File Offset: 0x0010697C
		public int Flags
		{
			get
			{
				int flags = 0;
				for (int i = 0; i != this.data.Length; i++)
				{
					flags |= (int)(this.data[i] & byte.MaxValue) << i * 8;
				}
				return flags;
			}
		}

		// Token: 0x0400191E RID: 6430
		public const int CertifyOther = 1;

		// Token: 0x0400191F RID: 6431
		public const int SignData = 2;

		// Token: 0x04001920 RID: 6432
		public const int EncryptComms = 4;

		// Token: 0x04001921 RID: 6433
		public const int EncryptStorage = 8;

		// Token: 0x04001922 RID: 6434
		public const int Split = 16;

		// Token: 0x04001923 RID: 6435
		public const int Authentication = 32;

		// Token: 0x04001924 RID: 6436
		public const int Shared = 128;
	}
}
