using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Database
{
	// Token: 0x02000296 RID: 662
	public class DatabaseClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001401 RID: 5121 RVA: 0x000165FC File Offset: 0x000147FC
		public DatabaseClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06001402 RID: 5122 RVA: 0x0001660B File Offset: 0x0001480B
		// (remove) Token: 0x06001403 RID: 5123 RVA: 0x0001661E File Offset: 0x0001481E
		public event global::System.EventHandler<global::CefSharp.DevTools.Database.AddDatabaseEventArgs> AddDatabase
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Database.AddDatabaseEventArgs>("Database.addDatabase", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Database.AddDatabaseEventArgs>("Database.addDatabase", value);
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x00016634 File Offset: 0x00014834
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Database.disable", parameters);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00016654 File Offset: 0x00014854
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Database.enable", parameters);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00016674 File Offset: 0x00014874
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Database.ExecuteSQLResponse> ExecuteSQLAsync(string databaseId, string query)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseId", databaseId);
			dictionary.Add("query", query);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Database.ExecuteSQLResponse>("Database.executeSQL", dictionary);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000166B0 File Offset: 0x000148B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Database.GetDatabaseTableNamesResponse> GetDatabaseTableNamesAsync(string databaseId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("databaseId", databaseId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Database.GetDatabaseTableNamesResponse>("Database.getDatabaseTableNames", dictionary);
		}

		// Token: 0x04000AC5 RID: 2757
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
