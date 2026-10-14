using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000120 RID: 288
	public enum StorageType
	{
		// Token: 0x040003FF RID: 1023
		[global::System.Runtime.Serialization.EnumMember(Value = "appcache")]
		Appcache,
		// Token: 0x04000400 RID: 1024
		[global::System.Runtime.Serialization.EnumMember(Value = "cookies")]
		Cookies,
		// Token: 0x04000401 RID: 1025
		[global::System.Runtime.Serialization.EnumMember(Value = "file_systems")]
		FileSystems,
		// Token: 0x04000402 RID: 1026
		[global::System.Runtime.Serialization.EnumMember(Value = "indexeddb")]
		Indexeddb,
		// Token: 0x04000403 RID: 1027
		[global::System.Runtime.Serialization.EnumMember(Value = "local_storage")]
		LocalStorage,
		// Token: 0x04000404 RID: 1028
		[global::System.Runtime.Serialization.EnumMember(Value = "shader_cache")]
		ShaderCache,
		// Token: 0x04000405 RID: 1029
		[global::System.Runtime.Serialization.EnumMember(Value = "websql")]
		Websql,
		// Token: 0x04000406 RID: 1030
		[global::System.Runtime.Serialization.EnumMember(Value = "service_workers")]
		ServiceWorkers,
		// Token: 0x04000407 RID: 1031
		[global::System.Runtime.Serialization.EnumMember(Value = "cache_storage")]
		CacheStorage,
		// Token: 0x04000408 RID: 1032
		[global::System.Runtime.Serialization.EnumMember(Value = "interest_groups")]
		InterestGroups,
		// Token: 0x04000409 RID: 1033
		[global::System.Runtime.Serialization.EnumMember(Value = "shared_storage")]
		SharedStorage,
		// Token: 0x0400040A RID: 1034
		[global::System.Runtime.Serialization.EnumMember(Value = "storage_buckets")]
		StorageBuckets,
		// Token: 0x0400040B RID: 1035
		[global::System.Runtime.Serialization.EnumMember(Value = "all")]
		All,
		// Token: 0x0400040C RID: 1036
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other
	}
}
