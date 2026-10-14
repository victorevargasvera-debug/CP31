using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Controls.Schedules
{
	// Token: 0x0200000D RID: 13
	internal interface IMap<TKey, TValue> : global::System.Collections.Generic.IEnumerable<TKey>, global::System.Collections.IEnumerable
	{
		// Token: 0x1700001A RID: 26
		TValue this[TKey key]
		{
			get;
			set;
		}
	}
}
