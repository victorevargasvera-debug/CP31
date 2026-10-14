using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200000D RID: 13
	public interface ITransportLayerSecurity
	{
		// Token: 0x06000033 RID: 51
		void Initialize(global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> cert);

		// Token: 0x06000034 RID: 52
		void Connect(int secMode);

		// Token: 0x06000035 RID: 53
		void Accept(int secMode, global::System.Action<global::System.Security.Cryptography.X509Certificates.X509Certificate> validateClientCertificate = null);

		// Token: 0x06000036 RID: 54
		int SendData(byte[] pBuf, int len);

		// Token: 0x06000037 RID: 55
		int ReceiveData(byte[] pBuf, int len);

		// Token: 0x06000038 RID: 56
		void Uninitialize();

		// Token: 0x06000039 RID: 57
		void SetProtocolVersion(global::Motorola.Common.Communication.TLS.TlsProtocolVersion tlsProtocolVersion, bool enableOpenSslCompatibilityMode = false);
	}
}
