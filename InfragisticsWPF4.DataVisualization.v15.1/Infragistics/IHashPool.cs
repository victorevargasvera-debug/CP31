using System;

namespace Infragistics
{
	// Token: 0x020000AC RID: 172
	public interface IHashPool<TKey, TValue> : global::Infragistics.IPool<TValue>
	{
		// Token: 0x170001B5 RID: 437
		TValue this[TKey key]
		{
			get;
		}
	}
}
