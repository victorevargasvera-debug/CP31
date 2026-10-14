using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000712 RID: 1810
	public class OtherHashAlgAndValue : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004136 RID: 16694 RVA: 0x001274C0 File Offset: 0x001256C0
		public static global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OtherHashAlgAndValue' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x00127510 File Offset: 0x00125710
		private OtherHashAlgAndValue(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0].ToAsn1Object());
			this.hashValue = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[1].ToAsn1Object();
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0012758B File Offset: 0x0012578B
		public OtherHashAlgAndValue(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, byte[] hashValue)
		{
			if (hashAlgorithm == null)
			{
				throw new global::System.ArgumentNullException("hashAlgorithm");
			}
			if (hashValue == null)
			{
				throw new global::System.ArgumentNullException("hashValue");
			}
			this.hashAlgorithm = hashAlgorithm;
			this.hashValue = new global::Org.BouncyCastle.Asn1.DerOctetString(hashValue);
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x001275C2 File Offset: 0x001257C2
		public OtherHashAlgAndValue(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString hashValue)
		{
			if (hashAlgorithm == null)
			{
				throw new global::System.ArgumentNullException("hashAlgorithm");
			}
			if (hashValue == null)
			{
				throw new global::System.ArgumentNullException("hashValue");
			}
			this.hashAlgorithm = hashAlgorithm;
			this.hashValue = hashValue;
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x001275F4 File Offset: 0x001257F4
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x001275FC File Offset: 0x001257FC
		public byte[] GetHashValue()
		{
			return this.hashValue.GetOctets();
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x00127609 File Offset: 0x00125809
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.hashAlgorithm,
				this.hashValue
			});
		}

		// Token: 0x04001F3E RID: 7998
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001F3F RID: 7999
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString hashValue;
	}
}
