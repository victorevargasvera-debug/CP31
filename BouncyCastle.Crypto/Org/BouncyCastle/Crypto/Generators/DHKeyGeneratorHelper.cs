using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000466 RID: 1126
	internal class DHKeyGeneratorHelper
	{
		// Token: 0x06002B9E RID: 11166 RVA: 0x000BAF6E File Offset: 0x000B916E
		private DHKeyGeneratorHelper()
		{
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x000BAF78 File Offset: 0x000B9178
		internal global::Org.BouncyCastle.Math.BigInteger CalculatePrivate(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			int limit = dhParams.L;
			if (limit != 0)
			{
				int minWeight = limit >> 2;
				global::Org.BouncyCastle.Math.BigInteger x;
				do
				{
					x = new global::Org.BouncyCastle.Math.BigInteger(limit, random).SetBit(limit - 1);
				}
				while (global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(x) < minWeight);
				return x;
			}
			global::Org.BouncyCastle.Math.BigInteger min = global::Org.BouncyCastle.Math.BigInteger.Two;
			int i = dhParams.M;
			if (i != 0)
			{
				min = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(i - 1);
			}
			global::Org.BouncyCastle.Math.BigInteger q = dhParams.Q;
			if (q == null)
			{
				q = dhParams.P;
			}
			global::Org.BouncyCastle.Math.BigInteger max = q.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two);
			int minWeight2 = max.BitLength >> 2;
			global::Org.BouncyCastle.Math.BigInteger x2;
			do
			{
				x2 = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(min, max, random);
			}
			while (global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(x2) < minWeight2);
			return x2;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x000BB012 File Offset: 0x000B9212
		internal global::Org.BouncyCastle.Math.BigInteger CalculatePublic(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams, global::Org.BouncyCastle.Math.BigInteger x)
		{
			return dhParams.G.ModPow(x, dhParams.P);
		}

		// Token: 0x04001216 RID: 4630
		internal static readonly global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper Instance = new global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper();
	}
}
