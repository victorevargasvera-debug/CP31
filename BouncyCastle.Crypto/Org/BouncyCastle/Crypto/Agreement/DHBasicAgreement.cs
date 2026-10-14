using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004ED RID: 1261
	public class DHBasicAgreement : global::Org.BouncyCastle.Crypto.IBasicAgreement
	{
		// Token: 0x060031B3 RID: 12723 RVA: 0x000EEE78 File Offset: 0x000ED078
		public virtual void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				parameters = ((global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters).Parameters;
			}
			if (!(parameters is global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters))
			{
				throw new global::System.ArgumentException("DHEngine expects DHPrivateKeyParameters");
			}
			this.key = (global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters)parameters;
			this.dhParams = this.key.Parameters;
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x000EEECA File Offset: 0x000ED0CA
		public virtual int GetFieldSize()
		{
			return (this.key.Parameters.P.BitLength + 7) / 8;
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000EEEE8 File Offset: 0x000ED0E8
		public virtual global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters pubKey)
		{
			if (this.key == null)
			{
				throw new global::System.InvalidOperationException("Agreement algorithm not initialised");
			}
			global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters dhpublicKeyParameters = (global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)pubKey;
			if (!dhpublicKeyParameters.Parameters.Equals(this.dhParams))
			{
				throw new global::System.ArgumentException("Diffie-Hellman public key has wrong parameters.");
			}
			global::Org.BouncyCastle.Math.BigInteger p = this.dhParams.P;
			global::Org.BouncyCastle.Math.BigInteger peerY = dhpublicKeyParameters.Y;
			if (peerY == null || peerY.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) <= 0 || peerY.CompareTo(p.Subtract(global::Org.BouncyCastle.Math.BigInteger.One)) >= 0)
			{
				throw new global::System.ArgumentException("Diffie-Hellman public key is weak");
			}
			global::Org.BouncyCastle.Math.BigInteger bigInteger = peerY.ModPow(this.key.X, p);
			if (bigInteger.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
			{
				throw new global::System.InvalidOperationException("Shared key can't be 1");
			}
			return bigInteger;
		}

		// Token: 0x040015B6 RID: 5558
		private global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters key;

		// Token: 0x040015B7 RID: 5559
		private global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams;
	}
}
