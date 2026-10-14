using System;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D7 RID: 983
	public class ECGost3410Parameters : global::Org.BouncyCastle.Crypto.Parameters.ECNamedDomainParameters
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000AAFF7 File Offset: 0x000A91F7
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return this._publicKeyParamSet;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000AAFFF File Offset: 0x000A91FF
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier DigestParamSet
		{
			get
			{
				return this._digestParamSet;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000AB007 File Offset: 0x000A9207
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier EncryptionParamSet
		{
			get
			{
				return this._encryptionParamSet;
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000AB010 File Offset: 0x000A9210
		public ECGost3410Parameters(global::Org.BouncyCastle.Crypto.Parameters.ECNamedDomainParameters dp, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet) : base(dp.Name, dp.Curve, dp.G, dp.N, dp.H, dp.GetSeed())
		{
			this._publicKeyParamSet = publicKeyParamSet;
			this._digestParamSet = digestParamSet;
			this._encryptionParamSet = encryptionParamSet;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x000AB05D File Offset: 0x000A925D
		public ECGost3410Parameters(global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dp, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestParamSet, global::Org.BouncyCastle.Asn1.DerObjectIdentifier encryptionParamSet) : base(publicKeyParamSet, dp.Curve, dp.G, dp.N, dp.H, dp.GetSeed())
		{
			this._publicKeyParamSet = publicKeyParamSet;
			this._digestParamSet = digestParamSet;
			this._encryptionParamSet = encryptionParamSet;
		}

		// Token: 0x04001003 RID: 4099
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier _publicKeyParamSet;

		// Token: 0x04001004 RID: 4100
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier _digestParamSet;

		// Token: 0x04001005 RID: 4101
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier _encryptionParamSet;
	}
}
