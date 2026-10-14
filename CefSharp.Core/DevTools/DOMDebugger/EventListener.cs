using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.DOMDebugger
{
	// Token: 0x020002AE RID: 686
	[global::System.Runtime.Serialization.DataContract]
	public class EventListener : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0001721C File Offset: 0x0001541C
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x00017224 File Offset: 0x00015424
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		public string Type { get; set; }

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0001722D File Offset: 0x0001542D
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x00017235 File Offset: 0x00015435
		[global::System.Runtime.Serialization.DataMember(Name = "useCapture", IsRequired = true)]
		public bool UseCapture { get; set; }

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0001723E File Offset: 0x0001543E
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x00017246 File Offset: 0x00015446
		[global::System.Runtime.Serialization.DataMember(Name = "passive", IsRequired = true)]
		public bool Passive { get; set; }

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0001724F File Offset: 0x0001544F
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x00017257 File Offset: 0x00015457
		[global::System.Runtime.Serialization.DataMember(Name = "once", IsRequired = true)]
		public bool Once { get; set; }

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00017260 File Offset: 0x00015460
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x00017268 File Offset: 0x00015468
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = true)]
		public string ScriptId { get; set; }

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00017271 File Offset: 0x00015471
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x00017279 File Offset: 0x00015479
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00017282 File Offset: 0x00015482
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0001728A File Offset: 0x0001548A
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = true)]
		public int ColumnNumber { get; set; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00017293 File Offset: 0x00015493
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0001729B File Offset: 0x0001549B
		[global::System.Runtime.Serialization.DataMember(Name = "handler", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Handler { get; set; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000172A4 File Offset: 0x000154A4
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x000172AC File Offset: 0x000154AC
		[global::System.Runtime.Serialization.DataMember(Name = "originalHandler", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject OriginalHandler { get; set; }

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x000172B5 File Offset: 0x000154B5
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x000172BD File Offset: 0x000154BD
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = false)]
		public int? BackendNodeId { get; set; }
	}
}
