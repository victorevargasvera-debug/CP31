using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000D6 RID: 214
	public abstract class NamedGroup
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x0002080C File Offset: 0x0001EA0C
		public static bool CanBeNegotiated(int namedGroup, global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsTlsV13(version))
			{
				if ((namedGroup >= 1 && namedGroup <= 22) || (namedGroup >= 26 && namedGroup <= 28) || (namedGroup >= 34 && namedGroup <= 40) || (namedGroup >= 65281 && namedGroup <= 65282))
				{
					return false;
				}
			}
			else if ((namedGroup >= 31 && namedGroup <= 33) || namedGroup == 41)
			{
				return false;
			}
			return global::Org.BouncyCastle.Tls.NamedGroup.IsValid(namedGroup);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00020868 File Offset: 0x0001EA68
		public static int GetCurveBits(int namedGroup)
		{
			switch (namedGroup)
			{
			case 1:
			case 2:
			case 3:
				return 163;
			case 4:
			case 5:
				return 193;
			case 6:
			case 7:
				return 233;
			case 8:
				return 239;
			case 9:
			case 10:
				return 283;
			case 11:
			case 12:
				return 409;
			case 13:
			case 14:
				return 571;
			case 15:
			case 16:
			case 17:
				return 160;
			case 18:
			case 19:
				return 192;
			case 20:
			case 21:
				return 224;
			case 22:
			case 23:
			case 26:
			case 31:
			case 34:
			case 35:
			case 36:
			case 37:
			case 41:
				return 256;
			case 24:
			case 27:
			case 32:
				return 384;
			case 25:
				return 521;
			case 28:
			case 33:
			case 38:
			case 39:
			case 40:
				return 512;
			case 29:
				return 252;
			case 30:
				return 446;
			default:
				return 0;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00020984 File Offset: 0x0001EB84
		public static string GetCurveName(int namedGroup)
		{
			if (global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup))
			{
				return global::Org.BouncyCastle.Tls.NamedGroup.CurveNames[namedGroup - 1];
			}
			return null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0002099C File Offset: 0x0001EB9C
		public static int GetFiniteFieldBits(int namedGroup)
		{
			switch (namedGroup)
			{
			case 256:
				return 2048;
			case 257:
				return 3072;
			case 258:
				return 4096;
			case 259:
				return 6144;
			case 260:
				return 8192;
			default:
				return 0;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000209EA File Offset: 0x0001EBEA
		public static string GetFiniteFieldName(int namedGroup)
		{
			if (global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificFiniteField(namedGroup))
			{
				return global::Org.BouncyCastle.Tls.NamedGroup.FiniteFieldNames[namedGroup - 256];
			}
			return null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00020A03 File Offset: 0x0001EC03
		public static int GetMaximumChar2CurveBits()
		{
			return 571;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00020A0A File Offset: 0x0001EC0A
		public static int GetMaximumCurveBits()
		{
			return 571;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00020A11 File Offset: 0x0001EC11
		public static int GetMaximumFiniteFieldBits()
		{
			return 8192;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00020A18 File Offset: 0x0001EC18
		public static int GetMaximumPrimeCurveBits()
		{
			return 521;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00020A20 File Offset: 0x0001EC20
		public static string GetName(int namedGroup)
		{
			if (global::Org.BouncyCastle.Tls.NamedGroup.IsPrivate(namedGroup))
			{
				return "PRIVATE";
			}
			switch (namedGroup)
			{
			case 29:
				return "x25519";
			case 30:
				return "x448";
			case 31:
				return "brainpoolP256r1tls13";
			case 32:
				return "brainpoolP384r1tls13";
			case 33:
				return "brainpoolP512r1tls13";
			case 34:
				return "GC256A";
			case 35:
				return "GC256B";
			case 36:
				return "GC256C";
			case 37:
				return "GC256D";
			case 38:
				return "GC512A";
			case 39:
				return "GC512B";
			case 40:
				return "GC512C";
			case 41:
				return "curveSM2";
			default:
			{
				if (namedGroup == 65281)
				{
					return "arbitrary_explicit_prime_curves";
				}
				if (namedGroup == 65282)
				{
					return "arbitrary_explicit_char2_curves";
				}
				string standardName = global::Org.BouncyCastle.Tls.NamedGroup.GetStandardName(namedGroup);
				if (standardName != null)
				{
					return standardName;
				}
				return "UNKNOWN";
			}
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		public static string GetStandardName(int namedGroup)
		{
			string curveName = global::Org.BouncyCastle.Tls.NamedGroup.GetCurveName(namedGroup);
			if (curveName != null)
			{
				return curveName;
			}
			string finiteFieldName = global::Org.BouncyCastle.Tls.NamedGroup.GetFiniteFieldName(namedGroup);
			if (finiteFieldName != null)
			{
				return finiteFieldName;
			}
			return null;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00020B1E File Offset: 0x0001ED1E
		public static string GetText(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.NamedGroup.GetName(namedGroup) + "(" + namedGroup.ToString() + ")";
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00020B3C File Offset: 0x0001ED3C
		public static bool IsChar2Curve(int namedGroup)
		{
			return (namedGroup >= 1 && namedGroup <= 14) || namedGroup == 65282;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00020B51 File Offset: 0x0001ED51
		public static bool IsPrimeCurve(int namedGroup)
		{
			return (namedGroup >= 15 && namedGroup <= 41) || namedGroup == 65281;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00020B67 File Offset: 0x0001ED67
		public static bool IsPrivate(int namedGroup)
		{
			return namedGroup >> 2 == 127 || namedGroup >> 8 == 254;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00020B7C File Offset: 0x0001ED7C
		public static bool IsValid(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificGroup(namedGroup) || global::Org.BouncyCastle.Tls.NamedGroup.IsPrivate(namedGroup) || (namedGroup >= 65281 && namedGroup <= 65282);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00020BA5 File Offset: 0x0001EDA5
		public static bool RefersToAnECDHCurve(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00020BAD File Offset: 0x0001EDAD
		public static bool RefersToAnECDSACurve(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup) && !global::Org.BouncyCastle.Tls.NamedGroup.RefersToAnXDHCurve(namedGroup);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00020BC2 File Offset: 0x0001EDC2
		public static bool RefersToAnXDHCurve(int namedGroup)
		{
			return namedGroup >= 29 && namedGroup <= 30;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00020BD3 File Offset: 0x0001EDD3
		public static bool RefersToASpecificCurve(int namedGroup)
		{
			return namedGroup >= 1 && namedGroup <= 41;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00020BE3 File Offset: 0x0001EDE3
		public static bool RefersToASpecificFiniteField(int namedGroup)
		{
			return namedGroup >= 256 && namedGroup <= 260;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x00020BFA File Offset: 0x0001EDFA
		public static bool RefersToASpecificGroup(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup) || global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificFiniteField(namedGroup);
		}

		// Token: 0x040005C0 RID: 1472
		public const int sect163k1 = 1;

		// Token: 0x040005C1 RID: 1473
		public const int sect163r1 = 2;

		// Token: 0x040005C2 RID: 1474
		public const int sect163r2 = 3;

		// Token: 0x040005C3 RID: 1475
		public const int sect193r1 = 4;

		// Token: 0x040005C4 RID: 1476
		public const int sect193r2 = 5;

		// Token: 0x040005C5 RID: 1477
		public const int sect233k1 = 6;

		// Token: 0x040005C6 RID: 1478
		public const int sect233r1 = 7;

		// Token: 0x040005C7 RID: 1479
		public const int sect239k1 = 8;

		// Token: 0x040005C8 RID: 1480
		public const int sect283k1 = 9;

		// Token: 0x040005C9 RID: 1481
		public const int sect283r1 = 10;

		// Token: 0x040005CA RID: 1482
		public const int sect409k1 = 11;

		// Token: 0x040005CB RID: 1483
		public const int sect409r1 = 12;

		// Token: 0x040005CC RID: 1484
		public const int sect571k1 = 13;

		// Token: 0x040005CD RID: 1485
		public const int sect571r1 = 14;

		// Token: 0x040005CE RID: 1486
		public const int secp160k1 = 15;

		// Token: 0x040005CF RID: 1487
		public const int secp160r1 = 16;

		// Token: 0x040005D0 RID: 1488
		public const int secp160r2 = 17;

		// Token: 0x040005D1 RID: 1489
		public const int secp192k1 = 18;

		// Token: 0x040005D2 RID: 1490
		public const int secp192r1 = 19;

		// Token: 0x040005D3 RID: 1491
		public const int secp224k1 = 20;

		// Token: 0x040005D4 RID: 1492
		public const int secp224r1 = 21;

		// Token: 0x040005D5 RID: 1493
		public const int secp256k1 = 22;

		// Token: 0x040005D6 RID: 1494
		public const int secp256r1 = 23;

		// Token: 0x040005D7 RID: 1495
		public const int secp384r1 = 24;

		// Token: 0x040005D8 RID: 1496
		public const int secp521r1 = 25;

		// Token: 0x040005D9 RID: 1497
		public const int brainpoolP256r1 = 26;

		// Token: 0x040005DA RID: 1498
		public const int brainpoolP384r1 = 27;

		// Token: 0x040005DB RID: 1499
		public const int brainpoolP512r1 = 28;

		// Token: 0x040005DC RID: 1500
		public const int x25519 = 29;

		// Token: 0x040005DD RID: 1501
		public const int x448 = 30;

		// Token: 0x040005DE RID: 1502
		public const int brainpoolP256r1tls13 = 31;

		// Token: 0x040005DF RID: 1503
		public const int brainpoolP384r1tls13 = 32;

		// Token: 0x040005E0 RID: 1504
		public const int brainpoolP512r1tls13 = 33;

		// Token: 0x040005E1 RID: 1505
		public const int GC256A = 34;

		// Token: 0x040005E2 RID: 1506
		public const int GC256B = 35;

		// Token: 0x040005E3 RID: 1507
		public const int GC256C = 36;

		// Token: 0x040005E4 RID: 1508
		public const int GC256D = 37;

		// Token: 0x040005E5 RID: 1509
		public const int GC512A = 38;

		// Token: 0x040005E6 RID: 1510
		public const int GC512B = 39;

		// Token: 0x040005E7 RID: 1511
		public const int GC512C = 40;

		// Token: 0x040005E8 RID: 1512
		public const int curveSM2 = 41;

		// Token: 0x040005E9 RID: 1513
		public const int ffdhe2048 = 256;

		// Token: 0x040005EA RID: 1514
		public const int ffdhe3072 = 257;

		// Token: 0x040005EB RID: 1515
		public const int ffdhe4096 = 258;

		// Token: 0x040005EC RID: 1516
		public const int ffdhe6144 = 259;

		// Token: 0x040005ED RID: 1517
		public const int ffdhe8192 = 260;

		// Token: 0x040005EE RID: 1518
		public const int arbitrary_explicit_prime_curves = 65281;

		// Token: 0x040005EF RID: 1519
		public const int arbitrary_explicit_char2_curves = 65282;

		// Token: 0x040005F0 RID: 1520
		private static readonly string[] CurveNames = new string[]
		{
			"sect163k1",
			"sect163r1",
			"sect163r2",
			"sect193r1",
			"sect193r2",
			"sect233k1",
			"sect233r1",
			"sect239k1",
			"sect283k1",
			"sect283r1",
			"sect409k1",
			"sect409r1",
			"sect571k1",
			"sect571r1",
			"secp160k1",
			"secp160r1",
			"secp160r2",
			"secp192k1",
			"secp192r1",
			"secp224k1",
			"secp224r1",
			"secp256k1",
			"secp256r1",
			"secp384r1",
			"secp521r1",
			"brainpoolP256r1",
			"brainpoolP384r1",
			"brainpoolP512r1",
			"X25519",
			"X448",
			"brainpoolP256r1",
			"brainpoolP384r1",
			"brainpoolP512r1",
			"Tc26-Gost-3410-12-256-paramSetA",
			"GostR3410-2001-CryptoPro-A",
			"GostR3410-2001-CryptoPro-B",
			"GostR3410-2001-CryptoPro-C",
			"Tc26-Gost-3410-12-512-paramSetA",
			"Tc26-Gost-3410-12-512-paramSetB",
			"Tc26-Gost-3410-12-512-paramSetC",
			"sm2p256v1"
		};

		// Token: 0x040005F1 RID: 1521
		private static readonly string[] FiniteFieldNames = new string[]
		{
			"ffdhe2048",
			"ffdhe3072",
			"ffdhe4096",
			"ffdhe6144",
			"ffdhe8192"
		};
	}
}
