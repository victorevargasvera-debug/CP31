using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.Common.Cryptography.Configuration.PortBinding
{
	// Token: 0x0200001C RID: 28
	public interface IPortBindingConfiguration
	{
		// Token: 0x06000040 RID: 64
		void SetCertificateBinding(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, global::System.Net.IPEndPoint ep);
	}
}
