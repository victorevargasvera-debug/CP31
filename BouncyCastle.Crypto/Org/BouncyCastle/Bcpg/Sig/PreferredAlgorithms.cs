using System;

namespace Org.BouncyCastle.Bcpg.Sig
{
	// Token: 0x020005D2 RID: 1490
	public class PreferredAlgorithms : global::Org.BouncyCastle.Bcpg.SignatureSubpacket
	{
		// Token: 0x06003807 RID: 14343 RVA: 0x0010896C File Offset: 0x00106B6C
		private static byte[] IntToByteArray(int[] v)
		{
			byte[] data = new byte[v.Length];
			for (int i = 0; i != v.Length; i++)
			{
				data[i] = (byte)v[i];
			}
			return data;
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x00108998 File Offset: 0x00106B98
		public PreferredAlgorithms(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type, bool critical, bool isLongLength, byte[] data) : base(type, critical, isLongLength, data)
		{
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x001089A5 File Offset: 0x00106BA5
		public PreferredAlgorithms(global::Org.BouncyCastle.Bcpg.SignatureSubpacketTag type, bool critical, int[] preferences) : base(type, critical, false, global::Org.BouncyCastle.Bcpg.Sig.PreferredAlgorithms.IntToByteArray(preferences))
		{
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x001089B8 File Offset: 0x00106BB8
		public int[] GetPreferences()
		{
			int[] v = new int[this.data.Length];
			for (int i = 0; i != v.Length; i++)
			{
				v[i] = (int)(this.data[i] & byte.MaxValue);
			}
			return v;
		}
	}
}
