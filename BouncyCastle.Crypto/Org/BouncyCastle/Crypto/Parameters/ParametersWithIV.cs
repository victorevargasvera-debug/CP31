using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003FF RID: 1023
	public class ParametersWithIV : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002856 RID: 10326 RVA: 0x000AC915 File Offset: 0x000AAB15
		public ParametersWithIV(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] iv) : this(parameters, iv, 0, iv.Length)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x000AC923 File Offset: 0x000AAB23
		public ParametersWithIV(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] iv, int ivOff, int ivLen)
		{
			if (iv == null)
			{
				throw new global::System.ArgumentNullException("iv");
			}
			this.parameters = parameters;
			this.iv = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(iv, ivOff, ivOff + ivLen);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x000AC951 File Offset: 0x000AAB51
		public byte[] GetIV()
		{
			return (byte[])this.iv.Clone();
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x000AC963 File Offset: 0x000AAB63
		public global::Org.BouncyCastle.Crypto.ICipherParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x0400105E RID: 4190
		private readonly global::Org.BouncyCastle.Crypto.ICipherParameters parameters;

		// Token: 0x0400105F RID: 4191
		private readonly byte[] iv;
	}
}
