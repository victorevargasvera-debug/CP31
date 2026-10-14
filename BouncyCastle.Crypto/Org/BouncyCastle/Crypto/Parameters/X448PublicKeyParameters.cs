using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000413 RID: 1043
	public sealed class X448PublicKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060028BB RID: 10427 RVA: 0x000AD572 File Offset: 0x000AB772
		public X448PublicKeyParameters(byte[] buf) : this(global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.Validate(buf), 0)
		{
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x000AD581 File Offset: 0x000AB781
		public X448PublicKeyParameters(byte[] buf, int off)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize];
			base..ctor(false);
			global::System.Array.Copy(buf, off, this.data, 0, global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x000AD5AD File Offset: 0x000AB7AD
		public X448PublicKeyParameters(global::System.IO.Stream input)
		{
			this.data = new byte[global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize];
			base..ctor(false);
			if (global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, this.data))
			{
				throw new global::System.IO.EndOfStreamException("EOF encountered in middle of X448 public key");
			}
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x000AD5E4 File Offset: 0x000AB7E4
		public void Encode(byte[] buf, int off)
		{
			global::System.Array.Copy(this.data, 0, buf, off, global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x000AD5F9 File Offset: 0x000AB7F9
		public byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.data);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x000AD608 File Offset: 0x000AB808
		private static byte[] Validate(byte[] buf)
		{
			if (buf.Length != global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize)
			{
				throw new global::System.ArgumentException("must have length " + global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters.KeySize.ToString(), "buf");
			}
			return buf;
		}

		// Token: 0x04001091 RID: 4241
		public static readonly int KeySize = 56;

		// Token: 0x04001092 RID: 4242
		private readonly byte[] data;
	}
}
