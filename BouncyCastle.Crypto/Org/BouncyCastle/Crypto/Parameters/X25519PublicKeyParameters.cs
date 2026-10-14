using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000410 RID: 1040
	public sealed class X25519PublicKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060028A9 RID: 10409 RVA: 0x000AD31E File Offset: 0x000AB51E
		public X25519PublicKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000AD32D File Offset: 0x000AB52D
		public X25519PublicKeyParameters(byte[] buf, int off)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize];
			base..ctor(false);
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000AD359 File Offset: 0x000AB559
		public X25519PublicKeyParameters(global::System.IO.Stream input)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize];
			base..ctor(false);
			if (global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of X25519 public key");
			}
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000AD390 File Offset: 0x000AB590
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000AD3A5 File Offset: 0x000AB5A5
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000AD3B4 File Offset: 0x000AB5B4
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x0400108C RID: 4236
		public static readonly int KeySize = 32;

		// Token: 0x0400108D RID: 4237
		private readonly byte[] data;
	}
}
