using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200070B RID: 1803
	public class CrlValidatedID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600410C RID: 16652 RVA: 0x00126BF8 File Offset: 0x00124DF8
		public static global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CrlValidatedID((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CrlValidatedID' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00126C48 File Offset: 0x00124E48
		private CrlValidatedID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count < 1 || seq.Count > 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.crlHash = global::Org.BouncyCastle.Asn1.Esf.OtherHash.GetInstance(seq[0].ToAsn1Object());
			if (seq.Count > 1)
			{
				this.crlIdentifier = global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier.GetInstance(seq[1].ToAsn1Object());
			}
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00126CD5 File Offset: 0x00124ED5
		public CrlValidatedID(global::Org.BouncyCastle.Asn1.Esf.OtherHash crlHash) : this(crlHash, null)
		{
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00126CDF File Offset: 0x00124EDF
		public CrlValidatedID(global::Org.BouncyCastle.Asn1.Esf.OtherHash crlHash, global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier crlIdentifier)
		{
			if (crlHash == null)
			{
				throw new global::System.ArgumentNullException("crlHash");
			}
			this.crlHash = crlHash;
			this.crlIdentifier = crlIdentifier;
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06004110 RID: 16656 RVA: 0x00126D03 File Offset: 0x00124F03
		public global::Org.BouncyCastle.Asn1.Esf.OtherHash CrlHash
		{
			get
			{
				return this.crlHash;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x00126D0B File Offset: 0x00124F0B
		public global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier CrlIdentifier
		{
			get
			{
				return this.crlIdentifier;
			}
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00126D14 File Offset: 0x00124F14
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.crlHash.ToAsn1Object()
			});
			if (this.crlIdentifier != null)
			{
				v.Add(this.crlIdentifier.ToAsn1Object());
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F25 RID: 7973
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherHash crlHash;

		// Token: 0x04001F26 RID: 7974
		private readonly global::Org.BouncyCastle.Asn1.Esf.CrlIdentifier crlIdentifier;
	}
}
