using System;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200007A RID: 122
	internal static class DbProviderServicesExtensions
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public static string GetProviderManifestTokenChecked(this global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbConnection connection)
		{
			string providerManifestToken;
			try
			{
				providerManifestToken = providerServices.GetProviderManifestToken(connection);
			}
			catch (global::System.Data.Entity.Core.ProviderIncompatibleException innerException)
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.FailedToGetProviderInformation, innerException);
			}
			return providerManifestToken;
		}
	}
}
