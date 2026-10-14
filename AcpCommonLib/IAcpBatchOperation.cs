using System;
using AcpCommonLib.UndoRedo;

namespace AcpCommonLib
{
	// Token: 0x02000021 RID: 33
	public interface IAcpBatchOperation
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000168 RID: 360
		// (set) Token: 0x06000169 RID: 361
		object Data { get; set; }

		// Token: 0x0600016A RID: 362
		void PreProcess(global::AcpCommonLib.UndoRedo.ContainerTask Task);

		// Token: 0x0600016B RID: 363
		void PostProcess(global::AcpCommonLib.UndoRedo.ContainerTask Task);
	}
}
