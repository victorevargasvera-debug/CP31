using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200001E RID: 30
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonDictionaryAttribute : global::Newtonsoft.Json.JsonContainerAttribute
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00002F90 File Offset: 0x00001190
		public JsonDictionaryAttribute()
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002F98 File Offset: 0x00001198
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public JsonDictionaryAttribute(string id) : base(id)
		{
		}
	}
}
