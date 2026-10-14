using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000629 RID: 1577
	internal class LazyDerSequence : global::Org.BouncyCastle.Asn1.DerSequence
	{
		// Token: 0x06003AA8 RID: 15016 RVA: 0x0010F399 File Offset: 0x0010D599
		internal LazyDerSequence(byte[] encoded)
		{
			if (encoded == null)
			{
				throw new global::System.ArgumentNullException("encoded");
			}
			this.encoded = encoded;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x0010F3B8 File Offset: 0x0010D5B8
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

		// Token: 0x170007B5 RID: 1973
		public override global::Org.BouncyCastle.Asn1.Asn1Encodable this[int index]
		{
			get
			{
				this.Parse();
				return base[index];
			}
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x0010F42B File Offset: 0x0010D62B
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			this.Parse();
			return base.GetEnumerator();
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06003AAC RID: 15020 RVA: 0x0010F439 File Offset: 0x0010D639
		public override int Count
		{
			get
			{
				this.Parse();
				return base.Count;
			}
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x0010F448 File Offset: 0x0010D648
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

		// Token: 0x06003AAE RID: 15022 RVA: 0x0010F4A0 File Offset: 0x0010D6A0
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
					asn1Out.WriteEncodingDL(withID, 48, this.encoded);
				}
			}
		}

		// Token: 0x040019B5 RID: 6581
		private byte[] encoded;
	}
}
