using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.Srp
{
	// Token: 0x020004FA RID: 1274
	public class Srp6Utilities
	{
		// Token: 0x060031FE RID: 12798 RVA: 0x000F051D File Offset: 0x000EE71D
		public static global::Org.BouncyCastle.Math.BigInteger CalculateK(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g)
		{
			return global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.HashPaddedPair(digest, N, N, g);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x000F0528 File Offset: 0x000EE728
		public static global::Org.BouncyCastle.Math.BigInteger CalculateU(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger A, global::Org.BouncyCastle.Math.BigInteger B)
		{
			return global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.HashPaddedPair(digest, N, A, B);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x000F0534 File Offset: 0x000EE734
		public static global::Org.BouncyCastle.Math.BigInteger CalculateX(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, byte[] salt, byte[] identity, byte[] password)
		{
			byte[] output = new byte[digest.GetDigestSize()];
			digest.BlockUpdate(identity, 0, identity.Length);
			digest.Update(58);
			digest.BlockUpdate(password, 0, password.Length);
			digest.DoFinal(output, 0);
			digest.BlockUpdate(salt, 0, salt.Length);
			digest.BlockUpdate(output, 0, output.Length);
			digest.DoFinal(output, 0);
			return new global::Org.BouncyCastle.Math.BigInteger(1, output);
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x000F059C File Offset: 0x000EE79C
		public static global::Org.BouncyCastle.Math.BigInteger GeneratePrivateValue(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			int minBits = global::System.Math.Min(256, N.BitLength / 2);
			global::Org.BouncyCastle.Math.BigInteger min = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(minBits - 1);
			global::Org.BouncyCastle.Math.BigInteger max = N.Subtract(global::Org.BouncyCastle.Math.BigInteger.One);
			return global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(min, max, random);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x000F05DC File Offset: 0x000EE7DC
		public static global::Org.BouncyCastle.Math.BigInteger ValidatePublicValue(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger val)
		{
			val = val.Mod(N);
			if (val.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero))
			{
				throw new global::Org.BouncyCastle.Crypto.CryptoException("Invalid public value: 0");
			}
			return val;
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x000F0600 File Offset: 0x000EE800
		public static global::Org.BouncyCastle.Math.BigInteger CalculateM1(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger A, global::Org.BouncyCastle.Math.BigInteger B, global::Org.BouncyCastle.Math.BigInteger S)
		{
			return global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.HashPaddedTriplet(digest, N, A, B, S);
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x000F060D File Offset: 0x000EE80D
		public static global::Org.BouncyCastle.Math.BigInteger CalculateM2(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger A, global::Org.BouncyCastle.Math.BigInteger M1, global::Org.BouncyCastle.Math.BigInteger S)
		{
			return global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.HashPaddedTriplet(digest, N, A, M1, S);
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x000F061C File Offset: 0x000EE81C
		public static global::Org.BouncyCastle.Math.BigInteger CalculateKey(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger S)
		{
			int padLength = (N.BitLength + 7) / 8;
			byte[] _S = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GetPadded(S, padLength);
			digest.BlockUpdate(_S, 0, _S.Length);
			byte[] output = new byte[digest.GetDigestSize()];
			digest.DoFinal(output, 0);
			return new global::Org.BouncyCastle.Math.BigInteger(1, output);
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000F0664 File Offset: 0x000EE864
		private static global::Org.BouncyCastle.Math.BigInteger HashPaddedTriplet(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger n1, global::Org.BouncyCastle.Math.BigInteger n2, global::Org.BouncyCastle.Math.BigInteger n3)
		{
			int padLength = (N.BitLength + 7) / 8;
			byte[] n1_bytes = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GetPadded(n1, padLength);
			byte[] n2_bytes = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GetPadded(n2, padLength);
			byte[] n3_bytes = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GetPadded(n3, padLength);
			digest.BlockUpdate(n1_bytes, 0, n1_bytes.Length);
			digest.BlockUpdate(n2_bytes, 0, n2_bytes.Length);
			digest.BlockUpdate(n3_bytes, 0, n3_bytes.Length);
			byte[] output = new byte[digest.GetDigestSize()];
			digest.DoFinal(output, 0);
			return new global::Org.BouncyCastle.Math.BigInteger(1, output);
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x000F06D8 File Offset: 0x000EE8D8
		private static global::Org.BouncyCastle.Math.BigInteger HashPaddedPair(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger n1, global::Org.BouncyCastle.Math.BigInteger n2)
		{
			int padLength = (N.BitLength + 7) / 8;
			byte[] n1_bytes = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GetPadded(n1, padLength);
			byte[] n2_bytes = global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Utilities.GetPadded(n2, padLength);
			digest.BlockUpdate(n1_bytes, 0, n1_bytes.Length);
			digest.BlockUpdate(n2_bytes, 0, n2_bytes.Length);
			byte[] output = new byte[digest.GetDigestSize()];
			digest.DoFinal(output, 0);
			return new global::Org.BouncyCastle.Math.BigInteger(1, output);
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000F0734 File Offset: 0x000EE934
		private static byte[] GetPadded(global::Org.BouncyCastle.Math.BigInteger n, int length)
		{
			byte[] bs = global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n);
			if (bs.Length < length)
			{
				byte[] tmp = new byte[length];
				global::System.Array.Copy(bs, 0, tmp, length - bs.Length, bs.Length);
				bs = tmp;
			}
			return bs;
		}
	}
}
