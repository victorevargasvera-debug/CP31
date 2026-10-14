using System;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000361 RID: 865
	public interface TlsContext
	{
		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002326 RID: 8998
		global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator NonceRandomGenerator { get; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002327 RID: 8999
		global::Org.BouncyCastle.Security.SecureRandom SecureRandom { get; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06002328 RID: 9000
		global::Org.BouncyCastle.Crypto.Tls.SecurityParameters SecurityParameters { get; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06002329 RID: 9001
		bool IsServer { get; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600232A RID: 9002
		global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion { get; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600232B RID: 9003
		global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ServerVersion { get; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600232C RID: 9004
		global::Org.BouncyCastle.Crypto.Tls.TlsSession ResumableSession { get; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600232D RID: 9005
		// (set) Token: 0x0600232E RID: 9006
		object UserObject { get; set; }

		// Token: 0x0600232F RID: 9007
		byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length);
	}
}
