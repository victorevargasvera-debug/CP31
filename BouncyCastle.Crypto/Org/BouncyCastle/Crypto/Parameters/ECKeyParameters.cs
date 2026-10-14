using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D9 RID: 985
	public abstract class ECKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x06002782 RID: 10114 RVA: 0x000AB0DB File Offset: 0x000A92DB
		protected ECKeyParameters(string algorithm, bool isPrivate, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters) : base(isPrivate)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			this.algorithm = global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.VerifyAlgorithmName(algorithm);
			this.parameters = parameters;
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x000AB114 File Offset: 0x000A9314
		protected ECKeyParameters(string algorithm, bool isPrivate, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base(isPrivate)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			if (publicKeyParamSet == null)
			{
				throw new global::System.ArgumentNullException("publicKeyParamSet");
			}
			this.algorithm = global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.VerifyAlgorithmName(algorithm);
			this.parameters = global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.LookupParameters(publicKeyParamSet);
			this.publicKeyParamSet = publicKeyParamSet;
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000AB163 File Offset: 0x000A9363
		public string AlgorithmName
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000AB16B File Offset: 0x000A936B
		public global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000AB173 File Offset: 0x000A9373
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier PublicKeyParamSet
		{
			get
			{
				return this.publicKeyParamSet;
			}
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000AB17C File Offset: 0x000A937C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x000AB1A2 File Offset: 0x000A93A2
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters other)
		{
			return this.parameters.Equals(other.parameters) && base.Equals(other);
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000AB1C0 File Offset: 0x000A93C0
		public override int GetHashCode()
		{
			return this.parameters.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000AB1D4 File Offset: 0x000A93D4
		internal global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters CreateKeyGenerationParameters(global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (this.publicKeyParamSet != null)
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(this.publicKeyParamSet, random);
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters(this.parameters, random);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000AB1F7 File Offset: 0x000A93F7
		internal static string VerifyAlgorithmName(string algorithm)
		{
			string result = global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(algorithm);
			if (global::System.Array.IndexOf<string>(global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.algorithms, algorithm, 0, global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.algorithms.Length) < 0)
			{
				throw new global::System.ArgumentException("unrecognised algorithm: " + algorithm, "algorithm");
			}
			return result;
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000AB22B File Offset: 0x000A942B
		internal static global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters LookupParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet)
		{
			if (publicKeyParamSet == null)
			{
				throw new global::System.ArgumentNullException("publicKeyParamSet");
			}
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters x9ECParameters = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(publicKeyParamSet);
			if (x9ECParameters == null)
			{
				throw new global::System.ArgumentException("OID is not a valid public key parameter set", "publicKeyParamSet");
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(x9ECParameters);
		}

		// Token: 0x04001008 RID: 4104
		private static readonly string[] algorithms = new string[]
		{
			"EC",
			"ECDSA",
			"ECDH",
			"ECDHC",
			"ECGOST3410",
			"ECMQV"
		};

		// Token: 0x04001009 RID: 4105
		private readonly string algorithm;

		// Token: 0x0400100A RID: 4106
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters;

		// Token: 0x0400100B RID: 4107
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;
	}
}
