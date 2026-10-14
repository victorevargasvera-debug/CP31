using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x02000036 RID: 54
	public interface IFastItemColumn<T> : global::System.Collections.Generic.IList<T>, global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::Infragistics.IFastItemColumnPropertyName
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002DF RID: 735
		T Minimum { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E0 RID: 736
		T Maximum { get; }
	}
}
