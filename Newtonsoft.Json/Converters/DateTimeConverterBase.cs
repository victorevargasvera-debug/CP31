using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E3 RID: 227
	public abstract class DateTimeConverterBase : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C3E RID: 3134 RVA: 0x00031328 File Offset: 0x0002F528
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType == typeof(global::System.DateTime) || objectType == typeof(global::System.DateTime?) || (objectType == typeof(global::System.DateTimeOffset) || objectType == typeof(global::System.DateTimeOffset?));
		}
	}
}
