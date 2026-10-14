using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x020006DD RID: 1757
	public class Cast5CbcParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FFF RID: 16383 RVA: 0x001225F1 File Offset: 0x001207F1
		public static global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters GetInstance(object o)
		{
			if (o is global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters)
			{
				return (global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Misc.Cast5CbcParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			throw new global::System.ArgumentException("unknown object in Cast5CbcParameters factory");
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x00122620 File Offset: 0x00120820
		public Cast5CbcParameters(byte[] iv, int keyLength)
		{
			this.iv = new global::Org.BouncyCastle.Asn1.DerOctetString(iv);
			this.keyLength = new global::Org.BouncyCastle.Asn1.DerInteger(keyLength);
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x00122640 File Offset: 0x00120840
		private Cast5CbcParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.iv = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[0];
			this.keyLength = (global::Org.BouncyCastle.Asn1.DerInteger)seq[1];
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x00122690 File Offset: 0x00120890
		public byte[] GetIV()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.iv.GetOctets());
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06004003 RID: 16387 RVA: 0x001226A2 File Offset: 0x001208A2
		public int KeyLength
		{
			get
			{
				return this.keyLength.IntValueExact;
			}
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x001226AF File Offset: 0x001208AF
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.iv,
				this.keyLength
			});
		}

		// Token: 0x04001E0A RID: 7690
		private readonly global::Org.BouncyCastle.Asn1.DerInteger keyLength;

		// Token: 0x04001E0B RID: 7691
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString iv;
	}
}
