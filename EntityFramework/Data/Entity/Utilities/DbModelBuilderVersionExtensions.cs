using System;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000075 RID: 117
	internal static class DbModelBuilderVersionExtensions
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		public static double GetEdmVersion(this global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion)
		{
			switch (modelBuilderVersion)
			{
			case global::System.Data.Entity.DbModelBuilderVersion.Latest:
			case global::System.Data.Entity.DbModelBuilderVersion.V5_0:
			case global::System.Data.Entity.DbModelBuilderVersion.V6_0:
				return 3.0;
			case global::System.Data.Entity.DbModelBuilderVersion.V4_1:
			case global::System.Data.Entity.DbModelBuilderVersion.V5_0_Net4:
				return 2.0;
			default:
				throw new global::System.ArgumentOutOfRangeException("modelBuilderVersion");
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public static bool IsEF6OrHigher(this global::System.Data.Entity.DbModelBuilderVersion modelBuilderVersion)
		{
			return modelBuilderVersion >= global::System.Data.Entity.DbModelBuilderVersion.V6_0 || modelBuilderVersion == global::System.Data.Entity.DbModelBuilderVersion.Latest;
		}
	}
}
