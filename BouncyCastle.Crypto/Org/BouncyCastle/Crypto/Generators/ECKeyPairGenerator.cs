using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200046C RID: 1132
	public class ECKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BC1 RID: 11201 RVA: 0x000BBB23 File Offset: 0x000B9D23
		public ECKeyPairGenerator() : this("EC")
		{
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000BBB30 File Offset: 0x000B9D30
		public ECKeyPairGenerator(string algorithm)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			this.algorithm = global::Org.BouncyCastle.Crypto.Parameters.ECKeyParameters.VerifyAlgorithmName(algorithm);
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000BBB54 File Offset: 0x000B9D54
		public void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters ecP = (global::Org.BouncyCastle.Crypto.Parameters.ECKeyGenerationParameters)parameters;
				this.publicKeyParamSet = ecP.PublicKeyParamSet;
				this.parameters = ecP.DomainParameters;
			}
			else
			{
				int strength = parameters.Strength;
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid;
				if (strength <= 239)
				{
					if (strength == 192)
					{
						oid = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime192v1;
						goto IL_AA;
					}
					if (strength == 224)
					{
						oid = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP224r1;
						goto IL_AA;
					}
					if (strength == 239)
					{
						oid = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime239v1;
						goto IL_AA;
					}
				}
				else
				{
					if (strength == 256)
					{
						oid = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.Prime256v1;
						goto IL_AA;
					}
					if (strength == 384)
					{
						oid = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP384r1;
						goto IL_AA;
					}
					if (strength == 521)
					{
						oid = global::Org.BouncyCastle.Asn1.Sec.SecObjectIdentifiers.SecP521r1;
						goto IL_AA;
					}
				}
				throw new global::Org.BouncyCastle.Security.InvalidParameterException("unknown key size.");
				IL_AA:
				global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecps = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(oid);
				this.publicKeyParamSet = oid;
				this.parameters = new global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters(ecps.Curve, ecps.G, ecps.N, ecps.H, ecps.GetSeed());
			}
			this.random = parameters.Random;
			if (this.random == null)
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
			}
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000BBC64 File Offset: 0x000B9E64
		public global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Math.BigInteger i = this.parameters.N;
			int minWeight = i.BitLength >> 2;
			global::Org.BouncyCastle.Math.BigInteger d;
			do
			{
				d = new global::Org.BouncyCastle.Math.BigInteger(i.BitLength, this.random);
			}
			while (d.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || d.CompareTo(i) >= 0 || global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(d) < minWeight);
			global::Org.BouncyCastle.Math.EC.ECPoint q = this.CreateBasePointMultiplier().Multiply(this.parameters.G, d);
			if (this.publicKeyParamSet != null)
			{
				return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(this.algorithm, q, this.publicKeyParamSet), new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(this.algorithm, d, this.publicKeyParamSet));
			}
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(this.algorithm, q, this.parameters), new global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters(this.algorithm, d, this.parameters));
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000BBD2C File Offset: 0x000B9F2C
		protected virtual global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateBasePointMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000BBD34 File Offset: 0x000B9F34
		internal static global::Org.BouncyCastle.Asn1.X9.X9ECParameters FindECCurveByOid(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecP = global::Org.BouncyCastle.Crypto.EC.CustomNamedCurves.GetByOid(oid);
			if (ecP == null)
			{
				ecP = global::Org.BouncyCastle.Asn1.X9.ECNamedCurveTable.GetByOid(oid);
			}
			return ecP;
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000BBD54 File Offset: 0x000B9F54
		internal static global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters GetCorrespondingPublicKey(global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKey)
		{
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters ec = privKey.Parameters;
			global::Org.BouncyCastle.Math.EC.ECPoint q = new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier().Multiply(ec.G, privKey.D);
			if (privKey.PublicKeyParamSet != null)
			{
				return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(privKey.AlgorithmName, q, privKey.PublicKeyParamSet);
			}
			return new global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters(privKey.AlgorithmName, q, ec);
		}

		// Token: 0x04001228 RID: 4648
		private readonly string algorithm;

		// Token: 0x04001229 RID: 4649
		private global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters parameters;

		// Token: 0x0400122A RID: 4650
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet;

		// Token: 0x0400122B RID: 4651
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
