using System;
using Microsoft.IdentityModel.Logging;
using Newtonsoft.Json;

namespace System.IdentityModel.Tokens.Jwt
{
	// Token: 0x02000006 RID: 6
	public static class JsonExtensions
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000025AD File Offset: 0x000007AD
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000025B4 File Offset: 0x000007B4
		public static global::System.IdentityModel.Tokens.Jwt.Serializer Serializer
		{
			get
			{
				return global::System.IdentityModel.Tokens.Jwt.JsonExtensions._serializer;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("value"));
				}
				global::System.IdentityModel.Tokens.Jwt.JsonExtensions._serializer = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000025CF File Offset: 0x000007CF
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000025D6 File Offset: 0x000007D6
		public static global::System.IdentityModel.Tokens.Jwt.Deserializer Deserializer
		{
			get
			{
				return global::System.IdentityModel.Tokens.Jwt.JsonExtensions._deserializer;
			}
			set
			{
				if (value == null)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentNullException("value"));
				}
				global::System.IdentityModel.Tokens.Jwt.JsonExtensions._deserializer = value;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000025F1 File Offset: 0x000007F1
		public static string SerializeToJson(object value)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.Serializer(value);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000025FE File Offset: 0x000007FE
		public static T DeserializeFromJson<T>(string jsonString) where T : class
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.Deserializer(jsonString, typeof(T)) as T;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000261F File Offset: 0x0000081F
		public static global::System.IdentityModel.Tokens.Jwt.JwtHeader DeserializeJwtHeader(string jsonString)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.Deserializer(jsonString, typeof(global::System.IdentityModel.Tokens.Jwt.JwtHeader)) as global::System.IdentityModel.Tokens.Jwt.JwtHeader;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000263B File Offset: 0x0000083B
		public static global::System.IdentityModel.Tokens.Jwt.JwtPayload DeserializeJwtPayload(string jsonString)
		{
			return global::System.IdentityModel.Tokens.Jwt.JsonExtensions.Deserializer(jsonString, typeof(global::System.IdentityModel.Tokens.Jwt.JwtPayload)) as global::System.IdentityModel.Tokens.Jwt.JwtPayload;
		}

		// Token: 0x04000007 RID: 7
		private static global::System.IdentityModel.Tokens.Jwt.Serializer _serializer = new global::System.IdentityModel.Tokens.Jwt.Serializer(global::Newtonsoft.Json.JsonConvert.SerializeObject);

		// Token: 0x04000008 RID: 8
		private static global::System.IdentityModel.Tokens.Jwt.Deserializer _deserializer = new global::System.IdentityModel.Tokens.Jwt.Deserializer(global::Newtonsoft.Json.JsonConvert.DeserializeObject);
	}
}
