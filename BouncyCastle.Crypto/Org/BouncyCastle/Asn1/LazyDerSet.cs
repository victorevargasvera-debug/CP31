using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200062A RID: 1578
	internal class LazyDerSet : global::Org.BouncyCastle.Asn1.DerSet
	{
		// Token: 0x06003AAF RID: 15023 RVA: 0x0010F4F8 File Offset: 0x0010D6F8
		internal LazyDerSet(byte[] encoded)
		{
			if (encoded == null)
			{
				throw new global::System.ArgumentNullException("encoded");
			}
			this.encoded = encoded;
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x0010F518 File Offset: 0x0010D718
		private void Parse()
		{
			lock (this)
			{
				if (this.encoded != null)
				{
					global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.LazyAsn1InputStream(this.encoded).ReadVector();
					this.elements = v.TakeElements();
					this.encoded = null;
				}
			}
		}

		// Token: 0x170007B7 RID: 1975
		public override global::Org.BouncyCastle.Asn1.Asn1Encodable this[int index]
		{
			get
			{
				this.Parse();
				return base[index];
			}
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x0010F58B File Offset: 0x0010D78B
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			this.Parse();
			return base.GetEnumerator();
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x0010F599 File Offset: 0x0010D799
		public override int Count
		{
			get
			{
				this.Parse();
				return base.Count;
			}
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x0010F5A8 File Offset: 0x0010D7A8
		internal override int EncodedLength(bool withID)
		{
			int result;
			lock (this)
			{
				if (this.encoded == null)
				{
					result = base.EncodedLength(withID);
				}
				else
				{
					result = global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.encoded.Length);
				}
			}
			return result;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x0010F600 File Offset: 0x0010D800
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			lock (this)
			{
				if (this.encoded == null)
				{
					base.Encode(asn1Out, withID);
				}
				else
				{
					asn1Out.WriteEncodingDL(withID, 49, this.encoded);
				}
			}
		}

		// Token: 0x040019B6 RID: 6582
		private byte[] encoded;
	}
}
