using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CefSharp.Web
{
	// Token: 0x020000A8 RID: 168
	public class JsonString
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x000081B7 File Offset: 0x000063B7
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x000081BF File Offset: 0x000063BF
		public string Json { get; private set; }

		// Token: 0x06000520 RID: 1312 RVA: 0x000081C8 File Offset: 0x000063C8
		public JsonString(string json)
		{
			if (json == null)
			{
				throw new global::System.ArgumentNullException("json");
			}
			this.Json = json;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000081E5 File Offset: 0x000063E5
		public override string ToString()
		{
			return this.Json;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x000081F0 File Offset: 0x000063F0
		public static global::CefSharp.Web.JsonString FromObject(object obj, global::System.Runtime.Serialization.Json.DataContractJsonSerializerSettings settings = null)
		{
			if (obj == null)
			{
				return null;
			}
			global::CefSharp.Web.JsonString result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.Runtime.Serialization.Json.DataContractJsonSerializer dataContractJsonSerializer = new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(obj.GetType(), settings);
				dataContractJsonSerializer.WriteObject(memoryStream, obj);
				string @string = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
				if (string.IsNullOrEmpty(@string))
				{
					result = null;
				}
				else
				{
					result = new global::CefSharp.Web.JsonString(@string);
				}
			}
			return result;
		}
	}
}
