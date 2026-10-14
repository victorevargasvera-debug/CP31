using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200064E RID: 1614
	public class CrlReason : global::Org.BouncyCastle.Asn1.DerEnumerated
	{
		// Token: 0x06003BBC RID: 15292 RVA: 0x00112539 File Offset: 0x00110739
		public CrlReason(int reason) : base(reason)
		{
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00112542 File Offset: 0x00110742
		public CrlReason(global::Org.BouncyCastle.Asn1.DerEnumerated reason) : base(reason.IntValueExact)
		{
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00112550 File Offset: 0x00110750
		public override string ToString()
		{
			int reason = base.IntValueExact;
			string str = (reason < 0 || reason > 10) ? "Invalid" : global::Org.BouncyCastle.Asn1.X509.CrlReason.ReasonString[reason];
			return "CrlReason: " + str;
		}

		// Token: 0x04001A44 RID: 6724
		public const int Unspecified = 0;

		// Token: 0x04001A45 RID: 6725
		public const int KeyCompromise = 1;

		// Token: 0x04001A46 RID: 6726
		public const int CACompromise = 2;

		// Token: 0x04001A47 RID: 6727
		public const int AffiliationChanged = 3;

		// Token: 0x04001A48 RID: 6728
		public const int Superseded = 4;

		// Token: 0x04001A49 RID: 6729
		public const int CessationOfOperation = 5;

		// Token: 0x04001A4A RID: 6730
		public const int CertificateHold = 6;

		// Token: 0x04001A4B RID: 6731
		public const int RemoveFromCrl = 8;

		// Token: 0x04001A4C RID: 6732
		public const int PrivilegeWithdrawn = 9;

		// Token: 0x04001A4D RID: 6733
		public const int AACompromise = 10;

		// Token: 0x04001A4E RID: 6734
		private static readonly string[] ReasonString = new string[]
		{
			"Unspecified",
			"KeyCompromise",
			"CACompromise",
			"AffiliationChanged",
			"Superseded",
			"CessationOfOperation",
			"CertificateHold",
			"Unknown",
			"RemoveFromCrl",
			"PrivilegeWithdrawn",
			"AACompromise"
		};
	}
}
