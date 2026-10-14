using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200007F RID: 127
	[global::System.Runtime.Serialization.DataContract]
	public class WasmDisassemblyChunk : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00007476 File Offset: 0x00005676
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x0000747E File Offset: 0x0000567E
		[global::System.Runtime.Serialization.DataMember(Name = "lines", IsRequired = true)]
		public string[] Lines { get; set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00007487 File Offset: 0x00005687
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x0000748F File Offset: 0x0000568F
		[global::System.Runtime.Serialization.DataMember(Name = "bytecodeOffsets", IsRequired = true)]
		public int[] BytecodeOffsets { get; set; }
	}
}
