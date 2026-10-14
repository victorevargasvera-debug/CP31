using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200033B RID: 827
	public abstract class NamedCurve
	{
		// Token: 0x06002239 RID: 8761 RVA: 0x000977FF File Offset: 0x000959FF
		public static bool IsValid(int namedCurve)
		{
			return (namedCurve >= 1 && namedCurve <= 28) || (namedCurve >= 65281 && namedCurve <= 65282);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00097821 File Offset: 0x00095A21
		public static bool RefersToASpecificNamedCurve(int namedCurve)
		{
			return namedCurve - 65281 > 1;
		}

		// Token: 0x04000DA5 RID: 3493
		public const int sect163k1 = 1;

		// Token: 0x04000DA6 RID: 3494
		public const int sect163r1 = 2;

		// Token: 0x04000DA7 RID: 3495
		public const int sect163r2 = 3;

		// Token: 0x04000DA8 RID: 3496
		public const int sect193r1 = 4;

		// Token: 0x04000DA9 RID: 3497
		public const int sect193r2 = 5;

		// Token: 0x04000DAA RID: 3498
		public const int sect233k1 = 6;

		// Token: 0x04000DAB RID: 3499
		public const int sect233r1 = 7;

		// Token: 0x04000DAC RID: 3500
		public const int sect239k1 = 8;

		// Token: 0x04000DAD RID: 3501
		public const int sect283k1 = 9;

		// Token: 0x04000DAE RID: 3502
		public const int sect283r1 = 10;

		// Token: 0x04000DAF RID: 3503
		public const int sect409k1 = 11;

		// Token: 0x04000DB0 RID: 3504
		public const int sect409r1 = 12;

		// Token: 0x04000DB1 RID: 3505
		public const int sect571k1 = 13;

		// Token: 0x04000DB2 RID: 3506
		public const int sect571r1 = 14;

		// Token: 0x04000DB3 RID: 3507
		public const int secp160k1 = 15;

		// Token: 0x04000DB4 RID: 3508
		public const int secp160r1 = 16;

		// Token: 0x04000DB5 RID: 3509
		public const int secp160r2 = 17;

		// Token: 0x04000DB6 RID: 3510
		public const int secp192k1 = 18;

		// Token: 0x04000DB7 RID: 3511
		public const int secp192r1 = 19;

		// Token: 0x04000DB8 RID: 3512
		public const int secp224k1 = 20;

		// Token: 0x04000DB9 RID: 3513
		public const int secp224r1 = 21;

		// Token: 0x04000DBA RID: 3514
		public const int secp256k1 = 22;

		// Token: 0x04000DBB RID: 3515
		public const int secp256r1 = 23;

		// Token: 0x04000DBC RID: 3516
		public const int secp384r1 = 24;

		// Token: 0x04000DBD RID: 3517
		public const int secp521r1 = 25;

		// Token: 0x04000DBE RID: 3518
		public const int brainpoolP256r1 = 26;

		// Token: 0x04000DBF RID: 3519
		public const int brainpoolP384r1 = 27;

		// Token: 0x04000DC0 RID: 3520
		public const int brainpoolP512r1 = 28;

		// Token: 0x04000DC1 RID: 3521
		public const int arbitrary_explicit_prime_curves = 65281;

		// Token: 0x04000DC2 RID: 3522
		public const int arbitrary_explicit_char2_curves = 65282;
	}
}
