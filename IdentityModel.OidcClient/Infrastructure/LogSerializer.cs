using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IdentityModel.OidcClient.Infrastructure
{
	// Token: 0x02000029 RID: 41
	internal static class LogSerializer
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00005A28 File Offset: 0x00003C28
		static LogSerializer()
		{
			global::IdentityModel.OidcClient.Infrastructure.LogSerializer.jsonSettings.Converters.Add(new global::Newtonsoft.Json.Converters.StringEnumConverter());
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005A60 File Offset: 0x00003C60
		public static string Serialize(object logObject)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(logObject, global::IdentityModel.OidcClient.Infrastructure.LogSerializer.jsonSettings);
		}

		// Token: 0x040000C2 RID: 194
		private static readonly global::Newtonsoft.Json.JsonSerializerSettings jsonSettings = new global::Newtonsoft.Json.JsonSerializerSettings
		{
			NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore,
			DateFormatHandling = global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
			Formatting = global::Newtonsoft.Json.Formatting.Indented
		};
	}
}
