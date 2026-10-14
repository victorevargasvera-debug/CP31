using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200038E RID: 910
	public abstract class TlsSrpUtilities
	{
		// Token: 0x060024DE RID: 9438 RVA: 0x000A0182 File Offset: 0x0009E382
		public static void AddSrpExtension(global::System.Collections.IDictionary extensions, byte[] identity)
		{
			extensions[12] = global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.CreateSrpExtension(identity);
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000A0198 File Offset: 0x0009E398
		public static byte[] GetSrpExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 12);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsSrpUtilities.ReadSrpExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000A01B9 File Offset: 0x0009E3B9
		public static byte[] CreateSrpExtension(byte[] identity)
		{
			if (identity == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeOpaque8(identity);
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000A01CC File Offset: 0x0009E3CC
		public static byte[] ReadSrpExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			byte[] identity = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return identity;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000A01FB File Offset: 0x0009E3FB
		public static global::Org.BouncyCastle.Math.BigInteger ReadSrpParameter(global::System.IO.Stream input)
		{
			return new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input));
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000A0209 File Offset: 0x0009E409
		public static void WriteSrpParameter(global::Org.BouncyCastle.Math.BigInteger x, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(x), output);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000A0217 File Offset: 0x0009E417
		public static bool IsSrpCipherSuite(int cipherSuite)
		{
			return cipherSuite - 49178 <= 8;
		}
	}
}
