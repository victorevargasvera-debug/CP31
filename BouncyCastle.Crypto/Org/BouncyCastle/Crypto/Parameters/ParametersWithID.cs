using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003FE RID: 1022
	public class ParametersWithID : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x06002852 RID: 10322 RVA: 0x000AC8D7 File Offset: 0x000AAAD7
		public ParametersWithID(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] id) : this(parameters, id, 0, id.Length)
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x000AC8E5 File Offset: 0x000AAAE5
		public ParametersWithID(global::Org.BouncyCastle.Crypto.ICipherParameters parameters, byte[] id, int idOff, int idLen)
		{
			this.parameters = parameters;
			this.id = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(id, idOff, idOff + idLen);
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000AC905 File Offset: 0x000AAB05
		public byte[] GetID()
		{
			return this.id;
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x000AC90D File Offset: 0x000AAB0D
		public global::Org.BouncyCastle.Crypto.ICipherParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x0400105C RID: 4188
		private readonly global::Org.BouncyCastle.Crypto.ICipherParameters parameters;

		// Token: 0x0400105D RID: 4189
		private readonly byte[] id;
	}
}
