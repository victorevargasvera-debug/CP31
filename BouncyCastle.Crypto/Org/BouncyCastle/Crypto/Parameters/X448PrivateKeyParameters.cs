using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000412 RID: 1042
	public sealed class X448PrivateKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060028B1 RID: 10417 RVA: 0x000AD405 File Offset: 0x000AB605
		public X448PrivateKeyParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(true)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448.GeneratePrivateKey(random, this.data);
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000AD42A File Offset: 0x000AB62A
		public X448PrivateKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000AD439 File Offset: 0x000AB639
		public X448PrivateKeyParameters(byte[] buf, int off) : base(true)
		{
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.KeySize);
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x000AD465 File Offset: 0x000AB665
		public X448PrivateKeyParameters(global::System.IO.Stream input) : base(true)
		{
			if (global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of X448 private key");
			}
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x000AD49C File Offset: 0x000AB69C
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.KeySize);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000AD4B1 File Offset: 0x000AB6B1
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000AD4C0 File Offset: 0x000AB6C0
		public global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters GeneratePublicKey()
		{
			byte[] publicKey = new byte[56];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X448.GeneratePublicKey(this.data, 0, publicKey, 0);
			return new global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters(publicKey, 0);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000AD4EC File Offset: 0x000AB6EC
		public void GenerateSecret(global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters publicKey, byte[] buf, int off)
		{
			byte[] encoded = new byte[56];
			publicKey.Encode(encoded, 0);
			if (!global::Org.BouncyCastle.Math.EC.Rfc7748.X448.CalculateAgreement(this.data, 0, encoded, 0, buf, off))
			{
				throw new global::System.InvalidOperationException("X448 agreement failed");
			}
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x000AD528 File Offset: 0x000AB728
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x0400108E RID: 4238
		public static readonly int KeySize = 56;

		// Token: 0x0400108F RID: 4239
		public static readonly int SecretSize = 56;

		// Token: 0x04001090 RID: 4240
		private readonly byte[] data = new byte[global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.KeySize];
	}
}
