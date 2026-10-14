using System;

namespace Org.BouncyCastle.Asn1.Icao
{
	// Token: 0x020006F2 RID: 1778
	public class DataGroupHash : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004072 RID: 16498 RVA: 0x00124599 File Offset: 0x00122799
		public static global::Org.BouncyCastle.Asn1.Icao.DataGroupHash GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Icao.DataGroupHash)
			{
				return (global::Org.BouncyCastle.Asn1.Icao.DataGroupHash)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Icao.DataGroupHash(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06004073 RID: 16499 RVA: 0x001245BC File Offset: 0x001227BC
		private DataGroupHash(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.dataGroupNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.dataGroupHashValue = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]);
		}

		// Token: 0x06004074 RID: 16500 RVA: 0x0012460C File Offset: 0x0012280C
		public DataGroupHash(int dataGroupNumber, global::Org.BouncyCastle.Asn1.Asn1OctetString dataGroupHashValue)
		{
			this.dataGroupNumber = new global::Org.BouncyCastle.Asn1.DerInteger(dataGroupNumber);
			this.dataGroupHashValue = dataGroupHashValue;
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06004075 RID: 16501 RVA: 0x00124627 File Offset: 0x00122827
		public int DataGroupNumber
		{
			get
			{
				return this.dataGroupNumber.IntValueExact;
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x00124634 File Offset: 0x00122834
		public global::Org.BouncyCastle.Asn1.Asn1OctetString DataGroupHashValue
		{
			get
			{
				return this.dataGroupHashValue;
			}
		}

		// Token: 0x06004077 RID: 16503 RVA: 0x0012463C File Offset: 0x0012283C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.dataGroupNumber,
				this.dataGroupHashValue
			});
		}

		// Token: 0x04001E8B RID: 7819
		private readonly global::Org.BouncyCastle.Asn1.DerInteger dataGroupNumber;

		// Token: 0x04001E8C RID: 7820
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString dataGroupHashValue;
	}
}
