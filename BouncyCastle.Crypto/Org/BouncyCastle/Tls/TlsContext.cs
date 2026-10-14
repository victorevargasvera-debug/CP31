using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000FE RID: 254
	public interface TlsContext
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000925 RID: 2341
		global::Org.BouncyCastle.Tls.Crypto.TlsCrypto Crypto { get; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000926 RID: 2342
		global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator NonceGenerator { get; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000927 RID: 2343
		global::Org.BouncyCastle.Tls.SecurityParameters SecurityParameters { get; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000928 RID: 2344
		bool IsServer { get; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000929 RID: 2345
		global::Org.BouncyCastle.Tls.ProtocolVersion[] ClientSupportedVersions { get; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600092A RID: 2346
		global::Org.BouncyCastle.Tls.ProtocolVersion ClientVersion { get; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600092B RID: 2347
		global::Org.BouncyCastle.Tls.ProtocolVersion RsaPreMasterSecretVersion { get; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600092C RID: 2348
		global::Org.BouncyCastle.Tls.ProtocolVersion ServerVersion { get; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600092D RID: 2349
		global::Org.BouncyCastle.Tls.TlsSession ResumableSession { get; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600092E RID: 2350
		global::Org.BouncyCastle.Tls.TlsSession Session { get; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600092F RID: 2351
		// (set) Token: 0x06000930 RID: 2352
		object UserObject { get; set; }

		// Token: 0x06000931 RID: 2353
		byte[] ExportChannelBinding(int channelBinding);

		// Token: 0x06000932 RID: 2354
		byte[] ExportEarlyKeyingMaterial(string asciiLabel, byte[] context_value, int length);

		// Token: 0x06000933 RID: 2355
		byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length);
	}
}
