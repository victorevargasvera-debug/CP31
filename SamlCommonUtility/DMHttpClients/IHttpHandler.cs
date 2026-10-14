using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x02000020 RID: 32
	public interface IHttpHandler
	{
		// Token: 0x0600006D RID: 109
		global::System.Threading.Tasks.Task<T> GetResourceAsync<T>(string requestUri);

		// Token: 0x0600006E RID: 110
		global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<T>> GetResourceListAsync<T>(string requestUri);

		// Token: 0x0600006F RID: 111
		global::System.Threading.Tasks.Task PutResourceAsync(global::System.Uri requestUri, global::System.Net.Http.HttpContent httpContent);
	}
}
