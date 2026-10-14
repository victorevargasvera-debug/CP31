using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200010D RID: 269
	public abstract class TlsExtensionsUtilities
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x00026351 File Offset: 0x00024551
		public static global::System.Collections.IDictionary EnsureExtensionsInitialised(global::System.Collections.IDictionary extensions)
		{
			if (extensions != null)
			{
				return extensions;
			}
			return global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0002635D File Offset: 0x0002455D
		public static void AddAlpnExtensionClient(global::System.Collections.IDictionary extensions, global::System.Collections.IList protocolNameList)
		{
			extensions[16] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateAlpnExtensionClient(protocolNameList);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00026372 File Offset: 0x00024572
		public static void AddAlpnExtensionServer(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.ProtocolName protocolName)
		{
			extensions[16] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateAlpnExtensionServer(protocolName);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00026387 File Offset: 0x00024587
		public static void AddCertificateAuthoritiesExtension(global::System.Collections.IDictionary extensions, global::System.Collections.IList authorities)
		{
			extensions[47] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateCertificateAuthoritiesExtension(authorities);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002639C File Offset: 0x0002459C
		public static void AddClientCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions, short[] certificateTypes)
		{
			extensions[19] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionClient(certificateTypes);
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x000263B1 File Offset: 0x000245B1
		public static void AddClientCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions, short certificateType)
		{
			extensions[19] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionServer(certificateType);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000263C6 File Offset: 0x000245C6
		public static void AddClientCertificateUrlExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[2] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateClientCertificateUrlExtension();
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x000263D9 File Offset: 0x000245D9
		public static void AddCookieExtension(global::System.Collections.IDictionary extensions, byte[] cookie)
		{
			extensions[44] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateCookieExtension(cookie);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x000263EE File Offset: 0x000245EE
		public static void AddEarlyDataIndication(global::System.Collections.IDictionary extensions)
		{
			extensions[42] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEarlyDataIndication();
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00026402 File Offset: 0x00024602
		public static void AddEarlyDataMaxSize(global::System.Collections.IDictionary extensions, long maxSize)
		{
			extensions[42] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEarlyDataMaxSize(maxSize);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00026417 File Offset: 0x00024617
		public static void AddEmptyExtensionData(global::System.Collections.IDictionary extensions, int extType)
		{
			extensions[extType] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0002642A File Offset: 0x0002462A
		public static void AddEncryptThenMacExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[22] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEncryptThenMacExtension();
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002643E File Offset: 0x0002463E
		public static void AddExtendedMasterSecretExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[23] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateExtendedMasterSecretExtension();
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00026452 File Offset: 0x00024652
		public static void AddHeartbeatExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.HeartbeatExtension heartbeatExtension)
		{
			extensions[15] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateHeartbeatExtension(heartbeatExtension);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00026467 File Offset: 0x00024667
		public static void AddKeyShareClientHello(global::System.Collections.IDictionary extensions, global::System.Collections.IList clientShares)
		{
			extensions[51] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateKeyShareClientHello(clientShares);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002647C File Offset: 0x0002467C
		public static void AddKeyShareHelloRetryRequest(global::System.Collections.IDictionary extensions, int namedGroup)
		{
			extensions[51] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateKeyShareHelloRetryRequest(namedGroup);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00026491 File Offset: 0x00024691
		public static void AddKeyShareServerHello(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.KeyShareEntry serverShare)
		{
			extensions[51] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateKeyShareServerHello(serverShare);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000264A6 File Offset: 0x000246A6
		public static void AddMaxFragmentLengthExtension(global::System.Collections.IDictionary extensions, short maxFragmentLength)
		{
			extensions[1] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateMaxFragmentLengthExtension(maxFragmentLength);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000264BA File Offset: 0x000246BA
		public static void AddOidFiltersExtension(global::System.Collections.IDictionary extensions, global::System.Collections.IDictionary filters)
		{
			extensions[48] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateOidFiltersExtension(filters);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000264CF File Offset: 0x000246CF
		public static void AddPaddingExtension(global::System.Collections.IDictionary extensions, int dataLength)
		{
			extensions[21] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreatePaddingExtension(dataLength);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000264E4 File Offset: 0x000246E4
		public static void AddPostHandshakeAuthExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[49] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreatePostHandshakeAuthExtension();
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x000264F8 File Offset: 0x000246F8
		public static void AddPreSharedKeyClientHello(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.OfferedPsks offeredPsks)
		{
			extensions[41] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreatePreSharedKeyClientHello(offeredPsks);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002650D File Offset: 0x0002470D
		public static void AddPreSharedKeyServerHello(global::System.Collections.IDictionary extensions, int selectedIdentity)
		{
			extensions[41] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreatePreSharedKeyServerHello(selectedIdentity);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00026522 File Offset: 0x00024722
		public static void AddPskKeyExchangeModesExtension(global::System.Collections.IDictionary extensions, short[] modes)
		{
			extensions[45] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreatePskKeyExchangeModesExtension(modes);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00026537 File Offset: 0x00024737
		public static void AddRecordSizeLimitExtension(global::System.Collections.IDictionary extensions, int recordSizeLimit)
		{
			extensions[28] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateRecordSizeLimitExtension(recordSizeLimit);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0002654C File Offset: 0x0002474C
		public static void AddServerCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions, short[] certificateTypes)
		{
			extensions[20] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionClient(certificateTypes);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00026561 File Offset: 0x00024761
		public static void AddServerCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions, short certificateType)
		{
			extensions[20] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionServer(certificateType);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00026576 File Offset: 0x00024776
		public static void AddServerNameExtensionClient(global::System.Collections.IDictionary extensions, global::System.Collections.IList serverNameList)
		{
			extensions[0] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateServerNameExtensionClient(serverNameList);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002658A File Offset: 0x0002478A
		public static void AddServerNameExtensionServer(global::System.Collections.IDictionary extensions)
		{
			extensions[0] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateServerNameExtensionServer();
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002659D File Offset: 0x0002479D
		public static void AddSignatureAlgorithmsExtension(global::System.Collections.IDictionary extensions, global::System.Collections.IList supportedSignatureAlgorithms)
		{
			extensions[13] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000265B2 File Offset: 0x000247B2
		public static void AddSignatureAlgorithmsCertExtension(global::System.Collections.IDictionary extensions, global::System.Collections.IList supportedSignatureAlgorithms)
		{
			extensions[50] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSignatureAlgorithmsCertExtension(supportedSignatureAlgorithms);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000265C7 File Offset: 0x000247C7
		public static void AddStatusRequestExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.CertificateStatusRequest statusRequest)
		{
			extensions[5] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateStatusRequestExtension(statusRequest);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000265DB File Offset: 0x000247DB
		public static void AddStatusRequestV2Extension(global::System.Collections.IDictionary extensions, global::System.Collections.IList statusRequestV2)
		{
			extensions[17] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateStatusRequestV2Extension(statusRequestV2);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000265F0 File Offset: 0x000247F0
		public static void AddSupportedGroupsExtension(global::System.Collections.IDictionary extensions, global::System.Collections.IList namedGroups)
		{
			extensions[10] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSupportedGroupsExtension(namedGroups);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00026605 File Offset: 0x00024805
		public static void AddSupportedPointFormatsExtension(global::System.Collections.IDictionary extensions, short[] ecPointFormats)
		{
			extensions[11] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSupportedPointFormatsExtension(ecPointFormats);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0002661A File Offset: 0x0002481A
		public static void AddSupportedVersionsExtensionClient(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.ProtocolVersion[] versions)
		{
			extensions[43] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSupportedVersionsExtensionClient(versions);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002662F File Offset: 0x0002482F
		public static void AddSupportedVersionsExtensionServer(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.ProtocolVersion selectedVersion)
		{
			extensions[43] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSupportedVersionsExtensionServer(selectedVersion);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00026644 File Offset: 0x00024844
		public static void AddTruncatedHmacExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[4] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateTruncatedHmacExtension();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00026657 File Offset: 0x00024857
		public static void AddTrustedCAKeysExtensionClient(global::System.Collections.IDictionary extensions, global::System.Collections.IList trustedAuthoritiesList)
		{
			extensions[3] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateTrustedCAKeysExtensionClient(trustedAuthoritiesList);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002666B File Offset: 0x0002486B
		public static void AddTrustedCAKeysExtensionServer(global::System.Collections.IDictionary extensions)
		{
			extensions[3] = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateTrustedCAKeysExtensionServer();
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00026680 File Offset: 0x00024880
		public static global::System.Collections.IList GetAlpnExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 16);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadAlpnExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000266A4 File Offset: 0x000248A4
		public static global::Org.BouncyCastle.Tls.ProtocolName GetAlpnExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 16);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadAlpnExtensionServer(extensionData);
			}
			return null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000266C8 File Offset: 0x000248C8
		public static global::System.Collections.IList GetCertificateAuthoritiesExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 47);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadCertificateAuthoritiesExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000266EC File Offset: 0x000248EC
		public static short[] GetClientCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 19);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00026710 File Offset: 0x00024910
		public static short GetClientCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 19);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionServer(extensionData);
			}
			return -1;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00026734 File Offset: 0x00024934
		public static byte[] GetCookieExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 44);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadCookieExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00026758 File Offset: 0x00024958
		public static long GetEarlyDataMaxSize(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 42);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEarlyDataMaxSize(extensionData);
			}
			return -1L;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0002677C File Offset: 0x0002497C
		public static global::Org.BouncyCastle.Tls.HeartbeatExtension GetHeartbeatExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 15);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadHeartbeatExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000267A0 File Offset: 0x000249A0
		public static global::System.Collections.IList GetKeyShareClientHello(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 51);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadKeyShareClientHello(extensionData);
			}
			return null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000267C4 File Offset: 0x000249C4
		public static int GetKeyShareHelloRetryRequest(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 51);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadKeyShareHelloRetryRequest(extensionData);
			}
			return -1;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000267E8 File Offset: 0x000249E8
		public static global::Org.BouncyCastle.Tls.KeyShareEntry GetKeyShareServerHello(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 51);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadKeyShareServerHello(extensionData);
			}
			return null;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002680C File Offset: 0x00024A0C
		public static short GetMaxFragmentLengthExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 1);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadMaxFragmentLengthExtension(extensionData);
			}
			return -1;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0002682C File Offset: 0x00024A2C
		public static global::System.Collections.IDictionary GetOidFiltersExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 48);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadOidFiltersExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00026850 File Offset: 0x00024A50
		public static int GetPaddingExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 21);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadPaddingExtension(extensionData);
			}
			return -1;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00026874 File Offset: 0x00024A74
		public static global::Org.BouncyCastle.Tls.OfferedPsks GetPreSharedKeyClientHello(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 41);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadPreSharedKeyClientHello(extensionData);
			}
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00026898 File Offset: 0x00024A98
		public static int GetPreSharedKeyServerHello(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 41);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadPreSharedKeyServerHello(extensionData);
			}
			return -1;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000268BC File Offset: 0x00024ABC
		public static short[] GetPskKeyExchangeModesExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 45);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadPskKeyExchangeModesExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x000268E0 File Offset: 0x00024AE0
		public static int GetRecordSizeLimitExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 28);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadRecordSizeLimitExtension(extensionData);
			}
			return -1;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00026904 File Offset: 0x00024B04
		public static short[] GetServerCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 20);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00026928 File Offset: 0x00024B28
		public static short GetServerCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 20);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionServer(extensionData);
			}
			return -1;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002694C File Offset: 0x00024B4C
		public static global::System.Collections.IList GetServerNameExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 0);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadServerNameExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002696C File Offset: 0x00024B6C
		public static global::System.Collections.IList GetSignatureAlgorithmsExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 13);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSignatureAlgorithmsExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00026990 File Offset: 0x00024B90
		public static global::System.Collections.IList GetSignatureAlgorithmsCertExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 50);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSignatureAlgorithmsCertExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000269B4 File Offset: 0x00024BB4
		public static global::Org.BouncyCastle.Tls.CertificateStatusRequest GetStatusRequestExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 5);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadStatusRequestExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000269D4 File Offset: 0x00024BD4
		public static global::System.Collections.IList GetStatusRequestV2Extension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 17);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadStatusRequestV2Extension(extensionData);
			}
			return null;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000269F8 File Offset: 0x00024BF8
		public static int[] GetSupportedGroupsExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 10);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSupportedGroupsExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00026A1C File Offset: 0x00024C1C
		public static short[] GetSupportedPointFormatsExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 11);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSupportedPointFormatsExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00026A40 File Offset: 0x00024C40
		public static global::Org.BouncyCastle.Tls.ProtocolVersion[] GetSupportedVersionsExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 43);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSupportedVersionsExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00026A64 File Offset: 0x00024C64
		public static global::Org.BouncyCastle.Tls.ProtocolVersion GetSupportedVersionsExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 43);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSupportedVersionsExtensionServer(extensionData);
			}
			return null;
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00026A88 File Offset: 0x00024C88
		public static global::System.Collections.IList GetTrustedCAKeysExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 3);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadTrustedCAKeysExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00026AA8 File Offset: 0x00024CA8
		public static bool HasClientCertificateUrlExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 2);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadClientCertificateUrlExtension(extensionData);
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00026AC8 File Offset: 0x00024CC8
		public static bool HasEarlyDataIndication(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 42);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEarlyDataIndication(extensionData);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00026AEC File Offset: 0x00024CEC
		public static bool HasEncryptThenMacExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 22);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEncryptThenMacExtension(extensionData);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00026B10 File Offset: 0x00024D10
		public static bool HasExtendedMasterSecretExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 23);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadExtendedMasterSecretExtension(extensionData);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00026B34 File Offset: 0x00024D34
		public static bool HasServerNameExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 0);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadServerNameExtensionServer(extensionData);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00026B54 File Offset: 0x00024D54
		public static bool HasPostHandshakeAuthExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 49);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadPostHandshakeAuthExtension(extensionData);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00026B78 File Offset: 0x00024D78
		public static bool HasTruncatedHmacExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 4);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadTruncatedHmacExtension(extensionData);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00026B98 File Offset: 0x00024D98
		public static bool HasTrustedCAKeysExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 3);
			return extensionData != null && global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadTrustedCAKeysExtensionServer(extensionData);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00026BB8 File Offset: 0x00024DB8
		public static byte[] CreateAlpnExtensionClient(global::System.Collections.IList protocolNameList)
		{
			if (protocolNameList == null || protocolNameList.Count < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, buf);
			foreach (object obj in protocolNameList)
			{
				((global::Org.BouncyCastle.Tls.ProtocolName)obj).Encode(buf);
			}
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.PatchOpaque16(buf);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00026C34 File Offset: 0x00024E34
		public static byte[] CreateAlpnExtensionServer(global::Org.BouncyCastle.Tls.ProtocolName protocolName)
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			list.Add(protocolName);
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateAlpnExtensionClient(list);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00026C48 File Offset: 0x00024E48
		public static byte[] CreateCertificateAuthoritiesExtension(global::System.Collections.IList authorities)
		{
			if (authorities == null || authorities.Count < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, buf);
			foreach (object obj in authorities)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(((global::Org.BouncyCastle.Asn1.X509.X509Name)obj).GetEncoded("DER"), buf);
			}
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.PatchOpaque16(buf);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00026CCC File Offset: 0x00024ECC
		public static byte[] CreateCertificateTypeExtensionClient(short[] certificateTypes)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(certificateTypes) || certificateTypes.Length > 255)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(certificateTypes);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00026CEE File Offset: 0x00024EEE
		public static byte[] CreateCertificateTypeExtensionServer(short certificateType)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint8(certificateType);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00026CF6 File Offset: 0x00024EF6
		public static byte[] CreateClientCertificateUrlExtension()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00026CFD File Offset: 0x00024EFD
		public static byte[] CreateCookieExtension(byte[] cookie)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(cookie) || cookie.Length >= 65536)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeOpaque16(cookie);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00026D1F File Offset: 0x00024F1F
		public static byte[] CreateEarlyDataIndication()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00026D26 File Offset: 0x00024F26
		public static byte[] CreateEarlyDataMaxSize(long maxSize)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint32(maxSize);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00026D2E File Offset: 0x00024F2E
		public static byte[] CreateEmptyExtensionData()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00026D35 File Offset: 0x00024F35
		public static byte[] CreateEncryptThenMacExtension()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00026D3C File Offset: 0x00024F3C
		public static byte[] CreateExtendedMasterSecretExtension()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00026D44 File Offset: 0x00024F44
		public static byte[] CreateHeartbeatExtension(global::Org.BouncyCastle.Tls.HeartbeatExtension heartbeatExtension)
		{
			if (heartbeatExtension == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			heartbeatExtension.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00026D70 File Offset: 0x00024F70
		public static byte[] CreateKeyShareClientHello(global::System.Collections.IList clientShares)
		{
			if (clientShares == null || clientShares.Count < 1)
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint16(0);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, buf);
			foreach (object obj in clientShares)
			{
				((global::Org.BouncyCastle.Tls.KeyShareEntry)obj).Encode(buf);
			}
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.PatchOpaque16(buf);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00026DE8 File Offset: 0x00024FE8
		public static byte[] CreateKeyShareHelloRetryRequest(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint16(namedGroup);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00026DF0 File Offset: 0x00024FF0
		public static byte[] CreateKeyShareServerHello(global::Org.BouncyCastle.Tls.KeyShareEntry serverShare)
		{
			if (serverShare == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			serverShare.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00026E1B File Offset: 0x0002501B
		public static byte[] CreateMaxFragmentLengthExtension(short maxFragmentLength)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint8(maxFragmentLength);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00026E24 File Offset: 0x00025024
		public static byte[] CreateOidFiltersExtension(global::System.Collections.IDictionary filters)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, buf);
			if (filters != null)
			{
				foreach (object obj in filters.Keys)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier certificateExtensionOid = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj;
					byte[] certificateExtensionValues = (byte[])filters[certificateExtensionOid];
					if (certificateExtensionOid == null || certificateExtensionValues == null)
					{
						throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
					}
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(certificateExtensionOid.GetEncoded("DER"), buf);
					global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(certificateExtensionValues, buf);
				}
			}
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.PatchOpaque16(buf);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00026EC4 File Offset: 0x000250C4
		public static byte[] CreatePaddingExtension(int dataLength)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(dataLength);
			return new byte[dataLength];
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00026ED2 File Offset: 0x000250D2
		public static byte[] CreatePostHandshakeAuthExtension()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00026EDC File Offset: 0x000250DC
		public static byte[] CreatePreSharedKeyClientHello(global::Org.BouncyCastle.Tls.OfferedPsks offeredPsks)
		{
			if (offeredPsks == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			offeredPsks.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00026F07 File Offset: 0x00025107
		public static byte[] CreatePreSharedKeyServerHello(int selectedIdentity)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint16(selectedIdentity);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00026F0F File Offset: 0x0002510F
		public static byte[] CreatePskKeyExchangeModesExtension(short[] modes)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(modes) || modes.Length > 255)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(modes);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00026F31 File Offset: 0x00025131
		public static byte[] CreateRecordSizeLimitExtension(int recordSizeLimit)
		{
			if (recordSizeLimit < 64)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint16(recordSizeLimit);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00026F48 File Offset: 0x00025148
		public static byte[] CreateServerNameExtensionClient(global::System.Collections.IList serverNameList)
		{
			if (serverNameList == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			new global::Org.BouncyCastle.Tls.ServerNameList(serverNameList).Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00026F78 File Offset: 0x00025178
		public static byte[] CreateServerNameExtensionServer()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00026F80 File Offset: 0x00025180
		public static byte[] CreateSignatureAlgorithmsExtension(global::System.Collections.IList supportedSignatureAlgorithms)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.EncodeSupportedSignatureAlgorithms(supportedSignatureAlgorithms, buf);
			return buf.ToArray();
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00026FA0 File Offset: 0x000251A0
		public static byte[] CreateSignatureAlgorithmsCertExtension(global::System.Collections.IList supportedSignatureAlgorithms)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00026FA8 File Offset: 0x000251A8
		public static byte[] CreateStatusRequestExtension(global::Org.BouncyCastle.Tls.CertificateStatusRequest statusRequest)
		{
			if (statusRequest == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			statusRequest.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00026FD4 File Offset: 0x000251D4
		public static byte[] CreateStatusRequestV2Extension(global::System.Collections.IList statusRequestV2)
		{
			if (statusRequestV2 == null || statusRequestV2.Count < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, buf);
			foreach (object obj in statusRequestV2)
			{
				((global::Org.BouncyCastle.Tls.CertificateStatusRequestItemV2)obj).Encode(buf);
			}
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.PatchOpaque16(buf);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00027050 File Offset: 0x00025250
		public static byte[] CreateSupportedGroupsExtension(global::System.Collections.IList namedGroups)
		{
			if (namedGroups == null || namedGroups.Count < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			int count = namedGroups.Count;
			int[] values = new int[count];
			for (int i = 0; i < count; i++)
			{
				values[i] = (int)namedGroups[i];
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint16ArrayWithUint16Length(values);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000270A0 File Offset: 0x000252A0
		public static byte[] CreateSupportedPointFormatsExtension(short[] ecPointFormats)
		{
			if (ecPointFormats == null || !global::Org.BouncyCastle.Utilities.Arrays.Contains(ecPointFormats, 0))
			{
				ecPointFormats = global::Org.BouncyCastle.Utilities.Arrays.Prepend(ecPointFormats, 0);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(ecPointFormats);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000270C0 File Offset: 0x000252C0
		public static byte[] CreateSupportedVersionsExtensionClient(global::Org.BouncyCastle.Tls.ProtocolVersion[] versions)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(versions) || versions.Length > 127)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			int count = versions.Length;
			byte[] data = new byte[1 + count * 2];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(count * 2, data, 0);
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(versions[i], data, 1 + i * 2);
			}
			return data;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0002711A File Offset: 0x0002531A
		public static byte[] CreateSupportedVersionsExtensionServer(global::Org.BouncyCastle.Tls.ProtocolVersion selectedVersion)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeVersion(selectedVersion);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00027122 File Offset: 0x00025322
		public static byte[] CreateTruncatedHmacExtension()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002712C File Offset: 0x0002532C
		public static byte[] CreateTrustedCAKeysExtensionClient(global::System.Collections.IList trustedAuthoritiesList)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(0, buf);
			if (trustedAuthoritiesList != null)
			{
				foreach (object obj in trustedAuthoritiesList)
				{
					((global::Org.BouncyCastle.Tls.TrustedAuthority)obj).Encode(buf);
				}
			}
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.PatchOpaque16(buf);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00027194 File Offset: 0x00025394
		public static byte[] CreateTrustedCAKeysExtensionServer()
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0002719B File Offset: 0x0002539B
		private static bool ReadEmptyExtensionData(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return true;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000271B8 File Offset: 0x000253B8
		public static global::System.Collections.IList ReadAlpnExtensionClient(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf) != extensionData.Length - 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IList protocol_name_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Tls.ProtocolName protocolName = global::Org.BouncyCastle.Tls.ProtocolName.Parse(buf);
				protocol_name_list.Add(protocolName);
			}
			return protocol_name_list;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00027215 File Offset: 0x00025415
		public static global::Org.BouncyCastle.Tls.ProtocolName ReadAlpnExtensionServer(byte[] extensionData)
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadAlpnExtensionClient(extensionData);
			if (list.Count != 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return (global::Org.BouncyCastle.Tls.ProtocolName)list[0];
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002723C File Offset: 0x0002543C
		public static global::System.Collections.IList ReadCertificateAuthoritiesExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length < 5)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf) != extensionData.Length - 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IList authorities = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Asn1.Asn1Object asn = global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf, 1));
				authorities.Add(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(asn));
			}
			return authorities;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000272B2 File Offset: 0x000254B2
		public static short[] ReadCertificateTypeExtensionClient(byte[] extensionData)
		{
			short[] array = global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return array;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000272C8 File Offset: 0x000254C8
		public static short ReadCertificateTypeExtensionServer(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint8(extensionData);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000272D0 File Offset: 0x000254D0
		public static bool ReadClientCertificateUrlExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000272D8 File Offset: 0x000254D8
		public static byte[] ReadCookieExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeOpaque16(extensionData, 1);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000272E1 File Offset: 0x000254E1
		public static bool ReadEarlyDataIndication(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000272E9 File Offset: 0x000254E9
		public static long ReadEarlyDataMaxSize(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint32(extensionData);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000272F1 File Offset: 0x000254F1
		public static bool ReadEncryptThenMacExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000272F9 File Offset: 0x000254F9
		public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00027304 File Offset: 0x00025504
		public static global::Org.BouncyCastle.Tls.HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Tls.HeartbeatExtension heartbeatExtension = global::Org.BouncyCastle.Tls.HeartbeatExtension.Parse(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return heartbeatExtension;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00027334 File Offset: 0x00025534
		public static global::System.Collections.IList ReadKeyShareClientHello(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf) != extensionData.Length - 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IList clientShares = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Tls.KeyShareEntry clientShare = global::Org.BouncyCastle.Tls.KeyShareEntry.Parse(buf);
				clientShares.Add(clientShare);
			}
			return clientShares;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x00027392 File Offset: 0x00025592
		public static int ReadKeyShareHelloRetryRequest(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint16(extensionData);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0002739C File Offset: 0x0002559C
		public static global::Org.BouncyCastle.Tls.KeyShareEntry ReadKeyShareServerHello(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Tls.KeyShareEntry serverShare = global::Org.BouncyCastle.Tls.KeyShareEntry.Parse(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return serverShare;
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000273CB File Offset: 0x000255CB
		public static short ReadMaxFragmentLengthExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint8(extensionData);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000273D4 File Offset: 0x000255D4
		public static global::System.Collections.IDictionary ReadOidFiltersExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length < 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf) != extensionData.Length - 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IDictionary filters = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Asn1.DerObjectIdentifier certificateExtensionOid = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(global::Org.BouncyCastle.Tls.TlsUtilities.ReadDerObject(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(buf, 1)));
				if (filters.Contains(certificateExtensionOid))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				byte[] certificateExtensionValues = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(buf);
				filters[certificateExtensionOid] = certificateExtensionValues;
			}
			return filters;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00027463 File Offset: 0x00025663
		public static int ReadPaddingExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (!global::Org.BouncyCastle.Utilities.Arrays.AreAllZeroes(extensionData, 0, extensionData.Length))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return extensionData.Length;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002748A File Offset: 0x0002568A
		public static bool ReadPostHandshakeAuthExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00027494 File Offset: 0x00025694
		public static global::Org.BouncyCastle.Tls.OfferedPsks ReadPreSharedKeyClientHello(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Tls.OfferedPsks offeredPsks = global::Org.BouncyCastle.Tls.OfferedPsks.Parse(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return offeredPsks;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000274C3 File Offset: 0x000256C3
		public static int ReadPreSharedKeyServerHello(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint16(extensionData);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000274CB File Offset: 0x000256CB
		public static short[] ReadPskKeyExchangeModesExtension(byte[] extensionData)
		{
			short[] array = global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return array;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000274E1 File Offset: 0x000256E1
		public static int ReadRecordSizeLimitExtension(byte[] extensionData)
		{
			int num = global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint16(extensionData);
			if (num < 64)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return num;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000274F8 File Offset: 0x000256F8
		public static global::System.Collections.IList ReadServerNameExtensionClient(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Tls.ServerNameList serverNameList = global::Org.BouncyCastle.Tls.ServerNameList.Parse(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return serverNameList.ServerNames;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002752C File Offset: 0x0002572C
		public static bool ReadServerNameExtensionServer(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00027534 File Offset: 0x00025734
		public static global::System.Collections.IList ReadSignatureAlgorithmsExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::System.Collections.IList supported_signature_algorithms = global::Org.BouncyCastle.Tls.TlsUtilities.ParseSupportedSignatureAlgorithms(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return supported_signature_algorithms;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00027563 File Offset: 0x00025763
		public static global::System.Collections.IList ReadSignatureAlgorithmsCertExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadSignatureAlgorithmsExtension(extensionData);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002756C File Offset: 0x0002576C
		public static global::Org.BouncyCastle.Tls.CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Tls.CertificateStatusRequest statusRequest = global::Org.BouncyCastle.Tls.CertificateStatusRequest.Parse(memoryStream);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return statusRequest;
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002759C File Offset: 0x0002579C
		public static global::System.Collections.IList ReadStatusRequestV2Extension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length < 3)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf) != extensionData.Length - 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IList statusRequestV2 = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Tls.CertificateStatusRequestItemV2 entry = global::Org.BouncyCastle.Tls.CertificateStatusRequestItemV2.Parse(buf);
				statusRequestV2.Add(entry);
			}
			return statusRequestV2;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00027608 File Offset: 0x00025808
		public static int[] ReadSupportedGroupsExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			int length = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf);
			if (length < 2 || (length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int[] result = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16Array(length / 2, buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			return result;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00027652 File Offset: 0x00025852
		public static short[] ReadSupportedPointFormatsExtension(byte[] extensionData)
		{
			short[] array = global::Org.BouncyCastle.Tls.TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
			if (!global::Org.BouncyCastle.Utilities.Arrays.Contains(array, 0))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return array;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002766C File Offset: 0x0002586C
		public static global::Org.BouncyCastle.Tls.ProtocolVersion[] ReadSupportedVersionsExtensionClient(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length < 3 || extensionData.Length > 255 || (extensionData.Length & 1) == 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			short num = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(extensionData, 0);
			if ((int)num != extensionData.Length - 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int count = (int)(num / 2);
			global::Org.BouncyCastle.Tls.ProtocolVersion[] versions = new global::Org.BouncyCastle.Tls.ProtocolVersion[count];
			for (int i = 0; i < count; i++)
			{
				versions[i] = global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(extensionData, 1 + i * 2);
			}
			return versions;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000276E2 File Offset: 0x000258E2
		public static global::Org.BouncyCastle.Tls.ProtocolVersion ReadSupportedVersionsExtensionServer(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length != 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadVersion(extensionData, 0);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00027707 File Offset: 0x00025907
		public static bool ReadTruncatedHmacExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00027710 File Offset: 0x00025910
		public static global::System.Collections.IList ReadTrustedCAKeysExtensionClient(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length < 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(buf) != extensionData.Length - 2)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			global::System.Collections.IList trusted_authorities_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Tls.TrustedAuthority entry = global::Org.BouncyCastle.Tls.TrustedAuthority.Parse(buf);
				trusted_authorities_list.Add(entry);
			}
			return trusted_authorities_list;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002777C File Offset: 0x0002597C
		public static bool ReadTrustedCAKeysExtensionServer(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00027784 File Offset: 0x00025984
		private static byte[] PatchOpaque16(global::System.IO.MemoryStream buf)
		{
			int i = (int)buf.Length - 2;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			byte[] extensionData = buf.ToArray();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, extensionData, 0);
			return extensionData;
		}
	}
}
