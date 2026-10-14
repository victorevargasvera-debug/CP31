using System;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x0200073A RID: 1850
	public class SubsequentMessage : global::Org.BouncyCastle.Asn1.DerInteger
	{
		// Token: 0x06004250 RID: 16976 RVA: 0x0012AEC9 File Offset: 0x001290C9
		private SubsequentMessage(int value) : base(value)
		{
		}

		// Token: 0x06004251 RID: 16977 RVA: 0x0012AED2 File Offset: 0x001290D2
		public static global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage ValueOf(int value)
		{
			if (value == 0)
			{
				return global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage.encrCert;
			}
			if (value == 1)
			{
				return global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage.challengeResp;
			}
			throw new global::System.ArgumentException("unknown value: " + value.ToString(), "value");
		}

		// Token: 0x04001FEF RID: 8175
		public static readonly global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage encrCert = new global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage(0);

		// Token: 0x04001FF0 RID: 8176
		public static readonly global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage challengeResp = new global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage(1);
	}
}
