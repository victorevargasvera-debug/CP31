using System;
using System.IO;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x0200040F RID: 1039
	public sealed class X25519PrivateKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x0600289F RID: 10399 RVA: 0x000AD1B2 File Offset: 0x000AB3B2
		public X25519PrivateKeyParameters(global::Org.BouncyCastle.Security.SecureRandom random) : base(true)
		{
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.GeneratePrivateKey(random, this.data);
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x000AD1D7 File Offset: 0x000AB3D7
		public X25519PrivateKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000AD1E6 File Offset: 0x000AB3E6
		public X25519PrivateKeyParameters(byte[] buf, int off) : base(true)
		{
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.KeySize);
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000AD212 File Offset: 0x000AB412
		public X25519PrivateKeyParameters(global::System.IO.Stream input) : base(true)
		{
			if (global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of X25519 private key");
			}
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x000AD249 File Offset: 0x000AB449
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.KeySize);
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000AD25E File Offset: 0x000AB45E
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000AD26C File Offset: 0x000AB46C
		public global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters GeneratePublicKey()
		{
			byte[] publicKey = new byte[32];
			global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.GeneratePublicKey(this.data, 0, publicKey, 0);
			return new global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters(publicKey, 0);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000AD298 File Offset: 0x000AB498
		public void GenerateSecret(global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters publicKey, byte[] buf, int off)
		{
			byte[] encoded = new byte[32];
			publicKey.Encode(encoded, 0);
			if (!global::Org.BouncyCastle.Math.EC.Rfc7748.X25519.CalculateAgreement(this.data, 0, encoded, 0, buf, off))
			{
				throw new global::System.InvalidOperationException("X25519 agreement failed");
			}
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000AD2D4 File Offset: 0x000AB4D4
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x04001089 RID: 4233
		public static readonly int KeySize = 32;

		// Token: 0x0400108A RID: 4234
		public static readonly int SecretSize = 32;

		// Token: 0x0400108B RID: 4235
		private readonly byte[] data = new byte[global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.KeySize];
	}
}
