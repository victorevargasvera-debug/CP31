using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200038F RID: 911
	public abstract class TlsSRTPUtils
	{
		// Token: 0x060024E6 RID: 9446 RVA: 0x000A022E File Offset: 0x0009E42E
		public static void AddUseSrtpExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Crypto.Tls.UseSrtpData useSRTPData)
		{
			extensions[14] = global::Org.BouncyCastle.Crypto.Tls.TlsSRTPUtils.CreateUseSrtpExtension(useSRTPData);
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x000A0244 File Offset: 0x0009E444
		public static global::Org.BouncyCastle.Crypto.Tls.UseSrtpData GetUseSrtpExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 14);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsSRTPUtils.ReadUseSrtpExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x000A0268 File Offset: 0x0009E468
		public static byte[] CreateUseSrtpExtension(global::Org.BouncyCastle.Crypto.Tls.UseSrtpData useSrtpData)
		{
			if (useSrtpData == null)
			{
				throw new global::System.ArgumentNullException("useSrtpData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(useSrtpData.ProtectionProfiles, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(useSrtpData.Mki, buf);
			return buf.ToArray();
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000A02A8 File Offset: 0x0009E4A8
		public static global::Org.BouncyCastle.Crypto.Tls.UseSrtpData ReadUseSrtpExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, true);
			int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(buf);
			if (length < 2 || (length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int[] protectionProfiles = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16Array(length / 2, buf);
			byte[] mki = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			return new global::Org.BouncyCastle.Crypto.Tls.UseSrtpData(protectionProfiles, mki);
		}
	}
}
