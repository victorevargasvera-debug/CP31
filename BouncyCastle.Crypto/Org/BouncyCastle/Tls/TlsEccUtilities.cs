using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000108 RID: 264
	public abstract class TlsEccUtilities
	{
		// Token: 0x06000973 RID: 2419 RVA: 0x00025E2C File Offset: 0x0002402C
		public static global::Org.BouncyCastle.Tls.Crypto.TlsECConfig CreateNamedECConfig(global::Org.BouncyCastle.Tls.TlsContext context, int namedGroup)
		{
			if (global::Org.BouncyCastle.Tls.NamedGroup.GetCurveBits(namedGroup) < 1)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return new global::Org.BouncyCastle.Tls.Crypto.TlsECConfig(namedGroup);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00025E45 File Offset: 0x00024045
		public static int GetMinimumCurveBits(int cipherSuite)
		{
			if (!global::Org.BouncyCastle.Tls.TlsEccUtilities.IsEccCipherSuite(cipherSuite))
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00025E54 File Offset: 0x00024054
		public static bool IsEccCipherSuite(int cipherSuite)
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
			return keyExchangeAlgorithm - 16 <= 4 || keyExchangeAlgorithm == 24;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00025E78 File Offset: 0x00024078
		public static void CheckPointEncoding(int namedGroup, byte[] encoding)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.IsNullOrEmpty(encoding))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			if (namedGroup - 29 <= 1)
			{
				return;
			}
			switch (encoding[0])
			{
			case 4:
				return;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00025ED4 File Offset: 0x000240D4
		public static global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ReceiveECDHConfig(global::Org.BouncyCastle.Tls.TlsContext context, global::System.IO.Stream input)
		{
			if (global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint8(input) != 3)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(40);
			}
			int namedGroup = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(input);
			if (global::Org.BouncyCastle.Tls.NamedGroup.RefersToAnECDHCurve(namedGroup))
			{
				int[] clientSupportedGroups = context.SecurityParameters.ClientSupportedGroups;
				if (clientSupportedGroups == null || global::Org.BouncyCastle.Utilities.Arrays.Contains(clientSupportedGroups, namedGroup))
				{
					return new global::Org.BouncyCastle.Tls.Crypto.TlsECConfig(namedGroup);
				}
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00025F27 File Offset: 0x00024127
		public static void WriteECConfig(global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsEccUtilities.WriteNamedECParameters(ecConfig.NamedGroup, output);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00025F35 File Offset: 0x00024135
		public static void WriteNamedECParameters(int namedGroup, global::System.IO.Stream output)
		{
			if (!global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificCurve(namedGroup))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(3, output);
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(namedGroup);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(namedGroup, output);
		}
	}
}
