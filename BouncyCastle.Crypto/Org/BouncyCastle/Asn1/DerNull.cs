using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200060D RID: 1549
	public class DerNull : global::Org.BouncyCastle.Asn1.Asn1Null
	{
		// Token: 0x060039EB RID: 14827 RVA: 0x0010DAF6 File Offset: 0x0010BCF6
		protected internal DerNull()
		{
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x0010DAFE File Offset: 0x0010BCFE
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, 0);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0010DB07 File Offset: 0x0010BD07
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 5, global::Org.BouncyCastle.Asn1.DerNull.ZeroBytes);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x0010DB16 File Offset: 0x0010BD16
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			return asn1Object is global::Org.BouncyCastle.Asn1.DerNull;
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x0010DB21 File Offset: 0x0010BD21
		protected override int Asn1GetHashCode()
		{
			return -1;
		}

		// Token: 0x0400199D RID: 6557
		public static readonly global::Org.BouncyCastle.Asn1.DerNull Instance = new global::Org.BouncyCastle.Asn1.DerNull();

		// Token: 0x0400199E RID: 6558
		private static readonly byte[] ZeroBytes = new byte[0];
	}
}
