using System;
using System.Collections;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F9 RID: 249
	public interface TlsClient : global::Org.BouncyCastle.Tls.TlsPeer
	{
		// Token: 0x060008ED RID: 2285
		void Init(global::Org.BouncyCastle.Tls.TlsClientContext context);

		// Token: 0x060008EE RID: 2286
		global::Org.BouncyCastle.Tls.TlsSession GetSessionToResume();

		// Token: 0x060008EF RID: 2287
		global::System.Collections.IList GetExternalPsks();

		// Token: 0x060008F0 RID: 2288
		bool IsFallback();

		// Token: 0x060008F1 RID: 2289
		global::System.Collections.IDictionary GetClientExtensions();

		// Token: 0x060008F2 RID: 2290
		global::System.Collections.IList GetEarlyKeyShareGroups();

		// Token: 0x060008F3 RID: 2291
		void NotifyServerVersion(global::Org.BouncyCastle.Tls.ProtocolVersion selectedVersion);

		// Token: 0x060008F4 RID: 2292
		void NotifySessionToResume(global::Org.BouncyCastle.Tls.TlsSession session);

		// Token: 0x060008F5 RID: 2293
		void NotifySessionID(byte[] sessionID);

		// Token: 0x060008F6 RID: 2294
		void NotifySelectedCipherSuite(int selectedCipherSuite);

		// Token: 0x060008F7 RID: 2295
		void NotifySelectedPsk(global::Org.BouncyCastle.Tls.TlsPsk selectedPsk);

		// Token: 0x060008F8 RID: 2296
		void ProcessServerExtensions(global::System.Collections.IDictionary serverExtensions);

		// Token: 0x060008F9 RID: 2297
		void ProcessServerSupplementalData(global::System.Collections.IList serverSupplementalData);

		// Token: 0x060008FA RID: 2298
		global::Org.BouncyCastle.Tls.TlsPskIdentity GetPskIdentity();

		// Token: 0x060008FB RID: 2299
		global::Org.BouncyCastle.Tls.TlsSrpIdentity GetSrpIdentity();

		// Token: 0x060008FC RID: 2300
		global::Org.BouncyCastle.Tls.TlsDHGroupVerifier GetDHGroupVerifier();

		// Token: 0x060008FD RID: 2301
		global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier GetSrpConfigVerifier();

		// Token: 0x060008FE RID: 2302
		global::Org.BouncyCastle.Tls.TlsAuthentication GetAuthentication();

		// Token: 0x060008FF RID: 2303
		global::System.Collections.IList GetClientSupplementalData();

		// Token: 0x06000900 RID: 2304
		void NotifyNewSessionTicket(global::Org.BouncyCastle.Tls.NewSessionTicket newSessionTicket);
	}
}
