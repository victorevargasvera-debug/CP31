using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D1 RID: 209
	public abstract class KeyExchangeAlgorithm
	{
		// Token: 0x04000596 RID: 1430
		public const int NULL = 0;

		// Token: 0x04000597 RID: 1431
		public const int RSA = 1;

		// Token: 0x04000598 RID: 1432
		public const int RSA_EXPORT = 2;

		// Token: 0x04000599 RID: 1433
		public const int DHE_DSS = 3;

		// Token: 0x0400059A RID: 1434
		public const int DHE_DSS_EXPORT = 4;

		// Token: 0x0400059B RID: 1435
		public const int DHE_RSA = 5;

		// Token: 0x0400059C RID: 1436
		public const int DHE_RSA_EXPORT = 6;

		// Token: 0x0400059D RID: 1437
		public const int DH_DSS = 7;

		// Token: 0x0400059E RID: 1438
		public const int DH_DSS_EXPORT = 8;

		// Token: 0x0400059F RID: 1439
		public const int DH_RSA = 9;

		// Token: 0x040005A0 RID: 1440
		public const int DH_RSA_EXPORT = 10;

		// Token: 0x040005A1 RID: 1441
		public const int DH_anon = 11;

		// Token: 0x040005A2 RID: 1442
		public const int DH_anon_EXPORT = 12;

		// Token: 0x040005A3 RID: 1443
		public const int PSK = 13;

		// Token: 0x040005A4 RID: 1444
		public const int DHE_PSK = 14;

		// Token: 0x040005A5 RID: 1445
		public const int RSA_PSK = 15;

		// Token: 0x040005A6 RID: 1446
		public const int ECDH_ECDSA = 16;

		// Token: 0x040005A7 RID: 1447
		public const int ECDHE_ECDSA = 17;

		// Token: 0x040005A8 RID: 1448
		public const int ECDH_RSA = 18;

		// Token: 0x040005A9 RID: 1449
		public const int ECDHE_RSA = 19;

		// Token: 0x040005AA RID: 1450
		public const int ECDH_anon = 20;

		// Token: 0x040005AB RID: 1451
		public const int SRP = 21;

		// Token: 0x040005AC RID: 1452
		public const int SRP_DSS = 22;

		// Token: 0x040005AD RID: 1453
		public const int SRP_RSA = 23;

		// Token: 0x040005AE RID: 1454
		public const int ECDHE_PSK = 24;

		// Token: 0x040005AF RID: 1455
		public const int SM2 = 25;
	}
}
