using System;
using System.Collections.Generic;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200001A RID: 26
	public interface IDMServiceAccessor
	{
		// Token: 0x06000133 RID: 307
		global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> GetAgencyIdsForUser(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAuthorizationServiceClient dmAuthSvcClient, string username);

		// Token: 0x06000134 RID: 308
		global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo> GetAgencyInfoById(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAgencyAdminServiceClient dmAgencyAdminSvcClient, global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> agencyIds, out bool lookupErrorFound);

		// Token: 0x06000135 RID: 309
		global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo GetOAuthApplicationInfo(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMIdPDiscoveryClient dmIdpDiscoverySvcClient);

		// Token: 0x06000136 RID: 310
		bool UploadMotorolaCodeplug(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMStorageServiceClient dmStorageServiceClient, string codeplugFilePath);
	}
}
