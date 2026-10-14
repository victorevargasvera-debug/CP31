using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Nist
{
	// Token: 0x020006D9 RID: 1753
	public class KMacWithShake256Params : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FE8 RID: 16360 RVA: 0x00121AB8 File Offset: 0x0011FCB8
		public KMacWithShake256Params(int outputLength)
		{
			this.outputLength = outputLength;
			this.customizationString = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params.EMPTY_STRING;
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00121AD2 File Offset: 0x0011FCD2
		public KMacWithShake256Params(int outputLength, byte[] customizationString)
		{
			this.outputLength = outputLength;
			this.customizationString = global::Org.BouncyCastle.Utilities.Arrays.Clone(customizationString);
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00121AED File Offset: 0x0011FCED
		public static global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params GetInstance(object o)
		{
			if (o is global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params)
			{
				return (global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params)o;
			}
			if (o != null)
			{
				return new global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o));
			}
			return null;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00121B10 File Offset: 0x0011FD10
		private KMacWithShake256Params(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
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
				this.outputLength = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params.DEF_LENGTH;
				this.customizationString = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params.EMPTY_STRING;
				return;
			}
			if (seq[0] is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				this.outputLength = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]).IntValueExact;
				this.customizationString = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params.EMPTY_STRING;
				return;
			}
			this.outputLength = global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params.DEF_LENGTH;
			this.customizationString = global::Org.BouncyCastle.Utilities.Arrays.Clone(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]).GetOctets());
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06003FEC RID: 16364 RVA: 0x00121BEC File Offset: 0x0011FDEC
		public int OutputLength
		{
			get
			{
				return this.outputLength;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x00121BF4 File Offset: 0x0011FDF4
		public byte[] CustomizationString
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.customizationString);
			}
		}

		// Token: 0x06003FEE RID: 16366 RVA: 0x00121C04 File Offset: 0x0011FE04
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.outputLength != global::Org.BouncyCastle.Asn1.Nist.KMacWithShake256Params.DEF_LENGTH)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerInteger(this.outputLength));
			}
			if (this.customizationString.Length != 0)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerOctetString(this.CustomizationString));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001DC4 RID: 7620
		private static readonly byte[] EMPTY_STRING = new byte[0];

		// Token: 0x04001DC5 RID: 7621
		private static readonly int DEF_LENGTH = 512;

		// Token: 0x04001DC6 RID: 7622
		private readonly int outputLength;

		// Token: 0x04001DC7 RID: 7623
		private readonly byte[] customizationString;
	}
}
