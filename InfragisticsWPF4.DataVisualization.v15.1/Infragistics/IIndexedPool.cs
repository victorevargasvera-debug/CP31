using System;

namespace Infragistics
{
	// Token: 0x020000AA RID: 170
	public interface IIndexedPool<T> : global::Infragistics.IPool<T>
	{
		// Token: 0x170001AC RID: 428
		T this[int index]
		{
			get;
		}
	}
}
