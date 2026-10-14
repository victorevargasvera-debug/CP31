using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000667 RID: 1639
	public class ReasonFlags : global::Org.BouncyCastle.Asn1.DerBitString
	{
		// Token: 0x06003C7F RID: 15487 RVA: 0x00114DC8 File Offset: 0x00112FC8
		public ReasonFlags(int reasons) : base(reasons)
		{
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x00114DD1 File Offset: 0x00112FD1
		public ReasonFlags(global::Org.BouncyCastle.Asn1.DerBitString reasons) : base(reasons.GetBytes(), reasons.PadBits)
		{
		}

		// Token: 0x04001AB4 RID: 6836
		public const int Unused = 128;

		// Token: 0x04001AB5 RID: 6837
		public const int KeyCompromise = 64;

		// Token: 0x04001AB6 RID: 6838
		public const int CACompromise = 32;

		// Token: 0x04001AB7 RID: 6839
		public const int AffiliationChanged = 16;

		// Token: 0x04001AB8 RID: 6840
		public const int Superseded = 8;

		// Token: 0x04001AB9 RID: 6841
		public const int CessationOfOperation = 4;

		// Token: 0x04001ABA RID: 6842
		public const int CertificateHold = 2;

		// Token: 0x04001ABB RID: 6843
		public const int PrivilegeWithdrawn = 1;

		// Token: 0x04001ABC RID: 6844
		public const int AACompromise = 32768;
	}
}
