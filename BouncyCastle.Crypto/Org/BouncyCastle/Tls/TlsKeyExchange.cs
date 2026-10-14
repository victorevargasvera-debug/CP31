using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000112 RID: 274
	public interface TlsKeyExchange
	{
		// Token: 0x06000A59 RID: 2649
		void Init(global::Org.BouncyCastle.Tls.TlsContext context);

		// Token: 0x06000A5A RID: 2650
		void SkipServerCredentials();

		// Token: 0x06000A5B RID: 2651
		void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials);

		// Token: 0x06000A5C RID: 2652
		void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate);

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A5D RID: 2653
		bool RequiresServerKeyExchange { get; }

		// Token: 0x06000A5E RID: 2654
		byte[] GenerateServerKeyExchange();

		// Token: 0x06000A5F RID: 2655
		void SkipServerKeyExchange();

		// Token: 0x06000A60 RID: 2656
		void ProcessServerKeyExchange(global::System.IO.Stream input);

		// Token: 0x06000A61 RID: 2657
		short[] GetClientCertificateTypes();

		// Token: 0x06000A62 RID: 2658
		void SkipClientCredentials();

		// Token: 0x06000A63 RID: 2659
		void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials);

		// Token: 0x06000A64 RID: 2660
		void ProcessClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate);

		// Token: 0x06000A65 RID: 2661
		void GenerateClientKeyExchange(global::System.IO.Stream output);

		// Token: 0x06000A66 RID: 2662
		void ProcessClientKeyExchange(global::System.IO.Stream input);

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A67 RID: 2663
		bool RequiresCertificateVerify { get; }

		// Token: 0x06000A68 RID: 2664
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret();
	}
}
