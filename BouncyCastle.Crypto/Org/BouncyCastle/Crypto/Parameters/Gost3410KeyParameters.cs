using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003EA RID: 1002
	public abstract class Gost3410KeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060027EF RID: 10223 RVA: 0x000ABE60 File Offset: 0x000AA060
		protected Gost3410KeyParameters(bool isPrivate, global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters) : base(isPrivate)
		{
			this.parameters = parameters;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000ABE70 File Offset: 0x000AA070
		protected Gost3410KeyParameters(bool isPrivate, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base(isPrivate)
		{
			this.parameters = global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters.LookupParameters(publicKeyParamSet);
			this.publicKeyParamSet = publicKeyParamSet;
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000ABE8C File Offset: 0x000AA08C
		public global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x000ABE94 File Offset: 0x000AA094
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return this.publicKeyParamSet;
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000ABE9C File Offset: 0x000AA09C
		private static global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters LookupParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
		{
			if (publicKeyParamSet == null)
			{
				throw new global::System.ArgumentNullException("publicKeyParamSet");
			}
			global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters p = global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410NamedParameters.GetByOid(publicKeyParamSet);
			if (p == null)
			{
				throw new global::System.ArgumentException("OID is not a valid CryptoPro public key parameter set", "publicKeyParamSet");
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters(p.P, p.Q, p.A);
		}

		// Token: 0x04001028 RID: 4136
		private readonly global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters;

		// Token: 0x04001029 RID: 4137
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
	}
}
