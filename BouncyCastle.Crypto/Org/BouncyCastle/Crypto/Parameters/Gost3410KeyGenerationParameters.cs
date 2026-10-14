using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E9 RID: 1001
	public class Gost3410KeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x060027EA RID: 10218 RVA: 0x000ABDCF File Offset: 0x000A9FCF
		public Gost3410KeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters) : base(random, parameters.P.BitLength - 1)
		{
			this.parameters = parameters;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000ABDEC File Offset: 0x000A9FEC
		public Gost3410KeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : this(random, global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters.LookupParameters(publicKeyParamSet))
		{
			this.publicKeyParamSet = publicKeyParamSet;
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000ABE02 File Offset: 0x000AA002
		public global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000ABE0A File Offset: 0x000AA00A
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return this.publicKeyParamSet;
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000ABE14 File Offset: 0x000AA014
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

		// Token: 0x04001026 RID: 4134
		private readonly global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters;

		// Token: 0x04001027 RID: 4135
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
	}
}
