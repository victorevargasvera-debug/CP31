using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000628 RID: 1576
	public class LazyAsn1InputStream : global::Org.BouncyCastle.Asn1.Asn1InputStream
	{
		// Token: 0x06003AA2 RID: 15010 RVA: 0x0010F32F File Offset: 0x0010D52F
		public LazyAsn1InputStream(byte[] input) : base(input)
		{
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x0010F338 File Offset: 0x0010D538
		public LazyAsn1InputStream(global::System.IO.Stream inputStream) : base(inputStream)
		{
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x0010F341 File Offset: 0x0010D541
		internal LazyAsn1InputStream(global::System.IO.Stream input, int limit, byte[][] tmpBuffers) : base(input, limit, tmpBuffers)
		{
		}

		// Token: 0x06003AA5 RID: 15013 RVA: 0x0010F34C File Offset: 0x0010D54C
		internal override global::Org.BouncyCastle.Asn1.DerSequence CreateDerSequence(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
		{
			return new global::Org.BouncyCastle.Asn1.LazyDerSequence(dIn.ToArray());
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x0010F359 File Offset: 0x0010D559
		internal override global::Org.BouncyCastle.Asn1.DerSet CreateDerSet(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream dIn)
		{
			return new global::Org.BouncyCastle.Asn1.LazyDerSet(dIn.ToArray());
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x0010F368 File Offset: 0x0010D568
		internal override global::Org.BouncyCastle.Asn1.Asn1EncodableVector ReadVector(global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream defIn)
		{
			int remaining = defIn.Remaining;
			if (remaining < 1)
			{
				return new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(0);
			}
			return new global::Org.BouncyCastle.Asn1.LazyAsn1InputStream(defIn, remaining, this.tmpBuffers).ReadVector();
		}
	}
}
