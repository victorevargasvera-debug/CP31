using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D8 RID: 984
	public class ECKeyGenerationParameters : global::Org.BouncyCastle.Crypto.KeyGenerationParameters
	{
		// Token: 0x0600277E RID: 10110 RVA: 0x000AB09A File Offset: 0x000A929A
		public ECKeyGenerationParameters(global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters domainParameters, global::Org.BouncyCastle.Security.SecureRandom random) : base(random, domainParameters.N.BitLength)
		{
			this.domainParams = domainParameters;
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000AB0B5 File Offset: 0x000A92B5
		public ECKeyGenerationParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet, global::Org.BouncyCastle.Security.SecureRandom random) : this(global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.LookupParameters(publicKeyParamSet), random)
		{
			this.publicKeyParamSet = publicKeyParamSet;
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000AB0CB File Offset: 0x000A92CB
		public global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters DomainParameters
		{
			get
			{
				return this.domainParams;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002781 RID: 10113 RVA: 0x000AB0D3 File Offset: 0x000A92D3
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return this.publicKeyParamSet;
			}
		}

		// Token: 0x04001006 RID: 4102
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters domainParams;

		// Token: 0x04001007 RID: 4103
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
	}
}
