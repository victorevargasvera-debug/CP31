using System;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004EC RID: 1260
	public class DHAgreement
	{
		// Token: 0x060031AF RID: 12719 RVA: 0x000EECD0 File Offset: 0x000ECED0
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter kParam;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom rParam = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				this.random = rParam.Random;
				kParam = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)rParam.Parameters;
			}
			else
			{
				this.random = new global::Org.BouncyCastle.Security.SecureRandom();
				kParam = (global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter)parameters;
			}
			if (!(kParam is global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters))
			{
				throw new global::System.ArgumentException("DHEngine expects DHPrivateKeyParameters");
			}
			this.key = (global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)kParam;
			this.dhParams = this.key.Parameters;
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000EED48 File Offset: 0x000ECF48
		public global::Org.BouncyCastle.Math.BigInteger CalculateMessage()
		{
			global::Org.BouncyCastle.Crypto.Generators.DHKeyPairGenerator dhkeyPairGenerator = new global::Org.BouncyCastle.Crypto.Generators.DHKeyPairGenerator();
			dhkeyPairGenerator.Init(new global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters(this.random, this.dhParams));
			global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair dhPair = dhkeyPairGenerator.GenerateKeyPair();
			this.privateValue = ((global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)dhPair.Private).X;
			return ((global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)dhPair.Public).Y;
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000EEDA0 File Offset: 0x000ECFA0
		public global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters pub, global::Org.BouncyCastle.Math.BigInteger message)
		{
			if (pub == null)
			{
				throw new global::System.ArgumentNullException("pub");
			}
			if (message == null)
			{
				throw new global::System.ArgumentNullException("message");
			}
			if (!pub.Parameters.Equals(this.dhParams))
			{
				throw new global::System.ArgumentException("Diffie-Hellman public key has wrong parameters.");
			}
			global::Org.BouncyCastle.Math.BigInteger p = this.dhParams.P;
			global::Org.BouncyCastle.Math.BigInteger peerY = pub.Y;
			if (peerY == null || peerY.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) <= 0 || peerY.CompareTo(p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One)) >= 0)
			{
				throw new global::System.ArgumentException("Diffie-Hellman public key is weak");
			}
			global::Org.BouncyCastle.Math.BigInteger result = peerY.ModPow(this.privateValue, p);
			if (result.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				throw new global::System.InvalidOperationException("Shared key can't be 1");
			}
			return message.ModPow(this.key.X, p).Multiply(result).Mod(p);
		}

		// Token: 0x040015B2 RID: 5554
		private global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters key;

		// Token: 0x040015B3 RID: 5555
		private global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams;

		// Token: 0x040015B4 RID: 5556
		private global::Org.BouncyCastle.Math.BigInteger privateValue;

		// Token: 0x040015B5 RID: 5557
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
