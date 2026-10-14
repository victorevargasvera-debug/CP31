using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200008D RID: 141
	[global::System.Runtime.Serialization.DataContract]
	public class NextWasmDisassemblyChunkResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x000079CB File Offset: 0x00005BCB
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x000079D3 File Offset: 0x00005BD3
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Debugger.WasmDisassemblyChunk chunk { get; set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000079DC File Offset: 0x00005BDC
		public global::CefSharp.DevTools.Debugger.WasmDisassemblyChunk Chunk
		{
			get
			{
				return this.chunk;
			}
		}
	}
}
