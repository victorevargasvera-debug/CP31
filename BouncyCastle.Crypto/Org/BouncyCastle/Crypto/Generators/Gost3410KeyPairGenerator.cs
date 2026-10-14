using System;
using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000471 RID: 1137
	public class Gost3410KeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BD4 RID: 11220 RVA: 0x000BBEFC File Offset: 0x000BA0FC
		public void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters)
			{
				this.param = (global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters)parameters;
				return;
			}
			global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters kgp = new global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters(parameters.Random, global::Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3410x94CryptoProA);
			int strength = parameters.Strength;
			int num = kgp.Parameters.P.BitLength - 1;
			this.param = kgp;
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000BBF50 File Offset: 0x000BA150
		public global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Security.SecureRandom random = this.param.Random;
			global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters gost3410Params = this.param.Parameters;
			global::Org.BouncyCastle.Math.BigInteger q = gost3410Params.Q;
			int minWeight = 64;
			global::Org.BouncyCastle.Math.BigInteger x;
			do
			{
				x = new global::Org.BouncyCastle.Math.BigInteger(256, random);
			}
			while (x.SignValue < 1 || x.CompareTo(q) >= 0 || global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(x) < minWeight);
			global::Org.BouncyCastle.Math.BigInteger p = gost3410Params.P;
			global::Org.BouncyCastle.Math.BigInteger y = gost3410Params.A.ModPow(x, p);
			if (this.param.PublicKeyParamSet != null)
			{
				return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters(y, this.param.PublicKeyParamSet), new global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters(x, this.param.PublicKeyParamSet));
			}
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.Gost3410PublicKeyParameters(y, gost3410Params), new global::Org.BouncyCastle.Crypto.Parameters.Gost3410PrivateKeyParameters(x, gost3410Params));
		}

		// Token: 0x04001232 RID: 4658
		private global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyGenerationParameters param;
	}
}
