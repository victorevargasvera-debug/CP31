using System;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006CC RID: 1740
	public class OcspResponseStatus : global::Org.BouncyCastle.Asn1.DerEnumerated
	{
		// Token: 0x06003F8B RID: 16267 RVA: 0x0012090E File Offset: 0x0011EB0E
		public OcspResponseStatus(int value) : base(value)
		{
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x00120917 File Offset: 0x0011EB17
		public OcspResponseStatus(global::Org.BouncyCastle.Asn1.DerEnumerated value) : base(value.IntValueExact)
		{
		}

		// Token: 0x04001D6F RID: 7535
		public const int Successful = 0;

		// Token: 0x04001D70 RID: 7536
		public const int MalformedRequest = 1;

		// Token: 0x04001D71 RID: 7537
		public const int InternalError = 2;

		// Token: 0x04001D72 RID: 7538
		public const int TryLater = 3;

		// Token: 0x04001D73 RID: 7539
		public const int SignatureRequired = 5;

		// Token: 0x04001D74 RID: 7540
		public const int Unauthorized = 6;
	}
}
