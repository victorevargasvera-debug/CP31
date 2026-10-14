using System;
using System.ComponentModel;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace NLog.LogReceiverService
{
	// Token: 0x0200008C RID: 140
	public interface IWcfLogReceiverClient : global::System.ServiceModel.ICommunicationObject
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060008E9 RID: 2281
		// (remove) Token: 0x060008EA RID: 2282
		event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> ProcessLogMessagesCompleted;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060008EB RID: 2283
		// (remove) Token: 0x060008EC RID: 2284
		event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060008ED RID: 2285
		// (remove) Token: 0x060008EE RID: 2286
		event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060008EF RID: 2287
		global::System.ServiceModel.Description.ClientCredentials ClientCredentials { get; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060008F0 RID: 2288
		global::System.ServiceModel.IClientChannel InnerChannel { get; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060008F1 RID: 2289
		global::System.ServiceModel.Description.ServiceEndpoint Endpoint { get; }

		// Token: 0x060008F2 RID: 2290
		void OpenAsync();

		// Token: 0x060008F3 RID: 2291
		void OpenAsync(object userState);

		// Token: 0x060008F4 RID: 2292
		void CloseAsync();

		// Token: 0x060008F5 RID: 2293
		void CloseAsync(object userState);

		// Token: 0x060008F6 RID: 2294
		void ProcessLogMessagesAsync(global::NLog.LogReceiverService.NLogEvents events);

		// Token: 0x060008F7 RID: 2295
		void ProcessLogMessagesAsync(global::NLog.LogReceiverService.NLogEvents events, object userState);

		// Token: 0x060008F8 RID: 2296
		global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState);

		// Token: 0x060008F9 RID: 2297
		void EndProcessLogMessages(global::System.IAsyncResult result);

		// Token: 0x060008FA RID: 2298
		void DisplayInitializationUI();

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060008FB RID: 2299
		// (set) Token: 0x060008FC RID: 2300
		global::System.Net.CookieContainer CookieContainer { get; set; }
	}
}
