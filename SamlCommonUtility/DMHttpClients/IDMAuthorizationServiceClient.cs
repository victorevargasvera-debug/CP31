using System;
using System.Collections.Generic;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x0200002A RID: 42
	public interface IDMAuthorizationServiceClient
	{
		// Token: 0x06000080 RID: 128
		global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> GetAgencyIds(string requestUri);
	}
}
