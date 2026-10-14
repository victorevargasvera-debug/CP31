using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200008C RID: 140
	[global::System.Runtime.Serialization.DataContract]
	public class DisassembleWasmModuleResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000795F File Offset: 0x00005B5F
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00007967 File Offset: 0x00005B67
		[global::System.Runtime.Serialization.DataMember]
		internal string streamId { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00007970 File Offset: 0x00005B70
		public string StreamId
		{
			get
			{
				return this.streamId;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00007978 File Offset: 0x00005B78
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00007980 File Offset: 0x00005B80
		[global::System.Runtime.Serialization.DataMember]
		internal int totalNumberOfLines { get; set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00007989 File Offset: 0x00005B89
		public int TotalNumberOfLines
		{
			get
			{
				return this.totalNumberOfLines;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00007991 File Offset: 0x00005B91
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00007999 File Offset: 0x00005B99
		[global::System.Runtime.Serialization.DataMember]
		internal int[] functionBodyOffsets { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000079A2 File Offset: 0x00005BA2
		public int[] FunctionBodyOffsets
		{
			get
			{
				return this.functionBodyOffsets;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000079AA File Offset: 0x00005BAA
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x000079B2 File Offset: 0x00005BB2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Debugger.WasmDisassemblyChunk chunk { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000079BB File Offset: 0x00005BBB
		public global::CefSharp.DevTools.Debugger.WasmDisassemblyChunk Chunk
		{
			get
			{
				return this.chunk;
			}
		}
	}
}
