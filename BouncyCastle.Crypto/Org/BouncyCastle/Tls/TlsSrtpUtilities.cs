using System;
using System.Collections;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200012C RID: 300
	public abstract class TlsSrtpUtilities
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0002B886 File Offset: 0x00029A86
		public static void AddUseSrtpExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Tls.UseSrtpData useSrtpData)
		{
			extensions[14] = global::Org.BouncyCastle.Tls.TlsSrtpUtilities.CreateUseSrtpExtension(useSrtpData);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002B89C File Offset: 0x00029A9C
		public static global::Org.BouncyCastle.Tls.UseSrtpData GetUseSrtpExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Tls.TlsUtilities.GetExtensionData(extensions, 14);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Tls.TlsSrtpUtilities.ReadUseSrtpExtension(extensionData);
			}
			return null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		public static byte[] CreateUseSrtpExtension(global::Org.BouncyCastle.Tls.UseSrtpData useSrtpData)
		{
			if (useSrtpData == null)
			{
				throw new global::System.ArgumentNullException("useSrtpData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(useSrtpData.ProtectionProfiles, buf);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteOpaque8(useSrtpData.Mki, buf);
			return buf.ToArray();
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0002B900 File Offset: 0x00029B00
		public static global::Org.BouncyCastle.Tls.UseSrtpData ReadUseSrtpExtension(byte[] extensionData)
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
			int[] protectionProfiles = global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16Array(length / 2, buf);
			byte[] mki = global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque8(buf);
			global::Org.BouncyCastle.Tls.TlsProtocol.AssertEmpty(buf);
			return new global::Org.BouncyCastle.Tls.UseSrtpData(protectionProfiles, mki);
		}
	}
}
