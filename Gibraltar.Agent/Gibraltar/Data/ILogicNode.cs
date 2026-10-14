using System;

namespace Gibraltar.Data
{
	// Token: 0x020000E9 RID: 233
	internal interface ILogicNode<D>
	{
		// Token: 0x060009B5 RID: 2485
		bool EvaluateNode(D dataset);

		// Token: 0x060009B6 RID: 2486
		global::Gibraltar.Data.ILogicNode<D> Clone();

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060009B7 RID: 2487
		// (set) Token: 0x060009B8 RID: 2488
		global::Gibraltar.Data.ILogicNode<D> NextOnTrue { get; set; }

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060009B9 RID: 2489
		// (set) Token: 0x060009BA RID: 2490
		global::Gibraltar.Data.ILogicNode<D> NextOnFalse { get; set; }
	}
}
