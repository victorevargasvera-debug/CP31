using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000073 RID: 115
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class CamelCasePropertyNamesContractResolver : global::Newtonsoft.Json.Serialization.DefaultContractResolver
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00019634 File Offset: 0x00017834
		public CamelCasePropertyNamesContractResolver()
		{
			base.NamingStrategy = new global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy
			{
				ProcessDictionaryKeys = true,
				OverrideSpecifiedNames = true
			};
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00019658 File Offset: 0x00017858
		public override global::Newtonsoft.Json.Serialization.JsonContract ResolveContract(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type> key = new global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>(base.GetType(), type);
			global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::Newtonsoft.Json.Serialization.JsonContract> contractCache = global::Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver._contractCache;
			global::Newtonsoft.Json.Serialization.JsonContract jsonContract;
			if (contractCache == null || !contractCache.TryGetValue(key, out jsonContract))
			{
				jsonContract = this.CreateContract(type);
				object typeContractCacheLock = global::Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver.TypeContractCacheLock;
				lock (typeContractCacheLock)
				{
					contractCache = global::Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver._contractCache;
					global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::Newtonsoft.Json.Serialization.JsonContract> dictionary = (contractCache != null) ? new global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::Newtonsoft.Json.Serialization.JsonContract>(contractCache) : new global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::Newtonsoft.Json.Serialization.JsonContract>();
					dictionary[key] = jsonContract;
					global::Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver._contractCache = dictionary;
				}
			}
			return jsonContract;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000196F8 File Offset: 0x000178F8
		internal override global::Newtonsoft.Json.DefaultJsonNameTable GetNameTable()
		{
			return global::Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver.NameTable;
		}

		// Token: 0x04000210 RID: 528
		private static readonly object TypeContractCacheLock = new object();

		// Token: 0x04000211 RID: 529
		private static readonly global::Newtonsoft.Json.DefaultJsonNameTable NameTable = new global::Newtonsoft.Json.DefaultJsonNameTable();

		// Token: 0x04000212 RID: 530
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			0,
			1,
			1,
			1
		})]
		private static global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::Newtonsoft.Json.Serialization.JsonContract> _contractCache;
	}
}
