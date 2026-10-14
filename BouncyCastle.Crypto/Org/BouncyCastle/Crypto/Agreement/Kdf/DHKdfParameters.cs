using System;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Crypto.Agreement.Kdf
{
	// Token: 0x020004FD RID: 1277
	public class DHKdfParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x000F097D File Offset: 0x000EEB7D
		public DHKdfParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, int keySize, byte[] z) : this(algorithm, keySize, z, null)
		{
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000F0989 File Offset: 0x000EEB89
		public DHKdfParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, int keySize, byte[] z, byte[] extraInfo)
		{
			this.algorithm = algorithm;
			this.keySize = keySize;
			this.z = z;
			this.extraInfo = extraInfo;
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06003214 RID: 12820 RVA: 0x000F09AE File Offset: 0x000EEBAE
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x000F09B6 File Offset: 0x000EEBB6
		public int KeySize
		{
			get
			{
				return this.keySize;
			}
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x000F09BE File Offset: 0x000EEBBE
		public byte[] GetZ()
		{
			return this.z;
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x000F09C6 File Offset: 0x000EEBC6
		public byte[] GetExtraInfo()
		{
			return this.extraInfo;
		}

		// Token: 0x0400162A RID: 5674
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm;

		// Token: 0x0400162B RID: 5675
		private readonly int keySize;

		// Token: 0x0400162C RID: 5676
		private readonly byte[] z;

		// Token: 0x0400162D RID: 5677
		private readonly byte[] extraInfo;
	}
}
