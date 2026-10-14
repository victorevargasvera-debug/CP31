using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Nist
{
	// Token: 0x020006D8 RID: 1752
	public class KMacWithShake128Params : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FE0 RID: 16352 RVA: 0x00121904 File Offset: 0x0011FB04
		public KMacWithShake128Params(int outputLength)
		{
			this.outputLength = outputLength;
			this.customizationString = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params.EMPTY_STRING;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0012191E File Offset: 0x0011FB1E
		public KMacWithShake128Params(int outputLength, byte[] customizationString)
		{
			this.outputLength = outputLength;
			this.customizationString = global::Org.BouncyCastle.Utilities.Arrays.Clone(customizationString);
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00121939 File Offset: 0x0011FB39
		public static global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params GetInstance(object o)
		{
			if (o is global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params)
			{
				return (global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params)o;
			}
			if (o != null)
			{
				return new global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o));
			}
			return null;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0012195C File Offset: 0x0011FB5C
		private KMacWithShake128Params(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 2)
			{
				throw new global::System.InvalidOperationException("sequence size greater than 2");
			}
			if (seq.Count == 2)
			{
				this.outputLength = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]).IntValueExact;
				this.customizationString = global::Org.BouncyCastle.Utilities.Arrays.Clone(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]).GetOctets());
				return;
			}
			if (seq.Count != 1)
			{
				this.outputLength = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params.DEF_LENGTH;
				this.customizationString = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params.EMPTY_STRING;
				return;
			}
			if (seq[0] is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				this.outputLength = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]).IntValueExact;
				this.customizationString = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params.EMPTY_STRING;
				return;
			}
			this.outputLength = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params.DEF_LENGTH;
			this.customizationString = global::Org.BouncyCastle.Utilities.Arrays.Clone(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]).GetOctets());
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06003FE4 RID: 16356 RVA: 0x00121A38 File Offset: 0x0011FC38
		public int OutputLength
		{
			get
			{
				return this.outputLength;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x00121A40 File Offset: 0x0011FC40
		public byte[] CustomizationString
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.customizationString);
			}
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00121A50 File Offset: 0x0011FC50
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.outputLength != global::Org.BouncyCastle.Asn1.Nist.KMacWithShake128Params.DEF_LENGTH)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerInteger(this.outputLength));
			}
			if (this.customizationString.Length != 0)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerOctetString(this.CustomizationString));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001DC0 RID: 7616
		private static readonly byte[] EMPTY_STRING = new byte[0];

		// Token: 0x04001DC1 RID: 7617
		private static readonly int DEF_LENGTH = 256;

		// Token: 0x04001DC2 RID: 7618
		private readonly int outputLength;

		// Token: 0x04001DC3 RID: 7619
		private readonly byte[] customizationString;
	}
}
