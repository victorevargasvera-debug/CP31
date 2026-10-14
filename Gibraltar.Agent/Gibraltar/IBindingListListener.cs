using System;

namespace Gibraltar
{
	// Token: 0x02000162 RID: 354
	internal interface IBindingListListener<T>
	{
		// Token: 0x06000ECC RID: 3788
		void BeginUpdate();

		// Token: 0x06000ECD RID: 3789
		void EndUpdate();

		// Token: 0x06000ECE RID: 3790
		void Reset();

		// Token: 0x06000ECF RID: 3791
		void Add(T item);

		// Token: 0x06000ED0 RID: 3792
		void Change(T item);

		// Token: 0x06000ED1 RID: 3793
		void Remove(T item);
	}
}
