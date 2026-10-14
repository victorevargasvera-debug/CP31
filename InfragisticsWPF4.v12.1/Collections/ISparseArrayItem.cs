using System;

namespace Infragistics.Collections
{
	// Token: 0x02000013 RID: 19
	public interface ISparseArrayItem
	{
		// Token: 0x060000ED RID: 237
		object GetOwnerData(global::Infragistics.Collections.SparseArray context);

		// Token: 0x060000EE RID: 238
		void SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context);
	}
}
