using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200012B RID: 299
	public abstract class TlsSrpUtilities
	{
		// Token: 0x06000B77 RID: 2935 RVA: 0x0002B7E0 File Offset: 0x000299E0
		public static void AddSrpExtension(global::System.Collections.IDictionary extensions, byte[] identity)
		{
			extensions[12] = global::Org.BouncyCastle.Tls.TlsSrpUtilities.CreateSrpExtension(identity);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0002B7F8 File Offset: 0x000299F8
		public static byte[] GetSrpExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 12);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsSrpUtilities.ReadSrpExtension(extensionData);
			}
			return null;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0002B819 File Offset: 0x00029A19
		public static byte[] CreateSrpExtension(byte[] identity)
		{
			if (identity == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.EncodeOpaque8(identity);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0002B82C File Offset: 0x00029A2C
		public static byte[] ReadSrpExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.DecodeOpaque8(extensionData, 1);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0002B843 File Offset: 0x00029A43
		public static global::Org.BouncyCastle.Math.BigInteger ReadSrpParameter(global::System.IO.Stream input)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1));
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0002B852 File Offset: 0x00029A52
		public static void WriteSrpParameter(global::Org.BouncyCastle.Math.BigInteger x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(x), output);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0002B860 File Offset: 0x00029A60
		public static bool IsSrpCipherSuite(int cipherSuite)
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
			return keyExchangeAlgorithm - 21 <= 2;
		}
	}
}
